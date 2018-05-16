Imports System.IO
Public Class frmImportStudents
    Private importFile As String
    Private Sub btnSelectImportFile_Click(sender As Object, e As EventArgs) Handles btnSelectImportFile.Click
        Dim getImportFileResult As DialogResult = ofdImportFile.ShowDialog()
        If getImportFileResult = DialogResult.OK Then
            importFile = ofdImportFile.FileName
            btnSelectImportFile.Text = "Done"
            btnSelectImportFile.Enabled = False
        End If
    End Sub
    Private Sub btnBeginImport_Click(sender As Object, e As EventArgs) Handles btnBeginImport.Click
        prgImportProgress.Visible = True
        Dim recordReader As New StreamReader(importFile)
        Dim totalRecordCount As Integer = GetLineCount()
        recordReader.ReadLine()
        Dim database As New PersistentDatabaseInteraction
        Dim recordCounter As Integer = 0
        Do While recordReader.Peek <> -1
            Dim thisRecord As String()
            Dim recordText As String = recordReader.ReadLine()
            recordText = recordText.Replace("'", "")
            thisRecord = recordText.Split(",")
            Dim insertStudentRecordSql As String = "INSERT INTO Students(StudentID, FirstName, LastName, Shop, District, Session, Grade) VALUES (" & thisRecord(0) & ", '" & thisRecord(1) & "', '" & thisRecord(3) & "', '" & thisRecord(5) & "', '" & thisRecord(4) & "', '" & thisRecord(6) & "', " & thisRecord(7) & ")"
            database.NonQuery(insertStudentRecordSql)
            recordCounter += 1
            prgImportProgress.Value = Math.Floor(recordCounter / totalRecordCount * 100)
        Loop
        database.CloseConnection()
        btnBeginImport.Enabled = False
        btnBeginImport.Text = "Done"
        prgImportProgress.Visible = False
    End Sub
    Private Sub btnCompleteImport_Click(sender As Object, e As EventArgs) Handles btnCompleteImport.Click
        Me.Close()
    End Sub
    Private Function GetLineCount() As Integer
        Dim recordReader As New StreamReader(importFile)
        Dim recordText As String = recordReader.ReadToEnd()
        Dim allLines() As String = recordText.Split(Environment.NewLine)
        'Account for 0 base and wasted line 1
        Return allLines.Count - 2
    End Function
End Class