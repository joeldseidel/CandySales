Option Strict On
Public Class Administrator
    Public username, password As String
    Private database As New DatabaseInteraction
    Sub New(name As String, pass As String)
        'Create object from username and password
        username = name
        password = pass
    End Sub
    Sub New(username As String)
        Me.username = username
    End Sub
    Sub New(adminRecord As DataRow)
        'Create object from data record
        username = adminRecord.Item(0).ToString()
        password = adminRecord.Item(1).ToString()
    End Sub
    Public Sub CreateNew()
        'Create a new administrator record in the database
        Dim createNewSql As String = "INSERT INTO AdminLogins(Username, Password) VALUES ('" & username & "', '" & password & "')"
        database.NonQuery(createNewSql)
    End Sub
    Public Sub Remove()
        'Remove the administrator record from the database
        Dim removeAdminSql As String = "DELETE FROM AdminLogins WHERE Username = '" & username & "'"
        database.NonQuery(removeAdminSql)
    End Sub
    Public Function GetTransactionCount() As Integer
        'Get the amount of transactions that the selected admin has completed and is tagged with
        Dim getTransactionCountSql As String = "SELECT * FROM Transactions WHERE AdminUsername = '" & username & "'"
        Dim transactionResults As DataTable = database.Query(getTransactionCountSql)
        Return transactionResults.Rows.Count
    End Function
End Class