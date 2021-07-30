Module misc

    ' Public eventList As New List(Of ScheduleEventClass)
    Public eventStore As New DataTable

    Public Sub log(ByVal text As String, Optional debug As Boolean = False)

        If debug = True And TeranexSchedulerForm.CheckBox1.Checked = False Then Exit Sub

        text = text.Replace(vbCrLf, ">")
        text = text.Replace(vbLf, ">")

        With TeranexSchedulerForm.tbLog
            .AppendText(vbCrLf)
            .AppendText(Now() & " " & text)
            .Select(.TextLength, 0)
            .ScrollToCaret()
        End With

    End Sub

    Public Function getValue(data As String)

        If data.Contains(":") = True Then
            Dim t = data.Split(":")
            Return t(1).Trim(" ")
        Else
            Return data
        End If

    End Function

    Public Function getCommand(data As String)

        If data.Contains(":") = True Then
            Dim t = data.Split(":")
            Return t(0).Trim(" ")
        Else
            Return data
        End If

    End Function
End Module

