Option Strict On
Public Class DateRange
    Public StartDate, EndDate As DateTime
    Public DateRange As String
    Private database As New DatabaseInteraction()
    Sub New(startDay As DateTime, endDay As DateTime)
        'Constructor that takes in dates as datetime
        StartDate = startDay
        EndDate = endDay
        DateRange = (endDay - startDay).Days.ToString()
    End Sub
    Sub New(startDay As String, endDay As String)
        'Constructor that takes in dates as strings and parses them to datetime
        StartDate = Convert.ToDateTime(startDay)
        EndDate = Convert.ToDateTime(endDay)
        DateRange = (EndDate - StartDate).Days.ToString()
    End Sub

    Public Sub dateReport()
        Dim reportingDate As Date = StartDate.Date
        Dim dateTransactions As DataTable = getDateTransactions(reportingDate)
        Dim studentsTable As DataTable = database.Query("SELECT * FROM Students WHERE StudentID = -1")
        Dim transactionsTable As DataTable = database.Query("SELECT * FROM Transactions WHERE OrderNumber = -1")
        Dim dailySales As New DataTable
        Dim dailyIncome As New DataTable
        dailySales.Columns.Add("StudentName")
        dailySales.Columns.Add("Shop")
        dailySales.Columns.Add("Session")
        dailySales.Columns.Add("OrderNumber")
        dailySales.Columns.Add("TransactionValue")
        dailyIncome.Columns.Add("Income")
        Dim totalDailyIncome As Decimal
        For Each transactionRecord As DataRow In dateTransactions.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transactionRecord)
            Dim thisStudent As New Student
            thisStudent = thisStudent.GetStudent(thisTransaction.student.studentID.ToString)
            Dim transactionRow As DataRow = dailySales.NewRow()
            transactionRow.Item(0) = thisStudent.FirstName & " " & thisStudent.LastName
            transactionRow.Item(1) = thisStudent.Shop
            transactionRow.Item(2) = thisStudent.Session
            transactionRow.Item(3) = thisTransaction.orderNumber
            transactionRow.Item(4) = thisTransaction.TransactionValue.ToString("C2")
            totalDailyIncome += Convert.ToDecimal(thisTransaction.TransactionValue)
            dailySales.Rows.Add(transactionRow)
        Next
        Dim incomeRecord As DataRow = dailyIncome.NewRow()
        incomeRecord.Item(0) = Convert.ToDouble(totalDailyIncome)
        dailyIncome.Rows.Add(incomeRecord)
        Dim sortedDataView As New DataView(dailySales)
        sortedDataView.Sort = "OrderNumber Asc"
        dailySales = sortedDataView.ToTable()
        Dim dailyReport As New DailyReport
        dailyReport.Database.Tables(0).SetDataSource(dailySales)
        dailyReport.Database.Tables(1).SetDataSource(dailyIncome)
        'Set the report viewer form source to be the created form
        ReportViewForm.crvReportView.ReportSource = dailyReport
        ReportViewForm.crvReportView.Refresh()
        ReportViewForm.Show()
    End Sub

    Private Function getDateTransactions(reportingDate As Date) As DataTable
        Dim getTransactionsSql As String = "SELECT * FROM Transactions WHERE TransactionDate ='" & reportingDate & "'"
        Dim getTransactionsResult As DataTable = database.Query(getTransactionsSql)
        Return getTransactionsResult
    End Function

    Private Function getDateDonations(reportingDate As Date) As DataTable
        Dim getDonationsSql As String = "SELECT * FROM Donations WHERE TransactionDate = '" & reportingDate & "'"
        Dim getDonationsResult As DataTable = database.Query(getDonationsSql)
        Return getDonationsResult
    End Function
End Class