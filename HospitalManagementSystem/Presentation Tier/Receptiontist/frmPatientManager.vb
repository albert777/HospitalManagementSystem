Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmPatientManager
    Private _patientBus As BusPatient
    Friend _patient As Patient

    Private _patientSeletedRow As DataGridViewRow
    Private _patientSeletedRowIndex As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _patientBus = New BusPatient
        _patient = Nothing
    End Sub

    Private Sub frmPatientManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPatients.AutoGenerateColumns = False

        LoadPatientsList()
        LoadSexComboBox()
        LoadTypeComboBox()
        ReNew()
    End Sub

    Private Sub LoadPatientsList()
        dgvPatients.DataSource = _patientBus.SearchPatientsDataTable()
        dgvPatients.ClearSelection()

    End Sub

    Private Sub LoadPatientsList(id As Integer)
        dgvPatients.DataSource = _patientBus.SearchPatientsDataTable(id)
        dgvPatients.ClearSelection()

    End Sub

    Private Sub ReNew()
        dgvPatients.ClearSelection()

        txtPatientId.Clear()
        txtPatientName.Clear()
        cboxPatientSex.SelectedIndex = -1

        txtPatientIdCard.Clear()
        dtpPatientDoB.Value = dtpPatientDoB.MinDate
        txtPatientFolk.Clear()
        txtPatientPhone.Clear()
        txtPatientAddress.Clear()

        txtPatientInsuranceId.Clear()
        dtpPatientInsuranceIssueDate.Value = dtpPatientInsuranceIssueDate.MinDate
        dtpPatientInsuranceExpiryDate.Value = dtpPatientInsuranceExpiryDate.MinDate

        txtPatientBedId.Clear()
        txtPatientRoom.Clear()

        cboxPatientType.SelectedIndex = -1
        txtPatientStatus.Clear()
        txtPatientAdmissionTime.Clear()
        txtPatientDischargeTime.Clear()

        btnAddPatient.Enabled = True
        btnUpdatePatient.Enabled = False
        btnDeletePatient.Enabled = False
        btnPrintPatient.Enabled = False

        btnNewAppointment.Enabled = False
        btnAdmission.Enabled = False
        btnDischarge.Enabled = False
        btnSupplyMedication.Enabled = False
        btnPaidPayment.Enabled = False

        btnViewAppointmentsList.Enabled = False
        btnPatientRelatives.Enabled = False
        btnPatientRecords.Enabled = False

    End Sub

    Private Sub LoadTypeComboBox()
        Dim TypeDataTable As New DataTable
        TypeDataTable.Columns.Add("Id")
        TypeDataTable.Columns.Add("Name")
        TypeDataTable.Rows.Add(0, "Ngoại trú")
        TypeDataTable.Rows.Add(1, "Nội trú")
        TypeDataTable.Rows.Add(2, "Cấp cứu")
        cboxPatientType.DataSource = TypeDataTable
        cboxPatientType.SelectedValue = 0
    End Sub

    Private Sub LoadSexComboBox()
        Dim SexDataTable As New DataTable
        SexDataTable.Columns.Add("Id")
        SexDataTable.Columns.Add("Name")
        SexDataTable.Rows.Add(True, "Nam")
        SexDataTable.Rows.Add(False, "Nữ")
        cboxPatientSex.DataSource = SexDataTable
        cboxPatientSex.SelectedValue = True

    End Sub

    Private Sub dgvPatients_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvPatients.CurrentCellChanged, dgvPatients.CellClick
        If dgvPatients.SelectedCells.Count > 0 Then
            _patientSeletedRow = dgvPatients.Rows(dgvPatients.SelectedCells(0).RowIndex)
            _patient = GetPatientFromDataGridView()
            LoadPatientInformation(_patient)

            btnAddPatient.Enabled = False
            btnUpdatePatient.Enabled = True
            btnDeletePatient.Enabled = True
            btnPrintPatient.Enabled = True

            btnNewAppointment.Enabled = True
            'btnAdmission.Enabled = True
            'btnDischarge.Enabled = True
            btnSupplyMedication.Enabled = True
            btnPaidPayment.Enabled = True

            btnViewAppointmentsList.Enabled = True
            btnPatientRelatives.Enabled = True
            btnPatientRecords.Enabled = True
        Else
            _patientSeletedRow = Nothing

            ReNew()
        End If

    End Sub

    Private Sub btnReSearch_Click(sender As Object, e As EventArgs) Handles btnReSearch.Click
        txtSearch_Id.Clear()
        LoadPatientsList()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ReNew()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        If CheckDataInput() Then
            _patientBus.AddPatient(GetPatientFromGroupBox)
            LoadPatientsList()
        End If

    End Sub

    Private Sub btnUpdatePatient_Click(sender As Object, e As EventArgs) Handles btnUpdatePatient.Click
        If CheckDataInput() Then
            _patientBus.UpdatePatient(GetPatientFromGroupBox)
            LoadPatientsList()
        End If

    End Sub

    Private Sub btnDeletePatient_Click(sender As Object, e As EventArgs) Handles btnDeletePatient.Click
        If CheckDataInput() Then
            _patientBus.DeletePatient(CInt(txtPatientId.Text.Trim))
            LoadPatientsList()
        End If

    End Sub

