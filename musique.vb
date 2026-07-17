Public Class musique
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://music.youtube.com")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://spotify.com")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://deezer.com")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://music.apple.com")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub musique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.LoadUrl("https://saturnbrowser.app/ads/350x50/")
    End Sub
End Class