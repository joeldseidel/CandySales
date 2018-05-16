<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportView
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
        Me.reportBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'reportBrowser
        '
        Me.reportBrowser.AllowNavigation = False
        Me.reportBrowser.AllowWebBrowserDrop = False
        Me.reportBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportBrowser.Location = New System.Drawing.Point(0, 0)
        Me.reportBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.reportBrowser.Name = "reportBrowser"
        Me.reportBrowser.Size = New System.Drawing.Size(891, 526)
        Me.reportBrowser.TabIndex = 0
        '
        'frmReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 526)
        Me.Controls.Add(Me.reportBrowser)
        Me.Name = "frmReportView"
        Me.Text = "View Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportBrowser As WebBrowser
End Class
