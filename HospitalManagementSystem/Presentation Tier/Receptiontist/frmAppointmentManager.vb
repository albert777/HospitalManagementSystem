Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmAppointmentManager
    Private _patient As Patient

    Private _appointBus As BUS.BusPatientAppointment

    Private _employeeBus As BusiEmployee

    Private _selectedAppointmentRow As DataGridViewRow

    Public Sub New(ByVal patient As Patient)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _patient = patient

        _appointBus = New BusPatientAppointment
        _employeeBus = New BusiEmployee

        _selectedAppointmentRow = Nothing

        dgvAppointments.AutoGenerateColumns = False

    End Sub

    Private Sub LoadPatientInformation()
        txtPatientId.Text = _patient.Id.ToString
        txtPatientName.Text = _patient.Name
        txtPatientDoB.Text = _patient.DoB.ToShortDateString
        rbtnSexMale.Checked = _patient.Sex
        rbtnSexFemale.Checked = Not (_patient.Sex)

        txtPatientInsuranceIssueDate.Text = _patient.InsuranceIssueDate.ToShortDateString
        txtPatientInsuranceExpiryDate.Text = _patient.InsuranceExpiryDate.ToShortDateString
        txtPatientInsuranceId.Text = "Nothing"
        txtPatientInsuranceId.Text = _patient.InsuranceID

    End Sub

    Private Sub LoadAppointmentsList()
        dgvAppointments.DataSource = _appointBus.GetPatientAppointmentsDataTable(_patient.Id)
        dgvAppointments.ClearSelection()
    End Sub

    Private Sub frmAppointmentManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientInformation()
        LoadAppointmentsList()
    End Sub

    Private Sub dgvAppointments_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvAppointments.CurrentCellChanged
        If dgvAppointments.SelectedCells.Count > 0 Then
            _selectedAppointmentRow = dgvAppointments.Rows(dgvAppointments.SelectedCells(0).RowIndex)
            btnViewAppointment.Enabled = True
        Else
            _selectedAppointmentRow = Nothing
            btnViewAppointment.Enabled = False
        End If
    End Sub

    Private Function GetAppointmentFromDataGridView() As PatientAppointment
        Dim appointment As New PatientAppointment

        Try
            If _selectedAppointmentRow IsNot Nothing Then
                appointment.Id = CInt(_selectedAppointmentRow.Cells(colAppointId.Name).FormattedValue)
                appointment.Patient = _patient

                appointment.Employee = _employeeBus.GetEmployeeById(CInt(_selectedAppointmentRow.Cells(colEmployeeId.Name).Value))

                Dim result As Integer
                If Integer.TryParse(_selectedAppointmentRow.Cells(colDoctorId.Name).Value.ToString, result) Then
                    appointment.Doctor = _employeeBus.GetEmployeeById(result)
                Else
                    appointment.Doctor = New Doctor
                End If

                appointment.Clinic = New Clinic(CInt(_selectedAppointmentRow.Cells(colClinicId.Name).Value))
                appointment.Numberorder = CInt(_selectedAppointmentRow.Cells(colAppointNo.Name).Value)
                appointment.CreateTime = CDate(_selectedAppointmentRow.Cells(colAppointCreateTime.Name).Value)

                If _selectedAppointmentRow.Cells(colAppointResult.Name).Value.Equals(DBNull.Value) Then
                    appointment.Result = ""
                Else
                    appointment.Result = CType(_selectedAppointmentRow.Cells(colAppointResult.Name).Value, String)
                End If
                If _selectedAppointmentRow.Cells(colAppointPrescribe.Name).Value.Equals(DBNull.Value) Then
                    appointment.Prescribe = ""
                Else
                    appointment.Prescribe = CType(_selectedAppointmentRow.Cells(colAppointPrescribe.Name).Value, String)
                End If

                appointment.Lines = Nothing

            End If
        Catch ex As Exception

        End Try

        Return appointment
    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewAppointment_Click(sender As Object, e As EventArgs) Handles btnViewAppointment.Click
        Dim frmViewAppointment As New frmAppointment("View", , GetAppointmentFromDataGridView)
        frmViewAppointment.ShowDialog()
    End Sub

    Private Sub btnNewAppointment_Click(sender As Object, e As EventArgs) Handles btnNewAppointment.Click
        Dim frmNewAppointment As New frmAppointment("New", _patient)
        frmNewAppointment.ShowDialog()

        LoadAppointmentsList()
    End Sub

    Private Sub txtPatientInsuranceId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientInsuranceId.TextChanged
        If txtPatientInsuranceId.Text = "" Then
            lblInsIssDate.Enabled = False
            txtPatientInsuranceIssueDate.Enabled = False
            lblInsExpDate.Enabled = False
            txtPatientInsuranceExpiryDate.Enabled = False
            txtPatientInsuranceIssueDate.Clear()
            txtPatientInsuranceExpiryDate.Clear()
        Else
            lblInsIssDate.Enabled = True
            txtPatientInsuranceIssueDate.Enabled = True
            lblInsExpDate.Enabled = True
            txtPatientInsuranceExpiryDate.Enabled = True
        End If
    End Sub
End Class