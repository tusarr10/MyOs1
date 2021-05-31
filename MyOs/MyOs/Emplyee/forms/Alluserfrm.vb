Public Class Alluserfrm
    Private Sub Alluserfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MaximizeBox = False

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        info.action = "new"
        cifopen1.MdiParent = mainform
        cifopen1.ShowDialog()
        cifopen1.BringToFront()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        info.action = "new"
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'TODO
        info.action = "update"

    End Sub
End Class