Imports System.IO
Public Class Backup
    Inherits BackupInteraction
    Sub New()
        'Default constructor
    End Sub
    Sub New(selectedLocation As String, currentDateTime As String, backupTables As List(Of String))
        'Set up the properties needed for the backup
        location = selectedLocation
        backUpDateTime = currentDateTime
        tables = backupTables
    End Sub
    Public Function DoBackUp() As Boolean
        'Create the backup directory
        Dim fullLocation As String = CreateBackUpDirectory()
        Dim errorLogList As New List(Of String)
        For Each table As String In tables
            'Query the database to get the most recent table
            Dim getTableContentsSql As String = "SELECT * FROM " & table
            Dim tableObject As DataTable = database.Query(getTableContentsSql)
            'Instantiate a table interaction to parse the table to XML
            Dim thisTable As New TableInteraction(tableObject)
            'Parse the table into unencrypted Xml
            Dim tableXml As String = thisTable.getTableXml()
            'Encrypt the table Xml using 'joelseidel' as the key BECAUSE I WROTE THIS ALLLLLLLL THATS WHY
            Dim encryptedTableContents As String = New EncryptionInteraction("joelseidel").EncryptData(tableXml)
            'Create the file into which the encrypted Xml will be written (.candy file)
            Dim backUpFilePath As String = CreateBackUpFile(fullLocation, table)
            'Send datatable object to the serialization object
            Dim serializationSuccess As Boolean
            'Episode IV: A New Stream
            Dim backUpWriteStream As StreamWriter = Nothing
            Try
                'Episode VII: The Stream Awakens
                backUpWriteStream = New StreamWriter(backUpFilePath, False)
                'Write the encrypted table Xml to the backup file created previously
                backUpWriteStream.Write(encryptedTableContents)
                serializationSuccess = True
            Catch ex As Exception
                serializationSuccess = False
            Finally
                If Not IsNothing(backUpWriteStream) Then
                    backUpWriteStream.Close()
                End If
            End Try
            If Not serializationSuccess Then
                'Backup has failed, add to error counter
                errorLogList.Add(table)
            End If
        Next
        If errorLogList.Count <> 0 Then
            'Backup has failed
            MsgBox("Serialization was not successful, try again later or seek technical support", , "Serialization/Backup Error")
            Return False
        Else
            Return True
        End If
    End Function
End Class