Imports WindowsInput
Public Class InceptionCloud
    Public sistema As String

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short
    End Function
    Function IsKeyPressed(ByVal key As Keys) As Boolean
        Return (GetAsyncKeyState(key) And &H8000) <> 0
    End Function
    Private Async Sub InceptionCloud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await Task.Delay(100)
        AxMsRdpClient8NotSafeForScripting1.Server = ("192.168.130.0")
        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.SmartSizing = True
        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.EnableWindowsKey = 1
        AxMsRdpClient8NotSafeForScripting1.DesktopWidth = Screen.PrimaryScreen.WorkingArea.Width
        AxMsRdpClient8NotSafeForScripting1.DesktopHeight = Screen.PrimaryScreen.WorkingArea.Height
        ' MsgBox(sistema)
        Try
            If sistema = "ubuntu" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1100
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1101
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1102
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try
            End If
            If sistema = "mint" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1500
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1501
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1502
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try

            End If
            If sistema = "win7" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 7000
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 7001
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 7002
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try

            End If

            If sistema = "win8" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 8000
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 8001
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 8002
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try
            End If

            If sistema = "win10" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1000
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1001
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1002
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try
            End If

            If sistema = "zorin" Then
                Try
                    AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1600
                    AxMsRdpClient8NotSafeForScripting1.Connect()
                Catch ex As Exception
                    Try
                        AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1600
                        AxMsRdpClient8NotSafeForScripting1.Connect()
                    Catch exs As Exception
                        Try
                            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort = 1602
                            AxMsRdpClient8NotSafeForScripting1.Connect()
                        Catch exe As Exception
                            MsgBox(exe.ToString + " " + exs.ToString + " " + ex.ToString)
                        End Try
                    End Try
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub AxMsRdpClient8NotSafeForScripting1_Enter(sender As Object, e As EventArgs) Handles AxMsRdpClient8NotSafeForScripting1.Enter

    End Sub

    Private Sub AxMsRdpClient8NotSafeForScripting1_Leave(sender As Object, e As EventArgs) Handles AxMsRdpClient8NotSafeForScripting1.Leave

    End Sub

    Private Sub AxMsRdpClient8NotSafeForScripting1_OnDisconnected(sender As Object, e As AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent) Handles AxMsRdpClient8NotSafeForScripting1.OnDisconnected
        If e.discReason.ToString = "2308" Then
            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort += 1
            AxMsRdpClient8NotSafeForScripting1.Connect()
        End If
        If e.discReason.ToString = "516" Then
            AxMsRdpClient8NotSafeForScripting1.AdvancedSettings7.RDPPort += 1
            AxMsRdpClient8NotSafeForScripting1.Connect()
        End If
        If e.discReason.ToString = "3" Then
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
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsKeyPressed(Keys.F12) Then
            Dim sim As New WindowsInput.InputSimulator
            sim.Keyboard.KeyDown(Native.VirtualKeyCode.VK_B)
            Await Task.Delay(10)
            sim.Keyboard.KeyUp(Native.VirtualKeyCode.VK_B)
            MsgBox("You can't use F12 at Clouds Machines!", MsgBoxStyle.Critical)
            Timer1.Stop()
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
    End Sub
End Class
