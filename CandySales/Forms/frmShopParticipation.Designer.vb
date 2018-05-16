<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopParticipation
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.crtShopParticipation = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.crtShopParticipation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtShopParticipation
        '
        Me.crtShopParticipation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea1.Name = "ChartArea1"
        Me.crtShopParticipation.ChartAreas.Add(ChartArea1)
        Me.crtShopParticipation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtShopParticipation.Location = New System.Drawing.Point(0, 0)
        Me.crtShopParticipation.Margin = New System.Windows.Forms.Padding(0)
        Me.crtShopParticipation.Name = "crtShopParticipation"
        Me.crtShopParticipation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.crtShopParticipation.Size = New System.Drawing.Size(833, 535)
        Me.crtShopParticipation.TabIndex = 0
        Me.crtShopParticipation.Text = "Shop Participation"
        '
        'frmShopParticipation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 535)
        Me.Controls.Add(Me.crtShopParticipation)
        Me.Name = "frmShopParticipation"
        Me.Text = "frmShopParticipation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.crtShopParticipation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crtShopParticipation As DataVisualization.Charting.Chart
End Class
