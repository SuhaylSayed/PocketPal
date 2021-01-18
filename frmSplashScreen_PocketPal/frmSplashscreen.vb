Public Class frmSplashscreen
    Private Sub timerSplashScreen_Tick(sender As Object, e As EventArgs) Handles timerSplashScreen.Tick
        frmPocketPal_HomeScreen.Show()
        Me.Hide()
        timerSplashScreen.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerSplashScreen.Start()
    End Sub

    Private Sub picGif_Click(sender As Object, e As EventArgs) Handles picGif.Click

    End Sub
End Class
