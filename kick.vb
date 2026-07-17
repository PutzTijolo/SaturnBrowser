Imports CefSharp
Public Class kick
    Public videoid As String
    Private Sub kick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If videoid = "" Then
            ChromiumWebBrowser1.LoadHtml("<center> <h1>Error: </h1> <hr> <p>Open a Kick livestream to use Saturn Browser Picture in Picture </p> <style> body{font-family: 'century gothic'}</style>")
        Else
            ChromiumWebBrowser1.LoadUrl("https://player.kick.com/" & videoid)
        End If
    End Sub
End Class