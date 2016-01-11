Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmDischarge
    Private _employee As Employee
    Private _patient As Patient
    Private _admission As PatientAdmission

    Private _emplBus As BusiEmployee
    Private _patientBus As BusPatient

    Public Sub New(ByVal Employee As Employee, ByVal Patient As Patient, Optional ByVal Admission As PatientAdmission = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _patientBus = New BusPatient

        _employee = Employee
        _patient = Patient
        _patient.Admission = _patientBus.GetAdmission(Patient.Id)
        '_admission = Admission

        txtEmployeeName.Text = _employee.Name

        txtPatientId.Text = _patient.Id.ToString
        txtPatientName.Text = _patient.Name
        txtPatientDoB.Text = _patient.DoB.ToShortDateString
        rbtnSexMale.Checked = _patient.Sex
        rbtnSexFemale.Checked = Not (_patient.Sex)

        txtPatientInsuranceIssueDate.Text = _patient.InsuranceIssueDate.ToShortDateString()
        txtPatientInsuranceExpiryDate.Text = _patient.InsuranceExpiryDate.ToShortDateString
        txtPatientInsuranceId.Text = "Nothing"
        txtPatientInsuranceId.Text = _patient.InsuranceID

        txtAdmissionTime.Text = _patient.Admission.AdmissionTime.ToShortDateString + " " + _patient.Admission.AdmissionTime.ToLongTimeString
        txtDischargeTime.Text = Date.Now.ToShortDateString + " " + Date.Now.ToLongTimeString
    End Sub

    Private Sub txtPatientInsuranceId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientInsuranceId.TextChanged
        If txtPatientInsuranceId.Text.Trim = "" Then
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

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        If CheckDataInput() Then
            If _patientBus.Discharge(_employee.Id, _patient.Admission.Id, txtTreatment.Text.Trim, txtResult.Text.Trim, txtPrescribe.Text) Then
                MsgBox("Ghi thông tin xuất viện thành công")
                btnDischarge.Enabled = False
            Else
                MsgBox("Ghi thông tin xuất viện thất bại")
                btnDischarge.Enabled = True
            End If
        End If
    End Sub

    Private Function CheckDataInput() As Boolean
        Dim strErr As String = String.Empty

        If txtTreatment.Text.Trim() = "" Then
            strErr = "- Phương pháp điều trị."
        End If
        If txtResult.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Kết quả điều trị."
        End If
        If txtPrescribe.Text.Trim() = "" Then
            strErr = strErr & vbLf & "- Lời dặn của bác sĩ."
        End If

        If strErr <> String.Empty Then
            MessageBox.Show("Bạn phải hoàn tất các thông tin sau :" & vbLf & strErr, "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class