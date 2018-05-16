Public Class frmCreateDefaultAdmin
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim username As String = txtUsername.Text
        If username.Contains("'") Or username.Contains(",") Then
            MsgBox("Username cannot contain ' or ," & Environment.NewLine & "Please select a different username", MessageBoxButtons.OK, "Username Invalid")
            Return
        End If
        Dim password As String = txtPassword.Text
        If password.Contains("'") Or password.Contains(",") Then
            MsgBox("Password cannot contain ' or ," & Environment.NewLine & "Please select a different password", MessageBoxButtons.OK, "Password Invalid")
            Return
        End If
        Dim thisAdministratorAccount As New Administrator(username, password)
        thisAdministratorAccount.CreateNew()
        MsgBox("Administrator successfully created!", , "Admin Creation Success")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class