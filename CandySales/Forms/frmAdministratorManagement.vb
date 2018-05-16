Public Class frmAdministratorManagement
    Private database As New DatabaseInteraction
    Private Sub frmAdministratorManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the administrator sidebar listbox
        PopulateCurrentAdministrator()
    End Sub
    Private Sub PopulateCurrentAdministrator()
        'Sub to get all admin usernames from the database and display to listbox
        lstCurrentAdmin.Items.Clear()
        cboAdmin.Text = ""
        cboAdmin.Items.Clear()
        'Get all admin from the database
        Dim getAllAdminSql As String = "SELECT * FROM AdminLogins"
        Dim allAdmin As DataTable = database.Query(getAllAdminSql)
        'Create admin object and set username to listbox
        For Each adminRecord As DataRow In allAdmin.Rows
            'Instantiate admin object
            Dim thisAdmin As New Administrator(adminRecord)
            'Set username to listbox
            lstCurrentAdmin.Items.Add(thisAdmin.username)
            cboAdmin.Items.Add(thisAdmin.username)
        Next
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Validate username and password input
        If Not IsNewAdminInputValid(txtNewUsername.Text, txtNewPassword.Text, txtNewConfirmPass.Text) Then
            'Input for creation is incorrect
            Return
        End If
        'Get entry data from the form
        Dim username, password As String
        username = txtNewUsername.Text
        password = txtNewPassword.Text
        'Confirm intent to create new admin
        Dim confirmationDialog As DialogResult = MessageBox.Show("Are you sure that you want to create this new admin?", "Confirm Creation", MessageBoxButtons.OKCancel)
        If confirmationDialog = DialogResult.Cancel Then
            'User does not actually want to do this. Good. They weren't worthy of becoming an admin anyways.....
            ResetForm()
            Return
        End If
        'Write admin record to the database
        Dim newAdministrator As New Administrator(username, password)
        newAdministrator.CreateNew()
        'Repopulate the listbox to reflect changes
        ResetForm()
    End Sub

    Private Function IsNewAdminInputValid(username As String, password As String, confirmationPass As String)
        If username = "" Or password = "" Or confirmationPass = "" Then
            MsgBox("You cannot leave any fields blank", MsgBoxStyle.OkOnly, "Input Error")
            Return False
        End If
        If confirmationPass <> password Then
            'The password could not be confirmed because they do not match
            MsgBox("Your password entries do not match", MsgBoxStyle.OkOnly, "Password Confirmation")
            Return False
        End If
        Return True
    End Function

    Private Sub ResetForm()
        'Reset form back to its default state
        txtNewUsername.Clear()
        txtNewPassword.Clear()
        txtNewConfirmPass.Clear()
        PopulateCurrentAdministrator()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnCancelRevoke.Click
        'Close the form and remove all changes
        Me.Close()
    End Sub

    Private Sub cboAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAdmin.SelectedIndexChanged
        If cboAdmin.SelectedIndex = -1 Then
            'Nothing is selected
            lblTransactionCount.Visible = False
            Return
        Else
            lblTransactionCount.Visible = True
        End If
        Dim adminUsername As String = cboAdmin.SelectedItem.ToString
        'Get the admin information from the database regarding the selected administrator
        Dim getAdmin As String = "SELECT * FROM AdminLogins WHERE Username='" & adminUsername & "'"
        Dim thisAdminTable As DataTable = database.Query(getAdmin)
        Dim thisAdmin As New Administrator(thisAdminTable.Rows(0))
        Dim transactionCount As Integer = thisAdmin.GetTransactionCount()
        lblTransactionCount.Text = "Transaction Completed: " & transactionCount.ToString()
        'Select the admin on the listbox
        For adminIndex As Integer = 0 To lstCurrentAdmin.Items.Count - 1
            If lstCurrentAdmin.Items(adminIndex).ToString = thisAdmin.username Then
                'The current listbox item contains the name of the admin we have selected, set as the selected index
                lstCurrentAdmin.SelectedIndex = adminIndex
                Exit For
            End If
        Next
    End Sub

    Private Sub btnRevoke_Click(sender As Object, e As EventArgs) Handles btnRevoke.Click
        'Revoke admin privileges from the selected administrator
        If cboAdmin.SelectedIndex = -1 Then
            'No administrator has been selected
            MsgBox("You must select an administrator to revoke access from", MsgBoxStyle.OkOnly, "Missing Admin")
            Return
        End If
        'Confirm intent to delete this admin
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure that you want to revoke the administrator access for this user?" & Environment.NewLine & "These changes will be enacted next time the user attempts to login", "Confirm Revoke", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.No Then
            'The user backed out or didnt actually want to do it in the first place. Someone must have saved their job. Good for them.
            Return
        End If
        Dim adminUsername As String = cboAdmin.SelectedItem.ToString
        'Create admin object
        Dim getAdmin As String = "SELECT * FROM AdminLogins WHERE Username='" & adminUsername & "'"
        Dim thisAdminTable As DataTable = database.Query(getAdmin)
        Dim thisAdmin As New Administrator(thisAdminTable.Rows(0))
        thisAdmin.Remove()
        ResetForm()
    End Sub

    Private Sub tbpDeleteAdmin_Enter(sender As Object, e As EventArgs) Handles tbpDeleteAdmin.Enter
        'Change the accept button because the tab page has changed
        Me.AcceptButton = btnRevoke
    End Sub

    Private Sub tbpNewAdmin_Enter(sender As Object, e As EventArgs) Handles tbpNewAdmin.Enter
        'Change the accept button because the tab page has changed
        Me.AcceptButton = btnCreate
    End Sub

    Private Sub lstCurrentAdmin_DoubleClick(sender As Object, e As EventArgs) Handles lstCurrentAdmin.DoubleClick
        If lstCurrentAdmin.SelectedIndex <> -1 Then
            tbcAdminControl.SelectedTab = tbpDeleteAdmin
            cboAdmin.SelectedIndex = cboAdmin.Items.IndexOf(lstCurrentAdmin.SelectedItem.ToString())
        End If
    End Sub
End Class