<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.mitemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mitemAccountInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemMain = New System.Windows.Forms.MenuStrip()
        Me.tsmiRecordsSystems = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReceptiontist = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPatientManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUpdatePatientAppointment = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mitemMain.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.DarkRed
        Me.lblEmployeeName.Location = New System.Drawing.Point(857, 5)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(75, 15)
        Me.lblEmployeeName.TabIndex = 6
        Me.lblEmployeeName.Text = "UserName"
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(783, 5)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(79, 15)
        Me.lblEmployee.TabIndex = 5
        Me.lblEmployee.Text = "Nhân viên: "
        '
        'mitemExit
        '
        Me.mitemExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mitemExit.Name = "mitemExit"
        Me.mitemExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mitemExit.Size = New System.Drawing.Size(180, 22)
        Me.mitemExit.Text = "Thoát"
        '
        'mitemLogout
        '
        Me.mitemLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mitemLogout.Name = "mitemLogout"
        Me.mitemLogout.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mitemLogout.Size = New System.Drawing.Size(180, 22)
        Me.mitemLogout.Text = "Đăng Xuất"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'mitemAccountInformation
        '
        Me.mitemAccountInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mitemAccountInformation.Name = "mitemAccountInformation"
        Me.mitemAccountInformation.Size = New System.Drawing.Size(180, 22)
        Me.mitemAccountInformation.Text = "Thông tin Tài khoản"
        '
        'mitemMenu
        '
        Me.mitemMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitemAccountInformation, Me.ToolStripSeparator1, Me.mitemLogout, Me.mitemExit})
        Me.mitemMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mitemMenu.Name = "mitemMenu"
        Me.mitemMenu.Size = New System.Drawing.Size(134, 20)
        Me.mitemMenu.Text = "QUẢN LÝ BỆNH VIỆN"
        '
        'mitemMain
        '
        Me.mitemMain.BackColor = System.Drawing.SystemColors.Control
        Me.mitemMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitemMenu, Me.tsmiRecordsSystems, Me.tsmiReceptiontist, Me.WindowsMenu, Me.HelpMenu})
        Me.mitemMain.Location = New System.Drawing.Point(0, 0)
        Me.mitemMain.Name = "mitemMain"
        Me.mitemMain.Size = New System.Drawing.Size(1084, 24)
        Me.mitemMain.TabIndex = 4
        Me.mitemMain.Text = "mstripMain"
        '
        'tsmiRecordsSystems
        '
        Me.tsmiRecordsSystems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchNhânViênToolStripMenuItem, Me.DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem})
        Me.tsmiRecordsSystems.Name = "tsmiRecordsSystems"
        Me.tsmiRecordsSystems.Size = New System.Drawing.Size(113, 20)
        Me.tsmiRecordsSystems.Text = "Quản lý Hệ thống"
        '
        'DanhSáchNhânViênToolStripMenuItem
        '
        Me.DanhSáchNhânViênToolStripMenuItem.Name = "DanhSáchNhânViênToolStripMenuItem"
        Me.DanhSáchNhânViênToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.DanhSáchNhânViênToolStripMenuItem.Text = "Danh sách Nhân viên"
        '
        'DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem
        '
        Me.DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem.Name = "DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem"
        Me.DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem.Text = "Danh sách Khoa, Ngành, Phòng khám, Giường bệnh"
        '
        'tsmiReceptiontist
        '
        Me.tsmiReceptiontist.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPatientManager, Me.tsmiUpdatePatientAppointment})
        Me.tsmiReceptiontist.Name = "tsmiReceptiontist"
        Me.tsmiReceptiontist.Size = New System.Drawing.Size(109, 20)
        Me.tsmiReceptiontist.Text = "Khám chữa bệnh"
        '
        'tsmiPatientManager
        '
        Me.tsmiPatientManager.Name = "tsmiPatientManager"
        Me.tsmiPatientManager.Size = New System.Drawing.Size(197, 22)
        Me.tsmiPatientManager.Text = "Danh mục bệnh nhân"
        '
        'tsmiUpdatePatientAppointment
        '
        Me.tsmiUpdatePatientAppointment.Name = "tsmiUpdatePatientAppointment"
        Me.tsmiUpdatePatientAppointment.Size = New System.Drawing.Size(197, 22)
        Me.tsmiUpdatePatientAppointment.Text = "Cập nhật kết quả khám"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseAllToolStripMenuItem.Text = "&Hide All"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "Thông tin ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1084, 22)
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "Version 18:14 11/01/16   "
        '
        'txtStatus
        '
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(39, 17)
        Me.txtStatus.Text = "Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblEmployee)
        Me.Controls.Add(Me.mitemMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trang chính"
        Me.mitemMain.ResumeLayout(False)
        Me.mitemMain.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblEmployee As Label
    Friend WithEvents mitemExit As ToolStripMenuItem
    Friend WithEvents mitemLogout As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mitemAccountInformation As ToolStripMenuItem
    Friend WithEvents mitemMenu As ToolStripMenuItem
    Friend WithEvents mitemMain As MenuStrip
    Friend WithEvents tsmiRecordsSystems As ToolStripMenuItem
    Friend WithEvents DanhSáchNhânViênToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents txtStatus As ToolStripStatusLabel
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiReceptiontist As ToolStripMenuItem
    Friend WithEvents tsmiPatientManager As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsmiUpdatePatientAppointment As ToolStripMenuItem
End Class
