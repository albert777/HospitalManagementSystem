Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO
Imports Microsoft.Office.Interop

Public Class frmAdmission
    Private _employee As Employee
    Private _patient As Patient

    Private _bedBus As BusiBed
    Private _emplBus As BusiEmployee

    Public Sub New(ByVal Employee As Employee, ByVal Patient As Patient)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _bedBus = New BusiBed
        _emplBus = New BusiEmployee

        _employee = Employee
        _patient = Patient

        txtAdmissionTime.Text = Date.Now.ToShortDateString()
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

        LoadBedsDepartmentsComboList()
    End Sub

    Private Sub LoadBedsDepartmentsComboList()
        cboxBed_DepartmentsName.DataSource = _bedBus.GetBedsDepartmentsDataTable()
        cboxBed_DepartmentsName.SelectedIndex = -1

    End Sub

    Private Sub LoadBedsRoomsComboList(DeptId As Integer)
        cboxRooms.DataSource = _bedBus.GetBedsRoomsDataTable(DeptId)
        cboxRooms.SelectedIndex = -1

    End Sub

    Private Sub LoadBedsComboBox(deptId As Integer, room As Integer)
        cboxBeds.DataSource = _bedBus.GetBedsDataTable(deptId, room)
        cboxBeds.SelectedIndex = -1
    End Sub

    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub rbtnOutpatient_CheckedChanged(sender As Object, e As EventArgs) _
        Handles rbtnOutpatient.CheckedChanged,
                rbtnInpatient.CheckedChanged,
                rbtnEmergencyPatient.CheckedChanged

        If rbtnOutpatient.Checked = True Then
            gboxBed.Enabled = False
        Else
            gboxBed.Enabled = True
        End If

        If rbtnInpatient.Checked = True OrElse rbtnEmergencyPatient.Checked = True Then
            gboxBed.Enabled = True
        Else
            gboxBed.Enabled = False
        End If

    End Sub

    Private Sub cboxBed_DepartmentsName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxBed_DepartmentsName.SelectedIndexChanged
        LoadBedsRoomsComboList(CInt(cboxBed_DepartmentsName.SelectedValue))
    End Sub

    Private Sub cboxRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxRooms.SelectedIndexChanged
        LoadBedsComboBox(CInt(cboxBed_DepartmentsName.SelectedValue), CInt(cboxRooms.SelectedValue))
    End Sub

    Private Sub btnAdmission_Click(sender As Object, e As EventArgs) Handles btnAdmission.Click
        If rbtnOutpatient.Checked = False AndAlso rbtnInpatient.Checked = False AndAlso rbtnEmergencyPatient.Checked = False Then
            MsgBox("Bạn cần chọn phân loại bệnh nhân")
        Else
            Dim patientType As String = ""
            If rbtnOutpatient.Checked = False Then
                If cboxBeds.SelectedIndex = -1 Then
                    MsgBox("Bạn cần chọn số giường")
                Else
                    'Inpatient Addmission 
                    If rbtnInpatient.Checked = True Then
                        patientType = "Nội trú"
                    Else
                        patientType = "Khẩn cấp"
                    End If
                    If _emplBus.InpatientAdmission(_employee.Id, _patient.Id, CInt(cboxBeds.SelectedValue), patientType) Then
                        btnAdmission.Enabled = False
                    Else
                        btnAdmission.Enabled = True
                    End If
                End If
            Else
                'Outpatient Addmission 
                If _emplBus.OutpatientAdmission(_employee.Id, _patient.Id) Then
                    btnAdmission.Enabled = False
                Else
                    btnAdmission.Enabled = True
                End If
            End If
            End If
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

        objselection.TypeText("PHIẾU NHẬP VIỆN" & vbCrLf)
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

        objDocumet.SaveAs(Application.StartupPath & "\Admission.doc")
    End Sub



End Class