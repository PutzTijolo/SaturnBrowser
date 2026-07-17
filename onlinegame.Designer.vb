<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class onlinegame
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.game = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.SuspendLayout()
        '
        'game
        '
        Me.game.ActivateBrowserOnCreation = False
        Me.game.Dock = System.Windows.Forms.DockStyle.Fill
        Me.game.Location = New System.Drawing.Point(0, 0)
        Me.game.Name = "game"
        Me.game.Size = New System.Drawing.Size(612, 369)
        Me.game.TabIndex = 0
        '
        'onlinegame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.game)
        Me.Name = "onlinegame"
        Me.Size = New System.Drawing.Size(612, 369)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents game As CefSharp.WinForms.ChromiumWebBrowser
End Class
