<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditStudent
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblShop = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.cboSession = New System.Windows.Forms.ComboBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.nudGrade = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboShops = New System.Windows.Forms.ComboBox()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.lblDivider = New System.Windows.Forms.Label()
        CType(Me.nudGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(267, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Edit Student Information"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(30, 119)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(115, 21)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Student Name: "
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(155, 116)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(270, 29)
        Me.txtStudentName.TabIndex = 1
        '
        'lblShop
        '
        Me.lblShop.AutoSize = True
        Me.lblShop.Location = New System.Drawing.Point(34, 168)
        Me.lblShop.Name = "lblShop"
        Me.lblShop.Size = New System.Drawing.Size(49, 21)
        Me.lblShop.TabIndex = 3
        Me.lblShop.Text = "Shop:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(34, 70)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(85, 21)
        Me.lblStudentID.TabIndex = 5
        Me.lblStudentID.Text = "Student ID:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(155, 67)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(270, 29)
        Me.txtStudentID.TabIndex = 0
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(34, 217)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(62, 21)
        Me.lblDistrict.TabIndex = 7
        Me.lblDistrict.Text = "District:"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Location = New System.Drawing.Point(34, 266)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(66, 21)
        Me.lblSession.TabIndex = 9
        Me.lblSession.Text = "Session:"
        '
        'cboSession
        '
        Me.cboSession.FormattingEnabled = True
        Me.cboSession.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboSession.Location = New System.Drawing.Point(155, 263)
        Me.cboSession.Name = "cboSession"
        Me.cboSession.Size = New System.Drawing.Size(92, 29)
        Me.cboSession.TabIndex = 4
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(316, 266)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(55, 21)
        Me.lblGrade.TabIndex = 11
        Me.lblGrade.Text = "Grade:"
        '
        'nudGrade
        '
        Me.nudGrade.Location = New System.Drawing.Point(377, 264)
        Me.nudGrade.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGrade.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudGrade.Name = "nudGrade"
        Me.nudGrade.Size = New System.Drawing.Size(48, 29)
        Me.nudGrade.TabIndex = 5
        Me.nudGrade.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(34, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 38)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(275, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 38)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update Student"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboShops
        '
        Me.cboShops.DropDownWidth = 400
        Me.cboShops.FormattingEnabled = True
        Me.cboShops.Location = New System.Drawing.Point(155, 165)
        Me.cboShops.Name = "cboShops"
        Me.cboShops.Size = New System.Drawing.Size(270, 29)
        Me.cboShops.TabIndex = 12
        '
        'cboDistrict
        '
        Me.cboDistrict.DropDownWidth = 400
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(155, 214)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(270, 29)
        Me.cboDistrict.TabIndex = 13
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(11, 48)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(424, 3)
        Me.lblDivider.TabIndex = 29
        '
        'frmEditStudent
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 383)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.cboDistrict)
        Me.Controls.Add(Me.cboShops)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditStudent"
        Me.Text = "Edit Student"
        CType(Me.nudGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents lblShop As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents cboSession As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents nudGrade As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cboShops As System.Windows.Forms.ComboBox
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents lblDivider As System.Windows.Forms.Label
End Class
