Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO
Imports HospitalManagementSystem.GlobalClass.GlobalFunction

Public Class frmStaffManager
    Private _employee As New Employee

    Private _employeeBus As BusiEmployee
    Private _departmentBus As BusiDepartment
    Private _specialityBus As BusiSpeciality

    Dim _selectedRow As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _employee = New Employee

        _employeeBus = New BusiEmployee
        _departmentBus = New BusiDepartment
        _specialityBus = New BusiSpeciality

        _selectedRow = -1
    End Sub

#Region "Windows Events"

    Private Sub frmRecordsSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgrEmplResult.AutoGenerateColumns = False

        LoadEmployeesList()
        LoadSexComboBox()
        LoadDepartmentsList()
        LoadSpecialitiesList()
        ReNew()

        txtSearch_Empl_ID.Focus()

        btnDeleteEmpl.Enabled = False
        btnUpdateEmpl.Enabled = False

        cboxSearchDepartments.SelectedIndex = -1
        cboxSearchSpecialities.SelectedIndex = -1


    End Sub

    Private Sub LoadSexComboBox()
        Dim SexDataTable As New DataTable
        SexDataTable.Columns.Add("Id")
        SexDataTable.Columns.Add("Name")
        SexDataTable.Rows.Add(True, "Nam")
        SexDataTable.Rows.Add(False, "Nữ")
        cboxEmployeeSex.DataSource = SexDataTable
        cboxEmployeeSex.SelectedValue = True
        colchkboxEmplSex.TrueValue = "Nam"
        colchkboxEmplSex.ToolTipText = "Nam"

    End Sub

    Private Sub LoadEmployeesList()
        Try
            dgrEmplResult.DataSource = _employeeBus.SearchEmployees()
            _selectedRow = dgrEmplResult.RowCount - 1
            dgrEmplResult.Rows(_selectedRow).Cells(0).Selected = True

        Catch ex As Exception
            My.Forms.frmMain.txtStatus.Text = "Lỗi: Không thể lấy danh sách nhân viên."
        End Try

    End Sub

    Private Sub LoadEmployeesList(id As Integer)
        Try
            dgrEmplResult.DataSource = _employeeBus.SearchEmployees(id)
            _selectedRow = dgrEmplResult.RowCount - 1
            dgrEmplResult.Rows(_selectedRow).Cells(0).Selected = True

        Catch ex As Exception
            My.Forms.frmMain.txtStatus.Text = "Lỗi: Không thể lấy danh sách nhân viên."
        End Try

    End Sub

    Private Sub LoadDepartmentsList()
        cboxEmployeeDepartment.DataSource = _departmentBus.LoadDepartmentsList()
        cboxSearchDepartments.DataSource = _departmentBus.LoadDepartmentsList
    End Sub

    Private Sub LoadSpecialitiesList()
        cboxEmployeeSpeciality.DataSource = _specialityBus.LoadSpecialitiesList()
        cboxSearchSpecialities.DataSource = _specialityBus.LoadSpecialitiesList
    End Sub

    Private Sub cmdReSearch_Click(sender As Object, e As EventArgs) Handles btnReSearch.Click
        txtSearch_Empl_ID.Clear()
        txtSearch_Empl_IDCard.Clear()
        txtSearch_Empl_Name.Clear()
        txtSearch_Empl_Phone.Clear()
        txtSearch_Empl_ID.Focus()
        cboxSearchDepartments.SelectedIndex = -1
        cboxSearchSpecialities.SelectedIndex = -1

        LoadEmployeesList()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch_Empl_ID.Text.Trim = "" Then
            MsgBox("Bạn cần nhập ít nhất một thông tin")
        Else
            Dim id As Integer
            If Integer.TryParse(txtSearch_Empl_ID.Text.Trim, id) Then
                LoadEmployeesList(id)
            Else
                MsgBox("Mã số không hợp lệ!")
            End If
        End If
    End Sub

    Private Sub dgrEmplResult_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrEmplResult.CellClick
        _selectedRow = e.RowIndex

        If _selectedRow >= 0 Then
            Try
                _employee = GetEmployeeDataFromDataGridView()
                LoadEmployeeInformations(_employee)

            Catch ex As Exception
                Throw ex
            End Try

            btnAddEmpl.Enabled = False
            btnDeleteEmpl.Enabled = True
            btnUpdateEmpl.Enabled = True
        End If
    End Sub

    Private Sub LoadEmployeeInformations(Empl As Employee)
        txtEmployeeId.Text = Empl.Id.ToString
        cboxEmployeeSex.SelectedValue = Empl.Sex
        txtEmployeeFolk.Text = Empl.Folk

        txtEmployeeName.Text = Empl.Name
        txtEmployeeIdCard.Text = Empl.IdCard
        dtpEmployeeDoB.Value = Empl.DoB

        txtEmployeeAddress.Text = Empl.Address
        txtEmployeePhone.Text = Empl.Phone
        dtpEmployeeHireDate.Value = Empl.HireDate

        txtEmployeeBasicSalary.Text = Empl.BasicSalary.ToString
        txtEmployeeSubsidy.Text = Empl.Subsidy.ToString
        txtEmployeeTotalSalary.Text = Empl.TotalSalary.ToString
        txtEmployeeRatio.Text = Empl.Ratio.ToString


        txtEmployeePosition.Text = Empl.Position

        If Empl.Department.Id > 0 Then
            cboxEmployeeDepartment.SelectedValue = Empl.Department.Id
        Else
            cboxEmployeeDepartment.SelectedIndex = -1
        End If

        If Empl.Speciality.Id > 0 Then
            cboxEmployeeSpeciality.SelectedValue = Empl.Speciality.Id
        Else
            cboxEmployeeSpeciality.SelectedIndex = -1
        End If

        btnAddEmpl.Enabled = False
        btnDeleteEmpl.Enabled = True
        btnUpdateEmpl.Enabled = True
    End Sub

    Private Sub btnAddEmpl_Click(sender As Object, e As EventArgs) Handles btnAddEmpl.Click
        Try
            If CheckDataInput() Then
                _employee = GetEmployeeDataFromGroupBox()
                _employeeBus.AddEmployee(_employee)
                LoadEmployeesList()
                LoadEmployeeInformations(_employee)
            End If
        Catch ex As Exception
            btnAddEmpl.Enabled = True
            btnDeleteEmpl.Enabled = False
            btnUpdateEmpl.Enabled = False
        End Try

    End Sub

    Private Sub btnDeleteEmpl_Click(sender As Object, e As EventArgs) Handles btnDeleteEmpl.Click
        Try
            _employeeBus.DeleteEmployee(GetEmployeeDataFromGroupBox.Id)
            LoadEmployeesList()
            _employee = GetEmployeeDataFromDataGridView()

            LoadEmployeeInformations(_employee)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdUpdateEmpl_Click(sender As Object, e As EventArgs) Handles btnUpdateEmpl.Click
        Try
            _employeeBus.UpdateEmployee(GetEmployeeDataFromGroupBox)
            Dim selectedBefore As Integer = _selectedRow
            LoadEmployeesList()
            _selectedRow = selectedBefore
            dgrEmplResult.Rows(_selectedRow).Cells(0).Selected = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ReNew()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub
