<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.fbdGetBackUpLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbcBackup = New System.Windows.Forms.TabControl()
        Me.tbpBackup = New System.Windows.Forms.TabPage()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblStartBackup = New System.Windows.Forms.Label()
        Me.btnBrowseLocation = New System.Windows.Forms.Button()
        Me.lblSelectBackupLocation = New System.Windows.Forms.Label()
        Me.clstSelectedTable = New System.Windows.Forms.CheckedListBox()
        Me.lblBackupHeader = New System.Windows.Forms.Label()
        Me.tbpRestore = New System.Windows.Forms.TabPage()
        Me.prgBackup = New System.Windows.Forms.ProgressBar()
        Me.btnStartRestore = New System.Windows.Forms.Button()
        Me.lblStartRestore = New System.Windows.Forms.Label()
        Me.btnGetRestoreLocation = New System.Windows.Forms.Button()
        Me.lblSelectRestorePath = New System.Windows.Forms.Label()
        Me.tbcBackup.SuspendLayout()
        Me.tbpBackup.SuspendLayout()
        Me.tbpRestore.SuspendLayout()
        Me.SuspendLayout()
        '
        'fbdGetBackUpLocation
        '
        Me.fbdGetBackUpLocation.Description = "Select a location for the database backup"
        Me.fbdGetBackUpLocation.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'tbcBackup
        '
        Me.tbcBackup.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcBackup.Controls.Add(Me.tbpBackup)
        Me.tbcBackup.Controls.Add(Me.tbpRestore)
        Me.tbcBackup.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcBackup.Location = New System.Drawing.Point(12, -1)
        Me.tbcBackup.Name = "tbcBackup"
        Me.tbcBackup.SelectedIndex = 0
        Me.tbcBackup.Size = New System.Drawing.Size(478, 290)
        Me.tbcBackup.TabIndex = 6
        '
        'tbpBackup
        '
        Me.tbpBackup.Controls.Add(Me.btnStart)
        Me.tbpBackup.Controls.Add(Me.lblStartBackup)
        Me.tbpBackup.Controls.Add(Me.btnBrowseLocation)
        Me.tbpBackup.Controls.Add(Me.lblSelectBackupLocation)
        Me.tbpBackup.Controls.Add(Me.clstSelectedTable)
        Me.tbpBackup.Controls.Add(Me.lblBackupHeader)
        Me.tbpBackup.Location = New System.Drawing.Point(4, 33)
        Me.tbpBackup.Name = "tbpBackup"
        Me.tbpBackup.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBackup.Size = New System.Drawing.Size(470, 253)
        Me.tbpBackup.TabIndex = 0
        Me.tbpBackup.Text = "Backup"
        Me.tbpBackup.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(243, 171)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(124, 44)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblStartBackup
        '
        Me.lblStartBackup.AutoSize = True
        Me.lblStartBackup.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartBackup.Location = New System.Drawing.Point(238, 128)
        Me.lblStartBackup.Name = "lblStartBackup"
        Me.lblStartBackup.Size = New System.Drawing.Size(129, 30)
        Me.lblStartBackup.TabIndex = 10
        Me.lblStartBackup.Text = "Start Backup"
        '
        'btnBrowseLocation
        '
        Me.btnBrowseLocation.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseLocation.Location = New System.Drawing.Point(243, 43)
        Me.btnBrowseLocation.Name = "btnBrowseLocation"
        Me.btnBrowseLocation.Size = New System.Drawing.Size(124, 44)
        Me.btnBrowseLocation.TabIndex = 9
        Me.btnBrowseLocation.Text = "Browse >>>"
        Me.btnBrowseLocation.UseVisualStyleBackColor = True
        '
        'lblSelectBackupLocation
        '
        Me.lblSelectBackupLocation.AutoSize = True
        Me.lblSelectBackupLocation.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectBackupLocation.Location = New System.Drawing.Point(238, 3)
        Me.lblSelectBackupLocation.Name = "lblSelectBackupLocation"
        Me.lblSelectBackupLocation.Size = New System.Drawing.Size(226, 30)
        Me.lblSelectBackupLocation.TabIndex = 8
        Me.lblSelectBackupLocation.Text = "Select Backup Location"
        '
        'clstSelectedTable
        '
        Me.clstSelectedTable.FormattingEnabled = True
        Me.clstSelectedTable.Location = New System.Drawing.Point(6, 43)
        Me.clstSelectedTable.Name = "clstSelectedTable"
        Me.clstSelectedTable.Size = New System.Drawing.Size(180, 172)
        Me.clstSelectedTable.TabIndex = 7
        '
        'lblBackupHeader
        '
        Me.lblBackupHeader.AutoSize = True
        Me.lblBackupHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupHeader.Location = New System.Drawing.Point(6, 3)
        Me.lblBackupHeader.Name = "lblBackupHeader"
        Me.lblBackupHeader.Size = New System.Drawing.Size(217, 30)
        Me.lblBackupHeader.TabIndex = 6
        Me.lblBackupHeader.Text = "Select Data To Backup"
        '
        'tbpRestore
        '
        Me.tbpRestore.Controls.Add(Me.prgBackup)
        Me.tbpRestore.Controls.Add(Me.btnStartRestore)
        Me.tbpRestore.Controls.Add(Me.lblStartRestore)
        Me.tbpRestore.Controls.Add(Me.btnGetRestoreLocation)
        Me.tbpRestore.Controls.Add(Me.lblSelectRestorePath)
        Me.tbpRestore.Location = New System.Drawing.Point(4, 33)
        Me.tbpRestore.Name = "tbpRestore"
        Me.tbpRestore.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRestore.Size = New System.Drawing.Size(470, 253)
        Me.tbpRestore.TabIndex = 1
        Me.tbpRestore.Text = "Restore"
        Me.tbpRestore.UseVisualStyleBackColor = True
        '
        'prgBackup
        '
        Me.prgBackup.Location = New System.Drawing.Point(157, 214)
        Me.prgBackup.Name = "prgBackup"
        Me.prgBackup.Size = New System.Drawing.Size(161, 23)
        Me.prgBackup.TabIndex = 14
        '
        'btnStartRestore
        '
        Me.btnStartRestore.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartRestore.Location = New System.Drawing.Point(173, 150)
        Me.btnStartRestore.Name = "btnStartRestore"
        Me.btnStartRestore.Size = New System.Drawing.Size(124, 44)
        Me.btnStartRestore.TabIndex = 13
        Me.btnStartRestore.Text = "Start!"
        Me.btnStartRestore.UseVisualStyleBackColor = True
        '
        'lblStartRestore
        '
        Me.lblStartRestore.AutoSize = True
        Me.lblStartRestore.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartRestore.Location = New System.Drawing.Point(152, 117)
        Me.lblStartRestore.Name = "lblStartRestore"
        Me.lblStartRestore.Size = New System.Drawing.Size(166, 30)
        Me.lblStartRestore.TabIndex = 12
        Me.lblStartRestore.Text = "Start Restoration"
        '
        'btnGetRestoreLocation
        '
        Me.btnGetRestoreLocation.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetRestoreLocation.Location = New System.Drawing.Point(173, 36)
        Me.btnGetRestoreLocation.Name = "btnGetRestoreLocation"
        Me.btnGetRestoreLocation.Size = New System.Drawing.Size(124, 44)
        Me.btnGetRestoreLocation.TabIndex = 10
        Me.btnGetRestoreLocation.Text = "Browse >>>"
        Me.btnGetRestoreLocation.UseVisualStyleBackColor = True
        '
        'lblSelectRestorePath
        '
        Me.lblSelectRestorePath.AutoSize = True
        Me.lblSelectRestorePath.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectRestorePath.Location = New System.Drawing.Point(145, 3)
        Me.lblSelectRestorePath.Name = "lblSelectRestorePath"
        Me.lblSelectRestorePath.Size = New System.Drawing.Size(181, 30)
        Me.lblSelectRestorePath.TabIndex = 0
        Me.lblSelectRestorePath.Text = "Select Restore File"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 301)
        Me.Controls.Add(Me.tbcBackup)
        Me.Name = "frmBackup"
        Me.Text = "Backup"
        Me.tbcBackup.ResumeLayout(False)
        Me.tbpBackup.ResumeLayout(False)
        Me.tbpBackup.PerformLayout()
        Me.tbpRestore.ResumeLayout(False)
        Me.tbpRestore.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fbdGetBackUpLocation As FolderBrowserDialog
    Friend WithEvents tbcBackup As System.Windows.Forms.TabControl
    Friend WithEvents tbpBackup As System.Windows.Forms.TabPage
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblStartBackup As System.Windows.Forms.Label
    Friend WithEvents btnBrowseLocation As System.Windows.Forms.Button
    Friend WithEvents lblSelectBackupLocation As System.Windows.Forms.Label
    Friend WithEvents clstSelectedTable As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblBackupHeader As System.Windows.Forms.Label
    Friend WithEvents tbpRestore As System.Windows.Forms.TabPage
    Friend WithEvents btnStartRestore As Button
    Friend WithEvents lblStartRestore As Label
    Friend WithEvents btnGetRestoreLocation As Button
    Friend WithEvents lblSelectRestorePath As Label
    Friend WithEvents prgBackup As System.Windows.Forms.ProgressBar
End Class
