Namespace DTO
    Public Class PatientAdmission
        Private _id As Integer
        Private _employee As Employee
        Private _admissionTime As Date
        Private _discharge As PatientDischarge

        Public Sub New()
            Id = 0
            Employee = Nothing
            AdmissionTime = Date.MinValue
            Discharge = Nothing
        End Sub

        Public Sub New(AdmissionTime As Date)
            Me.New
            Me.AdmissionTime = AdmissionTime
        End Sub

        Public Sub New(Id As Integer, AdmissionTime As Date)
            Me.New
            Me.Id = Id
            Me.AdmissionTime = AdmissionTime
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

        Public Property AdmissionTime As Date
            Get
                Return _admissionTime
            End Get
            Set(value As Date)
                _admissionTime = value
            End Set
        End Property

        Friend Property Discharge As PatientDischarge
            Get
                Return _discharge
            End Get
            Set(value As PatientDischarge)
                _discharge = value
            End Set
        End Property
    End Class
End Namespace
