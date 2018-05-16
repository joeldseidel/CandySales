Option Strict On
Public Class frmStudentView
    Dim database As New DatabaseInteraction()
    Dim student As Student
    Private Sub frmStudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshGUI()
    End Sub

    Public Sub refreshGUI()
        'Resets the GUI so that changes can be reverted or seen as per what comes from the database
        lstvStudentTransactions.Items.Clear()
        'Get student info from database
        Dim getStudentInfoSql As String = "SELECT * FROM Students WHERE StudentID=" & frmStats.selectedStudentID
        Dim studentResult As DataTable = database.Query(getStudentInfoSql)
        student = New Student(studentResult(0))
        'Get derived student data from transaction data
        student.OutstandingOrders = student.GetOutstandingOrders()
        student.RemainingDebt = student.GetRemainingDebt()
        'Set up form header
        lblStudentName.Text = student.FirstName & " " & student.LastName
        lblStudentShop.Text = student.Shop
        lblGrade.Text = "Grade: " & student.Grade
        lblSession.Text = "Session: " & student.Session
        'Get all student transactions from database
        Dim getStudentTransactionsSql As String = "SELECT * FROM Transactions WHERE StudentIDNumber='" & frmStats.selectedStudentID & "'"
        Dim studentTransactionsResults As DataTable = database.Query(getStudentTransactionsSql)
        Dim salesCounter As Integer = 0
        'Get the student sale count. To be counted a sale the transaction must be completed (must have a debt value of 0)
        For Each studentTransaction As DataRow In studentTransactionsResults.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(studentTransaction)
            If Not thisTransaction.IsTransactionOutstanding() Then
                'transaction is not outstanding and is therefore a complete transaction
                salesCounter += 1
            End If
        Next
        'Set student sale count to form header
        lblSales.Text = "Sales: " & salesCounter.ToString()
        For Each transRow As DataRow In studentTransactionsResults.Rows
            'Display every student transaction to the transaction list view
            Dim transaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transRow)
            'Create listview record array to be instantiated as a listviewitem
            Dim record() As String = {transaction.rowID.ToString(), transaction.TransactionDate, transaction.item.upc, transaction.TransactionValue.ToString("C2"), transaction.GetAdministrator.username}
            Dim transactionRecord As New ListViewItem(record)
            'Name transaction record to be the same as the transaction ID it represents
            transactionRecord.Name = transaction.rowID.ToString()
            'Add to transaction listview
            lstvStudentTransactions.Items.Add(transactionRecord)
        Next
    End Sub

    Private Sub lstvSelectedTransaction_DoubleClick(sender As Object, e As EventArgs) Handles lstvStudentTransactions.DoubleClick
        'Allows user to select a transaction and edit it by double clicking while a transaciton record is selected
        If lstvStudentTransactions.SelectedItems Is Nothing Then
            'Nothing was selected during the double click. Do nothing
            Return
        End If
        'Confirm users intent to edit a record
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to edit this record?" & Environment.NewLine & "Data integrity could be lost with the editing of this record!", "Confirm Record Edit", MessageBoxButtons.YesNo)
        If confirmation <> DialogResult.Yes Then
            'Oh okay, maybe next time
            Return
        End If
        'The user wants to update this record
        Dim newDate As String = InputBox("Enter an updated date for the updated record" & Environment.NewLine & "Leave blank to keep original", "Update Date", "")
        If newDate = "" Then
            'Use the previous date as the user has nothing to add/change
            newDate = lstvStudentTransactions.SelectedItems(0).SubItems(1).Text.ToString
        End If
        Dim newItem As String = ""
        Do
            'Validation loop entered
            'Get desired item
            Dim newItemInput As String = InputBox("Enter an update item UPC code for the updated record" & Environment.NewLine & "Leave blank to keep original", "Update Item", "")
            Dim itemCheckSql As String = "SELECT Name FROM Items WHERE UPC = '" & newItemInput.ToString() & "'"
            If newItemInput = "" Then
                'Use the previous item as the user has nothing to add/change
                newItem = lstvStudentTransactions.SelectedItems(0).SubItems(2).Text.ToString()
            Else
                'User has given us some data to play with
                If database.Query(itemCheckSql).Rows.Count < 1 Then
                    'Exciting to get some new data, but it doesn't exist and therefore really doesn't matter
                    MsgBox("You did not enter a recognized UPC code")
                Else
                    'User entered valid information (for once) and updates item selection to database
                    newItem = newItemInput
                End If
            End If
        Loop Until newItem <> ""
        Dim newTransactionValue As String = ""
        Do
            'Validation loop for transaction value
            'Get desired transaciton value
            Dim newTransactionValueInput As String = InputBox("Enter the updated transaction value" & Environment.NewLine & "Leave blank to keep original", "Update Transaction Value", "")
            Dim minItemPrice As Decimal
            If newTransactionValueInput <> "" Then
                'User has provided new data
                If Convert.ToDecimal(newTransactionValueInput) > minItemPrice Then
                    Dim confirmDonation As DialogResult = MessageBox.Show("The value entered is more than the price of the item. The extra will be considered a donation", "Confirm donation", MessageBoxButtons.OKCancel)
                    If confirmDonation = DialogResult.OK Then
                        Dim writeDonationSql = "INSERT INTO Donations(StudentID, Amount) VALUES('" & student.studentID & "'," & Convert.ToDouble(newTransactionValueInput) - minItemPrice & ")"
                        database.NonQuery(writeDonationSql)
                        newTransactionValue = newTransactionValueInput
                    End If
                ElseIf Convert.ToDecimal(newTransactionValueInput) = minItemPrice Then
                    newTransactionValue = newTransactionValueInput
                End If
            Else
                newTransactionValue = lstvStudentTransactions.SelectedItems(0).SubItems(3).Text.ToString
            End If
        Loop Until newTransactionValue <> ""
        Dim updateRecordSql As String = "UPDATE Transactions SET TransactionDate='" & newDate & "', ItemID='" & newItem & "', TransactionValue=" & CDec(newTransactionValue).ToString("N2") & " WHERE ID=" & lstvStudentTransactions.SelectedItems(0).SubItems(0).Text.ToString
        database.NonQuery(updateRecordSql)

        lstvStudentTransactions.Items.Clear()
        student.OutstandingOrders = student.GetOutstandingOrders()
        student.RemainingDebt = student.GetRemainingDebt()
        Dim getStudentTransactionsSql As String = "SELECT * FROM Transactions WHERE StudentIDNumber='" & frmStats.selectedStudentID & "'"
        Dim studentTransactionsResults As DataTable = database.Query(getStudentTransactionsSql)

        lblSales.Text = "Sales: " & ((studentTransactionsResults.Rows.Count - student.OutstandingOrders) / 2).ToString()
        For Each transRow As DataRow In studentTransactionsResults.Rows
            Dim transaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transRow)
            Dim record() As String = {transaction.rowID.ToString(), transaction.TransactionDate, transaction.item.upc, transaction.TransactionValue.ToString("C2"), transaction.GetAdministrator.username}
            Dim transactionRecord As New ListViewItem(record)
            transactionRecord.Name = transaction.rowID.ToString()
            lstvStudentTransactions.Items.Add(transactionRecord)
        Next
    End Sub
    Public Property editStudentID As String
    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        editStudentID = student.studentID.ToString
        frmEditStudent.Show()
    End Sub

    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this student? This CANNOT be reversed!", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.No Then
            Return
        End If
        Dim deleteStudentSql As String = "DELETE FROM Students WHERE StudentID=" & student.studentID
        database.NonQuery(deleteStudentSql)
        Dim deleteStudentTransactionsSql As String = "DELETE FROM Transactions WHERE StudentIDNumber=" & student.studentID
        database.NonQuery(deleteStudentSql)
        Me.Close()
    End Sub
End Class