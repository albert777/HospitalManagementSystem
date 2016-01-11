Imports System.Windows.Forms
Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmUpdateAppointment_EnterId
    Private _appointBus As BusPatientAppointment

    Private _appoint As PatientAppointment

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _appointBus = New BusPatientAppointment
        btnViewAppointment.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAppointmentId.TextChanged
        btnViewAppointment.Enabled = False

        If IsNumeric(txtAppointmentId.Text.Trim) Then
            If _appointBus.GetPatientAppointmentById(CInt(txtAppointmentId.Text.Trim)) Is Nothing Then
                ErrorProvider1.SetError(txtAppointmentId, "Mã số phiếu không chính xác!")

            Else
                _appoint = _appointBus.GetPatientAppointmentById(CInt(txtAppointmentId.Text.Trim))
                ErrorProvider1.SetError(txtAppointmentId, "")
                btnViewAppointment.Enabled = True
            End If
        Else
            ErrorProvider1.SetError(txtAppointmentId, "Mã số phiếu không hợp lệ, phải là kiểu số!")

        End If
    End Sub

    Private Sub btnViewAppointment_Click(sender As Object, e As EventArgs) Handles btnViewAppointment.Click
        Dim frmViewAppointment As New frmAppointment("Update", , _appoint, My.Forms.frmMain._account.Employee)
        frmViewAppointment.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

End Class
