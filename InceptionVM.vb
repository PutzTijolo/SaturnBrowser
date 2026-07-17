Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Threading
Imports WindowsInput
Public Class InceptionVM
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function


    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function MoveWindow(ByVal hWnd As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal bRepaint As Boolean) As Boolean
    End Function
    Dim qemuProcess As Process = New Process()
    Public sistema As String
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
    Private Async Sub InceptionVM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ThemeDark = True Then

        Else
            Me.BackColor = Color.White

            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
        End If

        Try


            If sistema = "windows" Then
                qemuProcess.StartInfo.FileName = "d:\qemu\qemu-system-i386.exe"
                qemuProcess.StartInfo.Arguments = "-m 1024 -cpu ""IvyBridge-v1"" -smp 1 -drive file=E:\7w\Windows7.vhd -boot c -netdev user,id=net0 -device rtl8139,netdev=net0"
            End If
            If sistema = "ubuntu" Then
                qemuProcess.StartInfo.FileName = "d:\qemu\qemu-system-i386.exe"
                qemuProcess.StartInfo.Arguments = "-m 1024 -cpu ""IvyBridge-v1"" -smp 1 -drive file=D:\linuq\Linuq\linuq.vhd -boot c -netdev user,id=net0 -device rtl8139,netdev=net0"
            End If
            If sistema = "win10" Then
                qemuProcess.StartInfo.FileName = "d:\qemu\qemu-system-i386.exe"
                qemuProcess.StartInfo.Arguments = "-m 2048 -cpu ""IvyBridge-v1"" -smp 2 -drive file=E:\Win10\Win10x32\Win10X32.vhd -boot c -netdev user,id=net0 -device rtl8139,netdev=net0"
            End If
            If sistema = "and44" Then
                qemuProcess.StartInfo.FileName = "d:\qemu\qemu-system-i386.exe"
                qemuProcess.StartInfo.Arguments = "-m 1024 -cpu ""IvyBridge-v1"" -smp 1 -drive file=E:\7w\Android.vhd -boot c -netdev user,id=net0 -device rtl8139,netdev=net0"
            End If
            If sistema = "macos" Then
                qemuProcess.StartInfo.FileName = "d:\qemu\qemu-system-ppc.exe"
                qemuProcess.StartInfo.Arguments = "-L pc-bios -boot c -M mac99 -m 2048 -hda D:\MacOS10\MacOS.vdi"
            End If


            qemuProcess.StartInfo.UseShellExecute = False
            qemuProcess.StartInfo.CreateNoWindow = True
            qemuProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized



            qemuProcess.Start()


            Await Task.Delay(100)


            Dim qemuHandle As IntPtr = WaitForMainWindowHandle(qemuProcess)
            If qemuHandle <> IntPtr.Zero Then

                SetParent(qemuHandle, Panel1.Handle)
                MoveWindow(qemuHandle, 0, 0, Panel1.Width, Panel1.Height, True)
            Else

            End If

            Dim sim As New WindowsInput.InputSimulator
            sim.Keyboard.KeyDown(Native.VirtualKeyCode.CONTROL)
            sim.Keyboard.KeyDown(Native.VirtualKeyCode.MENU)
            sim.Keyboard.KeyDown(Native.VirtualKeyCode.VK_M)
            Await Task.Delay(10)
            sim.Keyboard.KeyUp(Native.VirtualKeyCode.CONTROL)
            sim.Keyboard.KeyUp(Native.VirtualKeyCode.MENU)
            sim.Keyboard.KeyUp(Native.VirtualKeyCode.VK_M)

            Await Task.Delay(1000)
            SetParent(qemuHandle, Panel1.Handle)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If qemuProcess.HasExited Then
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

        Dim qemuHandle As IntPtr = WaitForMainWindowHandle(qemuProcess)
        If qemuHandle <> IntPtr.Zero Then


            MoveWindow(qemuHandle, 0, 0, Panel1.Width, Panel1.Height, True)
        Else

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InceptionVM_ControlRemoved(sender As Object, e As ControlEventArgs) Handles MyBase.ControlRemoved
        Try
            qemuProcess.Kill()
            qemuProcess.CloseMainWindow()
            qemuProcess.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
