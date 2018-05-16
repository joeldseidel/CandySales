Public Class Districts
    Private database As New DatabaseInteraction
    Sub New()
    End Sub
    Public Function GetAll() As List(Of String)
        Dim allDistricts As New List(Of String)
        Dim districtQuery As String = "SELECT DISTINCT District FROM Students"
        Dim districtResults As DataTable = database.Query(districtQuery)
        For Each district As DataRow In districtResults.Rows
            allDistricts.Add(district.Item(0).ToString())
        Next
        Return allDistricts
    End Function
End Class