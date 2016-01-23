Imports HospitalManagementSystem.BUS

Public Class frmCategoryManager
    Private _selectedRow_Department As DataGridViewRow
    Private _selectedRow_Clinic As DataGridViewRow
    Private _selectedRow_Speciality As DataGridViewRow
    Private _selectedRow_Bed As DataGridViewRow

    Private _deptBus As BusiDepartment
    Private _specBus As BusiSpeciality
    Private _clinicBus As BusiClinic
    Private _bedBus As BusiBed

    Private _emplBus As BusiEmployee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _selectedRow_Department = Nothing
        _selectedRow_Clinic = Nothing
        _selectedRow_Speciality = Nothing
        _selectedRow_Bed = Nothing

        _deptBus = New BusiDepartment
        _specBus = New BusiSpeciality
        _clinicBus = New BusiClinic
        _bedBus = New BusiBed

        _emplBus = New BusiEmployee
    End Sub

    Private Sub frmCategoryManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSpecialities.AutoGenerateColumns = False
        dgvDepartment.AutoGenerateColumns = False
        dgvClinics.AutoGenerateColumns = False
        dgvBeds.AutoGenerateColumns = False

        LoadSpecialitiesList()
        LoadDepartmentsList()
        LoadClinicsList()
        LoadBedsList()

        LoadChiefsComboBox()

    End Sub

    Private Sub LoadDepartmentsComboBox()
        cboxBed_DepartmentsName.DataSource = _deptBus.LoadDepartmentsList
        cboxBed_DepartmentsName.SelectedIndex = -1
    End Sub

    Private Sub LoadChiefsComboBox()
        cboxDepartment_ChiefName.DataSource = _emplBus.SearchEmployees
        cboxDepartment_ChiefName.SelectedIndex = -1

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

#Region "Department"
    Private Sub LoadDepartmentsList()
        LoadDepartmentsComboBox()

        tboxDepartment.Clear()
        btnDept_Add.Enabled = True
        btnDept_Delete.Enabled = False
        btnDept_Edit.Enabled = False

        dgvDepartment.DataSource = _deptBus.LoadDepartmentsList

        _selectedRow_Department = Nothing
        dgvDepartment.ClearSelection()
        chkbDeptChief.Checked = False
    End Sub

    Private Sub chkbDeptChief_CheckedChanged(sender As Object, e As EventArgs) Handles chkbDeptChief.CheckedChanged
        If chkbDeptChief.CheckState = CheckState.Checked Then
            lblDeptChief.Enabled = True
            cboxDepartment_ChiefName.Enabled = True
        Else
            lblDeptChief.Enabled = False
            cboxDepartment_ChiefName.Enabled = False
            cboxDepartment_ChiefName.SelectedIndex = -1
        End If
    End Sub

    Private Sub dgvDepartment_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvDepartment.CurrentCellChanged
        If dgvDepartment.SelectedCells.Count > 0 Then
            _selectedRow_Department = dgvDepartment.Rows(dgvDepartment.SelectedCells(0).RowIndex)

            btnDept_Add.Enabled = False
            btnDept_Edit.Enabled = True
            btnDept_Delete.Enabled = True

            tboxDepartment.Text = _selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim
            cboxDepartment_ChiefName.SelectedValue = _selectedRow_Department.Cells(colDeptChiefId.Name).Value

            If cboxDepartment_ChiefName.SelectedIndex <> -1 Then
                chkbDeptChief.Checked = True
            Else
                chkbDeptChief.Checked = False
            End If
        Else
            _selectedRow_Department = Nothing

            btnDept_Add.Enabled = True
            btnDept_Edit.Enabled = False
            btnDept_Delete.Enabled = False

            tboxDepartment.Clear()
            cboxDepartment_ChiefName.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnDept_Add_Click(sender As Object, e As EventArgs) Handles btnDept_Add.Click
        Try
            If cboxDepartment_ChiefName.SelectedIndex <> -1 Then
                _deptBus.AddDepartment(tboxDepartment.Text.Trim, CInt(cboxDepartment_ChiefName.SelectedValue.ToString))
            Else
                _deptBus.AddDepartment(tboxDepartment.Text.Trim, -1)
            End If
        Catch ex As Exception

        Finally
            LoadDepartmentsList()
        End Try
    End Sub

    Private Sub btnDept_Edit_Click(sender As Object, e As EventArgs) Handles btnDept_Edit.Click
        Try
            If cboxDepartment_ChiefName.SelectedIndex <> -1 Then
                _deptBus.UpdateDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim,
                                          tboxDepartment.Text.Trim,
                                          CInt(cboxDepartment_ChiefName.SelectedValue.ToString))
            Else
                _deptBus.UpdateDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim,
                                          tboxDepartment.Text.Trim,
                                          -1)
            End If
        Catch ex As Exception

        Finally
            LoadDepartmentsList()
        End Try
    End Sub

    Private Sub btnDept_Delete_Click(sender As Object, e As EventArgs) Handles btnDept_Delete.Click
        Try
            _deptBus.DeleteDepartment(_selectedRow_Department.Cells(colDeptName.Name).FormattedValue.ToString.Trim)
        Catch ex As Exception

        Finally
            LoadDepartmentsList()
        End Try
    End Sub

    Private Sub btnDept_Reset_Click(sender As Object, e As EventArgs) Handles btnDept_Reset.Click
        LoadDepartmentsList()
    End Sub
