Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class Dialog1
    Private _emplBus As New BUS.BusiEmployee

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        PrintDocument1.Print()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        PrintPreviewDialog1.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsetEmployeeInformation.dtableEmployeeInformation' table. You can move, or remove it, as needed.
        Me.dtableEmployeeInformationTableAdapter.Fill(Me.dsetEmployeeInformation.dtableEmployeeInformation)
        'ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsetEmployee", _emplBus.SearchEmployees()))

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class
