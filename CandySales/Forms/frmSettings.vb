Public Class frmSettings
    Private loadedUserPreferences As UserPreferences = Nothing
    Private preferences As UserPreferencesInteraction = Nothing
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preferences = New UserPreferencesInteraction
        loadedUserPreferences = preferences.userPreferences
        ApplyLoadedDefaultsSettings()
    End Sub
    Private Sub ApplyLoadedDefaultsSettings()
        txtDefaultBackup.Text = loadedUserPreferences.backUpLocation
        txtDefaultRestoration.Text = loadedUserPreferences.restoreLocation
        pnlPrimaryColor.BackColor = loadedUserPreferences.colorScheme.primaryColor
        pnlSecondaryColor.BackColor = loadedUserPreferences.colorScheme.secondaryColor
    End Sub
    Private Sub chkAutoBackup_CheckStateChanged(sender As Object, e As EventArgs) Handles chkAutoBackup.CheckStateChanged
        Dim autoBackupEnabled As Boolean = chkAutoBackup.Checked
        If autoBackupEnabled Then btnAutoBackupSettings.Visible = autoBackupEnabled Else btnAutoBackupSettings.Visible = Not True '<-- I can use nots whenever I want
    End Sub
    Private Sub pnlPrimaryColor_Click(sender As Object, e As EventArgs) Handles pnlPrimaryColor.Click
        Dim primaryColorDialogResult As DialogResult = cdlgColorScheme.ShowDialog()
        Dim newPrimaryColor As Color = Nothing
        If primaryColorDialogResult = DialogResult.OK Then
            newPrimaryColor = cdlgColorScheme.Color
            pnlPrimaryColor.BackColor = newPrimaryColor
        Else
            Return
        End If
    End Sub
    Private Sub pnlSecondaryColor_Click(sender As Object, e As EventArgs) Handles pnlSecondaryColor.Click
        Dim secondaryColorDialogResult As DialogResult = cdlgColorScheme.ShowDialog()
        Dim newSecondaryColor As Color = Nothing
        If secondaryColorDialogResult = DialogResult.OK Then
            newSecondaryColor = cdlgColorScheme.Color
            pnlSecondaryColor.BackColor = newSecondaryColor
        Else
            Return
        End If
    End Sub
End Class