Imports CefSharp
Imports System.Net
Imports System.IO
Imports CefSharp.WinForms
Imports System.Security.Principal
Imports System.Diagnostics
Public Class Form1
    Public tesete As String()
    Public videoid As String
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short
    End Function

    Function IsKeyPressed(ByVal key As Keys) As Boolean
        Return (GetAsyncKeyState(key) And &H8000) <> 0
    End Function
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Inception.Show()
        Inception.Location = Me.Location
        Inception.Height = Me.Height
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Video.Show()
        Video.Location = Me.Location
        Video.Height = Me.Height
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        musique.Show()
        musique.Location = Me.Location
        musique.Height = Me.Height
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileSystemWatcher1.Path = "C:\Users\" & SystemInformation.UserName & "\Downloads\"
        Dim client As New WebClient
        Dim Rertorp As String = client.DownloadString("https://saturnbrowser.app/currentversion.txt")
        If Rertorp = "130.0.0" Then

        Else
            My.Computer.Network.DownloadFile("https://saturnbrowser.app/update.exe", "")
        End If

        If My.Settings.language = "BR" Then
            Guna2HtmlToolTip1.SetToolTip(Guna2Button1, "Jogos")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button2, "Aplicativos")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button5, "Musica")
        End If
        If My.Settings.language = "ES" Then
            Guna2HtmlToolTip1.SetToolTip(Guna2Button1, "Juegos")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button2, "Aplicaciones")
            Guna2HtmlToolTip1.SetToolTip(Guna2Button5, "Musica")
        End If
        Dim settings = New CefSettings
        If My.Settings.ThemeDark = True Then
            settings.CefCommandLineArgs.Add("force-dark-mode")
        Else
            settings.CefCommandLineArgs.Remove("force-dark-mode")
        End If

        settings.UserAgent = ("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.7827.199 Safari/537.36")
        settings.WindowlessRenderingEnabled = True
        Dim instance As Process() = Process.GetProcessesByName("Saturn Browser")
        If instance.Length > 1 Then
            MsgBox("Another Instance of Saturn Browser is Running", MsgBoxStyle.Exclamation)
            Close()
        Else
            Cef.Initialize(settings)
        End If

        Dim tab As New TabPage
        Dim WebView As New SaturnWebView
        WebView.AbaShow = tab
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Guna2TabControl1.TabPages.Add(tab)
        Guna2TabControl1.SelectedTab = tab

        If My.Settings.color = "blue" Then
            Panel1.BackColor = Color.FromArgb(9, 86, 239)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(9, 86, 239)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.DeepSkyBlue

            PictureBox1.BackgroundImage = My.Resources.favicondarkblue
        End If
        If My.Settings.color = "aqua" Then
            Panel1.BackColor = Color.FromArgb(35, 213, 213)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(35, 213, 213)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.LightBlue

            PictureBox1.BackgroundImage = My.Resources.faviconaqua
        End If
        If My.Settings.color = "lime" Then
            Panel1.BackColor = Color.FromArgb(74, 223, 25)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(74, 223, 25)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.LimeGreen

            PictureBox1.BackgroundImage = My.Resources.faviconlimegreen
        End If

        If My.Settings.color = "green" Then
            Panel1.BackColor = Color.FromArgb(61, 183, 69)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(61, 183, 69)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.PaleGreen

            PictureBox1.BackgroundImage = My.Resources.favicongreen
        End If
        If My.Settings.color = "gold" Then
            Panel1.BackColor = Color.FromArgb(239, 205, 9)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(239, 205, 9)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(255, 255, 192)

            PictureBox1.BackgroundImage = My.Resources.faviconyellow
        End If
        If My.Settings.color = "red" Then
            Panel1.BackColor = Color.FromArgb(213, 45, 31)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(213, 45, 31)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.LightCoral

            PictureBox1.BackgroundImage = My.Resources.faviconred
        End If
        If My.Settings.color = "pink" Then
            Panel1.BackColor = Color.FromArgb(223, 25, 203)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(223, 25, 203)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.Crimson

            PictureBox1.BackgroundImage = My.Resources.faviconpink
        End If
        If My.Settings.color = "purple" Then
            Panel1.BackColor = Color.FromArgb(129, 81, 184)
            Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(129, 81, 184)
            Guna2TabControl1.TabButtonHoverState.InnerColor = Color.Violet

            PictureBox1.BackgroundImage = My.Resources.faviconpurple
        End If


        If My.Settings.ThemeDark = True Then

        Else
            Me.BackColor = Color.White
            Guna2Button10.ForeColor = Color.Black
            Guna2Button9.ForeColor = Color.Black
            Guna2TabControl1.TabButtonHoverState.FillColor = Color.White
            Guna2TabControl1.TabButtonHoverState.ForeColor = Color.Black

            Guna2TabControl1.TabButtonIdleState.FillColor = Color.White
            Guna2TabControl1.TabButtonIdleState.InnerColor = Color.White


            Guna2TabControl1.TabMenuBackColor = Color.White
            Guna2TabControl1.TabButtonSelectedState.FillColor = Color.White
            Guna2TabControl1.TabButtonSelectedState.ForeColor = Color.Black



            Guna2ControlBox1.FillColor = Color.White
            Guna2ControlBox2.FillColor = Color.White
            Guna2ControlBox3.FillColor = Color.White

            Guna2ControlBox1.IconColor = Color.Black
            Guna2ControlBox2.IconColor = Color.Black
            Guna2ControlBox3.IconColor = Color.Black

            Guna2ControlBox3.HoverState.IconColor = Color.Black
            Guna2ControlBox2.HoverState.IconColor = Color.Black
            Guna2ControlBox1.HoverState.IconColor = Color.GhostWhite
            Guna2ControlBox2.HoverState.FillColor = Color.GhostWhite
            Guna2ControlBox3.HoverState.FillColor = Color.GhostWhite

            Guna2Button2.ForeColor = Color.Black
            Guna2Button4.ForeColor = Color.Black
            Guna2Button3.ForeColor = Color.Black
            Guna2Button1.ForeColor = Color.Black

            Guna2Button2.FillColor = Color.Gainsboro
            Guna2Button4.FillColor = Color.Gainsboro
            Guna2Button3.FillColor = Color.Gainsboro
            Guna2Button1.FillColor = Color.Gainsboro

            Guna2Button5.ForeColor = Color.Black
            Guna2Button6.ForeColor = Color.Black
            Guna2Button7.ForeColor = Color.Black
            'Guna2Button8.ForeColor = Color.Black
            Guna2Button11.ForeColor = Color.Black


            Guna2Button6.FillColor = Color.Gainsboro
            Guna2Button5.FillColor = Color.Gainsboro
            Guna2Button7.FillColor = Color.Gainsboro
            'Guna2Button8.FillColor = Color.Gainsboro
            Guna2Button11.FillColor = Color.Gainsboro
        End If
        Try
            tesete = Environment.GetCommandLineArgs()
        Catch ex As Exception

        End Try

    End Sub
    Public Function IsUserAdmin() As Boolean
        Dim id As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As New WindowsPrincipal(id)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Not IsUserAdmin() Then
            Dim result = MessageBox.Show("To Play Games, Saturn Browser needs to be runned as Administrator, do you want to restart the application with Administrator Privileges?",
                                         "Warning",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim startInfo As New ProcessStartInfo()
                startInfo.UseShellExecute = True
                startInfo.WorkingDirectory = Environment.CurrentDirectory
                startInfo.FileName = Application.ExecutablePath
                startInfo.Arguments = "start-games"
                startInfo.Verb = "runas"
                Try
                    Process.Start(startInfo)
                    Application.Exit()
                Catch ex As Exception
                    MsgBox("Administrator Privileges were Recused, Error: " & ex.ToString)
                End Try
            Else

            End If

        Else
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
            Guna2TabControl1.TabPages.Add(tab)
            Guna2TabControl1.SelectedTab = tab
            Guna2Button9.Left += 180
            Guna2Button10.Left += 180
            Guna2TabControl1.SelectedTab.Text = "Games"
        End If

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Cef.Shutdown()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim tab As New TabPage
        Dim WebView As New SaturnWebView
        WebView.AbaShow = tab


        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Guna2TabControl1.TabPages.Add(tab)
        Guna2TabControl1.SelectedTab = tab
        Guna2Button9.Left += 180
        Guna2Button10.Left += 180
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        For Each ctrl As Control In Guna2TabControl1.SelectedTab.Controls
            Guna2TabControl1.SelectedTab.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        Guna2TabControl1.TabPages.Remove(Guna2TabControl1.SelectedTab)

        Guna2Button9.Left -= 180
        Guna2Button10.Left -= 180
        If Guna2TabControl1.TabPages.Count < 1 Then
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        Socials.Show()
        Socials.Location = Me.Location
        Socials.Height = Me.Height
        SaturnView.Location = Me.Location
        SaturnView.Height = Me.Height
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Inception.Location = Me.Location
        Inception.Height = Me.Height
        Video.Location = Me.Location
        Video.Height = Me.Height
        ai.Location = Me.Location
        ai.Height = Me.Height
        Socials.Location = Me.Location
        Socials.Height = Me.Height
        SaturnView.Location = Me.Location
        SaturnView.Height = Me.Height
        musique.Location = Me.Location
        musique.Height = Me.Height
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Inception.Location = Me.Location
        Inception.Height = Me.Height
        Video.Location = Me.Location
        Video.Height = Me.Height
        ai.Location = Me.Location
        ai.Height = Me.Height
        Socials.Location = Me.Location
        Socials.Height = Me.Height
        SaturnView.Location = Me.Location
        SaturnView.Height = Me.Height
        musique.Location = Me.Location
        musique.Height = Me.Height
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        ai.Show()
        ai.Location = Me.Location
        ai.Height = Me.Height
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsKeyPressed(Keys.LControlKey) Then
            If IsKeyPressed(Keys.T) Then
                Dim tab As New TabPage
                Dim WebView As New SaturnWebView
                WebView.AbaShow = tab

                WebView.Dock = DockStyle.Fill
                If My.Settings.ThemeDark = True Then
                    tab.BackColor = Color.FromArgb(16, 16, 16)
                Else
                    WebView.BackColor = Color.White
                    tab.BackColor = Color.White
                End If

                tab.Controls.Add(WebView)

                Guna2TabControl1.TabPages.Add(tab)
                Guna2TabControl1.SelectedTab = tab
                Guna2Button9.Left += 180
                Guna2Button10.Left += 180
            End If

            If IsKeyPressed(Keys.W) Then
                For Each ctrl As Control In Guna2TabControl1.SelectedTab.Controls
                    Guna2TabControl1.SelectedTab.Controls.Remove(ctrl)
                    ctrl.Dispose()
                Next

                Guna2TabControl1.TabPages.Remove(Guna2TabControl1.SelectedTab)

                Guna2Button9.Left -= 180
                Guna2Button10.Left -= 180
                If Guna2TabControl1.TabPages.Count < 1 Then
                    Application.Exit()
                End If
            End If
        End If
        SaturnView.MinimumSize = New Size(100, Me.Height)
        SaturnView.MaximumSize = Me.Size
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim tab As New TabPage
        Dim WebView As New Applications

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        Guna2TabControl1.TabPages.Add(tab)
        Guna2TabControl1.SelectedTab = tab
        Guna2Button9.Left += 180
        Guna2Button10.Left += 180
        Guna2TabControl1.SelectedTab.Text = "Applications"
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        If e.Name.Length >= 30 Then
            Dim download As New downloads
            download.Show()
            download.Label1.Text = e.Name
            download.Label2.Text = e.FullPath
            If download.Label1.Text.EndsWith(".exe") Then
                download.PictureBox1.BackgroundImage = My.Resources.Windows_11_executable_svg
            ElseIf download.Label1.Text.EndsWith(".png") Then
                download.PictureBox1.BackgroundImage = My.Resources.image_icon_153794
            ElseIf download.Label1.Text.EndsWith(".txt") Then
                download.PictureBox1.BackgroundImage = My.Resources.Text_txt_svg
            ElseIf download.Label1.Text.EndsWith(".docx") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Word_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".doc") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Word_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".xls") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Excel_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".xlsx") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Excel_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".ppt") Then
                download.PictureBox1.BackgroundImage = My.Resources.PowerPoint
            ElseIf download.Label1.Text.EndsWith(".pptx") Then
                download.PictureBox1.BackgroundImage = My.Resources.PowerPoint
            ElseIf download.Label1.Text.EndsWith(".pdf") Then
                download.PictureBox1.BackgroundImage = My.Resources.PDF_file_icon_svg
            ElseIf download.Label1.Text.EndsWith(".mp4") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mp3") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".wav") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mkv") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".flac") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".ogg") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".wave") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".avi") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".webm") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mp2") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".psd") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Photoshop_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".prproj") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Photoshop_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".fla") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Flash_Professional_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".swf") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Flash_Professional_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".fw.png") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Fireworks_CS6_Icon
            ElseIf download.Label1.Text.EndsWith(".ai") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Illustrator_Icon__CS6__svg
            ElseIf download.Label1.Text.EndsWith(".zip") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".rar") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".001") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".7z") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".jar") Then
                download.PictureBox1.BackgroundImage = My.Resources.create_java_jar
            End If
        Else

        End If
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        If Not e.Name.EndsWith("crdownload") Then
            Dim download As New downloads
            download.Show()
            download.Label1.Text = e.Name
            download.Label2.Text = e.FullPath
            If download.Label1.Text.EndsWith(".exe") Then
                download.PictureBox1.BackgroundImage = My.Resources.Windows_11_executable_svg
            ElseIf download.Label1.Text.EndsWith(".png") Then
                download.PictureBox1.BackgroundImage = My.Resources.image_icon_153794
            ElseIf download.Label1.Text.EndsWith(".txt") Then
                download.PictureBox1.BackgroundImage = My.Resources.Text_txt_svg
            ElseIf download.Label1.Text.EndsWith(".docx") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Word_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".doc") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Word_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".xls") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Excel_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".xlsx") Then
                download.PictureBox1.BackgroundImage = My.Resources.Office_Excel_2007_logo_svg
            ElseIf download.Label1.Text.EndsWith(".ppt") Then
                download.PictureBox1.BackgroundImage = My.Resources.PowerPoint
            ElseIf download.Label1.Text.EndsWith(".pptx") Then
                download.PictureBox1.BackgroundImage = My.Resources.PowerPoint
            ElseIf download.Label1.Text.EndsWith(".pdf") Then
                download.PictureBox1.BackgroundImage = My.Resources.PDF_file_icon_svg
            ElseIf download.Label1.Text.EndsWith(".mp4") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mp3") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".wav") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mkv") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".flac") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".ogg") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".wave") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".avi") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".webm") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".mp2") Then
                download.PictureBox1.BackgroundImage = My.Resources.Video_Music
            ElseIf download.Label1.Text.EndsWith(".psd") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Photoshop_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".prproj") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Photoshop_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".fla") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Flash_Professional_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".swf") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Flash_Professional_CS6_icon
            ElseIf download.Label1.Text.EndsWith(".fw.png") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Fireworks_CS6_Icon
            ElseIf download.Label1.Text.EndsWith(".ai") Then
                download.PictureBox1.BackgroundImage = My.Resources.Adobe_Illustrator_Icon__CS6__svg
            ElseIf download.Label1.Text.EndsWith(".zip") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".rar") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".001") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".7z") Then
                download.PictureBox1.BackgroundImage = My.Resources._21764_256x256x32
            ElseIf download.Label1.Text.EndsWith(".jar") Then
                download.PictureBox1.BackgroundImage = My.Resources.create_java_jar
            End If
        Else

        End If
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim rolinha As Process() = Process.GetProcessesByName("saturnvpn")
        If rolinha.Length > 0 Then
            Dim line As String() = File.ReadAllLines("Guna.UI.dll")
            If line(0).Contains("false") Then
                File.WriteAllText("Guna.UI.dll", "true")
            Else
                File.WriteAllText("Guna.UI.dll", "false")
            End If
        Else
            File.WriteAllText("Guna.UI.dll", "true")
            Process.Start("SaturnVPN.exe")
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Shell("cmd.exe /c taskkill /f /im saturnvpn.exe", AppWinStyle.Hide)
        If File.Exists("updater.exe") Then
            Process.Start("updater.exe")
        End If
    End Sub
End Class
