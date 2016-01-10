Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataSpeciality
        Inherits DataBaseAccess

        Public Sub New()

        End Sub

        Friend Function GetSpecialitiesDataTable() As DataTable
            Dim query As String = "SELECT S.Id, S.Name, COUNT(E.Id) AS COUNT
                                   FROM SPECIALITIES AS S LEFT OUTER JOIN
                                        EMPLOYEES AS E ON S.Id = E.SpecId
                                   GROUP BY S.Id, S.Name"
            Return GetDataTable(query)
        End Function

        Friend Sub AddSpeciality(specName As String)
            Dim query As String = String.Format("INSERT INTO SPECIALITIES(Name) VALUES(N'{0}')", specName)

            ExecuteNoneQuery(query)
        End Sub

        Friend Sub UpdateSpeciality(oldName As String, newName As String)
            Dim query As String = String.Format("UPDATE SPECIALITIES SET Name = N'{0}' WHERE Name = N'{1}'",
                                                newName, oldName)

            ExecuteNoneQuery(query)
        End Sub

        Friend Function GetSpecialityId(name As String) As Integer
            Dim query As String = String.Format("SELECT Id FROM SPECIALITIES WHERE Name = N'{0}'", name)
            Return CInt(GetScalar(query))
        End Function

        Friend Function DeleteSpeciality(specName As String) As Boolean
            Dim query As String = String.Format("DELETE FROM SPECIALITIES WHERE Name = N'{0}'", specName)
            Return ExecuteNoneQuery(query)
        End Function
    End Class
End Namespace
