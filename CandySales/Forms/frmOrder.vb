Option Strict On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
''' <summary>
''' Form that contains the withdraw/payment controls and the statistics viewer on a seperate tab
''' </summary>
Public Class frmOrder
    Dim database As New DatabaseInteraction()
    Dim selectedStudent As Student
    Public Shared username, password As String
    Dim currentAdmin As Administrator
    Private Sub frmOrderStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prepare form for order and statistics tabs
        'Set cursor to student ID field
        txtStudentID.Select()
        currentAdmin = New Administrator(username, password)
    End Sub

    Public Property shopName As String

    Private Sub shopStatsHandler(sender As Object, e As EventArgs)
        'Set the shop name to the property that can be read from the shop view form
        shopName = CType(sender, ToolStripMenuItem).Text
        frmShopView.Show()
    End Sub

    Private Sub btnGetInfoOnStudent_Click(sender As Object, e As EventArgs) Handles btnGetInfoOnStudent.Click, GetOrdersToolStripMenuItem.Click
        'Set disabled payment/withdraw elements to be enabled, show student information, allow withdraw/payment
        'Update item/orders
        ResetItemOrderSelection()
        'Update student information and reflect to form
        UpdateStudentInformation()
        'Test for success of getting student
        If lblName.Text = "" Then
            txtStudentID.Focus()
            txtStudentID.Text = ""
            Return
        End If
        grpInformation.Visible = True
        Dim hiddenElements As Control() = {grpInformation, btnWithdrawItem, btnPayAmount, lblItemToWithdraw, lblOrder, lblPaymentAmount, cboItemToWithdraw, cboOrders, lblPaymentMethod, grpMethods, radCash, radCheck, txtAmount}
        For Each element As Control In hiddenElements
            element.Enabled = True
        Next
        'Populate orders and items comboboxes
        UpdateItemSelections()
        UpdateOrderSelection(txtStudentID.Text)
        'Set cursor to withdraw
        btnWithdrawItem.Focus()
    End Sub

    Private Sub btnClearStudent_Click(sender As Object, e As EventArgs) Handles btnClearStudent.Click, ClearStudentToolStripMenuItem.Click
        'Disables the use of payment and withdraw controls/buttons. Resets orders and student information
        'Allow user to use withdraw and payment controls
        Dim hiddenElements As Control() = {grpInformation, btnWithdrawItem, btnPayAmount, lblItemToWithdraw, lblOrder, lblPaymentAmount, cboItemToWithdraw, cboOrders, lblPaymentMethod, grpMethods, radCash, radCheck, txtAmount}
        For Each element As Control In hiddenElements
            element.Enabled = False
        Next
        'Update items and orders
        ResetItemOrderSelection()
        'Reset form controls
        lblName.Text = ""
        grpInformation.Visible = False
        txtAmount.Text = "Payment Amount"
        txtStudentID.Text = ""
        'Set cursor for another student ID
        txtStudentID.Select()
        btnClearStudent.Enabled = False
    End Sub

    Private Sub btnWithdrawItem_Click(sender As Object, e As EventArgs) Handles btnWithdrawItem.Click
        'Handles Withdraw button click event. Validates entries and allows user to withdraw item
        If cboItemToWithdraw.SelectedIndex = -1 Or cboItemToWithdraw.Text = "" Then
            'User did not select an item to withdraw
            MsgBox("Please select an item to withdraw", , "Withdraw Error")
            Return
        End If
        'Confirm users intention to withdraw selected item
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to withdraw a '" & cboItemToWithdraw.SelectedItem.ToString & "'?", "Confirm Withdraw", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.No Then
            'User did not actually want to withdraw this item or they are just very indecisive
            Return
        End If
        WriteWithdraw()
        'Update the form to reflect that the student withdrew another item and incurred more debt
        UpdateStudentInformation()
        'Update and repopulate the item and order comboboxes
        ResetItemOrderSelection()
        UpdateOrderSelection(txtStudentID.Text)
        'Reset the focus to allow for quick movement to next student
        btnClearStudent.Select()
    End Sub

    Private Sub btnPayAmount_Click(sender As Object, e As EventArgs) Handles btnPayAmount.Click
        'Handles pay amount button click. Validates entries for payment and writes payment record to DB
        'Form entry validation
        If Not PaymentInformationValid() Then
            'One or more of the users field entries was invalid
            Return
        End If
        'Confirm the users intent to pay amount
        Dim confirmation As DialogResult = MessageBox.Show("Really pay off this debt?", "Confirmation", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.No Then
            'Quick digression: It's pretty difficult to fill in every field accurately and press the pay amount button accidently
            'but just in case it can be canceled. Message boxes are pretty though I guess I can understand just wanting to see .NET in action
            Return
        End If
        Dim amountPaid As Decimal = Convert.ToDecimal(txtAmount.Text)
        Dim correspondingWithdraw As PerformedTransaction = GetCorrespondingWithdraw()
        Dim debtOwed As Decimal = Convert.ToDecimal(correspondingWithdraw.GetTotalTransactionValue) * -1
        If debtOwed < Convert.ToDecimal(txtAmount.Text) Then
            Dim donationConfirmation As DialogResult = MessageBox.Show("More was payed than was due. Should the extra be added As a donation?", "Donate Confirmation", MessageBoxButtons.YesNo)
            If confirmation = DialogResult.Yes Then
                'The user has agreed to give a donation. Create and write the donation to the database
                Dim donation As New Donation
                donation.studentID = selectedStudent.studentID
                donation.orderNumber = correspondingWithdraw.orderNumber
                donation.transactionDate = DateTime.Now.ToShortDateString()
                donation.amount = Convert.ToDecimal(txtAmount.Text) - debtOwed
                'Write the donation to the database
                donation.WriteDonation()
                'Update amount paid to reflect the donation
                amountPaid = Convert.ToDecimal(txtAmount.Text) - donation.amount
            End If
        End If
        'Get payment method rom the radiobuttons on the form
        Dim paymentMethod As String = GetPaymentMethod()
        'Write the transaction record to the database
        WriteTransaction(amountPaid, correspondingWithdraw)
        'Reset the focus to be the clear student button to facilitate easier motion from student to student
        btnClearStudent.Select()
        'Update and repopulate item and orders comboboxes
        ResetItemOrderSelection()
        UpdateOrderSelection(txtStudentID.Text)
        UpdateStudentInformation()
        txtAmount.Text = "Payment Amount"
    End Sub

    Private Sub cboOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrders.SelectedIndexChanged, cboOrders.TextChanged
        If Not cboOrders.Text = " " And Not cboOrders.Text = "" And Not cboOrders.SelectedIndex = -1 Then
            'Order is selected
            'Enabled items to allow payment
            txtAmount.Enabled = True
            radCash.Enabled = True
            radCheck.Enabled = True
            'Query database to get the price of the selected item
            Dim selectedTransacitonQuerySql As String = "SELECT * FROM Transactions WHERE OrderNumber= " & cboOrders.SelectedItem.ToString.Substring(0, cboOrders.SelectedItem.ToString.IndexOf(":"))
            Dim selectedTransactionResult As DataTable = database.Query(selectedTransacitonQuerySql)
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(selectedTransactionResult.Rows(0))
            Dim paymentDue As Double = thisTransaction.GetTotalTransactionValue() * -1
            txtAmount.Text = paymentDue.ToString()
        Else
            'User has not selected an item or has entered custom text
            txtAmount.Enabled = False
            radCash.Enabled = False
            radCheck.Enabled = False
        End If
    End Sub

    Private Sub txtAmount_Enter(sender As Object, e As EventArgs) Handles txtAmount.Enter, txtAmount.Leave
        'Manipulate the text in the payment amount textbox to leave when the user goes to enter something and return if the user has not entered anything
        If txtAmount.Text = "Payment Amount" Then
            'User has clicked in the textbox to add an amount, set to blank
            txtAmount.Text = ""
        ElseIf txtAmount.Text = "" Then
            'User has left the textbox without entering, set to placeholder text
            txtAmount.Text = "Payment Amount"
        End If
    End Sub

    Private Sub UpdateStudentInformation()
        'Get student information from database
        lblName.Text = ""
        Try
            'Get new student from database and send to STUDENT class constructor as a datarow to parse into the STUDENT class properties
            selectedStudent = New Student()
            selectedStudent = selectedStudent.GetStudent(txtStudentID.Text)
            If selectedStudent.valid Then
                btnClearStudent.Enabled = True
            End If
        Catch ex As Exception
            'This student has no information in the database
            MsgBox("Invalid Student ID", , "Student Does Not Exist")
            Return
        End Try

        'Calculation of outstanding orders owed by selected student
        Dim outstandingOrders As Integer = selectedStudent.GetOutstandingOrders()
        'Calculation of remaining debt owed by selected student
        Dim remainingDebt As Decimal = selectedStudent.GetRemainingDebt()

        'Set student information to the form
        lblName.Text = selectedStudent.FirstName & " " & selectedStudent.LastName
        lblItemsOut.Text = outstandingOrders.ToString()
        lblDebt.Text = (remainingDebt * -1).ToString("C2")
    End Sub

    Private Sub UpdateItemSelections()
        cboItemToWithdraw.Items.Clear()
        'Query database for all existing items
        Dim getItemsQuery As String = "SELECT * FROM Items"
        Dim getItemsResult As DataTable = database.Query(getItemsQuery)
        For Each itemRecord As DataRow In getItemsResult.Rows
            'Populate the combobox with selectable items
            Dim item As New Item(itemRecord)
            cboItemToWithdraw.Items.Add(item.name)
        Next
        'Set the combobox to have nothing selected
        cboItemToWithdraw.SelectedIndex = 0
    End Sub

    Private Sub UpdateOrderSelection(studentID As String)
        Dim outstandingOrderData As DataTable = selectedStudent.GetOutstandingOrderData()
        For Each outstandingOrderRecord As DataRow In outstandingOrderData.Rows
            Dim outstandingOrder As PerformedTransaction = PerformedTransaction.GetTransactionType((outstandingOrderRecord))
            'Loop through each outstanding record and create a combobox item using data from the data row to reflect
            'order number, date withdrawn, and debt caused
            cboOrders.Items.Add(outstandingOrder.orderNumber & ": from " & outstandingOrder.TransactionDate & " with a debt of " & (outstandingOrder.TransactionValue * -1).ToString("C2"))
            cboOrders.SelectedIndex = 0
        Next
    End Sub

    Private Sub ResetItemOrderSelection()
        'Reset the form back to its 
        cboOrders.Items.Clear()
        'Console.WriteLine("Here is a line of dead code for you to enjoy")
        cboOrders.SelectedIndex = -1
        cboOrders.Text = ""
    End Sub

    Private Function PaymentInformationValid() As Boolean
        'Validate the selections of the user and display error messages
        If cboOrders.SelectedIndex = -1 Then
            'User did not select an order
            MsgBox("You must select an order to pay off", , "Payment Error")
            Return False
        ElseIf txtAmount.Text = "Payment Amount" Then
            'User did not specify a payment amount or cleared the automatically generated from the item
            MsgBox("You must enter a payment amount", , "Payment Error")
            Return False
        ElseIf Not IsNumeric(txtAmount.Text) Then
            'User has not entered a valid number
            MsgBox("You must enter a numeric payment amount", , "Payment Error")
            Return False
        End If
        'User has entered valid data
        Return True
    End Function

    Private Function GetPaymentMethod() As String
        If radCash.Checked Then
            'User has selected Cash
            Return "Cash"
        Else
            'User has selected Check
            Return "Check"
        End If
    End Function
    Private Sub WriteWithdraw()
        'Query the database to get the Item information needed to create the item object
        Dim selectedItemQuery As String = "SELECT * FROM Items WHERE Name = '" & cboItemToWithdraw.SelectedItem.ToString & "'"
        Dim selectedItemResult As DataTable = database.Query(selectedItemQuery)
        'Create an item object to match what is being withdrawn
        Dim withdrawnItem As New Item(selectedItemResult.Rows(0))
        If withdrawnItem.isImmediateReturn Then
            Dim purchase As New Purchase(withdrawnItem, selectedStudent, currentAdmin)
        End If
        'Write the withdraw record to database
        Dim withdraw As New Withdraw(withdrawnItem, selectedStudent, currentAdmin)
        withdraw.WriteTransaction()
    End Sub
    Private Sub WriteTransaction(amountPaid As Decimal, correspondingWithdraw As PerformedTransaction)
        'Get the item that was withdrawn which will be negated
        Dim getReturnedItemSql As String = "SELECT * FROM Items WHERE UPC='" & correspondingWithdraw.item.upc & "'"
        Dim getReturnedItemResult As DataTable = database.Query(getReturnedItemSql)
        Dim returnedItem As Item
        Try
            returnedItem = New Item(getReturnedItemResult.Rows(0))
        Catch ex As Exception
            Dim getReturnedItemSqlAgain As String = "SELECT * FROM Items WHERE UPC='0" & correspondingWithdraw.item.upc & "'"
            Dim getReturnedItemResultAgain As DataTable = database.Query(getReturnedItemSqlAgain)
            returnedItem = New Item(getReturnedItemResultAgain.Rows(0))
        End Try
        'Get the student that withdrew the items which will be negated
        Dim getReturningStudentSql As String = "SELECT * FROM Students WHERE StudentID = '" & correspondingWithdraw.student.studentID & "'"
        Dim getReturningStudentResult As DataTable = database.Query(getReturningStudentSql)
        Dim returningStudent As New Student(getReturningStudentResult.Rows(0))
        'Write the transaction to the database
        Dim thisTransaction As New Payment(amountPaid, returnedItem, returningStudent, currentAdmin, orderNumber:=correspondingWithdraw.orderNumber)
        thisTransaction.WriteTransaction()

        'Update datatables that the receipt report will pull from
        'Confirm the users intent to pay amount
        Dim confirmation As DialogResult = MessageBox.Show("Would you like a receipt?", "Create Receipt", MessageBoxButtons.YesNo)
        If confirmation = DialogResult.Yes Then
            Dim getTransactionDataSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & correspondingWithdraw.orderNumber & " AND TransactionValue > 0"
            Dim getTransactionDataResult As DataTable = database.Query(getTransactionDataSql)
            Dim receipt As New Receipt(getReturningStudentResult, getReturnedItemResult, getTransactionDataResult)
        End If
        btnClearStudent.Enabled = True
    End Sub

    Private Function GetCorrespondingWithdraw() As PerformedTransaction
        Dim getCorrespondingWithdrawSql As String = "SELECT * FROM Transactions WHERE OrderNumber = " & cboOrders.SelectedItem.ToString.Substring(0, cboOrders.SelectedItem.ToString.IndexOf(":"))
        Dim getCorrespondingWithdrawResult As DataTable = database.Query(getCorrespondingWithdrawSql)
        Dim correspondingWithdraw As PerformedTransaction = PerformedTransaction.GetTransactionType((getCorrespondingWithdrawResult.Rows(0)))
        Return correspondingWithdraw
    End Function

    Private Sub StatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatisticsToolStripMenuItem.Click
        frmStats.Show()
    End Sub

    Private Sub StudentStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentStatisticsToolStripMenuItem.Click
        frmStudentManagement.Show()
    End Sub

    Private Sub DailyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyReportToolStripMenuItem.Click
        Dim today As New DateRange(DateTime.Now, DateTime.Now)
        today.dateReport()
    End Sub

    Private Sub BackupDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDataToolStripMenuItem.Click
        frmBackup.Show()
    End Sub
End Class