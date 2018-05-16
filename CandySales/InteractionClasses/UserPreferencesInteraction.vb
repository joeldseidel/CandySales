Option Strict On
Imports System.IO
Public Class UserPreferencesInteraction
    Private encryptionProvider As EncryptionInteraction
    Private database As New DatabaseInteraction
    Public Property userPreferences As UserPreferences
    Sub New()
        encryptionProvider = New EncryptionInteraction(EncryptionInteraction.masterKey)
        GetPreferences()
    End Sub
    Private Sub GetPreferences()
        Dim localStorageLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales"
        Dim preferencesLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\userPrefs.candy"
        Dim userPrefs As New UserPreferences
        If Not File.Exists(preferencesLocation) Then
            CreatePreferences()
        End If
        Dim localStorageAuthentic As Boolean = isLocalStorageAuthentic(localStorageLocation)
        If Not localStorageAuthentic Then
            CreatePreferences()
            GetPreferences()
        End If
        Dim deserializationAgent As New DeserializeData
        Dim loadedUserPrefs As UserPreferences = DirectCast(deserializationAgent.LoadData(preferencesLocation), UserPreferences)
        userPreferences = loadedUserPrefs
    End Sub
    Private Sub CreatePreferences()
        Dim preferencesLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales"
        Directory.CreateDirectory(preferencesLocation)
        Dim authenticationFileLocation As String = preferencesLocation & "\authPack.bin"
        Dim authenticationFileStream As FileStream = Nothing
        Try
            If File.Exists(authenticationFileLocation) Then
                File.Delete(authenticationFileLocation)
            End If
            authenticationFileStream = New FileStream(authenticationFileLocation, FileMode.CreateNew)
        Catch ex As Exception
            Return
        End Try
        Dim authenticationFileWriter As StreamWriter = Nothing
        Try
            authenticationFileWriter = New StreamWriter(authenticationFileStream)
            Dim encryptedMasterKey As String = encryptionProvider.EncryptData(EncryptionInteraction.masterKey)
            authenticationFileWriter.Write(encryptedMasterKey)
        Catch ex As Exception
        Finally
            authenticationFileWriter.Close()
        End Try
        Dim userPreferencesObject As New UserPreferences
        Dim serializationAgent As New SerializeData
        serializationAgent.SaveData(preferencesLocation & "\userPrefs", userPreferencesObject)
    End Sub
    Private Sub UpdatePreferences()

    End Sub
    Private Function isLocalStorageAuthentic(localDataPath As String) As Boolean
        Dim authenticationFilePath As String = localDataPath & "\authPack.bin"
        If Not Directory.Exists(localDataPath) Then
            Return False
        End If
        Dim importedAuthenticationKey As String = ""
        Dim authenticationFileStream As FileStream = Nothing
        Try
            authenticationFileStream = New FileStream(authenticationFilePath, FileMode.Open)
        Catch ex As Exception
            Return False
        End Try
        Dim authenticationFileReader As New StreamReader(authenticationFileStream)
        Try
            importedAuthenticationKey = authenticationFileReader.ReadToEnd().ToString
        Catch ex As Exception
            Return False
        Finally
            authenticationFileReader.Close()
        End Try
        Dim decryptedAuthenticationKey As String = encryptionProvider.DecryptData(importedAuthenticationKey)
        'The decrypted key needs to match the master key
        If decryptedAuthenticationKey = EncryptionInteraction.masterKey Then
            Return True
        Else
            Return False
        End If
    End Function
End Class