<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.mitemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mitemAccountInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitemMain = New System.Windows.Forms.MenuStrip()
        Me.mitemMain.SuspendLayout()
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
        Me.mitemMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitemMenu})
        Me.mitemMain.Location = New System.Drawing.Point(0, 0)
        Me.mitemMain.Name = "mitemMain"
        Me.mitemMain.Size = New System.Drawing.Size(1084, 24)
        Me.mitemMain.TabIndex = 4
        Me.mitemMain.Text = "mstripMain"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 611)
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
End Class
