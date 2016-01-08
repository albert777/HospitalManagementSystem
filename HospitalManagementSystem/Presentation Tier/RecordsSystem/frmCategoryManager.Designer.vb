<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategoryManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoryManager))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkbDeptChief = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboxDepartment_ChiefName = New System.Windows.Forms.ComboBox()
        Me.lblDeptChief = New System.Windows.Forms.Label()
        Me.dgvDepartment = New System.Windows.Forms.DataGridView()
        Me.colDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeptChiefId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeptChiefName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDeptEmplCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDept_Reset = New System.Windows.Forms.Button()
        Me.btnDept_Edit = New System.Windows.Forms.Button()
        Me.tboxDepartment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDept_Add = New System.Windows.Forms.Button()
        Me.btnDept_Delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSpec_Reset = New System.Windows.Forms.Button()
        Me.btnSpec_Edit = New System.Windows.Forms.Button()
        Me.btnSpec_Add = New System.Windows.Forms.Button()
        Me.btnSpec_Delete = New System.Windows.Forms.Button()
        Me.lboxSpecialized = New System.Windows.Forms.ListBox()
        Me.tboxSpecialized = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvClinics = New System.Windows.Forms.DataGridView()
        Me.CLINICID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLINICNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClinic_Reset = New System.Windows.Forms.Button()
        Me.btnClinic_Edit = New System.Windows.Forms.Button()
        Me.btnClinic_Add = New System.Windows.Forms.Button()
        Me.btnClinic_Delete = New System.Windows.Forms.Button()
        Me.tboxClinic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBed_Reset = New System.Windows.Forms.Button()
        Me.btnBed_Edit = New System.Windows.Forms.Button()
        Me.btnBed_Add = New System.Windows.Forms.Button()
        Me.btnBed_Delete = New System.Windows.Forms.Button()
        Me.dgvBeds = New System.Windows.Forms.DataGridView()
        Me.BEDID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tboxBed_BedCount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboxBed_ClinicCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxBed_Department = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.chkbDeptChief)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cboxDepartment_ChiefName)
        Me.GroupBox1.Controls.Add(Me.lblDeptChief)
        Me.GroupBox1.Controls.Add(Me.dgvDepartment)
        Me.GroupBox1.Controls.Add(Me.btnDept_Reset)
        Me.GroupBox1.Controls.Add(Me.btnDept_Edit)
        Me.GroupBox1.Controls.Add(Me.tboxDepartment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDept_Add)
        Me.GroupBox1.Controls.Add(Me.btnDept_Delete)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(335, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DANH MỤC KHOA"
        '
        'chkbDeptChief
        '
        Me.chkbDeptChief.AutoSize = True
        Me.chkbDeptChief.Checked = True
        Me.chkbDeptChief.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbDeptChief.Location = New System.Drawing.Point(9, 61)
        Me.chkbDeptChief.Name = "chkbDeptChief"
        Me.chkbDeptChief.Size = New System.Drawing.Size(15, 14)
        Me.chkbDeptChief.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.chkbDeptChief, """Bỏ tích để không chọn trường này""")
        Me.chkbDeptChief.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(228, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Thông tin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboxDepartment_ChiefName
        '
        Me.cboxDepartment_ChiefName.DisplayMember = "Name"
        Me.cboxDepartment_ChiefName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDepartment_ChiefName.FormattingEnabled = True
        Me.cboxDepartment_ChiefName.Items.AddRange(New Object() {"Không lựa chọn"})
        Me.cboxDepartment_ChiefName.Location = New System.Drawing.Point(113, 56)
        Me.cboxDepartment_ChiefName.Name = "cboxDepartment_ChiefName"
        Me.cboxDepartment_ChiefName.Size = New System.Drawing.Size(109, 23)
        Me.cboxDepartment_ChiefName.TabIndex = 50
        Me.cboxDepartment_ChiefName.ValueMember = "Id"
        '
        'lblDeptChief
        '
        Me.lblDeptChief.AutoSize = True
        Me.lblDeptChief.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeptChief.ForeColor = System.Drawing.Color.Black
        Me.lblDeptChief.Location = New System.Drawing.Point(27, 61)
        Me.lblDeptChief.Name = "lblDeptChief"
        Me.lblDeptChief.Size = New System.Drawing.Size(80, 13)
        Me.lblDeptChief.TabIndex = 49
        Me.lblDeptChief.Text = "Trưởng Khoa"
        '
        'dgvDepartment
        '
        Me.dgvDepartment.AllowUserToAddRows = False
        Me.dgvDepartment.AllowUserToDeleteRows = False
        Me.dgvDepartment.AllowUserToOrderColumns = True
        Me.dgvDepartment.AllowUserToResizeColumns = False
        Me.dgvDepartment.AllowUserToResizeRows = False
        Me.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDepartment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvDepartment.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDeptName, Me.colDeptChiefId, Me.colDeptChiefName, Me.colDeptEmplCount})
        Me.dgvDepartment.Location = New System.Drawing.Point(9, 114)
        Me.dgvDepartment.MultiSelect = False
        Me.dgvDepartment.Name = "dgvDepartment"
        Me.dgvDepartment.ReadOnly = True
        Me.dgvDepartment.RowHeadersVisible = False
        Me.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDepartment.Size = New System.Drawing.Size(285, 155)
        Me.dgvDepartment.TabIndex = 48
        '
        'colDeptName
        '
        Me.colDeptName.DataPropertyName = "Name"
        Me.colDeptName.HeaderText = "Tên Khoa"
        Me.colDeptName.Name = "colDeptName"
        Me.colDeptName.ReadOnly = True
        Me.colDeptName.Width = 91
        '
        'colDeptChiefId
        '
        Me.colDeptChiefId.DataPropertyName = "Chief"
        Me.colDeptChiefId.HeaderText = "Chief"
        Me.colDeptChiefId.Name = "colDeptChiefId"
        Me.colDeptChiefId.ReadOnly = True
        Me.colDeptChiefId.Visible = False
        Me.colDeptChiefId.Width = 63
        '
        'colDeptChiefName
        '
        Me.colDeptChiefName.DataPropertyName = "ChiefName"
        Me.colDeptChiefName.HeaderText = "Trưởng Khoa"
        Me.colDeptChiefName.Name = "colDeptChiefName"
        Me.colDeptChiefName.ReadOnly = True
        Me.colDeptChiefName.Width = 110
        '
        'colDeptEmplCount
        '
        Me.colDeptEmplCount.DataPropertyName = "COUNT"
        Me.colDeptEmplCount.HeaderText = "Số nhân viên"
        Me.colDeptEmplCount.Name = "colDeptEmplCount"
        Me.colDeptEmplCount.ReadOnly = True
        Me.colDeptEmplCount.Width = 110
        '
        'btnDept_Reset
        '
        Me.btnDept_Reset.BackgroundImage = CType(resources.GetObject("btnDept_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btnDept_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept_Reset.ForeColor = System.Drawing.Color.Black
        Me.btnDept_Reset.Location = New System.Drawing.Point(228, 85)
        Me.btnDept_Reset.Name = "btnDept_Reset"
        Me.btnDept_Reset.Size = New System.Drawing.Size(66, 23)
        Me.btnDept_Reset.TabIndex = 35
        Me.btnDept_Reset.Text = "&Làm mới"
        Me.btnDept_Reset.UseVisualStyleBackColor = True
        '
        'btnDept_Edit
        '
        Me.btnDept_Edit.BackgroundImage = CType(resources.GetObject("btnDept_Edit.BackgroundImage"), System.Drawing.Image)
        Me.btnDept_Edit.Enabled = False
        Me.btnDept_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept_Edit.ForeColor = System.Drawing.Color.Black
        Me.btnDept_Edit.Location = New System.Drawing.Point(155, 85)
        Me.btnDept_Edit.Name = "btnDept_Edit"
        Me.btnDept_Edit.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Edit.TabIndex = 33
        Me.btnDept_Edit.Text = "&Sửa"
        Me.btnDept_Edit.UseVisualStyleBackColor = True
        '
        'tboxDepartment
        '
        Me.tboxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxDepartment.Location = New System.Drawing.Point(92, 29)
        Me.tboxDepartment.Name = "tboxDepartment"
        Me.tboxDepartment.Size = New System.Drawing.Size(202, 21)
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
        'btnDept_Add
        '
        Me.btnDept_Add.BackgroundImage = CType(resources.GetObject("btnDept_Add.BackgroundImage"), System.Drawing.Image)
        Me.btnDept_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept_Add.ForeColor = System.Drawing.Color.Black
        Me.btnDept_Add.Location = New System.Drawing.Point(9, 85)
        Me.btnDept_Add.Name = "btnDept_Add"
        Me.btnDept_Add.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Add.TabIndex = 31
        Me.btnDept_Add.Text = "&Thêm"
        Me.btnDept_Add.UseVisualStyleBackColor = True
        '
        'btnDept_Delete
        '
        Me.btnDept_Delete.BackgroundImage = CType(resources.GetObject("btnDept_Delete.BackgroundImage"), System.Drawing.Image)
        Me.btnDept_Delete.Enabled = False
        Me.btnDept_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept_Delete.ForeColor = System.Drawing.Color.Black
        Me.btnDept_Delete.Location = New System.Drawing.Point(82, 85)
        Me.btnDept_Delete.Name = "btnDept_Delete"
        Me.btnDept_Delete.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Delete.TabIndex = 32
        Me.btnDept_Delete.Text = "&Xóa"
        Me.btnDept_Delete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSpec_Reset)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Edit)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Add)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Delete)
        Me.GroupBox2.Controls.Add(Me.lboxSpecialized)
        Me.GroupBox2.Controls.Add(Me.tboxSpecialized)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DANH MỤC CHUYÊN MÔN"
        '
        'btnSpec_Reset
        '
        Me.btnSpec_Reset.BackgroundImage = CType(resources.GetObject("btnSpec_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btnSpec_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpec_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpec_Reset.ForeColor = System.Drawing.Color.Black
        Me.btnSpec_Reset.Location = New System.Drawing.Point(228, 56)
        Me.btnSpec_Reset.Name = "btnSpec_Reset"
        Me.btnSpec_Reset.Size = New System.Drawing.Size(66, 23)
        Me.btnSpec_Reset.TabIndex = 39
        Me.btnSpec_Reset.Text = "&Làm mới"
        Me.btnSpec_Reset.UseVisualStyleBackColor = True
        '
        'btnSpec_Edit
        '
        Me.btnSpec_Edit.BackgroundImage = CType(resources.GetObject("btnSpec_Edit.BackgroundImage"), System.Drawing.Image)
        Me.btnSpec_Edit.Enabled = False
        Me.btnSpec_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpec_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpec_Edit.ForeColor = System.Drawing.Color.Black
        Me.btnSpec_Edit.Location = New System.Drawing.Point(155, 56)
        Me.btnSpec_Edit.Name = "btnSpec_Edit"
        Me.btnSpec_Edit.Size = New System.Drawing.Size(67, 23)
        Me.btnSpec_Edit.TabIndex = 38
        Me.btnSpec_Edit.Text = "&Sửa"
        Me.btnSpec_Edit.UseVisualStyleBackColor = True
        '
        'btnSpec_Add
        '
        Me.btnSpec_Add.BackgroundImage = CType(resources.GetObject("btnSpec_Add.BackgroundImage"), System.Drawing.Image)
        Me.btnSpec_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpec_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpec_Add.ForeColor = System.Drawing.Color.Black
        Me.btnSpec_Add.Location = New System.Drawing.Point(9, 56)
        Me.btnSpec_Add.Name = "btnSpec_Add"
        Me.btnSpec_Add.Size = New System.Drawing.Size(67, 23)
        Me.btnSpec_Add.TabIndex = 36
        Me.btnSpec_Add.Text = "&Thêm"
        Me.btnSpec_Add.UseVisualStyleBackColor = True
        '
        'btnSpec_Delete
        '
        Me.btnSpec_Delete.BackgroundImage = CType(resources.GetObject("btnSpec_Delete.BackgroundImage"), System.Drawing.Image)
        Me.btnSpec_Delete.Enabled = False
        Me.btnSpec_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpec_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpec_Delete.ForeColor = System.Drawing.Color.Black
        Me.btnSpec_Delete.Location = New System.Drawing.Point(82, 56)
        Me.btnSpec_Delete.Name = "btnSpec_Delete"
        Me.btnSpec_Delete.Size = New System.Drawing.Size(67, 23)
        Me.btnSpec_Delete.TabIndex = 37
        Me.btnSpec_Delete.Text = "&Xóa"
        Me.btnSpec_Delete.UseVisualStyleBackColor = True
        '
        'lboxSpecialized
        '
        Me.lboxSpecialized.DisplayMember = "Name"
        Me.lboxSpecialized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxSpecialized.FormattingEnabled = True
        Me.lboxSpecialized.ItemHeight = 15
        Me.lboxSpecialized.Location = New System.Drawing.Point(9, 85)
        Me.lboxSpecialized.Name = "lboxSpecialized"
        Me.lboxSpecialized.Size = New System.Drawing.Size(285, 184)
        Me.lboxSpecialized.TabIndex = 35
        '
        'tboxSpecialized
        '
        Me.tboxSpecialized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxSpecialized.Location = New System.Drawing.Point(114, 29)
        Me.tboxSpecialized.Name = "tboxSpecialized"
        Me.tboxSpecialized.Size = New System.Drawing.Size(180, 21)
        Me.tboxSpecialized.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Chuyên môn"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvClinics)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Reset)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Edit)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Add)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Delete)
        Me.GroupBox3.Controls.Add(Me.tboxClinic)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(658, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DANH MỤC PHÒNG KHÁM"
        '
        'dgvClinics
        '
        Me.dgvClinics.AllowUserToAddRows = False
        Me.dgvClinics.AllowUserToDeleteRows = False
        Me.dgvClinics.AllowUserToOrderColumns = True
        Me.dgvClinics.AllowUserToResizeColumns = False
        Me.dgvClinics.AllowUserToResizeRows = False
        Me.dgvClinics.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClinics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLINICID, Me.CLINICNAME})
        Me.dgvClinics.Location = New System.Drawing.Point(10, 85)
        Me.dgvClinics.MultiSelect = False
        Me.dgvClinics.Name = "dgvClinics"
        Me.dgvClinics.ReadOnly = True
        Me.dgvClinics.RowHeadersVisible = False
        Me.dgvClinics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClinics.Size = New System.Drawing.Size(285, 184)
        Me.dgvClinics.TabIndex = 47
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
        Me.CLINICNAME.Width = 140
        '
        'btnClinic_Reset
        '
        Me.btnClinic_Reset.BackgroundImage = CType(resources.GetObject("btnClinic_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btnClinic_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClinic_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClinic_Reset.ForeColor = System.Drawing.Color.Black
        Me.btnClinic_Reset.Location = New System.Drawing.Point(229, 56)
        Me.btnClinic_Reset.Name = "btnClinic_Reset"
        Me.btnClinic_Reset.Size = New System.Drawing.Size(66, 23)
        Me.btnClinic_Reset.TabIndex = 47
        Me.btnClinic_Reset.Text = "&Làm mới"
        Me.btnClinic_Reset.UseVisualStyleBackColor = True
        '
        'btnClinic_Edit
        '
        Me.btnClinic_Edit.BackgroundImage = CType(resources.GetObject("btnClinic_Edit.BackgroundImage"), System.Drawing.Image)
        Me.btnClinic_Edit.Enabled = False
        Me.btnClinic_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClinic_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClinic_Edit.ForeColor = System.Drawing.Color.Black
        Me.btnClinic_Edit.Location = New System.Drawing.Point(156, 56)
        Me.btnClinic_Edit.Name = "btnClinic_Edit"
        Me.btnClinic_Edit.Size = New System.Drawing.Size(67, 23)
        Me.btnClinic_Edit.TabIndex = 46
        Me.btnClinic_Edit.Text = "&Sửa"
        Me.btnClinic_Edit.UseVisualStyleBackColor = True
        '
        'btnClinic_Add
        '
        Me.btnClinic_Add.BackgroundImage = CType(resources.GetObject("btnClinic_Add.BackgroundImage"), System.Drawing.Image)
        Me.btnClinic_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClinic_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClinic_Add.ForeColor = System.Drawing.Color.Black
        Me.btnClinic_Add.Location = New System.Drawing.Point(10, 56)
        Me.btnClinic_Add.Name = "btnClinic_Add"
        Me.btnClinic_Add.Size = New System.Drawing.Size(67, 23)
        Me.btnClinic_Add.TabIndex = 44
        Me.btnClinic_Add.Text = "&Thêm"
        Me.btnClinic_Add.UseVisualStyleBackColor = True
        '
        'btnClinic_Delete
        '
        Me.btnClinic_Delete.BackgroundImage = CType(resources.GetObject("btnClinic_Delete.BackgroundImage"), System.Drawing.Image)
        Me.btnClinic_Delete.Enabled = False
        Me.btnClinic_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClinic_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClinic_Delete.ForeColor = System.Drawing.Color.Black
        Me.btnClinic_Delete.Location = New System.Drawing.Point(83, 56)
        Me.btnClinic_Delete.Name = "btnClinic_Delete"
        Me.btnClinic_Delete.Size = New System.Drawing.Size(67, 23)
        Me.btnClinic_Delete.TabIndex = 45
        Me.btnClinic_Delete.Text = "&Xóa"
        Me.btnClinic_Delete.UseVisualStyleBackColor = True
        '
        'tboxClinic
        '
        Me.tboxClinic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxClinic.Location = New System.Drawing.Point(115, 29)
        Me.tboxClinic.Name = "tboxClinic"
        Me.tboxClinic.Size = New System.Drawing.Size(180, 21)
        Me.tboxClinic.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Phòng khám"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBed_Reset)
        Me.GroupBox4.Controls.Add(Me.btnBed_Edit)
        Me.GroupBox4.Controls.Add(Me.btnBed_Add)
        Me.GroupBox4.Controls.Add(Me.btnBed_Delete)
        Me.GroupBox4.Controls.Add(Me.dgvBeds)
        Me.GroupBox4.Controls.Add(Me.tboxBed_BedCount)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tboxBed_ClinicCount)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.tboxBed_Department)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 357)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(847, 186)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DANH MỤC GIƯỜNG BỆNH"
        '
        'btnBed_Reset
        '
        Me.btnBed_Reset.BackgroundImage = CType(resources.GetObject("btnBed_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btnBed_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBed_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed_Reset.ForeColor = System.Drawing.Color.Black
        Me.btnBed_Reset.Location = New System.Drawing.Point(231, 147)
        Me.btnBed_Reset.Name = "btnBed_Reset"
        Me.btnBed_Reset.Size = New System.Drawing.Size(66, 23)
        Me.btnBed_Reset.TabIndex = 46
        Me.btnBed_Reset.Text = "&Làm mới"
        Me.btnBed_Reset.UseVisualStyleBackColor = True
        '
        'btnBed_Edit
        '
        Me.btnBed_Edit.BackgroundImage = CType(resources.GetObject("btnBed_Edit.BackgroundImage"), System.Drawing.Image)
        Me.btnBed_Edit.Enabled = False
        Me.btnBed_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBed_Edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed_Edit.ForeColor = System.Drawing.Color.Black
        Me.btnBed_Edit.Location = New System.Drawing.Point(158, 147)
        Me.btnBed_Edit.Name = "btnBed_Edit"
        Me.btnBed_Edit.Size = New System.Drawing.Size(67, 23)
        Me.btnBed_Edit.TabIndex = 45
        Me.btnBed_Edit.Text = "&Sửa"
        Me.btnBed_Edit.UseVisualStyleBackColor = True
        '
        'btnBed_Add
        '
        Me.btnBed_Add.BackgroundImage = CType(resources.GetObject("btnBed_Add.BackgroundImage"), System.Drawing.Image)
        Me.btnBed_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBed_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed_Add.ForeColor = System.Drawing.Color.Black
        Me.btnBed_Add.Location = New System.Drawing.Point(12, 147)
        Me.btnBed_Add.Name = "btnBed_Add"
        Me.btnBed_Add.Size = New System.Drawing.Size(67, 23)
        Me.btnBed_Add.TabIndex = 43
        Me.btnBed_Add.Text = "&Thêm"
        Me.btnBed_Add.UseVisualStyleBackColor = True
        '
        'btnBed_Delete
        '
        Me.btnBed_Delete.BackgroundImage = CType(resources.GetObject("btnBed_Delete.BackgroundImage"), System.Drawing.Image)
        Me.btnBed_Delete.Enabled = False
        Me.btnBed_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBed_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed_Delete.ForeColor = System.Drawing.Color.Black
        Me.btnBed_Delete.Location = New System.Drawing.Point(85, 147)
        Me.btnBed_Delete.Name = "btnBed_Delete"
        Me.btnBed_Delete.Size = New System.Drawing.Size(67, 23)
        Me.btnBed_Delete.TabIndex = 44
        Me.btnBed_Delete.Text = "&Xóa"
        Me.btnBed_Delete.UseVisualStyleBackColor = True
        '
        'dgvBeds
        '
        Me.dgvBeds.AllowUserToAddRows = False
        Me.dgvBeds.AllowUserToDeleteRows = False
        Me.dgvBeds.AllowUserToOrderColumns = True
        Me.dgvBeds.AllowUserToResizeColumns = False
        Me.dgvBeds.AllowUserToResizeRows = False
        Me.dgvBeds.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BEDID, Me.ROOMID, Me.DEPARTMENT})
        Me.dgvBeds.Location = New System.Drawing.Point(336, 20)
        Me.dgvBeds.MultiSelect = False
        Me.dgvBeds.Name = "dgvBeds"
        Me.dgvBeds.ReadOnly = True
        Me.dgvBeds.RowHeadersVisible = False
        Me.dgvBeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBeds.Size = New System.Drawing.Size(488, 150)
        Me.dgvBeds.TabIndex = 42
        '
        'BEDID
        '
        Me.BEDID.DataPropertyName = "ID"
        Me.BEDID.HeaderText = "Số giường bệnh"
        Me.BEDID.Name = "BEDID"
        Me.BEDID.ReadOnly = True
        Me.BEDID.Width = 130
        '
        'ROOMID
        '
        Me.ROOMID.HeaderText = "Số phòng bệnh"
        Me.ROOMID.Name = "ROOMID"
        Me.ROOMID.ReadOnly = True
        Me.ROOMID.Width = 130
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.DataPropertyName = "DEPARTMENT"
        Me.DEPARTMENT.HeaderText = "Tên khoa"
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.ReadOnly = True
        Me.DEPARTMENT.Width = 150
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
        'tboxBed_Department
        '
        Me.tboxBed_Department.Location = New System.Drawing.Point(111, 84)
        Me.tboxBed_Department.Name = "tboxBed_Department"
        Me.tboxBed_Department.Size = New System.Drawing.Size(186, 21)
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
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.Location = New System.Drawing.Point(878, 520)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 23)
        Me.cmdClose.TabIndex = 34
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmCategoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 560)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategoryManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Quản lý Phòng ban"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents btnDept_Edit As Button
    Private WithEvents btnDept_Add As Button
    Private WithEvents btnDept_Delete As Button
    Private WithEvents cmdClose As Button
    Friend WithEvents lboxSpecialized As ListBox
    Friend WithEvents dgvBeds As DataGridView
    Friend WithEvents tboxBed_BedCount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tboxBed_ClinicCount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tboxBed_Department As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents btnDept_Reset As Button
    Private WithEvents btnSpec_Reset As Button
    Private WithEvents btnSpec_Edit As Button
    Private WithEvents btnSpec_Add As Button
    Private WithEvents btnSpec_Delete As Button
    Private WithEvents btnClinic_Reset As Button
    Private WithEvents btnClinic_Edit As Button
    Private WithEvents btnClinic_Add As Button
    Private WithEvents btnClinic_Delete As Button
    Private WithEvents btnBed_Reset As Button
    Private WithEvents btnBed_Edit As Button
    Private WithEvents btnBed_Add As Button
    Private WithEvents btnBed_Delete As Button
    Friend WithEvents dgvClinics As DataGridView
    Friend WithEvents CLINICID As DataGridViewTextBoxColumn
    Friend WithEvents CLINICNAME As DataGridViewTextBoxColumn
    Friend WithEvents cboxDepartment_ChiefName As ComboBox
    Friend WithEvents lblDeptChief As Label
    Friend WithEvents dgvDepartment As DataGridView
    Friend WithEvents BEDID As DataGridViewTextBoxColumn
    Friend WithEvents ROOMID As DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENT As DataGridViewTextBoxColumn
    Private WithEvents Button1 As Button
    Friend WithEvents colDeptName As DataGridViewTextBoxColumn
    Friend WithEvents colDeptChiefId As DataGridViewTextBoxColumn
    Friend WithEvents colDeptChiefName As DataGridViewTextBoxColumn
    Friend WithEvents colDeptEmplCount As DataGridViewTextBoxColumn
    Friend WithEvents chkbDeptChief As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
