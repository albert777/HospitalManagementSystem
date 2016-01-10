Namespace DTO
    Public Class Clinic
        Private _id As Integer
        Private _name As String
        Private _department As Department

        Public Sub New()
            Id = 0
            Name = String.Empty
            Department = Nothing
        End Sub

        Public Sub New(Id As Integer)
            'Me.New()
            Me.Id = Id
            Name = String.Empty
            Department = Nothing
        End Sub

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

        Public Property Department As Department
            Get
                Return _department
            End Get
            Set(value As Department)
                _department = value
            End Set
        End Property
    End Class
End Namespace
