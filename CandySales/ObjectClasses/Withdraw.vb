Public Class Withdraw
    Inherits PerformedTransaction
    Implements Transaction
    Private database As New DatabaseInteraction

    Public Sub New(record As DataRow)
        MyBase.New(record)
    End Sub
    Public Sub New(item As Item, student As Student, administrator As Administrator)
        'Constructor to create a database record for the transaction right away
        Me.item = item
        Me.student = student
        Me.administrator = administrator
    End Sub
    Public Sub New(orderNumber As Integer)
        GetTransaction(orderNumber)
    End Sub

    Private Sub GetTransaction(orderNumber As Integer) Implements Transaction.GetTransaction
        Dim getThisTransactionSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & orderNumber.ToString() & " AND TransactionValue > 0"
        Dim transactionRecord As DataRow = database.Query(getThisTransactionSql).Rows(0)
        ParseFromDataRow(transactionRecord)
    End Sub

    Public Sub WriteTransaction() Implements Transaction.WriteTransaction
        'Query information from the database dependent on form entries and insert subsequent order into transaction table of database
        'Database query for all transactions
        Dim previousOrderQuery As String = "SELECT * FROM Transactions"
        Dim previousOrderResult As DataTable = database.Query(previousOrderQuery)
        Dim newOrderNumber As Integer = GenerateOrderNumber(previousOrderResult)

        'Insert the new record into the database as a nonquery
        Dim insertWithdrawSQL As String = "INSERT INTO Transactions (OrderNumber, StudentIDNumber, TransactionDate, ItemID, TransactionValue, TechSession, AdminUsername) VALUES (" & newOrderNumber & ", " & student.studentID & ", '" & DateTime.Now.ToShortDateString() & "', " & item.upc & ", " & item.debtCreated & ", '" & student.Session & "', '" & administrator.username & "')"
        database.NonQuery(insertWithdrawSQL)
    End Sub

    Private Function GenerateOrderNumber(previousOrderResult As DataTable) As Integer
        'Get all order numbers stored and add to list
        Dim orderNumbers As New List(Of Integer)
        For Each transactionRecord As DataRow In previousOrderResult.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transactionRecord)
            'Add order number to order number list
            Dim thisOrderNumber As Integer = Convert.ToInt32(thisTransaction.GetOrderNumber())
            orderNumbers.Add(thisOrderNumber)
        Next
        'Sort order number list so as to get the next highest number in the table for the order numeber
        orderNumbers.Sort()
        'Find the new order number by adding one to the highest number in order number list
        Dim newOrderNumber As Integer
        Try
            'Try to get the next highest number that is greater or equal to 0
            If orderNumbers.Count - 1 < 0 Then
                'This will make the order number go into the negatives, throw an error so it falls down and makes it equal 1
                Throw New IndexOutOfRangeException
            End If
            If orderNumbers.Count - 1 = 1 Then
                newOrderNumber = 2
            Else
                newOrderNumber = (orderNumbers.Count - 1)
            End If
        Catch Ex As IndexOutOfRangeException
            'This exception was thrown because 1 cannot be subtracted from count without going into the negatives, meaning that this is the first order to placed and will be order number 1
            newOrderNumber = 1
        End Try
        MyBase.SetOrderNumber(newOrderNumber)
        Return newOrderNumber
    End Function
End Class