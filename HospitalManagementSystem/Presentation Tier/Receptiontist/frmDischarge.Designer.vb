<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischarge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDischarge))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPatientDoB = New System.Windows.Forms.TextBox()
        Me.rbtnSexFemale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtnSexMale = New System.Windows.Forms.RadioButton()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtPatientId = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtPatientInsuranceExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtPatientInsuranceIssueDate = New System.Windows.Forms.TextBox()
        Me.txtPatientInsuranceId = New System.Windows.Forms.TextBox()
        Me.lblInsIssDate = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblInsExpDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtAdmissionId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPrescribe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTreatment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDischargeTime = New System.Windows.Forms.TextBox()
        Me.txtAdmissionTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrintAdmission = New System.Windows.Forms.Button()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtPatientDoB)
        Me.groupBox2.Controls.Add(Me.rbtnSexFemale)
        Me.groupBox2.Controls.Add(Me.Label4)
        Me.groupBox2.Controls.Add(Me.rbtnSexMale)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.txtPatientName)
        Me.groupBox2.Controls.Add(Me.txtPatientId)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(14, 126)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(602, 88)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Thông tin bệnh nhân"
        '
        'txtPatientDoB
        '
        Me.txtPatientDoB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientDoB.Location = New System.Drawing.Point(305, 25)
        Me.txtPatientDoB.Name = "txtPatientDoB"
        Me.txtPatientDoB.ReadOnly = True
        Me.txtPatientDoB.Size = New System.Drawing.Size(88, 22)
        Me.txtPatientDoB.TabIndex = 3
        '
        'rbtnSexFemale
        '
        Me.rbtnSexFemale.AutoCheck = False
        Me.rbtnSexFemale.AutoSize = True
        Me.rbtnSexFemale.Enabled = False
        Me.rbtnSexFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSexFemale.Location = New System.Drawing.Point(533, 26)
        Me.rbtnSexFemale.Name = "rbtnSexFemale"
        Me.rbtnSexFemale.Size = New System.Drawing.Size(43, 20)
        Me.rbtnSexFemale.TabIndex = 6
        Me.rbtnSexFemale.Text = "Nữ"
        Me.rbtnSexFemale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Giới tính"
        '
        'rbtnSexMale
        '
        Me.rbtnSexMale.AutoCheck = False
        Me.rbtnSexMale.AutoSize = True
        Me.rbtnSexMale.Enabled = False
        Me.rbtnSexMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSexMale.Location = New System.Drawing.Point(472, 26)
        Me.rbtnSexMale.Name = "rbtnSexMale"
        Me.rbtnSexMale.Size = New System.Drawing.Size(55, 20)
        Me.rbtnSexMale.TabIndex = 5
        Me.rbtnSexMale.Text = "Nam"
        Me.rbtnSexMale.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(231, 28)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(68, 16)
        Me.label11.TabIndex = 2
        Me.label11.Text = "Ngày sinh"
        '
        'txtPatientName
        '
        Me.txtPatientName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(110, 53)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.ReadOnly = True
        Me.txtPatientName.Size = New System.Drawing.Size(481, 22)
        Me.txtPatientName.TabIndex = 8
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
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(17, 56)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(50, 16)
        Me.label8.TabIndex = 7
        Me.label8.Text = "Họ tên "
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
        'txtPatientInsuranceExpiryDate
        '
        Me.txtPatientInsuranceExpiryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceExpiryDate.Location = New System.Drawing.Point(504, 20)
        Me.txtPatientInsuranceExpiryDate.Name = "txtPatientInsuranceExpiryDate"
        Me.txtPatientInsuranceExpiryDate.ReadOnly = True
        Me.txtPatientInsuranceExpiryDate.Size = New System.Drawing.Size(87, 22)
        Me.txtPatientInsuranceExpiryDate.TabIndex = 5
        '
        'txtPatientInsuranceIssueDate
        '
        Me.txtPatientInsuranceIssueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceIssueDate.Location = New System.Drawing.Point(305, 20)
        Me.txtPatientInsuranceIssueDate.Name = "txtPatientInsuranceIssueDate"
        Me.txtPatientInsuranceIssueDate.ReadOnly = True
        Me.txtPatientInsuranceIssueDate.Size = New System.Drawing.Size(88, 22)
        Me.txtPatientInsuranceIssueDate.TabIndex = 3
        '
        'txtPatientInsuranceId
        '
        Me.txtPatientInsuranceId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceId.Location = New System.Drawing.Point(110, 21)
        Me.txtPatientInsuranceId.Name = "txtPatientInsuranceId"
        Me.txtPatientInsuranceId.ReadOnly = True
        Me.txtPatientInsuranceId.Size = New System.Drawing.Size(103, 22)
        Me.txtPatientInsuranceId.TabIndex = 1
        '
        'lblInsIssDate
        '
        Me.lblInsIssDate.AutoSize = True
        Me.lblInsIssDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsIssDate.Location = New System.Drawing.Point(231, 23)
        Me.lblInsIssDate.Name = "lblInsIssDate"
        Me.lblInsIssDate.Size = New System.Drawing.Size(67, 16)
        Me.lblInsIssDate.TabIndex = 2
        Me.lblInsIssDate.Text = "Ngày cấp"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(214, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(203, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PHIẾU XUẤT VIỆN"
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
        Me.lblInsExpDate.Location = New System.Drawing.Point(411, 23)
        Me.lblInsExpDate.Name = "lblInsExpDate"
        Me.lblInsExpDate.Size = New System.Drawing.Size(87, 16)
        Me.lblInsExpDate.TabIndex = 4
        Me.lblInsExpDate.Text = "Ngày hết hạn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmployeeName)
        Me.GroupBox1.Controls.Add(Me.txtAdmissionId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 86)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(110, 53)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(481, 22)
        Me.txtEmployeeName.TabIndex = 3
        '
        'txtAdmissionId
        '
        Me.txtAdmissionId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAdmissionId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmissionId.Location = New System.Drawing.Point(110, 25)
        Me.txtAdmissionId.Name = "txtAdmissionId"
        Me.txtAdmissionId.ReadOnly = True
        Me.txtAdmissionId.Size = New System.Drawing.Size(100, 22)
        Me.txtAdmissionId.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Người lập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Số phiếu"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPatientInsuranceExpiryDate)
        Me.GroupBox3.Controls.Add(Me.txtPatientInsuranceIssueDate)
        Me.GroupBox3.Controls.Add(Me.txtPatientInsuranceId)
        Me.GroupBox3.Controls.Add(Me.lblInsIssDate)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblInsExpDate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 54)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin khám chữa bệnh"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtPrescribe)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtResult)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtTreatment)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtDischargeTime)
        Me.GroupBox4.Controls.Add(Me.txtAdmissionTime)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(602, 182)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin xuất viện"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(89, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(89, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(89, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 17)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "*"
        '
        'txtPrescribe
        '
        Me.txtPrescribe.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrescribe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescribe.Location = New System.Drawing.Point(110, 131)
        Me.txtPrescribe.Multiline = True
        Me.txtPrescribe.Name = "txtPrescribe"
        Me.txtPrescribe.Size = New System.Drawing.Size(481, 35)
        Me.txtPrescribe.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 32)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Lời dặn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "của bác sĩ"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.SystemColors.Window
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(110, 90)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(481, 35)
        Me.txtResult.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 32)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kết quả " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "điều trị"
        '
        'txtTreatment
        '
        Me.txtTreatment.BackColor = System.Drawing.SystemColors.Window
        Me.txtTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTreatment.Location = New System.Drawing.Point(110, 49)
        Me.txtTreatment.Multiline = True
        Me.txtTreatment.Name = "txtTreatment"
        Me.txtTreatment.Size = New System.Drawing.Size(481, 35)
        Me.txtTreatment.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phương pháp" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "điều trị"
        '
        'txtDischargeTime
        '
        Me.txtDischargeTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDischargeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDischargeTime.Location = New System.Drawing.Point(399, 21)
        Me.txtDischargeTime.Name = "txtDischargeTime"
        Me.txtDischargeTime.ReadOnly = True
        Me.txtDischargeTime.Size = New System.Drawing.Size(192, 22)
        Me.txtDischargeTime.TabIndex = 4
        '
        'txtAdmissionTime
        '
        Me.txtAdmissionTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAdmissionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmissionTime.Location = New System.Drawing.Point(110, 21)
        Me.txtAdmissionTime.Name = "txtAdmissionTime"
        Me.txtAdmissionTime.ReadOnly = True
        Me.txtAdmissionTime.Size = New System.Drawing.Size(192, 22)
        Me.txtAdmissionTime.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Xuất viện"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nhập viện"
        '
        'btnPrintAdmission
        '
        Me.btnPrintAdmission.BackgroundImage = CType(resources.GetObject("btnPrintAdmission.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintAdmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAdmission.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnPrintAdmission.Location = New System.Drawing.Point(104, 468)
        Me.btnPrintAdmission.Name = "btnPrintAdmission"
        Me.btnPrintAdmission.Size = New System.Drawing.Size(86, 25)
        Me.btnPrintAdmission.TabIndex = 1
        Me.btnPrintAdmission.Text = "&In phiếu"
        Me.btnPrintAdmission.UseVisualStyleBackColor = True
        '
        'btnDischarge
        '
        Me.btnDischarge.BackgroundImage = CType(resources.GetObject("btnDischarge.BackgroundImage"), System.Drawing.Image)
        Me.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDischarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischarge.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnDischarge.Location = New System.Drawing.Point(12, 468)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(86, 25)
        Me.btnDischarge.TabIndex = 0
        Me.btnDischarge.Text = "&Xuất viện"
        Me.btnDischarge.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(528, 468)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(86, 25)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmDischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 505)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btnPrintAdmission)
        Me.Controls.Add(Me.btnDischarge)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDischarge"
        Me.Text = "Phiếu xuất viện"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox2 As GroupBox
    Friend WithEvents txtPatientDoB As TextBox
    Friend WithEvents rbtnSexFemale As RadioButton
    Private WithEvents Label4 As Label
    Friend WithEvents rbtnSexMale As RadioButton
    Private WithEvents label11 As Label
    Private WithEvents txtPatientName As TextBox
    Private WithEvents txtPatientId As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents txtPatientInsuranceExpiryDate As TextBox
    Private WithEvents txtPatientInsuranceIssueDate As TextBox
    Private WithEvents txtPatientInsuranceId As TextBox
    Private WithEvents lblInsIssDate As Label
    Private WithEvents btnPrintAdmission As Button
    Private WithEvents btnDischarge As Button
    Private WithEvents cmdClose As Button
    Private WithEvents lblTitle As Label
    Private WithEvents Label13 As Label
    Private WithEvents lblInsExpDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtAdmissionId As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents txtPrescribe As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents txtResult As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents txtTreatment As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents txtDischargeTime As TextBox
    Private WithEvents txtAdmissionTime As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
End Class
