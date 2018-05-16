Option Strict On
Public Class frmStudentManagement
    Dim idValid, nameValid, districtValid, shopValid, sessionValid, gradeValid As Boolean
    Dim database As New DatabaseInteraction
    Private Sub frmStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get district criteria choices
        Dim allDistricts As New Districts
        cboCreateDistrict.DataSource = allDistricts.GetAll()
        'Get shop criteria choices
        Dim allShops As New Shop
        cboCreateShop.DataSource = allShops.GetAll()
    End Sub
    Private Sub txtCreateID_focusLost(sender As Object, e As EventArgs) Handles txtCreateId.Leave
        'Validate the id field
        idValid = ValidateID(txtCreateId.Text)
    End Sub
    Private Function ValidateID(enteredID As String) As Boolean
        'Validation nested ifs for ID field
        If enteredID = "" Then
            'Id is blank
            SetError(txtCreateId, "ID cannot be left blank")
        Else
            If enteredID.IndexOf(" ") <> -1 Then
                'ID has spaces
                SetError(txtCreateId, "ID cannot contain spaces")
            Else
                If Not IsNumeric(enteredID) Then
                    'ID is not numeric
                    SetError(txtCreateId, "ID must be a numeric value")
                Else
                    'ID is valid
                    txtCreateId.Visible = False
                    lblCreateIDDisp.Text = txtCreateId.Text
                    lblCreateIDDisp.Visible = True
                    Return True
                End If
            End If
        End If
        'ID was not valid
        Return False
    End Function
    Private Sub lblCreateIDDisp_Click(sender As Object, e As EventArgs) Handles lblCreateIDDisp.Click
        'User wants to edit the entered data. Reshow the entry controls
        txtCreateId.Visible = True
        txtCreateId.BackColor = Color.White
        lblCreateIDDisp.Visible = False
        txtCreateId.Focus()
        txtCreateId.SelectAll()
    End Sub
    Private Sub txtCreateID_focusGain(sender As Object, e As EventArgs) Handles txtCreateId.Enter
        'Editting in the entry controls is easier with a white colored background
        txtCreateId.BackColor = Color.White
    End Sub
    Private Sub txtCreateName_focusLost(sender As Object, e As EventArgs) Handles txtCreateName.Leave
        'Validate name field
        nameValid = ValidateName(txtCreateName.Text)
    End Sub
    Public Function ValidateName(enteredName As String) As Boolean
        'Validate the name input from the name text input field
        If enteredName = "" Then
            'No name was entered
            SetError(txtCreateName, "Name cannot be left blank")
        Else
            'Name field has input
            If enteredName.IndexOf(" ") = -1 Then
                'There is no space in this name and therefore cannot be seperated for data purposes
                SetError(txtCreateName, "Name must contain a space splitting the first name from the last name")
            Else
                'There are both a first and last name entered
                If IsNumeric(enteredName) Then
                    'There is a number entered in as the name, thats not okay. The 5 cannot be silent....
                    SetError(txtCreateName, "Name cannot be a numeric value")
                Else
                    'The input has passed all levels of validation, set to the GUI to reflect input
                    txtCreateName.Visible = False
                    'Set the display GUI control to reflect the validated input
                    lblCreateNameDisp.Text = txtCreateName.Text
                    lblCreateNameDisp.Visible = True
                    'Name input is valid
                    Return True
                End If
            End If
        End If
        'Name input is not valid
        Return False
    End Function
    Private Sub lblCreateNameDisp_Clicked(sender As Object, e As EventArgs) Handles lblCreateNameDisp.Click
        'The user wants to edit the displayed input. Revert the GUI back to the default textbox controls
        txtCreateName.Visible = True
        txtCreateName.BackColor = Color.White
        lblCreateNameDisp.Visible = False
        txtCreateName.Focus()
        txtCreateName.SelectAll()
    End Sub
    Private Sub cboCreateDistrict_LostFocus(sender As Object, e As EventArgs) Handles cboCreateDistrict.Leave
        'Validate the district input from the district combobox input control
        Try
            If IsNothing(cboCreateDistrict.SelectedItem) Then
                'Nothing has been selected in the combobox, throw a new null reference exception
                Throw New NullReferenceException
            Else
                'A district has been selected, this is valid input
                districtValid = True
            End If
        Catch ex As NullReferenceException
            'Nothing was selected from the combobox
            If cboCreateDistrict.Text = "" Or Not cboCreateDistrict.Items.Contains(cboCreateDistrict.Text) Then
                SetError(cboCreateDistrict, "District selection cannot be left blank")
            Else
                districtValid = True
            End If
        Finally
            If districtValid Then
                'The district has been corrected or was inputed using text
                'Set the display control to show the valid input
                cboCreateDistrict.Visible = False
                lblCreateDistrictDisp.Visible = True
                lblCreateDistrictDisp.Text = cboCreateDistrict.Text
            End If
        End Try
    End Sub
    Private Sub cboCreateDistrict_GainedFocus(sender As Object, e As EventArgs) Handles cboCreateDistrict.Enter
        'Reset the combobox color to assume valid data is being entered
        cboCreateDistrict.BackColor = Color.White
    End Sub
    Private Sub lblCreateDistrictDisp_Clicked(sender As Object, e As EventArgs) Handles lblCreateDistrictDisp.Click
        'Revert form back to show the textbox to edit their input
        cboCreateDistrict.Visible = True
        cboCreateDistrict.BackColor = Color.White
        lblCreateDistrictDisp.Visible = False
        cboCreateDistrict.Focus()
        cboCreateDistrict.SelectAll()
    End Sub
    Private Sub cboCreateShop_LostFocus(sender As Object, e As EventArgs) Handles cboCreateShop.Leave
        Try
            If IsNothing(cboCreateShop.SelectedItem) Then
                Throw New NullReferenceException
            Else
                shopValid = True
            End If
        Catch ex As NullReferenceException
            If cboCreateShop.Text = "" Or Not cboCreateShop.Items.Contains(cboCreateShop.Text) Then
                SetError(cboCreateShop, "District selection cannot be left blank")
            Else
                shopValid = True
            End If
        Finally
            If shopValid Then
                cboCreateShop.Visible = False
                lblCreateShopDisp.Visible = True
                lblCreateShopDisp.Text = cboCreateShop.Text
            End If
        End Try
    End Sub
    Private Sub cboCreateShop_GainedFocus(sender As Object, e As EventArgs) Handles cboCreateShop.Enter
        cboCreateShop.BackColor = Color.White
    End Sub
    Private Sub lblCreateShop_Clicked(sender As Object, e As EventArgs) Handles lblCreateShopDisp.Click
        cboCreateShop.Visible = True
        cboCreateShop.BackColor = Color.White
        lblCreateShopDisp.Visible = False
        cboCreateDistrict.Focus()
        cboCreateDistrict.SelectAll()
    End Sub
    Private Sub cboCreateSession_lostFocus(sender As Object, e As EventArgs) Handles cboCreateSession.Leave
        Try
            If IsNothing(cboCreateSession.SelectedItem) Then
                Throw New NullReferenceException
            Else
                sessionValid = True
            End If
        Catch ex As NullReferenceException
            If cboCreateSession.Text = "" Or Not cboCreateSession.Items.Contains(cboCreateSession.Text) Then
                SetError(cboCreateSession, "Session selection cannot be left blank")
            Else
                sessionValid = True
            End If
        Finally
            If sessionValid Then
                cboCreateSession.Visible = False
                lblCreateSessionDisp.Visible = True
                lblCreateSessionDisp.Text = cboCreateSession.Text
            End If
        End Try
    End Sub
    Private Sub cboCreateSession_gainedFocus(sender As Object, e As EventArgs) Handles cboCreateSession.Enter
        cboCreateSession.BackColor = Color.White
    End Sub
    Private Sub lblCreateSessionDisp_Click(sender As Object, e As EventArgs) Handles lblCreateSessionDisp.Click
        cboCreateSession.Visible = True
        cboCreateSession.BackColor = Color.White
        lblCreateSessionDisp.Visible = False
        cboCreateSession.Focus()
        cboCreateSession.SelectAll()
    End Sub
    Private Sub nudCreateGrade_lostFocus(sender As Object, e As EventArgs) Handles nudCreateGrade.Leave
        Try
            If IsNothing(nudCreateGrade.Value) Then
                Throw New NullReferenceException
            Else
                gradeValid = True
            End If
        Catch ex As NullReferenceException
            If nudCreateGrade.Text = "" Then
                SetError(nudCreateGrade, "Session selection cannot be left blank")
            Else
                gradeValid = True
            End If
        Finally
            If gradeValid Then
                nudCreateGrade.Visible = False
                lblCreateGradeDisp.Visible = True
                lblCreateGradeDisp.Text = nudCreateGrade.Text
            End If
        End Try
    End Sub
    Private Sub nudCreateGrade_gainedFocus(sender As Object, e As EventArgs) Handles nudCreateGrade.Enter
        nudCreateGrade.BackColor = Color.White
    End Sub
    Private Sub lblCreateGradeDisp_Click(sender As Object, e As EventArgs) Handles lblCreateGradeDisp.Click
        nudCreateGrade.Visible = True
        nudCreateGrade.BackColor = Color.White
        lblCreateGradeDisp.Visible = False
        nudCreateGrade.Focus()
    End Sub
    Private Sub SetError(errorControl As Control, errorMessage As String)
        Dim errorToolTip As New ToolTip
        errorControl.BackColor = Color.Red
        errorToolTip.ToolTipTitle = "Input Error"
        errorToolTip.Show(errorMessage, errorControl, 5000)
    End Sub
    Private Sub btnCreateStudent_Click(sender As Object, e As EventArgs) Handles btnCreateStudent.Click
        If idValid And nameValid And districtValid And shopValid And sessionValid And gradeValid Then
            Dim studentToCreate As New Student
            studentToCreate.studentID = txtCreateId.Text
            studentToCreate.FirstName = txtCreateName.Text.Substring(0, txtCreateName.Text.IndexOf(" "))
            studentToCreate.LastName = txtCreateName.Text.Substring(txtCreateName.Text.IndexOf(" "), txtCreateName.Text.Length - txtCreateName.Text.IndexOf(" ")).Trim
            studentToCreate.District = cboCreateDistrict.SelectedItem.ToString
            studentToCreate.Shop = cboCreateShop.SelectedItem.ToString
            studentToCreate.Session = cboCreateSession.SelectedItem.ToString
            studentToCreate.Grade = Convert.ToInt32(nudCreateGrade.Value)
            If Not studentToCreate.Exists() Then
                studentToCreate.CreateStudent()
            Else
                Dim openStudent As DialogResult = MessageBox.Show("This student already exists. Would you like to open their profile?", "Student Exists!", MessageBoxButtons.YesNoCancel)
                If openStudent = DialogResult.Yes Then
                    frmStats.selectedStudentID = studentToCreate.studentID
                    Me.Close()
                    frmStudentView.Show()
                Else openStudent = DialogResult.No
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub btnCreateClear_Click(sender As Object, e As EventArgs) Handles btnCreateClear.Click
        txtCreateId.Text = ""
        txtCreateId.BackColor = Color.White
        txtCreateId.Visible = True
        lblCreateIDDisp.Visible = False
        txtCreateName.Clear()
        txtCreateName.BackColor = Color.White
        txtCreateName.Visible = True
        lblCreateNameDisp.Visible = False
        cboCreateDistrict.SelectedIndex = -1
        cboCreateDistrict.BackColor = Color.White
        cboCreateDistrict.Visible = True
        lblCreateDistrictDisp.Visible = False
        cboCreateShop.SelectedIndex = -1
        cboCreateShop.BackColor = Color.White
        cboCreateShop.Visible = True
        lblCreateShopDisp.Visible = False
        cboCreateSession.SelectedIndex = -1
        cboCreateSession.BackColor = Color.White
        cboCreateSession.Visible = True
        lblCreateSessionDisp.Visible = False
        nudCreateGrade.Value = 10
        nudCreateGrade.BackColor = Color.White
        nudCreateGrade.Visible = True
        lblCreateGradeDisp.Visible = False
    End Sub
End Class