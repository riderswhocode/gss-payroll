Imports MySql.Data.MySqlClient
Public Class frmUserAccounts

    Sub loadUser()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT tbluser.UserID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                  "tblemployee.EmployeeID, tblemployee.ContactNo, tbluser.Username, tbluser.Password, tbluser.UserType, tbluser.AccountStatus FROM tbluser " +
                                  "INNER JOIN tblemployee ON tbluser.EmployeeID = tblemployee.EmployeeID"
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUserAccounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadUser()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtFilter.SelectedIndex = 0 Then
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SELECT tbluser.UserID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                      "tblemployee.ContactNo, tbluser.Username, tbluser.Password, tbluser.UserType, tbluser.AccountStatus FROM tbluser " +
                                      "INNER JOIN tblemployee ON tbluser.EmployeeID = tblemployee.EmployeeID WHERE tbluser.Username LIKE @Filter"
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
                Dim query As String = "SELECT tbluser.UserID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                      "tblemployee.ContactNo, tbluser.Username, tbluser.Password, tbluser.UserType, tbluser.AccountStatus FROM tblemployee " +
                                      "INNER JOIN tbluser ON tblemployee.EmployeeID = tbluser.EmployeeID WHERE tblemployee.Lastname LIKE @Filter"
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

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Dim ChildForm As New frmUserAdd
        ChildForm.MdiParent = MainForm
        ChildForm.Dock = DockStyle.Fill
        ChildForm.Show()
        Me.Close()
    End Sub

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        If dgv1.SelectedRows.Count <> 0 Then
            Dim ChildForm As New frmUserAdd
            With ChildForm
                .txtEmpID.Text = dgv1.SelectedRows.Item(0).Cells(0).Value
                .txtName.Text = dgv1.SelectedRows.Item(0).Cells(2).Value
                .txtUsername.Text = dgv1.SelectedRows.Item(0).Cells(4).Value
                .txtPassword.Text = Decrypt(dgv1.SelectedRows.Item(0).Cells(5).Value, hashKey)
                .txtAccountType.Text = dgv1.SelectedRows.Item(0).Cells(6).Value
                .dgv1.Enabled = False
                .SplitContainer1.Panel1.Enabled = False
            End With
            ChildForm.MdiParent = MainForm
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditLoginToolStripMenuItem.Click
        If dgv1.SelectedRows.Count <> 0 Then
            Dim ChildForm As New frmUserAdd
            With ChildForm
                .txtEmpID.Text = dgv1.SelectedRows.Item(0).Cells(0).Value
                .txtName.Text = dgv1.SelectedRows.Item(0).Cells(2).Value
                .txtUsername.Text = dgv1.SelectedRows.Item(0).Cells(4).Value
                .txtPassword.Text = Decrypt(dgv1.SelectedRows.Item(0).Cells(5).Value, hashKey)
                .txtAccountType.Text = dgv1.SelectedRows.Item(0).Cells(6).Value
                .btnSave.Text = "Update"
                .dgv1.Enabled = False
                .SplitContainer1.Panel1.Enabled = False
                .updateFlag = True
            End With
            ChildForm.MdiParent = MainForm
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
            Me.Close()
        End If
    End Sub
End Class