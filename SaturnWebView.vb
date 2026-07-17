Imports CefSharp.WinForms
Imports CefSharp
Imports System.Net
Imports System.IO
Public Class SaturnWebView
    Public AbaShow = New TabPage

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        browser.Back
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        browser.Forward
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        browser.Reload
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2ContextMenuStrip1.Show()
        Guna2ContextMenuStrip1.Location = Cursor.Position

    End Sub

    Private Sub SaturnWebView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.language = "BR" Then
            Guna2TextBox1.PlaceholderText = "Insira uma URL ou Pesquisa"
            Guna2HtmlToolTip1.SetToolTip(Guna2Button3, "Voltar")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button1, "Avançar")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button4, "Recarregar")
            AppearanceToolStripMenuItem.Text = "Nova Aba"
            'NewWindowsToolStripMenuItem.Text = "Nova Janela"
            NewNoirNetworkToolStripMenuItem.Text = "Novo Roteador Onion"
            'PasswordManagerToolStripMenuItem.Text = "Gerenciador de Senhas"
            HistoryToolStripMenuItem.Text = "Historico"
            BookmarksToolStripMenuItem.Text = "Favoritos"
            ' ExtensionsToolStripMenuItem.Text = "Extensões"
            'HelpToolStripMenuItem.Text = "Ajuda"
            AppearanceToolStripMenuItem1.Text = "Aparencia"
            ConfigurationToolStripMenuItem.Text = "Configurações"
        End If
        If My.Settings.language = "ES" Then
            Guna2TextBox1.PlaceholderText = "Introduzca una URL o busque"
            Guna2HtmlToolTip1.SetToolTip(Guna2Button3, "Volver")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button1, "Proximo")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button4, "Recargar")

            AppearanceToolStripMenuItem.Text = "Nueva pestaña"
            'NewWindowsToolStripMenuItem.Text = "Nueva Ventana"
            NewNoirNetworkToolStripMenuItem.Text = "Nueva Network Noir"
            'PasswordManagerToolStripMenuItem.Text = "Administrador de contraseñas"
            HistoryToolStripMenuItem.Text = "Historia"
            BookmarksToolStripMenuItem.Text = "Favoritos"
            'ExtensionsToolStripMenuItem.Text = "Extensiones"
            'HelpToolStripMenuItem.Text = "Ayuda"
            AppearanceToolStripMenuItem1.Text = "Apariencia"
            ConfigurationToolStripMenuItem.Text = "Ajustes"
        End If
        browser.Load(My.Settings.home)

        If My.Settings.home = "hgoogle" Then
            If My.Settings.color = "orange" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\orange.html")
            End If
            If My.Settings.color = "blue" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\blue.html")
            End If
            If My.Settings.color = "aqua" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\aqua.html")
            End If
            If My.Settings.color = "gold" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\yellow.html")
            End If
            If My.Settings.color = "red" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\red.html")
            End If
            If My.Settings.color = "green" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\lime.html")
            End If
            If My.Settings.color = "lime" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\lime.html")
            End If
            If My.Settings.color = "pink" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\pink.html")
            End If
            If My.Settings.color = "purple" Then
                browser.Load(Application.StartupPath & "\Saturn\Google\pink.html")
            End If
        End If

        If My.Settings.home = "hbing" Then
            If My.Settings.color = "orange" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\orange.html")
            End If
            If My.Settings.color = "blue" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\blue.html")
            End If
            If My.Settings.color = "aqua" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\aqua.html")
            End If
            If My.Settings.color = "gold" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\yellow.html")
            End If
            If My.Settings.color = "red" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\red.html")
            End If
            If My.Settings.color = "green" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\lime.html")
            End If
            If My.Settings.color = "lime" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\lime.html")
            End If
            If My.Settings.color = "pink" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\pink.html")
            End If
            If My.Settings.color = "purple" Then
                browser.Load(Application.StartupPath & "\Saturn\bing\pink.html")
            End If
        End If
        If My.Settings.home = "hduckduckgo" Then
            If My.Settings.color = "orange" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\orange.html")
            End If
            If My.Settings.color = "blue" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\blue.html")
            End If
            If My.Settings.color = "aqua" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\aqua.html")
            End If
            If My.Settings.color = "gold" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\yellow.html")
            End If
            If My.Settings.color = "red" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\red.html")
            End If
            If My.Settings.color = "green" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\lime.html")
            End If
            If My.Settings.color = "lime" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\lime.html")
            End If
            If My.Settings.color = "pink" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\pink.html")
            End If
            If My.Settings.color = "purple" Then
                browser.Load(Application.StartupPath & "\Saturn\duckduckgo\pink.html")
            End If
        End If

        If My.Settings.home = "hyahoo" Then
            If My.Settings.color = "orange" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\orange.html")
            End If
            If My.Settings.color = "blue" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\blue.html")
            End If
            If My.Settings.color = "aqua" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\aqua.html")
            End If
            If My.Settings.color = "gold" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\yellow.html")
            End If
            If My.Settings.color = "red" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\red.html")
            End If
            If My.Settings.color = "green" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\lime.html")
            End If
            If My.Settings.color = "lime" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\lime.html")
            End If
            If My.Settings.color = "pink" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\pink.html")
            End If
            If My.Settings.color = "purple" Then
                browser.Load(Application.StartupPath & "\Saturn\yahoo\pink.html")
            End If
        End If


        If My.Settings.home = "google" Then
            browser.Load("google.com")
        End If
        If My.Settings.home = "duckduck" Then
            browser.Load("start.duckduckgo.com")
        End If
        If My.Settings.home = "bing" Then
            browser.Load("bing.com")
        End If
        If My.Settings.home = "yahoo" Then
            browser.Load("yahoo.com")
        End If


        If My.Settings.ThemeDark = True Then

        Else
            Me.BackColor = Color.White
            Guna2Button2.ForeColor = Color.Black
            Guna2Button4.ForeColor = Color.Black
            Guna2Button3.ForeColor = Color.Black
            Guna2Button1.ForeColor = Color.Black

            Guna2Button2.FillColor = Color.White
            Guna2Button4.FillColor = Color.White
            Guna2Button3.FillColor = Color.White
            Guna2Button1.FillColor = Color.White
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            browser.Load("https://www.google.com/search?q=" + Guna2TextBox1.Text)
            If Guna2TextBox1.Text.Contains(".") Then
                browser.Load(Guna2TextBox1.Text)
            End If
            If Guna2TextBox1.Text.Contains(":") Then
                browser.Load(Guna2TextBox1.Text)
            End If


        End If
    End Sub

    Private Sub browser_AddressChanged(sender As Object, e As AddressChangedEventArgs) Handles browser.AddressChanged
        Guna2TextBox1.Text = browser.Address

        WebBrowser1.Navigate(browser.Address)
        If Guna2TextBox1.Text.Contains("Saturn/Google") Then
            Guna2TextBox1.Text = "Saturn Browser"
        End If
        If Guna2TextBox1.Text.Contains("Saturn/duckduckgo") Then
            Guna2TextBox1.Text = "Saturn Browser"
        End If
        If Guna2TextBox1.Text.Contains("Saturn/bing") Then
            Guna2TextBox1.Text = "Saturn Browser"
        End If
        If Guna2TextBox1.Text.Contains("Saturn/yahoo") Then
            Guna2TextBox1.Text = "Saturn Browser"
        End If
        If Guna2TextBox1.Text.Contains("Saturn/") Then
        Else
            File.AppendAllText("libIE.dll", vbNewLine & browser.Address.ToString)
        End If

    End Sub

    Private Sub AppearanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppearanceToolStripMenuItem1.Click
        appearence.Show()
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Guna2TextBox1.Text.Contains("Saturn/Google") Then
            Guna2TextBox1.Text = "Saturn Browser"
        End If
        If Guna2TextBox1.Text.Contains("youtube.com/watch?v=") Then
            Dim text As String
            Dim id As String
            text = browser.Address
            id = text.Substring(text.Length - 11)
            youtube.videoid = id
        End If
        If Guna2TextBox1.Text.Contains("twitch.tv/") Then
            Dim poo() As String
            poo = Guna2TextBox1.Text.Split("/")
            If poo(3).EndsWith("/") Then
                poo(3).Replace("/", "")
                twitch.videoid = poo(3)
            Else
                twitch.videoid = poo(3)
            End If

        End If
        If Guna2TextBox1.Text.Contains("kick.com/") Then
            Dim poo() As String
            poo = Guna2TextBox1.Text.Split("/")
            If poo(3).EndsWith("/") Then
                poo(3).Replace("/", "")
                kick.videoid = poo(3)
            Else
                kick.videoid = poo(3)
            End If

        End If
        Try
            If Form1.tesete(1).Contains("start-games") Then
                Dim tab As New TabPage
                Dim WebView As New Games

                WebView.Dock = DockStyle.Fill
                If My.Settings.ThemeDark = True Then
                    tab.BackColor = Color.FromArgb(16, 16, 16)
                Else
                    WebView.BackColor = Color.White
                    tab.BackColor = Color.White
                End If

                tab.Controls.Add(WebView)
                Form1.Guna2TabControl1.TabPages.Add(tab)
                Form1.Guna2TabControl1.SelectedTab = tab
                Form1.Guna2Button9.Left += 180
                Form1.Guna2Button10.Left += 180
                Form1.Guna2TabControl1.SelectedTab.Text = "Games"
                Form1.tesete(1) = ""
            End If
            If Form1.tesete(1).Contains("start-vpn") Then
                Process.Start("SaturnVPN.exe")
                Form1.tesete(1) = ""
            End If
            If Form1.tesete(1).Length >= 1 Then
                browser.Load(Form1.tesete(1))
                Form1.tesete(1) = ""
            End If
        Catch ex As Exception

        End Try
        Dim wc As New WebClient

        Dim memorystream As New MemoryStream(wc.DownloadData("http://" & New Uri(WebBrowser1.Url.ToString).Host & "/favicon.ico"))
        Dim icon As New Icon(memorystream)

        Form1.ImageList1.Images.Add(icon.ToBitmap)

        AbaShow.ImageIndex = Form1.ImageList1.Images.Count - 1
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating

    End Sub

    Private Sub ConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New config

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.SelectedTab.Text = "Configuration"
    End Sub

    Private Sub DevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevToolsToolStripMenuItem.Click
        browser.ShowDevTools
    End Sub

    Private Sub browser_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles browser.TitleChanged
        Me.Parent.Text = e.Title
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New History

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.SelectedTab.Text = "History"
    End Sub

    Private Sub NewNoirNetworkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewNoirNetworkToolStripMenuItem.Click
        Process.Start("tor\tor-saturnbrowser.exe")
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New bookmarks

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.SelectedTab.Text = "Bookmarks"
    End Sub

    Private Sub BookmarkThisPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarkThisPageToolStripMenuItem.Click
        File.AppendAllText("libGecko.dll", vbNewLine & browser.Address.ToString)
    End Sub

    Private Sub AppearanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppearanceToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New SaturnWebView

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.SelectedTab.Text = "New Tab"
    End Sub
End Class
