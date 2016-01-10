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

        Friend Function GetPatientAppointmentLinesDataTable(id As Integer) As DataTable
            Dim query As String =
                    String.Format("SELECT L.Id As LineId, L.Detail " _
                                + "FROM APPOINTMENTS AS A LEFT OUTER JOIN " _
                                + "APPOINTMENTLINES AS L ON A.Id = L.AppointmentId " _
                                + "LEFT OUTER JOIN PATIENTS AS P ON A.PatientId = P.Id " _
                                + "WHERE A.Id = {0}", id)
            Return _dbAccess.GetDataTable(query)
        End Function
    End Class
End Namespace
