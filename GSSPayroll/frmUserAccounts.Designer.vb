<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccounts
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
        Me.components = New System.ComponentModel.Container()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockUnblockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.UserID, Me.Fullname, Me.ContactNo, Me.Username, Me.Password, Me.UserType, Me.AccountStatus})
        Me.dgv1.Location = New System.Drawing.Point(0, 39)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(955, 279)
        Me.dgv1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtFilter)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnNewUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(955, 36)
        Me.Panel1.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(470, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"Username", "Lastname"})
        Me.txtFilter.Location = New System.Drawing.Point(343, 8)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(121, 21)
        Me.txtFilter.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(161, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnNewUser
        '
        Me.btnNewUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNewUser.Location = New System.Drawing.Point(1, 6)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(154, 23)
        Me.btnNewUser.TabIndex = 0
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Crimson
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(955, 37)
        Me.Panel3.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(917, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.BlockUnblockToolStripMenuItem, Me.ForceLogoutToolStripMenuItem, Me.EditLoginToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 136)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve / Reject"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'BlockUnblockToolStripMenuItem
        '
        Me.BlockUnblockToolStripMenuItem.Name = "BlockUnblockToolStripMenuItem"
        Me.BlockUnblockToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BlockUnblockToolStripMenuItem.Text = "Block / Unblock"
        '
        'ForceLogoutToolStripMenuItem
        '
        Me.ForceLogoutToolStripMenuItem.Name = "ForceLogoutToolStripMenuItem"
        Me.ForceLogoutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ForceLogoutToolStripMenuItem.Text = "Force Logout"
        '
        'EmployeeID
        '
        Me.EmployeeID.DataPropertyName = "EmployeeID"
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Visible = False
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        '
        'Fullname
        '
        Me.Fullname.DataPropertyName = "Fullname"
        Me.Fullname.HeaderText = "Name"
        Me.Fullname.Name = "Fullname"
        Me.Fullname.ReadOnly = True
        Me.Fullname.Width = 250
        '
        'ContactNo
        '
        Me.ContactNo.DataPropertyName = "ContactNo"
        Me.ContactNo.HeaderText = "Contact No"
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.ReadOnly = True
        Me.ContactNo.Width = 150
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Width = 150
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        '
        'UserType
        '
        Me.UserType.DataPropertyName = "UserType"
        Me.UserType.HeaderText = "User Type"
        Me.UserType.Name = "UserType"
        Me.UserType.ReadOnly = True
        Me.UserType.Width = 150
        '
        'AccountStatus
        '
        Me.AccountStatus.DataPropertyName = "AccountStatus"
        Me.AccountStatus.HeaderText = "Account Status"
        Me.AccountStatus.Name = "AccountStatus"
        Me.AccountStatus.ReadOnly = True
        Me.AccountStatus.Width = 150
        '
        'EditLoginToolStripMenuItem
        '
        Me.EditLoginToolStripMenuItem.Name = "EditLoginToolStripMenuItem"
        Me.EditLoginToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditLoginToolStripMenuItem.Text = "Edit Login"
        '
        'frmUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccounts"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockUnblockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceLogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApproveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fullname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
