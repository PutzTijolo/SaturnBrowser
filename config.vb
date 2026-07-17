Public Class config
    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.language = "BR" Then
            Label5.Text = "Pagina Inicial:"
            Label4.Text = "Mecanismo de Busca:"
            Label1.Text = "Linguagem do Navegador:"
            BunifuDropdown1.selectedIndex = 0
        End If
        If My.Settings.language = "ES" Then
            Label5.Text = "Pagina Principal:"
            Label4.Text = "Motor de búsqueda:"
            Label1.Text = "Idioma del navegador:"
            BunifuDropdown1.selectedIndex = 2
        End If
        If My.Settings.ThemeDark = True Then
            Me.BackColor = Color.FromArgb(16, 16, 16)
            Me.ForeColor = Color.White
            ListView1.ForeColor = Color.White
            ListView1.BackColor = Color.FromArgb(16, 16, 16)
            ListView2.ForeColor = Color.White
            ListView2.BackColor = Color.FromArgb(16, 16, 16)
            Label3.ForeColor = Color.White
            Label2.ForeColor = Color.White
            TabPage1.BackColor = Color.FromArgb(16, 16, 16)
            TabPage2.BackColor = Color.FromArgb(16, 16, 16)

            TabPage4.BackColor = Color.FromArgb(16, 16, 16)
            TabPage5.BackColor = Color.FromArgb(16, 16, 16)
        Else

            Me.BackColor = Color.White
            Me.ForeColor = Color.Black
            TabPage1.BackColor = Color.White
            TabPage2.BackColor = Color.White

            TabPage4.BackColor = Color.White
            TabPage5.BackColor = Color.White
        End If
    End Sub

    Private Sub BunifuDropdown3_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown3.onItemSelected
        If BunifuDropdown3.selectedIndex = 0 Then

            BunifuDropdown2.Show()
            Label4.Show()

        Else
            BunifuDropdown2.Hide()
            Label4.Hide()
        End If

        If BunifuDropdown3.selectedIndex = 1 Then
            My.Settings.home = "google"
        End If
        If BunifuDropdown3.selectedIndex = 2 Then
            My.Settings.home = "duckduck"
        End If
        If BunifuDropdown3.selectedIndex = 3 Then
            My.Settings.home = "bing"
        End If
        If BunifuDropdown3.selectedIndex = 4 Then
            My.Settings.home = "yahoo"
        End If
        If BunifuDropdown3.selectedIndex = 5 Then
            Panel1.Show()
        Else
            Panel1.Hide()
        End If
    End Sub

    Private Sub BunifuDropdown2_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown2.onItemSelected
        If BunifuDropdown2.selectedIndex = 0 Then
            My.Settings.home = "hgoogle"

        End If
        If BunifuDropdown2.selectedIndex = 1 Then
            My.Settings.home = "hduckduckgo"
        End If
        If BunifuDropdown2.selectedIndex = 2 Then
            My.Settings.home = "hbing"
        End If
        If BunifuDropdown2.selectedIndex = 3 Then
            My.Settings.home = "hyahoo"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.home = TextBox1.Text
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown1.onItemSelected
        If BunifuDropdown1.selectedIndex = 0 Then
            My.Settings.language = "BR"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            My.Settings.language = "US"
        End If
        If BunifuDropdown1.selectedIndex = 2 Then
            My.Settings.language = "ES"
        End If
    End Sub
End Class
