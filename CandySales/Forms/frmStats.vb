Option Strict On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Xml
Imports System.IO
Public Class frmStats
    Dim database As New DatabaseInteraction
    Dim listItems As New List(Of String())
    Dim queryTerms As String
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'Prepare the GUI to display the required statistics
        prgPopulateList.Visible = True
        lstStudentsMatchingCriteria.Items.Clear()
        lstStudentsMatchingCriteria.Visible = True
        If chkID.Checked And txtIDNumber.Text = "" Then
            'ID filter was selected but no ID was put into the field
            MsgBox("ID Filter is selected but no ID was entered", , "Input Error")
            'Message to 
            Return
        End If
        'Get transaction query prototype base
        Dim transactionsQuery As String = "SELECT * FROM Transactions"
        Dim transactionResult As DataTable = database.Query(transactionsQuery)
        'Get student query prototype base
        Dim studentQuery As String = "SELECT * FROM Students "
        'Get condition filters referring to the students information
        Dim studentConditionsList As List(Of String) = GetStudentConditions()
        'Create string of query conditions
        Dim studentConditions As String = ""
        If studentConditionsList.Count < 1 And studentConditionsList.Count <> 0 Then
            'No student condition is selected display ALL students
            studentQuery &= "WHERE "
            studentConditions = studentConditionsList(0)
        End If
        If studentConditionsList.Count <> 0 Then
            'More than one student condition is selected append all the SQL to the query string
            studentQuery &= "WHERE "
            Dim conditionCounter As Integer = 0
            For Each condition As String In studentConditionsList
                'Loop through all selected conditions and append to SQL query string
                If conditionCounter <> studentConditionsList.Count - 1 Then
                    'More than one condition is selected, AND keyword must be added between each
                    conditionCounter += 1
                    studentQuery &= condition & " AND "
                Else
                    'Only one condition is selected. AND keyword is not necessary. Append directly to SQL base prototype
                    studentQuery &= condition
                End If
            Next
        End If
        'FIRST LEVEL FILTER.    Filtered by student conditions
        Dim studentInformation As DataTable = database.Query(studentQuery)
        'SECOND LEVEL FILTER.   Filtered by withdraw conditions
        Dim withdrawInformation As DataTable = GetWithdrawSpecificResults(studentInformation)
        'THIRD LEVEL FILTER.    Filtered by transaction conditions
        Dim transactionInformation As DataTable = GetTransactionSpecificResults(withdrawInformation)
        If cboSort.SelectedIndex <> -1 Then
            'User has selected a sort type. Sort table and return
            transactionInformation = SortSearchResults(transactionInformation)
        End If
        Dim progressCounter As Integer
        For Each matchingResult As DataRow In transactionInformation.Rows
            'Loop through each matching student and add to the listview contro
            'Update the progress bar to reflect percentage through the records
            prgPopulateList.Value = Convert.ToInt32(Math.Ceiling((progressCounter / transactionInformation.Rows.Count) * 100))
            'Create a new student object to hold the student the iteration of the loop is testing
            Dim currentStudent As New Student(matchingResult)
            'Create array to be stored into the listview control
            Dim studentInfo() As String = {currentStudent.FirstName & " " & currentStudent.LastName, currentStudent.Grade.ToString(), currentStudent.GetOutstandingOrders().ToString(), currentStudent.GetRemainingDebt().ToString("C2"), currentStudent.Shop}
            listItems.Add(studentInfo)
            Dim studentLVI As New ListViewItem(studentInfo)
            studentLVI.Name = currentStudent.studentID
            'Add student to listview
            lstStudentsMatchingCriteria.Items.Add(studentLVI)
            'Increment progress counter
            progressCounter += 1
        Next
        'Processing is complete. Hide progress bar
        prgPopulateList.Visible = False
        'Report the number of records used
        lblRecordCount.Text = lstStudentsMatchingCriteria.Items.Count & " records"
        lblRecordCount.Visible = True
    End Sub

    Private Function GetTransactionSpecificResults(withdraws As DataTable) As DataTable
        'Query database for table schema
        Dim updateResults As DataTable = database.Query("SELECT * FROM Students WHERE StudentID = -1")
        If radStillOwes.Checked Then
            'User has selected to see students that still owe money
            For Each record As DataRow In withdraws.Rows
                'Iterate through each student that matches the withdraw and student criteria
                'Get transactions from the students
                Dim outstandingOrdersQuery As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & record.Item(0).ToString() & "'"
                'Populate based on query results
                Dim outstandingOrdersResult As DataTable = database.Query(outstandingOrdersQuery)
                For Each transaction As DataRow In outstandingOrdersResult.Rows
                    'Create transaction from record / factory them
                    Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transaction)
                    If thisTransaction.IsTransactionOutstanding() Then
                        'Add the students to the datatable to be returned to as the final filter level
                        updateResults.ImportRow(record)
                        Exit For
                    End If
                Next
            Next
            'Results can be sent back to the UI now! 
            Return updateResults
        ElseIf radWithdrawPaidOff.Checked Then
            'User has selected to see students that have paid off their orders
            For Each record As DataRow In withdraws.Rows
                'Iterate through each student that matches the withdraw and student criteria
                Dim outstandingOrdersQuery As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & record.Item(0).ToString() & "'"
                Dim outstandingOrdersResult As DataTable = database.Query(outstandingOrdersQuery)
                Dim allPaid As Boolean = True
                For Each transaction As DataRow In outstandingOrdersResult.Rows
                    Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(transaction)
                    If thisTransaction.IsTransactionOutstanding() Then
                        'Add this student to the datatable. It passes this level of filtering
                        allPaid = False
                    End If
                Next
                If allPaid Then
                    updateResults.ImportRow(record)
                End If
            Next
            Return updateResults
        End If
        'No transaction specific conditions were selected, return what was passed
        Return withdraws
    End Function

    Private Function GetWithdrawSpecificResults(students As DataTable) As DataTable
        'Query DB for table schema
        Dim finalResults As DataTable = database.Query("SELECT * FROM Students WHERE StudentID = -1")
        If radHasWithdrawn.Checked Then
            'User has selected to see students that have withdrawn
            For Each record As DataRow In students.Rows
                'Get all transactions made by the student
                Dim transactionQuery As String = "SELECT StudentIDNumber FROM Transactions WHERE StudentIDNumber = " & record.Item(0).ToString()
                If database.Query(transactionQuery).Rows.Count > 0 Then
                    'Student has withdrawn. Add to returning table
                    finalResults.ImportRow(record)
                End If
            Next
        ElseIf radNeverWithdrewAnItem.Checked Then
            'User has selected to see students that have NOT withdrawn
            For Each record As DataRow In students.Rows
                'Get all transactions made by student
                Dim transactionQuery As String = "SELECT StudentIDNumber FROM Transactions WHERE StudentIDNumber = " & record.Item(0).ToString()
                If database.Query(transactionQuery).Rows.Count <= 0 Then
                    'Student has never withdrawn, BC their record count is 0. Add to returning table
                    finalResults.ImportRow(record)
                End If
            Next
        End If
        If Not radHasWithdrawn.Checked And Not radNeverWithdrewAnItem.Checked Then
            'No withdraw conditions have been specified. Set final results to be what was passed
            finalResults = students
        End If
        'Return filter results
        Return finalResults
    End Function

    Private Function GetStudentConditions() As List(Of String)
        'Get conditions selected from the form
        Dim conditions As New List(Of String)
        If chkFromDistrict.Checked Then
            'Add district filter
            conditions.Add("District = '" & cboDistrict.SelectedItem.ToString() & "'")
        End If
        If chkFromShop.Checked Then
            'Add shop filter
            conditions.Add("Shop = '" & cboShops.SelectedItem.ToString() & "'")
        End If
        If chkID.Checked Then
            'Add ID filter
            conditions.Add("StudentID = " & txtIDNumber.Text)
        End If
        If chkByName.Checked Then
            'Add both first name and last name filtering
            If txtName.Text.IndexOf(" ") = -1 Then
                conditions.Add("LastName = '" & txtName.Text.Substring(0, txtName.Text.Length) & "'")
            Else
                conditions.Add("FirstName = '" & txtName.Text.Substring(0, txtName.Text.IndexOf(" ")).ToString & "'")
                conditions.Add("LastName = '" & txtName.Text.Substring(txtName.Text.IndexOf(" "), txtName.Text.Length - txtName.Text.IndexOf(" ")).Trim & "'")
            End If
        End If
        If chkAMSession.Checked Then
            'Add AM Session filter
            conditions.Add("Session = 'AM'")
        End If
        If chkPMSession.Checked Then
            'Add PM Session filter
            conditions.Add("Session = 'PM'")
        End If
        'Return the condition list
        Return conditions
    End Function

    Private Function SortSearchResults(results As DataTable) As DataTable
        'Create new dataview to query in memory datatable
        Dim sortedDataView As New DataView(results)
        Select Case cboSort.SelectedIndex
            Case 0
                'Alphabetical sorting by student name
                sortedDataView.Sort = "LastName ASC"
                Return sortedDataView.ToTable()
            Case 1
                sortedDataView.Sort = "LastName Desc"
                Return sortedDataView.ToTable()
            Case 2
                'Alphabetical sorting by shop
                sortedDataView.Sort = "Shop, LastName Desc"
                Return sortedDataView.ToTable()
            Case 3
                'Alphabetical sorting by grade
                sortedDataView.Sort = "Grade, LastName Desc"
                Return sortedDataView.ToTable()
        End Select
        'Issue with the sorting query. Shouldn't descend to this point. This line is really just here to quiet Visual Studio's warnings
        Return Nothing
    End Function

    Private Sub chkFromDistrict_CheckedChanged(sender As Object, e As EventArgs) Handles chkFromDistrict.CheckedChanged
        If chkFromDistrict.Checked Then
            'Enable and give a default selection to the district combobox
            cboDistrict.Enabled = True
            cboDistrict.SelectedIndex = 0
        Else
            'Disable and remove the selection from the district combobox
            cboDistrict.Enabled = False
            cboDistrict.SelectedIndex = -1
        End If
    End Sub

    Private Sub chkFromShop_CheckedChanged(sender As Object, e As EventArgs) Handles chkFromShop.CheckedChanged
        If chkFromShop.Checked Then
            'Enable and give a default selection to the shop combobox
            cboShops.Enabled = True
            cboShops.SelectedIndex = 0
        Else
            'Disable and remove the selection from the shop combobox
            cboShops.Enabled = False
            cboShops.SelectedIndex = -1
        End If
    End Sub

    Private Sub chkID_CheckedChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged
        If chkID.Checked Then
            'ID filter enabled, enabled ID textbox
            txtIDNumber.Enabled = True
        Else
            'ID filter disabled, disable ID textbox
            txtIDNumber.Enabled = False
        End If
    End Sub

    Private Sub radHasWithdrawn_CheckedChanged(sender As Object, e As EventArgs) Handles radHasWithdrawn.CheckedChanged
        If radHasWithdrawn.Checked Then
            'Enabled withdraw criteria
            grpWithdrawCriteria.Enabled = True
        Else
            'Disable withdraw criteria
            grpWithdrawCriteria.Enabled = False
            radStillOwes.Checked = False
            radWithdrawPaidOff.Checked = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Return statistics tab to its default state and put the user back at the accept button
        chkFromDistrict.Checked = False
        chkFromShop.Checked = False
        chkID.Checked = False
        chkAMSession.Checked = False
        chkPMSession.Checked = False
        radHasWithdrawn.Checked = False
        radNeverWithdrewAnItem.Checked = False
        radStillOwes.Checked = False
        radWithdrawPaidOff.Checked = False
        cboDistrict.SelectedIndex = -1
        cboShops.SelectedIndex = -1
        txtIDNumber.Text = ""
        prgPopulateList.Value = 0
        prgPopulateList.Visible = False
        lstStudentsMatchingCriteria.Items.Clear()
    End Sub

    Private Sub btnCreateReportFromSearch_Click(sender As Object, e As EventArgs) Handles btnCreateReportFromSearch.Click
        'Generate a quick report from the data in the search result table
        'Create an instance of the report
        If lstStudentsMatchingCriteria.Visible Then
            studentSearchReport()
            prgPopulateList.Visible = False
        Else
            TopSellersReport()
        End If
    End Sub

    Private Sub studentSearchReport()
        prgPopulateList.Visible = True
        Dim quickReport As New QuickReport(GetQueryTerms(), listItems)
    End Sub

    Private Sub TopSellersReport()
        prgPopulateList.Visible = True
        Dim topSellerReport As New Report.TopSeller
    End Sub

    Public Function GetQueryTerms() As String
        'Get the query terms and conditions from the form
        Dim queryTerms As String = ""
        If chkFromDistrict.Checked Then
            'Add selected district to query
            queryTerms &= "District: '" & cboDistrict.SelectedItem.ToString & "'   "
        End If
        If chkFromShop.Checked Then
            'Add selected shop to query
            queryTerms &= "Shop: '" & cboShops.SelectedItem.ToString & "'   "
        End If
        If chkID.Checked Then
            'Add student ID to query
            queryTerms &= "ID: '" & txtIDNumber.Text.ToString & "'   "
        End If
        If chkByName.Checked Then
            'Add student name to query
            queryTerms &= "Name: '" & txtName.Text.ToString
        End If
        If chkAMSession.Checked Then
            'Add AM session to query
            queryTerms &= "Session: 'AM'   "
        End If
        If chkPMSession.Checked Then
            'Add PM session to query
            queryTerms &= "Session: 'PM'   "
        End If
        If radHasWithdrawn.Checked Then
            'Add withdrawn items to query
            queryTerms &= "Has Withdrawn An Item   "
        End If
        If radNeverWithdrewAnItem.Checked Then
            'Add never wthdrawn item to query
            queryTerms &= "Never Withdrawn An Item   "
        End If
        If radStillOwes.Checked Then
            'Add still owing money to query
            queryTerms &= "Still Owes Money   "
        End If
        If radWithdrawPaidOff.Checked Then
            'Add being paid off to query
            queryTerms &= "Paid Off   "
        End If
        If queryTerms = "" Then
            'No query terms. Get all students
            queryTerms &= "All Students"
        End If
        Return queryTerms
    End Function

    Private Sub tsmiTickets_Click(sender As Object, e As EventArgs) Handles tsmiTickets.Click
        'Create instance of the master student report class
        Dim ticketReport As New Tickets
    End Sub

    Public Property selectedStudentID As String
    Public Property shopName As String
    Private Sub lstMatchingItem_DoubleClicked(sender As Object, e As EventArgs) Handles lstStudentsMatchingCriteria.DoubleClick
        If lstStudentsMatchingCriteria.SelectedItems Is Nothing Then
            Return
        End If
        selectedStudentID = lstStudentsMatchingCriteria.SelectedItems(0).Name
        frmStudentView.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ShopInformationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        shopName = CType(sender, ToolStripMenuItem).Text
        frmShopView.Show()
    End Sub

    Private Sub StudentStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentStatisticsToolStripMenuItem.Click
        frmStudentManagement.Show()
    End Sub

    Private Sub BackupDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDataToolStripMenuItem.Click
        frmBackup.Show()
    End Sub

    Private Sub DailyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyReportToolStripMenuItem.Click
        Dim today As New DateRange(DateTime.Now, DateTime.Now)
        today.dateReport()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        frmOrder.Show()
        Me.Close()
    End Sub

    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get shop criteria choices
        Dim allShops As New Shop
        cboShops.DataSource = allShops.GetAll()
        'Get all district criteria choices
        Dim allDistricts As New Districts
        cboDistrict.DataSource = allDistricts.GetAll()
        Dim shopStatsMenuItem As ToolStripMenuItem = ShopStatisticsToolStripMenuItem
        For Each shop As String In allShops.GetAll()
            Dim thisShop As New ToolStripMenuItem(shop)
            AddHandler thisShop.Click, AddressOf ShopInformationToolStripMenuItem_Click
            shopStatsMenuItem.DropDownItems.Add(thisShop)
        Next
    End Sub

    Private Sub chkByName_CheckedChanged(sender As Object, e As EventArgs) Handles chkByName.CheckedChanged
        If chkByName.Checked Then
            txtName.Enabled = True
        Else
            txtName.Enabled = False
        End If
    End Sub

    Private Sub ShopParticipationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShopParticipationToolStripMenuItem.Click
        frmShopParticipation.Show()
    End Sub

    Private Sub SpecificDatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecificDateToolStripMenuItem.Click
        'Show date reports form
        frmDateReports.Show()
    End Sub

    Private Sub ByMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByMonthToolStripMenuItem.Click
        frmMonthlySales.Show()
    End Sub

    Private Sub AMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMToolStripMenuItem.Click
        Dim topSellersReports As New StudentSalesReports
        Dim topSellerReport As New Report.TopSeller
        topSellerReport.session = "AM"
        topSellerReport.CreateReport(New DataTable)
    End Sub

    Private Sub PMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PMToolStripMenuItem.Click
        Dim topSellersReports As New StudentSalesReports
        Dim topSellerReport As New Report.TopSeller
        topSellerReport.session = "PM"
        topSellerReport.CreateReport(New DataTable)
    End Sub

    Private Sub AdministratorManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministratorManagementToolStripMenuItem.Click
        frmAdministratorManagement.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSettings.Show()
    End Sub
    Private Sub ResetAllDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllDataToolStripMenuItem.Click
        Dim deleteEverythingDialogResult As DialogResult = MessageBox.Show("Are you sure you would like to reset all data? This will return the application to its first use settings and will require all data to be reentered!", "Confirm Application Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If deleteEverythingDialogResult = DialogResult.Yes Then
            Dim localDatabase As New LocalDatabase
            localDatabase.Reset()
            Application.Exit()
        End If
    End Sub

    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.Click
        frmCreateProduct.Show()
    End Sub

    Private Sub SellingStudentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellingStudentReportToolStripMenuItem.Click
        Dim studentSellerReport As XDocument = <?xml version="1.0" encoding="utf-8"?>
                                               <?xml-stylesheet type="text/xsl" href="studentsellerreport.xsl"?>
                                               <report>
                                               </report>
        Dim getAllStudentsSellersSql As String = "SELECT DISTINCT StudentIDNumber FROM Transactions"
        Dim allStudentSellers As DataTable = database.Query(getAllStudentsSellersSql)
        For Each studentIDRecord As DataRow In allStudentSellers.Rows
            Dim thisStudent As New Student(Convert.ToInt32(studentIDRecord.Item(0)))
            If thisStudent.GetSalesCount >= 2 Then
                studentSellerReport.Element("report").Add(New XElement("student", New XElement("name", thisStudent.FirstName & " " & thisStudent.LastName), New XElement("shop", thisStudent.Shop)))
            End If
        Next
        Dim localReportStorage As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\CandySales\studentsellerreport.xml"
        If File.Exists(localReportStorage) Then
            File.Delete(localReportStorage)
        End If
        studentSellerReport.Save(localReportStorage)
        Dim reportViewForm As New frmReportView(localReportStorage)
        reportViewForm.Show()
    End Sub
End Class