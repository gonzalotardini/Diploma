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
        Me.ButtonReporteVentas = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'ButtonReportePrecios
        '
        Me.ButtonReportePrecios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonReportePrecios.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonReportePrecios.Location = New System.Drawing.Point(147, 95)
        Me.ButtonReportePrecios.Name = "ButtonReportePrecios"
        Me.ButtonReportePrecios.Size = New System.Drawing.Size(255, 203)
        Me.ButtonReportePrecios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonReportePrecios.TabIndex = 0
        Me.ButtonReportePrecios.Text = "ButtonX1"
        '
        'ButtonReporteArticulos
        '
        Me.ButtonReporteArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonReporteArticulos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonReporteArticulos.Location = New System.Drawing.Point(437, 95)
        Me.ButtonReporteArticulos.Name = "ButtonReporteArticulos"
        Me.ButtonReporteArticulos.Size = New System.Drawing.Size(251, 203)
        Me.ButtonReporteArticulos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonReporteArticulos.TabIndex = 1
        Me.ButtonReporteArticulos.Text = "ButtonX2"
        '
        'ButtonReporteVentas
        '
        Me.ButtonReporteVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonReporteVentas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonReporteVentas.Location = New System.Drawing.Point(708, 95)
        Me.ButtonReporteVentas.Name = "ButtonReporteVentas"
        Me.ButtonReporteVentas.Size = New System.Drawing.Size(234, 203)
        Me.ButtonReporteVentas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonReporteVentas.TabIndex = 2
        Me.ButtonReporteVentas.Text = "ButtonX3"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 436)
        Me.Controls.Add(Me.ButtonReporteVentas)
        Me.Controls.Add(Me.ButtonReporteArticulos)
        Me.Controls.Add(Me.ButtonReportePrecios)
        Me.DoubleBuffered = True
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonReportePrecios As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonReporteArticulos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonReporteVentas As DevComponents.DotNetBar.ButtonX
End Class
