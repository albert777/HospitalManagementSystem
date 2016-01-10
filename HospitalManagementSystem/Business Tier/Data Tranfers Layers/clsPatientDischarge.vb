Namespace DTO
    Friend Class PatientDischarge
        Private _id As Integer
        Private _employee As Employee
        Private _dischargeTime As Date
        Private _treatment As String
        Private _result As String
        Private _prescribe As String

        Public Sub New()
            Id = 0
            Employee = Nothing
            DischargeTime = Date.MinValue
            Treatment = String.Empty
            Result = String.Empty
            Prescribe = String.Empty
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

        Public Property DischargeTime As Date
            Get
                Return _dischargeTime
            End Get
            Set(value As Date)
                _dischargeTime = value
            End Set
        End Property

        Public Property Treatment As String
            Get
                Return _treatment
            End Get
            Set(value As String)
                _treatment = value
            End Set
        End Property

        Public Property Result As String
            Get
                Return _result
            End Get
            Set(value As String)
                _result = value
            End Set
        End Property

        Public Property Prescribe As String
            Get
                Return _prescribe
            End Get
            Set(value As String)
                _prescribe = value
            End Set
        End Property
    End Class
End Namespace
