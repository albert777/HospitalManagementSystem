Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusPatient
        Private _patientData As DataPatient

        Public Sub New()
            _patientData = New DataPatient
        End Sub

        Friend Function SearchPatientsDataTable() As DataTable
            Return _patientData.GetPatientsDataTable()
        End Function

        Friend Function SearchPatientsDataTable(id As Integer) As DataTable
            Return _patientData.GetPatientsDataTable(id)
        End Function

        Friend Sub AddPatient(patient As Patient)
            If _patientData.AddPatient(patient) Then
                MsgBox("Thêm Bệnh nhân thành công")
            Else
                MsgBox("Thêm Bệnh nhân thất bại")
            End If
        End Sub

        Friend Function GetAdmission(id As Integer) As PatientAdmission
            Return _patientData.GetAdmission(id)
        End Function

        Friend Sub DeletePatient(id As Integer)
            If _patientData.DeletePatient(id) Then
                MsgBox("Xóa Bệnh nhân thành công")
            Else
                MsgBox("Xóa Bệnh nhân thất bại")
            End If
        End Sub

        Friend Sub UpdatePatient(patient As Patient)
            If _patientData.UpdatePatient(patient) Then
                MsgBox("Sửa thông tin Bệnh nhân thành công")
            Else
                MsgBox("Sửa thông tin Bệnh nhân thất bại")
            End If
        End Sub

        Friend Function GetAdmissionTime(Id As Integer) As Date
            Return _patientData.GetAdmissionTime(Id)
        End Function

        Friend Function GetDischargeTime(id As Integer) As Date
            Return _patientData.GetDischargeTime(id)
        End Function

        Friend Function Discharge(employeeId As Integer, admissionId As Integer, treatment As String, result As String, prescribe As String) As Boolean
            Return _patientData.Discharge(employeeId, admissionId, treatment, result, prescribe)
        End Function

        Friend Function GetBed(id As Integer) As Bed
            Return _patientData.GetBed(id)

        End Function
    End Class
End Namespace
