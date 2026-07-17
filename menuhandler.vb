Imports CefSharp
Public Class menuhandler
    Implements IContextMenuHandler
    Implements ILifeSpanHandler

    Public Sub OnBeforeContextMenu(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame, parameters As IContextMenuParams, model As IMenuModel) Implements IContextMenuHandler.OnBeforeContextMenu
        Throw New NotImplementedException()
    End Sub

    Public Sub OnContextMenuDismissed(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame) Implements IContextMenuHandler.OnContextMenuDismissed
        Throw New NotImplementedException()
    End Sub

    Public Sub OnAfterCreated(chromiumWebBrowser As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnAfterCreated
        Throw New NotImplementedException()
    End Sub

    Public Sub OnBeforeClose(chromiumWebBrowser As IWebBrowser, browser As IBrowser) Implements ILifeSpanHandler.OnBeforeClose
        Throw New NotImplementedException()
    End Sub

    Public Function OnContextMenuCommand(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame, parameters As IContextMenuParams, commandId As CefMenuCommand, eventFlags As CefEventFlags) As Boolean Implements IContextMenuHandler.OnContextMenuCommand
        Throw New NotImplementedException()
    End Function

    Public Function RunContextMenu(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame, parameters As IContextMenuParams, model As IMenuModel, callback As IRunContextMenuCallback) As Boolean Implements IContextMenuHandler.RunContextMenu
        Throw New NotImplementedException()
    End Function

    Public Function OnBeforePopup(chromiumWebBrowser As IWebBrowser, browser As IBrowser, frame As IFrame, targetUrl As String, targetFrameName As String, targetDisposition As WindowOpenDisposition, userGesture As Boolean, popupFeatures As IPopupFeatures, windowInfo As IWindowInfo, browserSettings As IBrowserSettings, ByRef noJavascriptAccess As Boolean, ByRef newBrowser As IWebBrowser) As Boolean Implements ILifeSpanHandler.OnBeforePopup
        Throw New NotImplementedException()
        Return True

        Form1.tesete(1) = targetUrl
        Dim tab As New TabPage
        Dim WebView As New SaturnWebView
        WebView.AbaShow = tab


        WebView.Dock = DockStyle.Fill
        If My.Settings.ThemeDark = True Then
            tab.BackColor = Color.FromArgb(16, 16, 16)
        Else
            WebView.BackColor = Color.White
            tab.BackColor = Color.White
        End If

        tab.Controls.Add(WebView)

        Form1.Guna2TabControl1.TabPages.Add(tab)
        Form1.Guna2TabControl1.SelectedTab = tab
        Form1.Guna2Button9.Left += 180
        Form1.Guna2Button10.Left += 180
    End Function

    Public Function DoClose(chromiumWebBrowser As IWebBrowser, browser As IBrowser) As Boolean Implements ILifeSpanHandler.DoClose
        Throw New NotImplementedException()
    End Function
End Class
