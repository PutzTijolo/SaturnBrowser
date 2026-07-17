Public Class documents
    Private Sub documents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChromiumWebBrowser1.LoadUrl("https://richtexteditor.saturnbrowser.app")
    End Sub
End Class