<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RfrmStaffManager
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gcStaffs = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.bgc1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc16 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgcAccount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgcRole = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.gcStaffs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcStaffs
        '
        Me.gcStaffs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStaffs.Location = New System.Drawing.Point(0, 0)
        Me.gcStaffs.MainView = Me.AdvBandedGridView1
        Me.gcStaffs.Name = "gcStaffs"
        Me.gcStaffs.Size = New System.Drawing.Size(1032, 507)
        Me.gcStaffs.TabIndex = 0
        Me.gcStaffs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand5, Me.gridBand2, Me.gridBand3, Me.gridBand4})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bgc1, Me.bgc5, Me.bgc3, Me.bgc2, Me.bgc10, Me.bgc4, Me.bgc11, Me.bgc9, Me.bgc7, Me.bgc6, Me.bgc8, Me.bgc12, Me.bgc13, Me.bgc14, Me.bgc15, Me.bgc16, Me.bgcAccount, Me.bgcRole})
        Me.AdvBandedGridView1.GridControl = Me.gcStaffs
        Me.AdvBandedGridView1.GroupPanelText = "Danh sách Nhân viên"
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.AdvBandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdvBandedGridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.AdvBandedGridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.AdvBandedGridView1.OptionsBehavior.ReadOnly = True
        '
        'bgc1
        '
        Me.bgc1.AppearanceHeader.Options.UseTextOptions = True
        Me.bgc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bgc1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.bgc1.AutoFillDown = True
        Me.bgc1.Caption = "Ảnh"
        Me.bgc1.Name = "bgc1"
        Me.bgc1.Visible = True
        Me.bgc1.Width = 61
        '
        'bgc5
        '
        Me.bgc5.Caption = "Mã nhân viên"
        Me.bgc5.FieldName = "Id"
        Me.bgc5.Name = "bgc5"
        Me.bgc5.OptionsEditForm.StartNewRow = True
        Me.bgc5.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc5.Visible = True
        Me.bgc5.Width = 123
        '
        'bgc2
        '
        Me.bgc2.Caption = "Họ tên"
        Me.bgc2.FieldName = "Name"
        Me.bgc2.Name = "bgc2"
        Me.bgc2.OptionsEditForm.ColumnSpan = 2
        Me.bgc2.OptionsEditForm.StartNewRow = True
        Me.bgc2.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc2.Visible = True
        Me.bgc2.Width = 208
        '
        'bgc4
        '
        Me.bgc4.Caption = "Số điện thoại"
        Me.bgc4.FieldName = "Phone"
        Me.bgc4.Name = "bgc4"
        Me.bgc4.OptionsEditForm.StartNewRow = True
        Me.bgc4.Visible = True
        Me.bgc4.Width = 106
        '
        'bgc9
        '
        Me.bgc9.Caption = "Giới tính"
        Me.bgc9.FieldName = "Sex"
        Me.bgc9.Name = "bgc9"
        Me.bgc9.OptionsEditForm.StartNewRow = True
        Me.bgc9.Visible = True
        Me.bgc9.Width = 100
        '
        'bgc3
        '
        Me.bgc3.Caption = "Số Chứng minh thư"
        Me.bgc3.FieldName = "IdCard"
        Me.bgc3.Name = "bgc3"
        Me.bgc3.OptionsEditForm.Caption = "Số CMND:"
        Me.bgc3.RowIndex = 1
        Me.bgc3.Visible = True
        Me.bgc3.Width = 123
        '
        'bgc10
        '
        Me.bgc10.Caption = "Vị trí"
        Me.bgc10.FieldName = "Position"
        Me.bgc10.Name = "bgc10"
        Me.bgc10.OptionsEditForm.ColumnSpan = 2
        Me.bgc10.OptionsEditForm.StartNewRow = True
        Me.bgc10.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc10.RowIndex = 1
        Me.bgc10.Visible = True
        Me.bgc10.Width = 208
        '
        'bgc11
        '
        Me.bgc11.Caption = "Ngày sinh"
        Me.bgc11.FieldName = "DoB"
        Me.bgc11.Name = "bgc11"
        Me.bgc11.RowIndex = 1
        Me.bgc11.Visible = True
        Me.bgc11.Width = 106
        '
        'bgc7
        '
        Me.bgc7.Caption = "Dân tộc"
        Me.bgc7.FieldName = "Folk"
        Me.bgc7.Name = "bgc7"
        Me.bgc7.RowIndex = 1
        Me.bgc7.Visible = True
        Me.bgc7.Width = 100
        '
        'bgc6
        '
        Me.bgc6.AutoFillDown = True
        Me.bgc6.Caption = "Địa chỉ"
        Me.bgc6.FieldName = "Address"
        Me.bgc6.Name = "bgc6"
        Me.bgc6.OptionsEditForm.ColumnSpan = 3
        Me.bgc6.OptionsEditForm.RowSpan = 3
        Me.bgc6.OptionsEditForm.StartNewRow = True
        Me.bgc6.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc6.Visible = True
        Me.bgc6.Width = 216
        '
        'bgc12
        '
        Me.bgc12.Caption = "Chuyên môn"
        Me.bgc12.FieldName = "SpecName"
        Me.bgc12.Name = "bgc12"
        Me.bgc12.OptionsEditForm.ColumnSpan = 3
        Me.bgc12.OptionsEditForm.StartNewRow = True
        Me.bgc12.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc12.Visible = True
        Me.bgc12.Width = 152
        '
        'bgc14
        '
        Me.bgc14.Caption = "Bậc lương"
        Me.bgc14.FieldName = "Ratio"
        Me.bgc14.Name = "bgc14"
        Me.bgc14.Visible = True
        Me.bgc14.Width = 98
        '
        'bgc8
        '
        Me.bgc8.Caption = "Khoa"
        Me.bgc8.FieldName = "DeptName"
        Me.bgc8.Name = "bgc8"
        Me.bgc8.OptionsEditForm.ColumnSpan = 3
        Me.bgc8.OptionsEditForm.StartNewRow = True
        Me.bgc8.OptionsEditForm.UseEditorColRowSpan = False
        Me.bgc8.RowIndex = 1
        Me.bgc8.Visible = True
        Me.bgc8.Width = 152
        '
        'bgc13
        '
        Me.bgc13.Caption = "Ngày vào làm"
        Me.bgc13.FieldName = "HireDate"
        Me.bgc13.Name = "bgc13"
        Me.bgc13.OptionsEditForm.StartNewRow = True
        Me.bgc13.RowIndex = 1
        Me.bgc13.Visible = True
        Me.bgc13.Width = 98
        '
        'bgc15
        '
        Me.bgc15.Caption = "Lương cơ bản"
        Me.bgc15.FieldName = "BasicSalary"
        Me.bgc15.Name = "bgc15"
        Me.bgc15.OptionsEditForm.StartNewRow = True
        Me.bgc15.Visible = True
        '
        'bgc16
        '
        Me.bgc16.Caption = "Phụ cấp"
        Me.bgc16.FieldName = "Subsidy"
        Me.bgc16.Name = "bgc16"
        Me.bgc16.Visible = True
        '
        'bgcAccount
        '
        Me.bgcAccount.Caption = "Username"
        Me.bgcAccount.FieldName = "Username"
        Me.bgcAccount.Name = "bgcAccount"
        Me.bgcAccount.Visible = True
        Me.bgcAccount.Width = 111
        '
        'bgcRole
        '
        Me.bgcRole.Caption = "Role"
        Me.bgcRole.FieldName = "Role"
        Me.bgcRole.Name = "bgcRole"
        Me.bgcRole.RowIndex = 1
        Me.bgcRole.Visible = True
        Me.bgcRole.Width = 111
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "Tài khoản"
        Me.gridBand5.Columns.Add(Me.bgcAccount)
        Me.gridBand5.Columns.Add(Me.bgcRole)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 0
        Me.gridBand5.Width = 111
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Thông tin cá nhân"
        Me.gridBand2.Columns.Add(Me.bgc5)
        Me.gridBand2.Columns.Add(Me.bgc2)
        Me.gridBand2.Columns.Add(Me.bgc4)
        Me.gridBand2.Columns.Add(Me.bgc9)
        Me.gridBand2.Columns.Add(Me.bgc3)
        Me.gridBand2.Columns.Add(Me.bgc10)
        Me.gridBand2.Columns.Add(Me.bgc11)
        Me.gridBand2.Columns.Add(Me.bgc7)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 537
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Địa chỉ"
        Me.gridBand3.Columns.Add(Me.bgc6)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 216
        '
        'gridBand4
        '
        Me.gridBand4.Caption = "Thông tin công việc"
        Me.gridBand4.Columns.Add(Me.bgc12)
        Me.gridBand4.Columns.Add(Me.bgc14)
        Me.gridBand4.Columns.Add(Me.bgc8)
        Me.gridBand4.Columns.Add(Me.bgc13)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 3
        Me.gridBand4.Width = 250
        '
        'RfrmStaffManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 507)
        Me.Controls.Add(Me.gcStaffs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RfrmStaffManager"
        Me.Text = "RfrmStaffManager"
        CType(Me.gcStaffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcStaffs As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents bgc1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc16 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bgcAccount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgcRole As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
