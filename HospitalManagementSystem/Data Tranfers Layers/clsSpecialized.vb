Namespace DTO
    Public Class Specialized
        Inherits Department

#Region "Attributes"
        'Department
        'Protected _id As Integer    'Mã số chuyên ngành
        'Protected _name As String   'Tên chuyên ngành
        'Protected _chief As Doctor  'Bác sĩ trưởng chuyên ngành

        Private _department As Department   'Khoa trực thuộc
#End Region


#Region "Constructor"
        Public Sub New()
            MyBase.New()
            Department = Nothing
        End Sub
#End Region

#Region "Property"
        Public Property Department As Department
            Get
                Return _department
            End Get
            Set(value As Department)
                _department = value
            End Set
        End Property
#End Region

    End Class
End Namespace
