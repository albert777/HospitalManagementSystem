Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiSpeciality
        Private _specData As DataSpeciality

        Public Sub New()
            _specData = New DataSpeciality()
        End Sub

        Public Function LoadSpecialitiesList() As DataTable
            Return _specData.GetSpecialitiesDataTable()
        End Function

        Friend Sub AddSpeciality(SpecName As String)
            _specData.AddSpeciality(SpecName)
        End Sub

        Friend Sub UpdateSpeciality(OldName As String, NewName As String)
            _specData.UpdateSpeciality(OldName, NewName)
        End Sub

        Friend Sub DeleteSpeciality(SpecName As String)
            _specData.DeleteSpeciality(SpecName)
        End Sub

        Friend Function GetSpecialityId(Name As String) As Integer
            Return _specData.GetSpecialityId(Name)
        End Function
    End Class
End Namespace

