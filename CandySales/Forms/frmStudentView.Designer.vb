<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentView
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
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentShop = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lstvStudentTransactions = New System.Windows.Forms.ListView()
        Me.clmRowID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTransactionDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmItemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTransactionValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmHandlingAdmin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblRecentTransaction = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.Location = New System.Drawing.Point(15, 17)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(351, 40)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "FIRST NAME || LAST NAME"
        '
        'lblStudentShop
        '
        Me.lblStudentShop.AutoSize = True
        Me.lblStudentShop.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentShop.Location = New System.Drawing.Point(18, 67)
        Me.lblStudentShop.Name = "lblStudentShop"
        Me.lblStudentShop.Size = New System.Drawing.Size(399, 21)
        Me.lblStudentShop.TabIndex = 1
        Me.lblStudentShop.Text = "Shop: SAMPLE SHOP AND MORE WORDS TECHNOLOGY"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(18, 92)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(77, 21)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade: XX"
        '
        'lstvStudentTransactions
        '
        Me.lstvStudentTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmRowID, Me.clmTransactionDate, Me.clmItemID, Me.clmTransactionValue, Me.clmHandlingAdmin})
        Me.lstvStudentTransactions.FullRowSelect = True
        Me.lstvStudentTransactions.Location = New System.Drawing.Point(22, 146)
        Me.lstvStudentTransactions.Name = "lstvStudentTransactions"
        Me.lstvStudentTransactions.Size = New System.Drawing.Size(599, 330)
        Me.lstvStudentTransactions.TabIndex = 3
        Me.lstvStudentTransactions.UseCompatibleStateImageBehavior = False
        Me.lstvStudentTransactions.View = System.Windows.Forms.View.Details
        '
        'clmRowID
        '
        Me.clmRowID.Text = "ID"
        Me.clmRowID.Width = 69
        '
        'clmTransactionDate
        '
        Me.clmTransactionDate.Text = "Date"
        Me.clmTransactionDate.Width = 96
        '
        'clmItemID
        '
        Me.clmItemID.Text = "Item Purchased ID"
        Me.clmItemID.Width = 156
        '
        'clmTransactionValue
        '
        Me.clmTransactionValue.Text = "Transaction Value"
        Me.clmTransactionValue.Width = 115
        '
        'clmHandlingAdmin
        '
        Me.clmHandlingAdmin.Text = "Admin"
        Me.clmHandlingAdmin.Width = 92
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(12, 59)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(450, 3)
        Me.lblDivider.TabIndex = 28
        '
        'lblRecentTransaction
        '
        Me.lblRecentTransaction.AutoSize = True
        Me.lblRecentTransaction.Location = New System.Drawing.Point(19, 126)
        Me.lblRecentTransaction.Name = "lblRecentTransaction"
        Me.lblRecentTransaction.Size = New System.Drawing.Size(121, 17)
        Me.lblRecentTransaction.TabIndex = 29
        Me.lblRecentTransaction.Text = "Recent Transactions:"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.Location = New System.Drawing.Point(161, 92)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(88, 21)
        Me.lblSession.TabIndex = 30
        Me.lblSession.Text = "Session: XX"
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Location = New System.Drawing.Point(6, 20)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(114, 27)
        Me.btnEditStudent.TabIndex = 31
        Me.btnEditStudent.Text = "Edit Student"
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.Location = New System.Drawing.Point(6, 53)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(114, 27)
        Me.btnDeleteStudent.TabIndex = 32
        Me.btnDeleteStudent.Text = "Delete Student"
        Me.btnDeleteStudent.UseVisualStyleBackColor = True
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.btnDeleteStudent)
        Me.grpActions.Controls.Add(Me.btnEditStudent)
        Me.grpActions.Location = New System.Drawing.Point(507, 12)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(128, 86)
        Me.grpActions.TabIndex = 33
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(317, 92)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(71, 21)
        Me.lblSales.TabIndex = 34
        Me.lblSales.Text = "Sales: XX"
        '
        'frmStudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 489)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblRecentTransaction)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lstvStudentTransactions)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblStudentShop)
        Me.Controls.Add(Me.lblStudentName)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudentView"
        Me.Text = "Student View"
        Me.grpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblStudentShop As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lstvStudentTransactions As System.Windows.Forms.ListView
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents lblRecentTransaction As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents clmTransactionDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmItemID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmTransactionValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmHandlingAdmin As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents grpActions As GroupBox
    Friend WithEvents lblSales As Label
    Friend WithEvents clmRowID As ColumnHeader
End Class
