Public Class frmCreateStudent
    Private database As New DatabaseInteraction()
    Private Sub frmCreateStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get shop criteria choices
        Dim shopQuery As String = "SELECT Shop FROM Students"
        Dim shopResults As DataTable = database.Query(shopQuery)
        For Each shop As DataRow In shopResults.Rows
            If Not cboShops.Items.Contains(shop.Item(0).ToString()) Then
                'Add found districts to the combobox
                cboShops.Items.Add(shop.Item(0).ToString())
            End If
        Next
        'Get district criteria choices
        Dim districtQuery As String = "SELECT District FROM Students"
        Dim districtResults As DataTable = database.Query(districtQuery)
        For Each district As DataRow In districtResults.Rows
            If Not cboDistrict.Items.Contains(district.Item(0).ToString()) Then
                'Add found districts to the combobox
                cboDistrict.Items.Add(district.Item(0).ToString())
            End If
        Next
    End Sub
    Private Const StudentIDLength As Integer = 9
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Create a new instance of student and prepare to be parsed to the database
        Dim newStudent As New Student()
        If txtStudentID.Text.Length = StudentIDLength And IsNumeric(txtStudentID.Text) Then
            'Student ID entry is valid as per length and composition
            newStudent.studentID = txtStudentID.Text
        Else
            'Student ID entry is invalid as per length and composition
            MessageBox.Show("Student ID input is invalid! A student ID must contain " & StudentIDLength.ToString & "numeric characters", "Invalid Student ID")
            Return
        End If
        If txtStudentName.Text.IndexOf(" ") <> -1 And Not IsNumeric(txtStudentName.Text) Then
            'Student name is valid: contains both a first and last name and is not composed of numeric characters
            newStudent.FirstName = txtStudentName.Text.Substring(0, txtStudentName.Text.IndexOf(" "))
            newStudent.LastName = txtStudentName.Text.Substring(txtStudentName.Text.IndexOf(" "), txtStudentName.Text.Length - txtStudentName.Text.IndexOf(" "))
        Else
            'Student name entry is invalid as per first/last name entry and composition
            MessageBox.Show("Student name input is invalid! A student name entry must contain both a first and last name!", "Name Input Error")
            Return
        End If
        If cboShops.SelectedIndex <> -1 Then
            'Shop selection entry is valid
            newStudent.Shop = cboShops.SelectedItem.ToString()
        Else
            'No shop was selected
            MessageBox.Show("You must select a shop", "Shop Selection Error")
            Return
        End If
        If cboDistrict.SelectedIndex <> -1 Then
            'District selection is valid
            newStudent.District = cboDistrict.SelectedItem.ToString()
        Else
            'No district was selected
            MessageBox.Show("You must selected a sending district", "District Selection Error")
            Return
        End If
        If cboSession.SelectedIndex <> -1 Then
            'Session selection is valid
            newStudent.Session = cboSession.SelectedItem.ToString()
        Else
            'No session was selected
            MessageBox.Show("You must select a BCTC Session", "Session Selection Error")
            Return
        End If
        'Grade selection is auto-validating with MAX and MIN properties
        newStudent.Grade = nudGrade.Value

        'Student instance is fully constructed. Write to database
        With newStudent
            Dim writeNewStudentSql As String = "INSERT INTO Students (StudentID, FirstName, LastName, Shop, District, Session, Grade) VALUES ('" & .studentID & "','" & .FirstName & "','" & .LastName & "','" & .Shop & "','" & .District & "','" & .Session & "','" & .Grade & "')"
        End With
    End Sub
End Class