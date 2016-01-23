Public Class XfrmDeleteAccount
    Private _accBus As New BUS.BusiAccount

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        OK_Button.Enabled = False

        If txtUsername.Text.Trim = "" Then
            ErrorProvider1.SetError(txtUsername, "Bạn cần nhập tên tài khoản!")
        Else
            If Not (_accBus.ExistUsername(txtUsername.Text.Trim)) Then
                ErrorProvider1.SetError(txtUsername, "Không tồn tại tài khoản!")
            Else
                ErrorProvider1.SetError(txtUsername, "")
                OK_Button.Enabled = True
            End If
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If _accBus.DeleteAccount(txtUsername.Text.Trim) Then
            Me.Close()
        End If
    End Sub
End Class