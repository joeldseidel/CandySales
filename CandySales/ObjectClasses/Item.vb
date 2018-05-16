Option Strict On
Public Class Item
    Public upc, name, lastYearUpdated, description As String
    Public unitPrice, debtCreated, retailPrice As Decimal
    Public inventoryAmount As Integer
    Public isImmediateReturn As Boolean
    Private database As New DatabaseInteraction
    Sub New(item As DataRow)
        ParseFromDataRow(item)
    End Sub
    Sub New(upc As String)
        Me.upc = upc.ToString()
        GetItem(upc)
    End Sub
    Sub New(upc As String, name As String, description As String, retailPrice As Decimal, isImmediateReturn As Boolean, inventoryAmount As Integer)
        Me.upc = upc
        Me.name = name
        Me.retailPrice = retailPrice
        Me.isImmediateReturn = isImmediateReturn
        Me.inventoryAmount = inventoryAmount
    End Sub
    Public Sub GetItem(upc As String)
        Dim getThisItemSql As String = "SELECT * FROM Items WHERE UPC = '" & upc & "'"
        Dim thisItemRecord As DataTable = database.Query(getThisItemSql)
        ParseFromDataRow(thisItemRecord.Rows(0))
    End Sub
    Private Sub ParseFromDataRow(itemRow As DataRow)
        upc = itemRow.Item(0).ToString
        name = itemRow.Item(1).ToString
        unitPrice = Convert.ToDecimal(itemRow.Item(2))
        retailPrice = Convert.ToDecimal(itemRow.Item(3))
        inventoryAmount = Convert.ToInt32(itemRow.Item(4))
        description = itemRow.Item(6).ToString
        isImmediateReturn = Convert.ToBoolean(itemRow.Item(7))
        debtCreated = retailPrice * -1
    End Sub
    Public Sub CreateNew()
        Dim newItemSql As String = "INSERT INTO Items(UPC, Name, UnitPrice, RetailPrice, InventoryAmount, LastYearUpdated, Description, IsImmediateReturn) VALUES ('" & upc & "', '" & name & "', 0, " & retailPrice & "," & inventoryAmount & ", 2016, '" & description & "', " & Convert.ToInt32(isImmediateReturn) & ")"
        database.NonQuery(newItemSql)
    End Sub
    Public Sub Update(upc As String, name As String, retailPrice As Decimal)
        Dim updateItemSql As String = "UPDATE Items SET UPC = '" & upc & "', Name = '" & name & "', RetailPrice = " & retailPrice.ToString & " WHERE UPC = '" & Me.upc & "'"
        database.NonQuery(updateItemSql)
        Me.upc = upc
        Me.name = name
    End Sub
    Public Sub UpdateInventory(inventoryAddition As Integer)
        Dim getCurrentInventorySql As String = "SELECT * FROM Items WHERE UPC = '" & upc & "'"
        Dim currentInventory As Integer = Convert.ToInt32(database.Query(getCurrentInventorySql).Rows(0).Item(4))
        Dim updatedInventory As Integer = currentInventory + inventoryAddition
        Dim updateInventorySql As String = "UPDATE Items SET InventoryAmount = " & updatedInventory.ToString() & " WHERE UPC = '" & upc & "'"
        database.NonQuery(updateInventorySql)
    End Sub
    Public Sub Delete()
        Dim deleteProductSql As String = "DELETE FROM Items WHERE UPC = '" & upc & "'"
        database.NonQuery(deleteProductSql)
    End Sub
End Class
