Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiEmployee
        Private _emplData As DataEmployee

        Public Sub New()
            _emplData = New DataEmployee()
        End Sub

        Friend Function Sex(txtSex As String) As Boolean
            Return (txtSex = "Nam")

        End Function

        Friend Function SearchEmployees() As DataTable
            Return _emplData.GetEmployeesDataTable()
        End Function

        Friend Sub DeleteEmployee(EmployeeId As Integer)
            If MessageBox.Show("Bạn có muốn xóa nhân viên?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _emplData.DeleteEmployee(EmployeeId) Then
                    MessageBox.Show("Xóa nhân viên thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa nhân viên thất bại", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Friend Sub AddEmployee(Employee As Employee)
            If MessageBox.Show("Bạn có muốn thêm nhân viên?", "Thêm nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _emplData.AddEmployee(Employee) Then
                    MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Thêm nhân viên thất bại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End Sub

        Friend Sub UpdateEmployee(Employee As Employee)
            If MessageBox.Show("Bạn có muốn sửa nhân viên?", "Sửa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _emplData.UpdateEmployee(Employee) Then
                    MessageBox.Show("Sửa nhân viên thành công", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Sửa nhân viên thất bại", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub
    End Class
End Namespace
