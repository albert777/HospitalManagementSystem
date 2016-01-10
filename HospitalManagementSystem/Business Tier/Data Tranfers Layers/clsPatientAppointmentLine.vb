Namespace DTO
    Public Class PatientAppointmentLine
        Private _id As Integer
        Private _detail As String

        Public Sub New()
            Id = 0
            Detail = String.Empty
        End Sub

        Public Sub New(Detail As String)
            Me.New()
            Me.Detail = Detail
        End Sub

        Public Sub New(Id As Integer, Detail As String)
            Me.Id = Id
            Me.Detail = Detail
        End Sub

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Detail As String
            Get
                Return _detail
            End Get
            Set(value As String)
                _detail = value
            End Set
        End Property
    End Class
End Namespace
