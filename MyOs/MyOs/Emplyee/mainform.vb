Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Public Class mainform
    Public Shared sendmyname As String = "MainForm"

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub BackstageViewTabItem2_SelectedChanged(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles BackstageViewTabItem2.SelectedChanged


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub NavBarControl1_Click(sender As Object, e As EventArgs) Handles NavBarControl1.Click
        Dim pn As PanelControl = New PanelControl
    End Sub

    Private Sub newuserLB_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles newuserLB.LinkClicked
        PanelControl1.Controls.Clear()
        Dim newuserlist As newuserlist = New newuserlist
        Dim details As DetailsView = New DetailsView
        details.Dock = DockStyle.Right
        newuserlist.Dock = DockStyle.Fill
        PanelControl1.Controls.Add(newuserlist)
        PanelControl1.Controls.Add(details)
    End Sub


    Private Sub mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' e.Cancel = True
        parrentfrm.BringToFront()

    End Sub

    Private Sub alluserLB_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles alluserLB.LinkClicked
        Try
            PanelControl1.Controls.Clear()
            PanelControl1.Hide()
        Catch ex As Exception

        Finally
            Alluserfrm.MdiParent = Me
            Alluserfrm.WindowState = FormWindowState.Maximized
            Alluserfrm.Show()
            Alluserfrm.BringToFront()

        End Try


    End Sub
    Private Sub RibbonControl_Merge(ByVal sender As System.Object, ByVal e As RibbonMergeEventArgs) Handles RibbonControl.Merge
        'Dim parentRRibbon As RibbonControl = TryCast(sender, RibbonControl)
        'Dim childRibbon As RibbonControl = e.MergedChild
        'parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar)
        TryCast(sender, RibbonControl).StatusBar.MergeStatusBar(e.MergedChild.StatusBar)
    End Sub
End Class