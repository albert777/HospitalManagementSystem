Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataAccount
        Private _dbAccess As DataBaseAccess

#Region "Constructor"
        Public Sub New()
            _dbAccess = New DataBaseAccess
        End Sub

#End Region

#Region "Methods"
        Friend Function IsCorrect(Account As Account) As Boolean
            Dim query As String =
                String.Format("SELECT COUNT(*) FROM dbo.ACCOUNTS WHERE Username = '{0}' AND Password = '{1}'",
                              Account.Username, Account.Password)
            Return CBool(_dbAccess.GetScalar(query))
        End Function

        Friend Function GetAccount(username As String, password As String) As Account
            Dim account As New Account

            Dim query As String =
                String.Format("SELECT * FROM dbo.ACCOUNTS WHERE Username = '{0}' AND Password = '{1}'",
                              username, password)
            Dim dtAccount As DataTable = _dbAccess.GetDataTable(query)
            If dtAccount.Rows.Count > 0 Then
                account.Id = CInt(dtAccount.Rows(0).Item("Id"))
                account.Username = CType(dtAccount.Rows(0).Item("Username"), String)
                account.Password = CType(dtAccount.Rows(0).Item("Password"), String)
                account.Role = CType(dtAccount.Rows(0).Item("Role"), Account.AccountRole)
                account.Employee = New Employee(CInt(dtAccount.Rows(0).Item("EmployeeId")))

            End If

            Return account
        End Function

        Friend Function DeleteAccount(user As String) As Boolean
            Dim query As String =
                String.Format("DELETE FROM ACCOUNTS WHERE Username = '{0}'", user)
            Return _dbAccess.ExecuteNoneQuery(query)
        End Function

        Friend Function ExistUsername(user As String) As Boolean
            Dim query As String =
                String.Format("SELECT COUNT(id) FROM ACCOUNTS WHERE Username = '{0}'", user)
            Return CBool(_dbAccess.GetScalar(query))
        End Function

        Friend Function EmployeeHaveAccount(eid As Integer) As Boolean
            Dim query As String =
                String.Format("SELECT COUNT(id) FROM ACCOUNTS WHERE EmployeeId = {0}", eid)

            Return CBool(_dbAccess.GetScalar(query))
            'If _dbAccess.GetScalar(query) = DBNull.Value Then
            '    Return False
            'Else
            '    Return True
            'End If
        End Function

        Friend Function CreateAccount(user As String, pass As String, eid As Integer, role As Integer) As Boolean
            Dim query As String =
                String.Format("INSERT INTO ACCOUNTS (Username, Password, EmployeeId, Role) VALUES ('{0}', '{1}', {2}, {3})", user, pass, eid, role)

            Return _dbAccess.ExecuteNoneQuery(query)
        End Function

        Friend Function GetAccountsInfos() As DataTable
            Try
                Dim query As String = "SELECT A.Username, IIF(A.Role = 0, 'Records System', IIF(A.Role = 1, 'Doctor', IIF(A.Role = 2, 'Receptionist', null))) As Role, E.Id, E.Name, E.Sex, E.DoB, E.IdCard, E.Address, E.Phone, E.Folk, 
										   E.HireDate, E.BasicSalary, E.Subsidy, E.Ratio, 
										   E.Position, E.DeptId, D.Name AS DeptName, S.Name AS SpecName, E.SpecId
										   FROM EMPLOYEES AS E LEFT OUTER JOIN
										   SPECIALITIES AS S ON E.SpecId = S.Id LEFT OUTER JOIN
										   DEPARTMENTS AS D ON E.DeptId = D.Id LEFT OUTER JOIN
										   ACCOUNTS AS A ON E.Id = A.EmployeeId"

                Return _dbAccess.GetDataTable(query)

            Catch ex As Exception
                'My.Forms.frmMain.txtStatus.Text = "Không thể lấy dữ liệu nhân viên"
                Return Nothing
            End Try
        End Function

        Friend Function ChangePassword(username As String, password As String) As Boolean
            Dim query As String =
                String.Format("UPDATE dbo.ACCOUNTS SET Password = '{0}' WHERE Username = '{1}'", password, username)
            Return _dbAccess.ExecuteNoneQuery(query)
        End Function
#End Region

    End Class
End Namespace
