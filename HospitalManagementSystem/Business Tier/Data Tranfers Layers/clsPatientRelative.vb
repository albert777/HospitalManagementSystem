Namespace DTO
    Public Class PatientRelative
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

        Private _id As Integer              'Mã số người nhà bệnh nhân
        Private _relationship As String     'Mối quan hệ với bệnh nhân
#End Region

#Region "Constructor"
        Public Sub New()
            MyBase.New()
            Me.Id = 0
            Me.Relationship = String.Empty
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

        Public Property Relationship As String
            Get
                Return _relationship
            End Get
            Set(value As String)
                _relationship = value
            End Set
        End Property
#End Region

    End Class
End Namespace
