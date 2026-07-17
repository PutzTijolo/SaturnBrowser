Imports System.IO
Public Class History
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        File.WriteAllText("libIE.dll", "")
        ListBox1.Items.Clear()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each link As String In File.ReadAllLines("libIE.dll")
            If link.Contains("Saturn/") Then

            Else
                ListBox1.Items.Add(link.ToString)
            End If
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
