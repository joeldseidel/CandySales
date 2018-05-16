Public Class Payment
    Inherits PerformedTransaction
    Implements Transaction
    Private database As New DatabaseInteraction
    Private amount As Decimal
    Private correspondingWithdrawl As Withdraw
    Private admin As Administrator
    Private Shadows orderNumber As Integer
    Public Sub New(amount As Decimal, item As Item, student As Student, admin As Administrator)
        Me.amount = amount
        Me.item = item
        Me.correspondingWithdrawl = GetCorrespondingWithdraw()
        Me.student = student
        Me.admin = admin
    End Sub
    Public Sub New(amount As Decimal, item As Item, student As Student, admin As Administrator, orderNumber As Integer)
        Me.orderNumber = orderNumber
        Me.amount = amount
        Me.item = item
        Me.correspondingWithdrawl = GetCorrespondingWithdraw()
        Me.student = student
        Me.admin = admin
    End Sub
    Public Sub New(record As DataRow)
        MyBase.New(record)
    End Sub
    Public Sub New(orderNumber As Integer)
        GetTransaction(orderNumber)
    End Sub
    Public Sub WriteTransaction() Implements Transaction.WriteTransaction
        'Write transaction data to database
        Dim insertPaymentSQL As String = "INSERT INTO Transactions (OrderNumber, StudentIDNumber, TransactionDate, ItemID, TransactionValue, PaymentMethod, TechSession, AdminUsername) VALUES (" & correspondingWithdrawl.GetOrderNumber() & ", " & student.studentID & ", '" & DateTime.Now.ToShortDateString() & "', 0" & item.upc & ", " & amount & ", 'Cash' , '" & student.Session & "', '" & admin.username & "')"
        database.NonQuery(insertPaymentSQL)
    End Sub
    Public Sub GetTransaction(orderNumber As Integer) Implements Transaction.GetTransaction
        Dim getTransactionSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & MyBase.GetOrderNumber & " AND TransactionValue > 0"
        Dim thisTransactionRecord As DataTable = database.Query(getTransactionSql)
        ParseFromDataRow(thisTransactionRecord.Rows(0))
    End Sub
    Public Function GetCorrespondingWithdraw() As PerformedTransaction
        Dim getCorrespondingWithdrawSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & Me.orderNumber & " AND TransactionValue < 0"
        Dim withdrawlRecords As DataTable = database.Query(getCorrespondingWithdrawSql)
        Dim correspondingWithdraw As New Withdraw(withdrawlRecords.Rows(0))
        Return correspondingWithdraw
    End Function
    Public Overrides Sub SetOrderNumber(orderNumber As Integer)
        Me.orderNumber = orderNumber
    End Sub
End Class