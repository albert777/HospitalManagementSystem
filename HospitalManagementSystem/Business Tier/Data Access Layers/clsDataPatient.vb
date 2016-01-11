Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataPatient
        Private _dbAccess As DataBaseAccess

        Public Sub New()
            _dbAccess = New DataBaseAccess
        End Sub

        Friend Function GetPatientsDataTable() As DataTable
            Dim query As String = "SELECT * FROM PATIENTS"
            Return _dbAccess.GetDataTable(query)
        End Function

        Friend Function GetPatientsDataTable(id As Integer) As DataTable
            Dim query As String =
                String.Format("SELECT *
                               FROM PATIENTS
                               WHERE PATIENTS.Id = {0}", id)

            Return _dbAccess.GetDataTable(query)
        End Function

        Friend Function GetAdmission(id As Integer) As PatientAdmission
            Dim admis As New PatientAdmission

            Try
                Dim query As String =
                    String.Format("SELECT * FROM ADMISSIONS
                                   WHERE PatientId = {0}
                                   ORDER BY Id DESC", id)
                Dim dtAdmis As DataTable = _dbAccess.GetDataTable(query)
                If dtAdmis.Rows.Count > 0 Then
                    admis = New PatientAdmission(CInt(dtAdmis.Rows(0).Item("Id")), CDate(dtAdmis.Rows(0).Item("AdmissionTime")))
                End If

            Catch ex As Exception

            End Try

            Return admis
        End Function

        Friend Function AddPatient(patient As Patient) As Boolean
            Dim strBedId As String = "null"

            If patient.Bed.Id <> -1 Then
                strBedId = patient.Bed.Id.ToString
            End If

            Dim query As String =
                String.Format("INSERT INTO 
                               PATIENTS(Name, Sex, DoB, IdCard, Address, Phone, 
                                        Folk, InsuranceId, InsuranceIssueDate, InsuranceExpiryDate,
                                        Status, BedId)
                               VALUES  (N'{0}', '{1}', '{2}', '{3}', N'{4}', '{5}',
                                        N'{6}', '{7}', '{8}', '{9}',
                                        N'{10}', {11})",
                                        patient.Name, patient.Sex.ToString, patient.DoB.ToString, patient.IdCard, patient.Address, patient.Phone,
                                        patient.Folk, patient.InsuranceID, patient.InsuranceIssueDate.ToString, patient.InsuranceExpiryDate.ToString,
                                        patient.Status, strBedId)

            Return _dbAccess.ExecuteNoneQuery(query)
        End Function

        Friend Function GetPatientById(id As Integer) As Patient
            Dim patient As Patient = Nothing

            Try
                Dim dtEmpl As DataTable = GetPatientsDataTable(id)

                If dtEmpl.Rows.Count > 0 Then

                    With dtEmpl.Rows(0)
                        patient = New Patient
                        patient.Id = CInt(.Item("Id"))
                        patient.Name = CType(.Item("Name"), String)
                        patient.Sex = CBool(.Item("Sex"))
                        patient.DoB = CDate(.Item("DoB"))

                        If .Item("InsuranceId").Equals(DBNull.Value) Then
                            patient.InsuranceID = ""
                            patient.InsuranceIssueDate = Date.MinValue
                            patient.InsuranceExpiryDate = Date.MaxValue
                        Else
                            patient.InsuranceID = CType(.Item("InsuranceId"), String)
                            patient.InsuranceIssueDate = CDate(.Item("InsuranceIssueDate"))
                            patient.InsuranceExpiryDate = CDate(.Item("InsuranceExpiryDate"))
                        End If

                    End With
                End If
            Catch ex As Exception

            End Try

            Return patient
        End Function

        Friend Function GetBed(id As Integer) As Bed
            Dim bed As Bed = Nothing

            Try
                Dim query As String =
                    String.Format("SELECT TOP(1) A.BedId, B.Room, B.DeptId 
                                    FROM ADMISSIONS AS A
                                    LEFT OUTER JOIN BEDS AS B ON A.BedId = B.Id
                                    WHERE A.PatientId = {0}
                                    ORDER BY A.Id DESC", id)
                Dim dtBed As DataTable = _dbAccess.GetDataTable(query)

                If dtBed.Rows.Count > 0 Then
                    If Not dtBed.Rows(0).Item("BedId").Equals(DBNull.Value) Then
                        bed = New Bed
                        bed.Id = CInt(dtBed.Rows(0).Item("BedId"))
                        bed.Room = CInt(dtBed.Rows(0).Item("Room"))

                    End If

                End If
            Catch ex As Exception

            End Try

            Return bed
        End Function

        Friend Function Discharge(employeeId As Integer, admissionId As Integer, treatment As String, result As String, prescribe As String) As Boolean
            Dim query As String =
                String.Format("INSERT INTO DISCHARGES(EmployeeId, AdmissionId, DischargeTime, Treatment, Result, Prescirbe)
                               VALUES ({0}, {1}, GETDATE(), N'{2}', N'{3}', N'{4}')",
                               employeeId, admissionId, treatment, result, prescribe)

            Return _dbAccess.ExecuteNoneQuery(query)
        End Function

        Friend Function GetDischargeTime(id As Integer) As Date
            Dim query As String =
                String.Format("SELECT D.DischargeTime, A.AdmissionTime, P.Id, P.Name, A.Id As AId
                               FROM PATIENTS AS P
                               LEFT OUTER JOIN ADMISSIONS AS A ON P.Id = A.PatientId
                               LEFT OUTER JOIN DISCHARGES AS D ON A.Id = D.AdmissionId
                               WHERE P.Id = {0}
                               ORDER BY AId DESC", id)

            If _dbAccess.GetScalar(query).Equals(DBNull.Value) Then
                Return Date.MinValue
            Else
                Return CDate(_dbAccess.GetScalar(query))
            End If

        End Function

        Friend Function GetAdmissionTime(Id As Integer) As Date
            Dim query As String =
                String.Format("SELECT A.AdmissionTime, D.DischargeTime, P.Id, P.Name, A.Id As AId
                               FROM PATIENTS AS P
                               LEFT OUTER JOIN ADMISSIONS AS A ON P.Id = A.PatientId
                               LEFT OUTER JOIN DISCHARGES AS D ON A.Id = D.AdmissionId
                               WHERE P.Id = {0}
                               ORDER BY AId DESC", Id)

            If _dbAccess.GetScalar(query).Equals(DBNull.Value) Then
                Return Date.MinValue
            Else
                Return CDate(_dbAccess.GetScalar(query))
            End If

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
                                       Folk = N'{6}', InsuranceId = '{7}', InsuranceIssueDate = '{8}', InsuranceExpiryDate = '{9}',
                                       Status = N'{10}', BedId = {11}
                                   WHERE Id = {12}",
                                  patient.Name, patient.Sex.ToString, patient.DoB.ToString, patient.IdCard, patient.Address, patient.Phone,
                                  patient.Folk, patient.InsuranceID, patient.InsuranceIssueDate, patient.InsuranceExpiryDate,
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
