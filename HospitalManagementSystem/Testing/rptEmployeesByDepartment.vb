Imports System.Windows.Forms

Public Class rptEmployeesByDepartment

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbHospitalDataSet1.EMPLOYEES' table. You can move, or remove it, as needed.
        Me.EMPLOYEESTableAdapter.Fill(Me.dbHospitalDataSet1.EMPLOYEES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
