Namespace DTO
    Public Class PatientPaymentLine
        Private _id As Integer
        Private _detail As String
        Private _charge As Integer

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

        Public Property Charge As Integer
            Get
                Return _charge
            End Get
            Set(value As Integer)
                _charge = value
            End Set
        End Property
    End Class
End Namespace
