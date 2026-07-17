Public Class Video
    Private Sub Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.LoadUrl("https://saturnbrowser.app/ads/350x50/")
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        youtube.Show()
        Close()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        twitch.Show()
        Close()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        kick.Show()
        Close()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        tiktok.Show()
        Close()
    End Sub
End Class