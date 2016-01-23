Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiAccount
        Private _accData As DataAccount

        Public Sub New()
            _accData = New DataAccount
        End Sub

        Public Class LoginResult
            Private _account As Account
            Private _result As DialogResult

            Public Property Account As Account
                Get
                    Return _account
                End Get
                Set(value As Account)
                    _account = value
                End Set
            End Property

            Public Property Result As DialogResult
                Get
                    Return _result
                End Get
                Set(value As DialogResult)
                    _result = value
                End Set
            End Property

            Public Sub New(Account As Account, Result As DialogResult)
                Me.Account = Account
                Me.Result = Result
            End Sub

        End Class

        Friend Function DeleteAccount(user As String) As Boolean
            If _accData.DeleteAccount(user) Then
                MsgBox("Xóa tài khoản thành công!")
                Return True
            Else
                MsgBox("Xóa tài khoản thất bại!")
                Return False
            End If
        End Function

        Friend Function EmployeeHaveAccount(Eid As Integer) As Boolean
            Return _accData.EmployeeHaveAccount(Eid)
        End Function

        Friend Function ExistUsername(user As String) As Boolean
            Return _accData.ExistUsername(user)
        End Function

        Friend Function GetAccountsInfos() As DataTable
            Return _accData.GetAccountsInfos()
        End Function

        Friend Function ChangePassword(username As String, password As String) As Boolean
            If _accData.ChangePassword(username, password) Then
                MsgBox("Đổi mật khẩu thành công")
                Return True
            Else
                MsgBox("Đổi mật khẩu thất bại")
                Return False
            End If
        End Function

        Friend Function CreateAccount(user As String, pass As String, eid As Integer, role As Integer) As Boolean
            If _accData.CreateAccount(user, pass, eid, role) Then
                MsgBox("Tạo tài khoản thành công!")
                Return True
            Else
                MsgBox("Tạo tài khoản thất bại!")
                Return False
            End If
        End Function

        Public Function GetAccountViaLogin() As LoginResult
            Dim frmLogin As New frmLogin
            frmLogin.ShowDialog()

            Return New LoginResult(frmLogin.Account, frmLogin._loginResult)
        End Function

        Friend Function CheckAccount(Account As Account) As Boolean
            Return _accData.IsCorrect(Account)
        End Function

        Friend Function GetAccount(Username As String, Password As String) As Account
            Return _accData.GetAccount(Username, Password)
        End Function

        Friend Function CheckAccount(Username As String, Password As String) As Boolean
            Dim Account As Account = New Account(Username, Password)
            Return _accData.IsCorrect(Account)
        End Function
    End Class
End Namespace
