Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataPatientAppointment
        Private _dbAccess As DataBaseAccess
        Private _appointLineData As DataPatientAppointmentLine

        Public Sub New()
            _dbAccess = New DataBaseAccess
            _appointLineData = New DataPatientAppointmentLine
        End Sub

        Friend Function AddPatientAppointment(patientId As Integer, employeeId As Integer,
                                              clinicId As Integer, ordernumber As Integer,
                                              createTime As Date, appointmentLines As List(Of PatientAppointmentLine)) As Boolean
            Try
                Dim query As String =
                    String.Format("INSERT INTO APPOINTMENTS (PatientId, EmployeeId, ClinicId, NumberOrder, CreateTime)
                                   VALUES ({0}, {1}, {2}, {3}, '{4}')",
                                   patientId, employeeId, clinicId, ordernumber, createTime)

                If _dbAccess.ExecuteNoneQuery(query) Then
                    Dim appId As Integer = Me.GetAppointmentId(patientId, employeeId, clinicId, ordernumber, createTime)

                    For Each line In appointmentLines
                        If Not (_appointLineData.AddApointmentLines(appId, line)) Then
                            Return False
                        End If

                    Next

                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False

            End Try

        End Function

        Private Function GetAppointmentId(patientId As Integer, employeeId As Integer, clinicId As Integer, ordernumber As Integer, createTime As Date) As Integer
            Dim query As String =
                String.Format("SELECT Id FROM APPOINTMENTS " _
                            + "WHERE PatientId = {0} " _
                            + "And EmployeeId = {1} " _
                            + "And ClinicId = {2} " _
                            + "And NumberOrder = {3} " _
                            + "And CreateTime = '{4}'",
                              patientId, employeeId, clinicId, ordernumber, createTime)

            Return CInt(_dbAccess.GetScalar(query))
        End Function

    End Class
End Namespace
