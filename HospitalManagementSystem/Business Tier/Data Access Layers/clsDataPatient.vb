Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataPatient
        Private _dbAccess As DataBaseAccess

        Public Sub New()
            _dbAccess = New DataBaseAccess
        End Sub

        Friend Function GetPatientsDataTable() As DataTable
            Dim query As String = "SELECT PATIENTS.*, BEDS.Room 
                                   FROM PATIENTS LEFT OUTER JOIN
	                               BEDS ON PATIENTS.BedId = BEDS.Id"
            Return _dbAccess.GetDataTable(query)
        End Function

        Friend Function GetPatientsDataTable(id As Integer) As DataTable
            Dim query As String =
                String.Format("SELECT PATIENTS.*, BEDS.Room 
                               FROM PATIENTS LEFT OUTER JOIN
	                           BEDS ON PATIENTS.BedId = BEDS.Id
                               WHERE PATIENTS.Id = {0}", id)

            Return _dbAccess.GetDataTable(query)
        End Function

        Friend Function AddPatient(patient As Patient) As Boolean
            Dim strBedId As String = "null"

            If patient.Bed.Id <> -1 Then
                strBedId = patient.Bed.Id.ToString
            End If

            Dim query As String =
                String.Format("INSERT INTO 
                               PATIENTS(Name, Sex, DoB, IdCard, Address, Phone, 
                                        Folk, Type, InsuranceId, InsuranceIssueDate, InsuranceExpiryDate,
                                        Status, BedId)
                               VALUES  (N'{0}', '{1}', '{2}', '{3}', N'{4}', '{5}',
                                        N'{6}', N'{7}', '{8}', '{9}', '{10}',
                                        N'{11}', {12})",
                                        patient.Name, patient.Sex.ToString, patient.DoB.ToString, patient.IdCard, patient.Address, patient.Phone,
                                        patient.Folk, patient.Type, patient.InsuranceID, patient.InsuranceIssueDate.ToString, patient.InsuranceExpiryDate.ToString,
                                        patient.Status, strBedId)

            Return _dbAccess.ExecuteNoneQuery(query)
        End Function

        Friend Function UpdatePatient(patient As Patient) As Boolean
            Try
                Dim strBedId As String = "null"

                If patient.Bed.Id <> -1 Then
                    strBedId = patient.Bed.Id.ToString
                End If

                Dim query As String =
                    String.Format("UPDATE PATIENTS
                                   SET Name = N'{0}', Sex = '{1}', DoB = '{2}', IdCard = '{3}', Address = N'{4}', Phone = '{5}',
                                       Folk = N'{6}', Type = N'{7}', InsuranceId = '{8}', InsuranceIssueDate = '{9}', InsuranceExpiryDate = '{10}',
                                       Status = N'{11}', BedId = {12}
                                   WHERE Id = {13}",
                                  patient.Name, patient.Sex.ToString, patient.DoB.ToString, patient.IdCard, patient.Address, patient.Phone,
                                  patient.Folk, patient.Type, patient.InsuranceID, patient.InsuranceIssueDate, patient.InsuranceExpiryDate,
                                  patient.Status, strBedId, patient.Id)

                Return _dbAccess.ExecuteNoneQuery(query)
            Catch ex As Exception
                Return False
            End Try

        End Function

        Friend Function DeletePatient(id As Integer) As Boolean
            Try
                Dim query As String = String.Format("DELETE FROM PATIENTS WHERE id = {0}", id)
                Return _dbAccess.ExecuteNoneQuery(query)
            Catch ex As Exception
                Return False
            End Try

        End Function
    End Class
End Namespace
