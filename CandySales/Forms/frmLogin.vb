Option Strict On
Public Class frmLogin
    Dim loginAttempts As Integer = 0
    Public database As DatabaseInteraction
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set GUI to reflect start-up screen
        prgDBConn.Visible = False
        txtUsername.Focus()
        'Attempt to connect to database
        Try
            database = New DatabaseInteraction
            database.Query("SELECT * FROM Students WHERE StudentID = -1")
        Catch ex As Exception
            MsgBox("A problem with establishing a data connection has been encountered. Please seek technical support if problem persists", MsgBoxStyle.Critical, "Data Connection Error")
            Me.Close()
        Finally
        End Try
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Basic validation, check database for user login eligibility, count login attempts, and allow apporved user access to further forms
        prgDBConn.Visible = True
        prgDBConn.Enabled = True
        'Form data validation
        If loginAttempts >= 5 Then
            'Exceeded login attempts
            ShowErrorMessage("You have attempted to login incorrectly more than 5 times. Try again later", "Exceeded Login Attempts")
            prgDBConn.Visible = False
            Return
        ElseIf txtUsername.Text = "" Then
            'Did not enter a user name
            ShowErrorMessage("You did not enter a username", "Missing Username")
            prgDBConn.Visible = False
            Return
        ElseIf txtPassword.Text = "" Then
            'Did not enter a password
            ShowErrorMessage("You did not enter a password", "Missing Password")
            prgDBConn.Visible = False
            Return
        End If
        'Database query to check for valid admin login
        Dim allAdmins As DataTable = New DatabaseInteraction().Query("SELECT * FROM AdminLogins")
        Dim loginQuery = "SELECT * FROM AdminLogins WHERE Username='" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'"
        Dim matchingLogins As DataTable = New DatabaseInteraction().Query(loginQuery)

        If matchingLogins.Rows.Count > 0 And matchingLogins.Rows.Count < 2 Then
            'Set username and password to the shared values so the current admin object can be set in the order and stats form

            frmOrder.username = txtUsername.Text
            frmOrder.password = txtPassword.Text
            'Move user to next form
            frmOrder.Show()
            'Close this form
            Me.Close()
        Else
            'Login is invalid
            prgDBConn.Enabled = False
            prgDBConn.Visible = False
            ShowErrorMessage("Login was invalid", "Login Error")
            txtPassword.Select()
            txtPassword.Text = ""
            loginAttempts += 1
        End If
    End Sub
    Public Shared Sub ShowErrorMessage(message As String, title As String)
        MsgBox(message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, title)
    End Sub
End Class
