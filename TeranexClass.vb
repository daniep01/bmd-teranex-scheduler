Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Globalization

Enum TeranexConfig
    Port = 9800
End Enum



Public Class TeranexClass

    Dim syncsender As Socket

    Property connected As Boolean = False
    Property deviceName As String = Nothing
    Property commandList As New Dictionary(Of String, String)
    Property readOnlyGroup As New List(Of String)

    Public Sub New()

        commandList.Add("Version", "Read only")
        commandList.Add("Model name", "Read only")
        commandList.Add("CC enabled", "Enable Closed Caption processing. True=ON; False=OFF; Default = False")
        commandList.Add("CC input line", "Analog CC input line selection. Range is 20 to 22. Default = 21")
        commandList.Add("CC output line", "Analog CC output line selection. Range is 20 to 22. Default = 21")

        commandList.Add("AudioOut0", "Select source to be mapped to output Ch 1. Available inputs: AudioIn1 through AudioIn16; AudioDD1 through AudioDD8; TT750, TT1500, TT3000, TT6000, TTMute")

        readOnlyGroup.Add("PROTOCOL PREAMBLE:")
        readOnlyGroup.Add("TERANEX DEVICE:")

    End Sub

    Public Sub connect(ByVal address As String)
        Try
            Dim ipAddress As IPAddress = IPAddress.Parse(address)
            Dim remoteEP As New IPEndPoint(ipAddress, TeranexConfig.Port)

            syncsender = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            syncsender.SendTimeout = 10

            ' establish connection 
            syncsender.Connect(remoteEP)
            parseStatusBlock(syncsendreceive(vbCrLf))


            Me.connected = True
        Catch ex As Exception
            log(ex.Message)
        End Try

    End Sub

    Function syncsendreceive(ByVal command As String, Optional waitTime As Integer = 100)

        ' check
        If syncsender Is Nothing Then
            log("Not connected")
            Return False
            Exit Function
        End If

        ' wait cursor
        TeranexSchedulerForm.Cursor = Cursors.WaitCursor

        Try

            ' send
            log("Send > " & command)
            Dim msg As Byte() = Encoding.ASCII.GetBytes(command & vbCrLf)
            Dim bytessent As Integer = syncsender.Send(msg)

            Threading.Thread.Sleep(waitTime)

            ' recieve
            Dim bytes(8192) As Byte
            Dim response As String = Nothing

            Dim bytesRec As Integer = syncsender.Receive(bytes)
            If bytesRec > 0 Then
                response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                log(response, True)
            End If
            log(bytesRec & "bytes", True)



            Return response
        Catch ex As Exception
            log(ex.Message)

        Finally
            TeranexSchedulerForm.Cursor = Cursors.Arrow
        End Try

    End Function

    Public Sub shutdown()

        If syncsender Is Nothing Then
            log("Not started, unable to disconnet")
            Exit Sub
        End If


        If syncsender.Connected = False Then
            log("Not connected, unable to disconnect")
            Exit Sub
        End If

        'syncsendreceive("quit")
        syncsender.Shutdown(SocketShutdown.Both)
        syncsender.Close()
        syncsender = Nothing
        Me.connected = False
        Me.deviceName = Nothing

        log("Connection closed")

    End Sub

    Public Sub genericCommand(ByVal command As String)

        log(command, True)
        msgparse(syncsendreceive(command & vbCrLf))

    End Sub

    Public Sub ping()

        syncsendreceive("ping")

    End Sub

    Sub msgparse(ByVal msg As String)

        If IsNothing(msg) Then
            log("Error: no message returned")
        ElseIf msg.Contains("ACK") = True
            log("Device returned ACK OK")
        ElseIf msg.Contains("NAK") = True
            log("Warning: Device returned NAK")
        Else
            log(msg, True)
        End If

    End Sub

    Private Function decodeMessageBlock(ByVal message As String)
        Dim slotinfoarray() As String = Split(message, vbCrLf)
        Dim MessageBlock As New Dictionary(Of String, String)
        Dim emptyLine As Boolean = False

        For Each item As String In slotinfoarray

            Debug.Print(">" & item)

            If item.Contains(":") Then
                ' split into 2 pieces at colon
                Dim lineArray() As String = Split(item, ":", 2)
                MessageBlock.Add(lineArray(0).Trim, lineArray(1).Trim)
            End If

            'If item = "" Then emptyLine = True

        Next

        For Each pair As KeyValuePair(Of String, String) In MessageBlock
            Console.WriteLine(pair.Key & "->" & pair.Value)
        Next

        Debug.Print(MessageBlock.Count & "lines returned")

        'If emptyLine = False Then log("warning: message block incomplete!")

        Return MessageBlock

    End Function

    Private Function parseStatusBlock(ByVal block As String)

        Dim blockLines As Array = Nothing
        Dim line As String
        blockLines = block.Split(vbLf)
        TeranexSchedulerForm.TreeView1.Nodes.Clear()
        ScheduleForm.cbGroup.Items.Clear()
        Dim root As New TreeNode("Teranex")
        Dim grp As Integer = -1
        TeranexSchedulerForm.TreeView1.Nodes.Add(root)

        For Each line In blockLines

            If line.Length > 0 Then

                If line.EndsWith(":") Then
                    ' group
                    TeranexSchedulerForm.TreeView1.Nodes(0).Nodes.Add(New TreeNode(line.TrimEnd(":")))

                    If readOnlyGroup.Contains(line) Then
                        ' do nothing
                    Else
                        ScheduleForm.cbGroup.Items.Add(line.TrimEnd(":"))
                    End If

                    grp = grp + 1

                Else
                    ' command
                    TeranexSchedulerForm.TreeView1.Nodes(0).Nodes(grp).Nodes.Add(New TreeNode(line))
                    If line.Contains("Model name:") Then
                        deviceName = getValue(line)
                    End If
                End If

            End If

        Next

        TeranexSchedulerForm.TreeView1.TopNode.Expand()
        ScheduleForm.cbGroup.SelectedIndex = 0
        ScheduleForm.cbCommand.SelectedIndex = 0
        Return True

    End Function

End Class

