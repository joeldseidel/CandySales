<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.lblSettingsHeader = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.lblDefaultBackupLocation = New System.Windows.Forms.Label()
        Me.txtDefaultBackup = New System.Windows.Forms.TextBox()
        Me.btnBackupBrowse = New System.Windows.Forms.Button()
        Me.btnRestorationBrowse = New System.Windows.Forms.Button()
        Me.txtDefaultRestoration = New System.Windows.Forms.TextBox()
        Me.lblDefaultRestorationLocation = New System.Windows.Forms.Label()
        Me.chkAutoBackup = New System.Windows.Forms.CheckBox()
        Me.btnAutoBackupSettings = New System.Windows.Forms.Button()
        Me.lblBackupSubheader = New System.Windows.Forms.Label()
        Me.lblAppearance = New System.Windows.Forms.Label()
        Me.lblPrimaryColor = New System.Windows.Forms.Label()
        Me.pnlPrimaryColor = New System.Windows.Forms.Panel()
        Me.lblSecondaryColor = New System.Windows.Forms.Label()
        Me.pnlSecondaryColor = New System.Windows.Forms.Panel()
        Me.cdlgColorScheme = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'lblSettingsHeader
        '
        Me.lblSettingsHeader.AutoSize = True
        Me.lblSettingsHeader.Font = New System.Drawing.Font("Segoe UI Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblSettingsHeader.Name = "lblSettingsHeader"
        Me.lblSettingsHeader.Size = New System.Drawing.Size(408, 50)
        Me.lblSettingsHeader.TabIndex = 0
        Me.lblSettingsHeader.Text = "Settings And Preferences"
        '
        'lblDivider
        '
        Me.lblDivider.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDivider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDivider.Location = New System.Drawing.Point(13, 65)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(875, 2)
        Me.lblDivider.TabIndex = 29
        '
        'lblDefaultBackupLocation
        '
        Me.lblDefaultBackupLocation.AutoSize = True
        Me.lblDefaultBackupLocation.Location = New System.Drawing.Point(42, 134)
        Me.lblDefaultBackupLocation.Name = "lblDefaultBackupLocation"
        Me.lblDefaultBackupLocation.Size = New System.Drawing.Size(180, 21)
        Me.lblDefaultBackupLocation.TabIndex = 30
        Me.lblDefaultBackupLocation.Text = "Default Backup Location:"
        '
        'txtDefaultBackup
        '
        Me.txtDefaultBackup.Location = New System.Drawing.Point(262, 131)
        Me.txtDefaultBackup.Name = "txtDefaultBackup"
        Me.txtDefaultBackup.Size = New System.Drawing.Size(468, 29)
        Me.txtDefaultBackup.TabIndex = 31
        '
        'btnBackupBrowse
        '
        Me.btnBackupBrowse.Location = New System.Drawing.Point(750, 130)
        Me.btnBackupBrowse.Name = "btnBackupBrowse"
        Me.btnBackupBrowse.Size = New System.Drawing.Size(117, 29)
        Me.btnBackupBrowse.TabIndex = 32
        Me.btnBackupBrowse.Text = "Browse >>> "
        Me.btnBackupBrowse.UseVisualStyleBackColor = True
        Me.btnBackupBrowse.Visible = False
        '
        'btnRestorationBrowse
        '
        Me.btnRestorationBrowse.Location = New System.Drawing.Point(750, 181)
        Me.btnRestorationBrowse.Name = "btnRestorationBrowse"
        Me.btnRestorationBrowse.Size = New System.Drawing.Size(117, 29)
        Me.btnRestorationBrowse.TabIndex = 35
        Me.btnRestorationBrowse.Text = "Browse >>> "
        Me.btnRestorationBrowse.UseVisualStyleBackColor = True
        Me.btnRestorationBrowse.Visible = False
        '
        'txtDefaultRestoration
        '
        Me.txtDefaultRestoration.Location = New System.Drawing.Point(262, 182)
        Me.txtDefaultRestoration.Name = "txtDefaultRestoration"
        Me.txtDefaultRestoration.Size = New System.Drawing.Size(468, 29)
        Me.txtDefaultRestoration.TabIndex = 34
        '
        'lblDefaultRestorationLocation
        '
        Me.lblDefaultRestorationLocation.AutoSize = True
        Me.lblDefaultRestorationLocation.Location = New System.Drawing.Point(42, 185)
        Me.lblDefaultRestorationLocation.Name = "lblDefaultRestorationLocation"
        Me.lblDefaultRestorationLocation.Size = New System.Drawing.Size(204, 21)
        Me.lblDefaultRestorationLocation.TabIndex = 33
        Me.lblDefaultRestorationLocation.Text = "Default Restoration Location"
        '
        'chkAutoBackup
        '
        Me.chkAutoBackup.AutoSize = True
        Me.chkAutoBackup.Location = New System.Drawing.Point(46, 242)
        Me.chkAutoBackup.Name = "chkAutoBackup"
        Me.chkAutoBackup.Size = New System.Drawing.Size(210, 25)
        Me.chkAutoBackup.TabIndex = 37
        Me.chkAutoBackup.Text = "Perform Automatic Backup"
        Me.chkAutoBackup.UseVisualStyleBackColor = True
        '
        'btnAutoBackupSettings
        '
        Me.btnAutoBackupSettings.Location = New System.Drawing.Point(262, 239)
        Me.btnAutoBackupSettings.Name = "btnAutoBackupSettings"
        Me.btnAutoBackupSettings.Size = New System.Drawing.Size(117, 29)
        Me.btnAutoBackupSettings.TabIndex = 38
        Me.btnAutoBackupSettings.Text = "Configure"
        Me.btnAutoBackupSettings.UseVisualStyleBackColor = True
        Me.btnAutoBackupSettings.Visible = False
        '
        'lblBackupSubheader
        '
        Me.lblBackupSubheader.AutoSize = True
        Me.lblBackupSubheader.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupSubheader.Location = New System.Drawing.Point(16, 87)
        Me.lblBackupSubheader.Name = "lblBackupSubheader"
        Me.lblBackupSubheader.Size = New System.Drawing.Size(234, 32)
        Me.lblBackupSubheader.TabIndex = 39
        Me.lblBackupSubheader.Text = "Backup And Recovery"
        '
        'lblAppearance
        '
        Me.lblAppearance.AutoSize = True
        Me.lblAppearance.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppearance.Location = New System.Drawing.Point(16, 287)
        Me.lblAppearance.Name = "lblAppearance"
        Me.lblAppearance.Size = New System.Drawing.Size(136, 32)
        Me.lblAppearance.TabIndex = 40
        Me.lblAppearance.Text = "Appearance"
        '
        'lblPrimaryColor
        '
        Me.lblPrimaryColor.AutoSize = True
        Me.lblPrimaryColor.Location = New System.Drawing.Point(46, 339)
        Me.lblPrimaryColor.Name = "lblPrimaryColor"
        Me.lblPrimaryColor.Size = New System.Drawing.Size(108, 21)
        Me.lblPrimaryColor.TabIndex = 41
        Me.lblPrimaryColor.Text = "Primary Color:"
        '
        'pnlPrimaryColor
        '
        Me.pnlPrimaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrimaryColor.Location = New System.Drawing.Point(262, 339)
        Me.pnlPrimaryColor.Name = "pnlPrimaryColor"
        Me.pnlPrimaryColor.Size = New System.Drawing.Size(193, 21)
        Me.pnlPrimaryColor.TabIndex = 42
        '
        'lblSecondaryColor
        '
        Me.lblSecondaryColor.AutoSize = True
        Me.lblSecondaryColor.Location = New System.Drawing.Point(46, 372)
        Me.lblSecondaryColor.Name = "lblSecondaryColor"
        Me.lblSecondaryColor.Size = New System.Drawing.Size(127, 21)
        Me.lblSecondaryColor.TabIndex = 43
        Me.lblSecondaryColor.Text = "Secondary Color:"
        '
        'pnlSecondaryColor
        '
        Me.pnlSecondaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSecondaryColor.Location = New System.Drawing.Point(262, 372)
        Me.pnlSecondaryColor.Name = "pnlSecondaryColor"
        Me.pnlSecondaryColor.Size = New System.Drawing.Size(193, 21)
        Me.pnlSecondaryColor.TabIndex = 43
        '
        'cdlgColorScheme
        '
        Me.cdlgColorScheme.AnyColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 574)
        Me.Controls.Add(Me.pnlSecondaryColor)
        Me.Controls.Add(Me.lblSecondaryColor)
        Me.Controls.Add(Me.pnlPrimaryColor)
        Me.Controls.Add(Me.lblPrimaryColor)
        Me.Controls.Add(Me.lblAppearance)
        Me.Controls.Add(Me.lblBackupSubheader)
        Me.Controls.Add(Me.btnAutoBackupSettings)
        Me.Controls.Add(Me.chkAutoBackup)
        Me.Controls.Add(Me.btnRestorationBrowse)
        Me.Controls.Add(Me.txtDefaultRestoration)
        Me.Controls.Add(Me.lblDefaultRestorationLocation)
        Me.Controls.Add(Me.btnBackupBrowse)
        Me.Controls.Add(Me.txtDefaultBackup)
        Me.Controls.Add(Me.lblDefaultBackupLocation)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblSettingsHeader)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSettingsHeader As System.Windows.Forms.Label
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents lblDefaultBackupLocation As System.Windows.Forms.Label
    Friend WithEvents txtDefaultBackup As System.Windows.Forms.TextBox
    Friend WithEvents btnBackupBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRestorationBrowse As Button
    Friend WithEvents txtDefaultRestoration As TextBox
    Friend WithEvents lblDefaultRestorationLocation As Label
    Friend WithEvents chkAutoBackup As CheckBox
    Friend WithEvents btnAutoBackupSettings As Button
    Friend WithEvents lblBackupSubheader As Label
    Friend WithEvents lblAppearance As Label
    Friend WithEvents lblPrimaryColor As Label
    Friend WithEvents pnlPrimaryColor As Panel
    Friend WithEvents lblSecondaryColor As Label
    Friend WithEvents pnlSecondaryColor As Panel
    Friend WithEvents cdlgColorScheme As ColorDialog
End Class
