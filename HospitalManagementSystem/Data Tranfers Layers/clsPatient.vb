Namespace DTO
    Public Class Patient
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

        Private _id As Integer           'Mã số bệnh nhân
        Private _type As Boolean         'Loại bệnh nhân: Ngoại trú: False, Nội trú: True
        Private _roomNo As Integer       'Phòng bệnh
        Private _insuranceID As String   'Số bảo hiểm y tế
#End Region

#Region "Constructor"
        Public Sub New()
            MyBase.New()
            Me.Id = 0
            Me.Type = False
            Me.RoomNo = 0
            Me.InsuranceID = String.Empty
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

        Public Property Type As Boolean
            Get
                Return _type
            End Get
            Set(value As Boolean)
                _type = value
            End Set
        End Property

        Public Property RoomNo As Integer
            Get
                Return _roomNo
            End Get
            Set(value As Integer)
                _roomNo = value
            End Set
        End Property

        Public Property InsuranceID As String
            Get
                Return _insuranceID
            End Get
            Set(value As String)
                _insuranceID = value
            End Set
        End Property
#End Region

    End Class
End Namespace
