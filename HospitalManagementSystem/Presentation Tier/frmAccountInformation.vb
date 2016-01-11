Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO

Public Class frmAccountInformation
    Private _account As Account

    Public Sub New(ByVal account As Account)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _account = account
        txtAccountUsername.Text = _account.Username
        txtAccountPassword.Text = _account.Password
        txtAccountRoleName.Text = _account.Role.ToString

        txtEmployeeId.Text = _account.Employee.Id.ToString
        txtEmployeeName.Text = _account.Employee.Name
        txtEmployeePhone.Text = _account.Employee.Phone
        txtEmployeeIdCard.Text = _account.Employee.IdCard
        txtEmployeeAddress.Text = _account.Employee.Address
        txtEmployeeFolk.Text = _account.Employee.Folk
        txtEmployeeDoB.Text = _account.Employee.DoB.ToShortDateString

        rbtnSexMale.Checked = _account.Employee.Sex
        rbtnSexFemale.Checked = Not (_account.Employee.Sex)

        txtEmployeeHireDate.Text = _account.Employee.HireDate.ToShortDateString
        txtEmployeeDepartment.Text = _account.Employee.Department.Name
        txtEmployeeSpectity.Text = _account.Employee.Speciality.Name
        txtEmployeeRatio.Text = _account.Employee.Ratio.ToString
        txtEmployeeSubsidy.Text = _account.Employee.Subsidy.ToString
        txtEmployeeBasicSalary.Text = _account.Employee.BasicSalary.ToString
        txtEmployeePosition.Text = _account.Employee.Position

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim frmChangePassword As New frmAccountChangePassword(_account)
        frmChangePassword.ShowDialog()
        _account = frmChangePassword.Account
        txtAccountPassword.Text = _account.Password
    End Sub
End Class