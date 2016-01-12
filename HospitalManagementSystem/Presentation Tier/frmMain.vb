Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Public Class frmMain
    Private dbAccess As New DataBaseAccess

    Friend _account As Account
    Private _accountBus As BusiAccount
    Private _employeeBus As BusiEmployee

    Private frmStaffManager As New frmStaffManager
    Private frmCategoryManager As New frmCategoryManager
    Private frmPatientManager As frmPatientManager
    Private frmUpdateAppointment_EnterID As New frmUpdateAppointment_EnterId

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmPatientManager = New frmPatientManager

        _account = Nothing
        _accountBus = New BusiAccount
        _employeeBus = New BusiEmployee

        tsmiRecordsSystems.Visible = False

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbAccess.OpenConnection()
            txtStatus.Text = "Đã kết nối Database!"

            CheckSeasion()

        Catch ex As Exception
            dbAccess.CloseConnection()
            txtStatus.Text = "Kết nối Database thất bại!"
            'Application.Exit()
        End Try

    End Sub

    Private Sub CheckSeasion()
        If (_account Is Nothing) Then
            Dim LoginResult As BusiAccount.LoginResult
            LoginResult = _accountBus.GetAccountViaLogin

            If (LoginResult.Result <> DialogResult.OK) Then
                _account = Nothing
                Application.Exit()

            End If

            Try
                _account = LoginResult.Account
                _account.Employee = _employeeBus.GetEmployeeByAccountId(_account.Employee.Id)
                lblEmployeeName.Text = _account.Employee.Name

                CheckPermission()

                HideAllMdi()

            Catch ex As Exception
                Application.Exit()
            End Try

        Else
            'Do nothing

        End If
    End Sub

    Private Sub CheckPermission()

        Select Case _account.Role
            Case Account.AccountRole.RecordsSystem
                tsmiRecordsSystems.Visible = True
                tsmiReceptiontist.Visible = True
                tsmiPatientManager.Visible = True
                tsmiUpdatePatientAppointment.Visible = True

            Case Account.AccountRole.Doctor
                tsmiRecordsSystems.Visible = False
                tsmiReceptiontist.Visible = True
                tsmiPatientManager.Visible = False
                tsmiUpdatePatientAppointment.Visible = True

            Case Account.AccountRole.Receptiontist
                tsmiRecordsSystems.Visible = False
                tsmiReceptiontist.Visible = True
                tsmiPatientManager.Visible = True
                tsmiUpdatePatientAppointment.Visible = False

            Case Else
                tsmiRecordsSystems.Visible = False
                tsmiReceptiontist.Visible = False
        End Select

    End Sub


    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            dbAccess.CloseConnection()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mitemLogout_Click(sender As Object, e As EventArgs) Handles mitemLogout.Click
        _account = Nothing
        CheckSeasion()
    End Sub

    Private Sub mitemExit_Click(sender As Object, e As EventArgs) Handles mitemExit.Click
        Application.Exit()
    End Sub

    Private Sub mitemAccountInformation_Click(sender As Object, e As EventArgs) Handles mitemAccountInformation.Click
        Dim frmAccountDetail As New frmAccountInformation(_account)
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
        Me.frmPatientManager.Hide()
        Me.frmUpdateAppointment_EnterID.Hide()
    End Sub

    Private Sub DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchKhoaNgànhPhòngKhámGiườngBệnhToolStripMenuItem.Click
        HideAllMdi()

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

    Private Sub DanhMụcBệnhNhânToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiPatientManager.Click
        HideAllMdi()

        Try
            If Me.frmPatientManager Is Nothing Then
                Me.frmPatientManager = New frmPatientManager
            End If

            Me.frmPatientManager.MdiParent = Me
            Me.frmPatientManager.Show()
        Catch ex As Exception
            txtStatus.Text = "Lỗi: Không thể mở Danh mục Bệnh nhân."

        End Try
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

    Private Sub CậpNhậtKếtQuảKhámToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiUpdatePatientAppointment.Click
        HideAllMdi()

        Try
            If Me.frmUpdateAppointment_EnterID Is Nothing Then
                Me.frmUpdateAppointment_EnterID = New frmUpdateAppointment_EnterId
            End If

            Me.frmUpdateAppointment_EnterID.MdiParent = Me
            Me.frmUpdateAppointment_EnterID.Show()
        Catch ex As Exception
            txtStatus.Text = "Lỗi: Không thể mở Cập nhật kết quả phiếu khám."

        End Try
    End Sub
End Class
