Imports CefSharp
Public Class twitch
    Public videoid As String
    Private Sub twitch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If videoid = "" Then
            ChromiumWebBrowser1.LoadHtml("<center> <h1>Error: </h1> <hr> <p>Open a Twitch Profile to use Saturn Browser Picture in Picture </p> <style> body{font-family: 'century gothic'}</style>")
        Else
            ChromiumWebBrowser1.LoadUrl("https://player.twitch.tv/?channel=" & videoid & "&player=facebook&autoplay=false&parent=iframe.ly&parent=cdn.iframe.ly&parent=iframely.net&parent=iframely.com&parent=if-cdn.com")
        End If
    End Sub
End Class