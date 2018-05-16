Imports System.IO
Imports System.Data.SQLite
Public Class LocalDatabase
    Dim localDatabaseLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\CandySales.db"
    Public Sub Initialize()
        If Not File.Exists(localDatabaseLocation) Then
            Create()
        End If
    End Sub
    Private Sub Create()
        Dim localStorageDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales"
        Directory.CreateDirectory(localStorageDirectory)
        Try
            If File.Exists(localDatabaseLocation) Then
                File.Delete(localDatabaseLocation)
            End If
            SQLiteConnection.CreateFile(localDatabaseLocation)
            Dim db As New SQLiteConnection("Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\CandySales.db; Version=3;")
            db.SetPassword("SkillsUSA")
        Catch ex As Exception
            Return
        End Try
        Dim tableCreateQueries As String() = {"CREATE TABLE 'AdminLogins' ('Username' TEXT NOT NULL, 'Password'	TEXT NOT NULL)", "Create TABLE Donations ('StudentID' TEXT NOT NULL, 'OrderNumber' INTEGER NOT NULL 'Amount' NUMERIC NOT NULL, 'TransactionDate' TEXT NOT NULL)", "CREATE TABLE 'Items'('UPC' TEXT PRIMARY KEY NOT NULL, 'Name' TEXT NOT NULL, 'UnitPrice' NUMERIC NOT NULL, 'RetailPrice' NUMERIC NOT NULL, 'InventoryAmount' INTEGER NOT NULL, 'LastYearUpdated' TEXT NOT NULL, 'Description' TEXT NOT NULL, 'IsImmediateReturn' INTEGER NOT NULL)", "CREATE TABLE 'Shops'('ShopID' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 'ShopName' TEXT NOT NULL, 'Cluster' TEXT NOT NULL)", "CREATE TABLE 'Students'('StudentID' INTEGER NOT NULL, 'FirstName' TEXT NOT NULL, 'LastName' TEXT NOT NULL, 'Shop' TEXT NOT NULL, 'District' TEXT NOT NULL, 'Session' TEXT NOT NULL, 'Grade' INTEGER NOT NULL)", "CREATE TABLE 'Transactions'('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'OrderNumber' INTEGER, 'StudentIDNumber' INTEGER, 'TransactionDate' TEXT, 'ItemID' TEXT, 'TransactionValue' REAL, 'PaymentMethod' TEXT, 'TechSession' TEXT, 'AdminUsername' TEXT)"}
        For Each tableQuery As String In tableCreateQueries
            Dim database As New DatabaseInteraction()
            database.NonQuery(tableQuery)
        Next
    End Sub
    Public Function isExist() As Boolean
        Return File.Exists(localDatabaseLocation)
    End Function
    Public Sub Reset()
        Dim localStorageDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales"
        Try
            File.Delete(localDatabaseLocation)
        Catch ex As Exception
            File.Delete(localDatabaseLocation)
        End Try
        Directory.Delete(localStorageDirectory)
    End Sub
End Class