#End Region

#Region "Specialities"
    Private Sub LoadSpecialitiesList()
        dgvSpecialities.DataSource = _specBus.LoadSpecialitiesList
        dgvSpecialities.ClearSelection()

        _selectedRow_Speciality = Nothing
    End Sub

    Private Sub dgvSpecialities_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvSpecialities.CurrentCellChanged
        If dgvSpecialities.SelectedCells.Count > 0 Then
            _selectedRow_Speciality = dgvSpecialities.Rows(dgvSpecialities.SelectedCells(0).RowIndex)

            btnSpec_Add.Enabled = False
            btnSpec_Edit.Enabled = True
            btnSpec_Delete.Enabled = True

            tboxSpecialized.Text = _selectedRow_Speciality.Cells(colSpecName.Name).FormattedValue.ToString.Trim

        Else
            _selectedRow_Speciality = Nothing

            btnSpec_Add.Enabled = True
            btnSpec_Edit.Enabled = False
            btnSpec_Delete.Enabled = False

            tboxSpecialized.Clear()
        End If
    End Sub

    Private Sub btnSpec_Add_Click(sender As Object, e As EventArgs) Handles btnSpec_Add.Click
        _specBus.AddSpeciality(tboxSpecialized.Text.Trim)
        LoadSpecialitiesList()
    End Sub

    Private Sub btnSpec_Reset_Click(sender As Object, e As EventArgs) Handles btnSpec_Reset.Click
        LoadSpecialitiesList()
    End Sub

    Private Sub btnSpec_Edit_Click(sender As Object, e As EventArgs) Handles btnSpec_Edit.Click
        _specBus.UpdateSpeciality(_selectedRow_Speciality.Cells(colSpecName.Name).FormattedValue.ToString.Trim, tboxSpecialized.Text.Trim)
        LoadSpecialitiesList()
    End Sub

    Private Sub btnSpec_Delete_Click(sender As Object, e As EventArgs) Handles btnSpec_Delete.Click
        _specBus.DeleteSpeciality(_selectedRow_Speciality.Cells(colSpecName.Name).FormattedValue.ToString.Trim)
        LoadSpecialitiesList()
    End Sub
#End Region

