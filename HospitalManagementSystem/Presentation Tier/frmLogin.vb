Imports System.ComponentModel
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmLogin
    Public Account As Account
    Public _loginResult As DialogResult = DialogResult.No

    Private _accBus As BusiAccount

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Account = Nothing
        _accBus = New BusiAccount

        _loginResult = DialogResult.No

    End Sub

#Region "Windows Events"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ((String.IsNullOrWhiteSpace(tboxUsername.Text)) AndAlso (String.IsNullOrWhiteSpace(tboxPassword.Text))) Then
            MessageBox.Show("Bạn chưa nhập cả Tên đăng nhập và Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (String.IsNullOrWhiteSpace(tboxUsername.Text))
            MessageBox.Show("Bạn chưa nhập Tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (String.IsNullOrWhiteSpace(tboxPassword.Text))
            MessageBox.Show("Bạn chưa nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If (_accBus.CheckAccount(tboxUsername.Text, tboxPassword.Text)) Then
                Account = New Account(tboxUsername.Text, tboxPassword.Text)
                Account.Employee = New RecordsSystem
                Account.Role = Account.AccountRole.RecordsSystem

                _loginResult = DialogResult.OK
                Me.Close()

            Else
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu bạn vừa nhập không đúng!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Account = Nothing
                _loginResult = DialogResult.No
            End If

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tboxUsername.Clear()
        tboxPassword.Clear()
        tboxUsername.Focus()
    End Sub

    Private Sub chkboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxShowPassword.CheckedChanged
        If (chkboxShowPassword.Checked = True) Then
            tboxPassword.PasswordChar = CChar("")
        Else
            tboxPassword.PasswordChar = CChar("*")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Dim resultExit As Integer = MessageBox.Show("Bạn có muốn thoát", "Thoát Đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If (resultExit = DialogResult.Yes) Then
        'Me.DialogResult = DialogResult.No
        Account = Nothing
        _loginResult = DialogResult.No
        Application.Exit()
        'End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loginResult = DialogResult.No
    End Sub

#End Region


End Class