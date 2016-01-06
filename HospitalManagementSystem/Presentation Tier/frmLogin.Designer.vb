<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tboxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassWord = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tboxUsername = New System.Windows.Forms.TextBox()
        Me.lblHospitalName = New System.Windows.Forms.Label()
        Me.chkboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 139)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTitle.Location = New System.Drawing.Point(332, 113)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 22)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(343, 164)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(94, 13)
        Me.lblUserName.TabIndex = 14
        Me.lblUserName.Text = "Tên Tài khoản:"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(509, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 27)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "&Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tboxPassword
        '
        Me.tboxPassword.Location = New System.Drawing.Point(443, 194)
        Me.tboxPassword.Name = "tboxPassword"
        Me.tboxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboxPassword.Size = New System.Drawing.Size(110, 20)
        Me.tboxPassword.TabIndex = 17
        Me.tboxPassword.Text = "pass"
        '
        'lblPassWord
        '
        Me.lblPassWord.AutoSize = True
        Me.lblPassWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassWord.Location = New System.Drawing.Point(343, 197)
        Me.lblPassWord.Name = "lblPassWord"
        Me.lblPassWord.Size = New System.Drawing.Size(64, 13)
        Me.lblPassWord.TabIndex = 15
        Me.lblPassWord.Text = "Mật khẩu:"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(331, 256)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(83, 27)
        Me.btnLogin.TabIndex = 19
        Me.btnLogin.Text = "&Đăng Nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(420, 256)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 27)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "Nhập &Lại"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tboxUsername
        '
        Me.tboxUsername.Location = New System.Drawing.Point(443, 161)
        Me.tboxUsername.Name = "tboxUsername"
        Me.tboxUsername.Size = New System.Drawing.Size(110, 20)
        Me.tboxUsername.TabIndex = 16
        Me.tboxUsername.Text = "admin"
        '
        'lblHospitalName
        '
        Me.lblHospitalName.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblHospitalName.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospitalName.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHospitalName.Image = Global.HospitalManagementSystem.My.Resources.Resources.banner
        Me.lblHospitalName.Location = New System.Drawing.Point(12, 9)
        Me.lblHospitalName.Name = "lblHospitalName"
        Me.lblHospitalName.Size = New System.Drawing.Size(560, 76)
        Me.lblHospitalName.TabIndex = 26
        Me.lblHospitalName.Text = "QUẢN LÝ BỆNH VIỆN"
        Me.lblHospitalName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkboxShowPassword
        '
        Me.chkboxShowPassword.AutoSize = True
        Me.chkboxShowPassword.Location = New System.Drawing.Point(458, 223)
        Me.chkboxShowPassword.Name = "chkboxShowPassword"
        Me.chkboxShowPassword.Size = New System.Drawing.Size(95, 17)
        Me.chkboxShowPassword.TabIndex = 18
        Me.chkboxShowPassword.Text = "Hiện mật khẩu"
        Me.chkboxShowPassword.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(311, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(2, 198)
        Me.Label5.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Số máy Bộ phận Kỹ thuật: 01692 777 247."
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(584, 305)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tboxPassword)
        Me.Controls.Add(Me.lblPassWord)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.tboxUsername)
        Me.Controls.Add(Me.lblHospitalName)
        Me.Controls.Add(Me.chkboxShowPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập Hệ thống"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents tboxPassword As TextBox
    Friend WithEvents lblPassWord As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents tboxUsername As TextBox
    Friend WithEvents lblHospitalName As Label
    Friend WithEvents chkboxShowPassword As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
