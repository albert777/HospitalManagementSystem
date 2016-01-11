Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataClinic
        Inherits DataBaseAccess

        Public Sub New()

        End Sub

        Friend Function GetClinicsDataTable() As DataTable
            Dim query As String = "SELECT * FROM CLINICS"
            Return GetDataTable(query)
        End Function

        Friend Function AddClinic(clinicName As String) As Boolean
            Dim query As String = String.Format("INSERT INTO CLINICS (Name) VALUES (N'{0}')", clinicName)
            Return ExecuteNoneQuery(query)
        End Function

        Friend Function UpdateClinic(oldName As String, newName As String) As Boolean
            Dim query As String = String.Format("UPDATE CLINICS SET Name = N'{0}' WHERE Name = N'{1}'", newName, oldName)
            Return ExecuteNoneQuery(query)
        End Function

        Friend Function DeleteClinic(clinicName As String) As Boolean
            Dim query As String = String.Format("DELETE FROM CLINICS WHERE Name = N'{0}'", clinicName)
            Return ExecuteNoneQuery(query)
        End Function

        'Friend Function GetClinicById(id As Integer) As Clinic
        '    Dim query As String =
        '        String.Format
        'End Function
    End Class
End Namespace
