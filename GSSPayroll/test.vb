Imports System.IO

Public Class test

    Sub loadFile()
        Dim objReader As New StreamReader("./dtr.txt")
        Dim s As String = ""
        Dim Data As String()
        Do While objReader.Peek <> -1
            s += objReader.ReadLine & " "
        Loop

        If s.Length <> 0 Then
            Data = s.Split(" ")
            TextBox1.AppendText(Decrypt(Data(0), hashKey) & vbNewLine)
            TextBox1.AppendText(Decrypt(Data(1), hashKey) & vbNewLine)
            TextBox1.AppendText(Decrypt(Data(2), hashKey) & vbNewLine)
            TextBox1.AppendText(Decrypt(Data(3), hashKey) & vbNewLine)
        End If
        objReader.Close()
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFile()
    End Sub
End Class