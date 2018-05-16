<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateReports
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
        Me.grpDateRange = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lstDateRangeMatching = New System.Windows.Forms.ListBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartingDate = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSelectionOptions = New System.Windows.Forms.GroupBox()
        Me.radSingleDate = New System.Windows.Forms.RadioButton()
        Me.radDateRange = New System.Windows.Forms.RadioButton()
        Me.btnGenerateReceipt = New System.Windows.Forms.Button()
        Me.grpDateRange.SuspendLayout()
        Me.grpSelectionOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDateRange
        '
        Me.grpDateRange.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.grpDateRange.Controls.Add(Me.btnGenerateReceipt)
        Me.grpDateRange.Controls.Add(Me.dtpEndDate)
        Me.grpDateRange.Controls.Add(Me.lblEndDate)
        Me.grpDateRange.Controls.Add(Me.lstDateRangeMatching)
        Me.grpDateRange.Controls.Add(Me.dtpStartDate)
        Me.grpDateRange.Controls.Add(Me.lblStartingDate)
        Me.grpDateRange.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDateRange.Location = New System.Drawing.Point(13, 12)
        Me.grpDateRange.Name = "grpDateRange"
        Me.grpDateRange.Size = New System.Drawing.Size(650, 226)
        Me.grpDateRange.TabIndex = 3
        Me.grpDateRange.TabStop = False
        Me.grpDateRange.Text = "Date Range"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Location = New System.Drawing.Point(6, 141)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(239, 25)
        Me.dtpEndDate.TabIndex = 4
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(7, 108)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(129, 30)
        Me.lblEndDate.TabIndex = 3
        Me.lblEndDate.Text = "Ending Date"
        '
        'lstDateRangeMatching
        '
        Me.lstDateRangeMatching.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDateRangeMatching.FormattingEnabled = True
        Me.lstDateRangeMatching.ItemHeight = 17
        Me.lstDateRangeMatching.Location = New System.Drawing.Point(268, 19)
        Me.lstDateRangeMatching.Name = "lstDateRangeMatching"
        Me.lstDateRangeMatching.Size = New System.Drawing.Size(372, 191)
        Me.lstDateRangeMatching.TabIndex = 2
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Location = New System.Drawing.Point(6, 69)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(239, 25)
        Me.dtpStartDate.TabIndex = 0
        '
        'lblStartingDate
        '
        Me.lblStartingDate.AutoSize = True
        Me.lblStartingDate.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingDate.Location = New System.Drawing.Point(6, 36)
        Me.lblStartingDate.Name = "lblStartingDate"
        Me.lblStartingDate.Size = New System.Drawing.Size(136, 30)
        Me.lblStartingDate.TabIndex = 1
        Me.lblStartingDate.Text = "Starting Date"
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(475, 247)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(188, 43)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(281, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 43)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpSelectionOptions
        '
        Me.grpSelectionOptions.Controls.Add(Me.radSingleDate)
        Me.grpSelectionOptions.Controls.Add(Me.radDateRange)
        Me.grpSelectionOptions.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectionOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpSelectionOptions.Location = New System.Drawing.Point(13, 242)
        Me.grpSelectionOptions.Name = "grpSelectionOptions"
        Me.grpSelectionOptions.Size = New System.Drawing.Size(234, 48)
        Me.grpSelectionOptions.TabIndex = 5
        Me.grpSelectionOptions.TabStop = False
        Me.grpSelectionOptions.Text = "Selection Options"
        '
        'radSingleDate
        '
        Me.radSingleDate.AutoSize = True
        Me.radSingleDate.Location = New System.Drawing.Point(128, 17)
        Me.radSingleDate.Name = "radSingleDate"
        Me.radSingleDate.Size = New System.Drawing.Size(91, 21)
        Me.radSingleDate.TabIndex = 1
        Me.radSingleDate.Text = "Single Date"
        Me.radSingleDate.UseVisualStyleBackColor = True
        '
        'radDateRange
        '
        Me.radDateRange.AutoSize = True
        Me.radDateRange.Checked = True
        Me.radDateRange.Location = New System.Drawing.Point(6, 17)
        Me.radDateRange.Name = "radDateRange"
        Me.radDateRange.Size = New System.Drawing.Size(92, 21)
        Me.radDateRange.TabIndex = 0
        Me.radDateRange.TabStop = True
        Me.radDateRange.Text = "Date Range"
        Me.radDateRange.UseVisualStyleBackColor = True
        '
        'btnGenerateReceipt
        '
        Me.btnGenerateReceipt.Location = New System.Drawing.Point(193, 181)
        Me.btnGenerateReceipt.Name = "btnGenerateReceipt"
        Me.btnGenerateReceipt.Size = New System.Drawing.Size(52, 29)
        Me.btnGenerateReceipt.TabIndex = 5
        Me.btnGenerateReceipt.Text = "Print"
        Me.btnGenerateReceipt.UseVisualStyleBackColor = True
        Me.btnGenerateReceipt.Visible = False
        '
        'frmDateReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(675, 302)
        Me.Controls.Add(Me.grpSelectionOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.grpDateRange)
        Me.Name = "frmDateReports"
        Me.Text = "Date Search"
        Me.grpDateRange.ResumeLayout(False)
        Me.grpDateRange.PerformLayout()
        Me.grpSelectionOptions.ResumeLayout(False)
        Me.grpSelectionOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDateRange As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lstDateRangeMatching As System.Windows.Forms.ListBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartingDate As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSelectionOptions As System.Windows.Forms.GroupBox
    Friend WithEvents radSingleDate As System.Windows.Forms.RadioButton
    Friend WithEvents radDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerateReceipt As Button
End Class
