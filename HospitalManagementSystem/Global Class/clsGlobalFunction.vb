Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text

Namespace GlobalClass
    Class GlobalFunction

#Region "Constructor"
        Public Sub New()

        End Sub
#End Region

#Region "Methods"
        ''' <summary>
        ''' Hàm chuyển đổi chuỗi ngày tháng sang định dạng Datetime
        ''' </summary>
        ''' <param name="date">Chuỗi ngày tháng cần chuyển đổi (định dạng MM/dd/yyyy)</param>
        ''' <param name="dateFormat">Định dạng chuỗi date truyền vào (dmy, mdy,ymd,ydm)</param>
        ''' <returns>Đối tượng Datetime đã được chuyển đổi (nếu tham số format truyền vào không đúng định dạng hàm sẽ trả về ngày hiện tại)</returns>
        Public Shared Function DateTimeConverter(ByVal [date] As String, ByVal dateFormat As String) As DateTime
            If [date].Trim() <> "" Then
                Dim dateTimeConverted As New DateTime()

                Dim delimStr As String = "\/- "
                Dim delimiter As Char() = delimStr.ToCharArray()
                Dim split As String() = Nothing

                For x As Integer = 1 To 3
                    split = [date].Split(delimiter)
                Next

                Select Case dateFormat.ToLower().Trim()
                    Case "mdy"
                        dateTimeConverted = New DateTime(Convert.ToInt32(split(2).ToString()), Convert.ToInt32(split(0).ToString()), Convert.ToInt32(split(1).ToString()))
                        Exit Select
                    Case "dmy"
                        dateTimeConverted = New DateTime(Convert.ToInt32(split(2).ToString()), Convert.ToInt32(split(1).ToString()), Convert.ToInt32(split(0).ToString()))
                        Exit Select
                    Case "ymd"
                        dateTimeConverted = New DateTime(Convert.ToInt32(split(0).ToString()), Convert.ToInt32(split(1).ToString()), Convert.ToInt32(split(2).ToString()))
                        Exit Select
                    Case "ydm"
                        dateTimeConverted = New DateTime(Convert.ToInt32(split(0).ToString()), Convert.ToInt32(split(2).ToString()), Convert.ToInt32(split(1).ToString()))
                        Exit Select
                    Case Else
                        dateTimeConverted = DateTime.Now
                        Exit Select
                End Select

                Return dateTimeConverted
            Else
                Return DateTime.Now
            End If
        End Function
#End Region

    End Class
End Namespace
