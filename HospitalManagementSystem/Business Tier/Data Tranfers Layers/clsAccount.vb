﻿
Namespace DTO
    Public Class Account

#Region "Attributes"
        Private _employee As Employee        'Mã số tài khoản
        Private _username As String   'Tên tài khoản
        Private _password As String   'Mật khẩu
        Private _role As AccountRole

        Public Enum AccountRole
            Doctor
            RecordsSystem
            Receptiontist
        End Enum
#End Region

#Region "Constructor"
        Public Sub New()
            Employee = Nothing
            Username = ""
            Password = ""
            Me.Role = Nothing
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
            Me.Role = Nothing
        End Sub

        Public Sub New(Account As Account)
            Employee = Account.Employee
            Username = Account.Username
            Password = Account.Password
            Me.Role = Account.Role
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

        Public Property Role As AccountRole
            Get
                Return _role
            End Get
            Set(value As AccountRole)
                _role = value
            End Set
        End Property

#End Region

    End Class
End Namespace

