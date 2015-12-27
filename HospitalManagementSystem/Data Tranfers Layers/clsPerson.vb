Namespace DTO
    Public MustInherit Class Person

#Region "Attributes"
        Protected _name As String       'Họ Tên 
        Protected _sex As Boolean       'Giới tính
        Protected _dob As DateTime      'Ngày sinh
        Protected _idcard As String     'Chứng minh nhân dân
        Protected _address As String    'Địa chỉ
        Protected _phone As String      'Số điện thoại
        Protected _folk As String       'Dân tộc
#End Region

#Region "Constructor"
        Public Sub New()
            Name = String.Empty
            Sex = False
            DoB = DateTime.Now
            IdCard = String.Empty
            Address = String.Empty
            Phone = String.Empty
            Folk = String.Empty

        End Sub
#End Region

#Region "Property"
        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Property Sex As Boolean
            Get
                Return _sex
            End Get
            Set(value As Boolean)
                _sex = value
            End Set
        End Property

        Public Property DoB As Date
            Get
                Return _dob
            End Get
            Set(value As Date)
                _dob = value
            End Set
        End Property

        Public Property IdCard As String
            Get
                Return _idcard
            End Get
            Set(value As String)
                _idcard = value
            End Set
        End Property

        Public Property Address As String
            Get
                Return _address
            End Get
            Set(value As String)
                _address = value
            End Set
        End Property

        Public Property Phone As String
            Get
                Return _phone
            End Get
            Set(value As String)
                _phone = value
            End Set
        End Property

        Public Property Folk As String
            Get
                Return _folk
            End Get
            Set(value As String)
                _folk = value
            End Set
        End Property
#End Region

    End Class
End Namespace
