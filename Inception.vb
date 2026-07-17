Public Class Inception
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "win7"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Dim tab As New TabPage
        Dim WebView As New InceptionVM
        WebView.sistema = "ubuntu"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "win10"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) 
        Guna2TabControl1.SelectedIndex = 1
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Guna2TabControl1.SelectedIndex = 2
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Guna2TabControl1.SelectedIndex = 3
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) 
        Guna2TabControl1.SelectedIndex = 4
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click, Guna2Button8.Click, Guna2Button6.Click, Guna2Button7.Click
        Guna2TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Inception_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Button5.Animated = True
        Guna2Button6.Animated = True
        Guna2Button7.Animated = True
        Guna2Button8.Animated = True
        ChromiumWebBrowser1.LoadUrl("https://saturnbrowser.app/ads/350x50/")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionVM
        WebView.sistema = "macos"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionVM
        WebView.sistema = "and44"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "ubuntu"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "mint"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub RunOnTheCloudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunOnTheCloudToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "win7"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub RunLocallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunLocallyToolStripMenuItem.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionVM
        WebView.sistema = "windows"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) 
        Guna2ContextMenuStrip1.Show()
        Guna2ContextMenuStrip1.Location = Cursor.Position
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "win8"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) 
        Guna2ContextMenuStrip2.Show()
        Guna2ContextMenuStrip2.Location = Cursor.Position
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionVM
        WebView.sistema = "win10"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "win10"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) 
        MsgBox("This VM is Only Available in Cloud!", MsgBoxStyle.Information)
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button19.Click, Guna2Button20.Click
        MsgBox("This VM is Only Available Locally!", MsgBoxStyle.Information)
    End Sub

    Private Sub Guna2TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button23_Click(sender As Object, e As EventArgs) 
        MsgBox("This VM is Only Available Locally!", MsgBoxStyle.Information)
    End Sub

    Private Sub Guna2Button24_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs) 
        MsgBox("This VM is Only Available in Cloud!", MsgBoxStyle.Information)
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) 
        ubuntuguna.Show()
        ubuntuguna.Location = Cursor.Position
    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs) Handles Guna2Button25.Click
        MsgBox("This VM is Only Available in the Backup Server!", MsgBoxStyle.Information)
    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs) Handles Guna2Button26.Click

    End Sub

    Private Sub Guna2Button30_Click(sender As Object, e As EventArgs) Handles Guna2Button30.Click
        Dim tab As New TabPage
        Dim WebView As New InceptionCloud
        WebView.sistema = "zorin"
        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)
        tab.Text = "Inception"
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Me.Close()
    End Sub
End Class