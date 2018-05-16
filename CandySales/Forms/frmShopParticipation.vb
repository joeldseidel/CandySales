Public Class frmShopParticipation
    Private Sub frmShopParticipation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim shopClass As New Shop
        Dim allShops As List(Of String) = shopClass.GetAll()
        Dim allShopsParticipation As New List(Of Decimal)
        For Each shop As String In allShops
            Dim thisShop As New Shop(shop)
            Dim participationPercent As Decimal = (thisShop.getSellingCount() / thisShop.getStudentCount()) * 100
            allShopsParticipation.Add(participationPercent)
        Next
        Dim newSeries = New DataVisualization.Charting.Series()
        newSeries.ChartType = DataVisualization.Charting.SeriesChartType.Column
        newSeries.Points.DataBindXY(allShops, allShopsParticipation)
        crtShopParticipation.ChartAreas(0).AxisX.Interval = 1
        crtShopParticipation.Series.Add(newSeries)
    End Sub
End Class