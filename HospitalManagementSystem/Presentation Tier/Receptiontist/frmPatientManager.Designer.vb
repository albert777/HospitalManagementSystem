<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientManager))
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboxPatientSex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPatientAddress = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtPatientFolk = New System.Windows.Forms.TextBox()
        Me.txtSearch_IdCard = New System.Windows.Forms.MaskedTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchInsuranceId = New System.Windows.Forms.TextBox()
        Me.txtSearch_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch_Name = New System.Windows.Forms.TextBox()
        Me.txtSearch_Id = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPatientIdCard = New System.Windows.Forms.MaskedTextBox()
        Me.dtpPatientDoB = New System.Windows.Forms.DateTimePicker()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtPatientId = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpPatientInsuranceExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPatientInsuranceIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPatientInsuranceId = New System.Windows.Forms.TextBox()
        Me.txtPatientDischargeTime = New System.Windows.Forms.TextBox()
        Me.txtPatientAdmissionTime = New System.Windows.Forms.TextBox()
        Me.lblAddmissionTime = New System.Windows.Forms.Label()
        Me.lblInsIssDate = New System.Windows.Forms.Label()
        Me.txtPatientRoom = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblDischargeTime = New System.Windows.Forms.Label()
        Me.txtPatientBedId = New System.Windows.Forms.TextBox()
        Me.lblBedId = New System.Windows.Forms.Label()
        Me.cboxPatientType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblInsExpDate = New System.Windows.Forms.Label()
        Me.txtPatientStatus = New System.Windows.Forms.TextBox()
        Me.txtEmployee = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.dgvPatients = New System.Windows.Forms.DataGridView()
        Me.colPatientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientInsuranceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientInsuranceIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientInsuranceExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colchkboxPatientSex = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colPatientIdCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientDoB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientFolk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientBedId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientRoomId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPrintPatient = New System.Windows.Forms.Button()
        Me.btnViewAppointmentsList = New System.Windows.Forms.Button()
        Me.btnPatientRelatives = New System.Windows.Forms.Button()
        Me.btnPatientRecords = New System.Windows.Forms.Button()
        Me.btnSupplyMedication = New System.Windows.Forms.Button()
        Me.btnPaidPayment = New System.Windows.Forms.Button()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.btnAdmission = New System.Windows.Forms.Button()
        Me.btnNewAppointment = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdatePatient = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.btnDeletePatient = New System.Windows.Forms.Button()
        Me.btnReSearch = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(85, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 17)
        Me.Label28.TabIndex = 19
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
        Me.Label27.TabIndex = 9
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
        Me.Label26.TabIndex = 6
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
        Me.Label24.TabIndex = 12
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
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "*"
        '
        'cboxPatientSex
        '
        Me.cboxPatientSex.DisplayMember = "Name"
        Me.cboxPatientSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPatientSex.FormattingEnabled = True
        Me.cboxPatientSex.Location = New System.Drawing.Point(727, 23)
        Me.cboxPatientSex.Name = "cboxPatientSex"
        Me.cboxPatientSex.Size = New System.Drawing.Size(100, 24)
        Me.cboxPatientSex.TabIndex = 7
        Me.cboxPatientSex.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(641, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Giới tính"
        '
        'txtPatientPhone
        '
        Me.txtPatientPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientPhone.Location = New System.Drawing.Point(520, 55)
        Me.txtPatientPhone.Mask = "00000000000"
        Me.txtPatientPhone.Name = "txtPatientPhone"
        Me.txtPatientPhone.Size = New System.Drawing.Size(96, 22)
        Me.txtPatientPhone.TabIndex = 15
        '
        'txtPatientAddress
        '
        Me.txtPatientAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAddress.Location = New System.Drawing.Point(110, 83)
        Me.txtPatientAddress.Name = "txtPatientAddress"
        Me.txtPatientAddress.Size = New System.Drawing.Size(717, 22)
        Me.txtPatientAddress.TabIndex = 20
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(17, 58)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(68, 16)
        Me.label11.TabIndex = 8
        Me.label11.Text = "Ngày sinh"
        '
        'txtPatientFolk
        '
        Me.txtPatientFolk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFolk.Location = New System.Drawing.Point(727, 53)
        Me.txtPatientFolk.Name = "txtPatientFolk"
        Me.txtPatientFolk.Size = New System.Drawing.Size(100, 22)
        Me.txtPatientFolk.TabIndex = 17
        '
        'txtSearch_IdCard
        '
        Me.txtSearch_IdCard.Enabled = False
        Me.txtSearch_IdCard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_IdCard.Location = New System.Drawing.Point(110, 51)
        Me.txtSearch_IdCard.Mask = "000000000"
        Me.txtSearch_IdCard.Name = "txtSearch_IdCard"
        Me.txtSearch_IdCard.Size = New System.Drawing.Size(103, 22)
        Me.txtSearch_IdCard.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Enabled = False
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(17, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 16)
        Me.Label33.TabIndex = 4
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
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Điện thoại"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtSearchInsuranceId)
        Me.groupBox1.Controls.Add(Me.txtSearch_Phone)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.txtSearch_IdCard)
        Me.groupBox1.Controls.Add(Me.Label33)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txtSearch_Name)
        Me.groupBox1.Controls.Add(Me.txtSearch_Id)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 41)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(628, 82)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tiêu chí tìm kiếm"
        '
        'txtSearchInsuranceId
        '
        Me.txtSearchInsuranceId.Enabled = False
        Me.txtSearchInsuranceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchInsuranceId.Location = New System.Drawing.Point(520, 50)
        Me.txtSearchInsuranceId.Name = "txtSearchInsuranceId"
        Me.txtSearchInsuranceId.Size = New System.Drawing.Size(96, 22)
        Me.txtSearchInsuranceId.TabIndex = 9
        '
        'txtSearch_Phone
        '
        Me.txtSearch_Phone.Enabled = False
        Me.txtSearch_Phone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Phone.Location = New System.Drawing.Point(319, 50)
        Me.txtSearch_Phone.Mask = "00000000000"
        Me.txtSearch_Phone.Name = "txtSearch_Phone"
        Me.txtSearch_Phone.Size = New System.Drawing.Size(88, 22)
        Me.txtSearch_Phone.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Số Bảo hiểm"
        '
        'txtSearch_Name
        '
        Me.txtSearch_Name.Enabled = False
        Me.txtSearch_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Name.Location = New System.Drawing.Point(319, 24)
        Me.txtSearch_Name.Name = "txtSearch_Name"
        Me.txtSearch_Name.Size = New System.Drawing.Size(297, 22)
        Me.txtSearch_Name.TabIndex = 3
        '
        'txtSearch_Id
        '
        Me.txtSearch_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch_Id.Location = New System.Drawing.Point(110, 24)
        Me.txtSearch_Id.Name = "txtSearch_Id"
        Me.txtSearch_Id.Size = New System.Drawing.Size(103, 22)
        Me.txtSearch_Id.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Enabled = False
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(245, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Họ tên "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(17, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Mã bệnh nhân"
        '
        'txtPatientIdCard
        '
        Me.txtPatientIdCard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientIdCard.Location = New System.Drawing.Point(319, 55)
        Me.txtPatientIdCard.Mask = "000000000"
        Me.txtPatientIdCard.Name = "txtPatientIdCard"
        Me.txtPatientIdCard.Size = New System.Drawing.Size(88, 22)
        Me.txtPatientIdCard.TabIndex = 13
        '
        'dtpPatientDoB
        '
        Me.dtpPatientDoB.CustomFormat = "dd/MM/yyyy"
        Me.dtpPatientDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPatientDoB.Location = New System.Drawing.Point(110, 53)
        Me.dtpPatientDoB.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dtpPatientDoB.Name = "dtpPatientDoB"
        Me.dtpPatientDoB.Size = New System.Drawing.Size(103, 22)
        Me.dtpPatientDoB.TabIndex = 10
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(17, 86)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(48, 16)
        Me.label10.TabIndex = 18
        Me.label10.Text = "Địa chỉ"
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(319, 25)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(297, 22)
        Me.txtPatientName.TabIndex = 4
        '
        'txtPatientId
        '
        Me.txtPatientId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientId.Location = New System.Drawing.Point(110, 25)
        Me.txtPatientId.Name = "txtPatientId"
        Me.txtPatientId.ReadOnly = True
        Me.txtPatientId.Size = New System.Drawing.Size(103, 22)
        Me.txtPatientId.TabIndex = 1
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
        Me.label8.TabIndex = 2
        Me.label8.Text = "Họ tên "
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(245, 58)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 11
        Me.label7.Text = "CMND"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpPatientInsuranceExpiryDate)
        Me.GroupBox3.Controls.Add(Me.dtpPatientInsuranceIssueDate)
        Me.GroupBox3.Controls.Add(Me.txtPatientInsuranceId)
        Me.GroupBox3.Controls.Add(Me.txtPatientDischargeTime)
        Me.GroupBox3.Controls.Add(Me.txtPatientAdmissionTime)
        Me.GroupBox3.Controls.Add(Me.lblAddmissionTime)
        Me.GroupBox3.Controls.Add(Me.lblInsIssDate)
        Me.GroupBox3.Controls.Add(Me.txtPatientRoom)
        Me.GroupBox3.Controls.Add(Me.lblRoom)
        Me.GroupBox3.Controls.Add(Me.lblDischargeTime)
        Me.GroupBox3.Controls.Add(Me.txtPatientBedId)
        Me.GroupBox3.Controls.Add(Me.lblBedId)
        Me.GroupBox3.Controls.Add(Me.cboxPatientType)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblInsExpDate)
        Me.GroupBox3.Controls.Add(Me.txtPatientStatus)
        Me.GroupBox3.Controls.Add(Me.txtEmployee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(844, 114)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin khám chữa bệnh"
        '
        'dtpPatientInsuranceExpiryDate
        '
        Me.dtpPatientInsuranceExpiryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPatientInsuranceExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPatientInsuranceExpiryDate.Location = New System.Drawing.Point(520, 18)
        Me.dtpPatientInsuranceExpiryDate.Name = "dtpPatientInsuranceExpiryDate"
        Me.dtpPatientInsuranceExpiryDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpPatientInsuranceExpiryDate.TabIndex = 5
        '
        'dtpPatientInsuranceIssueDate
        '
        Me.dtpPatientInsuranceIssueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPatientInsuranceIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPatientInsuranceIssueDate.Location = New System.Drawing.Point(319, 19)
        Me.dtpPatientInsuranceIssueDate.Name = "dtpPatientInsuranceIssueDate"
        Me.dtpPatientInsuranceIssueDate.Size = New System.Drawing.Size(88, 22)
        Me.dtpPatientInsuranceIssueDate.TabIndex = 3
        '
        'txtPatientInsuranceId
        '
        Me.txtPatientInsuranceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceId.Location = New System.Drawing.Point(110, 21)
        Me.txtPatientInsuranceId.Name = "txtPatientInsuranceId"
        Me.txtPatientInsuranceId.Size = New System.Drawing.Size(103, 22)
        Me.txtPatientInsuranceId.TabIndex = 1
        '
        'txtPatientDischargeTime
        '
        Me.txtPatientDischargeTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientDischargeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientDischargeTime.Location = New System.Drawing.Point(520, 81)
        Me.txtPatientDischargeTime.Name = "txtPatientDischargeTime"
        Me.txtPatientDischargeTime.ReadOnly = True
        Me.txtPatientDischargeTime.Size = New System.Drawing.Size(186, 22)
        Me.txtPatientDischargeTime.TabIndex = 17
        '
        'txtPatientAdmissionTime
        '
        Me.txtPatientAdmissionTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientAdmissionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientAdmissionTime.Location = New System.Drawing.Point(520, 51)
        Me.txtPatientAdmissionTime.Name = "txtPatientAdmissionTime"
        Me.txtPatientAdmissionTime.ReadOnly = True
        Me.txtPatientAdmissionTime.Size = New System.Drawing.Size(186, 22)
        Me.txtPatientAdmissionTime.TabIndex = 11
        '
        'lblAddmissionTime
        '
        Me.lblAddmissionTime.AutoSize = True
        Me.lblAddmissionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddmissionTime.Location = New System.Drawing.Point(432, 54)
        Me.lblAddmissionTime.Name = "lblAddmissionTime"
        Me.lblAddmissionTime.Size = New System.Drawing.Size(69, 16)
        Me.lblAddmissionTime.TabIndex = 10
        Me.lblAddmissionTime.Text = "Nhập viện"
        '
        'lblInsIssDate
        '
        Me.lblInsIssDate.AutoSize = True
        Me.lblInsIssDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsIssDate.Location = New System.Drawing.Point(245, 23)
        Me.lblInsIssDate.Name = "lblInsIssDate"
        Me.lblInsIssDate.Size = New System.Drawing.Size(67, 16)
        Me.lblInsIssDate.TabIndex = 2
        Me.lblInsIssDate.Text = "Ngày cấp"
        '
        'txtPatientRoom
        '
        Me.txtPatientRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientRoom.Location = New System.Drawing.Point(331, 81)
        Me.txtPatientRoom.Name = "txtPatientRoom"
        Me.txtPatientRoom.ReadOnly = True
        Me.txtPatientRoom.Size = New System.Drawing.Size(76, 22)
        Me.txtPatientRoom.TabIndex = 15
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(245, 84)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(80, 16)
        Me.lblRoom.TabIndex = 14
        Me.lblRoom.Text = "Phòng bệnh"
        '
        'lblDischargeTime
        '
        Me.lblDischargeTime.AutoSize = True
        Me.lblDischargeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDischargeTime.Location = New System.Drawing.Point(432, 84)
        Me.lblDischargeTime.Name = "lblDischargeTime"
        Me.lblDischargeTime.Size = New System.Drawing.Size(62, 16)
        Me.lblDischargeTime.TabIndex = 16
        Me.lblDischargeTime.Text = "Xuất viện"
        '
        'txtPatientBedId
        '
        Me.txtPatientBedId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientBedId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientBedId.Location = New System.Drawing.Point(110, 81)
        Me.txtPatientBedId.Name = "txtPatientBedId"
        Me.txtPatientBedId.ReadOnly = True
        Me.txtPatientBedId.Size = New System.Drawing.Size(103, 22)
        Me.txtPatientBedId.TabIndex = 13
        '
        'lblBedId
        '
        Me.lblBedId.AutoSize = True
        Me.lblBedId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedId.Location = New System.Drawing.Point(17, 84)
        Me.lblBedId.Name = "lblBedId"
        Me.lblBedId.Size = New System.Drawing.Size(84, 16)
        Me.lblBedId.TabIndex = 12
        Me.lblBedId.Text = "Giường bệnh"
        '
        'cboxPatientType
        '
        Me.cboxPatientType.DisplayMember = "Name"
        Me.cboxPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxPatientType.Enabled = False
        Me.cboxPatientType.FormattingEnabled = True
        Me.cboxPatientType.Location = New System.Drawing.Point(110, 51)
        Me.cboxPatientType.Name = "cboxPatientType"
        Me.cboxPatientType.Size = New System.Drawing.Size(103, 24)
        Me.cboxPatientType.TabIndex = 7
        Me.cboxPatientType.ValueMember = "Id"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Phân loại"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Số Bảo hiểm"
        '
        'lblInsExpDate
        '
        Me.lblInsExpDate.AutoSize = True
        Me.lblInsExpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsExpDate.Location = New System.Drawing.Point(432, 23)
        Me.lblInsExpDate.Name = "lblInsExpDate"
        Me.lblInsExpDate.Size = New System.Drawing.Size(87, 16)
        Me.lblInsExpDate.TabIndex = 4
        Me.lblInsExpDate.Text = "Ngày hết hạn"
        '
        'txtPatientStatus
        '
        Me.txtPatientStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientStatus.Location = New System.Drawing.Point(319, 51)
        Me.txtPatientStatus.Name = "txtPatientStatus"
        Me.txtPatientStatus.Size = New System.Drawing.Size(88, 22)
        Me.txtPatientStatus.TabIndex = 9
        '
        'txtEmployee
        '
        Me.txtEmployee.AutoSize = True
        Me.txtEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(245, 54)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(67, 16)
        Me.txtEmployee.TabIndex = 8
        Me.txtEmployee.Text = "Tình trạng"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(339, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(292, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DANH MỤC BỆNH NHÂN"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(641, 56)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(54, 16)
        Me.label12.TabIndex = 16
        Me.label12.Text = "Dân tộc"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(17, 28)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(92, 16)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Mã bệnh nhân"
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.AllowUserToResizeColumns = False
        Me.dgvPatients.AllowUserToResizeRows = False
        Me.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvPatients.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvPatients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPatientId, Me.colPatientName, Me.colPatientType, Me.colPatientStatus, Me.colPatientInsuranceId, Me.colPatientInsuranceIssueDate, Me.colPatientInsuranceExpiryDate, Me.colchkboxPatientSex, Me.colPatientIdCard, Me.colPatientDoB, Me.colPatientAddress, Me.colPatientPhone, Me.colPatientFolk, Me.colPatientBedId, Me.colPatientRoomId})
        Me.dgvPatients.Location = New System.Drawing.Point(12, 129)
        Me.dgvPatients.MultiSelect = False
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.ReadOnly = True
        Me.dgvPatients.RowHeadersVisible = False
        Me.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPatients.Size = New System.Drawing.Size(948, 166)
        Me.dgvPatients.TabIndex = 4
        '
        'colPatientId
        '
        Me.colPatientId.DataPropertyName = "Id"
        Me.colPatientId.Frozen = True
        Me.colPatientId.HeaderText = "Mã bệnh nhân"
        Me.colPatientId.Name = "colPatientId"
        Me.colPatientId.ReadOnly = True
        Me.colPatientId.Width = 101
        '
        'colPatientName
        '
        Me.colPatientName.DataPropertyName = "Name"
        Me.colPatientName.HeaderText = "Họ tên"
        Me.colPatientName.Name = "colPatientName"
        Me.colPatientName.ReadOnly = True
        Me.colPatientName.Width = 64
        '
        'colPatientType
        '
        Me.colPatientType.DataPropertyName = "Type"
        Me.colPatientType.HeaderText = "Phân loại"
        Me.colPatientType.Name = "colPatientType"
        Me.colPatientType.ReadOnly = True
        Me.colPatientType.Width = 76
        '
        'colPatientStatus
        '
        Me.colPatientStatus.DataPropertyName = "Status"
        Me.colPatientStatus.HeaderText = "Tình trạng"
        Me.colPatientStatus.Name = "colPatientStatus"
        Me.colPatientStatus.ReadOnly = True
        Me.colPatientStatus.Width = 80
        '
        'colPatientInsuranceId
        '
        Me.colPatientInsuranceId.DataPropertyName = "InsuranceId"
        Me.colPatientInsuranceId.HeaderText = "Số bảo hiểm"
        Me.colPatientInsuranceId.Name = "colPatientInsuranceId"
        Me.colPatientInsuranceId.ReadOnly = True
        Me.colPatientInsuranceId.Width = 91
        '
        'colPatientInsuranceIssueDate
        '
        Me.colPatientInsuranceIssueDate.DataPropertyName = "InsuranceIssueDate"
        Me.colPatientInsuranceIssueDate.HeaderText = "Ngày cấp"
        Me.colPatientInsuranceIssueDate.Name = "colPatientInsuranceIssueDate"
        Me.colPatientInsuranceIssueDate.ReadOnly = True
        Me.colPatientInsuranceIssueDate.Visible = False
        Me.colPatientInsuranceIssueDate.Width = 78
        '
        'colPatientInsuranceExpiryDate
        '
        Me.colPatientInsuranceExpiryDate.DataPropertyName = "InsuranceExpiryDate"
        Me.colPatientInsuranceExpiryDate.HeaderText = "Ngày hết hạn"
        Me.colPatientInsuranceExpiryDate.Name = "colPatientInsuranceExpiryDate"
        Me.colPatientInsuranceExpiryDate.ReadOnly = True
        Me.colPatientInsuranceExpiryDate.Visible = False
        Me.colPatientInsuranceExpiryDate.Width = 96
        '
        'colchkboxPatientSex
        '
        Me.colchkboxPatientSex.DataPropertyName = "Sex"
        Me.colchkboxPatientSex.FalseValue = "Nam"
        Me.colchkboxPatientSex.HeaderText = "Giới tính"
        Me.colchkboxPatientSex.Name = "colchkboxPatientSex"
        Me.colchkboxPatientSex.ReadOnly = True
        Me.colchkboxPatientSex.TrueValue = "Nữ"
        Me.colchkboxPatientSex.Width = 53
        '
        'colPatientIdCard
        '
        Me.colPatientIdCard.DataPropertyName = "IdCard"
        Me.colPatientIdCard.HeaderText = "Số CMND"
        Me.colPatientIdCard.Name = "colPatientIdCard"
        Me.colPatientIdCard.ReadOnly = True
        Me.colPatientIdCard.Width = 80
        '
        'colPatientDoB
        '
        Me.colPatientDoB.DataPropertyName = "DoB"
        Me.colPatientDoB.HeaderText = "Ngày sinh"
        Me.colPatientDoB.Name = "colPatientDoB"
        Me.colPatientDoB.ReadOnly = True
        Me.colPatientDoB.Width = 79
        '
        'colPatientAddress
        '
        Me.colPatientAddress.DataPropertyName = "Address"
        Me.colPatientAddress.HeaderText = "Địa chỉ"
        Me.colPatientAddress.Name = "colPatientAddress"
        Me.colPatientAddress.ReadOnly = True
        Me.colPatientAddress.Visible = False
        Me.colPatientAddress.Width = 65
        '
        'colPatientPhone
        '
        Me.colPatientPhone.DataPropertyName = "Phone"
        Me.colPatientPhone.HeaderText = "Điện thoại"
        Me.colPatientPhone.Name = "colPatientPhone"
        Me.colPatientPhone.ReadOnly = True
        Me.colPatientPhone.Width = 80
        '
        'colPatientFolk
        '
        Me.colPatientFolk.DataPropertyName = "Folk"
        Me.colPatientFolk.HeaderText = "Dân tộc"
        Me.colPatientFolk.Name = "colPatientFolk"
        Me.colPatientFolk.ReadOnly = True
        Me.colPatientFolk.Visible = False
        Me.colPatientFolk.Width = 70
        '
        'colPatientBedId
        '
        Me.colPatientBedId.DataPropertyName = "BedId"
        Me.colPatientBedId.HeaderText = "Mã Giường bệnh"
        Me.colPatientBedId.Name = "colPatientBedId"
        Me.colPatientBedId.ReadOnly = True
        Me.colPatientBedId.Visible = False
        Me.colPatientBedId.Width = 111
        '
        'colPatientRoomId
        '
        Me.colPatientRoomId.DataPropertyName = "Room"
        Me.colPatientRoomId.HeaderText = "Mã phòng bệnh"
        Me.colPatientRoomId.Name = "colPatientRoomId"
        Me.colPatientRoomId.ReadOnly = True
        Me.colPatientRoomId.Visible = False
        Me.colPatientRoomId.Width = 107
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Label28)
        Me.groupBox2.Controls.Add(Me.Label27)
        Me.groupBox2.Controls.Add(Me.Label26)
        Me.groupBox2.Controls.Add(Me.Label24)
        Me.groupBox2.Controls.Add(Me.Label23)
        Me.groupBox2.Controls.Add(Me.cboxPatientSex)
        Me.groupBox2.Controls.Add(Me.Label3)
        Me.groupBox2.Controls.Add(Me.txtPatientPhone)
        Me.groupBox2.Controls.Add(Me.txtPatientIdCard)
        Me.groupBox2.Controls.Add(Me.dtpPatientDoB)
        Me.groupBox2.Controls.Add(Me.txtPatientAddress)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.txtPatientName)
        Me.groupBox2.Controls.Add(Me.txtPatientId)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.txtPatientFolk)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 332)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(844, 118)
        Me.groupBox2.TabIndex = 14
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Thông tin cá nhân"
        '
        'btnPrintPatient
        '
        Me.btnPrintPatient.BackgroundImage = CType(resources.GetObject("btnPrintPatient.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintPatient.Location = New System.Drawing.Point(862, 456)
        Me.btnPrintPatient.Name = "btnPrintPatient"
        Me.btnPrintPatient.Size = New System.Drawing.Size(98, 23)
        Me.btnPrintPatient.TabIndex = 20
        Me.btnPrintPatient.Text = "&In thông tin"
        Me.btnPrintPatient.UseVisualStyleBackColor = True
        '
        'btnViewAppointmentsList
        '
        Me.btnViewAppointmentsList.BackgroundImage = CType(resources.GetObject("btnViewAppointmentsList.BackgroundImage"), System.Drawing.Image)
        Me.btnViewAppointmentsList.Enabled = False
        Me.btnViewAppointmentsList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewAppointmentsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAppointmentsList.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnViewAppointmentsList.Location = New System.Drawing.Point(737, 301)
        Me.btnViewAppointmentsList.Name = "btnViewAppointmentsList"
        Me.btnViewAppointmentsList.Size = New System.Drawing.Size(119, 25)
        Me.btnViewAppointmentsList.TabIndex = 12
        Me.btnViewAppointmentsList.Text = "DS Phiếu Khám"
        Me.btnViewAppointmentsList.UseVisualStyleBackColor = True
        '
        'btnPatientRelatives
        '
        Me.btnPatientRelatives.BackgroundImage = CType(resources.GetObject("btnPatientRelatives.BackgroundImage"), System.Drawing.Image)
        Me.btnPatientRelatives.Enabled = False
        Me.btnPatientRelatives.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPatientRelatives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientRelatives.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPatientRelatives.Location = New System.Drawing.Point(529, 301)
        Me.btnPatientRelatives.Name = "btnPatientRelatives"
        Me.btnPatientRelatives.Size = New System.Drawing.Size(98, 25)
        Me.btnPatientRelatives.TabIndex = 10
        Me.btnPatientRelatives.Text = "&Người nhà"
        Me.btnPatientRelatives.UseVisualStyleBackColor = True
        Me.btnPatientRelatives.Visible = False
        '
        'btnPatientRecords
        '
        Me.btnPatientRecords.BackgroundImage = CType(resources.GetObject("btnPatientRecords.BackgroundImage"), System.Drawing.Image)
        Me.btnPatientRecords.Enabled = False
        Me.btnPatientRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPatientRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientRecords.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPatientRecords.Location = New System.Drawing.Point(633, 301)
        Me.btnPatientRecords.Name = "btnPatientRecords"
        Me.btnPatientRecords.Size = New System.Drawing.Size(98, 25)
        Me.btnPatientRecords.TabIndex = 11
        Me.btnPatientRecords.Text = "&Sổ theo dõi"
        Me.btnPatientRecords.UseVisualStyleBackColor = True
        Me.btnPatientRecords.Visible = False
        '
        'btnSupplyMedication
        '
        Me.btnSupplyMedication.BackgroundImage = CType(resources.GetObject("btnSupplyMedication.BackgroundImage"), System.Drawing.Image)
        Me.btnSupplyMedication.Enabled = False
        Me.btnSupplyMedication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupplyMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplyMedication.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnSupplyMedication.Location = New System.Drawing.Point(311, 301)
        Me.btnSupplyMedication.Name = "btnSupplyMedication"
        Me.btnSupplyMedication.Size = New System.Drawing.Size(98, 25)
        Me.btnSupplyMedication.TabIndex = 8
        Me.btnSupplyMedication.Text = "&Cấp thuốc"
        Me.btnSupplyMedication.UseVisualStyleBackColor = True
        Me.btnSupplyMedication.Visible = False
        '
        'btnPaidPayment
        '
        Me.btnPaidPayment.BackgroundImage = CType(resources.GetObject("btnPaidPayment.BackgroundImage"), System.Drawing.Image)
        Me.btnPaidPayment.Enabled = False
        Me.btnPaidPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPaidPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaidPayment.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPaidPayment.Location = New System.Drawing.Point(415, 301)
        Me.btnPaidPayment.Name = "btnPaidPayment"
        Me.btnPaidPayment.Size = New System.Drawing.Size(98, 25)
        Me.btnPaidPayment.TabIndex = 9
        Me.btnPaidPayment.Text = "&Thanh toán"
        Me.btnPaidPayment.UseVisualStyleBackColor = True
        Me.btnPaidPayment.Visible = False
        '
        'btnDischarge
        '
        Me.btnDischarge.BackgroundImage = CType(resources.GetObject("btnDischarge.BackgroundImage"), System.Drawing.Image)
        Me.btnDischarge.Enabled = False
        Me.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischarge.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDischarge.Location = New System.Drawing.Point(219, 301)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(86, 25)
        Me.btnDischarge.TabIndex = 7
        Me.btnDischarge.Text = "&Xuất viện"
        Me.btnDischarge.UseVisualStyleBackColor = True
        '
        'btnAdmission
        '
        Me.btnAdmission.BackgroundImage = CType(resources.GetObject("btnAdmission.BackgroundImage"), System.Drawing.Image)
        Me.btnAdmission.Enabled = False
        Me.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmission.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnAdmission.Location = New System.Drawing.Point(127, 301)
        Me.btnAdmission.Name = "btnAdmission"
        Me.btnAdmission.Size = New System.Drawing.Size(86, 25)
        Me.btnAdmission.TabIndex = 6
        Me.btnAdmission.Text = "&Nhập viện"
        Me.btnAdmission.UseVisualStyleBackColor = True
        '
        'btnNewAppointment
        '
        Me.btnNewAppointment.BackgroundImage = CType(resources.GetObject("btnNewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.btnNewAppointment.Enabled = False
        Me.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAppointment.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnNewAppointment.Location = New System.Drawing.Point(12, 301)
        Me.btnNewAppointment.Name = "btnNewAppointment"
        Me.btnNewAppointment.Size = New System.Drawing.Size(109, 25)
        Me.btnNewAppointment.TabIndex = 5
        Me.btnNewAppointment.Text = "&Đăng ký Khám"
        Me.btnNewAppointment.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(862, 427)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Làm &mới"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdatePatient
        '
        Me.btnUpdatePatient.BackgroundImage = CType(resources.GetObject("btnUpdatePatient.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdatePatient.Location = New System.Drawing.Point(862, 398)
        Me.btnUpdatePatient.Name = "btnUpdatePatient"
        Me.btnUpdatePatient.Size = New System.Drawing.Size(98, 23)
        Me.btnUpdatePatient.TabIndex = 18
        Me.btnUpdatePatient.Text = "&Sửa"
        Me.btnUpdatePatient.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(862, 547)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(98, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'btnAddPatient
        '
        Me.btnAddPatient.BackgroundImage = CType(resources.GetObject("btnAddPatient.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddPatient.Location = New System.Drawing.Point(862, 340)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(98, 23)
        Me.btnAddPatient.TabIndex = 16
        Me.btnAddPatient.Text = "&Thêm bệnh nhân"
        Me.btnAddPatient.UseVisualStyleBackColor = True
        '
        'btnDeletePatient
        '
        Me.btnDeletePatient.BackgroundImage = CType(resources.GetObject("btnDeletePatient.BackgroundImage"), System.Drawing.Image)
        Me.btnDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeletePatient.Location = New System.Drawing.Point(862, 369)
        Me.btnDeletePatient.Name = "btnDeletePatient"
        Me.btnDeletePatient.Size = New System.Drawing.Size(98, 23)
        Me.btnDeletePatient.TabIndex = 17
        Me.btnDeletePatient.Text = "&Xóa"
        Me.btnDeletePatient.UseVisualStyleBackColor = True
        '
        'btnReSearch
        '
        Me.btnReSearch.BackgroundImage = CType(resources.GetObject("btnReSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnReSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReSearch.Location = New System.Drawing.Point(654, 65)
        Me.btnReSearch.Name = "btnReSearch"
        Me.btnReSearch.Size = New System.Drawing.Size(98, 23)
        Me.btnReSearch.TabIndex = 2
        Me.btnReSearch.Text = "&Làm lại"
        Me.btnReSearch.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(654, 92)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmPatientManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 587)
        Me.Controls.Add(Me.btnPrintPatient)
        Me.Controls.Add(Me.btnViewAppointmentsList)
        Me.Controls.Add(Me.dgvPatients)
        Me.Controls.Add(Me.btnPatientRelatives)
        Me.Controls.Add(Me.btnPatientRecords)
        Me.Controls.Add(Me.btnSupplyMedication)
        Me.Controls.Add(Me.btnPaidPayment)
        Me.Controls.Add(Me.btnDischarge)
        Me.Controls.Add(Me.btnAdmission)
        Me.Controls.Add(Me.btnNewAppointment)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpdatePatient)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.btnDeletePatient)
        Me.Controls.Add(Me.btnReSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.groupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPatientManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Danh mục Bệnh nhân"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cboxPatientSex As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents txtPatientPhone As MaskedTextBox
    Private WithEvents txtPatientAddress As TextBox
    Private WithEvents label11 As Label
    Private WithEvents txtPatientFolk As TextBox
    Private WithEvents txtSearch_IdCard As MaskedTextBox
    Private WithEvents Label33 As Label
    Private WithEvents Label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtSearch_Name As TextBox
    Private WithEvents txtSearch_Id As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtPatientIdCard As MaskedTextBox
    Private WithEvents dtpPatientDoB As DateTimePicker
    Private WithEvents label10 As Label
    Private WithEvents txtPatientName As TextBox
    Private WithEvents txtPatientId As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents lblInsExpDate As Label
    Private WithEvents txtPatientStatus As TextBox
    Private WithEvents txtEmployee As Label
    Private WithEvents btnReset As Button
    Private WithEvents btnUpdatePatient As Button
    Private WithEvents cmdClose As Button
    Private WithEvents btnAddPatient As Button
    Private WithEvents btnDeletePatient As Button
    Private WithEvents btnReSearch As Button
    Private WithEvents btnSearch As Button
    Private WithEvents lblTitle As Label
    Private WithEvents label12 As Label
    Private WithEvents label9 As Label
    Private WithEvents dgvPatients As DataGridView
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtSearch_Phone As MaskedTextBox
    Private WithEvents Label4 As Label
    Friend WithEvents cboxPatientType As ComboBox
    Private WithEvents Label14 As Label
    Private WithEvents Label13 As Label
    Private WithEvents btnNewAppointment As Button
    Private WithEvents btnAdmission As Button
    Private WithEvents btnDischarge As Button
    Private WithEvents btnPaidPayment As Button
    Private WithEvents btnSupplyMedication As Button
    Private WithEvents btnPatientRecords As Button
    Private WithEvents lblAddmissionTime As Label
    Private WithEvents lblInsIssDate As Label
    Private WithEvents txtPatientRoom As TextBox
    Private WithEvents lblRoom As Label
    Private WithEvents lblDischargeTime As Label
    Private WithEvents txtPatientBedId As TextBox
    Private WithEvents lblBedId As Label
    Private WithEvents btnPatientRelatives As Button
    Private WithEvents txtSearchInsuranceId As TextBox
    Private WithEvents txtPatientInsuranceId As TextBox
    Private WithEvents txtPatientDischargeTime As TextBox
    Private WithEvents txtPatientAdmissionTime As TextBox
    Private WithEvents btnPrintPatient As Button
    Private WithEvents btnViewAppointmentsList As Button
    Friend WithEvents dtpPatientInsuranceExpiryDate As DateTimePicker
    Friend WithEvents dtpPatientInsuranceIssueDate As DateTimePicker
    Friend WithEvents colPatientId As DataGridViewTextBoxColumn
    Friend WithEvents colPatientName As DataGridViewTextBoxColumn
    Friend WithEvents colPatientType As DataGridViewTextBoxColumn
    Friend WithEvents colPatientStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPatientInsuranceId As DataGridViewTextBoxColumn
    Friend WithEvents colPatientInsuranceIssueDate As DataGridViewTextBoxColumn
    Friend WithEvents colPatientInsuranceExpiryDate As DataGridViewTextBoxColumn
    Friend WithEvents colchkboxPatientSex As DataGridViewCheckBoxColumn
    Friend WithEvents colPatientIdCard As DataGridViewTextBoxColumn
    Friend WithEvents colPatientDoB As DataGridViewTextBoxColumn
    Friend WithEvents colPatientAddress As DataGridViewTextBoxColumn
    Friend WithEvents colPatientPhone As DataGridViewTextBoxColumn
    Friend WithEvents colPatientFolk As DataGridViewTextBoxColumn
    Friend WithEvents colPatientBedId As DataGridViewTextBoxColumn
    Friend WithEvents colPatientRoomId As DataGridViewTextBoxColumn
End Class
