Imports MySql.Data.MySqlClient
Public Class frmUserAdd

    Public updateFlag As Boolean = False

    Sub loadData()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                  "tbldesignation.DeptTitle, tbldesignation.Position FROM tblemployee " +
                                  "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                Dim sqlda As New MySqlDataAdapter
                Dim sqlds As New DataSet
                Dim bSource As New BindingSource
                sqlda.SelectCommand = sqlcmd
                sqlda.Fill(sqlds)
                bSource.DataSource = sqlds.Tables(0)
                dgv1.DataSource = bSource
            End Using
        End Using
    End Sub

    Private Sub frmUserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtFilter.SelectedIndex = 0 Then
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname " +
                                      "tbldesignation.DeptTitle, tbldesignation.Position FROM tblemployee " +
                                      "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID " +
                                      "WHERE tblemployee.EmployeeID LIKE @Filter"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@Filter", txtSearch.Text & "%")
                    Dim sqlda As New MySqlDataAdapter
                    Dim sqlds As New DataSet
                    Dim bSource As New BindingSource
                    sqlda.SelectCommand = sqlcmd
                    sqlda.Fill(sqlds)
                    bSource.DataSource = sqlds.Tables(0)
                    dgv1.DataSource = bSource
                End Using
            End Using
        Else
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname " +
                                      "tbldesignation.DeptTitle, tbldesignation.Position FROM tblemployee " +
                                      "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID " +
                                      "WHERE tblemployee.Lastname LIKE @Filter"
                Using sqlcmd = New MySqlCommand(query, sqlcon)
                    sqlcmd.Parameters.AddWithValue("@Filter", txtSearch.Text & "%")
                    Dim sqlda As New MySqlDataAdapter
                    Dim sqlds As New DataSet
                    Dim bSource As New BindingSource
                    sqlda.SelectCommand = sqlcmd
                    sqlda.Fill(sqlds)
                    bSource.DataSource = sqlds.Tables(0)
                    dgv1.DataSource = bSource
                End Using
            End Using
        End If
    End Sub

    Private Sub dgv1_SelectionChanged(sender As Object, e As EventArgs) Handles dgv1.SelectionChanged
        If dgv1.SelectedRows.Count <> 0 Then
            txtEmpID.Text = dgv1.SelectedRows.Item(0).Cells(0).Value
            txtName.Text = dgv1.SelectedRows.Item(0).Cells(1).Value
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtAccountType.Text = "" Then
            MsgBox("Fill up all the required fields", MsgBoxStyle.Information, "The Good Shepherd School - Payroll System")
        Else
            If Not updateFlag Then
                Using sqlcon = New MySqlConnection(conString)
                    sqlcon.Open()
                    Dim query As String = "INSERT INTO tbluser(Username,Password,UserType,LoginStatus,AccountStatus,EmployeeID) " +
                                          "VALUES(@Username,@Password,@UserType,@LoginStatus,@AccountStatus,@EmployeeID)"
                    Using sqlcmd = New MySqlCommand(query, sqlcon)
                        sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                        sqlcmd.Parameters.AddWithValue("@Password", Encrypt(txtPassword.Text, hashKey))
                        sqlcmd.Parameters.AddWithValue("@UserType", txtAccountType.Text)
                        sqlcmd.Parameters.AddWithValue("@LoginStatus", "LOGOUT")
                        sqlcmd.Parameters.AddWithValue("@AccountStatus", "PENDING")
                        sqlcmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text)
                        Dim x As Integer = sqlcmd.ExecuteNonQuery
                        If x > 0 Then
                            MsgBox("New account has been created with a pending status.", MsgBoxStyle.Information, "The Good Shepherd School - Payroll System")
                            Me.Close()
                        Else
                            MsgBox("There is an error while creating the new account.", MsgBoxStyle.Information, "The Good Shepherd School - Payroll System")
                        End If
                    End Using
                End Using
            Else
                Using sqlcon = New MySqlConnection(conString)
                    sqlcon.Open()
                    Dim query As String = "UPDATE tbluser SET Username = @Username, Password = @Password, UserType = @UserType " +
                                          "WHERE EmployeeID = @ID"
                    Using sqlcmd = New MySqlCommand(query, sqlcon)
                        sqlcmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                        sqlcmd.Parameters.AddWithValue("@Password", Encrypt(txtPassword.Text, hashKey))
                        sqlcmd.Parameters.AddWithValue("@UserType", txtAccountType.Text)
                        sqlcmd.Parameters.AddWithValue("@ID", txtEmpID.Text)
                        Dim x As Integer = sqlcmd.ExecuteNonQuery
                        If x > 0 Then
                            MsgBox("User account updated successfully", MsgBoxStyle.Information, "The Good Shepherd School - Payroll System")
                            Me.Close()
                        Else
                            MsgBox("Error saving changes", MsgBoxStyle.Information, "The Good Shepherd School - Payroll System")
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub

    Private Sub frmUserAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ChildForm = New frmUserAccounts
        ChildForm.MdiParent = MainForm
        ChildForm.Dock = DockStyle.Fill
        ChildForm.Show()
    End Sub
End Class