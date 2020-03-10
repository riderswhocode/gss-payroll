Imports MySql.Data.MySqlClient
Public Class frmDBSettings

    Sub ListDB()
        Try
            Dim conString = "Server = '" & txtServername.Text & "';User Id='" & txtUser.Text & "';Password='" & txtPassword.Text & "'"
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SHOW DATABASES"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    Using sqldr = sqlcmd.ExecuteReader
                        If sqldr.HasRows Then
                            txtDB.Items.Clear()
                            While sqldr.Read
                                txtDB.Items.Add(sqldr(0).ToString)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtServername.Text = "" Or txtUser.Text = "" Then
            MsgBox("Servername or Username cannot be empty", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            txtServername.Focus()
        Else
            If txtDB.Text = "" Then
                MsgBox("Select your Database...", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                txtDB.Focus()
            Else
                Dim server As String = txtServername.Text
                Dim user As String = txtUser.Text
                Dim pass As String = txtPassword.Text
                Dim db As String = txtDB.Text
                Dim flag = Module1.insertConfig(server, user, pass, db)
                If flag Then
                    MsgBox("Server Settings succesfully configured.", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                    frmLogin.Show()
                    Me.Close()
                Else
                    MsgBox("Something's wrong while saving...", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                End If
            End If
        End If
    End Sub

    Private Sub txtDB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDB.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDB_Enter(sender As Object, e As EventArgs) Handles txtDB.Enter
        ListDB()
    End Sub
End Class