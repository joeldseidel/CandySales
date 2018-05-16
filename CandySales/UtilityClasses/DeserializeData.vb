Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class DeserializeData
    Public Function LoadData(fileToLoadPath As String) As Object
        Dim loadableObject As UserPreferences = Nothing
        Dim fsDeserialize As New FileStream(fileToLoadPath, FileMode.Open)
        Dim bfDeserialize As New BinaryFormatter
        loadableObject = Deserialize(loadableObject, fsDeserialize, bfDeserialize)
        Return loadableObject
    End Function
    Private Function Deserialize(ByVal userPrefs As UserPreferences, fileStream As FileStream, binaryFormatter As BinaryFormatter) As Object
        Try
            userPrefs = binaryFormatter.Deserialize(fileStream)
        Catch ex As Exception
            userPrefs = New UserPreferences()
        Finally
            fileStream.Close()
        End Try
        Return userPrefs
    End Function
End Class