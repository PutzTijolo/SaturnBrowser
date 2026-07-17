Public Class appearence


    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        My.Settings.ThemeDark = False
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        My.Settings.ThemeDark = True
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        My.Settings.color = "blue"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        My.Settings.color = "aqua"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        My.Settings.color = "gold"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton6_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton6.Click
        My.Settings.color = "orange"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton7_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton7.Click
        My.Settings.color = "red"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton8_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton8.Click
        My.Settings.color = "pink"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton9_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton9.Click
        My.Settings.color = "purple"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton10_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton10.Click
        My.Settings.color = "green"
        My.Settings.Save()
    End Sub

    Private Sub Guna2CircleButton11_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton11.Click
        My.Settings.color = "lime"
        My.Settings.Save()
    End Sub

    Private Sub appearence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.language = "BR" Then
            Label4.Text = "Temas"
            Label1.Text = "Cor"
        End If
        If My.Settings.language = "ES" Then
            Label4.Text = "Temas"
            Label1.Text = "Color"
        End If
    End Sub
End Class