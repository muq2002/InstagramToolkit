Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        ListPasswords.Enabled = False
    End Sub

    Private Sub CloseBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBTN.Click
        Me.Hide()
    End Sub

    Private Sub AddBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBTN.Click
        If Username.Text <> "" And Password.Text <> "" Then
            For L = 0 To (ListUsers.Items.Count) - 1
                ListUsers.SetSelected(L, True)
                If Username.Text = ListUsers.SelectedItem Then
                    MsgBox("This is found on this list")
                    Exit Sub
                End If
            Next L
            ListUsers.Items.Add(Username.Text)
            ListPasswords.Items.Add(Password.Text)
        End If
    End Sub

    Private Sub ListUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListUsers.SelectedIndexChanged
        On Error Resume Next
        ListPasswords.SetSelected(ListUsers.SelectedIndex, True)
    End Sub

    Private Sub RemoveBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBTN.Click
        ListPasswords.Items.RemoveAt(ListUsers.SelectedIndex)
        ListUsers.Items.RemoveAt(ListUsers.SelectedIndex)
    End Sub

    Private Sub StartBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBTN.Click
        Dim User, Pass As String
        For L = 0 To (ListUsers.Items.Count) - 1
            ' Username
            ListUsers.SetSelected(L, True)
            User = ListUsers.SelectedItem
            ' Password
            ListPasswords.SetSelected(L, True)
            Pass = ListPasswords.SelectedItem

        Next L
    End Sub
End Class