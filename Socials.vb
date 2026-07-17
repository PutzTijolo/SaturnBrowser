Public Class Socials
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://discord.com/app")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://web.whatsapp.com/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://web.telegram.org/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://www.instagram.com/direct/inbox/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://x.com/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://facebook.com/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile7_Click(sender As Object, e As EventArgs) Handles MetroTile7.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://pinterest.com")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub

    Private Sub MetroTile8_Click(sender As Object, e As EventArgs) Handles MetroTile8.Click
        SaturnView.Show()
        SaturnView.ChromiumWebBrowser1.Load("https://reddit.com/")
        SaturnView.Location = Form1.Location
        SaturnView.Height = Form1.Height
        Me.Hide()
    End Sub
End Class