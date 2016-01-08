﻿Imports HospitalManagementSystem.DAO
Imports HospitalManagementSystem.DTO

Namespace BUS
    Public Class BusiAccount
        Private _accData As DataAccount

        Public Sub New()
            _accData = New DataAccount
        End Sub

        Public Class LoginResult
            Private _account As Account
            Private _result As DialogResult

            Public Property Account As Account
                Get
                    Return _account
                End Get
                Set(value As Account)
                    _account = value
                End Set
            End Property

            Public Property Result As DialogResult
                Get
                    Return _result
                End Get
                Set(value As DialogResult)
                    _result = value
                End Set
            End Property

            Public Sub New(Account As Account, Result As DialogResult)
                Me.Account = Account
                Me.Result = Result
            End Sub

        End Class

        Public Function GetAccountViaLogin() As LoginResult
            Dim frmLogin As New frmLogin
            frmLogin.ShowDialog()

            Return New LoginResult(frmLogin.Account, frmLogin._loginResult)
        End Function

        Friend Function CheckAccount(Account As Account) As Boolean
            Return _accData.IsCorrect(Account)
        End Function

        Friend Function CheckAccount(Username As String, Password As String) As Boolean
            Dim Account As Account = New Account(Username, Password)
            Return _accData.IsCorrect(Account)
        End Function
    End Class
End Namespace
