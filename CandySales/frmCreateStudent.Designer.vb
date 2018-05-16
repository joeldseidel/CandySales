<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.cboShops = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.nudGrade = New System.Windows.Forms.NumericUpDown()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.cboSession = New System.Windows.Forms.ComboBox()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblShop = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.nudGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivider.Location = New System.Drawing.Point(10, 44)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(424, 3)
        Me.lblDivider.TabIndex = 45
        '
        'cboDistrict
        '
        Me.cboDistrict.DropDownWidth = 400
        Me.cboDistrict.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(154, 210)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(270, 29)
        Me.cboDistrict.TabIndex = 44
        '
        'cboShops
        '
        Me.cboShops.DropDownWidth = 400
        Me.cboShops.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShops.FormattingEnabled = True
        Me.cboShops.Location = New System.Drawing.Point(154, 161)
        Me.cboShops.Name = "cboShops"
        Me.cboShops.Size = New System.Drawing.Size(270, 29)
        Me.cboShops.TabIndex = 43
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(274, 329)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(150, 38)
        Me.btnCreate.TabIndex = 38
        Me.btnCreate.Text = "Create Student"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(33, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 38)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'nudGrade
        '
        Me.nudGrade.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGrade.Location = New System.Drawing.Point(376, 260)
        Me.nudGrade.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGrade.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudGrade.Name = "nudGrade"
        Me.nudGrade.Size = New System.Drawing.Size(48, 29)
        Me.nudGrade.TabIndex = 36
        Me.nudGrade.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(315, 262)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(55, 21)
        Me.lblGrade.TabIndex = 42
        Me.lblGrade.Text = "Grade:"
        '
        'cboSession
        '
        Me.cboSession.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSession.FormattingEnabled = True
        Me.cboSession.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboSession.Location = New System.Drawing.Point(154, 259)
        Me.cboSession.Name = "cboSession"
        Me.cboSession.Size = New System.Drawing.Size(92, 29)
        Me.cboSession.TabIndex = 35
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(33, 262)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(66, 21)
        Me.lblSession.TabIndex = 41
        Me.lblSession.Text = "Session:"
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistrict.Location = New System.Drawing.Point(33, 213)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(62, 21)
        Me.lblDistrict.TabIndex = 40
        Me.lblDistrict.Text = "District:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(154, 63)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(270, 29)
        Me.txtStudentID.TabIndex = 30
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(29, 66)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(85, 21)
        Me.lblStudentID.TabIndex = 37
        Me.lblStudentID.Text = "Student ID:"
        '
        'lblShop
        '
        Me.lblShop.AutoSize = True
        Me.lblShop.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShop.Location = New System.Drawing.Point(33, 164)
        Me.lblShop.Name = "lblShop"
        Me.lblShop.Size = New System.Drawing.Size(49, 21)
        Me.lblShop.TabIndex = 34
        Me.lblShop.Text = "Shop:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(154, 112)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(270, 29)
        Me.txtStudentName.TabIndex = 32
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(29, 115)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(115, 21)
        Me.lblStudentName.TabIndex = 33
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(168, 32)
        Me.lblHeader.TabIndex = 31
        Me.lblHeader.Text = "Create Student"
        '
        'frmCreateStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 379)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.cboDistrict)
        Me.Controls.Add(Me.cboShops)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.nudGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.cboSession)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblShop)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmCreateStudent"
        Me.Text = "frmCreateStudent"
        CType(Me.nudGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDivider As Label
    Friend WithEvents cboDistrict As ComboBox
    Friend WithEvents cboShops As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents nudGrade As NumericUpDown
    Friend WithEvents lblGrade As Label
    Friend WithEvents cboSession As ComboBox
    Friend WithEvents lblSession As Label
    Friend WithEvents lblDistrict As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblShop As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblHeader As Label
End Class
