Namespace DTO
    Public Class Employee
        Inherits Person

#Region "Attributes"
        'Person
        'Protected _name As String       'Họ Tên 
        'Protected _sex As Boolean       'Giới tính
        'Protected _dob As Date          'Ngày sinh
        'Protected _idcard As String     'Chứng minh nhân dân
        'Protected _address As String    'Địa chỉ
        'Protected _phone As String      'Số điện thoại
        'Protected _folk As String       'Dân tộc

        Protected _id As Integer                'Mã số nhân viên
        Protected _firstYear As Integer         'Năm đầu tiên công tác
        Protected _ratio As Double              'Bậc lương
        Protected _position As String          'Chức danh, vị trí
        Protected _specialized As Specialized   'Chuyên ngành (Bác sĩ)
#End Region

#Region "Constructor"
        Public Sub New()
            Id = 0
            FirstYear = 0
            Ratio = 0
            Position = String.Empty
            Specialized = Nothing
        End Sub
#End Region

#Region "Property"
        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property FirstYear As Integer
            Get
                Return _firstYear
            End Get
            Set(value As Integer)
                _firstYear = value
            End Set
        End Property

        Public Property Ratio As Double
            Get
                Return _ratio
            End Get
            Set(value As Double)
                _ratio = value
            End Set
        End Property

        Public Property Position As String
            Get
                Return _position
            End Get
            Set(value As String)
                _position = value
            End Set
        End Property

        Public Property Specialized As Specialized
            Get
                Return _specialized
            End Get
            Set(value As Specialized)
                _specialized = value
            End Set
        End Property

#End Region

    End Class
End Namespace
