Public Class downloads
    Private Sub FileSystemWatcher1_Created(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created

    End Sub

    Private Sub downloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim areaTrabalho As Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim posicaoX As Integer = areaTrabalho.Width - Me.Width
        Dim posicaoY As Integer = areaTrabalho.Height - Me.Height
        Me.Location = New Point(posicaoX, posicaoY)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Process.Start("C:\Users\" & SystemInformation.UserName & "\Downloads\")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Close()
    End Sub

    Private Sub downloads_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub downloads_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Timer1.Stop()
    End Sub

    Private Sub downloads_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Timer1.Start()
    End Sub
End Class