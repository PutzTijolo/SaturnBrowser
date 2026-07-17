Imports System.Threading.Tasks
Imports System
Public Class ai

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If Guna2ComboBox1.SelectedIndex = 0 Then
            ChromiumWebBrowser1.LoadUrl("https://chatgpt.com")
        End If
        If Guna2ComboBox1.SelectedIndex = 1 Then
            ChromiumWebBrowser1.LoadUrl("https://gemini.google.com")
        End If
        If Guna2ComboBox1.SelectedIndex = 2 Then
            ChromiumWebBrowser1.LoadUrl("https://copilot.microsoft.com")
        End If
        If Guna2ComboBox1.SelectedIndex = 3 Then
            ChromiumWebBrowser1.LoadUrl("https://claude.ai")
        End If
        If Guna2ComboBox1.SelectedIndex = 4 Then
            ChromiumWebBrowser1.LoadUrl("https://grok.com")
        End If
    End Sub
End Class