Public Class Alluserfrm
    Private Sub Alluserfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MaximizeBox = False

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        cifopen1.ShowDialog()

    End Sub
End Class