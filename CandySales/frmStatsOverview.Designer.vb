<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatsOverview
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
        Me.tbcStatsOverview = New System.Windows.Forms.TabControl()
        Me.tbpTotals = New System.Windows.Forms.TabPage()
        Me.tbpStudentsOverview = New System.Windows.Forms.TabPage()
        Me.tbpShopOverview = New System.Windows.Forms.TabPage()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblWithdrawCount = New System.Windows.Forms.Label()
        Me.lblFundsRaised = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.lblPercentSelling = New System.Windows.Forms.Label()
        Me.lblPercentLabel = New System.Windows.Forms.Label()
        Me.lblWaitMessage = New System.Windows.Forms.Label()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.tbcStatsOverview.SuspendLayout()
        Me.tbpTotals.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcStatsOverview
        '
        Me.tbcStatsOverview.Controls.Add(Me.tbpTotals)
        Me.tbcStatsOverview.Controls.Add(Me.tbpStudentsOverview)
        Me.tbcStatsOverview.Controls.Add(Me.tbpShopOverview)
        Me.tbcStatsOverview.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcStatsOverview.ItemSize = New System.Drawing.Size(80, 30)
        Me.tbcStatsOverview.Location = New System.Drawing.Point(13, 12)
        Me.tbcStatsOverview.Name = "tbcStatsOverview"
        Me.tbcStatsOverview.SelectedIndex = 0
        Me.tbcStatsOverview.Size = New System.Drawing.Size(758, 503)
        Me.tbcStatsOverview.TabIndex = 0
        '
        'tbpTotals
        '
        Me.tbpTotals.BackColor = System.Drawing.Color.White
        Me.tbpTotals.Controls.Add(Me.prgProgress)
        Me.tbpTotals.Controls.Add(Me.lblWaitMessage)
        Me.tbpTotals.Controls.Add(Me.lblPercentLabel)
        Me.tbpTotals.Controls.Add(Me.lblPercentSelling)
        Me.tbpTotals.Controls.Add(Me.lblProfit)
        Me.tbpTotals.Controls.Add(Me.lblFundsRaised)
        Me.tbpTotals.Controls.Add(Me.lblWithdrawCount)
        Me.tbpTotals.Controls.Add(Me.lblTotalSales)
        Me.tbpTotals.Location = New System.Drawing.Point(4, 34)
        Me.tbpTotals.Name = "tbpTotals"
        Me.tbpTotals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTotals.Size = New System.Drawing.Size(750, 465)
        Me.tbpTotals.TabIndex = 0
        Me.tbpTotals.Text = "Totals"
        '
        'tbpStudentsOverview
        '
        Me.tbpStudentsOverview.Location = New System.Drawing.Point(4, 34)
        Me.tbpStudentsOverview.Name = "tbpStudentsOverview"
        Me.tbpStudentsOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpStudentsOverview.Size = New System.Drawing.Size(750, 465)
        Me.tbpStudentsOverview.TabIndex = 1
        Me.tbpStudentsOverview.Text = "Students"
        Me.tbpStudentsOverview.UseVisualStyleBackColor = True
        '
        'tbpShopOverview
        '
        Me.tbpShopOverview.Location = New System.Drawing.Point(4, 34)
        Me.tbpShopOverview.Name = "tbpShopOverview"
        Me.tbpShopOverview.Size = New System.Drawing.Size(750, 465)
        Me.tbpShopOverview.TabIndex = 2
        Me.tbpShopOverview.Text = "Shops"
        Me.tbpShopOverview.UseVisualStyleBackColor = True
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI Semilight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(23, 24)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(229, 40)
        Me.lblTotalSales.TabIndex = 0
        Me.lblTotalSales.Text = "Total Sales: XXXX"
        Me.lblTotalSales.Visible = False
        '
        'lblWithdrawCount
        '
        Me.lblWithdrawCount.AutoSize = True
        Me.lblWithdrawCount.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithdrawCount.Location = New System.Drawing.Point(25, 99)
        Me.lblWithdrawCount.Name = "lblWithdrawCount"
        Me.lblWithdrawCount.Size = New System.Drawing.Size(170, 30)
        Me.lblWithdrawCount.TabIndex = 1
        Me.lblWithdrawCount.Text = "Total Withdrawls:"
        Me.lblWithdrawCount.Visible = False
        '
        'lblFundsRaised
        '
        Me.lblFundsRaised.AutoSize = True
        Me.lblFundsRaised.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFundsRaised.Location = New System.Drawing.Point(25, 141)
        Me.lblFundsRaised.Name = "lblFundsRaised"
        Me.lblFundsRaised.Size = New System.Drawing.Size(258, 30)
        Me.lblFundsRaised.TabIndex = 2
        Me.lblFundsRaised.Text = "Total Funds Raised (Gross):"
        Me.lblFundsRaised.Visible = False
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.Location = New System.Drawing.Point(25, 183)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(256, 30)
        Me.lblProfit.TabIndex = 3
        Me.lblProfit.Text = "Total Funds Raised (Profit):"
        Me.lblProfit.Visible = False
        '
        'lblPercentSelling
        '
        Me.lblPercentSelling.AutoSize = True
        Me.lblPercentSelling.Font = New System.Drawing.Font("Segoe UI Semilight", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentSelling.Location = New System.Drawing.Point(482, 16)
        Me.lblPercentSelling.Name = "lblPercentSelling"
        Me.lblPercentSelling.Size = New System.Drawing.Size(96, 51)
        Me.lblPercentSelling.TabIndex = 4
        Me.lblPercentSelling.Text = "XX%"
        Me.lblPercentSelling.Visible = False
        '
        'lblPercentLabel
        '
        Me.lblPercentLabel.AutoSize = True
        Me.lblPercentLabel.Location = New System.Drawing.Point(577, 39)
        Me.lblPercentLabel.Name = "lblPercentLabel"
        Me.lblPercentLabel.Size = New System.Drawing.Size(167, 21)
        Me.lblPercentLabel.TabIndex = 5
        Me.lblPercentLabel.Text = "Of Students Are Selling"
        Me.lblPercentLabel.Visible = False
        '
        'lblWaitMessage
        '
        Me.lblWaitMessage.AutoSize = True
        Me.lblWaitMessage.Location = New System.Drawing.Point(124, 224)
        Me.lblWaitMessage.Name = "lblWaitMessage"
        Me.lblWaitMessage.Size = New System.Drawing.Size(148, 21)
        Me.lblWaitMessage.TabIndex = 6
        Me.lblWaitMessage.Text = "Getting The Facts....."
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(281, 213)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(345, 38)
        Me.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgProgress.TabIndex = 7
        '
        'frmStatsOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 527)
        Me.Controls.Add(Me.tbcStatsOverview)
        Me.Name = "frmStatsOverview"
        Me.Text = "frmStatsOverview"
        Me.tbcStatsOverview.ResumeLayout(False)
        Me.tbpTotals.ResumeLayout(False)
        Me.tbpTotals.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcStatsOverview As TabControl
    Friend WithEvents tbpTotals As TabPage
    Friend WithEvents lblFundsRaised As Label
    Friend WithEvents lblWithdrawCount As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents tbpStudentsOverview As TabPage
    Friend WithEvents tbpShopOverview As TabPage
    Friend WithEvents lblProfit As Label
    Friend WithEvents prgProgress As ProgressBar
    Friend WithEvents lblWaitMessage As Label
    Friend WithEvents lblPercentLabel As Label
    Friend WithEvents lblPercentSelling As Label
End Class
