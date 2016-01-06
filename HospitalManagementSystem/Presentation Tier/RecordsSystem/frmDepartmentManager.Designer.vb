<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartmentManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartmentManager))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tboxDepartment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboxSpecialized = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tboxClinic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdUpdateEmpl = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdDeleteCus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lboxDepartments = New System.Windows.Forms.ListBox()
        Me.lboxSpecialized = New System.Windows.Forms.ListBox()
        Me.tboxBed_Department = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tboxBed_ClinicCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxBed_BedCount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.dgvBeds = New System.Windows.Forms.DataGridView()
        Me.dgvClinics = New System.Windows.Forms.DataGridView()
        Me.CLINICID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLINICNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEDID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(202, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(615, 21)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "QUẢN LÝ DANH SÁCH KHOA, NGÀNH, PHÒNG KHÁM, GIƯỜNG BỆNH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lboxDepartments)
        Me.GroupBox1.Controls.Add(Me.cmdUpdateEmpl)
        Me.GroupBox1.Controls.Add(Me.tboxDepartment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCustomer)
        Me.GroupBox1.Controls.Add(Me.cmdDeleteCus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KHOA"
        '
        'tboxDepartment
        '
        Me.tboxDepartment.Location = New System.Drawing.Point(74, 29)
        Me.tboxDepartment.Name = "tboxDepartment"
        Me.tboxDepartment.Size = New System.Drawing.Size(220, 21)
        Me.tboxDepartment.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Khoa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lboxSpecialized)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tboxSpecialized)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Location = New System.Drawing.Point(348, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHUYÊN NGÀNH"
        '
        'tboxSpecialized
        '
        Me.tboxSpecialized.Location = New System.Drawing.Point(126, 31)
        Me.tboxSpecialized.Name = "tboxSpecialized"
        Me.tboxSpecialized.Size = New System.Drawing.Size(170, 21)
        Me.tboxSpecialized.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Chuyên ngành"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvClinics)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.tboxClinic)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(680, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PHÒNG KHÁM"
        '
        'tboxClinic
        '
        Me.tboxClinic.Location = New System.Drawing.Point(115, 31)
        Me.tboxClinic.Name = "tboxClinic"
        Me.tboxClinic.Size = New System.Drawing.Size(180, 21)
        Me.tboxClinic.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Phòng khám"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvBeds)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.tboxBed_BedCount)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tboxBed_ClinicCount)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.tboxBed_Department)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(847, 186)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GIƯỜNG BỆNH"
        '
        'cmdUpdateEmpl
        '
        Me.cmdUpdateEmpl.BackgroundImage = CType(resources.GetObject("cmdUpdateEmpl.BackgroundImage"), System.Drawing.Image)
        Me.cmdUpdateEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdateEmpl.Location = New System.Drawing.Point(224, 56)
        Me.cmdUpdateEmpl.Name = "cmdUpdateEmpl"
        Me.cmdUpdateEmpl.Size = New System.Drawing.Size(70, 23)
        Me.cmdUpdateEmpl.TabIndex = 33
        Me.cmdUpdateEmpl.Text = "&Sửa"
        Me.cmdUpdateEmpl.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(890, 525)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(98, 23)
        Me.cmdClose.TabIndex = 34
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackgroundImage = CType(resources.GetObject("cmdCustomer.BackgroundImage"), System.Drawing.Image)
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCustomer.Location = New System.Drawing.Point(72, 56)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(70, 23)
        Me.cmdCustomer.TabIndex = 31
        Me.cmdCustomer.Text = "&Thêm"
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdDeleteCus
        '
        Me.cmdDeleteCus.BackgroundImage = CType(resources.GetObject("cmdDeleteCus.BackgroundImage"), System.Drawing.Image)
        Me.cmdDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDeleteCus.Location = New System.Drawing.Point(148, 56)
        Me.cmdDeleteCus.Name = "cmdDeleteCus"
        Me.cmdDeleteCus.Size = New System.Drawing.Size(70, 23)
        Me.cmdDeleteCus.TabIndex = 32
        Me.cmdDeleteCus.Text = "&Xóa"
        Me.cmdDeleteCus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(226, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Sửa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(74, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "&Thêm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(150, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "&Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(225, 58)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 23)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "&Sửa"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(73, 58)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 23)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "&Thêm"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(149, 58)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 23)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "&Xóa"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lboxDepartments
        '
        Me.lboxDepartments.FormattingEnabled = True
        Me.lboxDepartments.ItemHeight = 15
        Me.lboxDepartments.Location = New System.Drawing.Point(6, 87)
        Me.lboxDepartments.Name = "lboxDepartments"
        Me.lboxDepartments.Size = New System.Drawing.Size(285, 184)
        Me.lboxDepartments.TabIndex = 34
        '
        'lboxSpecialized
        '
        Me.lboxSpecialized.FormattingEnabled = True
        Me.lboxSpecialized.ItemHeight = 15
        Me.lboxSpecialized.Location = New System.Drawing.Point(9, 87)
        Me.lboxSpecialized.Name = "lboxSpecialized"
        Me.lboxSpecialized.Size = New System.Drawing.Size(287, 184)
        Me.lboxSpecialized.TabIndex = 35
        '
        'tboxBed_Department
        '
        Me.tboxBed_Department.Location = New System.Drawing.Point(111, 84)
        Me.tboxBed_Department.Name = "tboxBed_Department"
        Me.tboxBed_Department.Size = New System.Drawing.Size(220, 21)
        Me.tboxBed_Department.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tên Khoa"
        '
        'tboxBed_ClinicCount
        '
        Me.tboxBed_ClinicCount.Location = New System.Drawing.Point(111, 57)
        Me.tboxBed_ClinicCount.Name = "tboxBed_ClinicCount"
        Me.tboxBed_ClinicCount.Size = New System.Drawing.Size(100, 21)
        Me.tboxBed_ClinicCount.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Số phòng bệnh"
        '
        'tboxBed_BedCount
        '
        Me.tboxBed_BedCount.Location = New System.Drawing.Point(111, 30)
        Me.tboxBed_BedCount.Name = "tboxBed_BedCount"
        Me.tboxBed_BedCount.Size = New System.Drawing.Size(100, 21)
        Me.tboxBed_BedCount.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Số giường bệnh"
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(164, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 23)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "&Sửa"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(12, 157)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 23)
        Me.Button8.TabIndex = 35
        Me.Button8.Text = "&Thêm"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(88, 157)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 23)
        Me.Button9.TabIndex = 36
        Me.Button9.Text = "&Xóa"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'dgvBeds
        '
        Me.dgvBeds.AllowUserToAddRows = False
        Me.dgvBeds.AllowUserToDeleteRows = False
        Me.dgvBeds.AllowUserToOrderColumns = True
        Me.dgvBeds.AllowUserToResizeColumns = False
        Me.dgvBeds.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBeds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BEDID, Me.ROOMID, Me.DEPARTMENT})
        Me.dgvBeds.Location = New System.Drawing.Point(373, 20)
        Me.dgvBeds.MultiSelect = False
        Me.dgvBeds.Name = "dgvBeds"
        Me.dgvBeds.ReadOnly = True
        Me.dgvBeds.RowHeadersVisible = False
        Me.dgvBeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBeds.Size = New System.Drawing.Size(453, 150)
        Me.dgvBeds.TabIndex = 42
        '
        'dgvClinics
        '
        Me.dgvClinics.AllowUserToAddRows = False
        Me.dgvClinics.AllowUserToDeleteRows = False
        Me.dgvClinics.AllowUserToResizeColumns = False
        Me.dgvClinics.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClinics.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClinics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClinics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLINICID, Me.CLINICNAME})
        Me.dgvClinics.Location = New System.Drawing.Point(9, 87)
        Me.dgvClinics.MultiSelect = False
        Me.dgvClinics.Name = "dgvClinics"
        Me.dgvClinics.ReadOnly = True
        Me.dgvClinics.RowHeadersVisible = False
        Me.dgvClinics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClinics.Size = New System.Drawing.Size(286, 184)
        Me.dgvClinics.TabIndex = 43
        '
        'CLINICID
        '
        Me.CLINICID.DataPropertyName = "ID"
        Me.CLINICID.HeaderText = "Mã số"
        Me.CLINICID.Name = "CLINICID"
        Me.CLINICID.ReadOnly = True
        Me.CLINICID.Width = 70
        '
        'CLINICNAME
        '
        Me.CLINICNAME.DataPropertyName = "NAME"
        Me.CLINICNAME.HeaderText = "Tên phòng khám"
        Me.CLINICNAME.Name = "CLINICNAME"
        Me.CLINICNAME.ReadOnly = True
        Me.CLINICNAME.Width = 200
        '
        'BEDID
        '
        Me.BEDID.DataPropertyName = "ID"
        Me.BEDID.HeaderText = "Số giường bệnh"
        Me.BEDID.Name = "BEDID"
        Me.BEDID.ReadOnly = True
        Me.BEDID.Width = 120
        '
        'ROOMID
        '
        Me.ROOMID.HeaderText = "Số phòng bệnh"
        Me.ROOMID.Name = "ROOMID"
        Me.ROOMID.ReadOnly = True
        Me.ROOMID.Width = 120
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.DataPropertyName = "DEPARTMENT"
        Me.DEPARTMENT.HeaderText = "Tên khoa"
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.ReadOnly = True
        Me.DEPARTMENT.Width = 150
        '
        'frmDepartmentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 560)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDepartmentManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Quản lý Phòng ban"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tboxDepartment As TextBox
    Friend WithEvents tboxSpecialized As TextBox
    Friend WithEvents tboxClinic As TextBox
    Private WithEvents cmdUpdateEmpl As Button
    Private WithEvents cmdCustomer As Button
    Private WithEvents cmdDeleteCus As Button
    Private WithEvents cmdClose As Button
    Friend WithEvents lboxDepartments As ListBox
    Friend WithEvents lboxSpecialized As ListBox
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Friend WithEvents dgvClinics As DataGridView
    Private WithEvents Button4 As Button
    Private WithEvents Button5 As Button
    Private WithEvents Button6 As Button
    Friend WithEvents dgvBeds As DataGridView
    Private WithEvents Button7 As Button
    Private WithEvents Button8 As Button
    Friend WithEvents tboxBed_BedCount As TextBox
    Private WithEvents Button9 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tboxBed_ClinicCount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tboxBed_Department As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CLINICID As DataGridViewTextBoxColumn
    Friend WithEvents CLINICNAME As DataGridViewTextBoxColumn
    Friend WithEvents BEDID As DataGridViewTextBoxColumn
    Friend WithEvents ROOMID As DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENT As DataGridViewTextBoxColumn
End Class
