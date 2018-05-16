Imports System.Data.SQLite
Public Class PersistentDatabaseInteraction
    Inherits DatabaseInteraction
    Private dbConn As SQLiteConnection
    Sub New()
        dbConn = MyBase.CreateConnection()
        dbConn.Open()
    End Sub
    Public Overrides Function Query(sql As String) As DataTable
        'Set up command for, execute query, and return results as datatable
        'Datatable initialization
        Dim resultsDataTable As DataTable = New DataTable()
        'Command initialization
        Dim query_Command As New SQLiteCommand(sql, dbConn)
        'Data reader initialization
        Dim query_DataReader As SQLiteDataReader = query_Command.ExecuteReader()
        'Datatable loads reults from data reading
        resultsDataTable.Load(query_DataReader)
        'Close and dispose of the connection to the database created at the beginning of the connection
        Return resultsDataTable
    End Function
    Public Overrides Sub NonQuery(sql As String)
        'Set up command for, execute nonquery, and close the connection
        'Async sub procedure for nonquery in the database
        Dim nonQueryCommand As New SQLiteCommand(sql, dbConn)
        nonQueryCommand.ExecuteNonQuery()
    End Sub
    Public Sub CloseConnection()
        dbConn.Close()
    End Sub
End Class