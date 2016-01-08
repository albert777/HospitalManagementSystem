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
            If MessageBox.Show("Bạn có muốn xóa Khoa: " + name, "Xóa thông tin Khoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _deptData.DeleteDepartment(name) Then
                    MessageBox.Show("Xóa thành công!", "Xóa thông tin Khoa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa thất bại!", "Xóa thông tin Khoa", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End Sub
    End Class
End Namespace
