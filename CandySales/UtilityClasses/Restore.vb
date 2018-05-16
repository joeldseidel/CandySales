Imports System.IO
Public Class Restore
    Inherits BackupInteraction
    Private persistentDatabase As New PersistentDatabaseInteraction
    Sub New()
        'Default constructor
    End Sub
    Sub New(selectedLocation As String, currentDateTime As String, backupTables As List(Of String))
        'Set up the properties needed for the backup
        location = selectedLocation
        backUpDateTime = currentDateTime
        tables = backupTables
    End Sub
    Public Function GetBackupFileInfo(restoreLocation As String) As FileInfo()
        'Get info on all the backup files stored in the selected directory
        Dim backupDirectory As New DirectoryInfo(restoreLocation)
        'Get the information from each file ending in a .candy extension
        Dim backupFiles As FileInfo() = backupDirectory.GetFiles("*.candy")
        Return backupFiles
    End Function
    Public Function ImportBackupFiles(restoreLocation As String, backupFileInfo As FileInfo()) As Boolean
        'Get the tables that were serialized and then fill their data into the database, overwriting the current table
        Dim tablesToRestore As New List(Of String)
        For Each backupFile As FileInfo In backupFileInfo
            'For each file name add to the list of table names as, hopefully, they are the same
            tablesToRestore.Add(backupFile.Name)
        Next
        'Get the data from each file and re-input to the database tables
        For Each tableToRestore As String In tablesToRestore
            'Get table from datatable
            Dim tableRestorationData As DataTable = GetTable(tableToRestore, restoreLocation & "\" & tableToRestore)
            'Re-input into the database
            InsertRestoredData(tableToRestore, tableRestorationData)
        Next
        'The import was successful
        Return True
    End Function
    Private Function GetTable(restoreFile As String, location As String) As DataTable
        'Get the table data from the serialization file
        'Remove the file extension from the file name to get the corresponding table name
        Dim tableName As String = restoreFile.Replace(".candy", "")
        Dim deserializationAgent As New StreamReader(location)
        'Using the deserialization class load in the XML data from the selected files
        Dim encryptedTableXMLString As String = deserializationAgent.ReadToEnd()
        Dim decryptedTableXML As String = New EncryptionInteraction("joelseidel").DecryptData(encryptedTableXMLString)
        Dim xmlStreamObject As Stream = New MemoryStream(System.Text.Encoding.UTF8.GetBytes(decryptedTableXML))
        Dim xmlStream As New StreamReader(xmlStreamObject)
        Dim restoredTable As New DataTable
        restoredTable.ReadXml(xmlStream)
        'Return loaded table as datatable IN MEMORY
        Return restoredTable
    End Function
    Private Sub InsertRestoredData(tableToRestore As String, restoredData As DataTable)
        'Take the loaded datatable object, split into datarows, split into items and reinsert into the database
        'Delete the currently existing table
        Dim clearTableSql As String = "DELETE FROM " & tableToRestore.Replace(".candy", "")
        database.NonQuery(clearTableSql)
        Dim progressCounter As Integer = 0
        'Break down the datatable object, build nonquery to reinsert to database, and reinsert into the database
        For Each row As DataRow In restoredData.Rows
            'Create the base of the nonquery object
            Dim thisInsertSql As String = "INSERT INTO " & tableToRestore.Replace(".candy", "") & "("
            'Break the row down into column titles
            For columnCount As Integer = 0 To restoredData.Columns.Count - 1
                'Test to see if the nonquery string needs
                If columnCount = restoredData.Columns.Count - 1 Then
                    'Does not need a comma, is the last column
                    thisInsertSql &= restoredData.Columns(columnCount).ToString
                Else
                    'Needs a comma, is not the last column
                    thisInsertSql &= restoredData.Columns(columnCount).ToString & ", "
                End If
            Next
            'Finished building the column values into the SQL nonquery string
            thisInsertSql &= ") VALUES ('"
            'Break the datarow down into items using the item array property, insert into the nonquery string
            For itemCount As Integer = 0 To row.ItemArray.Count - 1
                'Test to see if the nonquery string requires commas
                If itemCount = row.ItemArray.Count - 1 Then
                    'Does not require comma, is the last column
                    thisInsertSql &= row.ItemArray(itemCount).ToString.Replace("'", "")
                Else
                    'Does require a comma, is not the last column
                    thisInsertSql &= row.ItemArray(itemCount).ToString.Replace("'", "") & "', '"
                End If
            Next
            'Add the final parenthesis to the SQL nonquery string
            thisInsertSql &= "')"
            Database.NonQuery(thisInsertSql)
            'Increment the counter and update the progress bar on the backup form
            progressCounter += 1
            frmBackup.prgBackup.Value = Convert.ToInt32(progressCounter / restoredData.Rows.Count * 100)
        Next
    End Sub
End Class