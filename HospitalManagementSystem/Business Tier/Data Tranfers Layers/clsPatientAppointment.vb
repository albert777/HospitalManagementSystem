Namespace DTO
    Public Class PatientAppointment
        Private _id As Integer
        Private _patient As Patient
        Private _employee As Employee
        Private _doctor As Employee 'Doctor
        Private _clinic As Clinic
        Private _lines As List(Of PatientAppointmentLine)
        Private _numberorder As Integer
        Private _createTime As Date
        Private _result As String
        Private _prescribe As String

        Public Sub New()
            Me.Id = 0
            Me.Patient = Nothing
            Me.Employee = Nothing
            Me.Doctor = Nothing
            Me.Clinic = Nothing
            Me.Lines = Nothing
            Me.Numberorder = 0
            Me.CreateTime = Date.MinValue
            Me.Result = String.Empty
            Me.Prescribe = String.Empty
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

        Public Property Doctor As Employee
            Get
                Return _doctor
            End Get
            Set(value As Employee)
                _doctor = value
            End Set
        End Property

        Public Property Clinic As Clinic
            Get
                Return _clinic
            End Get
            Set(value As Clinic)
                _clinic = value
            End Set
        End Property

        Public Property Numberorder As Integer
            Get
                Return _numberorder
            End Get
            Set(value As Integer)
                _numberorder = value
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

        Public Property Patient As Patient
            Get
                Return _patient
            End Get
            Set(value As Patient)
                _patient = value
            End Set
        End Property

        Public Property Lines As List(Of PatientAppointmentLine)
            Get
                Return _lines
            End Get
            Set(value As List(Of PatientAppointmentLine))
                _lines = value
            End Set
        End Property
    End Class
End Namespace
