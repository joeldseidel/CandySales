<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcomeIntro
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
        Me.lblWelcomeHeader = New System.Windows.Forms.Label()
        Me.lblWelcomeSubHeader = New System.Windows.Forms.Label()
        Me.lblInstructionsHeader = New System.Windows.Forms.Label()
        Me.btnSetupStorageDrivers = New System.Windows.Forms.Button()
        Me.btnImportStudents = New System.Windows.Forms.Button()
        Me.btnSetupAdmin = New System.Windows.Forms.Button()
        Me.btnSetupProduct = New System.Windows.Forms.Button()
        Me.lblFlow12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLaunchLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcomeHeader
        '
        Me.lblWelcomeHeader.AutoSize = True
        Me.lblWelcomeHeader.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeHeader.Location = New System.Drawing.Point(282, 9)
        Me.lblWelcomeHeader.Name = "lblWelcomeHeader"
        Me.lblWelcomeHeader.Size = New System.Drawing.Size(228, 65)
        Me.lblWelcomeHeader.TabIndex = 0
        Me.lblWelcomeHeader.Text = "Welcome!"
        '
        'lblWelcomeSubHeader
        '
        Me.lblWelcomeSubHeader.AutoSize = True
        Me.lblWelcomeSubHeader.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeSubHeader.Location = New System.Drawing.Point(74, 74)
        Me.lblWelcomeSubHeader.Name = "lblWelcomeSubHeader"
        Me.lblWelcomeSubHeader.Size = New System.Drawing.Size(640, 60)
        Me.lblWelcomeSubHeader.TabIndex = 1
        Me.lblWelcomeSubHeader.Text = "It appears this is your first time using Candy Sales Fundraising software. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Than" &
    "ks for joining us!"
        Me.lblWelcomeSubHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInstructionsHeader
        '
        Me.lblInstructionsHeader.AutoSize = True
        Me.lblInstructionsHeader.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsHeader.Location = New System.Drawing.Point(129, 172)
        Me.lblInstructionsHeader.Name = "lblInstructionsHeader"
        Me.lblInstructionsHeader.Size = New System.Drawing.Size(530, 30)
        Me.lblInstructionsHeader.TabIndex = 2
        Me.lblInstructionsHeader.Text = "Let's get started setting up the application for its first usage"
        Me.lblInstructionsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSetupStorageDrivers
        '
        Me.btnSetupStorageDrivers.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetupStorageDrivers.Location = New System.Drawing.Point(12, 246)
        Me.btnSetupStorageDrivers.Name = "btnSetupStorageDrivers"
        Me.btnSetupStorageDrivers.Size = New System.Drawing.Size(161, 52)
        Me.btnSetupStorageDrivers.TabIndex = 4
        Me.btnSetupStorageDrivers.Text = "Step 1: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Setup Storage"
        Me.btnSetupStorageDrivers.UseVisualStyleBackColor = True
        '
        'btnImportStudents
        '
        Me.btnImportStudents.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportStudents.Location = New System.Drawing.Point(215, 246)
        Me.btnImportStudents.Name = "btnImportStudents"
        Me.btnImportStudents.Size = New System.Drawing.Size(155, 52)
        Me.btnImportStudents.TabIndex = 6
        Me.btnImportStudents.Text = "Step 2: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Import Students"
        Me.btnImportStudents.UseVisualStyleBackColor = True
        '
        'btnSetupAdmin
        '
        Me.btnSetupAdmin.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetupAdmin.Location = New System.Drawing.Point(418, 246)
        Me.btnSetupAdmin.Name = "btnSetupAdmin"
        Me.btnSetupAdmin.Size = New System.Drawing.Size(155, 52)
        Me.btnSetupAdmin.TabIndex = 8
        Me.btnSetupAdmin.Text = "Step 3: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Set Up Account"
        Me.btnSetupAdmin.UseVisualStyleBackColor = True
        '
        'btnSetupProduct
        '
        Me.btnSetupProduct.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetupProduct.Location = New System.Drawing.Point(621, 246)
        Me.btnSetupProduct.Name = "btnSetupProduct"
        Me.btnSetupProduct.Size = New System.Drawing.Size(155, 52)
        Me.btnSetupProduct.TabIndex = 10
        Me.btnSetupProduct.Text = "Step 4: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Set Up Products"
        Me.btnSetupProduct.UseVisualStyleBackColor = True
        '
        'lblFlow12
        '
        Me.lblFlow12.AutoSize = True
        Me.lblFlow12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlow12.Location = New System.Drawing.Point(179, 262)
        Me.lblFlow12.Name = "lblFlow12"
        Me.lblFlow12.Size = New System.Drawing.Size(30, 21)
        Me.lblFlow12.TabIndex = 11
        Me.lblFlow12.Text = ">>"
        Me.lblFlow12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = ">>"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(585, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = ">>"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLaunchLogin
        '
        Me.btnLaunchLogin.Enabled = False
        Me.btnLaunchLogin.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunchLogin.Location = New System.Drawing.Point(317, 332)
        Me.btnLaunchLogin.Name = "btnLaunchLogin"
        Me.btnLaunchLogin.Size = New System.Drawing.Size(155, 52)
        Me.btnLaunchLogin.TabIndex = 15
        Me.btnLaunchLogin.Text = "Launch Application"
        Me.btnLaunchLogin.UseVisualStyleBackColor = True
        '
        'frmWelcomeIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 404)
        Me.Controls.Add(Me.btnLaunchLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFlow12)
        Me.Controls.Add(Me.btnSetupProduct)
        Me.Controls.Add(Me.btnSetupAdmin)
        Me.Controls.Add(Me.btnImportStudents)
        Me.Controls.Add(Me.btnSetupStorageDrivers)
        Me.Controls.Add(Me.lblInstructionsHeader)
        Me.Controls.Add(Me.lblWelcomeSubHeader)
        Me.Controls.Add(Me.lblWelcomeHeader)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(805, 443)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(805, 443)
        Me.Name = "frmWelcomeIntro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome: Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeHeader As Label
    Friend WithEvents lblWelcomeSubHeader As Label
    Friend WithEvents lblInstructionsHeader As Label
    Friend WithEvents btnSetupStorageDrivers As Button
    Friend WithEvents btnImportStudents As Button
    Friend WithEvents btnSetupAdmin As Button
    Friend WithEvents btnSetupProduct As Button
    Friend WithEvents lblFlow12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLaunchLogin As Button
End Class
