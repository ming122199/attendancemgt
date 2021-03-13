<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empid1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deptID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dHired1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImage = Global.attendancesystem.My.Resources.Resources._61183
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.Location = New System.Drawing.Point(22, 112)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.BackgroundImage = Global.attendancesystem.My.Resources.Resources._202_2022557_edit_comments_edit_icon_png
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpdate.Location = New System.Drawing.Point(22, 155)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 37)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(815, 17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 375)
        Me.Panel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.Location = New System.Drawing.Point(38, 319)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 28)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.attendancesystem.My.Resources.Resources.download1
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(22, 238)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.BackgroundImage = Global.attendancesystem.My.Resources.Resources.delete_remove_trash_trash_bin_trash_can_icon_1320073117929397588
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemove.Location = New System.Drawing.Point(22, 196)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(119, 37)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(152, 17)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Employee:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(349, 17)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 47)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id1, Me.empid1, Me.deptID1, Me.fname1, Me.lname1, Me.add1, Me.bdate1, Me.gender1, Me.dHired1, Me.contact})
        Me.DataGridView1.GridColor = System.Drawing.Color.Violet
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(804, 274)
        Me.DataGridView1.TabIndex = 5
        '
        'id1
        '
        Me.id1.HeaderText = "ID"
        Me.id1.Name = "id1"
        Me.id1.ReadOnly = True
        '
        'empid1
        '
        Me.empid1.HeaderText = "EMPLOYEE ID"
        Me.empid1.Name = "empid1"
        Me.empid1.ReadOnly = True
        '
        'deptID1
        '
        Me.deptID1.HeaderText = "Department ID"
        Me.deptID1.Name = "deptID1"
        Me.deptID1.ReadOnly = True
        '
        'fname1
        '
        Me.fname1.HeaderText = "First Name"
        Me.fname1.Name = "fname1"
        Me.fname1.ReadOnly = True
        '
        'lname1
        '
        Me.lname1.HeaderText = "Last Name"
        Me.lname1.Name = "lname1"
        Me.lname1.ReadOnly = True
        '
        'add1
        '
        Me.add1.HeaderText = "Address"
        Me.add1.Name = "add1"
        Me.add1.ReadOnly = True
        '
        'bdate1
        '
        Me.bdate1.HeaderText = "Birthdate"
        Me.bdate1.Name = "bdate1"
        Me.bdate1.ReadOnly = True
        '
        'gender1
        '
        Me.gender1.HeaderText = "Gender"
        Me.gender1.Name = "gender1"
        Me.gender1.ReadOnly = True
        '
        'dHired1
        '
        Me.dHired1.HeaderText = "Date Hired"
        Me.dHired1.Name = "dHired1"
        Me.dHired1.ReadOnly = True
        '
        'contact
        '
        Me.contact.HeaderText = "Contact No"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EMPLOYEE ID", "EMPLOYEE NAME"})
        Me.ComboBox1.Location = New System.Drawing.Point(152, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search Type:"
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.BackColor = System.Drawing.Color.Transparent
        Me.chkAuto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.chkAuto.Location = New System.Drawing.Point(160, 70)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(92, 17)
        Me.chkAuto.TabIndex = 8
        Me.chkAuto.Text = "AutoComplete"
        Me.chkAuto.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 273)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(28, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 410)
        Me.Panel3.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.chkAuto)
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtSearch)
        Me.Panel5.Controls.Add(Me.btnSearch)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(11, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 96)
        Me.Panel5.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.AutoSize = True
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(28, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(338, 77)
        Me.Panel6.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 36)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "LIST OF EMPLOYEES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1059, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance "
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents id1 As DataGridViewTextBoxColumn
    Friend WithEvents empid1 As DataGridViewTextBoxColumn
    Friend WithEvents deptID1 As DataGridViewTextBoxColumn
    Friend WithEvents fname1 As DataGridViewTextBoxColumn
    Friend WithEvents lname1 As DataGridViewTextBoxColumn
    Friend WithEvents add1 As DataGridViewTextBoxColumn
    Friend WithEvents bdate1 As DataGridViewTextBoxColumn
    Friend WithEvents gender1 As DataGridViewTextBoxColumn
    Friend WithEvents dHired1 As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
End Class
