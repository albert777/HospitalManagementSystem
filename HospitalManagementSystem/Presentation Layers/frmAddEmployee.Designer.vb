<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.label9 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtCusEmail = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtpCusBirthday = New System.Windows.Forms.DateTimePicker()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtCusPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.txtCusIndentityID = New System.Windows.Forms.MaskedTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmdEmplSave = New System.Windows.Forms.Button()
        Me.txtCusAddress = New System.Windows.Forms.TextBox()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmdEmplDelete = New System.Windows.Forms.Button()
        Me.cmdEmplEdit = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdEmplAddNew = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(83, 104)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(135, 13)
        Me.label9.TabIndex = 114
        Me.label9.Text = "THÔNG TIN CÁ NHÂN"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(21, 84)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(259, 13)
        Me.label12.TabIndex = 113
        Me.label12.Text = "---------------------------------------------------------------"
        '
        'txtCusEmail
        '
        Me.txtCusEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusEmail.Location = New System.Drawing.Point(109, 300)
        Me.txtCusEmail.Name = "txtCusEmail"
        Me.txtCusEmail.Size = New System.Drawing.Size(123, 22)
        Me.txtCusEmail.TabIndex = 111
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 303)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 16)
        Me.label2.TabIndex = 110
        Me.label2.Text = "Dân tộc"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 247)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 16)
        Me.label1.TabIndex = 109
        Me.label1.Text = "Điện thoại"
        '
        'dtpCusBirthday
        '
        Me.dtpCusBirthday.CustomFormat = "dd/MM/yyyy"
        Me.dtpCusBirthday.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCusBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCusBirthday.Location = New System.Drawing.Point(109, 188)
        Me.dtpCusBirthday.Name = "dtpCusBirthday"
        Me.dtpCusBirthday.Size = New System.Drawing.Size(123, 22)
        Me.dtpCusBirthday.TabIndex = 108
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(12, 191)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(66, 16)
        Me.label10.TabIndex = 107
        Me.label10.Text = "Ngày sinh"
        '
        'txtCusPhoneNum
        '
        Me.txtCusPhoneNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusPhoneNum.Location = New System.Drawing.Point(109, 244)
        Me.txtCusPhoneNum.Mask = "00000000000000"
        Me.txtCusPhoneNum.Name = "txtCusPhoneNum"
        Me.txtCusPhoneNum.Size = New System.Drawing.Size(123, 22)
        Me.txtCusPhoneNum.TabIndex = 116
        '
        'txtCusIndentityID
        '
        Me.txtCusIndentityID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusIndentityID.Location = New System.Drawing.Point(109, 216)
        Me.txtCusIndentityID.Mask = "0000000000"
        Me.txtCusIndentityID.Name = "txtCusIndentityID"
        Me.txtCusIndentityID.Size = New System.Drawing.Size(123, 22)
        Me.txtCusIndentityID.TabIndex = 115
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(70, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(164, 16)
        Me.lblTitle.TabIndex = 112
        Me.lblTitle.Text = "THÔNG TIN NHÂN VIÊN"
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(109, 132)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(173, 22)
        Me.txtCusName.TabIndex = 105
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(185, 48)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmdEmplSave
        '
        Me.cmdEmplSave.BackgroundImage = CType(resources.GetObject("cmdEmplSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdEmplSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEmplSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmplSave.Location = New System.Drawing.Point(98, 19)
        Me.cmdEmplSave.Name = "cmdEmplSave"
        Me.cmdEmplSave.Size = New System.Drawing.Size(80, 23)
        Me.cmdEmplSave.TabIndex = 22
        Me.cmdEmplSave.Text = "&Lưu khách"
        Me.cmdEmplSave.UseVisualStyleBackColor = True
        '
        'txtCusAddress
        '
        Me.txtCusAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusAddress.Location = New System.Drawing.Point(109, 272)
        Me.txtCusAddress.Name = "txtCusAddress"
        Me.txtCusAddress.Size = New System.Drawing.Size(173, 22)
        Me.txtCusAddress.TabIndex = 106
        '
        'txtCusID
        '
        Me.txtCusID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCusID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusID.Location = New System.Drawing.Point(110, 59)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.ReadOnly = True
        Me.txtCusID.Size = New System.Drawing.Size(123, 22)
        Me.txtCusID.TabIndex = 104
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 135)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(85, 16)
        Me.label5.TabIndex = 101
        Me.label5.Text = "Họ tên N.viên"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(95, 16)
        Me.label4.TabIndex = 100
        Me.label4.Text = "Mã Nhân viên"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackgroundImage = CType(resources.GetObject("cmdCancel.BackgroundImage"), System.Drawing.Image)
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(185, 19)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(80, 23)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "Bỏ qua"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(12, 219)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 16)
        Me.label7.TabIndex = 103
        Me.label7.Text = "CMND số"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(12, 275)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 16)
        Me.label6.TabIndex = 102
        Me.label6.Text = "Địa chỉ"
        '
        'cmdEmplDelete
        '
        Me.cmdEmplDelete.BackgroundImage = CType(resources.GetObject("cmdEmplDelete.BackgroundImage"), System.Drawing.Image)
        Me.cmdEmplDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEmplDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmplDelete.Location = New System.Drawing.Point(98, 48)
        Me.cmdEmplDelete.Name = "cmdEmplDelete"
        Me.cmdEmplDelete.Size = New System.Drawing.Size(80, 23)
        Me.cmdEmplDelete.TabIndex = 25
        Me.cmdEmplDelete.Text = "Xóa KH"
        Me.cmdEmplDelete.UseVisualStyleBackColor = True
        '
        'cmdEmplEdit
        '
        Me.cmdEmplEdit.BackgroundImage = CType(resources.GetObject("cmdEmplEdit.BackgroundImage"), System.Drawing.Image)
        Me.cmdEmplEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEmplEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmplEdit.Location = New System.Drawing.Point(10, 48)
        Me.cmdEmplEdit.Name = "cmdEmplEdit"
        Me.cmdEmplEdit.Size = New System.Drawing.Size(80, 23)
        Me.cmdEmplEdit.TabIndex = 24
        Me.cmdEmplEdit.Text = "Sửa KH"
        Me.cmdEmplEdit.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnClose)
        Me.groupBox3.Controls.Add(Me.cmdCancel)
        Me.groupBox3.Controls.Add(Me.cmdEmplDelete)
        Me.groupBox3.Controls.Add(Me.cmdEmplEdit)
        Me.groupBox3.Controls.Add(Me.cmdEmplAddNew)
        Me.groupBox3.Controls.Add(Me.cmdEmplSave)
        Me.groupBox3.Location = New System.Drawing.Point(12, 421)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(276, 82)
        Me.groupBox3.TabIndex = 99
        Me.groupBox3.TabStop = False
        '
        'cmdEmplAddNew
        '
        Me.cmdEmplAddNew.BackgroundImage = CType(resources.GetObject("cmdEmplAddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmdEmplAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEmplAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmplAddNew.Location = New System.Drawing.Point(10, 19)
        Me.cmdEmplAddNew.Name = "cmdEmplAddNew"
        Me.cmdEmplAddNew.Size = New System.Drawing.Size(80, 23)
        Me.cmdEmplAddNew.TabIndex = 21
        Me.cmdEmplAddNew.Text = "Thêm mới"
        Me.cmdEmplAddNew.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 160)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Giới tính"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(109, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 22)
        Me.TextBox2.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Khoa"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(109, 328)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 22)
        Me.TextBox3.TabIndex = 120
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Chức danh"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(109, 384)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 22)
        Me.TextBox4.TabIndex = 124
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 387)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 16)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Chuyên ngành"
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HospitalManagementSystem.My.Resources.Resources.frmChild
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(300, 515)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.txtCusEmail)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.dtpCusBirthday)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtCusPhoneNum)
        Me.Controls.Add(Me.txtCusIndentityID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.txtCusAddress)
        Me.Controls.Add(Me.txtCusID)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.groupBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Nhân viên"
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label9 As Label
    Private WithEvents label12 As Label
    Private WithEvents txtCusEmail As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents dtpCusBirthday As DateTimePicker
    Private WithEvents label10 As Label
    Private WithEvents txtCusPhoneNum As MaskedTextBox
    Private WithEvents txtCusIndentityID As MaskedTextBox
    Private WithEvents lblTitle As Label
    Private WithEvents txtCusName As TextBox
    Private WithEvents btnClose As Button
    Private WithEvents cmdEmplSave As Button
    Private WithEvents txtCusAddress As TextBox
    Private WithEvents txtCusID As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents cmdEmplDelete As Button
    Private WithEvents cmdEmplEdit As Button
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents cmdEmplAddNew As Button
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents TextBox4 As TextBox
    Private WithEvents Label13 As Label
End Class
