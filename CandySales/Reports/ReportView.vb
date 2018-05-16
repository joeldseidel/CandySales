Public Class frmReportView
    Sub New(reportUrl As String)
        ' This call is required by the designer.
        InitializeComponent()
        reportBrowser.Url = New Uri(reportUrl)
    End Sub
End Class