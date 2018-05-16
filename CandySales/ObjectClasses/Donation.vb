Option Strict On
Public Class Donation
    Public studentID, transactionDate As String
    Public orderNumber As Integer
    Public amount As Decimal
    Private database As New DatabaseInteraction()
    Sub New()
    End Sub
    Sub New(donationRecord As DataRow)
        ParseFromDataRow(donationRecord)
    End Sub
    Sub New(passedStudentID As String, passedOrderNumber As Integer, passedTransactionDate As String, passedAmount As Decimal)
        studentID = passedStudentID
        orderNumber = passedOrderNumber
        transactionDate = passedTransactionDate
        amount = passedAmount
    End Sub
    Public Sub ParseFromDataRow(record As DataRow)
        studentID = record.Item(0).ToString()
        orderNumber = Convert.ToInt32(record.Item(1))
        transactionDate = record.Item(2).ToString()
        amount = Convert.ToDecimal(record.Item(3))
    End Sub
    Public Sub WriteDonation()
        Dim donationSql As String = "INSERT INTO Donations(StudentID, OrderNumber, TransactionDate, Amount) VALUES (" & studentID & "," & orderNumber & "," & transactionDate & "," & amount & ")"
        database.NonQuery(donationSql)
    End Sub
End Class