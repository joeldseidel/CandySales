Public Class UserPreferences
    Public backUpLocation As String
    Public restoreLocation As String
    Public colorScheme As ColorScheme
    Sub New()
        backUpLocation = Application.LocalUserAppDataPath & "/CandySales/backups"
        restoreLocation = Application.LocalUserAppDataPath & "/CandySales/backups"
        colorScheme = New ColorScheme()
    End Sub
End Class