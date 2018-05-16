Public Class frmMonthlySales
    Dim database As New DatabaseInteraction
    Private Sub frmMonthlySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim monthsCovered As List(Of String) = getSalesMonths()
        Dim monthsCount As New List(Of Integer)
        For Each month As String In monthsCovered
            Dim monthsTransactionCount As Integer = getMonthTransactions(month)
            monthsCount.Add(monthsTransactionCount)
        Next
        Dim newSeries = New DataVisualization.Charting.Series()
        newSeries.ChartType = DataVisualization.Charting.SeriesChartType.Column
        newSeries.Points.DataBindXY(monthsCovered, monthsCount)
        crtMonthSales.ChartAreas(0).AxisX.Interval = 1
        crtMonthSales.ChartAreas(0).AxisX.Name = "Transactions Occurred"
        crtMonthSales.Series.Add(newSeries)
    End Sub
    Private Function getSalesMonths() As List(Of String)
        Dim getTransactionDatesSql As String = "SELECT DISTINCT TransactionDate FROM Transactions"
        Dim allTransactionDates As DataTable = database.Query(getTransactionDatesSql)
        Dim transactionMonths As New List(Of String)
        For Each transactionDate As DataRow In allTransactionDates.Rows
            Dim correspondingDateTime As DateTime = Convert.ToDateTime(transactionDate.Item(0))
            If Not transactionMonths.Contains(correspondingDateTime.ToString("MMMM")) Then
                transactionMonths.Add(correspondingDateTime.ToString("MMMM"))
            End If
        Next
        Return transactionMonths
    End Function
    Private Function getMonthTransactions(month As String) As Integer
        Dim getMonthsTransactionsSql As String = "SELECT TransactionDate FROM Transactions"
        Dim allTransactionDates As DataTable = database.Query(getMonthsTransactionsSql)
        Dim monthTransactionCount As Integer = 0
        For Each transactionDate As DataRow In allTransactionDates.Rows
            Dim transactionDateTime As DateTime = Convert.ToDateTime(transactionDate.Item(0))
            If transactionDateTime.ToString("MMMM") = month Then
                monthTransactionCount += 1
            End If
        Next
        Return monthTransactionCount
    End Function
End Class