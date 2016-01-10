﻿Imports HospitalManagementSystem.DAO
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

        Friend Function GetPatientAppointmentLines(id As Integer) As List(Of PatientAppointmentLine)
            Return _appointmentData.GetPatientAppointmentLines(id)
        End Function
    End Class
End Namespace
