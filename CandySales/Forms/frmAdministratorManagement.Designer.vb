<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministratorManagement
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
        Me.tbcAdminControl = New System.Windows.Forms.TabControl()
        Me.tbpNewAdmin = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtNewConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblNewConfirmPass = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.lblNewUsername = New System.Windows.Forms.Label()
        Me.tbpDeleteAdmin = New System.Windows.Forms.TabPage()
        Me.lblTransactionCount = New System.Windows.Forms.Label()
        Me.btnCancelRevoke = New System.Windows.Forms.Button()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.cboAdmin = New System.Windows.Forms.ComboBox()
        Me.lblSelectAdmin = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.lstCurrentAdmin = New System.Windows.Forms.ListBox()
        Me.tbcAdminControl.SuspendLayout()
        Me.tbpNewAdmin.SuspendLayout()
        Me.tbpDeleteAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcAdminControl
        '
        Me.tbcAdminControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcAdminControl.Controls.Add(Me.tbpNewAdmin)
        Me.tbcAdminControl.Controls.Add(Me.tbpDeleteAdmin)
        Me.tbcAdminControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbcAdminControl.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcAdminControl.Location = New System.Drawing.Point(0, 0)
        Me.tbcAdminControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbcAdminControl.Name = "tbcAdminControl"
        Me.tbcAdminControl.SelectedIndex = 0
        Me.tbcAdminControl.Size = New System.Drawing.Size(426, 351)
        Me.tbcAdminControl.TabIndex = 0
        '
        'tbpNewAdmin
        '
        Me.tbpNewAdmin.Controls.Add(Me.btnCancel)
        Me.tbpNewAdmin.Controls.Add(Me.btnCreate)
        Me.tbpNewAdmin.Controls.Add(Me.txtNewConfirmPass)
        Me.tbpNewAdmin.Controls.Add(Me.lblNewConfirmPass)
        Me.tbpNewAdmin.Controls.Add(Me.txtNewPassword)
        Me.tbpNewAdmin.Controls.Add(Me.lblNewPassword)
        Me.tbpNewAdmin.Controls.Add(Me.txtNewUsername)
        Me.tbpNewAdmin.Controls.Add(Me.lblNewUsername)
        Me.tbpNewAdmin.Location = New System.Drawing.Point(4, 33)
        Me.tbpNewAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpNewAdmin.Name = "tbpNewAdmin"
        Me.tbpNewAdmin.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpNewAdmin.Size = New System.Drawing.Size(418, 314)
        Me.tbpNewAdmin.TabIndex = 0
        Me.tbpNewAdmin.Text = "Create New"
        Me.tbpNewAdmin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(151, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 45)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(284, 261)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(127, 45)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtNewConfirmPass
        '
        Me.txtNewConfirmPass.Location = New System.Drawing.Point(162, 141)
        Me.txtNewConfirmPass.Name = "txtNewConfirmPass"
        Me.txtNewConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewConfirmPass.Size = New System.Drawing.Size(217, 29)
        Me.txtNewConfirmPass.TabIndex = 5
        '
        'lblNewConfirmPass
        '
        Me.lblNewConfirmPass.AutoSize = True
        Me.lblNewConfirmPass.Location = New System.Drawing.Point(22, 144)
        Me.lblNewConfirmPass.Name = "lblNewConfirmPass"
        Me.lblNewConfirmPass.Size = New System.Drawing.Size(137, 21)
        Me.lblNewConfirmPass.TabIndex = 4
        Me.lblNewConfirmPass.Text = "Confirm Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(162, 85)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(217, 29)
        Me.txtNewPassword.TabIndex = 3
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(22, 88)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(129, 21)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "Enter a Password:"
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Location = New System.Drawing.Point(162, 29)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(217, 29)
        Me.txtNewUsername.TabIndex = 1
        '
        'lblNewUsername
        '
        Me.lblNewUsername.AutoSize = True
        Me.lblNewUsername.Location = New System.Drawing.Point(22, 32)
        Me.lblNewUsername.Name = "lblNewUsername"
        Me.lblNewUsername.Size = New System.Drawing.Size(134, 21)
        Me.lblNewUsername.TabIndex = 0
        Me.lblNewUsername.Text = "Enter a Username:"
        '
        'tbpDeleteAdmin
        '
        Me.tbpDeleteAdmin.Controls.Add(Me.lblTransactionCount)
        Me.tbpDeleteAdmin.Controls.Add(Me.btnCancelRevoke)
        Me.tbpDeleteAdmin.Controls.Add(Me.btnRevoke)
        Me.tbpDeleteAdmin.Controls.Add(Me.cboAdmin)
        Me.tbpDeleteAdmin.Controls.Add(Me.lblSelectAdmin)
        Me.tbpDeleteAdmin.Location = New System.Drawing.Point(4, 33)
        Me.tbpDeleteAdmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpDeleteAdmin.Name = "tbpDeleteAdmin"
        Me.tbpDeleteAdmin.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpDeleteAdmin.Size = New System.Drawing.Size(418, 314)
        Me.tbpDeleteAdmin.TabIndex = 1
        Me.tbpDeleteAdmin.Text = "Remove Access"
        '
        'lblTransactionCount
        '
        Me.lblTransactionCount.AutoSize = True
        Me.lblTransactionCount.Location = New System.Drawing.Point(12, 136)
        Me.lblTransactionCount.Name = "lblTransactionCount"
        Me.lblTransactionCount.Size = New System.Drawing.Size(178, 21)
        Me.lblTransactionCount.TabIndex = 9
        Me.lblTransactionCount.Text = "Transactions Completed:"
        '
        'btnCancelRevoke
        '
        Me.btnCancelRevoke.Location = New System.Drawing.Point(151, 261)
        Me.btnCancelRevoke.Name = "btnCancelRevoke"
        Me.btnCancelRevoke.Size = New System.Drawing.Size(127, 45)
        Me.btnCancelRevoke.TabIndex = 8
        Me.btnCancelRevoke.Text = "Cancel"
        Me.btnCancelRevoke.UseVisualStyleBackColor = True
        '
        'btnRevoke
        '
        Me.btnRevoke.Location = New System.Drawing.Point(284, 261)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.Size = New System.Drawing.Size(127, 45)
        Me.btnRevoke.TabIndex = 7
        Me.btnRevoke.Text = "Revoke"
        Me.btnRevoke.UseVisualStyleBackColor = True
        '
        'cboAdmin
        '
        Me.cboAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAdmin.FormattingEnabled = True
        Me.cboAdmin.Location = New System.Drawing.Point(12, 71)
        Me.cboAdmin.Name = "cboAdmin"
        Me.cboAdmin.Size = New System.Drawing.Size(217, 29)
        Me.cboAdmin.TabIndex = 1
        '
        'lblSelectAdmin
        '
        Me.lblSelectAdmin.AutoSize = True
        Me.lblSelectAdmin.Location = New System.Drawing.Point(8, 36)
        Me.lblSelectAdmin.Name = "lblSelectAdmin"
        Me.lblSelectAdmin.Size = New System.Drawing.Size(221, 21)
        Me.lblSelectAdmin.TabIndex = 0
        Me.lblSelectAdmin.Text = "Select Admin To Revoke Access"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(426, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 351)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'lstCurrentAdmin
        '
        Me.lstCurrentAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCurrentAdmin.FormattingEnabled = True
        Me.lstCurrentAdmin.ItemHeight = 21
        Me.lstCurrentAdmin.Location = New System.Drawing.Point(433, 0)
        Me.lstCurrentAdmin.Name = "lstCurrentAdmin"
        Me.lstCurrentAdmin.Size = New System.Drawing.Size(191, 340)
        Me.lstCurrentAdmin.TabIndex = 2
        '
        'frmAdministratorManagement
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 351)
        Me.Controls.Add(Me.lstCurrentAdmin)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tbcAdminControl)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAdministratorManagement"
        Me.Text = "Administrator Management"
        Me.tbcAdminControl.ResumeLayout(False)
        Me.tbpNewAdmin.ResumeLayout(False)
        Me.tbpNewAdmin.PerformLayout()
        Me.tbpDeleteAdmin.ResumeLayout(False)
        Me.tbpDeleteAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcAdminControl As TabControl
    Friend WithEvents tbpNewAdmin As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtNewConfirmPass As TextBox
    Friend WithEvents lblNewConfirmPass As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents tbpDeleteAdmin As TabPage
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents lstCurrentAdmin As ListBox
    Friend WithEvents cboAdmin As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectAdmin As System.Windows.Forms.Label
    Friend WithEvents btnCancelRevoke As System.Windows.Forms.Button
    Friend WithEvents btnRevoke As System.Windows.Forms.Button
    Friend WithEvents lblTransactionCount As System.Windows.Forms.Label
End Class
