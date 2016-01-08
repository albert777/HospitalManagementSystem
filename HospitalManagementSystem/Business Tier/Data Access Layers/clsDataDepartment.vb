
Namespace DAO
    Public Class DataDepartment
        Inherits DataBaseAccess

        Public Sub New()

        End Sub

        Public Function GetDepartmentsDataTable() As DataTable
            'Never Edit that
            'Never Edit that!
            'Never Edit that!!!
            Dim query As String = "SELECT t1.DId As Id, t1.DName As Name, t1.COUNT AS COUNT, t1.Chief AS Chief, t2.Name As ChiefName
                                   FROM
                                        (SELECT D.Id AS DId, D.Name AS DName, COUNT(E.Id) AS COUNT, D.Chief
                                         FROM dbo.DEPARTMENTS AS D LEFT OUTER JOIN
                                              dbo.EMPLOYEES AS E ON D.Id = E.DeptId
                                         GROUP BY D.Name, D.Id, D.Chief) AS t1 LEFT OUTER JOIN
                                        (SELECT Name, Id
                                         FROM dbo.EMPLOYEES) AS t2 ON t1.Chief = t2.Id"
            'NEVER EDIT THAT!!!!!

            Return GetDataTable(query)
        End Function

        Friend Sub AddDepartment(name As String, chiefid As Integer)
            Dim query As String = String.Empty
            If chiefid = -1 Then
                query = String.Format("INSERT INTO DEPARTMENTS (Name) VALUES (N'{0}')", name)
            Else
                query = String.Format("INSERT INTO DEPARTMENTS (Name, Chief) VALUES (N'{0}', {1})", name, chiefid)
            End If
        End Sub

        Friend Sub DeleteDepartment(name As String)
            Dim query As String = String.Format("DELETE FROM DEPARTMENTS WHERE Name = N'{0}'", name)
            MsgBox(query)
            ExecuteNoneQuery(query)
        End Sub

        Friend Sub UpdateDepartment(oldName As String, newName As String, chiefid As Integer)
            Dim query As String = String.Empty
            If chiefid = -1 Then
                query = String.Format("UPDATE DEPARTMENTS
                                       SET Name = N'{0}'
                                       WHERE Name = N'{1}'",
                                      newName, oldName)
            Else
                query = String.Format("UPDATE DEPARTMENTS
                                       SET Name = N'{0}', Chief = {1}
                                       WHERE Name = N'{2}'",
                      newName, chiefid, oldName)
            End If

            ExecuteNoneQuery(query)
        End Sub
    End Class
End Namespace
