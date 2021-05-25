
Imports DevExpress.Compatibility.System.Windows
Imports DevExpress.XtraBars
Imports DevExpress.XtraSplashScreen

Public Class parrentfrm

    Private m_ChildFormNumber As Integer

    Private Sub barBtnStart_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnStart.ItemClick

    End Sub

    Private Sub BtnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExit.ItemClick
        Application.Exit()

    End Sub

    Private Sub SettingMenuBar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SettingMenuBar.ItemClick
        Settingsetup.MdiParent = Me
        Settingsetup.Show()
    End Sub

    Private Sub parrentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        '  mainform.MdiParent = Me
        stbar()
    End Sub
    Public itemPrint As BarButtonItem = New BarButtonItem()
    Dim x As Integer

    Sub stbar()

        mainform.WindowState = FormWindowState.Maximized
        mainform.Show()
        mainform.BringToFront()
        ' Manually add the created item to the item collection of the RibbonControl.
        itemPrint.Caption = "MainForm"
        'itemPrint.ImageIndex = 1 ' My.Resources.Accounting
        itemPrint.Id = bar3.Manager.GetNewItemId() 'Ensures correct runtime layout (de)serialization.
        x = itemPrint.Id
        itemPrint.ItemAppearance.Normal.ForeColor = Color.LightGreen
        Dim linkPrint As BarItemLink = bar3.ItemLinks.Add(itemPrint)
        AddHandler itemPrint.ItemClick, AddressOf itemPrint_ItemClick

    End Sub


    Private Sub itemPrint_ItemClick(sender As Object, e As ItemClickEventArgs)
        If itemPrint.ItemAppearance.Normal.ForeColor = Color.LightGreen Then
            itemPrint.ItemAppearance.Normal.ForeColor = Color.Green
            mainform.BringToFront()
        ElseIf itemPrint.ItemAppearance.Normal.ForeColor = Color.Green Then
            itemPrint.ItemAppearance.Normal.ForeColor = Color.LightGreen
            mainform.BringToFront()
        End If


    End Sub
End Class
