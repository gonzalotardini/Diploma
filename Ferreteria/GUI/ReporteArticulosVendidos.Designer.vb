<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArticulosVendidos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CantidadInput = New DevComponents.Editors.IntegerInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.VentasLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(105, 153)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(942, 277)
        Me.DataGridViewX1.TabIndex = 0
        '
        'CantidadInput
        '
        '
        '
        '
        Me.CantidadInput.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.CantidadInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CantidadInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.CantidadInput.Location = New System.Drawing.Point(654, 97)
        Me.CantidadInput.Name = "CantidadInput"
        Me.CantidadInput.ShowUpDown = True
        Me.CantidadInput.Size = New System.Drawing.Size(49, 20)
        Me.CantidadInput.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(837, 84)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(107, 45)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "ButtonX1"
        '
        'FechaDesde
        '
        Me.FechaDesde.Location = New System.Drawing.Point(105, 97)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.FechaDesde.TabIndex = 3
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(374, 97)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.FechaHasta.TabIndex = 4
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.OrangeRed
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX2.Location = New System.Drawing.Point(467, 460)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(199, 37)
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.Text = "ButtonX2"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'VentasLabel
        '
        Me.VentasLabel.AutoSize = True
        Me.VentasLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.VentasLabel.Location = New System.Drawing.Point(435, 9)
        Me.VentasLabel.Name = "VentasLabel"
        Me.VentasLabel.Size = New System.Drawing.Size(170, 65)
        Me.VentasLabel.TabIndex = 12
        Me.VentasLabel.Text = "LABEL"
        '
        'ReporteArticulosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 483)
        Me.Controls.Add(Me.VentasLabel)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.FechaHasta)
        Me.Controls.Add(Me.FechaDesde)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.CantidadInput)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.DoubleBuffered = True
        Me.Name = "ReporteArticulosVendidos"
        Me.Text = "ReporteArticulosVendidos"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents CantidadInput As DevComponents.Editors.IntegerInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents VentasLabel As Label
End Class
