<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportStudents))
        Me.lblImportHeader = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnSelectImportFile = New System.Windows.Forms.Button()
        Me.lblStep1Label = New System.Windows.Forms.Label()
        Me.lblStep2Label = New System.Windows.Forms.Label()
        Me.btnBeginImport = New System.Windows.Forms.Button()
        Me.lblStep3Label = New System.Windows.Forms.Label()
        Me.btnCompleteImport = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ofdImportFile = New System.Windows.Forms.OpenFileDialog()
        Me.prgImportProgress = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblImportHeader
        '
        Me.lblImportHeader.AutoSize = True
        Me.lblImportHeader.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImportHeader.Location = New System.Drawing.Point(30, 9)
        Me.lblImportHeader.Name = "lblImportHeader"
        Me.lblImportHeader.Size = New System.Drawing.Size(282, 37)
        Me.lblImportHeader.TabIndex = 0
        Me.lblImportHeader.Text = "Import Student Records"
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.Location = New System.Drawing.Point(12, 52)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(600, 2)
        Me.lblDivider.TabIndex = 30
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructions.AutoEllipsis = True
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(33, 70)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(733, 84)
        Me.lblInstructions.TabIndex = 31
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelectImportFile
        '
        Me.btnSelectImportFile.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectImportFile.Location = New System.Drawing.Point(62, 254)
        Me.btnSelectImportFile.Name = "btnSelectImportFile"
        Me.btnSelectImportFile.Size = New System.Drawing.Size(131, 52)
        Me.btnSelectImportFile.TabIndex = 32
        Me.btnSelectImportFile.Text = "Start"
        Me.btnSelectImportFile.UseVisualStyleBackColor = True
        '
        'lblStep1Label
        '
        Me.lblStep1Label.AutoSize = True
        Me.lblStep1Label.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1Label.Location = New System.Drawing.Point(32, 222)
        Me.lblStep1Label.Name = "lblStep1Label"
        Me.lblStep1Label.Size = New System.Drawing.Size(193, 25)
        Me.lblStep1Label.TabIndex = 33
        Me.lblStep1Label.Text = "Step 1: Select .CSV File"
        '
        'lblStep2Label
        '
        Me.lblStep2Label.AutoSize = True
        Me.lblStep2Label.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2Label.Location = New System.Drawing.Point(307, 222)
        Me.lblStep2Label.Name = "lblStep2Label"
        Me.lblStep2Label.Size = New System.Drawing.Size(179, 25)
        Me.lblStep2Label.TabIndex = 35
        Me.lblStep2Label.Text = "Step 2: Begin Import"
        '
        'btnBeginImport
        '
        Me.btnBeginImport.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeginImport.Location = New System.Drawing.Point(331, 254)
        Me.btnBeginImport.Name = "btnBeginImport"
        Me.btnBeginImport.Size = New System.Drawing.Size(131, 52)
        Me.btnBeginImport.TabIndex = 34
        Me.btnBeginImport.Text = "Start"
        Me.btnBeginImport.UseVisualStyleBackColor = True
        '
        'lblStep3Label
        '
        Me.lblStep3Label.AutoSize = True
        Me.lblStep3Label.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep3Label.Location = New System.Drawing.Point(567, 222)
        Me.lblStep3Label.Name = "lblStep3Label"
        Me.lblStep3Label.Size = New System.Drawing.Size(213, 25)
        Me.lblStep3Label.TabIndex = 37
        Me.lblStep3Label.Text = "Step 3: Complete Import"
        '
        'btnCompleteImport
        '
        Me.btnCompleteImport.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteImport.Location = New System.Drawing.Point(604, 254)
        Me.btnCompleteImport.Name = "btnCompleteImport"
        Me.btnCompleteImport.Size = New System.Drawing.Size(131, 52)
        Me.btnCompleteImport.TabIndex = 36
        Me.btnCompleteImport.Text = "Start"
        Me.btnCompleteImport.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = ">>>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(517, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = ">>>"
        '
        'ofdImportFile
        '
        Me.ofdImportFile.Filter = "CSV (Comma Delimited)|*.csv"
        Me.ofdImportFile.InitialDirectory = "C:\"
        '
        'prgImportProgress
        '
        Me.prgImportProgress.Location = New System.Drawing.Point(62, 312)
        Me.prgImportProgress.Name = "prgImportProgress"
        Me.prgImportProgress.Size = New System.Drawing.Size(673, 23)
        Me.prgImportProgress.TabIndex = 40
        Me.prgImportProgress.Visible = False
        '
        'frmImportStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 343)
        Me.Controls.Add(Me.prgImportProgress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStep3Label)
        Me.Controls.Add(Me.btnCompleteImport)
        Me.Controls.Add(Me.lblStep2Label)
        Me.Controls.Add(Me.btnBeginImport)
        Me.Controls.Add(Me.lblStep1Label)
        Me.Controls.Add(Me.btnSelectImportFile)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblImportHeader)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmImportStudents"
        Me.Text = "Import Students"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImportHeader As Label
    Friend WithEvents lblDivider As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnSelectImportFile As Button
    Friend WithEvents lblStep1Label As Label
    Friend WithEvents lblStep2Label As Label
    Friend WithEvents btnBeginImport As Button
    Friend WithEvents lblStep3Label As Label
    Friend WithEvents btnCompleteImport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ofdImportFile As OpenFileDialog
    Friend WithEvents prgImportProgress As ProgressBar
End Class
