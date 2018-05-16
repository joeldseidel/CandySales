Option Strict On
Public Class frmEditStudent
    Dim student As Student
    Dim database As New DatabaseInteraction
    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get shop criteria choices
        Dim allShops As New Shop
        cboShops.DataSource = allShops.GetAll()
        'Get district criteria choices
        Dim allDistricts As New Districts
        cboDistrict.DataSource = allDistricts.GetAll()
        'Get the student ID that is to be openned
        Dim passedStudentID As String = frmStudentView.editStudentID
        'Get selected student from database
        Dim getOriginalStudentSql As String = "SELECT * FROM Students WHERE StudentID=" & passedStudentID
        student = New Student(database.Query(getOriginalStudentSql).Rows(0))
        'Set up current student data in form
        txtStudentID.Text = student.studentID
        txtStudentName.Text = student.FirstName & " " & student.LastName
        'Set student's shop
        For Each shop In cboShops.Items
            If student.Shop = shop.ToString() Then
                cboShops.SelectedItem = shop
                Exit For
            End If
        Next
        'Set student's district
        For Each district In cboDistrict.Items
            If student.District = district.ToString() Then
                cboDistrict.SelectedItem = district
                Exit For
            End If
        Next
        'Set students session
        If student.Session = "AM" Then
            cboSession.SelectedIndex = 0
        Else
            cboSession.SelectedIndex = 1
        End If
        'Set students grade
        Try
            'Students grade fits the constraints of 9-12
            nudGrade.Value = Convert.ToInt32(student.Grade)
        Catch Ex As ArgumentOutOfRangeException
            'Student's grade does not fit the constraints of 9-12
            nudGrade.Maximum = student.Grade
        Finally
            'Set the grade to the form
            nudGrade.Value = Convert.ToInt32(student.Grade)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Nebermnd lol k by
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Create updated student object to be passed to database
        Dim updatedStudent As New Student()
        updatedStudent.studentID = txtStudentID.Text
        updatedStudent.FirstName = txtStudentName.Text.Substring(0, txtStudentName.Text.IndexOf(" "))
        updatedStudent.LastName = txtStudentName.Text.Substring(txtStudentName.Text.IndexOf(" "), txtStudentName.Text.Length - txtStudentName.Text.IndexOf(" "))
        updatedStudent.Shop = cboShops.SelectedItem.ToString()
        updatedStudent.District = cboDistrict.SelectedItem.ToString()
        updatedStudent.Session = cboSession.SelectedItem.ToString()
        updatedStudent.Grade = Convert.ToInt32(nudGrade.Value)
        'Update the student in the database
        Dim updateStudentSql As String = "UPDATE Students SET StudentID = " & updatedStudent.studentID & ", FirstName = '" & updatedStudent.FirstName & "', LastName = '" & updatedStudent.LastName.Trim & "', Shop = '" & updatedStudent.Shop & "', District = '" & updatedStudent.District & "', Session = '" & updatedStudent.Session & "', Grade = " & updatedStudent.Grade & " WHERE StudentID = '" & student.studentID & "'"
        database.NonQuery(updateStudentSql)
        'Reset the form to show the changes
        frmStudentView.refreshGUI()
        Me.Close()
    End Sub
End Class