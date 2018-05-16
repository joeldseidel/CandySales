<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder
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
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.radCheck = New System.Windows.Forms.RadioButton()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblItemToWithdraw = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.btnClearStudent = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cboItemToWithdraw = New System.Windows.Forms.ComboBox()
        Me.cboOrders = New System.Windows.Forms.ComboBox()
        Me.btnPayAmount = New System.Windows.Forms.Button()
        Me.btnWithdrawItem = New System.Windows.Forms.Button()
        Me.grpInformation = New System.Windows.Forms.GroupBox()
        Me.lblDebt = New System.Windows.Forms.Label()
        Me.lblItemsOut = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGetInfoOnStudent = New System.Windows.Forms.Button()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMethods.SuspendLayout()
        Me.grpInformation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.radCash)
        Me.grpMethods.Controls.Add(Me.radCheck)
        Me.grpMethods.Enabled = False
        Me.grpMethods.Location = New System.Drawing.Point(414, 333)
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.Size = New System.Drawing.Size(165, 40)
        Me.grpMethods.TabIndex = 44
        Me.grpMethods.TabStop = False
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Checked = True
        Me.radCash.Location = New System.Drawing.Point(6, 12)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(49, 17)
        Me.radCash.TabIndex = 8
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'radCheck
        '
        Me.radCheck.AutoSize = True
        Me.radCheck.Enabled = False
        Me.radCheck.Location = New System.Drawing.Point(95, 12)
        Me.radCheck.Name = "radCheck"
        Me.radCheck.Size = New System.Drawing.Size(56, 17)
        Me.radCheck.TabIndex = 7
        Me.radCheck.Text = "Check"
        Me.radCheck.UseVisualStyleBackColor = True
        '
        'lblDivider
        '
        Me.lblDivider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(1, 206)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(741, 2)
        Me.lblDivider.TabIndex = 43
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Enabled = False
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(349, 343)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(59, 19)
        Me.lblPaymentMethod.TabIndex = 42
        Me.lblPaymentMethod.Text = "Method:"
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Enabled = False
        Me.lblPaymentAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentAmount.Location = New System.Drawing.Point(41, 343)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(82, 19)
        Me.lblPaymentAmount.TabIndex = 41
        Me.lblPaymentAmount.Text = "Amount ($):"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Enabled = False
        Me.lblOrder.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(41, 296)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(88, 19)
        Me.lblOrder.TabIndex = 40
        Me.lblOrder.Text = "Select Order:"
        '
        'lblItemToWithdraw
        '
        Me.lblItemToWithdraw.AutoSize = True
        Me.lblItemToWithdraw.Enabled = False
        Me.lblItemToWithdraw.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemToWithdraw.Location = New System.Drawing.Point(41, 244)
        Me.lblItemToWithdraw.Name = "lblItemToWithdraw"
        Me.lblItemToWithdraw.Size = New System.Drawing.Size(80, 19)
        Me.lblItemToWithdraw.TabIndex = 39
        Me.lblItemToWithdraw.Text = "Select Item:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(41, 58)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(78, 19)
        Me.lblStudentID.TabIndex = 38
        Me.lblStudentID.Text = "Student ID:"
        '
        'btnClearStudent
        '
        Me.btnClearStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearStudent.Enabled = False
        Me.btnClearStudent.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearStudent.Location = New System.Drawing.Point(615, 114)
        Me.btnClearStudent.Name = "btnClearStudent"
        Me.btnClearStudent.Size = New System.Drawing.Size(249, 67)
        Me.btnClearStudent.TabIndex = 2
        Me.btnClearStudent.Text = "Clear Student"
        Me.btnClearStudent.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(148, 341)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(185, 26)
        Me.txtAmount.TabIndex = 7
        Me.txtAmount.Text = "Payment Amount"
        '
        'cboItemToWithdraw
        '
        Me.cboItemToWithdraw.Enabled = False
        Me.cboItemToWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemToWithdraw.FormattingEnabled = True
        Me.cboItemToWithdraw.Location = New System.Drawing.Point(148, 239)
        Me.cboItemToWithdraw.Name = "cboItemToWithdraw"
        Me.cboItemToWithdraw.Size = New System.Drawing.Size(205, 28)
        Me.cboItemToWithdraw.TabIndex = 5
        '
        'cboOrders
        '
        Me.cboOrders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboOrders.Enabled = False
        Me.cboOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrders.FormattingEnabled = True
        Me.cboOrders.Location = New System.Drawing.Point(148, 291)
        Me.cboOrders.Name = "cboOrders"
        Me.cboOrders.Size = New System.Drawing.Size(431, 28)
        Me.cboOrders.TabIndex = 6
        '
        'btnPayAmount
        '
        Me.btnPayAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayAmount.Enabled = False
        Me.btnPayAmount.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayAmount.Location = New System.Drawing.Point(615, 306)
        Me.btnPayAmount.Name = "btnPayAmount"
        Me.btnPayAmount.Size = New System.Drawing.Size(249, 67)
        Me.btnPayAmount.TabIndex = 4
        Me.btnPayAmount.Text = "Pay An Amount"
        Me.btnPayAmount.UseVisualStyleBackColor = True
        '
        'btnWithdrawItem
        '
        Me.btnWithdrawItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWithdrawItem.Enabled = False
        Me.btnWithdrawItem.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdrawItem.Location = New System.Drawing.Point(615, 228)
        Me.btnWithdrawItem.Name = "btnWithdrawItem"
        Me.btnWithdrawItem.Size = New System.Drawing.Size(249, 67)
        Me.btnWithdrawItem.TabIndex = 3
        Me.btnWithdrawItem.Text = "Withdraw Item"
        Me.btnWithdrawItem.UseVisualStyleBackColor = True
        '
        'grpInformation
        '
        Me.grpInformation.Controls.Add(Me.lblDebt)
        Me.grpInformation.Controls.Add(Me.lblItemsOut)
        Me.grpInformation.Controls.Add(Me.lblName)
        Me.grpInformation.Controls.Add(Me.Label5)
        Me.grpInformation.Controls.Add(Me.Label6)
        Me.grpInformation.Controls.Add(Me.Label7)
        Me.grpInformation.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInformation.Location = New System.Drawing.Point(45, 114)
        Me.grpInformation.Name = "grpInformation"
        Me.grpInformation.Size = New System.Drawing.Size(499, 67)
        Me.grpInformation.TabIndex = 32
        Me.grpInformation.TabStop = False
        Me.grpInformation.Text = "Student Information"
        Me.grpInformation.Visible = False
        '
        'lblDebt
        '
        Me.lblDebt.AutoSize = True
        Me.lblDebt.Location = New System.Drawing.Point(447, 32)
        Me.lblDebt.Name = "lblDebt"
        Me.lblDebt.Size = New System.Drawing.Size(0, 17)
        Me.lblDebt.TabIndex = 5
        '
        'lblItemsOut
        '
        Me.lblItemsOut.AutoSize = True
        Me.lblItemsOut.Location = New System.Drawing.Point(321, 32)
        Me.lblItemsOut.Name = "lblItemsOut"
        Me.lblItemsOut.Size = New System.Drawing.Size(0, 17)
        Me.lblItemsOut.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(58, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 17)
        Me.lblName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Debt:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Items Out:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name:"
        '
        'btnGetInfoOnStudent
        '
        Me.btnGetInfoOnStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetInfoOnStudent.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetInfoOnStudent.Location = New System.Drawing.Point(615, 41)
        Me.btnGetInfoOnStudent.Name = "btnGetInfoOnStudent"
        Me.btnGetInfoOnStudent.Size = New System.Drawing.Size(249, 67)
        Me.btnGetInfoOnStudent.TabIndex = 1
        Me.btnGetInfoOnStudent.Text = "Get Orders"
        Me.btnGetInfoOnStudent.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(148, 52)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(248, 29)
        Me.txtStudentID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(1, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 2)
        Me.Label1.TabIndex = 46
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(903, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetOrdersToolStripMenuItem, Me.ClearStudentToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'GetOrdersToolStripMenuItem
        '
        Me.GetOrdersToolStripMenuItem.Name = "GetOrdersToolStripMenuItem"
        Me.GetOrdersToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.GetOrdersToolStripMenuItem.Text = "Get Orders"
        '
        'ClearStudentToolStripMenuItem
        '
        Me.ClearStudentToolStripMenuItem.Name = "ClearStudentToolStripMenuItem"
        Me.ClearStudentToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClearStudentToolStripMenuItem.Text = "Clear Student"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatisticsToolStripMenuItem, Me.StudentStatisticsToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.NavigateToolStripMenuItem.Text = "View"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StatisticsToolStripMenuItem.Text = "Statistics"
        '
        'StudentStatisticsToolStripMenuItem
        '
        Me.StudentStatisticsToolStripMenuItem.Name = "StudentStatisticsToolStripMenuItem"
        Me.StudentStatisticsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StudentStatisticsToolStripMenuItem.Text = "Student Management"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyReportToolStripMenuItem, Me.BackupDataToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'BackupDataToolStripMenuItem
        '
        Me.BackupDataToolStripMenuItem.Name = "BackupDataToolStripMenuItem"
        Me.BackupDataToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BackupDataToolStripMenuItem.Text = "Backup Data"
        '
        'frmOrder
        '
        Me.AcceptButton = Me.btnGetInfoOnStudent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 424)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.lblPaymentAmount)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblItemToWithdraw)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.btnClearStudent)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cboItemToWithdraw)
        Me.Controls.Add(Me.cboOrders)
        Me.Controls.Add(Me.btnPayAmount)
        Me.Controls.Add(Me.btnWithdrawItem)
        Me.Controls.Add(Me.grpInformation)
        Me.Controls.Add(Me.btnGetInfoOnStudent)
        Me.Controls.Add(Me.txtStudentID)
        Me.Name = "frmOrder"
        Me.Text = "Candy Sales: Orders"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.grpInformation.ResumeLayout(False)
        Me.grpInformation.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMethods As System.Windows.Forms.GroupBox
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents radCheck As System.Windows.Forms.RadioButton
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents lblPaymentAmount As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents lblItemToWithdraw As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents btnClearStudent As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cboItemToWithdraw As System.Windows.Forms.ComboBox
    Friend WithEvents cboOrders As System.Windows.Forms.ComboBox
    Friend WithEvents btnPayAmount As System.Windows.Forms.Button
    Friend WithEvents btnWithdrawItem As System.Windows.Forms.Button
    Friend WithEvents grpInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblDebt As System.Windows.Forms.Label
    Friend WithEvents lblItemsOut As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnGetInfoOnStudent As System.Windows.Forms.Button
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetOrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentStatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

