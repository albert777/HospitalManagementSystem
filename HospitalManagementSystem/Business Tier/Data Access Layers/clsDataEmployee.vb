Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataEmployee
        'Private _dbAccess As DataBaseAccess
        Inherits DataBaseAccess

#Region "Constructor"
        Public Sub New()

        End Sub

        Friend Function GetEmployeesDataTable() As DataTable
            Try
                Dim query As String = "SELECT E.Id, E.Name, E.Sex, E.DoB, E.IdCard, E.Address, E.Phone, E.Folk, 
                                       E.HireDate, E.BasicSalary, E.Subsidy, E.Ratio, 
                                       E.Position, E.DeptId, D.Name AS DeptName, S.Name AS SpecName, E.SpecId
                                       FROM EMPLOYEES AS E LEFT OUTER JOIN
                                       SPECIALITIES AS S ON E.SpecId = S.Id LEFT OUTER JOIN
                                       DEPARTMENTS AS D ON E.DeptId = D.Id"

                Return GetDataTable(query)

            Catch ex As Exception
                My.Forms.frmMain.txtStatus.Text = "Không thể lấy dữ liệu nhân viên"
                Return Nothing
            End Try

        End Function

        Friend Function GetEmployeesDataTable(id As Integer) As DataTable
            Try

                Dim query As String =
                    String.Format("SELECT E.Id, E.Name, E.Sex, E.DoB, E.IdCard, E.Address, E.Phone, E.Folk, 
                                   E.HireDate, E.BasicSalary, E.Subsidy, E.Ratio, 
                                   E.Position, E.DeptId, D.Name AS DeptName, S.Name AS SpecName, E.SpecId
                                   FROM EMPLOYEES AS E LEFT OUTER JOIN
                                   SPECIALITIES AS S ON E.SpecId = S.Id LEFT OUTER JOIN
                                   DEPARTMENTS AS D ON E.DeptId = D.Id
                                   WHERE E.Id = {0}", id)

                Return GetDataTable(query)

            Catch ex As Exception
                My.Forms.frmMain.txtStatus.Text = "Không thể lấy dữ liệu nhân viên"
                Return Nothing
            End Try

        End Function

        Friend Function GetEmployeesByDeptId(DeptId As Integer) As DataTable
            Try

                Dim query As String =
                    String.Format("SELECT E.Id, E.Name, E.Sex, E.DoB, E.IdCard, E.Address, E.Phone, E.Folk, 
                                   E.HireDate, E.BasicSalary, E.Subsidy, E.Ratio, 
                                   E.Position, E.DeptId, D.Name AS DeptName, S.Name AS SpecName, E.SpecId
                                   FROM EMPLOYEES AS E LEFT OUTER JOIN
                                   SPECIALITIES AS S ON E.SpecId = S.Id LEFT OUTER JOIN
                                   DEPARTMENTS AS D ON E.DeptId = D.Id
                                   WHERE D.Id = {0}", DeptId)

                Return GetDataTable(query)

            Catch ex As Exception
                My.Forms.frmMain.txtStatus.Text = "Không thể lấy dữ liệu nhân viên"
                Return Nothing
            End Try
        End Function

        Friend Function DeleteEmployee(employeeId As Integer) As Boolean
            Try
                Dim query As String =
                    String.Format("DELETE FROM EMPLOYEES WHERE Id = {0}",
                                  employeeId)

                My.Forms.frmMain.txtStatus.Text = "Xóa nhân viên thành công"
                Return ExecuteNoneQuery(query)

            Catch ex As Exception
                My.Forms.frmMain.txtStatus.Text = "Không thể xóa nhân viên"
                Return False
            End Try

        End Function

        Friend Function AddEmployee(Empl As Employee) As Boolean
            Try
                Dim emplDeptId As String = "NULL"
                If Empl.Department.Id > 0 Then
                    emplDeptId = Empl.Department.Id.ToString
                End If
                Dim emplSpecId As String = "NULL"
                If Empl.Speciality.Id > 0 Then
                    emplSpecId = Empl.Speciality.Id.ToString
                End If
                Dim query As String =
                    String.Format(
                        "INSERT INTO 
                        EMPLOYEES(Name, Sex, DoB, IdCard, Address, Phone,
                        Folk, HireDate, Ratio, BasicSalary, Subsidy, Position, DeptId, SpecId)
                        VALUES(N'{0}', '{1}', '{2}', '{3}', N'{4}', '{5}',
                        N'{6}', '{7}', {8}, {9}, {10}, N'{11}', {12}, {13})",
                        Empl.Name, Empl.Sex.ToString, Empl.DoB.ToString, Empl.IdCard, Empl.Address, Empl.Phone,
                        Empl.Folk, Empl.HireDate.ToString, Empl.Ratio, Empl.BasicSalary, Empl.Subsidy,
                        Empl.Position, emplDeptId, emplSpecId)


                My.Forms.frmMain.txtStatus.Text = "Thêm nhân viên thành công"
                Return ExecuteNoneQuery(query)

            Catch ex As Exception

                My.Forms.frmMain.txtStatus.Text = "Không thể thêm nhân viên"
                Return False

            End Try
        End Function

        Friend Function InpatientAdmission(employeeId As Integer, patientId As Integer, BedId As Integer, patientType As String) As Boolean
            Dim query As String =
                String.Format("INSERT INTO ADMISSIONS(EmployeeId, PatientId, AdmissionTime, BedId)
                               VALUES({0}, {1}, '{2}', {3})",
                              employeeId, patientId, Date.Now, BedId)
            Dim query2 As String =
                String.Format("UPDATE PATIENTS
                               SET Type = N'{0}'
                               WHERE Id = {1}", patientType, patientId)

            Return ExecuteNoneQuery(query) AndAlso ExecuteNoneQuery(query2)
        End Function

        Friend Function OutpatientAdmission(EmployeeId As Integer, PatientId As Integer) As Boolean
            Dim query As String =
                String.Format("INSERT INTO ADMISSIONS(EmployeeId, PatientId, AdmissionTime)
                               VALUES({0}, {1}, '{2}')",
                              EmployeeId, PatientId, Date.Now)
            Dim query2 As String =
                String.Format("UPDATE PATIENTS
                               SET Type = N'Ngoại trú'
                               WHERE Id = {0}", PatientId)
            Return ExecuteNoneQuery(query) AndAlso ExecuteNoneQuery(query2)
        End Function

        Friend Function GetEmployeeById(id As Integer) As Employee
            Dim empl As New Employee

            Try
                Dim query As String =
                    String.Format("SELECT * FROM EMPLOYEES WHERE Id = {0}", id)

                Dim dtEmpl As DataTable = GetDataTable(query)

                With dtEmpl.Rows(0)
                    empl.Id = CInt(.Item("Id"))
                    empl.Name = CType(.Item("Name"), String)
                    empl.Sex = CBool(.Item("Sex"))
                    empl.DoB = CDate(.Item("DoB"))
                    empl.IdCard = CType(.Item("IdCard"), String)
                    empl.Address = CType(.Item("Address"), String)
                    If .Item("Phone").Equals(DBNull.Value) Then
                        empl.Phone = ""
                    Else
                        empl.Phone = CType(.Item("Phone"), String)
                    End If
                    If .Item("Folk").Equals(DBNull.Value) Then
                        empl.Folk = ""
                    Else
                        empl.Folk = CType(.Item("Folk"), String)
                    End If
                    empl.HireDate = CDate(.Item("HireDate"))
                    If .Item("Ratio").Equals(DBNull.Value) Then
                        empl.Ratio = 0
                    Else
                        empl.Ratio = CDbl(.Item("Ratio"))
                    End If
                    empl.BasicSalary = CInt(.Item("BasicSalary"))
                    empl.Subsidy = CInt(.Item("Subsidy"))
                    If .Item("Position").Equals(DBNull.Value) Then
                        empl.Position = ""
                    Else
                        empl.Position = CType(.Item("Position"), String)
                    End If

                    If .Item("DeptId").Equals(DBNull.Value) Then
                        empl.Department = New Department()
                    Else
                        empl.Department = New Department(CInt(.Item("DeptId")))
                    End If
                    If .Item("SpecId").Equals(DBNull.Value) Then
                        empl.Speciality = New Speciality
                    Else
                        empl.Speciality = New Speciality(CInt(.Item("SpecId")))
                    End If

                End With

            Catch ex As Exception

            End Try

            Return empl
        End Function

        Friend Function UpdateEmployee(Empl As Employee) As Boolean
            Try
                Dim query As String =
                    String.Format(
                        "UPDATE EMPLOYEES
                        SET Name = N'{0}', Sex = '{1}', DoB = '{2}', IdCard = '{3}', Address = N'{4}', Phone = '{5}',
                        Folk = N'{6}', HireDate = '{7}', Ratio = {8}, BasicSalary = {9}, Subsidy = {10}, 
                        Position = N'{11}', DeptId = {12}, SpecId = {13}
                        WHERE Id = {14}",
                        Empl.Name, Empl.Sex.ToString, Empl.DoB.ToString, Empl.IdCard, Empl.Address, Empl.Phone,
                        Empl.Folk, Empl.HireDate.ToString, Empl.Ratio, Empl.BasicSalary, Empl.Subsidy,
                        Empl.Position, Empl.Department.Id, Empl.Speciality.Id,
                        Empl.Id)

                My.Forms.frmMain.txtStatus.Text = "Sửa nhân viên thành công"
                Return ExecuteNoneQuery(query)

            Catch ex As Exception
                My.Forms.frmMain.txtStatus.Text = "Không thể sửa nhân viên"
                Return False
            End Try
        End Function
#End Region

    End Class
End Namespace
