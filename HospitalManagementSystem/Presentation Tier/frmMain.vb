﻿Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Public Class frmMain
    Private dbAccess As New DataBaseAccess

    Private _accountData As Account
    Private _accountBus As BusiAccount

    Private frmStaffManager As New frmStaffManager
    Private frmCategoryManager As New frmCategoryManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _accountData = Nothing
        _accountBus = New BusiAccount

        tsmiRecordsSystems.Visible = False

    End Sub

    Private Sub CheckSeasion()
        If (_accountData Is Nothing) Then
            Dim LoginResult As BusiAccount.LoginResult
            LoginResult = _accountBus.GetAccountViaLogin

            If (LoginResult.Result <> DialogResult.OK) Then
                _accountData = Nothing
                Application.Exit()

            Else
                _accountData = LoginResult.Account
                CheckPermission()

                HideAllMdi()

            End If
        Else
            'Do nothing

        End If
    End Sub

    Private Sub CheckPermission()

        Select Case _accountData.Role
            Case Account.AccountRole.RecordsSystem
                tsmiRecordsSystems.Visible = True

            Case Account.AccountRole.Doctor
                tsmiRecordsSystems.Visible = False

            Case Account.AccountRole.Receptiontist
                tsmiRecordsSystems.Visible = False

            Case Else
                tsmiRecordsSystems.Visible = False

        End Select

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbAccess.OpenConnection()
            txtStatus.Text = "Đã kết nối Database!"

            CheckSeasion()

        Catch ex As Exception
            dbAccess.CloseConnection()
            txtStatus.Text = "Kết nối Database thất bại!"

        End Try

    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            dbAccess.CloseConnection()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mitemLogout_Click(sender As Object, e As EventArgs) Handles mitemLogout.Click
        _accountData = Nothing
        CheckSeasion()
    End Sub

    Private Sub mitemExit_Click(sender As Object, e As EventArgs) Handles mitemExit.Click
        Application.Exit()
    End Sub

    Private Sub mitemAccountInformation_Click(sender As Object, e As EventArgs) Handles mitemAccountInformation.Click
        Dim frmAccountDetail As New frmAccountDetail
        frmAccountDetail.ShowDialog()
    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        HideAllMdi()

        Try
            If Me.frmStaffManager Is Nothing Then
                Me.frmStaffManager = New frmStaffManager
            End If

            Me.frmStaffManager.MdiParent = Me
            Me.frmStaffManager.Show()

        Catch ex As Exception
            txtStatus.Text = "Lỗi: Không thể mở Danh mục nhân viên."
            'Me.frmStaffManager = New frmStaffManager
            'Me.frmStaffManager.MdiParent = Me
            'Me.frmStaffManager.Show()
        End Try

    End Sub

    Private Sub HideAllMdi()
        Me.frmStaffManager.Hide()
        Me.frmCategoryManager.Hide()
    End Sub

    Private Sub DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem.Click
        'CloseAllMdi()
        Try
            If Me.frmCategoryManager Is Nothing Then
                Me.frmCategoryManager = New frmCategoryManager
            End If

            Me.frmCategoryManager.MdiParent = Me
            Me.frmCategoryManager.Show()
        Catch ex As Exception
            txtStatus.Text = "Lỗi: Không thể mở Danh mục Khoa, Ngành, Phòng khám, Giường bệnh."
            'Me.frmCategoryManager.Show()
        End Try

    End Sub

    Private Sub ShowNewForm(sender As Object, e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Hide()
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
    End Sub
End Class
