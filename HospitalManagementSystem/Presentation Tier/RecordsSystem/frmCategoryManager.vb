Imports HospitalManagementSystem.BUS

Public Class frmCategoryManager
    Private _selectedRow_Department As DataGridViewRow
    Private _selectedRow_Clinic As DataGridViewRow
    Private _selectedSpeciality As DataRowView

    Private _deptBus As BusiDepartment
    Private _specBus As BusiSpeciality
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _selectedRow_Department = Nothing
        _selectedRow_Clinic = Nothing
        _selectedSpeciality = Nothing

        _deptBus = New BusiDepartment
        _specBus = New BusiSpeciality
    End Sub

    Private Sub frmCategoryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSpecialitiesList()
        LoadDepartmentsList()
        LoadDoctorsList()
    End Sub

    Private Sub LoadSpecialitiesList()
        lboxSpecialized.DataSource = _specBus.LoadSpecialitiesList
    End Sub

    Private Sub LoadDoctorsList()
        Try
            Dim dbAccess As New DAO.DataBaseAccess

            Dim query As String = "SELECT * 
                                   FROM EMPLOYEES"

            Dim dtableDoc As DataTable
            dtableDoc = dbAccess.GetDataTable(query)
            cboxDepartment_ChiefName.DataSource = dtableDoc
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadDepartmentsList()
        dgvDepartment.AutoGenerateColumns = False
        dgvDepartment.DataSource = _deptBus.LoadDepartmentsList

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

#Region "Department"
    Private Sub dgvDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartment.CellClick
        btnDept_Add.Enabled = False
        btnDept_Edit.Enabled = True
        btnDept_Delete.Enabled = True

        _selectedRow_Department = dgvDepartment.Rows(dgvDepartment.SelectedCells(0).RowIndex)

        tboxDepartment.Text = _selectedRow_Department.Cells(0).Value.ToString
        cboxDepartment_ChiefName.SelectedValue = _selectedRow_Department.Cells(colDeptChiefId.Name).Value

    End Sub

    Private Sub btnDept_Reset_Click(sender As Object, e As EventArgs) Handles btnDept_Reset.Click
        tboxDepartment.Clear()
        btnDept_Add.Enabled = True
        btnDept_Delete.Enabled = False
        btnDept_Edit.Enabled = False
        LoadDepartmentsList()
    End Sub

    Private Sub btnDept_Add_Click(sender As Object, e As EventArgs) Handles btnDept_Add.Click
        'Try
        If cboxDepartment_ChiefName.SelectedIndex <> -1 Then
                _deptBus.AddDepartment(tboxDepartment.Text.Trim, CInt(cboxDepartment_ChiefName.SelectedValue.ToString))
            Else
                _deptBus.AddDepartment(tboxDepartment.Text.Trim, -1)
            End If
        'Catch ex As Exception

        'End Try

        LoadDepartmentsList()
    End Sub

    Private Sub btnDept_Edit_Click(sender As Object, e As EventArgs) Handles btnDept_Edit.Click
        'Try
        If cboxDepartment_ChiefName.SelectedIndex <> -1 Then
                _deptBus.UpdateDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim,
                                      tboxDepartment.Text.Trim,
                                      CInt(cboxDepartment_ChiefName.SelectedValue.ToString))
            Else
                _deptBus.UpdateDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim,
                          tboxDepartment.Text.Trim,
                          -1)
            End If
            'Catch ex As Exception

            'End Try


            LoadDepartmentsList()
    End Sub

    Private Sub btnDept_Delete_Click(sender As Object, e As EventArgs) Handles btnDept_Delete.Click
        'Try
        _deptBus.DeleteDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim)
        'Catch ex As Exception

        'End Try

        LoadDepartmentsList()
    End Sub
#End Region

#Region "Specialized"
    Private Sub lboxSpecialized_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lboxSpecialized.SelectedIndexChanged

        If lboxSpecialized.SelectedIndex <> -1 Then
            btnSpec_Add.Enabled = False
            btnSpec_Delete.Enabled = True
            btnSpec_Edit.Enabled = True

            tboxSpecialized.Text = lboxSpecialized.Text
        End If

    End Sub

    Private Sub btnSpec_Reset_Click(sender As Object, e As EventArgs) Handles btnSpec_Reset.Click
        btnSpec_Add.Enabled = True
        btnSpec_Delete.Enabled = False
        btnSpec_Edit.Enabled = False
    End Sub

    Private Sub btnSpec_Add_Click(sender As Object, e As EventArgs) Handles btnSpec_Add.Click
        _specBus.AddSpeciality(tboxSpecialized.Text.Trim)
        LoadSpecialitiesList()
    End Sub

    Private Sub btnSpec_Edit_Click(sender As Object, e As EventArgs) Handles btnSpec_Edit.Click
        _specBus.UpdateSpeciality(lboxSpecialized.Text, tboxSpecialized.Text.Trim)
        LoadSpecialitiesList()
    End Sub

    Private Sub btnSpec_Delete_Click(sender As Object, e As EventArgs) Handles btnSpec_Delete.Click
        _specBus.DeleteSpeciality(tboxSpecialized.Text.Trim)
        LoadSpecialitiesList()
    End Sub
#End Region

#Region "Clinic"
    Private Sub dgvClinics_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClinics.CellClick
        btnClinic_Add.Enabled = False
        btnClinic_Delete.Enabled = True
        btnClinic_Edit.Enabled = True

        _selectedRow_Clinic = dgvClinics.Rows(dgvClinics.SelectedCells(0).RowIndex)
    End Sub

    Private Sub btnClinic_Reset_Click(sender As Object, e As EventArgs) Handles btnClinic_Reset.Click
        btnClinic_Add.Enabled = True
        btnClinic_Delete.Enabled = False
        btnClinic_Edit.Enabled = False
    End Sub

    Private Sub btnClinic_Add_Click(sender As Object, e As EventArgs) Handles btnClinic_Add.Click

    End Sub

    Private Sub btnClinic_Edit_Click(sender As Object, e As EventArgs) Handles btnClinic_Edit.Click

    End Sub

    Private Sub btnClinic_Delete_Click(sender As Object, e As EventArgs) Handles btnClinic_Delete.Click

    End Sub
#End Region

#Region "Bed"
    Private Sub dgvBeds_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBeds.CellClick
        btnBed_Add.Enabled = False
        btnBed_Delete.Enabled = True
        btnBed_Edit.Enabled = True
    End Sub

    Private Sub btnBed_Reset_Click(sender As Object, e As EventArgs) Handles btnBed_Reset.Click
        btnBed_Add.Enabled = True
        btnBed_Delete.Enabled = False
        btnBed_Edit.Enabled = False
    End Sub

    Private Sub btnBed_Add_Click(sender As Object, e As EventArgs) Handles btnBed_Add.Click

    End Sub

    Private Sub btnBed_Edit_Click(sender As Object, e As EventArgs) Handles btnBed_Edit.Click

    End Sub

    Private Sub btnBed_Delete_Click(sender As Object, e As EventArgs) Handles btnBed_Delete.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbDeptChief.CheckedChanged
        If chkbDeptChief.CheckState = CheckState.Checked Then
            lblDeptChief.Enabled = True
            cboxDepartment_ChiefName.Enabled = True
        Else
            lblDeptChief.Enabled = False
            cboxDepartment_ChiefName.Enabled = False
            cboxDepartment_ChiefName.SelectedIndex = -1
        End If
    End Sub






#End Region

End Class