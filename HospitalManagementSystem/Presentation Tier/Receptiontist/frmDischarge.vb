Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO
Imports Microsoft.Office.Interop

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

    Private Sub btnPrintAdmission_Click(sender As Object, e As EventArgs) Handles btnPrintAdmission.Click
        CreateWord()
    End Sub

    Private Sub CreateWord()
        Dim objApp As New Word.Application
        Dim objDocumet As New Word.Document

        objApp.Visible = True
        objApp.Activate()
        objDocumet = objApp.Documents.Add
        Dim objselection As Word.Selection
        objselection = objDocumet.Application.Selection
        objselection.TypeParagraph()
        objselection.Font.Color = Word.WdColor.wdColorRed
        objselection.Font.Size = 18
        objselection.Font.Bold = 1

        objselection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

        objselection.TypeText("PHIẾU XUẤT VIỆN" & vbCrLf)
        objselection.TypeParagraph()

        objselection.Font.Color = Word.WdColor.wdColorBlack
        objselection.Font.Size = 13
        objselection.Font.Bold = 0

        objselection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft

        objselection.TypeText("Số phiếu: " & txtAdmissionId.Text & vbCrLf)
        objselection.TypeText("Người lập phiếu: " & txtEmployeeName.Text & vbCrLf)
        objselection.TypeText("Thời gian lập: " & txtAdmissionTime.Text & vbCrLf)

        objselection.TypeParagraph()

        objselection.TypeText("Mã bệnh nhân: " & txtPatientId.Text & vbCrLf)
        objselection.TypeText("Tên bệnh nhân: " & txtPatientName.Text & vbCrLf)
        objselection.TypeText("Ngày sinh: " & txtPatientDoB.Text & vbCrLf)

        objselection.TypeText("Số bảo hiểm: " & txtPatientInsuranceId.Text & vbCrLf)
        objselection.TypeText("Ngày cấp: " & txtPatientInsuranceIssueDate.Text & vbCrLf)
        objselection.TypeText("Ngày hết hạn: " & txtPatientInsuranceExpiryDate.Text & vbCrLf)

        objselection.TypeParagraph()

        objselection.TypeText("Phương pháp điều trị: " & txtTreatment.Text & vbCrLf)
        objselection.TypeText("Kết quả điều trị: " & txtResult.Text & vbCrLf)
        objselection.TypeText("Lời khuyên của bác sĩ: " & txtPrescribe.Text & vbCrLf)

        objDocumet.SaveAs(Application.StartupPath & "\Admission.doc")
    End Sub
End Class