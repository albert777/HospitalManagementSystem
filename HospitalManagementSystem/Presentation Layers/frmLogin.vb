Imports HospitalManagementSystem.DTO

Public Class frmLogin
    Public Account As New Account

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Account = New Account(tboxUsername.Text, tboxPassword.Text)
        Me.Close()
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
        End
    End Sub
End Class