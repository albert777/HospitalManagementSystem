Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusPatientAppointment
        Private _appointmentData As DataPatientAppointment

        Public Sub New()
            _appointmentData = New DataPatientAppointment
        End Sub

        Friend Sub AddPatientAppointment(patientId As Integer, employeeId As Integer, clinicId As Integer, ordernumber As Integer, createTime As Date, lines As List(Of PatientAppointmentLine))
            If _appointmentData.AddPatientAppointment(patientId, employeeId, clinicId, ordernumber, createTime, lines) Then
                MsgBox("Tạo phiếu đăng ký khám thành công")
            Else
                MsgBox("Tạo phiếu đăng ký khám thất bại")
            End If
        End Sub
    End Class
End Namespace
