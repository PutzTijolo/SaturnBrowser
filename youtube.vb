Imports CefSharp
Public Class youtube
    Public videoid As String
    Private Sub youtube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If videoid = "" Then
            ChromiumWebBrowser1.LoadHtml("<center> <h1>Error: </h1> <hr> <p>Open a Youtube video to use Saturn Browser Picture in Picture </p> <style> body{font-family: 'century gothic'}</style>")
        Else
            ChromiumWebBrowser1.LoadUrl("https://www.yout-ube.com/watch?v=" & videoid)
        End If
    End Sub
End Class