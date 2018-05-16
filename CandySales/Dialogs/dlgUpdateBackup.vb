Imports System.Windows.Forms

Public Class dlgUpdateBackup
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub NewFile_Button_Click(sender As Object, e As EventArgs) Handles NewFile_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Ignore
    End Sub
End Class