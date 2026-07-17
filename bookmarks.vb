Imports System.IO
Public Class bookmarks
    Private Sub bookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each link As String In File.ReadAllLines("libGecko.dll")
            If link.Contains("Saturn/") Then

            Else
                ListBox1.Items.Add(link.ToString)
            End If
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        File.WriteAllText("libGecko.dll", "")
        ListBox1.Items.Clear()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        'File.WriteAllText.Replace("libGecko.dll", ListBox1.Items.ToString)
    End Sub
End Class
