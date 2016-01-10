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
                String.Format("SELECT COUNT(*) FROM ACCOUNTS WHERE Username = '{0}' AND Password = '{1}'",
                              Account.Username, Account.Password)
            Return CBool(_dbAccess.GetScalar(query))
        End Function

        Friend Function GetAccount(username As String, password As String) As Account
            Dim account As New Account

            Dim query As String =
                String.Format("SELECT * FROM ACCOUNTS WHERE Username = '{0}' AND Password = '{1}'",
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
#End Region

    End Class
End Namespace
