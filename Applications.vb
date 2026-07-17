Public Class Applications
    Private Sub Applications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.language = "BR" Then
            Label1.Text = "Aplicativos"
        End If
        If My.Settings.language = "ES" Then
            Label1.Text = "Aplicaciones"
        End If
        ChromiumWebBrowser1.LoadUrl("https://saturnbrowser.app/ads/728x90/")
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        InfinityCode.Show()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        documents.Show()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        video_editor.Show()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        tempmail.Show()
    End Sub
End Class
