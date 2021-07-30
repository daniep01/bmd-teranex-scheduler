Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class TeranexSchedulerForm

    Dim clientSocket As System.Net.Sockets.TcpClient
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim h As New TeranexClass



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        quickCommand()

    End Sub

    Private Sub quickCommand()

        Dim n As TreeNode
        n = Me.TreeView1.SelectedNode

        If n Is Nothing Then Exit Sub

        'log(n.Level & ":" & n.Index)

        If n.Level <= 1 Then
            log("not editable", True)
            Exit Sub
        End If

        Dim group As String = n.Parent.Text.Trim(" ")
        Dim command As Array = n.Text.Split(":")

        'log(group)
        'log(command(0))
        h.genericCommand(group & vbCrLf & command(0) & ": " & tbValue.Text)

    End Sub



    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'btnConnect.Enabled = False
    '    'readData = ""
    '    'updateLog()

    '    Try
    '        log(">>>Attempting to connect to " & tbIpAddress.Text)
    '        Cursor = Cursors.WaitCursor

    '        clientSocket = New System.Net.Sockets.TcpClient()
    '        clientSocket.Connect(tbIpAddress.Text, HyperdeckConfig.Port)

    '        serverStream = clientSocket.GetStream()



    '        'Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(TextBox3.Text)
    '        'serverStream.Write(outStream, 0, outStream.Length)
    '        'serverStream.Flush()

    '        'ctThread = New Threading.Thread(AddressOf getMessage)
    '        ' ctThread.Start()

    '        ' get notifications
    '        sendCommand("notify: transport: true", "")
    '        sendCommand("notify: slot: true", "")
    '        sendCommand("notify: remote: true", "")
    '        sendCommand("notify: configuration: true", "")

    '        ' get current state of device
    '        sendCommand("device info", "")
    '        sendCommand("slot info: slot id: 1", "")
    '        sendCommand("slot info: slot id: 2", "")
    '        sendCommand("configuration", "")
    '        sendCommand("transport info", "")

    '        ' update gui
    '        'swapEnabledButtons()
    '        'swapDropdown()
    '        'btnDisconnect.Enabled = True

    '    Catch ex As Exception
    '        log(ex.Message)

    '    Finally
    '        Cursor = Cursors.Arrow

    '    End Try


    'End Sub







    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ToolStripDateTime.Text = Now

        If eventStore.Rows.Count = 0 Then
            LabelWarning.Visible = False
            Exit Sub
        End If

        If h.connected = False Then
            LabelWarning.Visible = True
        Else
            LabelWarning.Visible = False
            For Each s As DataRow In eventStore.Rows

                If s.Item("startDateTime").ToString = Now.ToString Then

                    h.genericCommand(s.Item("group") & ":" & vbCrLf & s.Item("command") & ": " & s.Item("value"))

                End If

            Next
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Console.WriteLine("form load")
        ToolStripDateTime.Text = Now
        Timer2.Start()

        Dim key(1) As DataColumn
        Dim column As DataColumn

        column = New DataColumn
        column.ColumnName = "guid"
        column.DataType = Type.GetType("System.Guid")
        eventStore.Columns.Add(column)
        key(0) = column
        eventStore.PrimaryKey = key

        eventStore.Columns.Add("startDateTime", Type.GetType("System.String"))
        eventStore.Columns.Add("group", Type.GetType("System.String"))
        eventStore.Columns.Add("command", Type.GetType("System.String"))
        eventStore.Columns.Add("value", Type.GetType("System.String"))
        eventStore.Columns.Add("comment", Type.GetType("System.String"))

        With DataGridView1
            .AutoGenerateColumns = False
            .ColumnCount = 5
            .Columns(0).Name = "Date/Time"
            .Columns(0).DataPropertyName = "startDateTime"
            .Columns(1).Name = "Group"
            .Columns(1).DataPropertyName = "group"
            .Columns(2).Name = "Command"
            .Columns(2).DataPropertyName = "command"
            .Columns(3).Name = "Value"
            .Columns(3).DataPropertyName = "value"
            .Columns(4).Name = "Comment"
            .Columns(4).DataPropertyName = "comment"
            .DataSource = eventStore
        End With

    End Sub

    Private Sub connect()
        If h.connected = False Then
            Me.Cursor = Cursors.WaitCursor
            h.connect(tbIpAddress.Text)
            Me.Cursor = Cursors.Arrow
        Else
            log("Already connected")
        End If

        If h.connected = True Then
            StatusLabelDevice.Text = h.deviceName
            StatusLabelOnline.Text = "Connected"
            log("Connected to " & tbIpAddress.Text)
            btnAddRecording.Enabled = True
        End If
    End Sub

    Private Sub ConnectClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        connect()

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        h.shutdown()

        If h.connected = False Then
            StatusLabelOnline.Text = "Not connected"
            StatusLabelDevice.Text = "-"
            TreeView1.Nodes.Clear()
            tbValue.Text = Nothing
            LabelHelpText.Text = Nothing
            tbValue.Enabled = False
            btnSend.Enabled = False
            btnAddRecording.Enabled = False
            ScheduleForm.cbCommand.Items.Clear()
            ScheduleForm.cbGroup.Items.Clear()
            ScheduleForm.tbValue.Text = Nothing
        End If

    End Sub

    Private Sub AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecording.Click
        ScheduleForm.myShow(False)
        ScheduleForm.Activate()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim r As DialogResult = MessageBox.Show("Are you sure? Scheduled events will not run if this application is closed.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If


        My.Settings.deviceIp = tbIpAddress.Text

        My.Settings.Save()
        Console.WriteLine(Now & " save settings")

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim serializer As New BinaryFormatter()
        Dim savepath As String
        savepath = Path.Combine(Application.LocalUserAppDataPath, "events.bin")
        Dim myfilestream As Stream = File.Create(savepath)
        serializer.Serialize(myfilestream, eventStore)
        myfilestream.Close()
        log("Schedule saved") ' & savepath)
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Dim loadpath As String
        loadpath = Path.Combine(Application.LocalUserAppDataPath, "events.bin")
        If File.Exists(loadpath) Then

            Dim myfilestream As Stream = File.OpenRead(loadpath)
            Dim deserializer As New BinaryFormatter()
            '  eventStore = CType(deserializer.Deserialize(myfilestream), List(Of ScheduleEventClass))
            myfilestream.Close()

            log("Schedule loaded, " & eventStore.Rows.Count & " events")


            DataGridView1.Refresh()
        Else
            log("Error:File not found")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        h.ping()
    End Sub

    Private Sub RemoveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAllToolStripMenuItem.Click
        Dim result1 As Integer = MessageBox.Show("Remove all events?", Application.ProductName.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result1 = DialogResult.Yes Then
            eventStore.Rows.Clear()
            log("clear all rows", True)
            log(eventStore.Rows.Count & " events", True)
        End If
    End Sub


    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        AboutBox1.Show()
    End Sub

    Private Sub tbIpAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIpAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            connect()
        End If
    End Sub
    Private Sub tbValue_KeyDown(sender As Object, e As KeyEventArgs) Handles tbValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            quickCommand()
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        ' only allow level 2 to be editable
        If e.Node.Level <= 1 Then
            btnSend.Enabled = False
            tbValue.Enabled = False
            tbValue.Text = Nothing
            LabelHelpText.Text = Nothing
        Else
            btnSend.Enabled = True
            tbValue.Enabled = True
            tbValue.Text = getValue(e.Node.Text)

            If h.commandList.ContainsKey(getCommand(e.Node.Text)) Then
                LabelHelpText.Text = h.commandList.Item(getCommand(e.Node.Text))
            Else
                LabelHelpText.Text = Nothing
            End If
            'Label2.Text = h.commandList.f e.Node.Parent.Text & " " & e.Node.Text

        End If

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click

        Try
            Dim guidToRemove As Guid = getSelectedRowGuid()

            Dim r As DataRow = eventStore.Rows.Find(guidToRemove)
            log("Remove: " & r.Item("startDateTime").ToString)
            r.Delete()

            log("removed item: " & guidToRemove.ToString, True)
            log("total events:  " & eventStore.Rows.Count, True)
        Catch err As Exception
            log(err.Message, True)
        End Try


    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        Try
            Dim guidToEdit As Guid = getSelectedRowGuid()
            Dim r As DataRow = eventStore.Rows.Find(guidToEdit)
            log("Edit item: " & r.Item("guid").ToString)

            With ScheduleForm
                .DateTimePickerStart.Value = r.Item("startDateTime")
                .tbValue.Text = r.Item("value")
                .cbGroup.SelectedText = r.Item("group")
                .cbCommand.SelectedText = r.Item("command")
                .tbComment.Text = r.Item("comment")
                .myShow(True)
            End With
        Catch err As Exception
            log(err.Message, True)
        End Try


    End Sub

    Function getSelectedRowGuid() As Guid

        If DataGridView1.SelectedRows.Count > 0 Then

            For Each r As DataGridViewRow In DataGridView1.SelectedRows
                If Not r.IsNewRow Then

                    Dim guid As Guid = r.DataBoundItem("guid")
                    log("selected row guid: " & guid.ToString, True)
                    Return guid

                End If
            Next

        End If

    End Function


End Class
