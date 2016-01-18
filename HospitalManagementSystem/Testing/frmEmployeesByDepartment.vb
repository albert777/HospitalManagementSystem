Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Imports Microsoft.Office.Interop



Public Class frmEmployeesByDepartment
    Private _dbAccess As DataBaseAccess
    Private _departmentBus As BusiDepartment
    Private _employeeBus As BusiEmployee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _dbAccess = New DataBaseAccess
        _departmentBus = New BusiDepartment
        _employeeBus = New BusiEmployee

        cboxEmployeeDepartment.DataSource = _departmentBus.LoadDepartmentsList()
        cboxEmployeeDepartment.SelectedIndex = -1


    End Sub

    Private Sub cboxEmployeeDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxEmployeeDepartment.SelectedIndexChanged
        If cboxEmployeeDepartment.SelectedIndex <> -1 Then
            LoadEmployeesList(CInt(cboxEmployeeDepartment.SelectedValue))
        Else
            dgrEmplResult.DataSource = _employeeBus.SearchEmployees
        End If
    End Sub

    Private Sub LoadEmployeesList(DeptId As Integer)
        dgrEmplResult.AutoGenerateColumns = False

        dgrEmplResult.DataSource = _employeeBus.SearchEmployeesByDeptId(DeptId)
        dgrEmplResult.ClearSelection()
    End Sub

    Private Sub frmEmployeesByDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim report As New rptEmployeesByDepartment
        report.EMPLOYEESTableAdapter.Fill(New dbHospitalDataSet1.EMPLOYEESDataTable(CType(dgrEmplResult.DataSource, DataTable)))
        report.ReportViewer1.RefreshReport()
        report.Show()
    End Sub
End Class