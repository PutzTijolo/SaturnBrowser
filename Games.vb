
Imports System.IO
Imports System.Net

Public Class Games
    Dim download As New Net.WebClient
    Dim exedownload As New Net.WebClient

    Private Sub exeiniciaDonwload(ByVal arquivo As String, ByVal destino As String)
        Try
            Panel1.Hide()
            BunifuCircleProgressbar1.Visible = True
            Dim uriorigem As New Uri(arquivo)
            exedownload.DownloadFileAsync(uriorigem, destino)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub exeDownloadCompleto(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Shell("cmd.exe /c 7za.exe x -y C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\Net.7z -o""%temp%"" ")
        iniciaDonwload("https://incandescent-praline-e3931b.netlify.app/Happy-Wheels.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub
    Private Sub iniciaDonwload(ByVal arquivo As String, ByVal destino As String)
        Try
            Panel1.Hide()
            BunifuCircleProgressbar1.Visible = True
            Dim uriorigem As New Uri(arquivo)
            download.DownloadFileAsync(uriorigem, destino)
        Catch ex As Exception

        End Try
    End Sub
    Private Async Sub DownloadCompleto(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim tab As New TabPage
        Dim originaldate = Date.Now.ToString("dd-MM-yy")
        Shell("cmd.exe /c net stop w32time", AppWinStyle.Hide, True)
        Shell("cmd.exe /c date 10-10-20", AppWinStyle.Hide, True)
        Await Task.Delay(1000)
        Dim WebView As New game

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Form1.Guna2TabControl1.TabPages.Add(tab)


        Form1.Guna2TabControl1.TabPages.Remove(Form1.Guna2TabControl1.SelectedTab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2TabControl1.SelectedTab.Text = "Games"
        WebView.AxShockwaveFlash1.Movie = "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf"
        WebView.AxShockwaveFlash1.Play()
        Await Task.Delay(3000)
        Shell("cmd.exe /c date " & originaldate, AppWinStyle.Hide, True)
        Shell("cmd.exe /c net start w32time", AppWinStyle.Hide, True)

    End Sub

    Private Sub Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ThemeDark = True Then

        Else
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If
        AddHandler download.DownloadFileCompleted, AddressOf DownloadCompleto
        AddHandler exedownload.DownloadFileCompleted, AddressOf exeDownloadCompleto
        ChromiumWebBrowser1.LoadUrl("https://saturnbrowser.app/ads/728x90/")

        If My.Settings.language = "BR" Then
            Label1.Text = "Jogos"
        End If
        If My.Settings.language = "ES" Then
            Label1.Text = "Juegos"
        End If
    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox10.Click
        exeiniciaDonwload("https://incandescent-praline-e3931b.netlify.app/Happy%20Wheels.7z", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\Net.7z")
    End Sub

    Private Async Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/breaking-the-bank.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")

    End Sub

    Private Sub Guna2PictureBox11_Click(sender As Object, e As EventArgs)
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/escapingtheprisongame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/escapingtheprisongame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/infiltratingtheairshipgame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs)
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/infiltratingtheairshipgame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/stealingthediamondgame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        iniciaDonwload("https://archive.org/download/fleeingthecomplexgame_202507/fleeingthecomplexgame.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        iniciaDonwload("http://incandescent-praline-e3931b.netlify.app/angry-birds-chrome.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox14.Click
        iniciaDonwload("http://incandescent-praline-e3931b.netlify.app/Obey%20The%20Game.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox9.Click
        iniciaDonwload("https://archive.org/download/flight_202107/flight.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox7_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        iniciaDonwload("https://archive.org/download/flash-games_20210127/worlds_hardest_game_2.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox11_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox11.Click
        iniciaDonwload("http://incandescent-praline-e3931b.netlify.app/Bad_Piggies.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        Dim tab As New TabPage
        Dim WebView As New Minecraft

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Form1.Guna2TabControl1.TabPages.Add(tab)


        Form1.Guna2TabControl1.TabPages.Remove(Form1.Guna2TabControl1.SelectedTab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2TabControl1.SelectedTab.Text = "Games"
    End Sub

    Private Sub Guna2PictureBox13_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox13.Click
        iniciaDonwload("http://incandescent-praline-e3931b.netlify.app/Flappy-Bird.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox16_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox16.Click
        iniciaDonwload("http://incandescent-praline-e3931b.netlify.app/Learn%20To%20Fly.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox5_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        iniciaDonwload("https://incandescent-praline-e3931b.netlify.app/Learn_To_Fly_2.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox15_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox15.Click
        iniciaDonwload("https://incandescent-praline-e3931b.netlify.app/Learn-To-Fly-3.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox17_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox17.Click
        iniciaDonwload("https://archive.org/download/flash-games_20210127/ducklife4.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox18_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox18.Click
        iniciaDonwload("https://archive.org/download/flash-games_20211214/bloons_tower_defense_5.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox19_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox19.Click
        iniciaDonwload("https://archive.org/download/flash-games_20211214/Doodle%20Jump.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox20_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox20.Click
        iniciaDonwload("https://archive.org/download/flash-games_20211214/trollface-quest-1.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox21_Click(sender As Object, e As EventArgs)
        iniciaDonwload("https://archive.org/download/flash-games_20211214/trollface-quest-2.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox22_Click(sender As Object, e As EventArgs)
        iniciaDonwload("https://archive.org/download/flash-games_20211214/trollface-quest-3.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox23_Click(sender As Object, e As EventArgs)
        iniciaDonwload("https://archive.org/download/flash-games_20211214/tetris-2008.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox24_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox24.Click
        iniciaDonwload("https://archive.org/download/flash-games_20211214/pac-man.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox25_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox25.Click
        iniciaDonwload("https://www.genioquiz.com.br/wp-content/jogos/genio-quiz-1.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox21_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox21.Click
        iniciaDonwload("https://archive.org/download/flash-games_20211214/bloons_tower_defense_4.swf", "C:\Users\" & SystemInformation.UserName & "\Appdata\Local\Temp\game.swf")
    End Sub

    Private Sub Guna2PictureBox22_Click_1(sender As Object, e As EventArgs)
        Dim tab As New TabPage
        Dim WebView As New onlinegame

        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Form1.Guna2TabControl1.TabPages.Add(tab)


        Form1.Guna2TabControl1.TabPages.Remove(Form1.Guna2TabControl1.SelectedTab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2TabControl1.SelectedTab.Text = "Games"
        WebView.game.Load("https://8c68f477-6c9a-4245-a0c0-f4000563c1f7.gdn.poki.com/861deeab-2990-4532-a55e-d00191d8e55f/index.html?country=BR&ccpaApplies=0&url_referrer=https%3A%2F%2Fpoki.com%2F&tag=pg-f5a5e6998c01edcba6512e01639fd3bd25f89758&site_id=71&iso_lang=pt-br&poki_url=https%3A%2F%2Fpoki.com%2Fbr%2Fg%2Ftalking-tom-gold-run&hoist=yes&nonPersonalized=n&cloudsavegames=n&familyFriendly=n&device=desktop&categories=6%2C9%2C93%2C145%2C903%2C1141%2C1190&game_id=8c68f477-6c9a-4245-a0c0-f4000563c1f7&game_version_id=861deeab-2990-4532-a55e-d00191d8e55f&inspector=0&csp=1")
    End Sub
End Class
