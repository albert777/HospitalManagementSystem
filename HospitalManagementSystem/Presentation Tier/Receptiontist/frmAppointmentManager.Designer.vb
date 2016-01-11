<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointmentManager))
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.colAppointId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointPrescribe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmployeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointEName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointCreateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClinicId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointClinicName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDoctorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointDoctorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewAppointment = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnNewAppointment = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 54)
        Me.GroupBox3.TabIndex = 63
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
        Me.groupBox2.Location = New System.Drawing.Point(12, 38)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(602, 88)
        Me.groupBox2.TabIndex = 62
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
        Me.rbtnSexFemale.AutoCheck = False
        Me.rbtnSexFemale.AutoSize = True
        Me.rbtnSexFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSexFemale.Location = New System.Drawing.Point(533, 26)
        Me.rbtnSexFemale.Name = "rbtnSexFemale"
        Me.rbtnSexFemale.Size = New System.Drawing.Size(43, 20)
        Me.rbtnSexFemale.TabIndex = 62
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
        Me.rbtnSexMale.AutoCheck = False
        Me.rbtnSexMale.AutoSize = True
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(116, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(395, 26)
        Me.lblTitle.TabIndex = 61
        Me.lblTitle.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ KHÁM"
        '
        'dgvAppointments
        '
        Me.dgvAppointments.AllowUserToAddRows = False
        Me.dgvAppointments.AllowUserToDeleteRows = False
        Me.dgvAppointments.AllowUserToResizeColumns = False
        Me.dgvAppointments.AllowUserToResizeRows = False
        Me.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAppointId, Me.colAppointResult, Me.colAppointPrescribe, Me.colEmployeeId, Me.colAppointEName, Me.colAppointCreateTime, Me.colClinicId, Me.colAppointClinicName, Me.colAppointNo, Me.colDoctorId, Me.colAppointDoctorName})
        Me.dgvAppointments.Location = New System.Drawing.Point(12, 192)
        Me.dgvAppointments.MultiSelect = False
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.ReadOnly = True
        Me.dgvAppointments.RowHeadersVisible = False
        Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAppointments.Size = New System.Drawing.Size(602, 166)
        Me.dgvAppointments.TabIndex = 66
        '
        'colAppointId
        '
        Me.colAppointId.DataPropertyName = "Id"
        Me.colAppointId.Frozen = True
        Me.colAppointId.HeaderText = "Mã phiếu khám"
        Me.colAppointId.Name = "colAppointId"
        Me.colAppointId.ReadOnly = True
        Me.colAppointId.Width = 105
        '
        'colAppointResult
        '
        Me.colAppointResult.DataPropertyName = "Result"
        Me.colAppointResult.Frozen = True
        Me.colAppointResult.HeaderText = "Kết quả"
        Me.colAppointResult.Name = "colAppointResult"
        Me.colAppointResult.ReadOnly = True
        Me.colAppointResult.Visible = False
        Me.colAppointResult.Width = 69
        '
        'colAppointPrescribe
        '
        Me.colAppointPrescribe.DataPropertyName = "Prescribe"
        Me.colAppointPrescribe.Frozen = True
        Me.colAppointPrescribe.HeaderText = "Lời khuyên"
        Me.colAppointPrescribe.Name = "colAppointPrescribe"
        Me.colAppointPrescribe.ReadOnly = True
        Me.colAppointPrescribe.Visible = False
        Me.colAppointPrescribe.Width = 84
        '
        'colEmployeeId
        '
        Me.colEmployeeId.DataPropertyName = "EmployeeId"
        Me.colEmployeeId.Frozen = True
        Me.colEmployeeId.HeaderText = "Mã nhân viên lập"
        Me.colEmployeeId.Name = "colEmployeeId"
        Me.colEmployeeId.ReadOnly = True
        Me.colEmployeeId.Visible = False
        Me.colEmployeeId.Width = 114
        '
        'colAppointEName
        '
        Me.colAppointEName.DataPropertyName = "EName"
        Me.colAppointEName.Frozen = True
        Me.colAppointEName.HeaderText = "Người lập"
        Me.colAppointEName.Name = "colAppointEName"
        Me.colAppointEName.ReadOnly = True
        Me.colAppointEName.Width = 77
        '
        'colAppointCreateTime
        '
        Me.colAppointCreateTime.DataPropertyName = "CreateTime"
        Me.colAppointCreateTime.Frozen = True
        Me.colAppointCreateTime.HeaderText = "Ngày lập"
        Me.colAppointCreateTime.Name = "colAppointCreateTime"
        Me.colAppointCreateTime.ReadOnly = True
        Me.colAppointCreateTime.Width = 74
        '
        'colClinicId
        '
        Me.colClinicId.DataPropertyName = "ClinicId"
        Me.colClinicId.Frozen = True
        Me.colClinicId.HeaderText = "Mã số phòng khám"
        Me.colClinicId.Name = "colClinicId"
        Me.colClinicId.ReadOnly = True
        Me.colClinicId.Visible = False
        Me.colClinicId.Width = 123
        '
        'colAppointClinicName
        '
        Me.colAppointClinicName.DataPropertyName = "CName"
        Me.colAppointClinicName.Frozen = True
        Me.colAppointClinicName.HeaderText = "Tên phòng khám"
        Me.colAppointClinicName.Name = "colAppointClinicName"
        Me.colAppointClinicName.ReadOnly = True
        Me.colAppointClinicName.Width = 113
        '
        'colAppointNo
        '
        Me.colAppointNo.DataPropertyName = "NumberOrder"
        Me.colAppointNo.Frozen = True
        Me.colAppointNo.HeaderText = "Số thứ tự"
        Me.colAppointNo.Name = "colAppointNo"
        Me.colAppointNo.ReadOnly = True
        Me.colAppointNo.Width = 75
        '
        'colDoctorId
        '
        Me.colDoctorId.DataPropertyName = "DoctorId"
        Me.colDoctorId.Frozen = True
        Me.colDoctorId.HeaderText = "Mã số bác sĩ"
        Me.colDoctorId.Name = "colDoctorId"
        Me.colDoctorId.ReadOnly = True
        Me.colDoctorId.Visible = False
        Me.colDoctorId.Width = 95
        '
        'colAppointDoctorName
        '
        Me.colAppointDoctorName.DataPropertyName = "DName"
        Me.colAppointDoctorName.Frozen = True
        Me.colAppointDoctorName.HeaderText = "Tên bác sĩ"
        Me.colAppointDoctorName.Name = "colAppointDoctorName"
        Me.colAppointDoctorName.ReadOnly = True
        Me.colAppointDoctorName.Width = 85
        '
        'btnViewAppointment
        '
        Me.btnViewAppointment.BackgroundImage = CType(resources.GetObject("btnViewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.btnViewAppointment.Enabled = False
        Me.btnViewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAppointment.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnViewAppointment.Location = New System.Drawing.Point(12, 364)
        Me.btnViewAppointment.Name = "btnViewAppointment"
        Me.btnViewAppointment.Size = New System.Drawing.Size(109, 25)
        Me.btnViewAppointment.TabIndex = 67
        Me.btnViewAppointment.Text = "&Xem phiếu"
        Me.btnViewAppointment.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImage = CType(resources.GetObject("cmdClose.BackgroundImage"), System.Drawing.Image)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(516, 364)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(98, 25)
        Me.cmdClose.TabIndex = 65
        Me.cmdClose.Text = "&Đóng"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'btnNewAppointment
        '
        Me.btnNewAppointment.BackgroundImage = CType(resources.GetObject("btnNewAppointment.BackgroundImage"), System.Drawing.Image)
        Me.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAppointment.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnNewAppointment.Location = New System.Drawing.Point(127, 364)
        Me.btnNewAppointment.Name = "btnNewAppointment"
        Me.btnNewAppointment.Size = New System.Drawing.Size(109, 25)
        Me.btnNewAppointment.TabIndex = 64
        Me.btnNewAppointment.Text = "&Đăng ký Khám"
        Me.btnNewAppointment.UseVisualStyleBackColor = True
        '
        'frmAppointmentManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 399)
        Me.Controls.Add(Me.btnViewAppointment)
        Me.Controls.Add(Me.dgvAppointments)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.btnNewAppointment)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAppointmentManager"
        Me.Text = "Danh sách phiếu đăng ký khám"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdClose As Button
    Private WithEvents btnNewAppointment As Button
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents txtPatientInsuranceExpiryDate As TextBox
    Private WithEvents txtPatientInsuranceIssueDate As TextBox
    Private WithEvents txtPatientInsuranceId As TextBox
    Private WithEvents lblInsIssDate As Label
    Private WithEvents Label13 As Label
    Private WithEvents lblInsExpDate As Label
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
    Private WithEvents lblTitle As Label
    Private WithEvents dgvAppointments As DataGridView
    Private WithEvents btnViewAppointment As Button
    Friend WithEvents colAppointId As DataGridViewTextBoxColumn
    Friend WithEvents colAppointResult As DataGridViewTextBoxColumn
    Friend WithEvents colAppointPrescribe As DataGridViewTextBoxColumn
    Friend WithEvents colEmployeeId As DataGridViewTextBoxColumn
    Friend WithEvents colAppointEName As DataGridViewTextBoxColumn
    Friend WithEvents colAppointCreateTime As DataGridViewTextBoxColumn
    Friend WithEvents colClinicId As DataGridViewTextBoxColumn
    Friend WithEvents colAppointClinicName As DataGridViewTextBoxColumn
    Friend WithEvents colAppointNo As DataGridViewTextBoxColumn
    Friend WithEvents colDoctorId As DataGridViewTextBoxColumn
    Friend WithEvents colAppointDoctorName As DataGridViewTextBoxColumn
End Class
