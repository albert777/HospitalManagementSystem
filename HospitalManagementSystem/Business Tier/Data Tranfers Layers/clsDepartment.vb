﻿Namespace DTO
    Public Class Department     'Khoa

#Region "Attributes"
        Protected _id As Integer    'Mã số khoa
        Protected _name As String   'Tên khoa
        Protected _chief As Doctor  'Bác sĩ trưởng khoa

#End Region

#Region "Constructor"
        Public Sub New()
            Id = 0
            Name = ""
            Chief = Nothing
        End Sub

        Public Sub New(Name As String)
            Id = 0
            Me.Name = Name
            Chief = Nothing
        End Sub

        Public Sub New(Id As Integer, Name As String)
            Me.Id = Id
            Me.Name = Name
            Chief = Nothing
        End Sub

        Public Sub New(Id As Integer)
            Me.New()
            Me.Id = Id
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

        Public Property Name As String
            Get
                If Me Is Nothing Then
                    Return "Không có"
                Else
                    Return _name
                End If
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Public Property Chief As Doctor
            Get
                Return _chief
            End Get
            Set(value As Doctor)
                _chief = value
            End Set
        End Property
#End Region

    End Class
End Namespace
