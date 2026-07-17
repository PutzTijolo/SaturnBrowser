<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InceptionCloud
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InceptionCloud))
        Me.AxMsRdpClient11NotSafeForScripting1 = New AxMSTSCLib.AxMsRdpClient11NotSafeForScripting()
        Me.AxMsRdpClient11NotSafeForScripting2 = New AxMSTSCLib.AxMsRdpClient11NotSafeForScripting()
        Me.AxMsRdpClient111 = New AxMSTSCLib.AxMsRdpClient11()
        Me.AxMsRdpClient8NotSafeForScripting1 = New AxMSTSCLib.AxMsRdpClient8NotSafeForScripting()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxMsRdpClient11NotSafeForScripting1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMsRdpClient11NotSafeForScripting2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMsRdpClient111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxMsRdpClient8NotSafeForScripting1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxMsRdpClient11NotSafeForScripting1
        '
        Me.AxMsRdpClient11NotSafeForScripting1.Enabled = True
        Me.AxMsRdpClient11NotSafeForScripting1.Location = New System.Drawing.Point(0, 0)
        Me.AxMsRdpClient11NotSafeForScripting1.Name = "AxMsRdpClient11NotSafeForScripting1"
        Me.AxMsRdpClient11NotSafeForScripting1.TabIndex = 0
        '
        'AxMsRdpClient11NotSafeForScripting2
        '
        Me.AxMsRdpClient11NotSafeForScripting2.Enabled = True
        Me.AxMsRdpClient11NotSafeForScripting2.Location = New System.Drawing.Point(0, 0)
        Me.AxMsRdpClient11NotSafeForScripting2.Name = "AxMsRdpClient11NotSafeForScripting2"
        Me.AxMsRdpClient11NotSafeForScripting2.TabIndex = 0
        '
        'AxMsRdpClient111
        '
        Me.AxMsRdpClient111.Enabled = True
        Me.AxMsRdpClient111.Location = New System.Drawing.Point(0, 0)
        Me.AxMsRdpClient111.Name = "AxMsRdpClient111"
        Me.AxMsRdpClient111.TabIndex = 0
        '
        'AxMsRdpClient8NotSafeForScripting1
        '
        Me.AxMsRdpClient8NotSafeForScripting1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxMsRdpClient8NotSafeForScripting1.Enabled = True
        Me.AxMsRdpClient8NotSafeForScripting1.Location = New System.Drawing.Point(0, 0)
        Me.AxMsRdpClient8NotSafeForScripting1.Name = "AxMsRdpClient8NotSafeForScripting1"
        Me.AxMsRdpClient8NotSafeForScripting1.OcxState = CType(resources.GetObject("AxMsRdpClient8NotSafeForScripting1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMsRdpClient8NotSafeForScripting1.Size = New System.Drawing.Size(690, 419)
        Me.AxMsRdpClient8NotSafeForScripting1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'InceptionCloud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Controls.Add(Me.AxMsRdpClient8NotSafeForScripting1)
        Me.Name = "InceptionCloud"
        Me.Size = New System.Drawing.Size(690, 419)
        CType(Me.AxMsRdpClient11NotSafeForScripting1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMsRdpClient11NotSafeForScripting2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMsRdpClient111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxMsRdpClient8NotSafeForScripting1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxMsRdpClient11NotSafeForScripting1 As AxMSTSCLib.AxMsRdpClient11NotSafeForScripting
    Friend WithEvents AxMsRdpClient11NotSafeForScripting2 As AxMSTSCLib.AxMsRdpClient11NotSafeForScripting
    Friend WithEvents AxMsRdpClient111 As AxMSTSCLib.AxMsRdpClient11
    Friend WithEvents AxMsRdpClient8NotSafeForScripting1 As AxMSTSCLib.AxMsRdpClient8NotSafeForScripting
    Friend WithEvents Timer1 As Timer
End Class
