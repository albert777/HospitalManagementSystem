Public Class frmAccountDetail

#Region "Form Moving"
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Long

    Private Sub BorderlessWindowDrag(ByVal sender As Object, ByVal e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &HA1, 2, 0&)
    End Sub

    Private Sub frmAddCustomer_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        BorderlessWindowDrag(sender, e)
    End Sub

    Private Sub lblTitle_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        BorderlessWindowDrag(sender, e)
    End Sub
#End Region

    Private Sub frmAccountDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class