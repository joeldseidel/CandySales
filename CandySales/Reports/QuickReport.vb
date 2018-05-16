Imports System.IO
Public Class QuickReport
    Dim searchResults As List(Of String())
    Dim queryTerms As String
    Sub New(queryTerms As String, searchResults As List(Of String()))
        Me.searchResults = searchResults
        Me.queryTerms = queryTerms
        Dim reportPath = CreateDataDocument()
        ShowReport(reportPath)
    End Sub
    Private Function CreateDataDocument() As String
        Dim quickReportDocumentString As String = "<?xml version=""1.0"" encoding=""utf-8""?> <?xml-stylesheet type=""text/xsl"" href=""" & Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports"), "quickreport.xsl") & """?> <quickreport> <queryTerms> " & queryTerms & "</queryTerms> </quickreport>"
        Dim quickReportDocument As XDocument = XDocument.Parse(quickReportDocumentString)
        For Each recordData As String() In searchResults
            quickReportDocument.Element("quickreport").Add(New XElement("record", New XElement("name", recordData(0)), New XElement("shop", recordData(4)), New XElement("grade", recordData(1)), New XElement("outstanding-orders", recordData(2)), New XElement("debt", recordData(3))))
        Next
        Dim destinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\quickreport.xml"
        quickReportDocument.Save(destinationFile)
        Return destinationFile
    End Function
    Private Sub ShowReport(reportPath As String)
        Dim reportViewer As New frmReportView(reportPath)
        reportViewer.Show()
    End Sub
End Class