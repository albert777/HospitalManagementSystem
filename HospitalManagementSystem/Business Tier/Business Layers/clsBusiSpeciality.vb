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
            If MessageBox.Show("Bạn có muốn xóa Chuyên môn: " + SpecName, "Xóa thông tin Chuyên môn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _specData.DeleteSpeciality(SpecName) Then
                    MessageBox.Show("Xóa thành công!", "Xóa thông tin Chuyên môn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Xóa thất bại!", "Xóa thông tin Chuyên môn", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End Sub

        Friend Function GetSpecialityId(Name As String) As Integer
            Return _specData.GetSpecialityId(Name)
        End Function
    End Class
End Namespace

