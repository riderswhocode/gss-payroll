Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmEmployeeAdd

    Dim Firstname, Middlename, Lastname, Ext, Brgy, City, Province, Gender, Status As String
    Dim Citizenship, TIN, Contact, Email As String
    Dim SSS, PAGIBIG, PHILHEALTH As String
    Dim DOB As Date
    Dim _Height, _Weight As Double
    Dim Age As Integer

    Sub clearFields()
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtExt.Text = ""
        txtProvince.Text = ""
        txtMunicipality.Text = ""
        txtBarangay.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtPosition.Text = ""
        txtRate.Text = ""
        txtSSS.Text = ""
        txtPAGIBIG.Text = ""
        txtPHILHEALTH.Text = ""
    End Sub
    Sub validateInput()
        If txtFirstname.Text = "" Or txtLastname.Text = "" Or txtBarangay.Text = "" Or txtMunicipality.Text = "" Or txtProvince.Text = "" Then
            MsgBox("All fields are required")
        ElseIf txtSex.Text = "" Or txtCivil.Text = "" Or txtHeight.Text = "" Or txtWeight.Text = "" Then
            MsgBox("All fields are required")
        ElseIf txtPosition.Text = "" Or txtDepartment.Text = "" Then
            MsgBox("All fields are required")
        Else
            empID = txtEmpID.Text
            Firstname = Regex.Replace(txtFirstname.Text, "[^A-Za-z]", "")
            Middlename = Regex.Replace(txtMiddlename.Text, "[^A-Za-z]", "")
            Lastname = Regex.Replace(txtLastname.Text, "[^A-Za-z]", "")
            Ext = Regex.Replace(txtExt.Text, "[^A-Za-z0-9]", "")
            Brgy = txtBarangay.Text
            City = txtMunicipality.Text
            Province = txtProvince.Text
            DOB = dateDOB.Value.ToShortDateString
            Gender = txtSex.Text
            Status = txtCivil.Text
            'Citizenship = Regex.Replace(txtCitizenship.Text, "[^A-Za-z0-9\-/]", "")
            _Height = txtHeight.Text
            _Weight = txtWeight.Text
            'TIN = Regex.Replace(txtTIN.Text, "[^A-Za-z0-9\-/]", "")
            'BType = Regex.Replace(txtBtype.Text, "[^A-Za-z0-9\-/]", "")
            Contact = Regex.Replace(txtPhone.Text, "[^0-9]", "")
            Email = txtEmail.Text
            Call Me.save()
        End If
    End Sub
    Sub save()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim u, v, w, x, y, z As Integer
            query = "START TRANSACTION; " + vbNewLine

            query = query + "INSERT INTO tblemployee(EmployeeID,Firstname,Middlename,Lastname,Ext,DOB,Age, " +
                                  "Barangay,City,Province,Gender,CivilStatus,Height,Weight,ContactNo,Email) " +
                                  "VALUES(@EmployeeID,@Firstname,@Middlename,@Lastname,@Ext,@DOB,@Age,@Barangay,@City, " +
                                  "@Province,@Gender,@CivilStatus,@Height,@Weight,@Contact,@Email);" + vbNewLine
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmployeeID", empID)
                sqlcmd.Parameters.AddWithValue("@Firstname", Firstname)
                sqlcmd.Parameters.AddWithValue("@Middlename", Middlename)
                sqlcmd.Parameters.AddWithValue("@Lastname", Lastname)
                sqlcmd.Parameters.AddWithValue("@Ext", Ext)
                sqlcmd.Parameters.AddWithValue("@DOB", DOB)
                sqlcmd.Parameters.AddWithValue("@Age", txtAge.Text)
                sqlcmd.Parameters.AddWithValue("@Barangay", Brgy)
                sqlcmd.Parameters.AddWithValue("@City", City)
                sqlcmd.Parameters.AddWithValue("@Province", Province)
                sqlcmd.Parameters.AddWithValue("@Gender", Gender)
                sqlcmd.Parameters.AddWithValue("@CivilStatus", Status)
                sqlcmd.Parameters.AddWithValue("@Height", _Height)
                sqlcmd.Parameters.AddWithValue("@Weight", _Weight)
                sqlcmd.Parameters.AddWithValue("@Contact", Contact)
                sqlcmd.Parameters.AddWithValue("@Email", Email)
                u = sqlcmd.ExecuteNonQuery()
            End Using

            query = "INSERT INTO tblsss(EmployeeID,SSS) " +
                                  "VALUES(@EmpID,@SSS)"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmpID", empID)
                sqlcmd.Parameters.AddWithValue("@SSS", txtSSS.Text)
                v = sqlcmd.ExecuteNonQuery()
            End Using

            query = "INSERT INTO tblphilhealth(EmployeeID,PHILHEALTH) " +
                                  "VALUES(@EmpID,@PHILHEALTH)"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmpID", empID)
                sqlcmd.Parameters.AddWithValue("@PHILHEALTH", txtPHILHEALTH.Text)
                w = sqlcmd.ExecuteNonQuery()
            End Using

            query = "INSERT INTO tblpagibig(EmployeeID,PAGIBIG) " +
                                  "VALUES(@EmpID,@PAGIBIG)"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmpID", empID)
                sqlcmd.Parameters.AddWithValue("@PAGIBIG", txtPAGIBIG.Text)
                x = sqlcmd.ExecuteNonQuery()
            End Using

            query = "INSERT INTO tbldesignation(EmployeeID,Position,DeptTitle,Status) " +
                                  "VALUES(@EmpID,@Position,@Dept,@Status)"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmpID", empID)
                sqlcmd.Parameters.AddWithValue("@Position", txtPosition.Text)
                sqlcmd.Parameters.AddWithValue("@Dept", txtDepartment.Text)
                sqlcmd.Parameters.AddWithValue("@Status", "ACTIVE")
                y = sqlcmd.ExecuteNonQuery()
            End Using

            query = "INSERT INTO tblrates(EmployeeID,MonthYear,Rate) " +
                                  "VALUES(@EmpID,@MonthYear,@Rate)"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                sqlcmd.Parameters.AddWithValue("@EmpID", empID)
                sqlcmd.Parameters.AddWithValue("@MonthYear", "CURDATE()")
                sqlcmd.Parameters.AddWithValue("@Rate", txtRate.Text)
                z = sqlcmd.ExecuteNonQuery()
            End Using

            Try
                If u And v And w And x And y And z > 0 Then
                    query = "COMMIT"
                    Using sqlcmd = New MySqlCommand(query, sqlcon)
                        Dim r = sqlcmd.ExecuteNonQuery
                        If r > 1 Then
                            MsgBox("New employee has been added.", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                            Call Me.clearFields()
                            txtEmpID.Text = Module1.employeeIDGenerator()
                        Else
                            MsgBox("There is an error saving new employee's information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                        End If
                    End Using
                ElseIf u = 0 Then
                    MsgBox("There is an error on saving Employee's Personal Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                ElseIf v = 0 Then
                    MsgBox("There is an error on saving Employee's SSS Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                ElseIf w = 0 Then
                    MsgBox("There is an error on saving Employee's PhilHealth Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                ElseIf x = 0 Then
                    MsgBox("There is an error on saving Employee's PAGIBIG Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                ElseIf y = 0 Then
                    MsgBox("There is an error on saving Employee's Work Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                ElseIf z = 0 Then
                    MsgBox("There is an error on saving Employee's Work Information", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                Else
                    query = "ROLLBACK"
                    Using sqlcmd = New MySqlCommand(query, sqlcon)
                        Dim r = sqlcmd.ExecuteNonQuery
                        If r > 0 Then
                            MsgBox("Rolling back some changes, Error saving employee's information.", MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
                        End If
                    End Using
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "The Good Sheperd School - Payroll System")
            End Try
            
        End Using

    End Sub

    Sub loadDepartment()
        Using sqlcon = New MySqlConnection(conString)
            sqlcon.Open()
            Dim query As String = "SELECT DISTINCT(DeptTitle) FROM tbldepartment"
            Using sqlcmd = New MySqlCommand(query, sqlcon)
                Using sqldr = sqlcmd.ExecuteReader
                    txtDepartment.Items.Clear()
                    While sqldr.Read
                        If sqldr.HasRows Then
                            txtDepartment.Items.Add(sqldr(0))
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub frmEmployeeAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ChildForm = New frmEmployee
        ChildForm.MdiParent = MainForm
        ChildForm.Dock = DockStyle.Fill
        ChildForm.Show()
    End Sub
    Private Sub frmEmployeeAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If newEmployeeFlag Then
            txtEmpID.Text = Module1.employeeIDGenerator()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        Else
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        End If
        loadDepartment()
    End Sub


    Private Sub dateDOB_Validated(sender As Object, e As EventArgs)
        txtAge.Text = Module1.GetCurrentAge(dateDOB.Value)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If newEmployeeFlag Then
            Call Me.validateInput()
        Else

        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Enter(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.Enter
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblFPStatus.Visible = True Then
            lblFPStatus.Visible = False
        Else
            lblFPStatus.Visible = True
        End If
    End Sub

    Private Sub SplitContainer1_Panel2_Click(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.Click
        Timer1.Start()
    End Sub
End Class