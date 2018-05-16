Imports System.Security.Cryptography
Imports System.IO
Imports System.Text.Encoding
Public NotInheritable Class EncryptionInteraction
    Public Shared masterKey As String = "joelseidel"
    Private TripleDes As New TripleDESCryptoServiceProvider
    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    Private Function TruncateHash(key As String, length As Integer) As Byte()
        Dim SHA1ServiceProvider As New SHA1CryptoServiceProvider
        'Hash the encrytion key using SHA1 service provider
        Dim keyBytes() As Byte = Unicode.GetBytes(key)
        Dim hash() As Byte = SHA1ServiceProvider.ComputeHash(keyBytes)
        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Public Function EncryptData(plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte = Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return System.Convert.ToBase64String(ms.ToArray())
    End Function

    Public Function DecryptData(encryptedtext As String) As String
        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = System.Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return Unicode.GetString(ms.ToArray)
    End Function
End Class
