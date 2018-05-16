<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlySales
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
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.crtMonthSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.crtMonthSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtMonthSales
        '
        ChartArea1.Name = "ChartArea1"
        Me.crtMonthSales.ChartAreas.Add(ChartArea1)
        Me.crtMonthSales.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.crtMonthSales.Legends.Add(Legend1)
        Me.crtMonthSales.Location = New System.Drawing.Point(0, 0)
        Me.crtMonthSales.Name = "crtMonthSales"
        Me.crtMonthSales.Size = New System.Drawing.Size(284, 261)
        Me.crtMonthSales.TabIndex = 0
        Me.crtMonthSales.Text = "Chart1"
        '
        'frmMonthlySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.crtMonthSales)
        Me.Name = "frmMonthlySales"
        Me.Text = "frmMonthlySales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.crtMonthSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crtMonthSales As DataVisualization.Charting.Chart
End Class
