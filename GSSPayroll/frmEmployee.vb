Imports MySql.Data.MySqlClient
Public Class frmEmployee

    Sub loadEmployee()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                  "CONCAT(tblemployee.Barangay, ', ', tblemployee.City, ' ', tblemployee.Province) As Address, tblemployee.DOB, " +
                                  "tbldesignation.Position, tbldesignation.DeptTitle, tblrates.Rate, tbldesignation.Status FROM tblemployee " +
                                  "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID " +
                                  "INNER JOIN tblrates ON tblemployee.EmployeeID = tblrates.EmployeeID"
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

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployee()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNewEmp_Click(sender As Object, e As EventArgs) Handles btnNewEmp.Click
        newEmployeeFlag = True
        Dim ChildForm As New frmEmployeeAdd
        ChildForm.MdiParent = MainForm
        'ChildForm.Dock = DockStyle.Fill
        ChildForm.Show()
        'frmEmployeeAdd.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtFilter.SelectedIndex = 0 Then
            Using sqlcon = New MySqlConnection(conString)
                sqlcon.Open()
                Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                  "CONCAT(tblemployee.Barangay, ', ', tblemployee.City, ' ', tblemployee.Province) As Address, tblemployee.DOB, " +
                                  "tbldesignation.Position, tbldesignation.DeptTitle, tblrates.Rate, tbldesignation.Status FROM tblemployee " +
                                  "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID " +
                                  "INNER JOIN tblrates ON tblemployee.EmployeeID = tblrates.EmployeeID WHERE tblemployee.EmployeeID LIKE @Filter"
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
                Dim query As String = "SELECT tblemployee.EmployeeID, CONCAT(tblemployee.Lastname, ', ', tblemployee.Firstname, ' ', tblemployee.Middlename) As Fullname, " +
                                  "CONCAT(tblemployee.Barangay, ', ', tblemployee.City, ' ', tblemployee.Province) As Address, tblemployee.DOB, " +
                                  "tbldesignation.Position, tbldesignation.DeptTitle, tblrates.Rate, tbldesignation.Status FROM tblemployee " +
                                  "INNER JOIN tbldesignation ON tblemployee.EmployeeID = tbldesignation.EmployeeID " +
                                  "INNER JOIN tblrates ON tblemployee.EmployeeID = tblrates.EmployeeID WHERE tblemployee.Lastname LIKE @Filter"
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
End Class