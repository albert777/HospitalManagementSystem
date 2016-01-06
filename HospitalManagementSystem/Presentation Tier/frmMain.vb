Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Public Class frmMain
    Private dbAccess As New DataBaseAccess

    Private _accountData As Account
    Private _accountBus As BusiAccount

    Private frmRecordsSystem As New frmStaffManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _accountData = Nothing
        _accountBus = New BusiAccount

        'CheckSeasion()

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

                Me.frmRecordsSystem.MdiParent = Me
                Me.frmRecordsSystem.Show()

            End If
        Else
            'Do nothing

        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbAccess.OpenConnection()
            lblEmployeeName.Text = "Đã kết nối Database!"

            CheckSeasion()

        Catch ex As Exception
            dbAccess.CloseConnection()
            lblEmployeeName.Text = "Kết nối Database thất bại!"

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
End Class
