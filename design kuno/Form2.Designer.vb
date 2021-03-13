<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ViewAdministratorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SumifruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEmployeeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayEmployeeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeTimeSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalEmp = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLeave = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOntime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTimesheet = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ABSENT"
        '
        'ViewAdministratorsToolStripMenuItem
        '
        Me.ViewAdministratorsToolStripMenuItem.Name = "ViewAdministratorsToolStripMenuItem"
        Me.ViewAdministratorsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewAdministratorsToolStripMenuItem.Text = "View Administrators"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.MenuStrip1)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Controls.Add(Me.Panel7)
        Me.Panel9.Location = New System.Drawing.Point(12, 16)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(736, 395)
        Me.Panel9.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumifruToolStripMenuItem, Me.DToolStripMenuItem, Me.TimeSheetToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 25)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SumifruToolStripMenuItem
        '
        Me.SumifruToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportExcelToolStripMenuItem})
        Me.SumifruToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumifruToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SumifruToolStripMenuItem.Name = "SumifruToolStripMenuItem"
        Me.SumifruToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.SumifruToolStripMenuItem.Text = "Menu"
        '
        'ExportExcelToolStripMenuItem
        '
        Me.ExportExcelToolStripMenuItem.Name = "ExportExcelToolStripMenuItem"
        Me.ExportExcelToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExportExcelToolStripMenuItem.Text = "Export Excel"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEmployeeToolStripMenuItem1, Me.DisplayEmployeeToolStripMenuItem1})
        Me.DToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.DToolStripMenuItem.Text = "Employees "
        '
        'AddNewEmployeeToolStripMenuItem1
        '
        Me.AddNewEmployeeToolStripMenuItem1.Name = "AddNewEmployeeToolStripMenuItem1"
        Me.AddNewEmployeeToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.AddNewEmployeeToolStripMenuItem1.Text = "Add New Employee"
        '
        'DisplayEmployeeToolStripMenuItem1
        '
        Me.DisplayEmployeeToolStripMenuItem1.Name = "DisplayEmployeeToolStripMenuItem1"
        Me.DisplayEmployeeToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.DisplayEmployeeToolStripMenuItem1.Text = "View Employee"
        '
        'TimeSheetToolStripMenuItem
        '
        Me.TimeSheetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeTimeSheetToolStripMenuItem, Me.ViewReportsToolStripMenuItem, Me.EditReportsToolStripMenuItem})
        Me.TimeSheetToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSheetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TimeSheetToolStripMenuItem.Name = "TimeSheetToolStripMenuItem"
        Me.TimeSheetToolStripMenuItem.Size = New System.Drawing.Size(89, 21)
        Me.TimeSheetToolStripMenuItem.Text = "Time Sheet"
        '
        'EmployeeTimeSheetToolStripMenuItem
        '
        Me.EmployeeTimeSheetToolStripMenuItem.Name = "EmployeeTimeSheetToolStripMenuItem"
        Me.EmployeeTimeSheetToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EmployeeTimeSheetToolStripMenuItem.Text = "Employee TimeSheet"
        '
        'ViewReportsToolStripMenuItem
        '
        Me.ViewReportsToolStripMenuItem.Name = "ViewReportsToolStripMenuItem"
        Me.ViewReportsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ViewReportsToolStripMenuItem.Text = "View Reports"
        '
        'EditReportsToolStripMenuItem
        '
        Me.EditReportsToolStripMenuItem.Name = "EditReportsToolStripMenuItem"
        Me.EditReportsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EditReportsToolStripMenuItem.Text = "Edit Reports"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem, Me.ViewUsersToolStripMenuItem})
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(129, 21)
        Me.UserToolStripMenuItem.Text = "Manage Accounts"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem1, Me.ViewUsersToolStripMenuItem1})
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddNewUserToolStripMenuItem.Text = "User"
        '
        'AddNewUserToolStripMenuItem1
        '
        Me.AddNewUserToolStripMenuItem1.Name = "AddNewUserToolStripMenuItem1"
        Me.AddNewUserToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.AddNewUserToolStripMenuItem1.Text = "Add new User"
        '
        'ViewUsersToolStripMenuItem1
        '
        Me.ViewUsersToolStripMenuItem1.Name = "ViewUsersToolStripMenuItem1"
        Me.ViewUsersToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ViewUsersToolStripMenuItem1.Text = "View Users"
        '
        'ViewUsersToolStripMenuItem
        '
        Me.ViewUsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAdminToolStripMenuItem, Me.ViewAdministratorsToolStripMenuItem})
        Me.ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        Me.ViewUsersToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewUsersToolStripMenuItem.Text = "Administrator"
        '
        'AddNewAdminToolStripMenuItem
        '
        Me.AddNewAdminToolStripMenuItem.Name = "AddNewAdminToolStripMenuItem"
        Me.AddNewAdminToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddNewAdminToolStripMenuItem.Text = "Add new Admin"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Panel5)
        Me.Panel8.Controls.Add(Me.date1)
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Controls.Add(Me.Panel2)
        Me.Panel8.Location = New System.Drawing.Point(138, 29)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(598, 366)
        Me.Panel8.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(237, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 43)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Welcome, Admin!"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.lblTotalEmp)
        Me.Panel5.Location = New System.Drawing.Point(388, 187)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(166, 93)
        Me.Panel5.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(2, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TOTAL Employees"
        '
        'lblTotalEmp
        '
        Me.lblTotalEmp.AutoSize = True
        Me.lblTotalEmp.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEmp.CausesValidation = False
        Me.lblTotalEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmp.ForeColor = System.Drawing.Color.White
        Me.lblTotalEmp.Location = New System.Drawing.Point(2, 11)
        Me.lblTotalEmp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalEmp.Name = "lblTotalEmp"
        Me.lblTotalEmp.Size = New System.Drawing.Size(41, 44)
        Me.lblTotalEmp.TabIndex = 4
        Me.lblTotalEmp.Text = "0"
        '
        'date1
        '
        Me.date1.AutoSize = True
        Me.date1.BackColor = System.Drawing.Color.Transparent
        Me.date1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.date1.Location = New System.Drawing.Point(337, 6)
        Me.date1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(48, 22)
        Me.date1.TabIndex = 21
        Me.date1.Text = "date"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.lblLeave)
        Me.Panel6.Location = New System.Drawing.Point(423, 87)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(129, 93)
        Me.Panel6.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "On-LEAVE"
        '
        'lblLeave
        '
        Me.lblLeave.AutoSize = True
        Me.lblLeave.BackColor = System.Drawing.Color.Transparent
        Me.lblLeave.CausesValidation = False
        Me.lblLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeave.ForeColor = System.Drawing.Color.White
        Me.lblLeave.Location = New System.Drawing.Point(2, 11)
        Me.lblLeave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLeave.Name = "lblLeave"
        Me.lblLeave.Size = New System.Drawing.Size(41, 44)
        Me.lblLeave.TabIndex = 4
        Me.lblLeave.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.lblAbsent)
        Me.Panel4.Location = New System.Drawing.Point(163, 87)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(123, 93)
        Me.Panel4.TabIndex = 18
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.BackColor = System.Drawing.Color.Transparent
        Me.lblAbsent.CausesValidation = False
        Me.lblAbsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsent.ForeColor = System.Drawing.Color.White
        Me.lblAbsent.Location = New System.Drawing.Point(2, 11)
        Me.lblAbsent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(41, 44)
        Me.lblAbsent.TabIndex = 4
        Me.lblAbsent.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblOntime)
        Me.Panel3.Location = New System.Drawing.Point(35, 87)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(124, 93)
        Me.Panel3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ON TIME"
        '
        'lblOntime
        '
        Me.lblOntime.AutoSize = True
        Me.lblOntime.BackColor = System.Drawing.Color.Transparent
        Me.lblOntime.CausesValidation = False
        Me.lblOntime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOntime.ForeColor = System.Drawing.Color.White
        Me.lblOntime.Location = New System.Drawing.Point(2, 11)
        Me.lblOntime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOntime.Name = "lblOntime"
        Me.lblOntime.Size = New System.Drawing.Size(41, 44)
        Me.lblOntime.TabIndex = 4
        Me.lblOntime.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblLate)
        Me.Panel2.Location = New System.Drawing.Point(290, 87)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 93)
        Me.Panel2.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LATE"
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.BackColor = System.Drawing.Color.Transparent
        Me.lblLate.CausesValidation = False
        Me.lblLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLate.ForeColor = System.Drawing.Color.White
        Me.lblLate.Location = New System.Drawing.Point(2, 11)
        Me.lblLate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(41, 44)
        Me.lblLate.TabIndex = 4
        Me.lblLate.Text = "0"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.btnTimesheet)
        Me.Panel7.Controls.Add(Me.Button5)
        Me.Panel7.Location = New System.Drawing.Point(0, 29)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(139, 366)
        Me.Panel7.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(10, 125)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Employees"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(10, 81)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnTimesheet
        '
        Me.btnTimesheet.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnTimesheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTimesheet.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimesheet.ForeColor = System.Drawing.Color.White
        Me.btnTimesheet.Location = New System.Drawing.Point(10, 169)
        Me.btnTimesheet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTimesheet.Name = "btnTimesheet"
        Me.btnTimesheet.Size = New System.Drawing.Size(120, 40)
        Me.btnTimesheet.TabIndex = 30
        Me.btnTimesheet.Text = "Reports"
        Me.btnTimesheet.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Button5.BackgroundImage = Global.attendancesystem.My.Resources.Resources.free_exit_logout_icon_2857_thumb
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(28, 301)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 37)
        Me.Button5.TabIndex = 29
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(51, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 77)
        Me.Panel1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(401, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "LEMCO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(66, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(756, 36)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Laak Banana Employees Multi-Purpose Cooperative "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), System.Drawing.Image)
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Location = New System.Drawing.Point(101, 112)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(759, 429)
        Me.Panel10.TabIndex = 35
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(960, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel10)
        Me.DoubleBuffered = True
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATTENDANCE MONITORING SYSTEM"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents ViewAdministratorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel9 As Panel
    Friend WithEvents date1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalEmp As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLate As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOntime As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLeave As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAbsent As Label
    Friend WithEvents AddNewAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents btnTimesheet As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SumifruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisplayEmployeeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimeSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeTimeSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewUsersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
End Class
