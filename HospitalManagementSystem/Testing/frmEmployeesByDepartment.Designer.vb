<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeesByDepartment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxEmployeeDepartment = New System.Windows.Forms.ComboBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.dgrEmplResult = New System.Windows.Forms.DataGridView()
        Me.colEmplId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplBasicSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmplSubsidy = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.colEmplDeptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExcel = New System.Windows.Forms.Button()
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DANH SÁCH NHÂN VIÊN THEO KHOA"
        '
        'cboxEmployeeDepartment
        '
        Me.cboxEmployeeDepartment.DisplayMember = "Name"
        Me.cboxEmployeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEmployeeDepartment.FormattingEnabled = True
        Me.cboxEmployeeDepartment.Location = New System.Drawing.Point(76, 50)
        Me.cboxEmployeeDepartment.Name = "cboxEmployeeDepartment"
        Me.cboxEmployeeDepartment.Size = New System.Drawing.Size(307, 21)
        Me.cboxEmployeeDepartment.TabIndex = 31
        Me.cboxEmployeeDepartment.ValueMember = "Id"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(12, 53)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(39, 16)
        Me.lblDept.TabIndex = 30
        Me.lblDept.Text = "Khoa"
        '
        'btnReport
        '
        Me.btnReport.Enabled = False
        Me.btnReport.Location = New System.Drawing.Point(595, 50)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 33
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
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
        Me.dgrEmplResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmplId, Me.colEmplBasicSalary, Me.colEmplSubsidy, Me.colEmplSpecId, Me.colEmplName, Me.colEmplPosition, Me.colchkboxEmplSex, Me.colEmplIdCard, Me.colEmplDoB, Me.colEmplAddress, Me.colEmplPhone, Me.colEmplFolk, Me.colEmplDeptName, Me.colEmplSpecName, Me.colEmplHireDate, Me.colEmplRatio, Me.colEmplDeptId})
        Me.dgrEmplResult.Location = New System.Drawing.Point(12, 77)
        Me.dgrEmplResult.MultiSelect = False
        Me.dgrEmplResult.Name = "dgrEmplResult"
        Me.dgrEmplResult.ReadOnly = True
        Me.dgrEmplResult.RowHeadersVisible = False
        Me.dgrEmplResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgrEmplResult.Size = New System.Drawing.Size(658, 312)
        Me.dgrEmplResult.TabIndex = 34
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
        Me.colEmplPosition.Visible = False
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
        Me.colEmplIdCard.Visible = False
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
        Me.colEmplDeptName.Visible = False
        Me.colEmplDeptName.Width = 57
        '
        'colEmplSpecName
        '
        Me.colEmplSpecName.DataPropertyName = "SpecName"
        Me.colEmplSpecName.Frozen = True
        Me.colEmplSpecName.HeaderText = "Chuyên môn"
        Me.colEmplSpecName.Name = "colEmplSpecName"
        Me.colEmplSpecName.ReadOnly = True
        Me.colEmplSpecName.Visible = False
        Me.colEmplSpecName.Width = 91
        '
        'colEmplHireDate
        '
        Me.colEmplHireDate.DataPropertyName = "HireDate"
        Me.colEmplHireDate.Frozen = True
        Me.colEmplHireDate.HeaderText = "Ngày thuê"
        Me.colEmplHireDate.Name = "colEmplHireDate"
        Me.colEmplHireDate.ReadOnly = True
        Me.colEmplHireDate.Visible = False
        Me.colEmplHireDate.Width = 81
        '
        'colEmplRatio
        '
        Me.colEmplRatio.DataPropertyName = "Ratio"
        Me.colEmplRatio.Frozen = True
        Me.colEmplRatio.HeaderText = "Bậc lương"
        Me.colEmplRatio.Name = "colEmplRatio"
        Me.colEmplRatio.ReadOnly = True
        Me.colEmplRatio.Visible = False
        Me.colEmplRatio.Width = 80
        '
        'colEmplDeptId
        '
        Me.colEmplDeptId.DataPropertyName = "DeptId"
        Me.colEmplDeptId.Frozen = True
        Me.colEmplDeptId.HeaderText = "Mã Khoa"
        Me.colEmplDeptId.Name = "colEmplDeptId"
        Me.colEmplDeptId.ReadOnly = True
        Me.colEmplDeptId.Width = 75
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(514, 50)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 35
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'frmEmployeesByDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 401)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.dgrEmplResult)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.cboxEmployeeDepartment)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmployeesByDepartment"
        Me.Text = "Danh sách Nhân viên theo Khoa"
        CType(Me.dgrEmplResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboxEmployeeDepartment As ComboBox
    Private WithEvents lblDept As Label
    Friend WithEvents btnReport As Button
    Private WithEvents dgrEmplResult As DataGridView
    Friend WithEvents colEmplId As DataGridViewTextBoxColumn
    Friend WithEvents colEmplBasicSalary As DataGridViewTextBoxColumn
    Friend WithEvents colEmplSubsidy As DataGridViewTextBoxColumn
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
    Friend WithEvents colEmplDeptId As DataGridViewTextBoxColumn
    Friend WithEvents btnExcel As Button
End Class
