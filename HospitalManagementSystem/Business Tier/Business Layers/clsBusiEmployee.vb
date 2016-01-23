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

        Friend Function SearchEmployees(id As Integer) As DataTable
            Return _emplData.GetEmployeesDataTable(id)
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

        Friend Function SearchEmployeesByDeptId(DeptId As Integer) As DataTable
            Return _emplData.GetEmployeesByDeptId(DeptId)
        End Function

        Friend Function GetEmployeeByAccountId(id As Integer) As Employee
            Dim empl As New Employee
            Dim dbEmpl As DataTable = _emplData.GetEmployeesDataTable(id)

            If dbEmpl.Rows.Count > 0 Then
                With dbEmpl.Rows(0)
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
                        empl.Department = New Department
                    Else
                        empl.Department = New Department(CInt(.Item("DeptId")))
                    End If
                    If .Item("SpecId").Equals(DBNull.Value) Then
                        empl.Speciality = New Speciality
                    Else
                        empl.Speciality = New Speciality(CInt(.Item("SpecId")))
                    End If

                End With
            End If

            Return empl
        End Function

        Friend Function ExistEmployee(Id As Integer) As Boolean
            Return _emplData.ExistEmployee(Id)
        End Function

        Friend Sub AddEmployee(Employee As Employee)
            If MessageBox.Show("Bạn có muốn thêm nhân viên?", "Thêm nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _emplData.AddEmployee(Employee) Then
                    MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Thêm nhân viên thất bại", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End Sub

        Friend Function GetEmployeeById(id As Integer) As Employee
            Return _emplData.GetEmployeeById(id)
        End Function

        Friend Sub UpdateEmployee(Employee As Employee)
            If MessageBox.Show("Bạn có muốn sửa nhân viên?", "Sửa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _emplData.UpdateEmployee(Employee) Then
                    MessageBox.Show("Sửa nhân viên thành công", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Sửa nhân viên thất bại", "Sửa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Friend Function InpatientAdmission(EmployeeId As Integer, PatientId As Integer, BedId As Integer, patientType As String) As Boolean
            If _emplData.InpatientAdmission(EmployeeId, PatientId, BedId, patientType) Then
                MsgBox("Ghi thông tin nhập viện thành công")
                Return True
            Else
                MsgBox("Ghi thông tin nhập viện thành công")
                Return False
            End If
        End Function

        Friend Function OutpatientAdmission(EmployeeId As Integer, PatientId As Integer) As Boolean
            If _emplData.OutpatientAdmission(EmployeeId, PatientId) Then
                MsgBox("Ghi thông tin nhập viện thành công")
                Return True
            Else
                MsgBox("Ghi thông tin nhập viện thành công")
                Return False
            End If
        End Function
    End Class
End Namespace
