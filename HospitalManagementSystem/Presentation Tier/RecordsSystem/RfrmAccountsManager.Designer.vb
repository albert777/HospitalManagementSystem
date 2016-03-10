﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RfrmAccountsManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RfrmAccountsManager))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains1 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains2 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains3 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Me.bgcRole = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiAddAccount = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDeleteAccount = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReLoadAccounts = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiHideAccounts = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gcStaffs = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bgcAccount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bgc5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bgc6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.bgc12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc15 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bgc16 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcStaffs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.bbiAddAccount, Me.bbiDeleteAccount, Me.bbiReLoadAccounts, Me.bbiHideAccounts})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl.Size = New System.Drawing.Size(1046, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'bbiAddAccount
        '
        Me.bbiAddAccount.Caption = "Thêm Tài khoản"
        Me.bbiAddAccount.Glyph = CType(resources.GetObject("bbiAddAccount.Glyph"), System.Drawing.Image)
        Me.bbiAddAccount.Id = 1
        Me.bbiAddAccount.Name = "bbiAddAccount"
        Me.bbiAddAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bbiDeleteAccount
        '
        Me.bbiDeleteAccount.Caption = "Xóa Tài khoản"
        Me.bbiDeleteAccount.Glyph = CType(resources.GetObject("bbiDeleteAccount.Glyph"), System.Drawing.Image)
        Me.bbiDeleteAccount.Id = 2
        Me.bbiDeleteAccount.Name = "bbiDeleteAccount"
        Me.bbiDeleteAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bbiReLoadAccounts
        '
        Me.bbiReLoadAccounts.Caption = "Làm mới"
        Me.bbiReLoadAccounts.Glyph = CType(resources.GetObject("bbiReLoadAccounts.Glyph"), System.Drawing.Image)
        Me.bbiReLoadAccounts.Id = 3
        Me.bbiReLoadAccounts.Name = "bbiReLoadAccounts"
        Me.bbiReLoadAccounts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bbiHideAccounts
        '
        Me.bbiHideAccounts.Caption = "Đóng"
        Me.bbiHideAccounts.Id = 4
        Me.bbiHideAccounts.ImageUri.Uri = "Close"
        Me.bbiHideAccounts.Name = "bbiHideAccounts"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Hệ thống"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiAddAccount)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiDeleteAccount)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiReLoadAccounts)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbiHideAccounts)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Quản lý Tài khoản"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 570)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1046, 31)
        '
        'gcStaffs
        '
        Me.gcStaffs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStaffs.Location = New System.Drawing.Point(0, 143)
        Me.gcStaffs.MainView = Me.AdvBandedGridView1
        Me.gcStaffs.Name = "gcStaffs"
        Me.gcStaffs.Size = New System.Drawing.Size(1046, 427)
        Me.gcStaffs.TabIndex = 2
        Me.gcStaffs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand5, Me.gridBand2, Me.gridBand3, Me.gridBand4})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.bgc1, Me.bgc5, Me.bgc3, Me.bgc2, Me.bgc10, Me.bgc4, Me.bgc11, Me.bgc9, Me.bgc7, Me.bgc6, Me.bgc8, Me.bgc12, Me.bgc13, Me.bgc14, Me.bgc15, Me.bgc16, Me.bgcAccount, Me.bgcRole})
        GridFormatRule1.Column = Me.bgcRole
        GridFormatRule1.ColumnApplyTo = Me.bgcAccount
        GridFormatRule1.Name = "Records System"
        FormatConditionRuleContains1.PredefinedName = "Red Fill"
        FormatConditionRuleContains1.Values = CType(resources.GetObject("FormatConditionRuleContains1.Values"), System.Collections.IList)
        GridFormatRule1.Rule = FormatConditionRuleContains1
        GridFormatRule2.Column = Me.bgcRole
        GridFormatRule2.ColumnApplyTo = Me.bgcAccount
        GridFormatRule2.Name = "Receptionist"
        FormatConditionRuleContains2.PredefinedName = "Yellow Fill, Yellow Text"
        FormatConditionRuleContains2.Values = CType(resources.GetObject("FormatConditionRuleContains2.Values"), System.Collections.IList)
        GridFormatRule2.Rule = FormatConditionRuleContains2
        GridFormatRule3.Column = Me.bgcRole
        GridFormatRule3.ColumnApplyTo = Me.bgcAccount
        GridFormatRule3.Name = "Doctor"
        FormatConditionRuleContains3.PredefinedName = "Green Fill"
        FormatConditionRuleContains3.Values = CType(resources.GetObject("FormatConditionRuleContains3.Values"), System.Collections.IList)
        GridFormatRule3.Rule = FormatConditionRuleContains3
        Me.AdvBandedGridView1.FormatRules.Add(GridFormatRule1)
        Me.AdvBandedGridView1.FormatRules.Add(GridFormatRule2)
        Me.AdvBandedGridView1.FormatRules.Add(GridFormatRule3)
        Me.AdvBandedGridView1.GridControl = Me.gcStaffs
        Me.AdvBandedGridView1.GroupPanelText = "Danh sách Nhân viên"
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.AdvBandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdvBandedGridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.AdvBandedGridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.AdvBandedGridView1.OptionsBehavior.ReadOnly = True
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
        'bgcAccount
        '
        Me.bgcAccount.Caption = "Username"
        Me.bgcAccount.FieldName = "Username"
        Me.bgcAccount.Name = "bgcAccount"
        Me.bgcAccount.Visible = True
        Me.bgcAccount.Width = 111
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
        'gridBand3
        '
        Me.gridBand3.Caption = "Địa chỉ"
        Me.gridBand3.Columns.Add(Me.bgc6)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 216
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
        'RfrmAccountsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 601)
        Me.Controls.Add(Me.gcStaffs)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "RfrmAccountsManager"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Quản lý Tài khoản"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcStaffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gcStaffs As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bgcAccount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgcRole As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bgc5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bgc6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bgc12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc15 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bgc16 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bbiAddAccount As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiDeleteAccount As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiReLoadAccounts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiHideAccounts As DevExpress.XtraBars.BarButtonItem
End Class