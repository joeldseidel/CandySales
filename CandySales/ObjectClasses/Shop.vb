Option Strict On
Public Class Shop
    Public name As String
    Private studentCount, sellingCount As Integer
    Private database As New DatabaseInteraction()
    Sub New()
    End Sub
    Sub New(inName As String)
        name = inName
    End Sub
    Public Function GetAll() As List(Of String)
        Dim allShops As New List(Of String)
        Dim shopQuery As String = "SELECT DISTINCT Shop FROM Students"
        Dim shopResults As DataTable = database.Query(shopQuery)
        For Each shop As DataRow In shopResults.Rows
            allShops.Add(shop.Item(0).ToString)
        Next
        Return allShops
    End Function
    Public Function getStudentCount() As Integer
        Return getStudentsData().Rows.Count
    End Function

    Public Function getStudentsData() As DataTable
        Dim getShopStudentsSql As String = "SELECT * FROM Students WHERE Shop='" & name & "'"
        Dim studentsInShop As DataTable = database.Query(getShopStudentsSql)
        Return studentsInShop
    End Function

    Public Function getSellingCount() As Integer
        Dim sellingStudents As Integer = 0
        For Each studentRecord As DataRow In getStudentsData().Rows
            Dim student As New Student(studentRecord)
            If student.GetSalesCount > 0 Then
                sellingStudents += 1
            End If
        Next
        Return sellingStudents
    End Function

    Public Function getOutstandingOrders() As DataTable
        Dim allStudentsData As DataTable = getStudentsData()
        Dim allOutstandingOrders As New DataTable
        For Each studentRecord As DataRow In allStudentsData.Rows
            Dim thisStudent As New Student(studentRecord)
            Dim thisStudentOrders As DataTable = thisStudent.GetOutstandingOrderData()
            allOutstandingOrders.Merge(thisStudentOrders)
        Next
        Return allOutstandingOrders
    End Function
End Class