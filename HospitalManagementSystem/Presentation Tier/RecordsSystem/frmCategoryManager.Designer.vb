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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvSpecialities = New System.Windows.Forms.DataGridView()
        Me.colSpecName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSpec_Reset = New System.Windows.Forms.Button()
        Me.btnSpec_Edit = New System.Windows.Forms.Button()
        Me.btnSpec_Add = New System.Windows.Forms.Button()
        Me.btnSpec_Delete = New System.Windows.Forms.Button()
        Me.tboxSpecialized = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnClinic_Reset = New System.Windows.Forms.Button()
        Me.dgvClinics = New System.Windows.Forms.DataGridView()
        Me.colClinicId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClinicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClinic_Edit = New System.Windows.Forms.Button()
        Me.tboxClinic = New System.Windows.Forms.TextBox()
        Me.btnClinic_Add = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClinic_Delete = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboxBed_DepartmentsName = New System.Windows.Forms.ComboBox()
        Me.btnBed_Reset = New System.Windows.Forms.Button()
        Me.btnBed_Edit = New System.Windows.Forms.Button()
        Me.btnBed_Add = New System.Windows.Forms.Button()
        Me.btnBed_Delete = New System.Windows.Forms.Button()
        Me.dgvBeds = New System.Windows.Forms.DataGridView()
        Me.colBedId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBedDeptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBedRoom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBedDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tboxBedId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboxBedRoom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSpecialities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(341, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 288)
        Me.GroupBox1.TabIndex = 1
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
        Me.chkbDeptChief.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.chkbDeptChief, """Bỏ tích để không chọn trường này""")
        Me.chkbDeptChief.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(269, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 5
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
        Me.cboxDepartment_ChiefName.Size = New System.Drawing.Size(150, 23)
        Me.cboxDepartment_ChiefName.TabIndex = 4
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
        Me.lblDeptChief.TabIndex = 3
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
        Me.dgvDepartment.Size = New System.Drawing.Size(326, 155)
        Me.dgvDepartment.TabIndex = 10
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
        Me.colDeptChiefId.Width = 56
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
        Me.colDeptEmplCount.HeaderText = "Số N.viên"
        Me.colDeptEmplCount.Name = "colDeptEmplCount"
        Me.colDeptEmplCount.ReadOnly = True
        Me.colDeptEmplCount.Width = 91
        '
        'btnDept_Reset
        '
        Me.btnDept_Reset.BackgroundImage = CType(resources.GetObject("btnDept_Reset.BackgroundImage"), System.Drawing.Image)
        Me.btnDept_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDept_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDept_Reset.ForeColor = System.Drawing.Color.Black
        Me.btnDept_Reset.Location = New System.Drawing.Point(269, 85)
        Me.btnDept_Reset.Name = "btnDept_Reset"
        Me.btnDept_Reset.Size = New System.Drawing.Size(66, 23)
        Me.btnDept_Reset.TabIndex = 9
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
        Me.btnDept_Edit.Location = New System.Drawing.Point(196, 85)
        Me.btnDept_Edit.Name = "btnDept_Edit"
        Me.btnDept_Edit.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Edit.TabIndex = 8
        Me.btnDept_Edit.Text = "&Sửa"
        Me.btnDept_Edit.UseVisualStyleBackColor = True
        '
        'tboxDepartment
        '
        Me.tboxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxDepartment.Location = New System.Drawing.Point(113, 29)
        Me.tboxDepartment.Name = "tboxDepartment"
        Me.tboxDepartment.Size = New System.Drawing.Size(222, 21)
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
        Me.btnDept_Add.Location = New System.Drawing.Point(50, 85)
        Me.btnDept_Add.Name = "btnDept_Add"
        Me.btnDept_Add.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Add.TabIndex = 6
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
        Me.btnDept_Delete.Location = New System.Drawing.Point(123, 85)
        Me.btnDept_Delete.Name = "btnDept_Delete"
        Me.btnDept_Delete.Size = New System.Drawing.Size(67, 23)
        Me.btnDept_Delete.TabIndex = 7
        Me.btnDept_Delete.Text = "&Xóa"
        Me.btnDept_Delete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSpecialities)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Reset)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Edit)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Add)
        Me.GroupBox2.Controls.Add(Me.btnSpec_Delete)
        Me.GroupBox2.Controls.Add(Me.tboxSpecialized)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DANH MỤC CHUYÊN MÔN"
        '
        'dgvSpecialities
        '
        Me.dgvSpecialities.AllowUserToAddRows = False
        Me.dgvSpecialities.AllowUserToDeleteRows = False
        Me.dgvSpecialities.AllowUserToOrderColumns = True
        Me.dgvSpecialities.AllowUserToResizeColumns = False
        Me.dgvSpecialities.AllowUserToResizeRows = False
        Me.dgvSpecialities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvSpecialities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvSpecialities.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvSpecialities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpecialities.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSpecName, Me.DataGridViewTextBoxColumn4})
        Me.dgvSpecialities.Location = New System.Drawing.Point(12, 85)
        Me.dgvSpecialities.MultiSelect = False
        Me.dgvSpecialities.Name = "dgvSpecialities"
        Me.dgvSpecialities.ReadOnly = True
        Me.dgvSpecialities.RowHeadersVisible = False
        Me.dgvSpecialities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvSpecialities.Size = New System.Drawing.Size(285, 184)
        Me.dgvSpecialities.TabIndex = 6
        '
        'colSpecName
        '
        Me.colSpecName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colSpecName.DataPropertyName = "Name"
        Me.colSpecName.HeaderText = "Tên Chuyên môn"
        Me.colSpecName.Name = "colSpecName"
        Me.colSpecName.ReadOnly = True
        Me.colSpecName.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "COUNT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Số N.viên"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        Me.btnSpec_Reset.TabIndex = 5
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
        Me.btnSpec_Edit.TabIndex = 4
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
        Me.btnSpec_Add.TabIndex = 2
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
        Me.btnSpec_Delete.TabIndex = 3
        Me.btnSpec_Delete.Text = "&Xóa"
        Me.btnSpec_Delete.UseVisualStyleBackColor = True
        '
        'tboxSpecialized
        '
        Me.tboxSpecialized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxSpecialized.Location = New System.Drawing.Point(114, 29)
        Me.tboxSpecialized.Name = "tboxSpecialized"
        Me.tboxSpecialized.Size = New System.Drawing.Size(180, 21)
        Me.tboxSpecialized.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Chuyên môn"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClinic_Reset)
        Me.GroupBox3.Controls.Add(Me.dgvClinics)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Edit)
        Me.GroupBox3.Controls.Add(Me.tboxClinic)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Add)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnClinic_Delete)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(710, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 288)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DANH MỤC PHÒNG KHÁM"
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
        Me.btnClinic_Reset.TabIndex = 5
        Me.btnClinic_Reset.Text = "&Làm mới"
        Me.btnClinic_Reset.UseVisualStyleBackColor = True
        '
        'dgvClinics
        '
        Me.dgvClinics.AllowUserToAddRows = False
        Me.dgvClinics.AllowUserToDeleteRows = False
        Me.dgvClinics.AllowUserToOrderColumns = True
        Me.dgvClinics.AllowUserToResizeColumns = False
        Me.dgvClinics.AllowUserToResizeRows = False
        Me.dgvClinics.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClinics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClinics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClinicId, Me.colClinicName})
        Me.dgvClinics.Location = New System.Drawing.Point(10, 85)
        Me.dgvClinics.MultiSelect = False
        Me.dgvClinics.Name = "dgvClinics"
        Me.dgvClinics.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClinics.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClinics.RowHeadersVisible = False
        Me.dgvClinics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvClinics.Size = New System.Drawing.Size(285, 184)
        Me.dgvClinics.TabIndex = 6
        '
        'colClinicId
        '
        Me.colClinicId.DataPropertyName = "ID"
        Me.colClinicId.HeaderText = "Mã số"
        Me.colClinicId.Name = "colClinicId"
        Me.colClinicId.ReadOnly = True
        Me.colClinicId.Width = 70
        '
        'colClinicName
        '
        Me.colClinicName.DataPropertyName = "NAME"
        Me.colClinicName.HeaderText = "Tên phòng khám"
        Me.colClinicName.Name = "colClinicName"
        Me.colClinicName.ReadOnly = True
        Me.colClinicName.Width = 140
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
        Me.btnClinic_Edit.TabIndex = 4
        Me.btnClinic_Edit.Text = "&Sửa"
        Me.btnClinic_Edit.UseVisualStyleBackColor = True
        '
        'tboxClinic
        '
        Me.tboxClinic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxClinic.Location = New System.Drawing.Point(115, 29)
        Me.tboxClinic.Name = "tboxClinic"
        Me.tboxClinic.Size = New System.Drawing.Size(180, 21)
        Me.tboxClinic.TabIndex = 1
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
        Me.btnClinic_Add.TabIndex = 2
        Me.btnClinic_Add.Text = "&Thêm"
        Me.btnClinic_Add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên Phòng khám"
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
        Me.btnClinic_Delete.TabIndex = 3
        Me.btnClinic_Delete.Text = "&Xóa"
        Me.btnClinic_Delete.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboxBed_DepartmentsName)
        Me.GroupBox4.Controls.Add(Me.btnBed_Reset)
        Me.GroupBox4.Controls.Add(Me.btnBed_Edit)
        Me.GroupBox4.Controls.Add(Me.btnBed_Add)
        Me.GroupBox4.Controls.Add(Me.btnBed_Delete)
        Me.GroupBox4.Controls.Add(Me.dgvBeds)
        Me.GroupBox4.Controls.Add(Me.tboxBedId)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.tboxBedRoom)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(847, 186)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DANH MỤC GIƯỜNG BỆNH"
        '
        'cboxBed_DepartmentsName
        '
        Me.cboxBed_DepartmentsName.DisplayMember = "Name"
        Me.cboxBed_DepartmentsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBed_DepartmentsName.FormattingEnabled = True
        Me.cboxBed_DepartmentsName.Items.AddRange(New Object() {"Không lựa chọn"})
        Me.cboxBed_DepartmentsName.Location = New System.Drawing.Point(111, 84)
        Me.cboxBed_DepartmentsName.Name = "cboxBed_DepartmentsName"
        Me.cboxBed_DepartmentsName.Size = New System.Drawing.Size(186, 23)
        Me.cboxBed_DepartmentsName.TabIndex = 5
        Me.cboxBed_DepartmentsName.ValueMember = "Id"
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
        Me.btnBed_Reset.TabIndex = 9
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
        Me.btnBed_Edit.TabIndex = 8
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
        Me.btnBed_Add.TabIndex = 6
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
        Me.btnBed_Delete.TabIndex = 7
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
        Me.dgvBeds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBedId, Me.colBedDeptId, Me.colBedRoom, Me.colBedDeptName})
        Me.dgvBeds.Location = New System.Drawing.Point(336, 20)
        Me.dgvBeds.MultiSelect = False
        Me.dgvBeds.Name = "dgvBeds"
        Me.dgvBeds.ReadOnly = True
        Me.dgvBeds.RowHeadersVisible = False
        Me.dgvBeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBeds.Size = New System.Drawing.Size(488, 150)
        Me.dgvBeds.TabIndex = 10
        '
        'colBedId
        '
        Me.colBedId.DataPropertyName = "Id"
        Me.colBedId.HeaderText = "Số giường bệnh"
        Me.colBedId.Name = "colBedId"
        Me.colBedId.ReadOnly = True
        Me.colBedId.Width = 130
        '
        'colBedDeptId
        '
        Me.colBedDeptId.DataPropertyName = "DeptId"
        Me.colBedDeptId.HeaderText = "DeptId"
        Me.colBedDeptId.Name = "colBedDeptId"
        Me.colBedDeptId.ReadOnly = True
        Me.colBedDeptId.Visible = False
        '
        'colBedRoom
        '
        Me.colBedRoom.DataPropertyName = "Room"
        Me.colBedRoom.HeaderText = "Số phòng bệnh"
        Me.colBedRoom.Name = "colBedRoom"
        Me.colBedRoom.ReadOnly = True
        Me.colBedRoom.Width = 130
        '
        'colBedDeptName
        '
        Me.colBedDeptName.DataPropertyName = "DeptName"
        Me.colBedDeptName.HeaderText = "Tên khoa"
        Me.colBedDeptName.Name = "colBedDeptName"
        Me.colBedDeptName.ReadOnly = True
        Me.colBedDeptName.Width = 150
        '
        'tboxBedId
        '
        Me.tboxBedId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tboxBedId.Location = New System.Drawing.Point(111, 30)
        Me.tboxBedId.Name = "tboxBedId"
        Me.tboxBedId.ReadOnly = True
        Me.tboxBedId.Size = New System.Drawing.Size(100, 21)
        Me.tboxBedId.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Số giường bệnh"
        '
        'tboxBedRoom
        '
        Me.tboxBedRoom.Location = New System.Drawing.Point(111, 57)
        Me.tboxBedRoom.Name = "tboxBedRoom"
        Me.tboxBedRoom.Size = New System.Drawing.Size(100, 21)
        Me.tboxBedRoom.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Số phòng bệnh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tên Khoa"
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.Location = New System.Drawing.Point(930, 480)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmCategoryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 518)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategoryManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Quản lý Phòng ban"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvSpecialities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvClinics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvBeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents dgvBeds As DataGridView
    Friend WithEvents tboxBedId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tboxBedRoom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents btnDept_Reset As Button
    Private WithEvents btnSpec_Reset As Button
    Private WithEvents btnSpec_Edit As Button
    Private WithEvents btnSpec_Add As Button
    Private WithEvents btnSpec_Delete As Button
    Private WithEvents btnBed_Reset As Button
    Private WithEvents btnBed_Edit As Button
    Private WithEvents btnBed_Add As Button
    Private WithEvents btnBed_Delete As Button
    Friend WithEvents dgvClinics As DataGridView
    Friend WithEvents cboxDepartment_ChiefName As ComboBox
    Friend WithEvents lblDeptChief As Label
    Friend WithEvents dgvDepartment As DataGridView
    Private WithEvents Button1 As Button
    Friend WithEvents chkbDeptChief As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dgvSpecialities As DataGridView
    Friend WithEvents colDeptName As DataGridViewTextBoxColumn
    Friend WithEvents colDeptChiefId As DataGridViewTextBoxColumn
    Friend WithEvents colDeptChiefName As DataGridViewTextBoxColumn
    Friend WithEvents colDeptEmplCount As DataGridViewTextBoxColumn
    Friend WithEvents colClinicId As DataGridViewTextBoxColumn
    Friend WithEvents colClinicName As DataGridViewTextBoxColumn
    Private WithEvents btnClinic_Reset As Button
    Private WithEvents btnClinic_Edit As Button
    Private WithEvents btnClinic_Add As Button
    Private WithEvents btnClinic_Delete As Button
    Friend WithEvents cboxBed_DepartmentsName As ComboBox
    Friend WithEvents colBedId As DataGridViewTextBoxColumn
    Friend WithEvents colBedDeptId As DataGridViewTextBoxColumn
    Friend WithEvents colBedRoom As DataGridViewTextBoxColumn
    Friend WithEvents colBedDeptName As DataGridViewTextBoxColumn
    Friend WithEvents colSpecName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
