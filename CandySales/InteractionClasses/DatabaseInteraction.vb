Option Strict On
Imports System.Data.SQLite
Public Class DatabaseInteraction
    Private connection As New SQLiteConnection
    Private key As New EncryptionInteraction("joelseidel")
    Private ReadOnly dbConnString As String = "Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\CandySales.db; Version=3; Password=" & key.DecryptData("TFTyZDaIKYUKZLJ9vS3+dtM76DlR3Hoc")
    Public Function CreateConnection() As SQLiteConnection
        'Create and return new SQLite connection to data
        Return New SQLiteConnection(dbConnString)
    End Function
    Public Overridable Function Query(sql As String) As DataTable
        'Set up command for, execute query, and return results as datatable
        connection = CreateConnection()
        connection.Open()
        'Datatable initialization
        Dim resultsDataTable As DataTable = New DataTable()
        'Command initialization
        Dim query_Command As New SQLiteCommand(sql, connection)
        'Data reader initialization
        Dim query_DataReader As SQLiteDataReader = query_Command.ExecuteReader()
        'Datatable loads reults from data reading
        resultsDataTable.Load(query_DataReader)
        'Close and dispose of the connection to the database created at the beginning of the connection
        connection.Close()
        Return resultsDataTable
    End Function
    Public Overridable Sub NonQuery(sql As String)
        'Set up command for, execute nonquery, and close the connection
        connection = CreateConnection()
        connection.Open()
        'Async sub procedure for nonquery in the database
        Dim nonQueryCommand As New SQLiteCommand(sql, connection)
        nonQueryCommand.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class