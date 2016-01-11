Imports System.Windows.Forms
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmAccountChangePassword
    Private _accBus As BusiAccount
    Private _account As Account

    Public Property Account As Account
        Get
            Return _account
        End Get
        Set(value As Account)
            _account = value
        End Set
    End Property

    Public Sub New(ByRef account As Account)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _accBus = New BusiAccount
        Me.Account = account

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If _accBus.ChangePassword(Account.Username, txtRepeatPassword.Text.Trim) Then
            Account.Password = txtRepeatPassword.Text.Trim
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.Close()
    End Sub

    Private Sub txtAccountUsername_TextChanged(sender As Object, e As EventArgs) Handles txtAccountPasswordOld.TextChanged
        If _accBus.CheckAccount(Account.Username, txtAccountPasswordOld.Text.Trim) Then
            ErrorProvider1.SetError(txtAccountPasswordOld, "")
        Else
            ErrorProvider1.SetError(txtAccountPasswordOld, "Mật khẩu cũ không chính xác")
        End If
    End Sub

    Private Sub txtRepeatPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRepeatPassword.TextChanged
        OK_Button.Enabled = False

        If txtAccountPassword.Text.Trim <> txtRepeatPassword.Text.Trim Then
            ErrorProvider1.SetError(txtRepeatPassword, "Mật khẩu không trùng khớp")
            ErrorProvider1.SetError(txtAccountPassword, "Mật khẩu không trùng khớp")
        Else
            ErrorProvider1.SetError(txtRepeatPassword, "")
            ErrorProvider1.SetError(txtAccountPassword, "")

            If _accBus.CheckAccount(Account.Username, txtAccountPasswordOld.Text.Trim) AndAlso (txtAccountPassword.Text.Trim = txtRepeatPassword.Text.Trim) Then
                OK_Button.Enabled = True
            End If
        End If
    End Sub
End Class
