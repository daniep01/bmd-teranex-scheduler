Public Class ScheduleForm

    Public Sub myShow(edit As Boolean)
        log("myshow, edit=" & edit)
        If edit = True Then
            GroupBox1.Text = "Edit event"
        Else
            GroupBox1.Text = "Add a new event"
        End If
        Me.Show()

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentDate As Date = Now().Date
        DateTimePickerStart.Value = currentDate & " 12:00:00"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        addevent()
        DateTimePickerStart.Focus()
    End Sub

    Public Function addevent()

        If cbGroup.Text.Length = 0 Then
            MsgBox("A group is required.", vbInformation)
            Return False
        End If

        If cbCommand.Text.Length = 0 Then
            MsgBox("A command is required.", vbInformation)
            Return False
        End If

        'For Each scheditem In eventStore
        '    If scheditem.StartDateTime.ToString = DateTimePickerStart.Value.ToString Then
        '        MsgBox("Event already exists with this start date/time! Duplicates not allowed.", vbInformation)
        '        Return False
        '        Exit Function
        '    End If
        'Next

        Dim g As Guid = System.Guid.NewGuid

        Dim s As DataRow = eventStore.NewRow
        s("guid") = g
        s("startDateTime") = DateTimePickerStart.Value
        s("group") = cbGroup.Text
        s("command") = cbCommand.Text
        s("value") = tbValue.Text
        s("comment") = tbComment.Text

        eventStore.Rows.Add(s)

        log(eventStore.Rows.Count & " events total", True)

        Return True ' success

    End Function

    Private Sub btnAddClose_Click_1(sender As Object, e As EventArgs) Handles btnAddClose.Click
        If addevent() = True Then Me.Hide()
    End Sub

    Private Sub cbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroup.SelectedIndexChanged

        cbCommand.Items.Clear()
        fillCommandList()
        cbCommand.SelectedIndex = 0

    End Sub

    Public Sub fillCommandList()

        For Each n As TreeNode In TeranexSchedulerForm.TreeView1.Nodes
            log(n.Text)
            For Each q As TreeNode In n.Nodes

                log(q.Text)
                If q.Text = cbGroup.Text Then

                    For Each i In q.Nodes
                        cbCommand.Items.Add(getCommand(i.text))

                        log(i.text, True)
                    Next
                    Exit For

                End If

            Next
        Next


    End Sub

End Class