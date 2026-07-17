Public Class tempmail
    Private Sub tempmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.Load("https://tempmail.adguard.com/?_locale=en&theme=dark")
    End Sub
End Class