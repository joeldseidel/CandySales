<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopView
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
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblStudentCount = New System.Windows.Forms.Label()
        Me.lblSellingCount = New System.Windows.Forms.Label()
        Me.lstvStudents = New System.Windows.Forms.ListView()
        Me.clmName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmGrade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmSession = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmOutstandingOrders = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmRemainingDebt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblStudentsInShop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblShopName
        '
        Me.lblShopName.AutoSize = True
        Me.lblShopName.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShopName.Location = New System.Drawing.Point(19, 10)
        Me.lblShopName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(196, 45)
        Me.lblShopName.TabIndex = 0
        Me.lblShopName.Text = "SHOP NAME"
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(18, 55)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(600, 3)
        Me.lblDivider.TabIndex = 29
        '
        'lblStudentCount
        '
        Me.lblStudentCount.AutoSize = True
        Me.lblStudentCount.Location = New System.Drawing.Point(23, 69)
        Me.lblStudentCount.Name = "lblStudentCount"
        Me.lblStudentCount.Size = New System.Drawing.Size(73, 21)
        Me.lblStudentCount.TabIndex = 30
        Me.lblStudentCount.Text = "Students:"
        '
        'lblSellingCount
        '
        Me.lblSellingCount.AutoSize = True
        Me.lblSellingCount.Location = New System.Drawing.Point(236, 69)
        Me.lblSellingCount.Name = "lblSellingCount"
        Me.lblSellingCount.Size = New System.Drawing.Size(123, 21)
        Me.lblSellingCount.TabIndex = 31
        Me.lblSellingCount.Text = "Students Selling:"
        '
        'lstvStudents
        '
        Me.lstvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmName, Me.clmGrade, Me.clmSession, Me.clmOutstandingOrders, Me.clmRemainingDebt})
        Me.lstvStudents.FullRowSelect = True
        Me.lstvStudents.Location = New System.Drawing.Point(27, 154)
        Me.lstvStudents.Name = "lstvStudents"
        Me.lstvStudents.Size = New System.Drawing.Size(741, 370)
        Me.lstvStudents.TabIndex = 32
        Me.lstvStudents.UseCompatibleStateImageBehavior = False
        Me.lstvStudents.View = System.Windows.Forms.View.Details
        '
        'clmName
        '
        Me.clmName.Text = "Student Name"
        Me.clmName.Width = 200
        '
        'clmGrade
        '
        Me.clmGrade.Text = "Grade"
        '
        'clmSession
        '
        Me.clmSession.Text = "Session"
        Me.clmSession.Width = 70
        '
        'clmOutstandingOrders
        '
        Me.clmOutstandingOrders.Text = "Outstanding Orders"
        Me.clmOutstandingOrders.Width = 153
        '
        'clmRemainingDebt
        '
        Me.clmRemainingDebt.Text = "Remaining Debt"
        Me.clmRemainingDebt.Width = 124
        '
        'lblStudentsInShop
        '
        Me.lblStudentsInShop.AutoSize = True
        Me.lblStudentsInShop.Location = New System.Drawing.Point(23, 130)
        Me.lblStudentsInShop.Name = "lblStudentsInShop"
        Me.lblStudentsInShop.Size = New System.Drawing.Size(196, 21)
        Me.lblStudentsInShop.TabIndex = 33
        Me.lblStudentsInShop.Text = "Shop Students Information:"
        '
        'frmShopView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 547)
        Me.Controls.Add(Me.lblStudentsInShop)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.lstvStudents)
        Me.Controls.Add(Me.lblSellingCount)
        Me.Controls.Add(Me.lblStudentCount)
        Me.Controls.Add(Me.lblDivider)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmShopView"
        Me.Text = "Shop View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblShopName As System.Windows.Forms.Label
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents lblStudentCount As System.Windows.Forms.Label
    Friend WithEvents lblSellingCount As System.Windows.Forms.Label
    Friend WithEvents lstvStudents As System.Windows.Forms.ListView
    Friend WithEvents lblStudentsInShop As System.Windows.Forms.Label
    Friend WithEvents clmName As ColumnHeader
    Friend WithEvents clmGrade As ColumnHeader
    Friend WithEvents clmSession As ColumnHeader
    Friend WithEvents clmOutstandingOrders As ColumnHeader
    Friend WithEvents clmRemainingDebt As ColumnHeader
End Class
