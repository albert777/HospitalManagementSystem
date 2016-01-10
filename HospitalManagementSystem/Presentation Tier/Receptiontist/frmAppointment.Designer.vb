<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointment))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAppointmentCreateTime = New System.Windows.Forms.TextBox()
        Me.txtAppoimentId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPatientInsuranceExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtPatientInsuranceIssueDate = New System.Windows.Forms.TextBox()
        Me.txtPatientInsuranceId = New System.Windows.Forms.TextBox()
        Me.lblInsIssDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblInsExpDate = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAppointmentEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRequest5 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtRequest4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRequest2 = New System.Windows.Forms.TextBox()
        Me.txtRequest3 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRequest1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAppointmentNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboxClinics = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClinicId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtPrescribe = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnNewAppointment = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(316, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 21)
        Me.lblTitle.TabIndex = 33
        Me.lblTitle.Text = "PHIẾU ĐĂNG KÝ KHÁM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Ngày lập"
        '
        'txtAppointmentCreateTime
        '
        Me.txtAppointmentCreateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAppointmentCreateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentCreateTime.Location = New System.Drawing.Point(305, 25)
        Me.txtAppointmentCreateTime.Name = "txtAppointmentCreateTime"
        Me.txtAppointmentCreateTime.ReadOnly = True
        Me.txtAppointmentCreateTime.Size = New System.Drawing.Size(88, 22)
        Me.txtAppointmentCreateTime.TabIndex = 35
        '
        'txtAppoimentId
        '
        Me.txtAppoimentId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAppoimentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppoimentId.Location = New System.Drawing.Point(110, 25)
        Me.txtAppoimentId.Name = "txtAppoimentId"
        Me.txtAppoimentId.ReadOnly = True
        Me.txtAppoimentId.Size = New System.Drawing.Size(100, 22)
        Me.txtAppoimentId.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 36
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 54)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin khám chữa bệnh"
        '
        'txtPatientInsuranceExpiryDate
        '
        Me.txtPatientInsuranceExpiryDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceExpiryDate.Location = New System.Drawing.Point(504, 20)
        Me.txtPatientInsuranceExpiryDate.Name = "txtPatientInsuranceExpiryDate"
        Me.txtPatientInsuranceExpiryDate.ReadOnly = True
        Me.txtPatientInsuranceExpiryDate.Size = New System.Drawing.Size(87, 22)
        Me.txtPatientInsuranceExpiryDate.TabIndex = 36
        '
        'txtPatientInsuranceIssueDate
        '
        Me.txtPatientInsuranceIssueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceIssueDate.Location = New System.Drawing.Point(305, 20)
        Me.txtPatientInsuranceIssueDate.Name = "txtPatientInsuranceIssueDate"
        Me.txtPatientInsuranceIssueDate.ReadOnly = True
        Me.txtPatientInsuranceIssueDate.Size = New System.Drawing.Size(88, 22)
        Me.txtPatientInsuranceIssueDate.TabIndex = 58
        '
        'txtPatientInsuranceId
        '
        Me.txtPatientInsuranceId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPatientInsuranceId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientInsuranceId.Location = New System.Drawing.Point(110, 21)
        Me.txtPatientInsuranceId.Name = "txtPatientInsuranceId"
        Me.txtPatientInsuranceId.ReadOnly = True
        Me.txtPatientInsuranceId.Size = New System.Drawing.Size(103, 22)
        Me.txtPatientInsuranceId.TabIndex = 57
        '
        'lblInsIssDate
        '
        Me.lblInsIssDate.AutoSize = True
        Me.lblInsIssDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsIssDate.Location = New System.Drawing.Point(231, 23)
        Me.lblInsIssDate.Name = "lblInsIssDate"
        Me.lblInsIssDate.Size = New System.Drawing.Size(67, 16)
        Me.lblInsIssDate.TabIndex = 51
        Me.lblInsIssDate.Text = "Ngày cấp"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Số Bảo hiểm"
        '
        'lblInsExpDate
        '
        Me.lblInsExpDate.AutoSize = True
        Me.lblInsExpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsExpDate.Location = New System.Drawing.Point(411, 23)
        Me.lblInsExpDate.Name = "lblInsExpDate"
        Me.lblInsExpDate.Size = New System.Drawing.Size(87, 16)
        Me.lblInsExpDate.TabIndex = 16
        Me.lblInsExpDate.Text = "Ngày hết hạn"
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
        Me.groupBox2.Location = New System.Drawing.Point(12, 125)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(602, 88)
        Me.groupBox2.TabIndex = 44
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
        Me.txtPatientDoB.TabIndex = 39
        '
        'rbtnSexFemale
        '
        Me.rbtnSexFemale.AutoSize = True
        Me.rbtnSexFemale.Checked = True
        Me.rbtnSexFemale.Enabled = False
        Me.rbtnSexFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSexFemale.Location = New System.Drawing.Point(533, 26)
        Me.rbtnSexFemale.Name = "rbtnSexFemale"
        Me.rbtnSexFemale.Size = New System.Drawing.Size(43, 20)
        Me.rbtnSexFemale.TabIndex = 62
        Me.rbtnSexFemale.TabStop = True
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
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Giới tính"
        '
        'rbtnSexMale
        '
        Me.rbtnSexMale.AutoSize = True
        Me.rbtnSexMale.Enabled = False
        Me.rbtnSexMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSexMale.Location = New System.Drawing.Point(472, 26)
        Me.rbtnSexMale.Name = "rbtnSexMale"
        Me.rbtnSexMale.Size = New System.Drawing.Size(55, 20)
        Me.rbtnSexMale.TabIndex = 61
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
        Me.label11.TabIndex = 10
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
        Me.txtPatientName.TabIndex = 7
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
        Me.label8.TabIndex = 6
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAppointmentEmployeeName)
        Me.GroupBox1.Controls.Add(Me.txtAppoimentId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAppointmentCreateTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 86)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin phiếu"
        '
        'txtAppointmentEmployeeName
        '
        Me.txtAppointmentEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAppointmentEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentEmployeeName.Location = New System.Drawing.Point(110, 53)
        Me.txtAppointmentEmployeeName.Name = "txtAppointmentEmployeeName"
        Me.txtAppointmentEmployeeName.ReadOnly = True
        Me.txtAppointmentEmployeeName.Size = New System.Drawing.Size(481, 22)
        Me.txtAppointmentEmployeeName.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Người lập"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRequest5)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtRequest4)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtRequest2)
        Me.GroupBox4.Controls.Add(Me.txtRequest3)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtRequest1)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(408, 168)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Yêu cầu khám của bệnh nhân"
        '
        'txtRequest5
        '
        Me.txtRequest5.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequest5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest5.Location = New System.Drawing.Point(110, 133)
        Me.txtRequest5.Name = "txtRequest5"
        Me.txtRequest5.Size = New System.Drawing.Size(283, 22)
        Me.txtRequest5.TabIndex = 55
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 136)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 16)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Yêu cầu 5"
        '
        'txtRequest4
        '
        Me.txtRequest4.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequest4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest4.Location = New System.Drawing.Point(110, 105)
        Me.txtRequest4.Name = "txtRequest4"
        Me.txtRequest4.Size = New System.Drawing.Size(283, 22)
        Me.txtRequest4.TabIndex = 52
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 108)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Yêu cầu 4"
        '
        'txtRequest2
        '
        Me.txtRequest2.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest2.Location = New System.Drawing.Point(110, 49)
        Me.txtRequest2.Name = "txtRequest2"
        Me.txtRequest2.Size = New System.Drawing.Size(283, 22)
        Me.txtRequest2.TabIndex = 41
        '
        'txtRequest3
        '
        Me.txtRequest3.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequest3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest3.Location = New System.Drawing.Point(110, 77)
        Me.txtRequest3.Name = "txtRequest3"
        Me.txtRequest3.Size = New System.Drawing.Size(283, 22)
        Me.txtRequest3.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 16)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Yêu cầu 3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 16)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Yêu cầu 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(85, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "*"
        '
        'txtRequest1
        '
        Me.txtRequest1.BackColor = System.Drawing.SystemColors.Window
        Me.txtRequest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequest1.Location = New System.Drawing.Point(110, 21)
        Me.txtRequest1.Name = "txtRequest1"
        Me.txtRequest1.Size = New System.Drawing.Size(283, 22)
        Me.txtRequest1.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Yêu cầu 1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtAppointmentNo)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.cboxClinics)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txtClinicId)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(620, 125)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(215, 148)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Phân phòng khám"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(70, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 17)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(121, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 17)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "*"
        '
        'txtAppointmentNo
        '
        Me.txtAppointmentNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppointmentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentNo.Location = New System.Drawing.Point(114, 114)
        Me.txtAppointmentNo.Name = "txtAppointmentNo"
        Me.txtAppointmentNo.Size = New System.Drawing.Size(88, 22)
        Me.txtAppointmentNo.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Số thứ tự"
        '
        'cboxClinics
        '
        Me.cboxClinics.DisplayMember = "Name"
        Me.cboxClinics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxClinics.FormattingEnabled = True
        Me.cboxClinics.Location = New System.Drawing.Point(9, 75)
        Me.cboxClinics.Name = "cboxClinics"
        Me.cboxClinics.Size = New System.Drawing.Size(193, 24)
        Me.cboxClinics.TabIndex = 49
        Me.cboxClinics.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Tên phòng khám"
        '
        'txtClinicId
        '
        Me.txtClinicId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClinicId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinicId.Location = New System.Drawing.Point(114, 25)
        Me.txtClinicId.Name = "txtClinicId"
        Me.txtClinicId.ReadOnly = True
        Me.txtClinicId.Size = New System.Drawing.Size(88, 22)
        Me.txtClinicId.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Số phòng khám"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtPrescribe)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtResult)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(426, 279)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(409, 168)
        Me.GroupBox6.TabIndex = 56
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Kết luận của bác sĩ"
        '
        'txtPrescribe
        '
        Me.txtPrescribe.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrescribe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescribe.Location = New System.Drawing.Point(110, 77)
        Me.txtPrescribe.Multiline = True
        Me.txtPrescribe.Name = "txtPrescribe"
        Me.txtPrescribe.Size = New System.Drawing.Size(286, 78)
        Me.txtPrescribe.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 16)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Hướng điều trị"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.SystemColors.Window
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(110, 21)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(286, 50)
        Me.txtResult.TabIndex = 38
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Chuẩn đoán"
        '
        'btnNewAppointment
        '
        Me.btnNewAppointment.BackgroundImage = CType(resources.GetObject("btnNewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAppointment.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnNewAppointment.Location = New System.Drawing.Point(12, 453)
        Me.btnNewAppointment.Name = "btnNewAppointment"
        Me.btnNewAppointment.Size = New System.Drawing.Size(109, 25)
        Me.btnNewAppointment.TabIndex = 57
        Me.btnNewAppointment.Text = "&Đăng ký Khám"
        Me.btnNewAppointment.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button2.Location = New System.Drawing.Point(127, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 25)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "&In phiếu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(737, 454)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(98, 25)
        Me.cmdClose.TabIndex = 60
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 491)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNewAppointment)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAppointment"
        Me.Text = "Phiếu Đăng ký Khám"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAppointmentCreateTime As TextBox
    Friend WithEvents txtAppoimentId As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents txtPatientInsuranceId As TextBox
    Private WithEvents lblInsIssDate As Label
    Private WithEvents Label13 As Label
    Private WithEvents lblInsExpDate As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtPatientInsuranceExpiryDate As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents label11 As Label
    Private WithEvents txtPatientName As TextBox
    Private WithEvents txtPatientId As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents txtAppointmentEmployeeName As TextBox
    Private WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents txtRequest5 As TextBox
    Private WithEvents Label21 As Label
    Private WithEvents txtRequest4 As TextBox
    Private WithEvents Label19 As Label
    Private WithEvents txtRequest2 As TextBox
    Private WithEvents txtRequest3 As TextBox
    Private WithEvents Label17 As Label
    Private WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents txtRequest1 As TextBox
    Private WithEvents Label14 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Private WithEvents txtAppointmentNo As TextBox
    Private WithEvents Label10 As Label
    Friend WithEvents cboxClinics As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents txtClinicId As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Private WithEvents txtPrescribe As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents txtResult As TextBox
    Private WithEvents Label23 As Label
    Private WithEvents btnNewAppointment As Button
    Private WithEvents Button2 As Button
    Private WithEvents cmdClose As Button
    Friend WithEvents rbtnSexFemale As RadioButton
    Friend WithEvents rbtnSexMale As RadioButton
    Private WithEvents txtPatientInsuranceIssueDate As TextBox
    Friend WithEvents txtPatientDoB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
End Class
