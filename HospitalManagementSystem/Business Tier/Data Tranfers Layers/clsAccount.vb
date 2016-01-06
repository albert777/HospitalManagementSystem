Namespace DTO
    Public Class Account

#Region "Attributes"
        Private _employee As Employee        'Mã số tài khoản
        Private _username As String   'Tên tài khoản
        Private _password As String   'Mật khẩu
#End Region

#Region "Constructor"
        Public Sub New()
            Employee = Nothing
            Username = ""
            Password = ""
        End Sub

        ''' <summary>
        '''     Khởi tạo Account Object
        ''' </summary>
        ''' <param name="Username">Tên tài khoản</param>
        ''' <param name="Password">Mật khẩu</param>
        Public Sub New(Username As String, Password As String)
            Employee = Nothing
            Me.Username = Username
            Me.Password = Password
        End Sub

        Public Sub New(Account As Account)
            Me.Employee = Account.Employee
            Me.Username = Account.Username
            Me.Password = Account.Password
        End Sub


#End Region

#Region "Property"
        Public Property Employee As Employee
            Get
                Return _employee
            End Get
            Set(value As Employee)
                _employee = value
            End Set
        End Property

        Protected Property Username As String
            Get
                Return _username
            End Get
            Set(value As String)
                _username = value
            End Set
        End Property

        Protected Property Password As String
            Get
                Return _password
            End Get
            Set(value As String)
                _password = value
            End Set
        End Property

#End Region

    End Class
End Namespace
