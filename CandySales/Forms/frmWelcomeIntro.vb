Public Class frmWelcomeIntro
    Private Sub frmWelcomeIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim localDatabase As New LocalDatabase
        If localDatabase.isExist Then
            frmLogin.Show()
            btnLaunchLogin.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub btnSetupStorageDrivers_Click(sender As Object, e As EventArgs) Handles btnSetupStorageDrivers.Click
        Dim localDatabase As New LocalDatabase
        localDatabase.Initialize()
        ShowStepCompleted(btnSetupStorageDrivers)
    End Sub
    Private Sub btnImportStudents_Click(sender As Object, e As EventArgs) Handles btnImportStudents.Click
        frmImportStudents.Show()
        ShowStepCompleted(btnImportStudents)
    End Sub
    Private Sub btnSetupAdmin_Click(sender As Object, e As EventArgs) Handles btnSetupAdmin.Click
        frmCreateDefaultAdmin.Show()
        ShowStepCompleted(btnSetupAdmin)
    End Sub
    Private Sub btnSetupProduct_Click(sender As Object, e As EventArgs) Handles btnSetupProduct.Click
        frmCreateProduct.Show()
        ShowStepCompleted(btnSetupProduct)
        btnLaunchLogin.Enabled = True
    End Sub
    Public Sub ShowStepCompleted(completedStepButton As Button)
        completedStepButton.Enabled = False
        completedStepButton.Text = "Step Completed!"
    End Sub

    Private Sub btnLaunchLogin_Click(sender As Object, e As EventArgs) Handles btnLaunchLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub
    Private Sub frmWelcomeIntro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not btnLaunchLogin.Enabled Then
            Dim confirmExitWithoutCompletion As DialogResult = MessageBox.Show("Exiting now will not save any changes", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If confirmExitWithoutCompletion <> DialogResult.OK Then
                e.Cancel = True
                Dim localDatabase As New LocalDatabase
                localDatabase.Reset()
            End If
        End If
    End Sub
End Class