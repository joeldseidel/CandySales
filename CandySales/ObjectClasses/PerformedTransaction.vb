Option Strict On
Imports System.Convert
Public MustInherit Class PerformedTransaction
    Public orderNumber As Integer
    Public TransactionValue As Decimal
    Public TransactionDate As String
    Public rowID As Integer
    Public item As Item
    Public student As Student
    Protected administrator As Administrator
    Private database As New DatabaseInteraction()

    Sub New()
    End Sub

    Sub New(dataRowToParse As DataRow)
        ParseFromDataRow(dataRowToParse)
    End Sub

    Public Shared Function GetTransactionType(transactionRecord As DataRow) As PerformedTransaction
        'Factory function for type of payment
        Dim transaction As PerformedTransaction = Nothing
        Dim transactionValue As Decimal = ToDecimal(transactionRecord.Item(5))
        Dim transactionItem As New Item(transactionRecord.Item(4).ToString())
        If transactionItem.isImmediateReturn Then
            transaction = New Purchase(transactionRecord)
        ElseIf transactionValue < 0 Then
            transaction = New Withdraw(transactionRecord)
        ElseIf transactionValue > 0 Then
            transaction = New Payment(transactionRecord)
        End If
        Return transaction
    End Function

    Public Shared Function GetCompletedTransactions(transactionOrderNumber As Integer) As PerformedTransaction()
        Dim withdrawTransaction As New Withdraw(transactionOrderNumber)
        Dim paymentTransaction As New Payment(transactionOrderNumber)
        Return {withdrawTransaction, paymentTransaction}
    End Function

    Public Sub ParseFromDataRow(row As DataRow)
        rowID = ToInt32(row.Item(0))
        orderNumber = ToInt32(row.Item(1))
        student = New Student(ToInt32(row.Item(2)))
        TransactionDate = row.Item(3).ToString()
        item = New Item(row.Item(4).ToString())
        TransactionValue = ToDecimal(row.Item(5))
        administrator = New Administrator(row.Item(8).ToString())
    End Sub

    Public Function IsTransactionOutstanding() As Boolean
        Dim totalTransactionValue As Double = GetTotalTransactionValue()
        'If the total value is 0, the transaction is entirely paid off
        If totalTransactionValue = 0 Then
            'Order is payed off
            Return False
        Else
            'Order still has value and therefore is not paid off
            Return True
        End If
    End Function

    Public Function GetTotalTransactionValue() As Double
        'Select all transactions that have the same value as the selected one
        Dim getCorrespondingOrderSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & orderNumber
        Dim getCorrespondingOrderResult As DataTable = database.Query(getCorrespondingOrderSql)
        Dim totalTransactionValue As Double
        'For each transaciton selected, add the value
        For Each transactionRecord As DataRow In getCorrespondingOrderResult.Rows
            Dim thisTransaction As PerformedTransaction = GetTransactionType(transactionRecord)
            totalTransactionValue += thisTransaction.TransactionValue
        Next
        Return totalTransactionValue
    End Function

    Public Function GetOrderNumber() As Integer
        Return orderNumber
    End Function

    Public Overridable Sub SetOrderNumber(orderNumber As Integer)
        Me.orderNumber = orderNumber
    End Sub

    Public Function GetAdministrator() As Administrator
        Return Me.administrator
    End Function

    Public Function GetValue() As Decimal
        Return TransactionValue
    End Function
End Class