#Region "Process"
    Private Function CheckDataInput() As Boolean
        Dim strErr As String = String.Empty

        If txtPatientName.Text.Trim() = "" Then
            strErr = "- Họ tên."
        End If
        If cboxPatientSex.Text.Trim = "" Then
            strErr = strErr & vbLf & "- Giới tính."
        End If
        If DateTime.Now.Year - dtpPatientDoB.Value.Year < 15 Then
            strErr = strErr & vbLf & "- Ngày sinh không hợp lệ."
        End If
        If txtPatientIdCard.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Số chứng minh nhân dân."
        End If
        If txtPatientAddress.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Địa chỉ."
        End If

        If strErr <> String.Empty Then
            MessageBox.Show("Bạn phải hoàn tất các thông tin sau :" & vbLf & strErr, "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
    End Function

    Private Sub LoadPatientInformation(patient As Patient)
        If patient.Id <= 0 Then
            txtPatientId.Clear()
        Else
            txtPatientId.Text = patient.Id.ToString
        End If
        txtPatientName.Text = patient.Name
        cboxPatientSex.SelectedValue = patient.Sex
        dtpPatientDoB.Value = patient.DoB
        txtPatientIdCard.Text = patient.IdCard
        txtPatientAddress.Text = patient.Address
        txtPatientPhone.Text = patient.Phone
        txtPatientFolk.Text = patient.Folk
        cboxPatientType.Text = patient.Type
        txtPatientStatus.Text = patient.Status

        txtPatientInsuranceId.Text = patient.InsuranceID
        If patient.InsuranceIssueDate = Date.MinValue Then
            dtpPatientInsuranceIssueDate.Value = dtpPatientInsuranceIssueDate.MinDate
        Else
            dtpPatientInsuranceIssueDate.Value = patient.InsuranceIssueDate
        End If
        If patient.InsuranceExpiryDate = Date.MinValue Then
            dtpPatientInsuranceExpiryDate.Value = dtpPatientInsuranceExpiryDate.MinDate
        Else
            dtpPatientInsuranceExpiryDate.Value = patient.InsuranceExpiryDate
        End If

        If _patientBus.GetBed(_patient.Id) IsNot Nothing Then
            patient.Bed = New Bed(_patientBus.GetBed(_patient.Id))
            txtPatientBedId.Text = patient.Bed.Id.ToString
            txtPatientRoom.Text = patient.Bed.Room.ToString
        Else
            txtPatientBedId.Clear()
            txtPatientRoom.Clear()
        End If

        txtPatientAdmissionTime.Text = "Nothing"
        txtPatientDischargeTime.Text = "Nothing"
        patient.Admission = New PatientAdmission(_patientBus.GetAdmissionTime(patient.Id))
        patient.Admission.Discharge = New PatientDischarge(_patientBus.GetDischargeTime(patient.Id))
        If patient.Admission.AdmissionTime = Date.MinValue Then
            txtPatientAdmissionTime.Clear()
        Else
            txtPatientAdmissionTime.Text = patient.Admission.AdmissionTime.ToShortDateString + " " + patient.Admission.AdmissionTime.ToLongTimeString
        End If
        If patient.Admission.Discharge.DischargeTime = Date.MinValue Then
            txtPatientDischargeTime.Clear()
        Else
            txtPatientDischargeTime.Text = patient.Admission.Discharge.DischargeTime.ToShortDateString + " " + patient.Admission.Discharge.DischargeTime.ToLongTimeString
        End If

    End Sub

    Private Function GetPatientFromGroupBox() As Patient
        Dim patient As New Patient

        Try
            If Not (Integer.TryParse(txtPatientId.Text.Trim, patient.Id)) Then
                patient.Id = -1
            End If
            patient.Name = txtPatientName.Text.Trim
            patient.Sex = CBool(cboxPatientSex.SelectedValue)
            patient.DoB = dtpPatientDoB.Value
            patient.IdCard = txtPatientIdCard.Text.Trim
            patient.Address = txtPatientAddress.Text.Trim
            patient.Phone = txtPatientPhone.Text.Trim
            patient.Folk = txtPatientFolk.Text.Trim
            patient.Type = cboxPatientType.Text.Trim
            patient.Status = txtPatientStatus.Text.Trim

            patient.InsuranceID = txtPatientInsuranceId.Text.Trim
            patient.InsuranceIssueDate = dtpPatientInsuranceIssueDate.Value
            patient.InsuranceExpiryDate = dtpPatientInsuranceExpiryDate.Value

            patient.Bed = New Bed()
            If Not (Integer.TryParse(txtPatientBedId.Text.Trim, patient.Bed.Id)) Then
                patient.Bed.Id = -1
                patient.Bed.Room = -1
            Else
                patient.Bed.Room = CInt(txtPatientRoom.Text.Trim)
            End If

        Catch ex As Exception

        End Try

        Return patient
    End Function

    Private Function GetPatientFromDataGridView() As Patient
        Dim patient As New Patient

        Try
            patient.Id = CInt(_patientSeletedRow.Cells(colPatientId.Name).FormattedValue)
            patient.Name = _patientSeletedRow.Cells(colPatientName.Name).Value.ToString.Trim
            patient.Sex = CBool(_patientSeletedRow.Cells(colchkboxPatientSex.Name).FormattedValue)
            patient.DoB = CDate(_patientSeletedRow.Cells(colPatientDoB.Name).FormattedValue)
            patient.IdCard = _patientSeletedRow.Cells(colPatientIdCard.Name).Value.ToString.Trim
            patient.Address = _patientSeletedRow.Cells(colPatientAddress.Name).Value.ToString.Trim
            patient.Phone = _patientSeletedRow.Cells(colPatientPhone.Name).Value.ToString.Trim
            patient.Folk = _patientSeletedRow.Cells(colPatientFolk.Name).Value.ToString.Trim
            patient.Type = _patientSeletedRow.Cells(colPatientType.Name).Value.ToString.Trim
            patient.Status = _patientSeletedRow.Cells(colPatientStatus.Name).Value.ToString.Trim

            patient.InsuranceID = _patientSeletedRow.Cells(colPatientInsuranceId.Name).Value.ToString.Trim
            If _patientSeletedRow.Cells(colPatientInsuranceIssueDate.Name).Value.Equals(DBNull.Value) Then
                patient.InsuranceIssueDate = dtpPatientInsuranceIssueDate.MinDate
            Else
                patient.InsuranceIssueDate = CDate(_patientSeletedRow.Cells(colPatientInsuranceIssueDate.Name).FormattedValue)
            End If
            If _patientSeletedRow.Cells(colPatientInsuranceExpiryDate.Name).Value.Equals(DBNull.Value) Then
                patient.InsuranceExpiryDate = dtpPatientInsuranceExpiryDate.MinDate
            Else
                patient.InsuranceExpiryDate = CDate(_patientSeletedRow.Cells(colPatientInsuranceExpiryDate.Name).FormattedValue)
            End If

        Catch ex As Exception

        End Try

        Return patient
    End Function

    Private Sub txtPatientInsuranceId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientInsuranceId.TextChanged
        If String.IsNullOrWhiteSpace(txtPatientInsuranceId.Text) Then
            lblInsIssDate.Enabled = False
            dtpPatientInsuranceIssueDate.Enabled = False
            lblInsExpDate.Enabled = False
            dtpPatientInsuranceExpiryDate.Enabled = False
        Else
            lblInsIssDate.Enabled = True
            dtpPatientInsuranceIssueDate.Enabled = True
            lblInsExpDate.Enabled = True
            dtpPatientInsuranceExpiryDate.Enabled = True
        End If
    End Sub

    Private Sub cboxPatientType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxPatientType.SelectedIndexChanged
        If cboxPatientType.SelectedIndex <= 0 Then
            lblBedId.Enabled = False
            lblRoom.Enabled = False
            txtPatientBedId.Enabled = False
            txtPatientRoom.Enabled = False
            txtPatientBedId.Clear()
            txtPatientRoom.Clear()
            txtPatientAdmissionTime.Clear()
            txtPatientDischargeTime.Clear()
        Else
            lblBedId.Enabled = True
            lblRoom.Enabled = True
            txtPatientBedId.Enabled = True
            txtPatientRoom.Enabled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch_Id.Text.Trim = "" And txtSearch_Name.Text.Trim = "" And txtSearch_IdCard.Text.Trim = "" _
           And txtSearch_Phone.Text.Trim = "" And txtSearchInsuranceId.Text.Trim = "" Then
            MsgBox("Bạn cần nhập ít nhất một thông tin")
        Else
            Dim id As Integer
            If Integer.TryParse(txtSearch_Id.Text.Trim, id) Then
                LoadPatientsList(id)
            Else
                MsgBox("Mã số không hợp lệ!")
            End If
        End If
    End Sub

    Private Sub txtSearch_Id_TextChanged(sender As Object, e As EventArgs) Handles txtSearch_Id.TextChanged
        Dim id As Integer
        If Integer.TryParse(txtSearch_Id.Text.Trim, id) Then
            LoadPatientsList(id)
        Else
            LoadPatientsList()
        End If
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnNewAppointment.Click
        Dim frmAppointment As New frmAppointment("New", GetPatientFromDataGridView)
        frmAppointment.ShowDialog()
    End Sub

    Private Sub btnViewAppointmentsList_Click(sender As Object, e As EventArgs) Handles btnViewAppointmentsList.Click
        Dim frmAppointmentManager As New frmAppointmentManager(GetPatientFromDataGridView)
        frmAppointmentManager.ShowDialog()
    End Sub

    Private Sub btnAdmission_Click(sender As Object, e As EventArgs) Handles btnAdmission.Click
        Dim frmAdmission As New frmAdmission(My.Forms.frmMain._account.Employee, _patient)
        frmAdmission.ShowDialog()
        LoadPatientsList()
        LoadPatientInformation(_patient)
    End Sub

    Private Sub txtPatientAdmissionTime_TextChanged(sender As Object, e As EventArgs) Handles txtPatientAdmissionTime.TextChanged, txtPatientDischargeTime.TextChanged
        If txtPatientAdmissionTime.Text.Trim = "" AndAlso txtPatientDischargeTime.Text.Trim = "" Then
            btnAdmission.Enabled = True
            btnDischarge.Enabled = False
        ElseIf txtPatientAdmissionTime.Text <> "" AndAlso txtPatientDischargeTime.Text.Trim = "" Then
            btnAdmission.Enabled = False
            btnDischarge.Enabled = True
        Else
            btnAdmission.Enabled = True
            btnDischarge.Enabled = False
        End If
    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        Dim frmDischarge As New frmDischarge(My.Forms.frmMain._account.Employee, _patient)
        frmDischarge.ShowDialog()
        LoadPatientsList()
        LoadPatientInformation(_patient)
    End Sub

#End Region
End Class