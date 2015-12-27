Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiAccount
        Private _accData As DataAccount

        Public Function GetViaLogin() As Account
            Dim frmLogin As New frmLogin
            frmLogin.ShowDialog()
            Return frmLogin.Account
        End Function
    End Class
End Namespace
