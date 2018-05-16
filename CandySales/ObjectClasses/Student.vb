Option Strict On
Public Class Student
    Public studentID, FirstName, LastName, Shop, District, Session As String
    Public Grade, OutstandingOrders As Integer
    Public RemainingDebt As Decimal
    Private database As New DatabaseInteraction()
    Sub New()
    End Sub
    Public valid As Boolean
    Sub New(ByVal studentData As DataRow)
        'Loaded constructor, passing student information from a query datatable
        ParseDataRow(studentData)
    End Sub
    Sub New(studentID As Integer)
        Me.studentID = studentID.ToString()
        getStudent(studentID)
    End Sub
    Private Sub ParseDataRow(ByVal dataRow As DataRow)
        'Assign datarow items to corresponding properties
        studentID = dataRow.Item(0).ToString()
        FirstName = dataRow.Item(1).ToString()
        LastName = dataRow.Item(2).ToString()
        Shop = dataRow.Item(3).ToString()
        District = dataRow.Item(4).ToString()
        Session = dataRow.Item(5).ToString()
        Grade = Convert.ToInt32(dataRow.Item(6))
    End Sub
    Public Sub getStudent(studentID As Integer)
        Dim getThisStudentSql As String = "SELECT * FROM Students WHERE StudentID = '" & studentID & "'"
        Dim thisStudentRecord As DataTable = database.Query(getThisStudentSql)
        ParseDataRow(thisStudentRecord.Rows(0))
    End Sub
    Public Function ParseToDataRow() As DataRow
        'Query to get table schema
        Dim getStudentTableSchemaSql As String = "SELECT * FROM Students WHERE StudentID = -1"
        Dim studentsTable As DataTable = database.Query(getStudentTableSchemaSql)
        Dim newStudentRecord As DataRow = studentsTable.NewRow()
        'Construct new row item by item
        newStudentRecord.Item(0) = studentID
        newStudentRecord.Item(1) = FirstName
        newStudentRecord.Item(2) = LastName
        newStudentRecord.Item(3) = Shop
        newStudentRecord.Item(4) = District
        newStudentRecord.Item(5) = Session
        newStudentRecord.Item(6) = Grade
        Return newStudentRecord
    End Function
    Public Function Exists() As Boolean
        'Query the database to find if this student is already in the database by using the studentID identifier
        Dim getThisStudentSql As String = "SELECT * FROM Students WHERE StudentID = '" & studentID & "'"
        Dim thisStudentResults As DataTable = database.Query(getThisStudentSql)
        If thisStudentResults.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CreateStudent()
        Dim createStudentSql As String = "INSERT INTO Students(StudentID, FirstName, LastName, Shop, District, Session, Grade) VALUES ('" & studentID & "', '" & FirstName & "', '" & LastName & "', '" & Shop & "', '" & District & "', '" & Session & "', " & Grade & ")"
        database.NonQuery(createStudentSql)
    End Sub

    Public Function GetStudent(studentID As String) As Student
        'Retrieve a student's information datarow from database
        Dim studentSelectionQuery As String = "SELECT * FROM Students WHERE StudentID = '" & studentID & "'"
        'Query database for corresponding datarow
        Dim studentResult As DataTable = database.Query(studentSelectionQuery)
        If studentResult.Rows.Count = 0 Then
            valid = False
            Return Nothing
        Else
            'Return the corresponding student information datarow
            valid = True
            Dim returnableStudent As New Student(studentResult(0))
            returnableStudent.valid = True
            Return returnableStudent
        End If
    End Function

    Public Function GetOutstandingOrders() As Integer
        'Get all orders pertaining to the selected student by student ID identifier
        Dim outstandingOrdersQuery As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & studentID & "'"
        'Query the database for the corresponding order records
        Dim outstandingOrdersResult As DataTable = database.Query(outstandingOrdersQuery)

        Dim parsedRecords As New List(Of Integer)
        Dim outstandingOrderCount As Integer
        For Each outstandingOrderRecord As DataRow In outstandingOrdersResult.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(outstandingOrderRecord)
            Dim orderNumber As Integer = thisTransaction.GetOrderNumber()
            If Not parsedRecords.Contains(orderNumber) Then
                If thisTransaction.IsTransactionOutstanding() Then
                    outstandingOrderCount += 1
                End If
                parsedRecords.Add(orderNumber)
            End If
        Next
        Return outstandingOrderCount
    End Function

    Public Function GetRemainingDebt() As Decimal
        'Get all orders pertaining to the student by the student ID identifier
        Dim remainingDebtQuery As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & studentID & "'"
        Dim remainingDebtResult As DataTable = database.Query(remainingDebtQuery)
        Dim currentDebt As Decimal = 0
        For Each orderRecord As DataRow In remainingDebtResult.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(orderRecord)
            'Loop through each record in the datatabe and add to the currentDebt variable.
            'The values if positive signify a credit to the account and if negative to signify a debit to the account
            currentDebt += Convert.ToDecimal(thisTransaction.GetValue())
        Next
        Return currentDebt
    End Function

    Public Function GetSalesCount() As Integer
        'Get the amount of sales this student has made
        Dim getAllSalesSql As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & studentID & "'"
        'Get amount of records less the outstanding orders which cannot be counted as sales. Then divide out to get the withdrawn and returned transactions
        Dim totalTransCount As Integer = database.Query(getAllSalesSql).Rows.Count
        Dim salesCount As Integer = Convert.ToInt32((totalTransCount - GetOutstandingOrders()) / 2I)
        Return salesCount
    End Function

    Public Function GetOutstandingOrderData() As DataTable
        'Get all orders pertaining to the selected student by student ID identifier
        Dim outstandingOrdersQuery As String = "SELECT * FROM Transactions WHERE StudentIDNumber = '" & studentID & "'"
        'Query the database for the corresponding order records
        Dim outstandingOrdersResult As DataTable = database.Query(outstandingOrdersQuery)
        Dim outstandingOrdersTable As DataTable = database.Query("SELECT * FROM Transactions WHERE StudentIDNumber = -1")
        Dim parsedRecords As New List(Of Integer)
        For Each orderRecord As DataRow In outstandingOrdersResult.Rows
            Dim thisTransaction As PerformedTransaction = PerformedTransaction.GetTransactionType(orderRecord)
            Dim orderNumber As Integer = thisTransaction.GetOrderNumber()
            If Not parsedRecords.Contains(orderNumber) Then
                If thisTransaction.IsTransactionOutstanding() Then
                    'Reference the item in the record transaction item array that holds the transaction value
                    orderRecord.Item(5) = thisTransaction.GetTotalTransactionValue()
                    outstandingOrdersTable.ImportRow(orderRecord)
                End If
                parsedRecords.Add(orderNumber)
            End If
        Next
        Return outstandingOrdersTable
    End Function
End Class