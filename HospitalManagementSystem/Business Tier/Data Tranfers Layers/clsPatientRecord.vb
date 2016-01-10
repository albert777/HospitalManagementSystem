Namespace DTO
    Public Class PatientRecord

#Region "Attributes"
        Private _id As Integer
        Private _createTime As Date
        Private _doctor As Doctor
        Private _lines As List(Of PatientRecordLine)
#End Region

#Region "Constructor"
        Public Sub New()
            Id = 0
            CreateTime = Date.MinValue
            Doctor = Nothing
            Me.Lines = Nothing
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

        Public Property CreateTime As Date
            Get
                Return _createTime
            End Get
            Set(value As Date)
                _createTime = value
            End Set
        End Property

        Public Property Doctor As Doctor
            Get
                Return _doctor
            End Get
            Set(value As Doctor)
                _doctor = value
            End Set
        End Property

        Public Property Lines As List(Of PatientRecordLine)
            Get
                Return _lines
            End Get
            Set(value As List(Of PatientRecordLine))
                _lines = value
            End Set
        End Property
#End Region

    End Class
End Namespace
