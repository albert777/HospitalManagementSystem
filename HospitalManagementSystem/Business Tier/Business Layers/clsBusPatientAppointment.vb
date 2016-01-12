Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusPatientAppointment
        Private _appointmentData As DataPatientAppointment

        Public Sub New()
            _appointmentData = New DataPatientAppointment
        End Sub

        Friend Function AddPatientAppointment(patientId As Integer, employeeId As Integer, clinicId As Integer, ordernumber As Integer, createTime As Date, lines As List(Of PatientAppointmentLine)) As Boolean
            If _appointmentData.AddPatientAppointment(patientId, employeeId, clinicId, ordernumber, createTime, lines) Then
                MsgBox("Tạo phiếu đăng ký khám thành công")
                Return True
            Else
                MsgBox("Tạo phiếu đăng ký khám thất bại")
                Return False
            End If
        End Function

        Friend Function GetPatientAppointmentsDataTable(patientId As Integer) As DataTable
            Return _appointmentData.GetPatientAppointmentsDataTable(patientId)
        End Function

        Friend Function GetPatientAppointmentById(id As Integer) As PatientAppointment
            Return _appointmentData.GetAppointmentById(id)
        End Function

        Friend Function GetPatientAppointmentLines(id As Integer) As List(Of PatientAppointmentLine)
            Return _appointmentData.GetPatientAppointmentLines(id)
        End Function

        Friend Function GetPatientLastAppointmentId(id As Integer) As String
            Return _appointmentData.GetPatientLastAppointmentId(id)
        End Function

        Friend Function UpdateAppointment(appId As Integer, doctorId As Integer, result As String, prescibe As String) As Boolean
            If _appointmentData.UpdateAppointment(appId, doctorId, result, prescibe) Then
                MsgBox("Cập nhật thành công")
                Return True
            Else
                MsgBox("Cập nhật thất bại")
                Return False
            End If
        End Function
    End Class
End Namespace
