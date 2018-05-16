Option Strict On
Public Class frmShopView
    Dim database As New DatabaseInteraction()
    Dim shop As Shop
    Private Sub frmShopView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get selected shop information from sender form
        shop = New Shop(frmStats.shopName)
        'Get all students in this shop
        Dim studentList As New List(Of Student)
        Dim studentsInShop As DataTable = shop.getStudentsData
        For Each student As DataRow In studentsInShop.Rows
            Dim currentStudent As New Student(student)
            'Create array to be stored into the listview control
            Dim studentInfo() As String = {currentStudent.FirstName & " " & currentStudent.LastName, currentStudent.Grade.ToString(), currentStudent.Session, currentStudent.GetOutstandingOrders.ToString(), currentStudent.GetRemainingDebt.ToString("C2")}
            Dim studentLVI As New ListViewItem(studentInfo)
            studentLVI.Name = currentStudent.studentID
            'Add student to listview
            lstvStudents.Items.Add(studentLVI)
            studentList.Add(currentStudent)
        Next
        'Get number of students that have sold in this shop
        lblShopName.Text = shop.name
        lblStudentCount.Text = "Students: " & shop.getStudentCount
        lblSellingCount.Text = "Students Selling: " & shop.getSellingCount
    End Sub

    Private Sub lstvStudents_DoubledClicked(sender As Object, e As EventArgs) Handles lstvStudents.DoubleClick
        If lstvStudents.SelectedItems Is Nothing Then
            Return
        End If
        frmStats.selectedStudentID = lstvStudents.SelectedItems(0).Name
        frmStudentView.Show()
    End Sub
End Class