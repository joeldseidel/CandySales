Imports System.IO
Public Class Tickets
    Sub New()
        Dim reportPath As String = CreateDataDocument()
        ShowReport(reportPath)
    End Sub
    Private Function CreateDataDocument() As String
        Dim ticketsDocumentString As String = "<?xml version=""1.0"" encoding=""utf-8""?> <?xml-stylesheet type=""text/xsl"" href=""" & Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports"), "tickets.xsl") & """?> <report> </report>"
        Dim ticketsDocument As XDocument = XDocument.Parse(ticketsDocumentString)
        Dim database As New DatabaseInteraction
        Dim allSalesSql As String = "SELECT StudentIDNumber FROM Transactions WHERE TransactionValue > 0"
        Dim allSalesResults As DataTable = database.Query(allSalesSql)
        Dim ticketResults As New List(Of String())
        For Each saleStudent As DataRow In allSalesResults.Rows
            Dim correspondingStudentSql As String = "SELECT FirstName, LastName, Shop, Grade FROM Students WHERE StudentID = '" & saleStudent.Item(0).ToString() & "'"
            Dim correspondingStudentResults As DataTable = database.Query(correspondingStudentSql)
            Dim studentRecord As DataRow = correspondingStudentResults.Rows(0)
            ticketResults.Add({studentRecord.Item(0) & " " & studentRecord.Item(1), studentRecord.Item(2), studentRecord.Item(3)})
        Next
        For Each ticket As String() In ticketResults
            ticketsDocument.Element("report").Add(New XElement("ticket", New XElement("name", ticket(0)), New XElement("shop", ticket(1)), New XElement("grade", ticket(2))))
        Next
        Dim destinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\tickets.xml"
        ticketsDocument.Save(destinationFile)
        Return destinationFile
    End Function
    Private Sub ShowReport(reportPath As String)
        Dim reportViewer As New frmReportView(reportPath)
        reportViewer.Show()
    End Sub
End Class
