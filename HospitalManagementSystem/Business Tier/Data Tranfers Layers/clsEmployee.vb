Namespace DTO
    Public Class Employee
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

        Protected _id As Integer                'Mã số nhân viên
        Protected _hireDate As Date         'Ngày thuê
        Protected _ratio As Double              'Bậc lương
        Protected _basicSalary As Integer
        Protected _subsidy As Integer
        Protected _position As String          'Chức danh, vị trí
        Protected _department As Department     'Bộ phận, Khoa
        Protected _speciality As Speciality     'Chuyên môn

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

        Public Property HireDate As Date
            Get
                Return _hireDate
            End Get
            Set(value As Date)
                _hireDate = value
            End Set
        End Property

        Public Property Ratio As Double
            Get
                Return _ratio
            End Get
            Set(value As Double)
                _ratio = value
            End Set
        End Property

        Public Property BasicSalary As Integer
            Get
                Return _basicSalary
            End Get
            Set(value As Integer)
                _basicSalary = value
            End Set
        End Property

        Public Property Subsidy As Integer
            Get
                Return _subsidy
            End Get
            Set(value As Integer)
                _subsidy = value
            End Set
        End Property

        Public ReadOnly Property TotalSalary As Integer
            Get
                Return CInt(BasicSalary * Ratio + Subsidy)
            End Get
        End Property

        Public Property Position As String
            Get
                Return _position
            End Get
            Set(value As String)
                _position = value
            End Set
        End Property

        Public Property Speciality As Speciality
            Get
                Return _speciality
            End Get
            Set(value As Speciality)
                _speciality = value
            End Set
        End Property

        Public Property Department As Department
            Get
                Return _department
            End Get
            Set(value As Department)
                _department = value
            End Set
        End Property

#End Region

#Region "Constructor"
        Public Sub New()
            MyBase.New()
            Id = 0
            HireDate = Nothing
            Ratio = 0
            BasicSalary = 0
            Subsidy = 0
            Position = String.Empty
            Speciality = Nothing
            Department = Nothing

        End Sub

        Public Sub New(Id As Integer)
            Me.New()
            Me.Id = Id
        End Sub

        Public Sub New(Employee As Employee)
            Name = Employee.Name
            Sex = Employee.Sex
            DoB = Employee.DoB
            IdCard = Employee.IdCard
            Address = Employee.Address
            Phone = Employee.Phone
            Folk = Employee.Folk

            Me.Id = Employee.Id
            Me.HireDate = Employee.HireDate
            Me.Ratio = Employee.Ratio
            Me.BasicSalary = Employee.BasicSalary
            Me.Subsidy = Employee.Subsidy
            Me.Position = Employee.Position
            Me.Speciality = Employee.Speciality
            Me.Department = Employee.Department
        End Sub
#End Region

    End Class
End Namespace
