Option Strict On
Imports System.IO
Public Class TableInteraction
    Private database As New DatabaseInteraction
    Public table As DataTable
    Sub New(tableObject As DataTable)
        table = tableObject
    End Sub
    Public Function getTableXml() As String
        'Create the stream that the XML will be written into
        Dim xmlStream As TextWriter = New StringWriter
        'Parse the table into XML using previously created stream
        table.WriteXml(xmlStream, XmlWriteMode.WriteSchema)
        'Parse the string 
        Dim thisTableXml As String = xmlStream.ToString()
        Return thisTableXml
    End Function
End Class