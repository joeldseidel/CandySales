Option Strict On
Imports System.IO
Public Class frmBackup
    Dim backUpLocation As String = ""
    Dim database As New DatabaseInteraction()
    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Query the sqlite utility table for the names of all the tables in the database
        Dim getAllTablesSql As String = "SELECT name FROM sqlite_master WHERE type='table' order by name;"
        Dim allTables As DataTable = database.Query(getAllTablesSql)
        'Remove the sqlite utility table
        allTables.Rows.RemoveAt(0)
        allTables.Rows.RemoveAt(allTables.Rows.Count - 1)
        'Add the tables to the listbox as options
        For Each table As DataRow In allTables.Rows
            clstSelectedTable.Items.Add(table.Item(0))
        Next
    End Sub
    Private Sub btnBrowseLocation_Click(sender As Object, e As EventArgs) Handles btnBrowseLocation.Click
        'If the user confirms a selection
        If fbdGetBackUpLocation.ShowDialog = DialogResult.OK Then
            backUpLocation = fbdGetBackUpLocation.SelectedPath
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Get the backup input and ship to backup classes
        If clstSelectedTable.CheckedItems.Count = 0 Then
            'The user has selected no tables for backup. That's not okay :(
            MsgBox("You must select at least one table to backup", , "Input Error")
            Return
        End If
        If backUpLocation = "" Then
            'User has not selected a location for the backup
            'See if the user has a previous backup location saved in their data packet
            MsgBox("You must select a backup location", , "Input Error")
            Return
        End If
        Dim tables As New List(Of String)
        For Each checkedItem As Object In clstSelectedTable.CheckedItems
            'Get the tables that the user selected to update
            tables.Add(checkedItem.ToString)
        Next
        'Instantiate the backup object
        Dim thisBackup As New Backup(backUpLocation, Now.ToString("MM_dd_yyyy"), tables)
        'Enable the creation of the backup files
        Dim backUpSuccess As Boolean = thisBackup.DoBackUp()
        If backUpSuccess Then
            MsgBox("Backup successful")
            Me.Close()
        Else
            'Don't worry, this code is 'virtually' unreachable
            'Nevermind....
            ' Times I got this error message: 2 (12/17/2015, 1/25/2016)
            MsgBox("Big spaghetti-oh")
        End If
    End Sub

    Dim restoreLocation As String = ""
    Private Sub btnGetRestoreLocation_Click(sender As Object, e As EventArgs) Handles btnGetRestoreLocation.Click
        Dim backup As New Restore
        'If the user confirms a selection get the result of the selected folder
        If fbdGetBackUpLocation.ShowDialog = DialogResult.OK Then
            'User has selected a folder that MAY contain backup files
            Dim isBackUpDirectory As Boolean = backup.IsBackUpDirectory(fbdGetBackUpLocation.SelectedPath)
            If Not isBackUpDirectory Then
                'User has selected a folder that does not contain backup files (shame on them really)
                MsgBox("That folder does not contain backed up files. You must select a folder containing the .candy backup files", , "Error")
                Return
            End If
            'Set location for the restore
            restoreLocation = fbdGetBackUpLocation.SelectedPath
        Else
            Return
        End If
    End Sub

    Private Sub btnStartRestore_Click(sender As Object, e As EventArgs) Handles btnStartRestore.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to revert the database back to this state ?", "Confirm Restore", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.No Then
            'User did not actually want to restore. Nice.
            Return
        End If
        Dim backup As New Restore
        If restoreLocation = "" Then
            'User did not select a location for the restore
            MsgBox("You did not select a folder with .candy backup files in it",, "Error")
        End If
        'Get the information of the backup files contained in the selected folder
        Dim backUpFiles As FileInfo() = backup.GetBackupFileInfo(restoreLocation)
        'Import the backup files and insert into the database
        Dim backupSuccessful As Boolean = backup.ImportBackupFiles(restoreLocation, backUpFiles)
        If backupSuccessful Then
            'Yay
            MsgBox("The restoration was successful", , "Successful Restore")
            Me.Close()
        Else
            'Nuuu
            MsgBox("The restoration was unsuccessful", , "Unsuccessful Restore")
        End If
    End Sub
End Class