Public Class RfrmAccountsManager
    Private _accBus As BUS.BusiAccount

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _accBus = New BUS.BusiAccount


        gcStaffs.DataSource = _accBus.GetAccountsInfos()
    End Sub

    Private Sub bbiHideAccounts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiHideAccounts.ItemClick
        Me.Hide()
    End Sub

    Private Sub bbiReLoadAccounts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiReLoadAccounts.ItemClick
        gcStaffs.DataSource = _accBus.GetAccountsInfos()
    End Sub

    Private Sub bbiAddAccount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAddAccount.ItemClick
        Dim frmAddAccount As New XfrmAddAccount
        frmAddAccount.ShowDialog()
        gcStaffs.DataSource = _accBus.GetAccountsInfos()
    End Sub

    Private Sub bbiDeleteAccount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDeleteAccount.ItemClick
        Dim frmDeleteAccount As New XfrmDeleteAccount
        frmDeleteAccount.ShowDialog()
        gcStaffs.DataSource = _accBus.GetAccountsInfos()
    End Sub
End Class