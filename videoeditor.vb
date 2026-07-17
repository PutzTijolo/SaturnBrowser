Public Class video_editor
    Private Sub video_editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.LoadUrl("https://pixiko.com/editor-evolution")
    End Sub

    Private Sub ChromiumWebBrowser1_FrameLoadEnd(sender As Object, e As CefSharp.FrameLoadEndEventArgs) Handles ChromiumWebBrowser1.FrameLoadEnd
        PictureBox1.BackColor = Color.FromArgb(36, 36, 36)
        PictureBox2.BackColor = Color.FromArgb(36, 36, 36)
    End Sub
End Class