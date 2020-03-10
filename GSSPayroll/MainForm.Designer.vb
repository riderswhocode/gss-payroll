<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TravelOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveOfAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashAdvanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1, Me.ConfigToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1057, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TransactionToolStripMenuItem.Text = "Masterfiles"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TravelOrderToolStripMenuItem, Me.LeaveOfAbsenceToolStripMenuItem, Me.PassSlipToolStripMenuItem, Me.CashAdvanceToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ReportsToolStripMenuItem.Text = "Transactions"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1057, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 57)
        Me.Panel1.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayrollToolStripMenuItem, Me.EmployeesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1057, 57)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PayrollToolStripMenuItem.Image = CType(resources.GetObject("PayrollToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PayrollToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 53)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        Me.PayrollToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Image = CType(resources.GetObject("EmployeesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmployeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 53)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        Me.EmployeesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TravelOrderToolStripMenuItem
        '
        Me.TravelOrderToolStripMenuItem.Name = "TravelOrderToolStripMenuItem"
        Me.TravelOrderToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.TravelOrderToolStripMenuItem.Text = "Travel Order"
        '
        'LeaveOfAbsenceToolStripMenuItem
        '
        Me.LeaveOfAbsenceToolStripMenuItem.Name = "LeaveOfAbsenceToolStripMenuItem"
        Me.LeaveOfAbsenceToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LeaveOfAbsenceToolStripMenuItem.Text = "Leave of Absence"
        '
        'PassSlipToolStripMenuItem
        '
        Me.PassSlipToolStripMenuItem.Name = "PassSlipToolStripMenuItem"
        Me.PassSlipToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PassSlipToolStripMenuItem.Text = "Pass Slip"
        '
        'CashAdvanceToolStripMenuItem
        '
        Me.CashAdvanceToolStripMenuItem.Name = "CashAdvanceToolStripMenuItem"
        Me.CashAdvanceToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CashAdvanceToolStripMenuItem.Text = "Cash Advance"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Good Shepherd School Imelda Inc. -  Payroll System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TravelOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveOfAbsenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PassSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashAdvanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
