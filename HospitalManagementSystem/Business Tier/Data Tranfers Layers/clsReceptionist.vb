Namespace DTO
    Public Class Receptionist
        Inherits Employee

#Region "Property"
        Public Shadows Property Specialized As Specialized
            Get
                Return Nothing
            End Get
            Set(value As Specialized)
                'Do nothing
            End Set
        End Property
#End Region

    End Class
End Namespace
