Imports DevExpress.XtraBars
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Public Class RfrmMain
    Private dbAccess As New DataBaseAccess

    Friend _account As Account
    Private _accountBus As BusiAccount
    Private _employeeBus As BusiEmployee

    Private frmStaffManager As New frmStaffManager
    Private frmCategoryManager As New frmCategoryManager
    Private frmPatientManager As frmPatientManager
    Private frmUpdateAppointment_EnterID As New frmUpdateAppointment_EnterId
    Private frmAccountsManager As New RfrmAccountsManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmPatientManager = New frmPatientManager

        _account = Nothing
        _accountBus = New BusiAccount
        _employeeBus = New BusiEmployee

        CheckSeasion()
    End Sub

    Private Sub HideAllMdi()
        Try
            Me.frmStaffManager.Hide()
            Me.frmCategoryManager.Hide()
            Me.frmPatientManager.Hide()
            Me.frmUpdateAppointment_EnterID.Hide()
            Me.frmAccountsManager.Hide()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bbiAccountInformation_ItemClick(sender As Object, e As EventArgs) _
        Handles bbiAccountInformation.ItemClick, bbiAccountTop.ItemClick, aceAccountName.Click, aceEmployeeName.Click, aceEmployeeRole.Click
        Dim frmAccountDetail As New frmAccountInformation(_account)
        frmAccountDetail.ShowDialog()
    End Sub

    Private Sub bbiLogout_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiLogout.ItemClick, bbtnLogout.ItemClick
        Application.Restart()
    End Sub

    Private Sub bbiExitTop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbiExitTop.ItemClick, bbtnExit.ItemClick
        Application.Exit()
    End Sub

    Private Sub aceEmployees_Click(sender As Object, e As EventArgs) Handles aceEmployees.Click
        HideAllMdi()
        Try
            If Me.frmStaffManager Is Nothing Then
                Me.frmStaffManager = New frmStaffManager
            End If

            Me.frmStaffManager.MdiParent = Me
            Me.frmStaffManager.Show()

        Catch ex As Exception
            'txtStatus.Text = "Lỗi: Không thể mở Danh mục nhân viên."

        End Try
    End Sub

    Private Sub aceCategories_Click(sender As Object, e As EventArgs) Handles aceCategories.Click
        HideAllMdi()

        Try
            If Me.frmCategoryManager Is Nothing Then
                Me.frmCategoryManager = New frmCategoryManager
            End If

            Me.frmCategoryManager.MdiParent = Me
            Me.frmCategoryManager.Show()
        Catch ex As Exception
            'txtStatus.Text = "Lỗi: Không thể mở Danh mục Khoa, Ngành, Phòng khám, Giường bệnh."

        End Try
    End Sub

    Private Sub acePatients_Click(sender As Object, e As EventArgs) Handles acePatients.Click
        HideAllMdi()

        Try
            If Me.frmPatientManager Is Nothing Then
                Me.frmPatientManager = New frmPatientManager
            End If

            Me.frmPatientManager.MdiParent = Me
            Me.frmPatientManager.Show()
        Catch ex As Exception
            'txtStatus.Text = "Lỗi: Không thể mở Danh mục Bệnh nhân."

        End Try
    End Sub

    Private Sub aceUpdateAppointment_Click(sender As Object, e As EventArgs) Handles aceUpdateAppointment.Click
        HideAllMdi()

        Try
            If Me.frmUpdateAppointment_EnterID Is Nothing Then
                Me.frmUpdateAppointment_EnterID = New frmUpdateAppointment_EnterId
            End If

            Me.frmUpdateAppointment_EnterID.MdiParent = Me
            Me.frmUpdateAppointment_EnterID.Show()
        Catch ex As Exception
            'txtStatus.Text = "Lỗi: Không thể mở Cập nhật kết quả phiếu khám."

        End Try
    End Sub

    Private Sub RfrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            dbAccess.OpenConnection()
            'txtStatus.Text = "Đã kết nối Database!"



        Catch ex As Exception
            dbAccess.CloseConnection()
            'txtStatus.Text = "Kết nối Database thất bại!"
            'Application.Exit()
        End Try

    End Sub


    Private Sub RfrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
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

                aceAccountName.Text = "Tên tài khoản: " + _account.Username
                aceEmployeeName.Text = "Tên nhân viên: " + _account.Employee.Name
                aceEmployeeRole.Text = "Vị trí: " + _account.Role.ToString
                aceSystemTime.Text = "Thời gian hệ thống: " + Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString



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
                aceMain.Visible = True
                aceHealth.Visible = True
                acePatients.Visible = True
                aceUpdateAppointment.Visible = True
                bbiAddAccount.Visibility = BarItemVisibility.Always

            Case Account.AccountRole.Doctor
                aceMain.Visible = False
                aceHealth.Visible = True
                acePatients.Visible = False
                aceUpdateAppointment.Visible = True
                bbiAddAccount.Visibility = BarItemVisibility.Never

            Case Account.AccountRole.Receptiontist
                aceMain.Visible = False
                aceHealth.Visible = True
                acePatients.Visible = True
                aceUpdateAppointment.Visible = False
                bbiAddAccount.Visibility = BarItemVisibility.Never

            Case Else
                aceMain.Visible = False
                aceHealth.Visible = False
                acePatients.Visible = False
                aceUpdateAppointment.Visible = False
                bbiAddAccount.Visibility = BarItemVisibility.Never

                MsgBox("Bạn không có quyền hạn truy cập phần mềm!")
                Application.Restart()
        End Select

    End Sub

    Private Sub bbiAbout_ItemClick(sender As Object, e As EventArgs) Handles bbiAbout.ItemClick, bbiAboutTop.ItemClick, aceVersion.Click
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog()
    End Sub

    Private Sub bbiAddAccount_ItemClick(sender As Object, e As EventArgs) Handles bbiAddAccount.ItemClick, aceAccounts.Click
        HideAllMdi()

        Try
            If Me.frmAccountsManager Is Nothing Then
                Me.frmAccountsManager = New RfrmAccountsManager
            End If

            Me.frmAccountsManager.MdiParent = Me
            Me.frmAccountsManager.Show()
        Catch ex As Exception
            'txtStatus.Text = "Lỗi: Không thể mở Cập nhật kết quả phiếu khám."

        End Try
    End Sub
End Class