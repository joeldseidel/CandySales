<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewForm
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
        Me.crvReportView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvReportView
        '
        Me.crvReportView.ActiveViewIndex = -1
        Me.crvReportView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportView.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportView.Location = New System.Drawing.Point(0, 0)
        Me.crvReportView.Name = "crvReportView"
        Me.crvReportView.ShowGroupTreeButton = False
        Me.crvReportView.ShowLogo = False
        Me.crvReportView.ShowParameterPanelButton = False
        Me.crvReportView.ShowTextSearchButton = False
        Me.crvReportView.Size = New System.Drawing.Size(1210, 674)
        Me.crvReportView.TabIndex = 0
        Me.crvReportView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 674)
        Me.Controls.Add(Me.crvReportView)
        Me.Name = "ReportViewForm"
        Me.Text = "Report View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvReportView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
