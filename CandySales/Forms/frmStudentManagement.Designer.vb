<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbcStudentManagement = New System.Windows.Forms.TabControl()
        Me.tbpCreateStudent = New System.Windows.Forms.TabPage()
        Me.lblCreateGradeDisp = New System.Windows.Forms.Label()
        Me.lblCreateSessionDisp = New System.Windows.Forms.Label()
        Me.lblCreateShopDisp = New System.Windows.Forms.Label()
        Me.lblCreateDistrictDisp = New System.Windows.Forms.Label()
        Me.lblCreateNameDisp = New System.Windows.Forms.Label()
        Me.lblCreateIDDisp = New System.Windows.Forms.Label()
        Me.btnCreateClear = New System.Windows.Forms.Button()
        Me.btnCreateStudent = New System.Windows.Forms.Button()
        Me.cboCreateSession = New System.Windows.Forms.ComboBox()
        Me.lblCreateSession = New System.Windows.Forms.Label()
        Me.nudCreateGrade = New System.Windows.Forms.NumericUpDown()
        Me.lblCreateGrade = New System.Windows.Forms.Label()
        Me.cboCreateShop = New System.Windows.Forms.ComboBox()
        Me.lblCreateShop = New System.Windows.Forms.Label()
        Me.cboCreateDistrict = New System.Windows.Forms.ComboBox()
        Me.lblCreateDistrict = New System.Windows.Forms.Label()
        Me.txtCreateName = New System.Windows.Forms.TextBox()
        Me.lblCreateName = New System.Windows.Forms.Label()
        Me.txtCreateId = New System.Windows.Forms.TextBox()
        Me.lblCreateID = New System.Windows.Forms.Label()
        Me.tbcStudentManagement.SuspendLayout()
        Me.tbpCreateStudent.SuspendLayout()
        CType(Me.nudCreateGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcStudentManagement
        '
        Me.tbcStudentManagement.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcStudentManagement.Controls.Add(Me.tbpCreateStudent)
        Me.tbcStudentManagement.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcStudentManagement.Location = New System.Drawing.Point(11, 9)
        Me.tbcStudentManagement.Name = "tbcStudentManagement"
        Me.tbcStudentManagement.SelectedIndex = 0
        Me.tbcStudentManagement.Size = New System.Drawing.Size(659, 349)
        Me.tbcStudentManagement.TabIndex = 0
        '
        'tbpCreateStudent
        '
        Me.tbpCreateStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateGradeDisp)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateSessionDisp)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateShopDisp)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateDistrictDisp)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateNameDisp)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateIDDisp)
        Me.tbpCreateStudent.Controls.Add(Me.btnCreateClear)
        Me.tbpCreateStudent.Controls.Add(Me.btnCreateStudent)
        Me.tbpCreateStudent.Controls.Add(Me.cboCreateSession)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateSession)
        Me.tbpCreateStudent.Controls.Add(Me.nudCreateGrade)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateGrade)
        Me.tbpCreateStudent.Controls.Add(Me.cboCreateShop)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateShop)
        Me.tbpCreateStudent.Controls.Add(Me.cboCreateDistrict)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateDistrict)
        Me.tbpCreateStudent.Controls.Add(Me.txtCreateName)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateName)
        Me.tbpCreateStudent.Controls.Add(Me.txtCreateId)
        Me.tbpCreateStudent.Controls.Add(Me.lblCreateID)
        Me.tbpCreateStudent.Location = New System.Drawing.Point(4, 33)
        Me.tbpCreateStudent.Name = "tbpCreateStudent"
        Me.tbpCreateStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCreateStudent.Size = New System.Drawing.Size(651, 312)
        Me.tbpCreateStudent.TabIndex = 0
        Me.tbpCreateStudent.Text = "Create Student"
        Me.tbpCreateStudent.UseVisualStyleBackColor = True
        '
        'lblCreateGradeDisp
        '
        Me.lblCreateGradeDisp.AutoSize = True
        Me.lblCreateGradeDisp.Location = New System.Drawing.Point(266, 254)
        Me.lblCreateGradeDisp.Name = "lblCreateGradeDisp"
        Me.lblCreateGradeDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateGradeDisp.TabIndex = 19
        Me.lblCreateGradeDisp.Text = "Label1"
        Me.lblCreateGradeDisp.Visible = False
        '
        'lblCreateSessionDisp
        '
        Me.lblCreateSessionDisp.AutoSize = True
        Me.lblCreateSessionDisp.Location = New System.Drawing.Point(113, 253)
        Me.lblCreateSessionDisp.Name = "lblCreateSessionDisp"
        Me.lblCreateSessionDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateSessionDisp.TabIndex = 18
        Me.lblCreateSessionDisp.Text = "Label1"
        Me.lblCreateSessionDisp.Visible = False
        '
        'lblCreateShopDisp
        '
        Me.lblCreateShopDisp.AutoSize = True
        Me.lblCreateShopDisp.Location = New System.Drawing.Point(113, 197)
        Me.lblCreateShopDisp.Name = "lblCreateShopDisp"
        Me.lblCreateShopDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateShopDisp.TabIndex = 17
        Me.lblCreateShopDisp.Text = "Label1"
        Me.lblCreateShopDisp.Visible = False
        '
        'lblCreateDistrictDisp
        '
        Me.lblCreateDistrictDisp.AutoSize = True
        Me.lblCreateDistrictDisp.Location = New System.Drawing.Point(113, 140)
        Me.lblCreateDistrictDisp.Name = "lblCreateDistrictDisp"
        Me.lblCreateDistrictDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateDistrictDisp.TabIndex = 16
        Me.lblCreateDistrictDisp.Text = "Label1"
        Me.lblCreateDistrictDisp.Visible = False
        '
        'lblCreateNameDisp
        '
        Me.lblCreateNameDisp.AutoSize = True
        Me.lblCreateNameDisp.Location = New System.Drawing.Point(113, 82)
        Me.lblCreateNameDisp.Name = "lblCreateNameDisp"
        Me.lblCreateNameDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateNameDisp.TabIndex = 15
        Me.lblCreateNameDisp.Text = "Label1"
        Me.lblCreateNameDisp.Visible = False
        '
        'lblCreateIDDisp
        '
        Me.lblCreateIDDisp.AutoSize = True
        Me.lblCreateIDDisp.Location = New System.Drawing.Point(113, 29)
        Me.lblCreateIDDisp.Name = "lblCreateIDDisp"
        Me.lblCreateIDDisp.Size = New System.Drawing.Size(52, 21)
        Me.lblCreateIDDisp.TabIndex = 14
        Me.lblCreateIDDisp.Text = "Label1"
        Me.lblCreateIDDisp.Visible = False
        '
        'btnCreateClear
        '
        Me.btnCreateClear.Location = New System.Drawing.Point(469, 78)
        Me.btnCreateClear.Name = "btnCreateClear"
        Me.btnCreateClear.Size = New System.Drawing.Size(174, 53)
        Me.btnCreateClear.TabIndex = 13
        Me.btnCreateClear.Text = "Clear Fields"
        Me.btnCreateClear.UseVisualStyleBackColor = True
        '
        'btnCreateStudent
        '
        Me.btnCreateStudent.Location = New System.Drawing.Point(469, 12)
        Me.btnCreateStudent.Name = "btnCreateStudent"
        Me.btnCreateStudent.Size = New System.Drawing.Size(174, 53)
        Me.btnCreateStudent.TabIndex = 12
        Me.btnCreateStudent.Text = "Create Student"
        Me.btnCreateStudent.UseVisualStyleBackColor = True
        '
        'cboCreateSession
        '
        Me.cboCreateSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCreateSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCreateSession.FormattingEnabled = True
        Me.cboCreateSession.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboCreateSession.Location = New System.Drawing.Point(113, 249)
        Me.cboCreateSession.Name = "cboCreateSession"
        Me.cboCreateSession.Size = New System.Drawing.Size(77, 29)
        Me.cboCreateSession.TabIndex = 11
        '
        'lblCreateSession
        '
        Me.lblCreateSession.AutoSize = True
        Me.lblCreateSession.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateSession.Location = New System.Drawing.Point(6, 249)
        Me.lblCreateSession.Name = "lblCreateSession"
        Me.lblCreateSession.Size = New System.Drawing.Size(77, 25)
        Me.lblCreateSession.TabIndex = 10
        Me.lblCreateSession.Text = "Session:"
        '
        'nudCreateGrade
        '
        Me.nudCreateGrade.Location = New System.Drawing.Point(268, 250)
        Me.nudCreateGrade.Name = "nudCreateGrade"
        Me.nudCreateGrade.Size = New System.Drawing.Size(58, 29)
        Me.nudCreateGrade.TabIndex = 13
        '
        'lblCreateGrade
        '
        Me.lblCreateGrade.AutoSize = True
        Me.lblCreateGrade.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateGrade.Location = New System.Drawing.Point(196, 249)
        Me.lblCreateGrade.Name = "lblCreateGrade"
        Me.lblCreateGrade.Size = New System.Drawing.Size(66, 25)
        Me.lblCreateGrade.TabIndex = 8
        Me.lblCreateGrade.Text = "Grade:"
        '
        'cboCreateShop
        '
        Me.cboCreateShop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCreateShop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCreateShop.FormattingEnabled = True
        Me.cboCreateShop.Location = New System.Drawing.Point(113, 193)
        Me.cboCreateShop.Name = "cboCreateShop"
        Me.cboCreateShop.Size = New System.Drawing.Size(270, 29)
        Me.cboCreateShop.TabIndex = 7
        '
        'lblCreateShop
        '
        Me.lblCreateShop.AutoSize = True
        Me.lblCreateShop.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateShop.Location = New System.Drawing.Point(6, 193)
        Me.lblCreateShop.Name = "lblCreateShop"
        Me.lblCreateShop.Size = New System.Drawing.Size(58, 25)
        Me.lblCreateShop.TabIndex = 6
        Me.lblCreateShop.Text = "Shop:"
        '
        'cboCreateDistrict
        '
        Me.cboCreateDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCreateDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCreateDistrict.FormattingEnabled = True
        Me.cboCreateDistrict.Location = New System.Drawing.Point(113, 136)
        Me.cboCreateDistrict.Name = "cboCreateDistrict"
        Me.cboCreateDistrict.Size = New System.Drawing.Size(270, 29)
        Me.cboCreateDistrict.TabIndex = 5
        '
        'lblCreateDistrict
        '
        Me.lblCreateDistrict.AutoSize = True
        Me.lblCreateDistrict.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateDistrict.Location = New System.Drawing.Point(6, 136)
        Me.lblCreateDistrict.Name = "lblCreateDistrict"
        Me.lblCreateDistrict.Size = New System.Drawing.Size(72, 25)
        Me.lblCreateDistrict.TabIndex = 4
        Me.lblCreateDistrict.Text = "District:"
        '
        'txtCreateName
        '
        Me.txtCreateName.Location = New System.Drawing.Point(113, 78)
        Me.txtCreateName.Name = "txtCreateName"
        Me.txtCreateName.Size = New System.Drawing.Size(270, 29)
        Me.txtCreateName.TabIndex = 2
        '
        'lblCreateName
        '
        Me.lblCreateName.AutoSize = True
        Me.lblCreateName.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateName.Location = New System.Drawing.Point(6, 78)
        Me.lblCreateName.Name = "lblCreateName"
        Me.lblCreateName.Size = New System.Drawing.Size(66, 25)
        Me.lblCreateName.TabIndex = 2
        Me.lblCreateName.Text = "Name:"
        '
        'txtCreateId
        '
        Me.txtCreateId.Location = New System.Drawing.Point(113, 25)
        Me.txtCreateId.Name = "txtCreateId"
        Me.txtCreateId.Size = New System.Drawing.Size(270, 29)
        Me.txtCreateId.TabIndex = 1
        '
        'lblCreateID
        '
        Me.lblCreateID.AutoSize = True
        Me.lblCreateID.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateID.Location = New System.Drawing.Point(6, 25)
        Me.lblCreateID.Name = "lblCreateID"
        Me.lblCreateID.Size = New System.Drawing.Size(101, 25)
        Me.lblCreateID.TabIndex = 0
        Me.lblCreateID.Text = "Student ID:"
        '
        'frmStudentManagement
        '
        Me.AcceptButton = Me.btnCreateStudent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 366)
        Me.Controls.Add(Me.tbcStudentManagement)
        Me.Name = "frmStudentManagement"
        Me.Text = "Student Management"
        Me.tbcStudentManagement.ResumeLayout(False)
        Me.tbpCreateStudent.ResumeLayout(False)
        Me.tbpCreateStudent.PerformLayout()
        CType(Me.nudCreateGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcStudentManagement As TabControl
    Friend WithEvents tbpCreateStudent As TabPage
    Friend WithEvents nudCreateGrade As NumericUpDown
    Friend WithEvents lblCreateGrade As Label
    Friend WithEvents cboCreateShop As ComboBox
    Friend WithEvents lblCreateShop As Label
    Friend WithEvents cboCreateDistrict As ComboBox
    Friend WithEvents lblCreateDistrict As Label
    Friend WithEvents txtCreateName As TextBox
    Friend WithEvents lblCreateName As Label
    Friend WithEvents txtCreateId As TextBox
    Friend WithEvents lblCreateID As Label
    Friend WithEvents btnCreateClear As Button
    Friend WithEvents btnCreateStudent As Button
    Friend WithEvents cboCreateSession As ComboBox
    Friend WithEvents lblCreateSession As Label
    Friend WithEvents lblCreateGradeDisp As Label
    Friend WithEvents lblCreateSessionDisp As Label
    Friend WithEvents lblCreateShopDisp As Label
    Friend WithEvents lblCreateDistrictDisp As Label
    Friend WithEvents lblCreateNameDisp As Label
    Friend WithEvents lblCreateIDDisp As Label
End Class
