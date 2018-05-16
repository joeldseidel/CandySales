<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats
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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.lstStudentsMatchingCriteria = New System.Windows.Forms.ListView()
        Me.clmStudent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmGrade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmItemsOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmlDebt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmShop = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.prgPopulateList = New System.Windows.Forms.ProgressBar()
        Me.btnCreateReportFromSearch = New System.Windows.Forms.Button()
        Me.grpCriteria = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkByName = New System.Windows.Forms.CheckBox()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.lblSortResults = New System.Windows.Forms.Label()
        Me.grpWithdrawCriteria = New System.Windows.Forms.GroupBox()
        Me.radStillOwes = New System.Windows.Forms.RadioButton()
        Me.radWithdrawPaidOff = New System.Windows.Forms.RadioButton()
        Me.chkPMSession = New System.Windows.Forms.CheckBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.chkID = New System.Windows.Forms.CheckBox()
        Me.chkAMSession = New System.Windows.Forms.CheckBox()
        Me.cboDistrict = New System.Windows.Forms.ComboBox()
        Me.chkFromDistrict = New System.Windows.Forms.CheckBox()
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.radHasWithdrawn = New System.Windows.Forms.RadioButton()
        Me.radNeverWithdrewAnItem = New System.Windows.Forms.RadioButton()
        Me.cboShops = New System.Windows.Forms.ComboBox()
        Me.chkFromShop = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopSellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecificDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShopParticipationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellingStudentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpCriteria.SuspendLayout()
        Me.grpWithdrawCriteria.SuspendLayout()
        Me.grpItems.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(156, 423)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(148, 54)
        Me.btnApply.TabIndex = 39
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 423)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 54)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.Location = New System.Drawing.Point(898, 403)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(83, 17)
        Me.lblRecordCount.TabIndex = 44
        Me.lblRecordCount.Text = "XXXX Records"
        Me.lblRecordCount.Visible = False
        '
        'lstStudentsMatchingCriteria
        '
        Me.lstStudentsMatchingCriteria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstStudentsMatchingCriteria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmStudent, Me.clmGrade, Me.clmItemsOut, Me.cmlDebt, Me.clmShop})
        Me.lstStudentsMatchingCriteria.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentsMatchingCriteria.FullRowSelect = True
        Me.lstStudentsMatchingCriteria.LabelWrap = False
        Me.lstStudentsMatchingCriteria.Location = New System.Drawing.Point(310, 49)
        Me.lstStudentsMatchingCriteria.MultiSelect = False
        Me.lstStudentsMatchingCriteria.Name = "lstStudentsMatchingCriteria"
        Me.lstStudentsMatchingCriteria.Size = New System.Drawing.Size(671, 351)
        Me.lstStudentsMatchingCriteria.TabIndex = 43
        Me.lstStudentsMatchingCriteria.UseCompatibleStateImageBehavior = False
        Me.lstStudentsMatchingCriteria.View = System.Windows.Forms.View.Details
        '
        'clmStudent
        '
        Me.clmStudent.Text = "Student Name"
        Me.clmStudent.Width = 193
        '
        'clmGrade
        '
        Me.clmGrade.Text = "Grade"
        Me.clmGrade.Width = 51
        '
        'clmItemsOut
        '
        Me.clmItemsOut.Text = "Items Out"
        Me.clmItemsOut.Width = 67
        '
        'cmlDebt
        '
        Me.cmlDebt.Text = "Debt"
        Me.cmlDebt.Width = 68
        '
        'clmShop
        '
        Me.clmShop.Text = "Shop"
        Me.clmShop.Width = 300
        '
        'prgPopulateList
        '
        Me.prgPopulateList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgPopulateList.Location = New System.Drawing.Point(310, 432)
        Me.prgPopulateList.Name = "prgPopulateList"
        Me.prgPopulateList.Size = New System.Drawing.Size(506, 37)
        Me.prgPopulateList.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPopulateList.TabIndex = 42
        Me.prgPopulateList.Visible = False
        '
        'btnCreateReportFromSearch
        '
        Me.btnCreateReportFromSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateReportFromSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateReportFromSearch.Location = New System.Drawing.Point(822, 432)
        Me.btnCreateReportFromSearch.Name = "btnCreateReportFromSearch"
        Me.btnCreateReportFromSearch.Size = New System.Drawing.Size(159, 37)
        Me.btnCreateReportFromSearch.TabIndex = 41
        Me.btnCreateReportFromSearch.Text = "Quick Report"
        Me.btnCreateReportFromSearch.UseVisualStyleBackColor = True
        '
        'grpCriteria
        '
        Me.grpCriteria.Controls.Add(Me.txtName)
        Me.grpCriteria.Controls.Add(Me.chkByName)
        Me.grpCriteria.Controls.Add(Me.cboSort)
        Me.grpCriteria.Controls.Add(Me.lblSortResults)
        Me.grpCriteria.Controls.Add(Me.grpWithdrawCriteria)
        Me.grpCriteria.Controls.Add(Me.chkPMSession)
        Me.grpCriteria.Controls.Add(Me.txtIDNumber)
        Me.grpCriteria.Controls.Add(Me.chkID)
        Me.grpCriteria.Controls.Add(Me.chkAMSession)
        Me.grpCriteria.Controls.Add(Me.cboDistrict)
        Me.grpCriteria.Controls.Add(Me.chkFromDistrict)
        Me.grpCriteria.Controls.Add(Me.grpItems)
        Me.grpCriteria.Controls.Add(Me.cboShops)
        Me.grpCriteria.Controls.Add(Me.chkFromShop)
        Me.grpCriteria.Location = New System.Drawing.Point(12, 46)
        Me.grpCriteria.Name = "grpCriteria"
        Me.grpCriteria.Size = New System.Drawing.Size(292, 354)
        Me.grpCriteria.TabIndex = 38
        Me.grpCriteria.TabStop = False
        Me.grpCriteria.Text = "Criteria (Optional)"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(91, 126)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 29)
        Me.txtName.TabIndex = 21
        '
        'chkByName
        '
        Me.chkByName.AutoSize = True
        Me.chkByName.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkByName.Location = New System.Drawing.Point(5, 128)
        Me.chkByName.Name = "chkByName"
        Me.chkByName.Size = New System.Drawing.Size(74, 25)
        Me.chkByName.TabIndex = 20
        Me.chkByName.Text = "Name:"
        Me.chkByName.UseVisualStyleBackColor = True
        '
        'cboSort
        '
        Me.cboSort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSort.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"Alphabetical - Ascended", "Alphabetical - Descending", "By Shop", "By Grade"})
        Me.cboSort.Location = New System.Drawing.Point(93, 317)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(186, 28)
        Me.cboSort.TabIndex = 19
        '
        'lblSortResults
        '
        Me.lblSortResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSortResults.AutoSize = True
        Me.lblSortResults.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortResults.Location = New System.Drawing.Point(6, 320)
        Me.lblSortResults.Name = "lblSortResults"
        Me.lblSortResults.Size = New System.Drawing.Size(39, 20)
        Me.lblSortResults.TabIndex = 18
        Me.lblSortResults.Text = "Sort:"
        '
        'grpWithdrawCriteria
        '
        Me.grpWithdrawCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpWithdrawCriteria.Controls.Add(Me.radStillOwes)
        Me.grpWithdrawCriteria.Controls.Add(Me.radWithdrawPaidOff)
        Me.grpWithdrawCriteria.Enabled = False
        Me.grpWithdrawCriteria.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWithdrawCriteria.Location = New System.Drawing.Point(7, 252)
        Me.grpWithdrawCriteria.Name = "grpWithdrawCriteria"
        Me.grpWithdrawCriteria.Size = New System.Drawing.Size(272, 60)
        Me.grpWithdrawCriteria.TabIndex = 2
        Me.grpWithdrawCriteria.TabStop = False
        Me.grpWithdrawCriteria.Text = "Withdraw Specific Criteria"
        '
        'radStillOwes
        '
        Me.radStillOwes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radStillOwes.AutoSize = True
        Me.radStillOwes.Location = New System.Drawing.Point(6, 24)
        Me.radStillOwes.Name = "radStillOwes"
        Me.radStillOwes.Size = New System.Drawing.Size(137, 24)
        Me.radStillOwes.TabIndex = 1
        Me.radStillOwes.Tag = "OwesMoney"
        Me.radStillOwes.Text = "Still Owes Money"
        Me.radStillOwes.UseVisualStyleBackColor = True
        '
        'radWithdrawPaidOff
        '
        Me.radWithdrawPaidOff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radWithdrawPaidOff.AutoSize = True
        Me.radWithdrawPaidOff.Location = New System.Drawing.Point(148, 24)
        Me.radWithdrawPaidOff.Name = "radWithdrawPaidOff"
        Me.radWithdrawPaidOff.Size = New System.Drawing.Size(78, 24)
        Me.radWithdrawPaidOff.TabIndex = 0
        Me.radWithdrawPaidOff.Tag = "PaidOff"
        Me.radWithdrawPaidOff.Text = "Paid Off"
        Me.radWithdrawPaidOff.UseVisualStyleBackColor = True
        '
        'chkPMSession
        '
        Me.chkPMSession.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPMSession.AutoSize = True
        Me.chkPMSession.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPMSession.Location = New System.Drawing.Point(115, 163)
        Me.chkPMSession.Name = "chkPMSession"
        Me.chkPMSession.Size = New System.Drawing.Size(101, 24)
        Me.chkPMSession.TabIndex = 14
        Me.chkPMSession.Tag = "PM"
        Me.chkPMSession.Text = "PM Session"
        Me.chkPMSession.UseVisualStyleBackColor = True
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDNumber.Enabled = False
        Me.txtIDNumber.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(91, 93)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(188, 27)
        Me.txtIDNumber.TabIndex = 5
        '
        'chkID
        '
        Me.chkID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkID.AutoSize = True
        Me.chkID.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkID.Location = New System.Drawing.Point(5, 95)
        Me.chkID.Name = "chkID"
        Me.chkID.Size = New System.Drawing.Size(79, 24)
        Me.chkID.TabIndex = 4
        Me.chkID.Tag = "ID"
        Me.chkID.Text = "With ID:"
        Me.chkID.UseVisualStyleBackColor = True
        '
        'chkAMSession
        '
        Me.chkAMSession.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAMSession.AutoSize = True
        Me.chkAMSession.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAMSession.Location = New System.Drawing.Point(6, 163)
        Me.chkAMSession.Name = "chkAMSession"
        Me.chkAMSession.Size = New System.Drawing.Size(103, 24)
        Me.chkAMSession.TabIndex = 13
        Me.chkAMSession.Tag = "AM"
        Me.chkAMSession.Text = "AM Session"
        Me.chkAMSession.UseVisualStyleBackColor = True
        '
        'cboDistrict
        '
        Me.cboDistrict.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDistrict.DropDownWidth = 400
        Me.cboDistrict.Enabled = False
        Me.cboDistrict.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(91, 26)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(188, 28)
        Me.cboDistrict.TabIndex = 12
        '
        'chkFromDistrict
        '
        Me.chkFromDistrict.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFromDistrict.AutoSize = True
        Me.chkFromDistrict.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFromDistrict.Location = New System.Drawing.Point(6, 28)
        Me.chkFromDistrict.Name = "chkFromDistrict"
        Me.chkFromDistrict.Size = New System.Drawing.Size(75, 24)
        Me.chkFromDistrict.TabIndex = 11
        Me.chkFromDistrict.Tag = "District"
        Me.chkFromDistrict.Text = "District:"
        Me.chkFromDistrict.UseVisualStyleBackColor = True
        '
        'grpItems
        '
        Me.grpItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItems.Controls.Add(Me.radHasWithdrawn)
        Me.grpItems.Controls.Add(Me.radNeverWithdrewAnItem)
        Me.grpItems.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItems.Location = New System.Drawing.Point(7, 193)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(272, 60)
        Me.grpItems.TabIndex = 10
        Me.grpItems.TabStop = False
        Me.grpItems.Text = "Item Specific Criteria"
        '
        'radHasWithdrawn
        '
        Me.radHasWithdrawn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radHasWithdrawn.AutoSize = True
        Me.radHasWithdrawn.Location = New System.Drawing.Point(6, 24)
        Me.radHasWithdrawn.Name = "radHasWithdrawn"
        Me.radHasWithdrawn.Size = New System.Drawing.Size(125, 24)
        Me.radHasWithdrawn.TabIndex = 1
        Me.radHasWithdrawn.TabStop = True
        Me.radHasWithdrawn.Tag = "HasWithdrawn"
        Me.radHasWithdrawn.Text = "Has Withdrawn"
        Me.radHasWithdrawn.UseVisualStyleBackColor = True
        '
        'radNeverWithdrewAnItem
        '
        Me.radNeverWithdrewAnItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radNeverWithdrewAnItem.AutoSize = True
        Me.radNeverWithdrewAnItem.Location = New System.Drawing.Point(138, 24)
        Me.radNeverWithdrewAnItem.Name = "radNeverWithdrewAnItem"
        Me.radNeverWithdrewAnItem.Size = New System.Drawing.Size(132, 24)
        Me.radNeverWithdrewAnItem.TabIndex = 0
        Me.radNeverWithdrewAnItem.TabStop = True
        Me.radNeverWithdrewAnItem.Tag = "NeverWithdrawn"
        Me.radNeverWithdrewAnItem.Text = "Never Withdrew"
        Me.radNeverWithdrewAnItem.UseVisualStyleBackColor = True
        '
        'cboShops
        '
        Me.cboShops.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboShops.DropDownWidth = 400
        Me.cboShops.Enabled = False
        Me.cboShops.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShops.FormattingEnabled = True
        Me.cboShops.Location = New System.Drawing.Point(91, 59)
        Me.cboShops.Name = "cboShops"
        Me.cboShops.Size = New System.Drawing.Size(188, 28)
        Me.cboShops.TabIndex = 9
        '
        'chkFromShop
        '
        Me.chkFromShop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFromShop.AutoSize = True
        Me.chkFromShop.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFromShop.Location = New System.Drawing.Point(6, 61)
        Me.chkFromShop.Name = "chkFromShop"
        Me.chkFromShop.Size = New System.Drawing.Size(65, 24)
        Me.chkFromShop.TabIndex = 8
        Me.chkFromShop.Tag = "Shop"
        Me.chkFromShop.Text = "Shop:"
        Me.chkFromShop.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdersToolStripMenuItem, Me.TopSellersToolStripMenuItem, Me.DateStatisticsToolStripMenuItem, Me.ShopStatisticsToolStripMenuItem, Me.StudentStatisticsToolStripMenuItem, Me.AdministratorManagementToolStripMenuItem, Me.ProductCreationToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.NavigateToolStripMenuItem.Text = "View"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'TopSellersToolStripMenuItem
        '
        Me.TopSellersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AMToolStripMenuItem, Me.PmToolStripMenuItem})
        Me.TopSellersToolStripMenuItem.Name = "TopSellersToolStripMenuItem"
        Me.TopSellersToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TopSellersToolStripMenuItem.Text = "Top Sellers"
        '
        'AMToolStripMenuItem
        '
        Me.AMToolStripMenuItem.Name = "AMToolStripMenuItem"
        Me.AMToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.AMToolStripMenuItem.Text = "AM"
        '
        'PmToolStripMenuItem
        '
        Me.PmToolStripMenuItem.Name = "PmToolStripMenuItem"
        Me.PmToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.PmToolStripMenuItem.Text = "PM"
        '
        'DateStatisticsToolStripMenuItem
        '
        Me.DateStatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpecificDateToolStripMenuItem, Me.ByMonthToolStripMenuItem})
        Me.DateStatisticsToolStripMenuItem.Name = "DateStatisticsToolStripMenuItem"
        Me.DateStatisticsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DateStatisticsToolStripMenuItem.Text = "Date Statistics"
        '
        'SpecificDateToolStripMenuItem
        '
        Me.SpecificDateToolStripMenuItem.Name = "SpecificDateToolStripMenuItem"
        Me.SpecificDateToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SpecificDateToolStripMenuItem.Text = "Specific Date"
        '
        'ByMonthToolStripMenuItem
        '
        Me.ByMonthToolStripMenuItem.Name = "ByMonthToolStripMenuItem"
        Me.ByMonthToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ByMonthToolStripMenuItem.Text = "By Month"
        '
        'ShopStatisticsToolStripMenuItem
        '
        Me.ShopStatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShopParticipationToolStripMenuItem})
        Me.ShopStatisticsToolStripMenuItem.Name = "ShopStatisticsToolStripMenuItem"
        Me.ShopStatisticsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ShopStatisticsToolStripMenuItem.Text = "Shop Statistics"
        '
        'ShopParticipationToolStripMenuItem
        '
        Me.ShopParticipationToolStripMenuItem.Name = "ShopParticipationToolStripMenuItem"
        Me.ShopParticipationToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ShopParticipationToolStripMenuItem.Text = "Shop Participation"
        '
        'StudentStatisticsToolStripMenuItem
        '
        Me.StudentStatisticsToolStripMenuItem.Name = "StudentStatisticsToolStripMenuItem"
        Me.StudentStatisticsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StudentStatisticsToolStripMenuItem.Text = "Student Management"
        '
        'AdministratorManagementToolStripMenuItem
        '
        Me.AdministratorManagementToolStripMenuItem.Name = "AdministratorManagementToolStripMenuItem"
        Me.AdministratorManagementToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AdministratorManagementToolStripMenuItem.Text = "Administrator Management"
        '
        'ProductCreationToolStripMenuItem
        '
        Me.ProductCreationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewToolStripMenuItem})
        Me.ProductCreationToolStripMenuItem.Name = "ProductCreationToolStripMenuItem"
        Me.ProductCreationToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ProductCreationToolStripMenuItem.Text = "Product Management"
        '
        'CreateNewToolStripMenuItem
        '
        Me.CreateNewToolStripMenuItem.Name = "CreateNewToolStripMenuItem"
        Me.CreateNewToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CreateNewToolStripMenuItem.Text = "Create New"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTickets, Me.DailyReportToolStripMenuItem, Me.SellingStudentReportToolStripMenuItem, Me.BackupDataToolStripMenuItem, Me.ResetAllDataToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'tsmiTickets
        '
        Me.tsmiTickets.Name = "tsmiTickets"
        Me.tsmiTickets.Size = New System.Drawing.Size(191, 22)
        Me.tsmiTickets.Text = "Tickets"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'SellingStudentReportToolStripMenuItem
        '
        Me.SellingStudentReportToolStripMenuItem.Name = "SellingStudentReportToolStripMenuItem"
        Me.SellingStudentReportToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SellingStudentReportToolStripMenuItem.Text = "Selling Student Report"
        '
        'BackupDataToolStripMenuItem
        '
        Me.BackupDataToolStripMenuItem.Name = "BackupDataToolStripMenuItem"
        Me.BackupDataToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BackupDataToolStripMenuItem.Text = "Backup"
        '
        'ResetAllDataToolStripMenuItem
        '
        Me.ResetAllDataToolStripMenuItem.Name = "ResetAllDataToolStripMenuItem"
        Me.ResetAllDataToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ResetAllDataToolStripMenuItem.Text = "Reset All Data"
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 484)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Controls.Add(Me.lstStudentsMatchingCriteria)
        Me.Controls.Add(Me.prgPopulateList)
        Me.Controls.Add(Me.btnCreateReportFromSearch)
        Me.Controls.Add(Me.grpCriteria)
        Me.Name = "frmStats"
        Me.Text = "Candy Sales: Statistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpCriteria.ResumeLayout(False)
        Me.grpCriteria.PerformLayout()
        Me.grpWithdrawCriteria.ResumeLayout(False)
        Me.grpWithdrawCriteria.PerformLayout()
        Me.grpItems.ResumeLayout(False)
        Me.grpItems.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents lstStudentsMatchingCriteria As ListView
    Friend WithEvents clmStudent As ColumnHeader
    Friend WithEvents clmGrade As ColumnHeader
    Friend WithEvents clmItemsOut As ColumnHeader
    Friend WithEvents cmlDebt As ColumnHeader
    Friend WithEvents clmShop As ColumnHeader
    Friend WithEvents prgPopulateList As ProgressBar
    Friend WithEvents btnCreateReportFromSearch As Button
    Friend WithEvents grpCriteria As GroupBox
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents lblSortResults As Label
    Friend WithEvents grpWithdrawCriteria As GroupBox
    Friend WithEvents radStillOwes As RadioButton
    Friend WithEvents radWithdrawPaidOff As RadioButton
    Friend WithEvents chkPMSession As CheckBox
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents chkID As CheckBox
    Friend WithEvents chkAMSession As CheckBox
    Friend WithEvents cboDistrict As ComboBox
    Friend WithEvents chkFromDistrict As CheckBox
    Friend WithEvents grpItems As GroupBox
    Friend WithEvents radHasWithdrawn As RadioButton
    Friend WithEvents radNeverWithdrewAnItem As RadioButton
    Friend WithEvents cboShops As ComboBox
    Friend WithEvents chkFromShop As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopSellersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateStatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShopStatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentStatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiTickets As ToolStripMenuItem
    Friend WithEvents DailyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtName As TextBox
    Private WithEvents chkByName As CheckBox
    Friend WithEvents ShopParticipationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecificDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByMonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratorManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductCreationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetAllDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellingStudentReportToolStripMenuItem As ToolStripMenuItem
End Class
