Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataPatientAppointmentLine
        Private _dbAccess As DataBaseAccess

        Public Sub New()
            _dbAccess = New DataBaseAccess
        End Sub

        Friend Function AddApointmentLines(appId As Integer, line As PatientAppointmentLine) As Boolean
            Try
                Dim query As String =
                    String.Format("INSERT INTO APPOINTMENTLINES (AppointmentId, Detail) " _
                                + "VALUES ({0}, N'{1}')",
                                  appId, line.Detail)

                Return _dbAccess.ExecuteNoneQuery(query)
            Catch ex As Exception
                Return False
            End Try

        End Function
    End Class
End Namespace
