Imports HospitalManagementSystem
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmAppointment
    Private _employee As Employee
    Private _patient As Patient
    Private _doctor As Employee

    Private _clinicBus As BusiClinic
    Private _appoitmentBus As BusPatientAppointment

    Public Sub New(ByVal Type As String, Optional ByVal patient As Patient = Nothing, Optional ByVal appointment As PatientAppointment = Nothing, Optional ByVal doctor As Employee = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _clinicBus = New BusiClinic
        _appoitmentBus = New BusPatientAppointment

        LoadClinicsComboBox()

        If Type = "New" Then
            _employee = My.Forms.frmMain._account.Employee
            _patient = patient
            txtAppointmentCreateTime.Text = Date.Now.ToShortDateString() + " " + Date.Now.ToLongTimeString

            txtResult.ReadOnly = True
            txtResult.BackColor = Color.FromArgb(255, 255, 192)
            txtPrescribe.ReadOnly = True
            txtPrescribe.BackColor = Color.FromArgb(255, 255, 192)

            txtRequest2.Enabled = False
            txtRequest3.Enabled = False
            txtRequest4.Enabled = False
            txtRequest5.Enabled = False

        ElseIf Type = "View" Then
            SetViewMode()

            _employee = appointment.Employee
            _patient = appointment.Patient
            txtAppoimentId.Text = appointment.Id.ToString
            txtAppointmentCreateTime.Text = appointment.CreateTime.ToShortDateString
            txtDoctor.Text = appointment.Doctor.Name.ToString

            txtResult.Text = appointment.Result
            txtPrescribe.Text = appointment.Prescribe
            txtResult.ReadOnly = True
            txtResult.BackColor = Color.FromArgb(255, 255, 192)
            txtPrescribe.ReadOnly = True
            txtPrescribe.BackColor = Color.FromArgb(255, 255, 192)

            cboxClinics.SelectedValue = appointment.Clinic.Id
            txtAppointmentNo.Text = appointment.Numberorder.ToString

            appointment.Lines = _appoitmentBus.GetPatientAppointmentLines(appointment.Id)

            txtRequest1.Text = appointment.Lines(0).Detail
            If appointment.Lines.Count >= 2 Then
                txtRequest2.Text = appointment.Lines(1).Detail
            End If
            If appointment.Lines.Count >= 3 Then
                txtRequest3.Text = appointment.Lines(2).Detail
            End If
            If appointment.Lines.Count >= 4 Then
                txtRequest4.Text = appointment.Lines(3).Detail
            End If
            If appointment.Lines.Count = 5 Then
                txtRequest5.Text = appointment.Lines(4).Detail
            End If

        ElseIf Type = "Update" Then
            SetViewMode()
            btnUpdateAppointment.Enabled = True

            _employee = appointment.Employee
            _patient = appointment.Patient
            _doctor = doctor

            txtAppoimentId.Text = appointment.Id.ToString
            txtAppointmentCreateTime.Text = appointment.CreateTime.ToShortDateString

            cboxClinics.SelectedValue = appointment.Clinic.Id
            txtAppointmentNo.Text = appointment.Numberorder.ToString

            appointment.Lines = _appoitmentBus.GetPatientAppointmentLines(appointment.Id)

            txtRequest1.Text = appointment.Lines(0).Detail
            If appointment.Lines.Count >= 2 Then
                txtRequest2.Text = appointment.Lines(1).Detail
            End If
            If appointment.Lines.Count >= 3 Then
                txtRequest3.Text = appointment.Lines(2).Detail
            End If
            If appointment.Lines.Count >= 4 Then
                txtRequest4.Text = appointment.Lines(3).Detail
            End If
            If appointment.Lines.Count = 5 Then
                txtRequest5.Text = appointment.Lines(4).Detail
            End If

            txtDoctor.Text = _doctor.Name
        End If

        txtAppointmentEmployeeName.Text = _employee.Name

        txtPatientId.Text = _patient.Id.ToString
        txtPatientName.Text = _patient.Name
        txtPatientDoB.Text = _patient.DoB.ToShortDateString

        txtPatientInsuranceIssueDate.Text = _patient.InsuranceIssueDate.ToShortDateString()
        txtPatientInsuranceExpiryDate.Text = _patient.InsuranceExpiryDate.ToShortDateString
        txtPatientInsuranceId.Text = "Nothing"
        txtPatientInsuranceId.Text = _patient.InsuranceID

        rbtnSexMale.Checked = _patient.Sex
        rbtnSexFemale.Checked = Not (_patient.Sex)

    End Sub

    Private Sub LoadClinicsComboBox()
        cboxClinics.DataSource = _clinicBus.LoadClinicsList
        cboxClinics.SelectedIndex = -1
    End Sub

    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub cboxClinics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxClinics.SelectedIndexChanged
        txtClinicId.Text = CType(cboxClinics.SelectedValue, String)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnNewAppointment.Click
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

            If _appoitmentBus.AddPatientAppointment(_patient.Id, _employee.Id, CInt(txtClinicId.Text.Trim), CInt(txtAppointmentNo.Text.Trim), Date.Now, lines) Then
                SetViewMode()
                txtAppoimentId.Text = _appoitmentBus.GetPatientLastAppointmentId(_patient.Id)
            Else
                btnNewAppointment.Enabled = True
            End If
        End If
    End Sub

    Private Sub SetViewMode()
        btnNewAppointment.Enabled = False
        txtRequest1.ReadOnly = True
        txtRequest1.BackColor = Color.FromArgb(255, 255, 192)
        txtRequest2.ReadOnly = True
        txtRequest2.BackColor = Color.FromArgb(255, 255, 192)
        txtRequest3.ReadOnly = True
        txtRequest3.BackColor = Color.FromArgb(255, 255, 192)
        txtRequest4.ReadOnly = True
        txtRequest4.BackColor = Color.FromArgb(255, 255, 192)
        txtRequest5.ReadOnly = True
        txtRequest5.BackColor = Color.FromArgb(255, 255, 192)
        cboxClinics.Enabled = False
        txtAppointmentNo.ReadOnly = True
        txtAppointmentNo.BackColor = Color.FromArgb(255, 255, 192)
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

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdateAppointment_Click(sender As Object, e As EventArgs) Handles btnUpdateAppointment.Click
        If CheckDataUpdate() Then
            If _appoitmentBus.UpdateAppointment(CInt(txtAppoimentId.Text.Trim), _doctor.Id, txtResult.Text.Trim, txtPrescribe.Text.Trim) Then
                btnUpdateAppointment.Enabled = False
                txtResult.ReadOnly = True
                txtPrescribe.ReadOnly = True
            Else
                btnUpdateAppointment.Enabled = True
            End If
        Else
            MsgBox("Bạn cần nhập đủ thông tin!")
        End If
    End Sub

    Private Function CheckDataUpdate() As Boolean
        If txtPrescribe.Text.Trim = "" Or txtResult.Text.Trim = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class