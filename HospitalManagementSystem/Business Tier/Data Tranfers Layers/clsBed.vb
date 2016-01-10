Namespace DTO
    Public Class Bed

#Region "Attributes"
        Private _id As Integer
        Private _room As Integer
        Private _department As Department
        Private v As Integer
#End Region

#Region "Constructor"
        Public Sub New()
            Id = 0
            Room = 0
            Department = Nothing
        End Sub

        Public Sub New(id As Integer)
            Me.Id = id
            Me.Room = 0
            Me.Department = Nothing
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

        Public Property Room As Integer
            Get
                Return _room
            End Get
            Set(value As Integer)
                _room = value
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
#End Region



    End Class
End Namespace

