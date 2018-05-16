Option Strict On
Imports System.IO
Public MustInherit Class BackupInteraction
    'Serves the needs of both the backup and restore classes
    Public location, backUpDateTime As String
    Public tables As List(Of String)
    Protected database As New DatabaseInteraction
    Protected Function CreateBackUpDirectory() As String
        'Set up the directory and the file for the backup
        Dim directoryPathToCreate As String = location & "/CandySalesBackup" & backUpDateTime
        'Create the directory the backup will go into
        Dim isDirectoryUnique As Boolean = False
        'Check if the user has backed up today, or at least has a backup directory with the same name
        If Directory.Exists(directoryPathToCreate) Then
            'The user has already backed up today
            'Decide if the user wants to update the previous update or create a new folder that has a name that is incremented one more than the previous backup folder
            Dim shouldUpdateBackupResult As DialogResult = dlgUpdateBackup.ShowDialog()
            'Get the dialog result and decide what to do
            If shouldUpdateBackupResult = DialogResult.OK Then
                'The user wants to update their backup
                'Delete the previously created backup directory and its contents
                Directory.Delete(directoryPathToCreate, True)
                'Create the new directory for the current update to be stored in with the same name
                Directory.CreateDirectory(directoryPathToCreate)
            Else
                'The user wants to make a new file with a name incremented one from the previous backup
                Dim forceUniqueCounter As Integer = 1
                Dim uniqueDirectoryPath As String = directoryPathToCreate
                While Directory.Exists(uniqueDirectoryPath)
                    'The directory already exists, the name needed to be incremented by one
                    uniqueDirectoryPath = directoryPathToCreate
                    'Concatenate the counter to the directory path
                    uniqueDirectoryPath &= forceUniqueCounter.ToString()
                    'Increment the path counter for a possible unique name
                    forceUniqueCounter += 1
                End While
                'Create the new (unique) directory
                Directory.CreateDirectory(uniqueDirectoryPath)
                directoryPathToCreate = uniqueDirectoryPath
            End If
        Else
            'This is a new backup, no interaction with previously backed up directories/files necessary.
            Directory.CreateDirectory(directoryPathToCreate)
        End If
        Return directoryPathToCreate
    End Function
    Protected Function CreateBackUpFile(fullLocation As String, table As String) As String
        Dim backUpFilePath As String = fullLocation & "\" & table & ".candy"
        'Create the filestream to create the new file
        Dim backUpFileStream As New FileStream(backUpFilePath, FileMode.Create)
        backUpFileStream.Close()
        Return backUpFilePath
    End Function
    Public Function IsBackUpDirectory(restoreLocation As String) As Boolean
        'Get the directory information and decide if the selected folder contains the backup files or not
        'Get the file system information on the selected directory
        Dim selectedDirectory As New DirectoryInfo(restoreLocation)
        'Get the files from the directory information if they have a .candy extension
        Dim filesInDirectory As FileInfo() = selectedDirectory.GetFiles("*.candy")
        'Test for the amount of .candy files in a specific folder
        If filesInDirectory.Count = 0 Then
            'This is not a backup directory
            Return False
        Else
            'This is a backup directory
            Return True
        End If
    End Function
End Class