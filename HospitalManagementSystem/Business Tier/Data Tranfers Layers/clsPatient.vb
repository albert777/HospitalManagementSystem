Namespace DTO
    Public Class Patient
        Inherits Person

#Region "Attributes"
        'Person
        'Protected _name As String       'Họ Tên 
        'Protected _sex As Boolean       'Giới tính
        'Protected _dob As Date          'Ngày sinh
        'Protected _idcard As String     'Chứng minh nhân dân
        'Protected _address As String    'Địa chỉ
        'Protected _phone As String      'Số điện thoại
        'Protected _folk As String       'Dân tộc

        Private _id As Integer           'Mã số bệnh nhân
        Private _type As String         'Loại bệnh nhân: Ngoại trú: False, Nội trú: True
        Private _status As String
        Private _insuranceId As String   'Số bảo hiểm y tế
        Private _insuranceIssueDate As Date
        Private _insuranceExpiryDate As Date
        Private _bed As Bed
        Private _relatives As List(Of PatientRelative)
        Private _records As List(Of PatientRecord)
        Private _appointments As List(Of PatientAppointment)
        Private _admission As PatientAdmission
#End Region

#Region "Constructor"
        Public Sub New()
            MyBase.New()
            Me.Id = 0
            Me.Type = String.Empty
            Me.Status = String.Empty
            Me.InsuranceID = String.Empty
            Me.InsuranceIssueDate = Date.MinValue
            Me.InsuranceExpiryDate = Date.MinValue
            Me.Bed = Nothing
            Me.Relatives = Nothing
            Me.Records = Nothing
            Me.Appointments = Nothing
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

        Public Property Type As String
            Get
                Return _type
            End Get
            Set(value As String)
                _type = value
            End Set
        End Property

        Public Property InsuranceID As String
            Get
                Return _insuranceID
            End Get
            Set(value As String)
                _insuranceID = value
            End Set
        End Property

        Public Property Bed As Bed
            Get
                Return _bed
            End Get
            Set(value As Bed)
                _bed = value
            End Set
        End Property

        Public Property Relatives As List(Of PatientRelative)
            Get
                Return _relatives
            End Get
            Set(value As List(Of PatientRelative))
                _relatives = value
            End Set
        End Property

        Public Property Records As List(Of PatientRecord)
            Get
                Return _records
            End Get
            Set(value As List(Of PatientRecord))
                _records = value
            End Set
        End Property

        Public Property Appointments As List(Of PatientAppointment)
            Get
                Return _appointments
            End Get
            Set(value As List(Of PatientAppointment))
                _appointments = value
            End Set
        End Property

        Public Property InsuranceIssueDate As Date
            Get
                Return _insuranceIssueDate
            End Get
            Set(value As Date)
                _insuranceIssueDate = value
            End Set
        End Property

        Public Property InsuranceExpiryDate As Date
            Get
                Return _insuranceExpiryDate
            End Get
            Set(value As Date)
                _insuranceExpiryDate = value
            End Set
        End Property

        Public Property Status As String
            Get
                Return _status
            End Get
            Set(value As String)
                _status = value
            End Set
        End Property

        Public Property Admission As PatientAdmission
            Get
                Return _admission
            End Get
            Set(value As PatientAdmission)
                _admission = value
            End Set
        End Property
#End Region

    End Class
End Namespace
