Public Class XfrmAddAccount
    Private _accBus As BUS.BusiAccount
    Private _emplBus As BUS.BusiEmployee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _accBus = New BUS.BusiAccount
        _emplBus = New BUS.BusiEmployee

        LoadPermissionComboBox()
    End Sub

    Private Sub LoadPermissionComboBox()
        Dim TypeDataTable As New DataTable
        TypeDataTable.Columns.Add("Id")
        TypeDataTable.Columns.Add("Name")
        TypeDataTable.Rows.Add(0, "Records System")
        TypeDataTable.Rows.Add(1, "Doctor")
        TypeDataTable.Rows.Add(2, "Receptionist")
        cboxPermission.DataSource = TypeDataTable
        cboxPermission.SelectedValue = 0
    End Sub

    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged, txtUsername.TextChanged, txtPassword.TextChanged
        OK_Button.Enabled = False

        If txtEmployeeId.Text.Trim = "" OrElse txtUsername.Text.Trim = "" OrElse txtPassword.Text.Trim = "" Then
            ErrorProvider1.SetError(txtEmployeeId, "Bạn cần nhập đủ thông tin!")
        Else
            If _accBus.ExistUsername(txtUsername.Text.Trim) Then
                ErrorProvider1.SetError(txtUsername, "Đã tồn tại tên tài khoản này!")
            Else
                If Not (_emplBus.ExistEmployee(CInt(txtEmployeeId.Text.Trim))) Then
                    ErrorProvider1.SetError(txtEmployeeId, "Không tồn tại nhân viên với mã đã nhập!")
                Else
                    If _accBus.EmployeeHaveAccount(CInt(txtEmployeeId.Text.Trim)) Then
                        ErrorProvider1.SetError(txtEmployeeId, "Nhân viên đã có tài khoản!")
                    Else
                        ErrorProvider1.SetError(txtEmployeeId, "")
                        ErrorProvider1.SetError(txtUsername, "")
                        OK_Button.Enabled = True
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If _accBus.CreateAccount(txtUsername.Text.Trim, txtPassword.Text.Trim, CInt(txtEmployeeId.Text.Trim), CInt(cboxPermission.SelectedValue)) Then
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

End Class