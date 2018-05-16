Public Class frmCreateProduct
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim upc, name, description As String
        Dim price As Decimal
        Dim initialInventory As Integer
        Dim inputTextBoxArray() As TextBox = {txtUPC, txtProductName, txtProductDescription}
        For Each inputTextBox As TextBox In inputTextBoxArray
            If inputTextBox.Text = "" Then
                MsgBox("No field can be left blank!", MessageBoxButtons.OK, "Input Error")
                Return
            End If
            If inputTextBox.Text.Contains("'") Then
                MsgBox("No field can contain the ' character", MessageBoxButtons.OK, "Input Error")
                Return
            End If
        Next
        If nudRetailPrice.Value = 0 Or nudInitialInventory.Value = 0 Then
            MsgBox("Numeric fields cannot be left 0", , "Input Error")
            Return
        End If
        If txtUPC.Text.IndexOf("0") = 0 Then
            txtUPC.Text = txtUPC.Text.Substring(1, txtUPC.Text.Length - 1)
        End If
        upc = txtUPC.Text
        name = txtProductName.Text
        description = txtProductDescription.Text
        price = nudRetailPrice.Value
        initialInventory = nudInitialInventory.Value
        Dim newProduct As New Item(upc, name, description, price, False, initialInventory)
        newProduct.CreateNew()
        Me.Close()
    End Sub
End Class