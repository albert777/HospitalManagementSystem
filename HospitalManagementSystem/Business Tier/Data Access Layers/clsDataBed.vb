Imports HospitalManagementSystem.DTO

Namespace DAO
    Public Class DataBed
        Inherits DataBaseAccess

        Public Sub New()

        End Sub

        Friend Function DeleteBed(id As Integer) As Boolean
            Dim query As String = String.Format("DELETE FROM BEDS WHERE Id = {0}", id)
            Return ExecuteNoneQuery(query)
        End Function

        Friend Function GetBedsDataTable() As DataTable
            Dim query As String = "SELECT B.*, D.Name AS DeptName
                                   FROM BEDS AS B LEFT OUTER JOIN DEPARTMENTS AS D
                                   ON B.DeptId = D.Id"
            Return GetDataTable(query)
        End Function

        Friend Function AddBed(RoomId As Integer, deptId As Integer) As Boolean
            Dim query As String = String.Format("INSERT INTO BEDS(Room, DeptId) VALUES({0}, {1})", RoomId, deptId)
            Return ExecuteNoneQuery(query)
        End Function

        Friend Function UpdateBed(id As Integer, roomId As Integer, deptId As Integer) As Boolean
            Dim query As String = String.Format("UPDATE BEDS SET Room = {0}, DeptId = {1} WHERE Id = {2}", roomId, deptId, id)
            Return ExecuteNoneQuery(query)
        End Function
    End Class
End Namespace
