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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtSearch_Empl_Name = New System.Windows.Forms.TextBox()
        Me.txtSearch_Empl_ID = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgrEmplResult = New System.Windows.Forms.DataGridView()
        Me.colEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplBasicSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplSubsidy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplDeptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplSpecId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colchkboxEmplSex = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colEmplIdCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplDoB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplFolk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplSpecName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplHireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplRatio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEmployeeIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboxEmployeeSex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployeePhone = New System.Windows.Forms.MaskedTextBox()
        Me.dtpEmployeeDoB = New System.Windows.Forms.DateTimePicker()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtEmployeeFolk = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.cboxEmployeeSpeciality = New System.Windows.Forms.ComboBox()
        Me.cboxEmployeeDepartment = New System.Windows.Forms.ComboBox()
        Me.dtpEmployeeHireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEmployeeRatio = New System.Windows.Forms.TextBox()
        Me.txtEmployee = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblSpec = New System.Windows.Forms.Label()
        Me.txtEmployeePosition = New System.Windows.Forms.TextBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch_Empl_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.txtSearch_Empl_IDCard = New System.Windows.Forms.MaskedTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxSearchSpecialities = New System.Windows.Forms.ComboBox()
        Me.cboxSearchDepartments = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnReSearch = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdateEmpl = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnAddEmpl = New System.Windows.Forms.Button()
        Me.btnDeleteEmpl = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkbSpec = New System.Windows.Forms.CheckBox()
        Me.chkbDept = New System.Windows.Forms.CheckBox()
        Me.txtEmployeeTotalSalary = New System.Windows.Forms.TextBox()
        Me.txtEmployeeSubsidy = New System.Windows.Forms.TextBox()
        Me.txtEmployeeBasicSalary = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Enabled = False
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(245, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Họ tên "
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(17, 86)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(48, 16)
        Me.label10.TabIndex = 12
        Me.label10.Text = "Địa chỉ"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(319, 25)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(297, 22)
        Me.txtEmployeeName.TabIndex = 7
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeId.Location = New System.Drawing.Point(110, 25)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.ReadOnly = True
        Me.txtEmployeeId.Size = New System.Drawing.Size(103, 22)
        Me.txtEmployeeId.TabIndex = 1
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(432, 58)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 16)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Điện thoại"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(245, 28)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 16)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Họ tên "
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
        Me.txtSearch_Empl_Name.Enabled = False
        Me.txtSearch_Empl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_Name.Location = New System.Drawing.Point(319, 24)
        Me.txtSearch_Empl_Name.Name = "txtSearch_Empl_Name"
        Me.txtSearch_Empl_Name.Size = New System.Drawing.Size(297, 22)
        Me.txtSearch_Empl_Name.TabIndex = 5
        '
        'txtSearch_Empl_ID
        '
        Me.txtSearch_Empl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_ID.Location = New System.Drawing.Point(110, 24)
        Me.txtSearch_Empl_ID.Name = "txtSearch_Empl_ID"
        Me.txtSearch_Empl_ID.Size = New System.Drawing.Size(103, 22)
        Me.txtSearch_Empl_ID.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(245, 58)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 8
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
        Me.dgrEmplResult.AllowUserToAddRows = False
        Me.dgrEmplResult.AllowUserToDeleteRows = False
        Me.dgrEmplResult.AllowUserToResizeColumns = False
        Me.dgrEmplResult.AllowUserToResizeRows = False
        Me.dgrEmplResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgrEmplResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgrEmplResult.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgrEmplResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmplId, Me.colEmplBasicSalary, Me.colEmplSubsidy, Me.colEmplDeptId, Me.colEmplSpecId, Me.colEmplName, Me.colEmplPosition, Me.colchkboxEmplSex, Me.colEmplIdCard, Me.colEmplDoB, Me.colEmplAddress, Me.colEmplPhone, Me.colEmplFolk, Me.colEmplDeptName, Me.colEmplSpecName, Me.colEmplHireDate, Me.colEmplRatio})
        Me.dgrEmplResult.Location = New System.Drawing.Point(12, 156)
        Me.dgrEmplResult.MultiSelect = False
        Me.dgrEmplResult.Name = "dgrEmplResult"
        Me.dgrEmplResult.ReadOnly = True
        Me.dgrEmplResult.RowHeadersVisible = False
        Me.dgrEmplResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgrEmplResult.Size = New System.Drawing.Size(948, 166)
        Me.dgrEmplResult.TabIndex = 2
        '
        'colEmplId
        '
        Me.colEmplId.DataPropertyName = "Id"
        Me.colEmplId.Frozen = True
        Me.colEmplId.HeaderText = "Mã nhân viên"
        Me.colEmplId.Name = "colEmplId"
        Me.colEmplId.ReadOnly = True
        Me.colEmplId.Width = 97
        '
        'colEmplBasicSalary
        '
        Me.colEmplBasicSalary.DataPropertyName = "BasicSalary"
        Me.colEmplBasicSalary.Frozen = True
        Me.colEmplBasicSalary.HeaderText = "Lương cơ bản"
        Me.colEmplBasicSalary.Name = "colEmplBasicSalary"
        Me.colEmplBasicSalary.ReadOnly = True
        Me.colEmplBasicSalary.Visible = False
        Me.colEmplBasicSalary.Width = 98
        '
        'colEmplSubsidy
        '
        Me.colEmplSubsidy.DataPropertyName = "Subsidy"
        Me.colEmplSubsidy.Frozen = True
        Me.colEmplSubsidy.HeaderText = "Phụ cấp"
        Me.colEmplSubsidy.Name = "colEmplSubsidy"
        Me.colEmplSubsidy.ReadOnly = True
        Me.colEmplSubsidy.Visible = False
        Me.colEmplSubsidy.Width = 72
        '
        'colEmplDeptId
        '
        Me.colEmplDeptId.DataPropertyName = "DeptId"
        Me.colEmplDeptId.Frozen = True
        Me.colEmplDeptId.HeaderText = "Mã Khoa"
        Me.colEmplDeptId.Name = "colEmplDeptId"
        Me.colEmplDeptId.ReadOnly = True
        Me.colEmplDeptId.Visible = False
        Me.colEmplDeptId.Width = 75
        '
        'colEmplSpecId
        '
        Me.colEmplSpecId.DataPropertyName = "SpecId"
        Me.colEmplSpecId.Frozen = True
        Me.colEmplSpecId.HeaderText = "Mã Chuyên môn"
        Me.colEmplSpecId.Name = "colEmplSpecId"
        Me.colEmplSpecId.ReadOnly = True
        Me.colEmplSpecId.Visible = False
        Me.colEmplSpecId.Width = 109
        '
        'colEmplName
        '
        Me.colEmplName.DataPropertyName = "Name"
        Me.colEmplName.Frozen = True
        Me.colEmplName.HeaderText = "Họ tên"
        Me.colEmplName.Name = "colEmplName"
        Me.colEmplName.ReadOnly = True
        Me.colEmplName.Width = 64
        '
        'colEmplPosition
        '
        Me.colEmplPosition.DataPropertyName = "Position"
        Me.colEmplPosition.Frozen = True
        Me.colEmplPosition.HeaderText = "Vị trí"
        Me.colEmplPosition.Name = "colEmplPosition"
        Me.colEmplPosition.ReadOnly = True
        Me.colEmplPosition.Width = 54
        '
        'colchkboxEmplSex
        '
        Me.colchkboxEmplSex.DataPropertyName = "Sex"
        Me.colchkboxEmplSex.FalseValue = "Nam"
        Me.colchkboxEmplSex.Frozen = True
        Me.colchkboxEmplSex.HeaderText = "Giới tính"
        Me.colchkboxEmplSex.Name = "colchkboxEmplSex"
        Me.colchkboxEmplSex.ReadOnly = True
        Me.colchkboxEmplSex.TrueValue = "Nữ"
        Me.colchkboxEmplSex.Width = 53
        '
        'colEmplIdCard
        '
        Me.colEmplIdCard.DataPropertyName = "IdCard"
        Me.colEmplIdCard.Frozen = True
        Me.colEmplIdCard.HeaderText = "Số CMND"
        Me.colEmplIdCard.Name = "colEmplIdCard"
        Me.colEmplIdCard.ReadOnly = True
        Me.colEmplIdCard.Width = 80
        '
        'colEmplDoB
        '
        Me.colEmplDoB.DataPropertyName = "DoB"
        Me.colEmplDoB.Frozen = True
        Me.colEmplDoB.HeaderText = "Ngày sinh"
        Me.colEmplDoB.Name = "colEmplDoB"
        Me.colEmplDoB.ReadOnly = True
        Me.colEmplDoB.Width = 79
        '
        'colEmplAddress
        '
        Me.colEmplAddress.DataPropertyName = "Address"
        Me.colEmplAddress.Frozen = True
        Me.colEmplAddress.HeaderText = "Địa chỉ"
        Me.colEmplAddress.Name = "colEmplAddress"
        Me.colEmplAddress.ReadOnly = True
        Me.colEmplAddress.Visible = False
        Me.colEmplAddress.Width = 65
        '
        'colEmplPhone
        '
        Me.colEmplPhone.DataPropertyName = "Phone"
        Me.colEmplPhone.Frozen = True
        Me.colEmplPhone.HeaderText = "Điện thoại"
        Me.colEmplPhone.Name = "colEmplPhone"
        Me.colEmplPhone.ReadOnly = True
        Me.colEmplPhone.Width = 80
        '
        'colEmplFolk
        '
        Me.colEmplFolk.DataPropertyName = "Folk"
        Me.colEmplFolk.Frozen = True
        Me.colEmplFolk.HeaderText = "Dân tộc"
        Me.colEmplFolk.Name = "colEmplFolk"
        Me.colEmplFolk.ReadOnly = True
        Me.colEmplFolk.Visible = False
        Me.colEmplFolk.Width = 70
        '
        'colEmplDeptName
        '
        Me.colEmplDeptName.DataPropertyName = "DeptName"
        Me.colEmplDeptName.Frozen = True
        Me.colEmplDeptName.HeaderText = "Khoa"
        Me.colEmplDeptName.Name = "colEmplDeptName"
        Me.colEmplDeptName.ReadOnly = True
        Me.colEmplDeptName.Width = 57
        '
        'colEmplSpecName
        '
        Me.colEmplSpecName.DataPropertyName = "SpecName"
        Me.colEmplSpecName.Frozen = True
        Me.colEmplSpecName.HeaderText = "Chuyên môn"
        Me.colEmplSpecName.Name = "colEmplSpecName"
        Me.colEmplSpecName.ReadOnly = True
        Me.colEmplSpecName.Width = 91
        '
        'colEmplHireDate
        '
        Me.colEmplHireDate.DataPropertyName = "HireDate"
        Me.colEmplHireDate.HeaderText = "Ngày thuê"
        Me.colEmplHireDate.Name = "colEmplHireDate"
        Me.colEmplHireDate.ReadOnly = True
        Me.colEmplHireDate.Visible = False
        Me.colEmplHireDate.Width = 81
        '
        'colEmplRatio
        '
        Me.colEmplRatio.DataPropertyName = "Ratio"
        Me.colEmplRatio.HeaderText = "Bậc lương"
        Me.colEmplRatio.Name = "colEmplRatio"
        Me.colEmplRatio.ReadOnly = True
        Me.colEmplRatio.Visible = False
        Me.colEmplRatio.Width = 80
        '
        'txtEmployeeIdCard
        '
        Me.txtEmployeeIdCard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeIdCard.Location = New System.Drawing.Point(319, 55)
        Me.txtEmployeeIdCard.Mask = "000000000"
        Me.txtEmployeeIdCard.Name = "txtEmployeeIdCard"
        Me.txtEmployeeIdCard.Size = New System.Drawing.Size(88, 22)
        Me.txtEmployeeIdCard.TabIndex = 9
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Label28)
        Me.groupBox2.Controls.Add(Me.Label27)
        Me.groupBox2.Controls.Add(Me.Label26)
        Me.groupBox2.Controls.Add(Me.Label24)
        Me.groupBox2.Controls.Add(Me.Label23)
        Me.groupBox2.Controls.Add(Me.cboxEmployeeSex)
        Me.groupBox2.Controls.Add(Me.Label3)
        Me.groupBox2.Controls.Add(Me.txtEmployeePhone)
        Me.groupBox2.Controls.Add(Me.txtEmployeeIdCard)
        Me.groupBox2.Controls.Add(Me.dtpEmployeeDoB)
        Me.groupBox2.Controls.Add(Me.txtEmployeeAddress)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.txtEmployeeName)
        Me.groupBox2.Controls.Add(Me.txtEmployeeId)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.txtEmployeeFolk)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 328)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(844, 118)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Thông tin cá nhân"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(85, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 17)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(85, 58)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 17)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "*"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(692, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 17)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(289, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 17)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(289, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 17)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "*"
        '
        'cboxEmployeeSex
        '
        Me.cboxEmployeeSex.DisplayMember = "Name"
        Me.cboxEmployeeSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmployeeSex.FormattingEnabled = True
        Me.cboxEmployeeSex.Location = New System.Drawing.Point(727, 23)
        Me.cboxEmployeeSex.Name = "cboxEmployeeSex"
        Me.cboxEmployeeSex.Size = New System.Drawing.Size(100, 24)
        Me.cboxEmployeeSex.TabIndex = 3
        Me.cboxEmployeeSex.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(641, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giới tính"
        '
        'txtEmployeePhone
        '
        Me.txtEmployeePhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeePhone.Location = New System.Drawing.Point(520, 55)
        Me.txtEmployeePhone.Mask = "00000000000"
        Me.txtEmployeePhone.Name = "txtEmployeePhone"
        Me.txtEmployeePhone.Size = New System.Drawing.Size(96, 22)
        Me.txtEmployeePhone.TabIndex = 15
        '
        'dtpEmployeeDoB
        '
        Me.dtpEmployeeDoB.CustomFormat = "dd/MM/yyyy"
        Me.dtpEmployeeDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEmployeeDoB.Location = New System.Drawing.Point(110, 53)
        Me.dtpEmployeeDoB.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtpEmployeeDoB.Name = "dtpEmployeeDoB"
        Me.dtpEmployeeDoB.Size = New System.Drawing.Size(103, 22)
        Me.dtpEmployeeDoB.TabIndex = 11
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(110, 83)
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(717, 22)
        Me.txtEmployeeAddress.TabIndex = 13
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(17, 58)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(68, 16)
        Me.label11.TabIndex = 10
        Me.label11.Text = "Ngày sinh"
        '
        'txtEmployeeFolk
        '
        Me.txtEmployeeFolk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeFolk.Location = New System.Drawing.Point(727, 53)
        Me.txtEmployeeFolk.Name = "txtEmployeeFolk"
        Me.txtEmployeeFolk.Size = New System.Drawing.Size(100, 22)
        Me.txtEmployeeFolk.TabIndex = 5
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(641, 56)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(54, 16)
        Me.label12.TabIndex = 4
        Me.label12.Text = "Dân tộc"
        '
        'cboxEmployeeSpeciality
        '
        Me.cboxEmployeeSpeciality.DisplayMember = "Name"
        Me.cboxEmployeeSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmployeeSpeciality.Enabled = False
        Me.cboxEmployeeSpeciality.FormattingEnabled = True
        Me.cboxEmployeeSpeciality.Location = New System.Drawing.Point(110, 53)
        Me.cboxEmployeeSpeciality.Name = "cboxEmployeeSpeciality"
        Me.cboxEmployeeSpeciality.Size = New System.Drawing.Size(297, 24)
        Me.cboxEmployeeSpeciality.TabIndex = 30
        Me.cboxEmployeeSpeciality.ValueMember = "Id"
        '
        'cboxEmployeeDepartment
        '
        Me.cboxEmployeeDepartment.DisplayMember = "Name"
        Me.cboxEmployeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmployeeDepartment.Enabled = False
        Me.cboxEmployeeDepartment.FormattingEnabled = True
        Me.cboxEmployeeDepartment.Location = New System.Drawing.Point(520, 53)
        Me.cboxEmployeeDepartment.Name = "cboxEmployeeDepartment"
        Me.cboxEmployeeDepartment.Size = New System.Drawing.Size(307, 24)
        Me.cboxEmployeeDepartment.TabIndex = 29
        Me.cboxEmployeeDepartment.ValueMember = "Id"
        '
        'dtpEmployeeHireDate
        '
        Me.dtpEmployeeHireDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEmployeeHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEmployeeHireDate.Location = New System.Drawing.Point(110, 25)
        Me.dtpEmployeeHireDate.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtpEmployeeHireDate.Name = "dtpEmployeeHireDate"
        Me.dtpEmployeeHireDate.Size = New System.Drawing.Size(103, 22)
        Me.dtpEmployeeHireDate.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Ngày vào "
        '
        'txtEmployeeRatio
        '
        Me.txtEmployeeRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeRatio.Location = New System.Drawing.Point(319, 83)
        Me.txtEmployeeRatio.Name = "txtEmployeeRatio"
        Me.txtEmployeeRatio.Size = New System.Drawing.Size(88, 22)
        Me.txtEmployeeRatio.TabIndex = 23
        '
        'txtEmployee
        '
        Me.txtEmployee.AutoSize = True
        Me.txtEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(245, 86)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(44, 16)
        Me.txtEmployee.TabIndex = 22
        Me.txtEmployee.Text = "Hệ số"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(432, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 16)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Phụ cấp"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 86)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Lương CB"
        '
        'lblSpec
        '
        Me.lblSpec.AutoSize = True
        Me.lblSpec.Enabled = False
        Me.lblSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpec.Location = New System.Drawing.Point(35, 56)
        Me.lblSpec.Name = "lblSpec"
        Me.lblSpec.Size = New System.Drawing.Size(56, 16)
        Me.lblSpec.TabIndex = 28
        Me.lblSpec.Text = "Ch. môn"
        '
        'txtEmployeePosition
        '
        Me.txtEmployeePosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeePosition.Location = New System.Drawing.Point(319, 25)
        Me.txtEmployeePosition.Name = "txtEmployeePosition"
        Me.txtEmployeePosition.Size = New System.Drawing.Size(297, 22)
        Me.txtEmployeePosition.TabIndex = 25
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Enabled = False
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(456, 56)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(39, 16)
        Me.lblDept.TabIndex = 26
        Me.lblDept.Text = "Khoa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(245, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Vị trí"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_Phone)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_IDCard)
        Me.groupBox1.Controls.Add(Me.Label33)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.cboxSearchSpecialities)
        Me.groupBox1.Controls.Add(Me.cboxSearchDepartments)
        Me.groupBox1.Controls.Add(Me.Label13)
        Me.groupBox1.Controls.Add(Me.Label15)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_Name)
        Me.groupBox1.Controls.Add(Me.txtSearch_Empl_ID)
        Me.groupBox1.Controls.Add(Me.TextBox3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.Label14)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 40)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(844, 110)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tiêu chí tìm kiếm"
        '
        'txtSearch_Empl_Phone
        '
        Me.txtSearch_Empl_Phone.Enabled = False
        Me.txtSearch_Empl_Phone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_Phone.Location = New System.Drawing.Point(319, 50)
        Me.txtSearch_Empl_Phone.Mask = "00000000000"
        Me.txtSearch_Empl_Phone.Name = "txtSearch_Empl_Phone"
        Me.txtSearch_Empl_Phone.Size = New System.Drawing.Size(88, 22)
        Me.txtSearch_Empl_Phone.TabIndex = 37
        '
        'txtSearch_Empl_IDCard
        '
        Me.txtSearch_Empl_IDCard.Enabled = False
        Me.txtSearch_Empl_IDCard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Empl_IDCard.Location = New System.Drawing.Point(110, 51)
        Me.txtSearch_Empl_IDCard.Mask = "000000000"
        Me.txtSearch_Empl_IDCard.Name = "txtSearch_Empl_IDCard"
        Me.txtSearch_Empl_IDCard.Size = New System.Drawing.Size(103, 22)
        Me.txtSearch_Empl_IDCard.TabIndex = 37
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Enabled = False
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(17, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 16)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "CMND"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Điện thoại"
        '
        'cboxSearchSpecialities
        '
        Me.cboxSearchSpecialities.DisplayMember = "Name"
        Me.cboxSearchSpecialities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSearchSpecialities.Enabled = False
        Me.cboxSearchSpecialities.FormattingEnabled = True
        Me.cboxSearchSpecialities.Location = New System.Drawing.Point(520, 78)
        Me.cboxSearchSpecialities.Name = "cboxSearchSpecialities"
        Me.cboxSearchSpecialities.Size = New System.Drawing.Size(307, 24)
        Me.cboxSearchSpecialities.TabIndex = 34
        Me.cboxSearchSpecialities.ValueMember = "Id"
        '
        'cboxSearchDepartments
        '
        Me.cboxSearchDepartments.DisplayMember = "Name"
        Me.cboxSearchDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSearchDepartments.Enabled = False
        Me.cboxSearchDepartments.FormattingEnabled = True
        Me.cboxSearchDepartments.Location = New System.Drawing.Point(110, 78)
        Me.cboxSearchDepartments.Name = "cboxSearchDepartments"
        Me.cboxSearchDepartments.Size = New System.Drawing.Size(297, 24)
        Me.cboxSearchDepartments.TabIndex = 33
        Me.cboxSearchDepartments.ValueMember = "Id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(432, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Chuyên môn"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Khoa"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(520, 50)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(307, 22)
        Me.TextBox3.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(432, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Vị trí"
        '
        'btnReSearch
        '
        Me.btnReSearch.BackgroundImage = CType(resources.GetObject("btnReSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnReSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReSearch.Location = New System.Drawing.Point(862, 91)
        Me.btnReSearch.Name = "btnReSearch"
        Me.btnReSearch.Size = New System.Drawing.Size(98, 23)
        Me.btnReSearch.TabIndex = 14
        Me.btnReSearch.Text = "&Làm lại"
        Me.btnReSearch.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(862, 118)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "&Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(349, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "QUẢN LÝ DANH SÁCH NHÂN VIÊN"
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(862, 427)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Làm &mới"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdateEmpl
        '
        Me.btnUpdateEmpl.BackgroundImage = CType(resources.GetObject("btnUpdateEmpl.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdateEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateEmpl.Location = New System.Drawing.Point(862, 398)
        Me.btnUpdateEmpl.Name = "btnUpdateEmpl"
        Me.btnUpdateEmpl.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdateEmpl.TabIndex = 6
        Me.btnUpdateEmpl.Text = "&Sửa"
        Me.btnUpdateEmpl.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(862, 534)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(98, 23)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'btnAddEmpl
        '
        Me.btnAddEmpl.BackgroundImage = CType(resources.GetObject("btnAddEmpl.BackgroundImage"), System.Drawing.Image)
        Me.btnAddEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddEmpl.Location = New System.Drawing.Point(862, 340)
        Me.btnAddEmpl.Name = "btnAddEmpl"
        Me.btnAddEmpl.Size = New System.Drawing.Size(98, 23)
        Me.btnAddEmpl.TabIndex = 4
        Me.btnAddEmpl.Text = "&Thêm nhân viên"
        Me.btnAddEmpl.UseVisualStyleBackColor = True
        '
        'btnDeleteEmpl
        '
        Me.btnDeleteEmpl.BackgroundImage = CType(resources.GetObject("btnDeleteEmpl.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteEmpl.Location = New System.Drawing.Point(862, 369)
        Me.btnDeleteEmpl.Name = "btnDeleteEmpl"
        Me.btnDeleteEmpl.Size = New System.Drawing.Size(98, 23)
        Me.btnDeleteEmpl.TabIndex = 5
        Me.btnDeleteEmpl.Text = "&Xóa"
        Me.btnDeleteEmpl.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkbSpec)
        Me.GroupBox3.Controls.Add(Me.chkbDept)
        Me.GroupBox3.Controls.Add(Me.txtEmployeeTotalSalary)
        Me.GroupBox3.Controls.Add(Me.txtEmployeeSubsidy)
        Me.GroupBox3.Controls.Add(Me.txtEmployeeBasicSalary)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.cboxEmployeeSpeciality)
        Me.GroupBox3.Controls.Add(Me.cboxEmployeeDepartment)
        Me.GroupBox3.Controls.Add(Me.dtpEmployeeHireDate)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.lblSpec)
        Me.GroupBox3.Controls.Add(Me.lblDept)
        Me.GroupBox3.Controls.Add(Me.txtEmployeeRatio)
        Me.GroupBox3.Controls.Add(Me.txtEmployeePosition)
        Me.GroupBox3.Controls.Add(Me.txtEmployee)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(844, 116)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin công việc"
        '
        'chkbSpec
        '
        Me.chkbSpec.AutoSize = True
        Me.chkbSpec.Location = New System.Drawing.Point(14, 58)
        Me.chkbSpec.Name = "chkbSpec"
        Me.chkbSpec.Size = New System.Drawing.Size(15, 14)
        Me.chkbSpec.TabIndex = 45
        Me.chkbSpec.UseVisualStyleBackColor = True
        '
        'chkbDept
        '
        Me.chkbDept.AutoSize = True
        Me.chkbDept.Location = New System.Drawing.Point(435, 58)
        Me.chkbDept.Name = "chkbDept"
        Me.chkbDept.Size = New System.Drawing.Size(15, 14)
        Me.chkbDept.TabIndex = 44
        Me.chkbDept.UseVisualStyleBackColor = True
        '
        'txtEmployeeTotalSalary
        '
        Me.txtEmployeeTotalSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmployeeTotalSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeTotalSalary.Location = New System.Drawing.Point(727, 83)
        Me.txtEmployeeTotalSalary.Name = "txtEmployeeTotalSalary"
        Me.txtEmployeeTotalSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtEmployeeTotalSalary.TabIndex = 43
        '
        'txtEmployeeSubsidy
        '
        Me.txtEmployeeSubsidy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeSubsidy.Location = New System.Drawing.Point(520, 83)
        Me.txtEmployeeSubsidy.Name = "txtEmployeeSubsidy"
        Me.txtEmployeeSubsidy.Size = New System.Drawing.Size(96, 22)
        Me.txtEmployeeSubsidy.TabIndex = 42
        '
        'txtEmployeeBasicSalary
        '
        Me.txtEmployeeBasicSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeBasicSalary.Location = New System.Drawing.Point(110, 83)
        Me.txtEmployeeBasicSalary.Name = "txtEmployeeBasicSalary"
        Me.txtEmployeeBasicSalary.Size = New System.Drawing.Size(103, 22)
        Me.txtEmployeeBasicSalary.TabIndex = 32
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(85, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 17)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(491, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 17)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(289, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 17)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "*"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(641, 86)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 16)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "Tổng Lương"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(85, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 17)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "*"
        '
        'frmStaffManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 585)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dgrEmplResult)
        Me.Controls.Add(Me.btnUpdateEmpl)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.btnAddEmpl)
        Me.Controls.Add(Me.btnDeleteEmpl)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnReSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStaffManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmRecordsSystem"
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSearch As Button
    Private WithEvents label2 As Label
    Private WithEvents label10 As Label
    Private WithEvents txtEmployeeName As TextBox
    Private WithEvents txtEmployeeId As TextBox
    Private WithEvents btnReSearch As Button
    Private WithEvents label6 As Label
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents txtSearch_Empl_Name As TextBox
    Private WithEvents txtSearch_Empl_ID As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label1 As Label
    Private WithEvents dgrEmplResult As DataGridView
    Private WithEvents btnUpdateEmpl As Button
    Private WithEvents cmdClose As Button
    Private WithEvents btnAddEmpl As Button
    Private WithEvents btnDeleteEmpl As Button
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
    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label14 As Label
    Private WithEvents lblSpec As Label
    Private WithEvents txtEmployeePosition As TextBox
    Private WithEvents lblDept As Label
    Private WithEvents Label18 As Label
    Friend WithEvents cboxEmployeeSex As ComboBox
    Private WithEvents btnReset As Button
    Private WithEvents dtpEmployeeHireDate As DateTimePicker
    Private WithEvents Label22 As Label
    Private WithEvents txtEmployeeRatio As TextBox
    Private WithEvents txtEmployee As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label21 As Label
    Friend WithEvents cboxEmployeeSpeciality As ComboBox
    Friend WithEvents cboxEmployeeDepartment As ComboBox
    Friend WithEvents cboxSearchSpecialities As ComboBox
    Friend WithEvents cboxSearchDepartments As ComboBox
    Private WithEvents Label13 As Label
    Private WithEvents Label15 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Private WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label25 As Label
    Private WithEvents Label30 As Label
    Private WithEvents txtSearch_Empl_Phone As MaskedTextBox
    Private WithEvents txtSearch_Empl_IDCard As MaskedTextBox
    Private WithEvents Label33 As Label
    Private WithEvents Label5 As Label
    Private WithEvents txtEmployeeSubsidy As TextBox
    Private WithEvents txtEmployeeBasicSalary As TextBox
    Private WithEvents txtEmployeeTotalSalary As TextBox
    Friend WithEvents colEmplId As DataGridViewTextBoxColumn
    Friend WithEvents colEmplBasicSalary As DataGridViewTextBoxColumn
    Friend WithEvents colEmplSubsidy As DataGridViewTextBoxColumn
    Friend WithEvents colEmplDeptId As DataGridViewTextBoxColumn
    Friend WithEvents colEmplSpecId As DataGridViewTextBoxColumn
    Friend WithEvents colEmplName As DataGridViewTextBoxColumn
    Friend WithEvents colEmplPosition As DataGridViewTextBoxColumn
    Friend WithEvents colchkboxEmplSex As DataGridViewCheckBoxColumn
    Friend WithEvents colEmplIdCard As DataGridViewTextBoxColumn
    Friend WithEvents colEmplDoB As DataGridViewTextBoxColumn
    Friend WithEvents colEmplAddress As DataGridViewTextBoxColumn
    Friend WithEvents colEmplPhone As DataGridViewTextBoxColumn
    Friend WithEvents colEmplFolk As DataGridViewTextBoxColumn
    Friend WithEvents colEmplDeptName As DataGridViewTextBoxColumn
    Friend WithEvents colEmplSpecName As DataGridViewTextBoxColumn
    Friend WithEvents colEmplHireDate As DataGridViewTextBoxColumn
    Friend WithEvents colEmplRatio As DataGridViewTextBoxColumn
    Friend WithEvents chkbSpec As CheckBox
    Friend WithEvents chkbDept As CheckBox
End Class
