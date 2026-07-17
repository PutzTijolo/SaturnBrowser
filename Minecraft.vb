Imports CmlLib
Imports System.Runtime.InteropServices
Imports System.Threading
Imports CmlLib.Core
Imports CmlLib.Core.ProcessBuilder
Imports CmlLib.Core.Auth
Public Class Minecraft
    Dim process As Process = New Process()
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function MoveWindow(ByVal hWnd As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal bRepaint As Boolean) As Boolean
    End Function

    Private Function WaitForMainWindowHandle(ByVal proc As Process, Optional ByVal maxIntent As Integer = 50) As IntPtr
        Dim hwnd As IntPtr = IntPtr.Zero
        Do
            hwnd = proc.MainWindowHandle
            If hwnd <> IntPtr.Zero Then
                Return hwnd
            End If
            Application.DoEvents()
            Thread.Sleep(25)
            maxIntent -= 1
        Loop While hwnd = IntPtr.Zero AndAlso maxIntent > 0
        Return hwnd
    End Function
    Private Async Sub Minecraft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ThemeDark = True Then

        Else
            Me.BackColor = Color.White

            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If

        Try
            Dim launcher = New MinecraftLauncher
            Dim abus = New MLaunchOption
            abus.Session = MSession.CreateOfflineSession("abustantan10")
            process = Await launcher.BuildProcessAsync("Saturn", abus)
            process.Start()

            Await Task.Delay(10)
            Dim qemuHandle As IntPtr = WaitForMainWindowHandle(process)
            If qemuHandle <> IntPtr.Zero Then

                SetParent(qemuHandle, Panel1.Handle)
                MoveWindow(qemuHandle, 0, 0, Panel1.Width, Panel1.Height, True)
            Else

            End If

            Await Task.Delay(1000)
            SetParent(qemuHandle, Panel1.Handle)
            MoveWindow(qemuHandle, 0, 0, Panel1.Width, Panel1.Height, True)
        Catch ex As Exception
            'MsgBox(ex)
        End Try



    End Sub

    Private Sub Minecraft_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            Dim qemuHandle As IntPtr = WaitForMainWindowHandle(process)
            MoveWindow(qemuHandle, 0, 0, Panel1.Width, Panel1.Height, True)
            SetParent(qemuHandle, Panel1.Handle)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If process.HasExited Then
                For Each ctrl As Control In Form1.Guna2TabControl1.SelectedTab.Controls

                    Form1.Guna2TabControl1.SelectedTab.Controls.Remove(ctrl)


                    ctrl.Dispose()
                Next

                Form1.Guna2TabControl1.TabPages.Remove(Form1.Guna2TabControl1.SelectedTab)

                Form1.Guna2Button9.Left -= 180
                Form1.Guna2Button10.Left -= 180
                If Form1.Guna2TabControl1.TabPages.Count < 1 Then
                    Application.Exit()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
