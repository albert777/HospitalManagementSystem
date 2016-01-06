Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataAccount
        Inherits DataBaseAccess

#Region "Constructor"
        Public Sub New()

        End Sub

#End Region

#Region "Methods"
        Friend Function IsCorrect(Account As Account) As Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
