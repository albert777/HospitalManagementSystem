<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffManager))
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch_Empl_Phone = New System.Windows.Forms.TextBox()
        Me.txtSearch_Empl_IDCard = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.cmdReSearch = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtSearch_Empl_Name = New System.Windows.Forms.TextBox()
        Me.txtSearch_Empl_ID = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgrEmplResult = New System.Windows.Forms.DataGridView()
        Me.colEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplSex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplIdCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplDoB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplFolk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLSPEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdUpdateEmpl = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdDeleteCus = New System.Windows.Forms.Button()
        Me.txtEmployeeIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeSpecialized = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmployeePhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmployeeDepartment = New System.Windows.Forms.TextBox()
        Me.dtpEmployeeDoB = New System.Windows.Forms.DateTimePicker()
        Me.txtEmployeePosition = New System.Windows.Forms.TextBox()
        Me.txtEmployeeFolk = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboxEmployeeSex = New System.Windows.Forms.ComboBox()
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.BackgroundImage = CType(resources.GetObject("cmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSearch.Location = New System.Drawing.Point(872, 81)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(98, 23)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "&Tìm kiếm"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch_Empl_Phone
        '
        Me.txtSearch_Empl_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_Phone.Location = New System.Drawing.Point(452, 53)
        Me.txtSearch_Empl_Phone.Name = "txtSearch_Empl_Phone"
        Me.txtSearch_Empl_Phone.Size = New System.Drawing.Size(132, 22)
        Me.txtSearch_Empl_Phone.TabIndex = 7
        '
        'txtSearch_Empl_IDCard
        '
        Me.txtSearch_Empl_IDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_IDCard.Location = New System.Drawing.Point(452, 26)
        Me.txtSearch_Empl_IDCard.Name = "txtSearch_Empl_IDCard"
        Me.txtSearch_Empl_IDCard.Size = New System.Drawing.Size(132, 22)
        Me.txtSearch_Empl_IDCard.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(17, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(107, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Họ tên nhân viên"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(17, 84)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(108, 16)
        Me.label10.TabIndex = 8
        Me.label10.Text = "Địa chỉ nhân viên"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(130, 53)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(227, 22)
        Me.txtEmployeeName.TabIndex = 5
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeId.Location = New System.Drawing.Point(130, 25)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.ReadOnly = True
        Me.txtEmployeeId.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeeId.TabIndex = 4
        '
        'cmdReSearch
        '
        Me.cmdReSearch.BackgroundImage = CType(resources.GetObject("cmdReSearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdReSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdReSearch.Location = New System.Drawing.Point(872, 54)
        Me.cmdReSearch.Name = "cmdReSearch"
        Me.cmdReSearch.Size = New System.Drawing.Size(98, 23)
        Me.cmdReSearch.TabIndex = 9
        Me.cmdReSearch.Text = "&Làm lại"
        Me.cmdReSearch.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(375, 84)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 16)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Điện thoại"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(17, 56)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(107, 16)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Họ tên nhân viên"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(17, 28)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(87, 16)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Mã nhân viên"
        '
        'txtSearch_Empl_Name
        '
        Me.txtSearch_Empl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_Name.Location = New System.Drawing.Point(130, 52)
        Me.txtSearch_Empl_Name.Name = "txtSearch_Empl_Name"
        Me.txtSearch_Empl_Name.Size = New System.Drawing.Size(227, 22)
        Me.txtSearch_Empl_Name.TabIndex = 5
        '
        'txtSearch_Empl_ID
        '
        Me.txtSearch_Empl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_ID.Location = New System.Drawing.Point(130, 24)
        Me.txtSearch_Empl_ID.Name = "txtSearch_Empl_ID"
        Me.txtSearch_Empl_ID.Size = New System.Drawing.Size(132, 22)
        Me.txtSearch_Empl_ID.TabIndex = 4
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(375, 57)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 16)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Điện thoại"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(375, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 2
        Me.label4.Text = "CMND"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(375, 56)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 2
        Me.label7.Text = "CMND"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(17, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Mã nhân viên"
        '
        'dgrEmplResult
        '
        Me.dgrEmplResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgrEmplResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgrEmplResult.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgrEmplResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmplId, Me.colEmplPosition, Me.colEmplName, Me.colEmplSex, Me.colEmplIdCard, Me.colEmplDoB, Me.colEmplAddress, Me.colEmplPhone, Me.colEmplFolk, Me.EMPLSPEC, Me.EMPLDEPT})
        Me.dgrEmplResult.Location = New System.Drawing.Point(12, 156)
        Me.dgrEmplResult.MultiSelect = False
        Me.dgrEmplResult.Name = "dgrEmplResult"
        Me.dgrEmplResult.ReadOnly = True
        Me.dgrEmplResult.RowHeadersVisible = False
        Me.dgrEmplResult.Size = New System.Drawing.Size(976, 249)
        Me.dgrEmplResult.TabIndex = 31
        '
        'colEmplId
        '
        Me.colEmplId.DataPropertyName = "EMPLID"
        Me.colEmplId.Frozen = True
        Me.colEmplId.HeaderText = "Mã nhân viên"
        Me.colEmplId.Name = "colEmplId"
        Me.colEmplId.ReadOnly = True
        Me.colEmplId.Width = 97
        '
        'colEmplPosition
        '
        Me.colEmplPosition.DataPropertyName = "EMPLPOS"
        Me.colEmplPosition.Frozen = True
        Me.colEmplPosition.HeaderText = "Chức danh"
        Me.colEmplPosition.Name = "colEmplPosition"
        Me.colEmplPosition.ReadOnly = True
        Me.colEmplPosition.Width = 84
        '
        'colEmplName
        '
        Me.colEmplName.DataPropertyName = "EMPLNAME"
        Me.colEmplName.Frozen = True
        Me.colEmplName.HeaderText = "Họ tên"
        Me.colEmplName.Name = "colEmplName"
        Me.colEmplName.ReadOnly = True
        Me.colEmplName.Width = 64
        '
        'colEmplSex
        '
        Me.colEmplSex.DataPropertyName = "EMPLSEX"
        Me.colEmplSex.Frozen = True
        Me.colEmplSex.HeaderText = "Giới tính"
        Me.colEmplSex.Name = "colEmplSex"
        Me.colEmplSex.ReadOnly = True
        Me.colEmplSex.Width = 72
        '
        'colEmplIdCard
        '
        Me.colEmplIdCard.DataPropertyName = "EMPLIDCARD"
        Me.colEmplIdCard.Frozen = True
        Me.colEmplIdCard.HeaderText = "Số CMND"
        Me.colEmplIdCard.Name = "colEmplIdCard"
        Me.colEmplIdCard.ReadOnly = True
        Me.colEmplIdCard.Width = 80
        '
        'colEmplDoB
        '
        Me.colEmplDoB.DataPropertyName = "EMPL_DOB"
        Me.colEmplDoB.Frozen = True
        Me.colEmplDoB.HeaderText = "Ngày sinh"
        Me.colEmplDoB.Name = "colEmplDoB"
        Me.colEmplDoB.ReadOnly = True
        Me.colEmplDoB.Width = 79
        '
        'colEmplAddress
        '
        Me.colEmplAddress.DataPropertyName = "EMPLADD"
        Me.colEmplAddress.Frozen = True
        Me.colEmplAddress.HeaderText = "Địa chỉ"
        Me.colEmplAddress.Name = "colEmplAddress"
        Me.colEmplAddress.ReadOnly = True
        Me.colEmplAddress.Width = 65
        '
        'colEmplPhone
        '
        Me.colEmplPhone.DataPropertyName = "EMPLPHONE"
        Me.colEmplPhone.Frozen = True
        Me.colEmplPhone.HeaderText = "Điện thoại"
        Me.colEmplPhone.Name = "colEmplPhone"
        Me.colEmplPhone.ReadOnly = True
        Me.colEmplPhone.Width = 80
        '
        'colEmplFolk
        '
        Me.colEmplFolk.DataPropertyName = "EMPLFOLK"
        Me.colEmplFolk.Frozen = True
        Me.colEmplFolk.HeaderText = "Dân tộc"
        Me.colEmplFolk.Name = "colEmplFolk"
        Me.colEmplFolk.ReadOnly = True
        Me.colEmplFolk.Width = 70
        '
        'EMPLSPEC
        '
        Me.EMPLSPEC.DataPropertyName = "EMPLSPEC"
        Me.EMPLSPEC.Frozen = True
        Me.EMPLSPEC.HeaderText = "Khoa"
        Me.EMPLSPEC.Name = "EMPLSPEC"
        Me.EMPLSPEC.ReadOnly = True
        Me.EMPLSPEC.Width = 57
        '
        'EMPLDEPT
        '
        Me.EMPLDEPT.DataPropertyName = "EMPLDEPT"
        Me.EMPLDEPT.Frozen = True
        Me.EMPLDEPT.HeaderText = "Chuyên ngành"
        Me.EMPLDEPT.Name = "EMPLDEPT"
        Me.EMPLDEPT.ReadOnly = True
        Me.EMPLDEPT.Width = 101
        '
        'cmdUpdateEmpl
        '
        Me.cmdUpdateEmpl.BackgroundImage = CType(resources.GetObject("cmdUpdateEmpl.BackgroundImage"), System.Drawing.Image)
        Me.cmdUpdateEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdateEmpl.Location = New System.Drawing.Point(884, 488)
        Me.cmdUpdateEmpl.Name = "cmdUpdateEmpl"
        Me.cmdUpdateEmpl.Size = New System.Drawing.Size(98, 23)
        Me.cmdUpdateEmpl.TabIndex = 29
        Me.cmdUpdateEmpl.Text = "&Sửa"
        Me.cmdUpdateEmpl.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(884, 517)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(98, 23)
        Me.cmdClose.TabIndex = 30
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackgroundImage = CType(resources.GetObject("cmdCustomer.BackgroundImage"), System.Drawing.Image)
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCustomer.Location = New System.Drawing.Point(884, 430)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(98, 23)
        Me.cmdCustomer.TabIndex = 27
        Me.cmdCustomer.Text = "&Thêm nhân viên"
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdDeleteCus
        '
        Me.cmdDeleteCus.BackgroundImage = CType(resources.GetObject("cmdDeleteCus.BackgroundImage"), System.Drawing.Image)
        Me.cmdDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDeleteCus.Location = New System.Drawing.Point(884, 459)
        Me.cmdDeleteCus.Name = "cmdDeleteCus"
        Me.cmdDeleteCus.Size = New System.Drawing.Size(98, 23)
        Me.cmdDeleteCus.TabIndex = 28
        Me.cmdDeleteCus.Text = "&Xóa"
        Me.cmdDeleteCus.UseVisualStyleBackColor = True
        '
        'txtEmployeeIdCard
        '
        Me.txtEmployeeIdCard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeIdCard.Location = New System.Drawing.Point(452, 53)
        Me.txtEmployeeIdCard.Mask = "000000000"
        Me.txtEmployeeIdCard.Name = "txtEmployeeIdCard"
        Me.txtEmployeeIdCard.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeeIdCard.TabIndex = 63
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cboxEmployeeSex)
        Me.groupBox2.Controls.Add(Me.txtEmployeeSpecialized)
        Me.groupBox2.Controls.Add(Me.Label3)
        Me.groupBox2.Controls.Add(Me.Label16)
        Me.groupBox2.Controls.Add(Me.txtEmployeePhone)
        Me.groupBox2.Controls.Add(Me.txtEmployeeIdCard)
        Me.groupBox2.Controls.Add(Me.txtEmployeeDepartment)
        Me.groupBox2.Controls.Add(Me.dtpEmployeeDoB)
        Me.groupBox2.Controls.Add(Me.txtEmployeePosition)
        Me.groupBox2.Controls.Add(Me.txtEmployeeFolk)
        Me.groupBox2.Controls.Add(Me.Label17)
        Me.groupBox2.Controls.Add(Me.txtEmployeeAddress)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.Label18)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.txtEmployeeName)
        Me.groupBox2.Controls.Add(Me.txtEmployeeId)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 411)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(866, 139)
        Me.groupBox2.TabIndex = 26
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Thông tin nhân viên"
        '
        'txtEmployeeSpecialized
        '
        Me.txtEmployeeSpecialized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeSpecialized.Location = New System.Drawing.Point(701, 109)
        Me.txtEmployeeSpecialized.Name = "txtEmployeeSpecialized"
        Me.txtEmployeeSpecialized.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeeSpecialized.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Giới tính"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(602, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 16)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Chuyên ngành"
        '
        'txtEmployeePhone
        '
        Me.txtEmployeePhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeePhone.Location = New System.Drawing.Point(452, 81)
        Me.txtEmployeePhone.Mask = "00000000000"
        Me.txtEmployeePhone.Name = "txtEmployeePhone"
        Me.txtEmployeePhone.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeePhone.TabIndex = 64
        '
        'txtEmployeeDepartment
        '
        Me.txtEmployeeDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeDepartment.Location = New System.Drawing.Point(452, 109)
        Me.txtEmployeeDepartment.Name = "txtEmployeeDepartment"
        Me.txtEmployeeDepartment.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeeDepartment.TabIndex = 19
        '
        'dtpEmployeeDoB
        '
        Me.dtpEmployeeDoB.CustomFormat = "dd/MM/yyyy"
        Me.dtpEmployeeDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEmployeeDoB.Location = New System.Drawing.Point(701, 53)
        Me.dtpEmployeeDoB.Name = "dtpEmployeeDoB"
        Me.dtpEmployeeDoB.Size = New System.Drawing.Size(132, 22)
        Me.dtpEmployeeDoB.TabIndex = 21
        '
        'txtEmployeePosition
        '
        Me.txtEmployeePosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeePosition.Location = New System.Drawing.Point(130, 109)
        Me.txtEmployeePosition.Name = "txtEmployeePosition"
        Me.txtEmployeePosition.Size = New System.Drawing.Size(227, 22)
        Me.txtEmployeePosition.TabIndex = 18
        '
        'txtEmployeeFolk
        '
        Me.txtEmployeeFolk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeFolk.Location = New System.Drawing.Point(701, 25)
        Me.txtEmployeeFolk.Name = "txtEmployeeFolk"
        Me.txtEmployeeFolk.Size = New System.Drawing.Size(132, 22)
        Me.txtEmployeeFolk.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(375, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Khoa"
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(130, 81)
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(227, 22)
        Me.txtEmployeeAddress.TabIndex = 12
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(602, 28)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(54, 16)
        Me.label12.TabIndex = 10
        Me.label12.Text = "Dân tộc"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Chức danh"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(602, 56)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(68, 16)
        Me.label11.TabIndex = 9
        Me.label11.Text = "Ngày sinh"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.TextBox4)
        Me.groupBox1.Controls.Add(Me.Label15)
        Me.groupBox1.Controls.Add(Me.TextBox2)
        Me.groupBox1.Controls.Add(Me.TextBox3)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Controls.Add(Me.Label14)
        Me.groupBox1.Controls.Add(Me.cmdReSearch)
        Me.groupBox1.Controls.Add(Me.cmdSearch)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_Phone)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_IDCard)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_Name)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_ID)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 40)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(976, 110)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tiêu chí tìm kiếm"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(701, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(602, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Chuyên ngành"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(452, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(130, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 22)
        Me.TextBox3.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(375, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Khoa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Chức danh"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(329, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 21)
        Me.lblTitle.TabIndex = 24
        Me.lblTitle.Text = "QUẢN LÝ DANH SÁCH NHÂN VIÊN"
        '
        'cboxEmployeeSex
        '
        Me.cboxEmployeeSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmployeeSex.FormattingEnabled = True
        Me.cboxEmployeeSex.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cboxEmployeeSex.Location = New System.Drawing.Point(452, 25)
        Me.cboxEmployeeSex.Name = "cboxEmployeeSex"
        Me.cboxEmployeeSex.Size = New System.Drawing.Size(132, 24)
        Me.cboxEmployeeSex.TabIndex = 66
        '
        'frmRecordsSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 560)
        Me.Controls.Add(Me.dgrEmplResult)
        Me.Controls.Add(Me.cmdUpdateEmpl)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdDeleteCus)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRecordsSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmRecordsSystem"
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdSearch As Button
    Private WithEvents txtSearch_Empl_Phone As TextBox
    Private WithEvents txtSearch_Empl_IDCard As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label10 As Label
    Private WithEvents txtEmployeeName As TextBox
    Private WithEvents txtEmployeeId As TextBox
    Private WithEvents cmdReSearch As Button
    Private WithEvents label6 As Label
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents txtSearch_Empl_Name As TextBox
    Private WithEvents txtSearch_Empl_ID As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label7 As Label
    Private WithEvents label1 As Label
    Private WithEvents dgrEmplResult As DataGridView
    Private WithEvents cmdUpdateEmpl As Button
    Private WithEvents cmdClose As Button
    Private WithEvents cmdCustomer As Button
    Private WithEvents cmdDeleteCus As Button
    Private WithEvents txtEmployeeIdCard As MaskedTextBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtEmployeePhone As MaskedTextBox
    Private WithEvents dtpEmployeeDoB As DateTimePicker
    Private WithEvents txtEmployeeFolk As TextBox
    Private WithEvents txtEmployeeAddress As TextBox
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblTitle As Label
    Private WithEvents Label3 As Label
    Private WithEvents TextBox4 As TextBox
    Private WithEvents Label15 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Private WithEvents txtEmployeeSpecialized As TextBox
    Private WithEvents Label16 As Label
    Private WithEvents txtEmployeeDepartment As TextBox
    Private WithEvents txtEmployeePosition As TextBox
    Private WithEvents Label17 As Label
    Private WithEvents Label18 As Label
    Friend WithEvents colEmplId As DataGridViewTextBoxColumn
    Friend WithEvents colEmplPosition As DataGridViewTextBoxColumn
    Friend WithEvents colEmplName As DataGridViewTextBoxColumn
    Friend WithEvents colEmplSex As DataGridViewTextBoxColumn
    Friend WithEvents colEmplIdCard As DataGridViewTextBoxColumn
    Friend WithEvents colEmplDoB As DataGridViewTextBoxColumn
    Friend WithEvents colEmplAddress As DataGridViewTextBoxColumn
    Friend WithEvents colEmplPhone As DataGridViewTextBoxColumn
    Friend WithEvents colEmplFolk As DataGridViewTextBoxColumn
    Friend WithEvents EMPLSPEC As DataGridViewTextBoxColumn
    Friend WithEvents EMPLDEPT As DataGridViewTextBoxColumn
    Friend WithEvents cboxEmployeeSex As ComboBox
End Class
