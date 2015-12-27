Imports HospitalManagementSystem.BUS
Imports HospitalManagementSystem.DTO
Imports HospitalManagementSystem.GlobalClass.GlobalFunction

Public Class frmRecordsSystem
    Dim _employeeData As New DTO.Employee()
    Dim _employeeBus As New BUS.BusiEmployee()

    Dim _selectedRow As Integer

    '#Region "Form Moving"
    '    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    '    Private Declare Function ReleaseCapture Lib "user32" () As Long

    '    Private Sub BorderlessWindowDrag(ByVal sender As Object, ByVal e As MouseEventArgs)
    '        ReleaseCapture()
    '        SendMessage(Me.Handle, &HA1, 2, 0&)
    '    End Sub

    '    Private Sub frmAddCustomer_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
    '        BorderlessWindowDrag(sender, e)
    '    End Sub

    '    Private Sub lblTitle_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
    '        BorderlessWindowDrag(sender, e)
    '    End Sub
    '#End Region

#Region "Windows Events"

    Private Sub frmRecordsSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch_Empl_ID.Focus()

        cmdDeleteCus.Enabled = False
        cmdUpdateEmpl.Enabled = False
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdReSearch_Click(sender As Object, e As EventArgs) Handles cmdReSearch.Click
        txtSearch_Empl_ID.Clear()
        txtSearch_Empl_IDCard.Clear()
        txtSearch_Empl_Name.Clear()
        txtSearch_Empl_Phone.Clear()
        txtSearch_Empl_ID.Focus()

    End Sub

    Private Sub dgrEmplResult_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrEmplResult.CellClick
        If e.RowIndex >= 0 Then
            Try
                With dgrEmplResult.Rows(e.RowIndex)
                    txtEmployeeId.Text = .Cells(0).FormattedValue.ToString()
                    txtEmployeePosition.Text = .Cells(1).FormattedValue.ToString()
                    txtEmployeeName.Text = .Cells(2).FormattedValue.ToString()
                    txtEmployeeSex.Text = .Cells(3).FormattedValue.ToString()
                    txtEmployeeIdCard.Text = .Cells(4).FormattedValue.ToString()

                    'dtpEmployeeDoB.Value = GlobalClass.GlobalFunction.DateTimeConverter(.Cells(5).FormattedValue.ToString(), "mdy")

                    txtEmployeeAddress.Text = .Cells(6).FormattedValue.ToString()
                    txtEmployeePhone.Text = .Cells(7).FormattedValue.ToString()
                    txtEmployeeFolk.Text = .Cells(8).FormattedValue.ToString()
                    txtEmployeeDepartment.Text = .Cells(9).FormattedValue.ToString()
                    txtEmployeeSpecialized.Text = .Cells(10).FormattedValue.ToString()
                End With

            Catch ex As Exception
                Throw ex
            End Try

            _selectedRow = e.RowIndex
            cmdDeleteCus.Enabled = True
            cmdUpdateEmpl.Enabled = True
        End If
    End Sub

    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click

    End Sub

    Private Sub cmdUpdateEmpl_Click(sender As Object, e As EventArgs) Handles cmdUpdateEmpl.Click
        AddDataToList(GetEmployeeData())
    End Sub
#End Region

#Region "Process"

    Private Sub AddDataToList(ByVal empl As Employee)
        Try
            With dgrEmplResult.Rows(_selectedRow)
                .Cells(0).Value = empl.Ratio
                .Cells(1).Value = empl.Position
                .Cells(2).Value = empl.Name

                If empl.Sex = True Then
                    .Cells(3).Value = "Nam"
                Else
                    .Cells(3).Value = "Nữ"
                End If

                .Cells(4).Value = empl.IdCard
                .Cells(5).Value = empl.DoB
                .Cells(6).Value = empl.Address
                .Cells(7).Value = empl.Phone
                .Cells(8).Value = empl.Folk

                .Cells(9).Value = empl.Specialized.Department.Name
                .Cells(10).Value = empl.Specialized.Name

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Function GetEmployeeData() As Employee
        Dim empl As New Employee()

        Try
            empl.Id = 5 'Integer.Parse(txtEmployeeId.Text.Trim())
            empl.Position = txtEmployeePosition.Text.Trim()
            empl.Name = txtEmployeeName.Text.Trim()

            If (txtEmployeeSex.Text.Trim().ToUpper() = "NAM") Then
                empl.Sex = True
            Else
                empl.Sex = False
            End If

            empl.IdCard = txtEmployeeIdCard.Text.Trim()
            empl.DoB = dtpEmployeeDoB.Value
            empl.Address = txtEmployeeAddress.Text.Trim()
            empl.Phone = txtEmployeePhone.Text.Trim()
            empl.Folk = txtEmployeeFolk.Text.Trim()
            empl.Specialized = New Specialized
            empl.Specialized.Department = New Department
            empl.Specialized.Department.Name = txtEmployeeSpecialized.Text.Trim()
            empl.Specialized.Name = txtEmployeeDepartment.Text.Trim()

        Catch ex As Exception

        End Try

        Return empl
    End Function

#End Region

End Class