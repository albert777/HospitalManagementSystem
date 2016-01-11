Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiBed
        Private _bedData As DataBed

        Public Sub New()
            _bedData = New DataBed
        End Sub

        Friend Function LoadBedsList() As DataTable
            Return _bedData.GetBedsDataTable()
        End Function

        Friend Sub DeleteBed(id As Integer)
            If MessageBox.Show("Bạn có muốn xóa Giường bệnh: " + id.ToString, "Xóa thông tin Giường bệnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _bedData.DeleteBed(id) Then
                    MessageBox.Show("Xóa thành công!", "Xóa thông tin Giường bệnh", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa thất bại!", "Xóa thông tin Giường bệnh", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End Sub

        Friend Sub AddBed(RoomId As Integer, DeptId As Integer)
            _bedData.AddBed(RoomId, DeptId)
        End Sub

        Friend Sub UpdateBed(id As Integer, roomId As Integer, deptId As Integer)
            _bedData.UpdateBed(id, roomId, deptId)
        End Sub

        Friend Function GetBedsDepartmentsDataTable() As DataTable
            Return _bedData.GetBedsDepartmentDataTable()
        End Function

        Friend Function GetBedsRoomsDataTable(deptId As Integer) As DataTable
            Return _bedData.GetBedsRoomsDataTable(deptId)
        End Function

        Friend Function GetBedsDataTable(deptId As Integer, room As Integer) As Object
            Return _bedData.GetBedsDataTable(deptId, room)
        End Function
    End Class
End Namespace
