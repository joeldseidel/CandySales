Option Strict On
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class SerializeData
    Public Overloads Function SaveData(ByVal folderPath As String, ByVal storageType As String, ByRef dataTable As DataTable) As Boolean
        Dim fsSerialize As New FileStream(folderPath & "/" & storageType & ".candy", FileMode.OpenOrCreate)
        Dim bfSerialize As New BinaryFormatter
        Dim serializationSuccessful As Boolean = Serialize(fsSerialize, bfSerialize, dataTable)
        Return serializationSuccessful
    End Function
    Public Overloads Function SaveData(filePath As String, ByVal serializableObject As Object) As Boolean
        Dim fsSerialize As New FileStream(filePath & ".candy", FileMode.OpenOrCreate)
        Dim bfSerialize As New BinaryFormatter
        Dim serializationSuccessful As Boolean = Serialize(fsSerialize, bfSerialize, serializableObject)
        Return serializationSuccessful
    End Function
    Private Function Serialize(fileStream As FileStream, binaryFormatter As BinaryFormatter, dataTable As Object) As Boolean
        Try
            binaryFormatter.Serialize(fileStream, dataTable)
        Catch ex As Exception
            fileStream.Close()
            Return False
        End Try
        fileStream.Close()
        Return True
    End Function
End Class