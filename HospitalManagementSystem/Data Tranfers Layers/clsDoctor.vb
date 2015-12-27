Namespace DTO
    Public Class Doctor
        Inherits Employee

#Region "Attributes"
        'Person
        'Protected _name As String       'Họ Tên 
        'Protected _sex As Boolean       'Giới tính
        'Protected _dob As Date          'Ngày sinh
        'Protected _idcard As String     'Chứng minh nhân dân
        'Protected _address As String    'Địa chỉ
        'Protected _phone As String      'Số điện thoại
        'Protected _folk As String       'Dân tộc

        'Protected _id As Integer                'Mã số bác sĩ
        'Protected _firstYear As Integer         'Năm đầu tiên công tác
        'Protected _ratio As Double              'Bậc lương
        'Protected _position As Integer          'Chức danh, vị trí
        'Protected _specialized As Specialized   'Chuyên ngành

        'Private _specialized As Specialized

#End Region

#Region "Constructor"
        Public Sub New()
            MyBase.New()
            'Specialized = New Specialized()
        End Sub
#End Region

#Region "Property"
        'Public Property Specialized As Specialized
        '    Get
        '        Return _specialized
        '    End Get
        '    Set(value As Specialized)
        '        _specialized = value
        '    End Set
        'End Property
#End Region

    End Class
End Namespace