#End Region

#Region "Process"
    Private Function CheckDataInput() As Boolean
        Dim strErr As String = String.Empty

        If txtEmployeeName.Text.Trim() = "" Then
            strErr = "- Họ tên."
        End If
        If cboxEmployeeSex.Text.Trim = "" Then
            strErr = strErr & vbLf & "- Giới tính."
        End If
        If DateTime.Now.Year - dtpEmployeeDoB.Value.Year < 15 Then
            strErr = strErr & vbLf & "- Ngày sinh không hợp lệ."
        End If
        If txtEmployeeIdCard.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Số chứng minh nhân dân."
        End If
        If txtEmployeeAddress.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Địa chỉ."
        End If
        If DateTime.Now.Year - dtpEmployeeHireDate.Value.Year < 0 Then
            strErr = strErr & vbLf & "- Ngày vào làm không hợp lệ."
        End If
        If txtEmployeeBasicSalary.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Lương cơ bản."
        End If
        If txtEmployeeRatio.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Hệ số lương."
        End If
        If txtEmployeeSubsidy.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Phụ cấp lương."
        End If

        If strErr <> String.Empty Then
            MessageBox.Show("Bạn phải hoàn tất các thông tin sau :" & vbLf & strErr, "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
    End Function


    Private Function GetEmployeeDataFromDataGridView() As Employee
        If _selectedRow >= 0 Then
            Try
                Dim empl As New Employee

                With dgrEmplResult.Rows(_selectedRow)
                    empl.Id = CInt(.Cells(colEmplId.Name).FormattedValue)
                    empl.Name = .Cells(colEmplName.Name).FormattedValue.ToString.Trim
                    empl.Sex = CBool(.Cells(colchkboxEmplSex.Name).FormattedValue)
                    empl.DoB = CDate(.Cells(colEmplDoB.Name).Value)
                    empl.IdCard = .Cells(colEmplIdCard.Name).FormattedValue.ToString.Trim
                    empl.Address = .Cells(colEmplAddress.Name).FormattedValue.ToString.Trim
                    empl.Phone = .Cells(colEmplPhone.Name).FormattedValue.ToString.Trim
                    empl.Folk = .Cells(colEmplFolk.Name).FormattedValue.ToString.Trim
                    empl.HireDate = CDate(.Cells(colEmplHireDate.Name).Value)
                    empl.Ratio = CDbl(.Cells(colEmplRatio.Name).FormattedValue)
                    empl.BasicSalary = Integer.Parse(.Cells(colEmplBasicSalary.Name).Value.ToString)
                    empl.Subsidy = Integer.Parse(.Cells(colEmplSubsidy.Name).Value.ToString)
                    empl.Position = .Cells(colEmplPosition.Name).FormattedValue.ToString.Trim

                    empl.Department = New Department()
                    If Integer.TryParse(.Cells(colEmplDeptId.Name).FormattedValue.ToString.Trim, empl.Department.Id) Then
                        empl.Department.Name = .Cells(colEmplDeptName.Name).FormattedValue.ToString.Trim
                    End If

                    empl.Speciality = New Speciality()
                    If Integer.TryParse(.Cells(colEmplSpecId.Name).FormattedValue.ToString.Trim, empl.Speciality.Id) Then
                        empl.Speciality.Name = .Cells(colEmplSpecName.Name).FormattedValue.ToString.Trim
                    End If

                End With

                Return empl
            Catch ex As Exception
                Throw ex
                Return Nothing
            End Try
        Else
            Return Nothing
        End If

    End Function

    Private Function GetEmployeeDataFromGroupBox() As Employee
        Try
            Dim empl As New Employee()

            If Not (Integer.TryParse(txtEmployeeId.Text.Trim(), empl.Id)) Then
                empl.Id = 0

            End If

            empl.Sex = _employeeBus.Sex(cboxEmployeeSex.Text)
            empl.Folk = txtEmployeeFolk.Text.Trim()

            empl.Name = txtEmployeeName.Text.Trim()
            empl.IdCard = txtEmployeeIdCard.Text.Trim()
            empl.DoB = dtpEmployeeDoB.Value

            empl.Address = txtEmployeeAddress.Text.Trim()
            empl.Phone = txtEmployeePhone.Text.Trim()
            empl.HireDate = dtpEmployeeHireDate.Value

            If Not (Integer.TryParse(txtEmployeeBasicSalary.Text.Trim, empl.BasicSalary)) Then
                empl.BasicSalary = 0

            End If

            If Not (Integer.TryParse(txtEmployeeSubsidy.Text.Trim, empl.Subsidy)) Then
                empl.Subsidy = 0

            End If

            If Not (Double.TryParse(txtEmployeeRatio.Text.Trim, empl.Ratio)) Then
                empl.Subsidy = 0

            End If

            empl.Position = txtEmployeePosition.Text.Trim()


            If CInt(cboxEmployeeDepartment.SelectedIndex.ToString) <> -1 Then
                empl.Department = New Department(CInt(cboxEmployeeDepartment.SelectedValue.ToString), cboxEmployeeDepartment.Text.Trim())
            Else
                empl.Department = New Department

            End If

            If CInt(cboxEmployeeSpeciality.SelectedIndex.ToString) <> -1 Then
                empl.Speciality = New Speciality(CInt(cboxEmployeeSpeciality.SelectedValue.ToString), cboxEmployeeSpeciality.Text.Trim())
            Else
                empl.Speciality = New Speciality

            End If

            Return empl

        Catch ex As Exception
        Return Nothing

        End Try

    End Function

    Private Sub ReNew()
        txtEmployeeId.Clear()
        cboxEmployeeSex.SelectedIndex = -1
        txtEmployeeFolk.Clear()

        txtEmployeeName.Clear()
        txtEmployeeIdCard.Clear()
        dtpEmployeeDoB.Value = dtpEmployeeDoB.MinDate

        txtEmployeeAddress.Clear()
        txtEmployeePhone.Clear()
        dtpEmployeeHireDate.Value = dtpEmployeeHireDate.MinDate

        txtEmployeeBasicSalary.Clear()
        txtEmployeeSubsidy.Clear()
        txtEmployeeTotalSalary.Clear()
        txtEmployeeRatio.Clear()

        txtEmployeePosition.Clear()
        cboxEmployeeDepartment.SelectedIndex = -1
        cboxEmployeeSpeciality.SelectedIndex = -1

        btnAddEmpl.Enabled = True
        btnUpdateEmpl.Enabled = False
        btnDeleteEmpl.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbDept.CheckedChanged
        If chkbDept.CheckState = CheckState.Checked Then
            lblDept.Enabled = True
            cboxEmployeeDepartment.Enabled = True

        Else
            lblDept.Enabled = False
            cboxEmployeeDepartment.Enabled = False
            cboxEmployeeDepartment.SelectedIndex = -1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbSpec.CheckedChanged
        If chkbSpec.CheckState = CheckState.Checked Then
            lblSpec.Enabled = True
            cboxEmployeeSpeciality.Enabled = True

        Else
            lblSpec.Enabled = False
            cboxEmployeeSpeciality.Enabled = False
            cboxEmployeeSpeciality.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtSearch_Empl_ID_TextChanged(sender As Object, e As EventArgs) Handles txtSearch_Empl_ID.TextChanged
        Dim id As Integer
        If Integer.TryParse(txtSearch_Empl_ID.Text.Trim, id) Then
            LoadEmployeesList(id)
        Else
            LoadEmployeesList()
        End If

    End Sub

#End Region

End Class