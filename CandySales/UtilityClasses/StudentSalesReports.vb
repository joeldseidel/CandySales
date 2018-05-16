Option Strict On
Public Class StudentSalesReports
    Public ID, Name, Shop As String
    Public Sales As Integer
    Private database As New DatabaseInteraction()
    Sub New()
    End Sub
End Class

Public MustInherit Class Report
    Public MustOverride Sub CreateReport(passedData As DataTable)
    Public MustOverride Sub ShowReport(createdReportData As DataTable)
    Private database As New DatabaseInteraction()
    Public Class TicketsOld
        Inherits Report
        Dim allSalesStudents As New DataTable
        Public Overrides Sub CreateReport(passedData As DataTable)
            Dim allSalesSql As String = "SELECT StudentIDNumber FROM Transactions WHERE TransactionValue > 0"
            Dim allSalesResults As DataTable = database.Query(allSalesSql)
            Try
                allSalesStudents.Columns.Add("StudentName")
                allSalesStudents.Columns.Add("Shop")
                allSalesStudents.Columns.Add("Grade")
            Catch ex As Exception
            End Try
            For Each saleStudent As DataRow In allSalesResults.Rows
                Dim correspondingStudentSql As String = "SELECT FirstName, LastName, Shop, Grade FROM Students WHERE StudentID = '" & saleStudent.Item(0).ToString() & "'"
                Dim correspondingStudentResults As DataTable = database.Query(correspondingStudentSql)
                Dim saleRecord As DataRow = allSalesStudents.NewRow()
                saleRecord.Item(0) = correspondingStudentResults.Rows(0).Item(0).ToString() & " " & correspondingStudentResults.Rows(0).Item(1).ToString()
                saleRecord.Item(1) = correspondingStudentResults.Rows(0).Item(2).ToString()
                saleRecord.Item(2) = correspondingStudentResults.Rows(0).Item(3).ToString()
                allSalesStudents.Rows.Add(saleRecord)
            Next
            ShowReport(allSalesResults)
        End Sub

        Public Overrides Sub ShowReport(createdReportData As DataTable)
            'Create a tickets and export as new crystal report
            Dim tickets As New CandySales.TicketsCrystal
            tickets.Database.Tables(0).SetDataSource(allSalesStudents)
            ReportViewForm.crvReportView.ReportSource = tickets
            ReportViewForm.crvReportView.Refresh()
            ReportViewForm.Show()
        End Sub
    End Class

    Public Class TopSeller
        Inherits Report
        Dim topSellerReport As New TopSellerReport
        Dim reportRecords As New StudentSalesReports
        Dim topSellerTable As New DataTable
        Public session As String
        Public Overrides Sub CreateReport(passedData As DataTable)
            'Get all students students with the information necessary for required object
            Dim getAllStudentsSql As String = "SELECT * FROM Students WHERE Session='" & session & "'"
            Dim studentsResults As DataTable = database.Query(getAllStudentsSql)
            Dim studentSaleClassList As New List(Of StudentSalesReports)
            Dim progresscounter As Integer = 0
            For Each studentRecord As DataRow In studentsResults.Rows
                frmStats.prgPopulateList.Value = Convert.ToInt32(Math.Ceiling((progresscounter / studentsResults.Rows.Count) * 100))
                'Create object to hold infomation for sorting
                Dim student As New Student(studentRecord)
                Dim currentStudentSales As New StudentSalesReports
                currentStudentSales.ID = student.studentID
                currentStudentSales.Sales = student.GetSalesCount()
                currentStudentSales.Name = student.FirstName & " " & student.LastName
                currentStudentSales.Shop = student.Shop
                studentSaleClassList.Add(currentStudentSales)
                progresscounter += 1
            Next
            'Sort list of by sales amount (LINQ)
            Dim topSellerList As List(Of StudentSalesReports) = studentSaleClassList.OrderByDescending(Function(x) x.Sales).ToList()
            Dim sellerTable As New DataTable
            sellerTable.Columns.Add("StudentName")
            sellerTable.Columns.Add("Shop")
            sellerTable.Columns.Add("Sales")
            For Each seller As StudentSalesReports In topSellerList
                Dim thisSeller As DataRow = sellerTable.NewRow()
                thisSeller.Item(0) = seller.Name
                thisSeller.Item(1) = seller.Shop
                thisSeller.Item(2) = seller.Sales
                sellerTable.Rows.Add(thisSeller)
            Next
            topSellerTable = sellerTable
            ShowReport(topSellerTable)
        End Sub

        Public Overrides Sub ShowReport(createdReportData As DataTable)
            'Set the datasource of the report instance to be the recently populated dataset table
            TopSellerReport.Database.Tables(0).SetDataSource(topSellerTable)
            'Set the report viewer form source to be the created form
            ReportViewForm.crvReportView.ReportSource = TopSellerReport
            frmStats.prgPopulateList.Visible = False
            ReportViewForm.crvReportView.Refresh()
            'Show report/viewer form
            ReportViewForm.Show()
        End Sub
    End Class
End Class
Public Class Receipt
    Private database As New DatabaseInteraction()
    Sub New(studentData As DataTable, itemData As DataTable, transactionData As DataTable)
        CreateReport(studentData, itemData, transactionData)
    End Sub
    Private Sub CreateReport(studentData As DataTable, itemData As DataTable, transactionData As DataTable)
        Dim orderReport As New orderReceipt
        orderReport.Database.Tables(0).SetDataSource(studentData)
        orderReport.Database.Tables(1).SetDataSource(itemData)
        orderReport.Database.Tables(2).SetDataSource(transactionData)
        ReportViewForm.crvReportView.ReportSource = orderReport
        ReportViewForm.Refresh()
        ReportViewForm.Show()
    End Sub
End Class