Namespace DTO
    Public Class PatientPayment
        Private _id As Integer
        Private _employee As Employee
        Private _createTime As Date
        Private _lines As List(Of PatientPaymentLine)

        Public Sub New()
            Me.Id = 0
            Me.Employee = Nothing
            Me.CreateTime = Date.MinValue
            Me.Lines = Nothing
        End Sub

        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

        Public Property Employee As Employee
            Get
                Return _employee
            End Get
            Set(value As Employee)
                _employee = value
            End Set
        End Property

        Public Property CreateTime As Date
            Get
                Return _createTime
            End Get
            Set(value As Date)
                _createTime = value
            End Set
        End Property

        Public Property Lines As List(Of PatientPaymentLine)
            Get
                Return _lines
            End Get
            Set(value As List(Of PatientPaymentLine))
                _lines = value
            End Set
        End Property
    End Class
End Namespace
