<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountDetail))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmdCusDelete = New System.Windows.Forms.Button()
        Me.cmdCusEdit = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtCusAddress = New System.Windows.Forms.TextBox()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdCusAddNew = New System.Windows.Forms.Button()
        Me.cmdCusSave = New System.Windows.Forms.Button()
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
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        'cmdCusDelete
        '
        Me.cmdCusDelete.BackgroundImage = CType(resources.GetObject("cmdCusDelete.BackgroundImage"), System.Drawing.Image)
        Me.cmdCusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCusDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCusDelete.Location = New System.Drawing.Point(98, 48)
        Me.cmdCusDelete.Name = "cmdCusDelete"
        Me.cmdCusDelete.Size = New System.Drawing.Size(80, 23)
        Me.cmdCusDelete.TabIndex = 25
        Me.cmdCusDelete.Text = "Xóa KH"
        Me.cmdCusDelete.UseVisualStyleBackColor = True
        '
        'cmdCusEdit
        '
        Me.cmdCusEdit.BackgroundImage = CType(resources.GetObject("cmdCusEdit.BackgroundImage"), System.Drawing.Image)
        Me.cmdCusEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCusEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCusEdit.Location = New System.Drawing.Point(10, 48)
        Me.cmdCusEdit.Name = "cmdCusEdit"
        Me.cmdCusEdit.Size = New System.Drawing.Size(80, 23)
        Me.cmdCusEdit.TabIndex = 24
        Me.cmdCusEdit.Text = "Sửa KH"
        Me.cmdCusEdit.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(12, 191)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 16)
        Me.label7.TabIndex = 85
        Me.label7.Text = "CMND số"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(12, 247)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 16)
        Me.label6.TabIndex = 84
        Me.label6.Text = "Địa chỉ"
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
        'txtCusAddress
        '
        Me.txtCusAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusAddress.Location = New System.Drawing.Point(84, 241)
        Me.txtCusAddress.Name = "txtCusAddress"
        Me.txtCusAddress.Size = New System.Drawing.Size(201, 22)
        Me.txtCusAddress.TabIndex = 88
        '
        'txtCusID
        '
        Me.txtCusID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCusID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusID.Location = New System.Drawing.Point(84, 56)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.ReadOnly = True
        Me.txtCusID.Size = New System.Drawing.Size(123, 22)
        Me.txtCusID.TabIndex = 86
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 135)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(68, 16)
        Me.label5.TabIndex = 83
        Me.label5.Text = "Họ tên KH"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 16)
        Me.label4.TabIndex = 82
        Me.label4.Text = "Mã KH"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnClose)
        Me.groupBox3.Controls.Add(Me.cmdCancel)
        Me.groupBox3.Controls.Add(Me.cmdCusDelete)
        Me.groupBox3.Controls.Add(Me.cmdCusEdit)
        Me.groupBox3.Controls.Add(Me.cmdCusAddNew)
        Me.groupBox3.Controls.Add(Me.cmdCusSave)
        Me.groupBox3.Location = New System.Drawing.Point(12, 305)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(276, 82)
        Me.groupBox3.TabIndex = 81
        Me.groupBox3.TabStop = False
        '
        'cmdCusAddNew
        '
        Me.cmdCusAddNew.BackgroundImage = CType(resources.GetObject("cmdCusAddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmdCusAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCusAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCusAddNew.Location = New System.Drawing.Point(10, 19)
        Me.cmdCusAddNew.Name = "cmdCusAddNew"
        Me.cmdCusAddNew.Size = New System.Drawing.Size(80, 23)
        Me.cmdCusAddNew.TabIndex = 21
        Me.cmdCusAddNew.Text = "Thêm mới"
        Me.cmdCusAddNew.UseVisualStyleBackColor = True
        '
        'cmdCusSave
        '
        Me.cmdCusSave.BackgroundImage = CType(resources.GetObject("cmdCusSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdCusSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCusSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCusSave.Location = New System.Drawing.Point(98, 19)
        Me.cmdCusSave.Name = "cmdCusSave"
        Me.cmdCusSave.Size = New System.Drawing.Size(80, 23)
        Me.cmdCusSave.TabIndex = 22
        Me.cmdCusSave.Text = "&Lưu khách"
        Me.cmdCusSave.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(83, 104)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(135, 13)
        Me.label9.TabIndex = 96
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
        Me.label12.TabIndex = 95
        Me.label12.Text = "---------------------------------------------------------------"
        '
        'txtCusEmail
        '
        Me.txtCusEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusEmail.Location = New System.Drawing.Point(84, 269)
        Me.txtCusEmail.Name = "txtCusEmail"
        Me.txtCusEmail.Size = New System.Drawing.Size(201, 22)
        Me.txtCusEmail.TabIndex = 93
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 275)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 16)
        Me.label2.TabIndex = 92
        Me.label2.Text = "EMail"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 219)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 16)
        Me.label1.TabIndex = 91
        Me.label1.Text = "Điện thoại"
        '
        'dtpCusBirthday
        '
        Me.dtpCusBirthday.CustomFormat = "dd/MM/yyyy"
        Me.dtpCusBirthday.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCusBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCusBirthday.Location = New System.Drawing.Point(84, 157)
        Me.dtpCusBirthday.Name = "dtpCusBirthday"
        Me.dtpCusBirthday.Size = New System.Drawing.Size(123, 22)
        Me.dtpCusBirthday.TabIndex = 90
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(12, 163)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(66, 16)
        Me.label10.TabIndex = 89
        Me.label10.Text = "Ngày sinh"
        '
        'txtCusPhoneNum
        '
        Me.txtCusPhoneNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusPhoneNum.Location = New System.Drawing.Point(84, 213)
        Me.txtCusPhoneNum.Mask = "00000000000000"
        Me.txtCusPhoneNum.Name = "txtCusPhoneNum"
        Me.txtCusPhoneNum.Size = New System.Drawing.Size(123, 22)
        Me.txtCusPhoneNum.TabIndex = 98
        '
        'txtCusIndentityID
        '
        Me.txtCusIndentityID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusIndentityID.Location = New System.Drawing.Point(84, 185)
        Me.txtCusIndentityID.Mask = "0000000000"
        Me.txtCusIndentityID.Name = "txtCusIndentityID"
        Me.txtCusIndentityID.Size = New System.Drawing.Size(123, 22)
        Me.txtCusIndentityID.TabIndex = 97
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(68, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(154, 16)
        Me.lblTitle.TabIndex = 94
        Me.lblTitle.Text = "THÔNG TIN TÀI KHOẢN"
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(84, 129)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(198, 22)
        Me.txtCusName.TabIndex = 87
        '
        'frmAccountDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HospitalManagementSystem.My.Resources.Resources.frmChild
        Me.ClientSize = New System.Drawing.Size(300, 400)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtCusAddress)
        Me.Controls.Add(Me.txtCusID)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.groupBox3)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(300, 400)
        Me.MinimumSize = New System.Drawing.Size(300, 400)
        Me.Name = "frmAccountDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin Tài khoản"
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnClose As Button
    Private WithEvents cmdCusDelete As Button
    Private WithEvents cmdCusEdit As Button
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents cmdCancel As Button
    Private WithEvents txtCusAddress As TextBox
    Private WithEvents txtCusID As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents cmdCusAddNew As Button
    Private WithEvents cmdCusSave As Button
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
End Class
