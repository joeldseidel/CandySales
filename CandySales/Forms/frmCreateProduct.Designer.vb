<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateProduct
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
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblProductHeader = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblUPC = New System.Windows.Forms.Label()
        Me.txtUPC = New System.Windows.Forms.TextBox()
        Me.llbProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProductRetailPrice = New System.Windows.Forms.Label()
        Me.nudRetailPrice = New System.Windows.Forms.NumericUpDown()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.nudInitialInventory = New System.Windows.Forms.NumericUpDown()
        Me.lblInitialInventory = New System.Windows.Forms.Label()
        CType(Me.nudRetailPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInitialInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(14, 52)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(600, 2)
        Me.lblDivider.TabIndex = 32
        '
        'lblProductHeader
        '
        Me.lblProductHeader.AutoSize = True
        Me.lblProductHeader.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductHeader.Location = New System.Drawing.Point(32, 9)
        Me.lblProductHeader.Name = "lblProductHeader"
        Me.lblProductHeader.Size = New System.Drawing.Size(185, 37)
        Me.lblProductHeader.TabIndex = 31
        Me.lblProductHeader.Text = "Create Product"
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(35, 59)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(507, 21)
        Me.lblInstructions.TabIndex = 33
        Me.lblInstructions.Text = "Enter the data to create the fundrasing item to be sold with the application"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUPC
        '
        Me.lblUPC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUPC.AutoEllipsis = True
        Me.lblUPC.AutoSize = True
        Me.lblUPC.Location = New System.Drawing.Point(35, 106)
        Me.lblUPC.Name = "lblUPC"
        Me.lblUPC.Size = New System.Drawing.Size(132, 21)
        Me.lblUPC.TabIndex = 34
        Me.lblUPC.Text = "Scan Product UPC"
        Me.lblUPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUPC
        '
        Me.txtUPC.Location = New System.Drawing.Point(209, 103)
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.Size = New System.Drawing.Size(320, 29)
        Me.txtUPC.TabIndex = 0
        '
        'llbProductName
        '
        Me.llbProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llbProductName.AutoEllipsis = True
        Me.llbProductName.AutoSize = True
        Me.llbProductName.Location = New System.Drawing.Point(35, 151)
        Me.llbProductName.Name = "llbProductName"
        Me.llbProductName.Size = New System.Drawing.Size(111, 21)
        Me.llbProductName.TabIndex = 36
        Me.llbProductName.Text = "Product Name:"
        Me.llbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(209, 148)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(320, 29)
        Me.txtProductName.TabIndex = 1
        '
        'lblProductRetailPrice
        '
        Me.lblProductRetailPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductRetailPrice.AutoEllipsis = True
        Me.lblProductRetailPrice.AutoSize = True
        Me.lblProductRetailPrice.Location = New System.Drawing.Point(35, 200)
        Me.lblProductRetailPrice.Name = "lblProductRetailPrice"
        Me.lblProductRetailPrice.Size = New System.Drawing.Size(143, 21)
        Me.lblProductRetailPrice.TabIndex = 38
        Me.lblProductRetailPrice.Text = "Product Retail Price:"
        Me.lblProductRetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudRetailPrice
        '
        Me.nudRetailPrice.DecimalPlaces = 2
        Me.nudRetailPrice.Location = New System.Drawing.Point(209, 198)
        Me.nudRetailPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudRetailPrice.Name = "nudRetailPrice"
        Me.nudRetailPrice.Size = New System.Drawing.Size(120, 29)
        Me.nudRetailPrice.TabIndex = 2
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(209, 293)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(320, 29)
        Me.txtProductDescription.TabIndex = 4
        '
        'lblProductDescription
        '
        Me.lblProductDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductDescription.AutoEllipsis = True
        Me.lblProductDescription.AutoSize = True
        Me.lblProductDescription.Location = New System.Drawing.Point(35, 296)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(146, 21)
        Me.lblProductDescription.TabIndex = 40
        Me.lblProductDescription.Text = "Product Description:"
        Me.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(455, 349)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(155, 35)
        Me.btnCreate.TabIndex = 42
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'nudInitialInventory
        '
        Me.nudInitialInventory.Location = New System.Drawing.Point(209, 245)
        Me.nudInitialInventory.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudInitialInventory.Name = "nudInitialInventory"
        Me.nudInitialInventory.Size = New System.Drawing.Size(120, 29)
        Me.nudInitialInventory.TabIndex = 3
        '
        'lblInitialInventory
        '
        Me.lblInitialInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInitialInventory.AutoEllipsis = True
        Me.lblInitialInventory.AutoSize = True
        Me.lblInitialInventory.Location = New System.Drawing.Point(35, 247)
        Me.lblInitialInventory.Name = "lblInitialInventory"
        Me.lblInitialInventory.Size = New System.Drawing.Size(117, 21)
        Me.lblInitialInventory.TabIndex = 43
        Me.lblInitialInventory.Text = "Initial Inventory:"
        Me.lblInitialInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreateProduct
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(622, 396)
        Me.Controls.Add(Me.nudInitialInventory)
        Me.Controls.Add(Me.lblInitialInventory)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtProductDescription)
        Me.Controls.Add(Me.lblProductDescription)
        Me.Controls.Add(Me.nudRetailPrice)
        Me.Controls.Add(Me.lblProductRetailPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.llbProductName)
        Me.Controls.Add(Me.txtUPC)
        Me.Controls.Add(Me.lblUPC)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblProductHeader)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCreateProduct"
        Me.Text = "Create Product"
        CType(Me.nudRetailPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInitialInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDivider As Label
    Friend WithEvents lblProductHeader As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblUPC As Label
    Friend WithEvents txtUPC As TextBox
    Friend WithEvents llbProductName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblProductRetailPrice As Label
    Friend WithEvents nudRetailPrice As NumericUpDown
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents lblProductDescription As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents nudInitialInventory As NumericUpDown
    Friend WithEvents lblInitialInventory As Label
End Class
