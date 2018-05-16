Option Strict On
Public Class frmDateReports
    Private database As New DatabaseInteraction()
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        lstDateRangeMatching.Items.Clear()
        Dim startDate As DateTime = dtpStartDate.Value.Date
        Dim endDate As DateTime = dtpEndDate.Value.Date
        Dim dateRange As DateRange
        Dim dateRecords As New DataTable()
        If radDateRange.Checked Then
            dateRange = New DateRange(startDate, endDate)
            dateRecords = getDataFromRange(dateRange)
        Else
            dateRecords = getDataFromSingleDate(startDate)
        End If
        PopulateResultsBox(dateRecords)
    End Sub

    Private Sub dateSelectionOptionCheckChanged(sender As Object, e As EventArgs) Handles radSingleDate.CheckedChanged, radDateRange.CheckedChanged
        If CType(sender, RadioButton).Name = radDateRange.Name Then
            'The object raising the event is the date range option. Change the GUI to reflect that choice
            lblEndDate.Visible = True
            dtpEndDate.Visible = True
        Else
            'The object raising the event is the single date option. Change the GUI to reflect that choice
            lblEndDate.Visible = False
            dtpEndDate.Visible = False
        End If
    End Sub

    Private Function getDataFromRange(dateRange As DateRange) As DataTable
        Dim dateRangeSql As String = "SELECT * FROM Transactions WHERE TransactionDate = "
        Dim firstCondition As Boolean = True
        For dayInRange As Integer = 0 To Convert.ToInt32(dateRange.DateRange) Step 1
            If firstCondition Then
                dateRangeSql &= "'" & dateRange.StartDate.AddDays(dayInRange) & "' "
                firstCondition = False
            Else
                dateRangeSql &= "OR TransactionDate = '" & dateRange.StartDate.AddDays(dayInRange) & "'"
            End If
        Next
        Return database.Query(dateRangeSql)
    End Function

    Private Function getDataFromSingleDate(singleDate As DateTime) As DataTable
        Dim dateSingleSql As String = "SELECT * FROM Transactions WHERE TransactionDate = '" & singleDate.ToShortDateString() & "'"
        Return database.Query(dateSingleSql)
    End Function
    Dim displayedTransactions As New List(Of PerformedTransaction)
    Private Sub PopulateResultsBox(dateRecords As DataTable)
        For Each transactionRecord As DataRow In dateRecords.Rows
            Dim currentTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transactionRecord)
            Dim currentTransactionItem As New Item(GetCorrespondingItem(currentTransaction.item.upc.ToString()))
            If currentTransaction.TransactionValue < 0 Then
                lstDateRangeMatching.Items.Add(currentTransaction.TransactionDate & ": " & currentTransaction.student.FirstName & " " & currentTransaction.student.LastName & " withdrew a " & currentTransactionItem.name)
            Else
                lstDateRangeMatching.Items.Add(currentTransaction.TransactionDate & ": " & currentTransaction.student.FirstName & " " & currentTransaction.student.LastName & " payed off a " & currentTransactionItem.name)
            End If
            displayedTransactions.Add(currentTransaction)
        Next
        If lstDateRangeMatching.Items.Count = 0 Then
            lstDateRangeMatching.Items.Add("Nothing here.... Try another date")
        End If
    End Sub
    Private Function GetCorrespondingStudent(studentIDNumber As String) As DataRow
        Dim getStudentSql As String = "SELECT * FROM Students WHERE StudentID = " & Convert.ToInt32(studentIDNumber)
        Return database.Query(getStudentSql).Rows(0)
    End Function
    Private Function GetCorrespondingItem(itemIDNumber As String) As DataRow
        If itemIDNumber.Length <> 12 Then
            itemIDNumber = itemIDNumber
        End If
        Dim getItemSql As String = "SELECT * FROM Items WHERE UPC ='" & itemIDNumber & "'"
        Return database.Query(getItemSql).Rows(0)
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub lstDateRangeMatching_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDateRangeMatching.SelectedIndexChanged
        If lstDateRangeMatching.SelectedIndex <> -1 Then
            If displayedTransactions.Item(lstDateRangeMatching.SelectedIndex).TransactionValue > 0 Then
                btnGenerateReceipt.Visible = True
            End If
        End If
    End Sub
    Private Sub btnGenerateReceipt_Click(sender As Object, e As EventArgs) Handles btnGenerateReceipt.Click
        Dim selectedTransaction As Integer = lstDateRangeMatching.SelectedIndex
        Dim performedTransaction As PerformedTransaction = displayedTransactions(selectedTransaction)
        Dim getStudentSql As String = "SELECT * FROM Students WHERE StudentID = '" & performedTransaction.student.studentID & "'"
        Dim studentData As DataTable = database.Query(getStudentSql)
        Dim getItemSql As String = "SELECT * FROM Items WHERE UPC = '" & performedTransaction.item.upc & "'"
        Dim itemData As DataTable = database.Query(getItemSql)
        Dim getTransactionData As String = "SELECT * FROM Transactions WHERE ID = " & performedTransaction.rowID
        Dim transactionData As DataTable = database.Query(getTransactionData)
        Dim receipt As New Receipt(studentData, itemData, transactionData)
    End Sub
End Class