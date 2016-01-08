Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiDepartment
        Private _deptData As DataDepartment

        Public Sub New()
            _deptData = New DataDepartment()
        End Sub

        Public Function LoadDepartmentsList() As DataTable
            Return _deptData.GetDepartmentsDataTable()
        End Function

        Friend Sub AddDepartment(name As String, chiefid As Integer)
            _deptData.AddDepartment(name, chiefid)
        End Sub

        Friend Sub UpdateDepartment(oldName As String, newName As String, chiefid As Integer)
            _deptData.UpdateDepartment(oldName, newName, chiefid)
        End Sub

        Friend Sub DeleteDepartment(name As String)
            _deptData.DeleteDepartment(name)
        End Sub
    End Class
End Namespace
