Namespace DTO
    Public Class Speciality


#Region "Attributes"
        'Department
        Private _id As Integer    'Mã số chuyên môn
        Private _name As String   'Tên chuyên môn
        'Protected _chief As Doctor  'Bác sĩ trưởng chuyên ngành

        'Private _department As Department   'Khoa trực thuộc
#End Region


#Region "Constructor"
        Public Sub New()
            Id = 0
            Name = String.Empty
        End Sub

        Public Sub New(Name As String)
            Id = 0
            Me.Name = Name
        End Sub

        Public Sub New(Id As Integer, Name As String)
            Me.Id = Id
            Me.Name = Name
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

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        'Public Property Department As Department
        '    Get
        '        Return _department
        '    End Get
        '    Set(value As Department)
        '        _department = value
        '    End Set
        'End Property
#End Region

    End Class
End Namespace
