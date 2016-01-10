Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiClinic
        Private _clinicData As DataClinic

        Public Sub New()
            _clinicData = New DataClinic
        End Sub

        Friend Function LoadClinicsList() As DataTable
            Return _clinicData.GetClinicsDataTable()
        End Function

        Friend Sub AddClinic(clinicName As String)
            If MessageBox.Show("Bạn có thêm Phòng khám: " + clinicName, "Thêm thông tin Phòng khám", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _clinicData.AddClinic(clinicName) Then
                    MessageBox.Show("Thêm thành công!", "Thêm thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Thêm thất bại!", "Thêm thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Friend Sub UpdateClinic(oldName As String, newName As String)
            If MessageBox.Show("Bạn có sửa Phòng khám: " + oldName, "Sửa thông tin Phòng khám", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _clinicData.UpdateClinic(oldName, newName) Then
                    MessageBox.Show("Sửa thành công!", "Sửa thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Sửa thất bại!", "Sửa thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Friend Sub DeleteClinic(clinicName As String)
            If MessageBox.Show("Bạn có muốn xóa Phòng khám: " + clinicName, "Xóa thông tin Phòng khám", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _clinicData.DeleteClinic(clinicName) Then
                    MessageBox.Show("Xóa thành công!", "Xóa thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa thất bại!", "Xóa thông tin Phòng khám", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub
    End Class
End Namespace

