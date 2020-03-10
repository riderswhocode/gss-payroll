Public Class MainForm

    Dim ChildForm As New Form

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        ChildForm = New frmEmployee
        ChildForm.MdiParent = Me
        ChildForm.Dock = DockStyle.Fill
        'ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        If ChildForm.Visible = True Then
            ChildForm.Close()
            ChildForm = New frmDepartment
            ChildForm.MdiParent = Me
            ChildForm.Show()
        Else
            ChildForm = New frmDepartment
            ChildForm.MdiParent = Me
            ChildForm.Show()
        End If
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccountsToolStripMenuItem.Click
        If ChildForm.Visible = True Then
            ChildForm.Close()
            ChildForm = New frmUserAccounts
            ChildForm.MdiParent = Me
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
        Else
            ChildForm = New frmUserAccounts
            ChildForm.MdiParent = Me
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
        End If
    End Sub
End Class
