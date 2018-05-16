Public Class Purchase
    Inherits PerformedTransaction
    Implements Transaction
    Private database As New DatabaseInteraction
    Public Sub New(record As DataRow)
        MyBase.New(record)
    End Sub
    Public Sub New(item As Item, student As Student, administrator As Administrator)
        Me.item = item
        Me.student = student
        Me.administrator = administrator
    End Sub
    Public Sub WriteTransaction() Implements Transaction.WriteTransaction
        Dim withdraw As New Withdraw(item, student, administrator)
        withdraw.WriteTransaction()
        Dim immediatePayment As New Payment(withdraw.GetValue(), item, student, administrator)
        immediatePayment.WriteTransaction()
    End Sub
    Public Sub GetTransaction(orderNumber As Integer) Implements Transaction.GetTransaction
        Dim getThisTransactionSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & orderNumber.ToString() & " AND TransactionValue > 0"
        Dim transactionRecord As DataRow = database.Query(getThisTransactionSql).Rows(0)
        ParseFromDataRow(transactionRecord)
    End Sub
End Class