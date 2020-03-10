Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmLogin

    Dim username, password As String

    Sub validateInput()
        username = Regex.Replace(txtUsername.Text, "[^A-Za-z0-9\-/]", "")
        password = txtPassword.Text
    End Sub

    Function isLogin(ByRef user As String, ByRef pass As String) As String
        Dim s As String
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT Username,Password,UserType, AccountStatus FROM tbluser " +
                                  "WHERE Username = @User AND Password = @Pass AND LoginStatus = @LoginStatus"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@User", username)
                sqlcmd.Parameters.AddWithValue("@Pass", Encrypt(password, hashKey))
                sqlcmd.Parameters.AddWithValue("@LoginStatus", "LOGOUT")
                Using sqldr = sqlcmd.ExecuteReader
                    If sqldr.HasRows Then
                        sqldr.Read()
                        If sqldr("AccountStatus").ToString = "PENDING" Then
                            s = "PENDING"
                        Else
                            s = "LOGIN"
                        End If
                    Else
                        s = "INVALID"
                    End If
                End Using
            End Using
        End Using
        Return s
    End Function

    Sub checkConfig()
        If checkConnection() Then
            txtUsername.Focus()
        Else
            If MessageBox.Show("Database Connection Error. Do you want to configure it?", "The Good Sheperd School - Payroll System", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                frmDBSettings.Show()
                Me.Close()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.checkConfig()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MsgBox("Username cannot be empty", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password cannot be empty", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
        Else
            Call Me.validateInput()
            If isLogin(username, password) = "LOGIN" Then
                MainForm.Show()
                Me.Close()
            ElseIf isLogin(username, password) = "INVALID" Then
                MsgBox("Invalid Username or Password", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            Else
                MsgBox("This account is still pending", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            End If
        End If
    End Sub
End Class