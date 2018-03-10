<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonReportePrecios = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonReporteArticulos = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonReportePrecios
        '
        Me.ButtonReportePrecios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonReportePrecios.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonReportePrecios.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonReportePrecios.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonReportePrecios.Location = New System.Drawing.Point(249, 210)
        Me.ButtonReportePrecios.Name = "ButtonReportePrecios"
        Me.ButtonReportePrecios.Size = New System.Drawing.Size(255, 203)
        Me.ButtonReportePrecios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonReportePrecios.TabIndex = 0
        Me.ButtonReportePrecios.Text = "ButtonX1"
        '
        'ButtonReporteArticulos
        '
        Me.ButtonReporteArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonReporteArticulos.BackColor = System.Drawing.Color.DarkOrange
        Me.ButtonReporteArticulos.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonReporteArticulos.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonReporteArticulos.Location = New System.Drawing.Point(703, 210)
        Me.ButtonReporteArticulos.Name = "ButtonReporteArticulos"
        Me.ButtonReporteArticulos.Size = New System.Drawing.Size(251, 203)
        Me.ButtonReporteArticulos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonReporteArticulos.TabIndex = 1
        Me.ButtonReporteArticulos.Text = "ButtonX2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(561, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 65)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "label"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 436)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReporteArticulos)
        Me.Controls.Add(Me.ButtonReportePrecios)
        Me.DoubleBuffered = True
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonReportePrecios As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonReporteArticulos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As Label
End Class
