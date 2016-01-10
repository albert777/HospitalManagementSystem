Imports HospitalManagementSystem
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmAppointment
    Private _employee As Employee
    Private _patient As Patient

    Private _clinicBus As BusiClinic
    Private _appoitmentBus As BusPatientAppointment

    Public Sub New(ByVal Type As String, Optional ByVal patient As Patient = Nothing, Optional ByVal appointment As PatientAppointment = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clinicBus = New BusiClinic
        _appoitmentBus = New BusPatientAppointment

        LoadClinicsComboBox()

        If Type = "New" Then
            _employee = My.Forms.frmMain._account.Employee
            _patient = patient
            txtAppointmentCreateTime.Text = Date.Now.ToShortDateString()
            txtAppointmentEmployeeName.Text = _employee.Name

            txtPatientId.Text = patient.Id.ToString
            txtPatientName.Text = patient.Name
            txtPatientDoB.Text = patient.DoB.ToShortDateString
            rbtnSexMale.Checked = patient.Sex
            txtPatientInsuranceId.Text = patient.InsuranceID
            txtPatientInsuranceIssueDate.Text = patient.InsuranceIssueDate.ToShortDateString()
            txtPatientInsuranceExpiryDate.Text = patient.InsuranceExpiryDate.ToShortDateString

            txtResult.ReadOnly = True
            txtResult.BackColor = Color.FromArgb(255, 255, 192)
            txtPrescribe.ReadOnly = True
            txtPrescribe.BackColor = Color.FromArgb(255, 255, 192)

            txtRequest2.Enabled = False
            txtRequest3.Enabled = False
            txtRequest4.Enabled = False
            txtRequest5.Enabled = False

            'ElseIf Type = "View" Then
            '    _employee = My.Forms.frmMain._account.Employee
            '    _patient = patient
            '    txtAppointmentCreateTime.Text = Date.Now.ToShortDateString()
            '    txtAppointmentEmployeeName.Text = _employee.Name

            '    txtPatientId.Text = patient.Id.ToString
            '    txtPatientName.Text = patient.Name
            '    txtPatientDoB.Text = patient.DoB.ToShortDateString
            '    rbtnSexMale.Checked = patient.Sex
            '    txtPatientInsuranceId.Text = patient.InsuranceID
            '    txtPatientInsuranceIssueDate.Text = patient.InsuranceIssueDate.ToShortDateString()
            '    txtPatientInsuranceExpiryDate.Text = patient.InsuranceExpiryDate.ToShortDateString

        End If

    End Sub

    Private Sub LoadClinicsComboBox()
        cboxClinics.DataSource = _clinicBus.LoadClinicsList
        cboxClinics.SelectedIndex = -1
    End Sub

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPatientInsuranceId_TextChanged(sender As Object, e As EventArgs) Handles txtPatientInsuranceId.TextChanged
        If String.IsNullOrWhiteSpace(txtPatientInsuranceId.Text) Then
            lblInsIssDate.Enabled = False
            txtPatientInsuranceIssueDate.Enabled = False
            lblInsExpDate.Enabled = False
            txtPatientInsuranceExpiryDate.Enabled = False
        Else
            lblInsIssDate.Enabled = True
            txtPatientInsuranceIssueDate.Enabled = True
            lblInsExpDate.Enabled = True
            txtPatientInsuranceExpiryDate.Enabled = True
        End If
    End Sub

    Private Sub cboxClinics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxClinics.SelectedIndexChanged
        txtClinicId.Text = CType(cboxClinics.SelectedValue, String)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        If CheckDataInput() Then
            Dim lines As New List(Of PatientAppointmentLine)

            If txtRequest1.Text.Trim <> "" Then
                lines.Add(New PatientAppointmentLine(txtRequest1.Text.Trim))
            End If
            If txtRequest2.Text.Trim <> "" Then
                lines.Add(New PatientAppointmentLine(txtRequest2.Text.Trim))
            End If
            If txtRequest3.Text.Trim <> "" Then
                lines.Add(New PatientAppointmentLine(txtRequest3.Text.Trim))
            End If
            If txtRequest4.Text.Trim <> "" Then
                lines.Add(New PatientAppointmentLine(txtRequest4.Text.Trim))
            End If
            If txtRequest5.Text.Trim <> "" Then
                lines.Add(New PatientAppointmentLine(txtRequest5.Text.Trim))
            End If

            _appoitmentBus.AddPatientAppointment(_patient.Id, _employee.Id, CInt(txtClinicId.Text.Trim), CInt(txtAppointmentNo.Text.Trim), Date.Now, lines)
        End If
    End Sub

    Private Function CheckDataInput() As Boolean
        Dim strErr As String = String.Empty

        If txtRequest1.Text.Trim() = "" Then
            strErr = "- Yêu cầu 1."
        End If
        If cboxClinics.Text.Trim = "" Then
            strErr = strErr & vbLf & "- Phòng khám."
        End If
        Dim order As Integer
        If Not (Integer.TryParse(txtAppointmentNo.Text.Trim, order)) Then
            strErr = strErr & vbLf & "- Số thứ tự."
        End If

        If strErr <> String.Empty Then
            MessageBox.Show("Bạn phải hoàn tất chính xác các thông tin sau :" & vbLf & strErr, "Cảnh báo !", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
    End Function

    Private Sub txtRequest1_TextChanged(sender As Object, e As EventArgs) Handles txtRequest1.TextChanged
        If txtRequest1.Text.Trim = "" Then
            txtRequest2.Enabled = False
        Else
            txtRequest2.Enabled = True
        End If
    End Sub

    Private Sub txtRequest2_TextChanged(sender As Object, e As EventArgs) Handles txtRequest2.TextChanged
        If txtRequest2.Text.Trim = "" Then
            txtRequest3.Enabled = False
        Else
            txtRequest3.Enabled = True
        End If
    End Sub

    Private Sub txtRequest3_TextChanged(sender As Object, e As EventArgs) Handles txtRequest3.TextChanged
        If txtRequest3.Text.Trim = "" Then
            txtRequest4.Enabled = False
        Else
            txtRequest4.Enabled = True
        End If
    End Sub

    Private Sub txtRequest4_TextChanged(sender As Object, e As EventArgs) Handles txtRequest4.TextChanged
        If txtRequest4.Text.Trim = "" Then
            txtRequest5.Enabled = False
        Else
            txtRequest5.Enabled = True
        End If
    End Sub

End Class