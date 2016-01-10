Namespace DTO
    Public Class PatientRecordLine
#Region "Attributes"
        Private _id As Integer
        Private _detail As String
#End Region

#Region "Constructor"
        Public Sub New()
            Id = 0
            Detail = String.Empty
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

        Public Property Detail As String
            Get
                Return _detail
            End Get
            Set(value As String)
                _detail = value
            End Set
        End Property
#End Region

    End Class
End Namespace
