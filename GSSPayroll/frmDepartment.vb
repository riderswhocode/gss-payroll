Imports MySql.Data.MySqlClient
Public Class frmDepartment

    Sub loadDept()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT DeptID,DeptTitle FROM tbldepartment"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                Using sqldr = sqlcmd.ExecuteReader
                    While sqldr.Read
                        If sqldr.HasRows Then
                            lv1.Items.Clear()
                            With lv1
                                .Items.Add(sqldr("DeptID"))
                                With .Items(.Items.Count - 1).SubItems
                                    .Add(sqldr("DeptTitle"))
                                End With
                            End With
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDept()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim x As Integer
        If txtDept.Text = "" Then
            MsgBox("Department name cannot be empty", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            txtDept.Focus()
        Else
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "INSERT IGNORE INTO tbldepartment(DeptTitle) VALUES(@Dept)"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@Dept", txtDept.Text)
                    x = sqlcmd.ExecuteNonQuery
                End Using
            End Using
            If x > 0 Then
                MsgBox("New Department has been added", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                loadDept()
            Else
                MsgBox("Department name already exist", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            End If
        End If
    End Sub

    Private Sub lv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv1.SelectedIndexChanged
        If lv1.SelectedItems.Count <> 0 Then
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SELECT CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) " +
                                      "As Fullname, tbldesignation.Position FROM tbldesignation INNER JOIN tblemployee ON tbldesignation.EmployeeID = tblemployee.EmployeeID " +
                                      "WHERE tbldesignation.DeptTitle = '" & lv1.SelectedItems.Item(0).SubItems(1).Text & "'"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    Dim sqlda As New MySqlDataAdapter
                    Dim ds As New DataSet
                    Dim bSource As New BindingSource
                    sqlda.SelectCommand = sqlcmd
                    sqlda.Fill(ds)
                    bSource.DataSource = ds.Tables(0)
                    dgv1.DataSource = bSource
                End Using
            End Using
        End If
    End Sub
End Class