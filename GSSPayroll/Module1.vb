Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Module Module1

#Region "Public"
    Public conString As String
    Public newEmployeeFlag As Boolean
    Public query As String

    Public empID As String
#End Region

#Region "Crypto"
    Public hashKey As String = "c411ec3fbe63b02c622f135613672f82"

    Dim DES As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider

    Function MD5Hash(value As String)
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Public Function Encrypt(input As String, key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(input)

        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
    Public Function Decrypt(input As String, key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim buffer As Byte() = Convert.FromBase64String(input)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
#End Region

    Public Function insertConfig(server As String, username As String, pass As String, db As String) As Boolean
        Dim success As Boolean
        Dim path As String = "./dtr.txt"
        Dim data As String() = {Encrypt(server, hashKey), Encrypt(username, hashKey), Encrypt(pass, hashKey), Encrypt(db, hashKey)}
        File.WriteAllLines(path, data)
        success = True
        Return success
    End Function

    Public Function checkConnection() As Boolean
        Dim status As Boolean = False
        Dim objReader As New StreamReader("./dtr.txt")
        Dim s As String = ""
        Dim Data As String()
        Do While objReader.Peek <> -1
            s += objReader.ReadLine & " "
        Loop

        If String.IsNullOrWhiteSpace(s) Then
            Return False
            Exit Function
        Else
            If s.Length <> 0 Then
                Data = s.Split(" ")
                My.Settings.Servername = Decrypt(Data(0), hashKey)
                My.Settings.ServerUser = Decrypt(Data(1), hashKey)
                My.Settings.ServerPass = Decrypt(Data(2), hashKey)
                My.Settings.ServerDB = Decrypt(Data(3), hashKey)
            End If
            conString = "Server='" & My.Settings.Servername & "';uid='" & My.Settings.ServerUser & "';Password='" & My.Settings.ServerPass & "'; Database='" & My.Settings.ServerDB & "';Convert Zero Datetime=true;"
            status = True
        End If
        objReader.Close()
        Return status

    End Function
    Function convertHeight(ft As Integer, inch As Integer) As Double
        Dim newHeight As Double
        newHeight = ((CInt(ft) * 12) + CInt(inch)) * 2.54
        Return newHeight
    End Function
    Function convertWeight(lbs As Double) As Double
        Dim newWeight As Double
        newWeight = CDbl(lbs) * 0.45
        Return newWeight
    End Function
    Public Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Function employeeIDGenerator() As String
        Dim id As String = ""
        Using sqlcon As New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT EmployeeID FROM tblemployee ORDER BY EmployeeID DESC LIMIT 1"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                Using sqldr = sqlcmd.ExecuteReader
                    If sqldr.HasRows Then
                        While sqldr.Read
                            id = CInt(sqldr(0)) + 1
                        End While
                    Else
                        id = "100001005"
                    End If
                End Using
            End Using
        End Using
        Return id
    End Function

End Module
