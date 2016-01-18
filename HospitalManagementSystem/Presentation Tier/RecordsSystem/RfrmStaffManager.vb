Imports DevExpress.XtraGrid.Views.Grid

Public Class RfrmStaffManager
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim _emplBus As New BUS.BusiEmployee


        gcStaffs.DataSource = _emplBus.SearchEmployees
    End Sub

End Class