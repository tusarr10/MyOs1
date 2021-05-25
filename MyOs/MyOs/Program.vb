

Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraSplashScreen

Public NotInheritable Class Program
    Sub New()

    End Sub
    Shared Sub Main()
        ' SplashScreenManager.ShowForm(GetType(ssMyOs))
        BonusSkins.Register()
        SkinManager.EnableFormSkins()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New parrentfrm())


    End Sub
End Class