#Region "Clinic"
    Private Sub LoadClinicsList()
        dgvClinics.DataSource = _clinicBus.LoadClinicsList()
        dgvClinics.ClearSelection()

        _selectedRow_Clinic = Nothing
    End Sub

    Private Sub dgvClinics_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvClinics.CurrentCellChanged
        If dgvClinics.SelectedCells.Count > 0 Then
            _selectedRow_Clinic = dgvClinics.Rows(dgvClinics.SelectedCells(0).RowIndex)

            btnClinic_Add.Enabled = False
            btnClinic_Edit.Enabled = True
            btnClinic_Delete.Enabled = True

            tboxClinic.Text = _selectedRow_Clinic.Cells(colClinicName.Name).FormattedValue.ToString.Trim

        Else
            _selectedRow_Clinic = Nothing

            btnClinic_Add.Enabled = True
            btnClinic_Edit.Enabled = False
            btnClinic_Delete.Enabled = False

            tboxClinic.Clear()
        End If
    End Sub

    Private Sub btnClinic_Add_Click(sender As Object, e As EventArgs) Handles btnClinic_Add.Click
        _clinicBus.AddClinic(tboxClinic.Text.Trim)
        LoadClinicsList()
    End Sub

    Private Sub btnClinic_Edit_Click(sender As Object, e As EventArgs) Handles btnClinic_Edit.Click
        _clinicBus.UpdateClinic(_selectedRow_Clinic.Cells(colClinicName.Name).FormattedValue.ToString.Trim, tboxClinic.Text.Trim)
        LoadClinicsList()
    End Sub

    Private Sub btnClinic_Delete_Click(sender As Object, e As EventArgs) Handles btnClinic_Delete.Click
        _clinicBus.DeleteClinic(tboxClinic.Text.Trim)
        LoadClinicsList()
    End Sub

    Private Sub btnClinic_Reset_Click(sender As Object, e As EventArgs) Handles btnClinic_Reset.Click
        LoadClinicsList()
    End Sub

#End Region

#Region "Bed"
    Private Sub LoadBedsList()
        dgvBeds.DataSource = _bedBus.LoadBedsList()
        dgvBeds.ClearSelection()

        _selectedRow_Bed = Nothing
    End Sub

    Private Sub dgvBeds_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvBeds.CurrentCellChanged
        If dgvBeds.SelectedCells.Count > 0 Then
            _selectedRow_Bed = dgvBeds.Rows(dgvBeds.SelectedCells(0).RowIndex)

            btnBed_Add.Enabled = False
            btnBed_Edit.Enabled = True
            btnBed_Delete.Enabled = True

            tboxBedId.Text = _selectedRow_Bed.Cells(colBedId.Name).FormattedValue.ToString.Trim
            tboxBedRoom.Text = _selectedRow_Bed.Cells(colBedRoom.Name).FormattedValue.ToString.Trim
            cboxBed_DepartmentsName.SelectedValue = _selectedRow_Bed.Cells(colBedDeptId.Name).FormattedValue.ToString.Trim

        Else
            _selectedRow_Clinic = Nothing

            btnBed_Add.Enabled = True
            btnBed_Edit.Enabled = False
            btnBed_Delete.Enabled = False

            tboxBedId.Clear()
            tboxBedRoom.Clear()
            cboxBed_DepartmentsName.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnBed_Add_Click(sender As Object, e As EventArgs) Handles btnBed_Add.Click
        _bedBus.AddBed(CInt(tboxBedRoom.Text.Trim), CInt(cboxBed_DepartmentsName.SelectedValue))
        LoadBedsList()
    End Sub

    Private Sub btnBed_Edit_Click(sender As Object, e As EventArgs) Handles btnBed_Edit.Click
        _bedBus.UpdateBed(CInt(tboxBedId.Text.Trim), CInt(tboxBedRoom.Text.Trim), CInt(cboxBed_DepartmentsName.SelectedValue))
        LoadBedsList()
    End Sub

    Private Sub btnBed_Delete_Click(sender As Object, e As EventArgs) Handles btnBed_Delete.Click
        _bedBus.DeleteBed(CInt(tboxBedId.Text.Trim))
        LoadBedsList()
    End Sub

    Private Sub btnBed_Reset_Click(sender As Object, e As EventArgs) Handles btnBed_Reset.Click
        LoadBedsList()
    End Sub

    Private Sub bbiReLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReLoad.ItemClick
        LoadSpecialitiesList()
        LoadDepartmentsList()
        LoadClinicsList()
        LoadBedsList()

        LoadChiefsComboBox()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Hide()
    End Sub


#End Region

End Class