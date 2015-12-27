Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Public Class frmMain
    Public dbAccess As New DAO.DataBaseAccess

    Dim _accountData As New DTO.Account
    Dim _accountBus As New BUS.BusiAccount

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbAccess.OpenConnection()

            lblEmployeeName.Text = "Đã kết nối Database!"

            _accountData = _accountBus.GetViaLogin()

            Dim frmRecordsSystem As New frmRecordsSystem
            frmRecordsSystem.MdiParent = Me
            frmRecordsSystem.Show()
        Catch ex As Exception
            lblEmployeeName.Text = "Kết nối Database thất bại!"
            dbAccess.CloseConnection()
        End Try

    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            dbAccess.CloseConnection()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mitemExit_Click(sender As Object, e As EventArgs) Handles mitemExit.Click
        Me.Close()
    End Sub

    Private Sub mitemLogout_Click(sender As Object, e As EventArgs) Handles mitemLogout.Click

    End Sub

    Private Sub mitemAccountInformation_Click(sender As Object, e As EventArgs) Handles mitemAccountInformation.Click
        Dim frmAccountDetail As New frmAccountDetail
        frmAccountDetail.ShowDialog()
    End Sub
End Class
