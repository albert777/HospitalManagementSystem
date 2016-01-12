Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Dialog1
    Private _dbAccess As New DAO.DataBaseAccess
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = TextBox1.Text.Trim
        Try
            con.Open()
            MsgBox("Kết nối thành công")
        Catch ex As Exception
            MsgBox("Kết nối thất bại")
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbHospitalDataSet.ACCOUNTS' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DbHospitalDataSet1.EMPLOYEES' table. You can move, or remove it, as needed.

    End Sub

End Class
