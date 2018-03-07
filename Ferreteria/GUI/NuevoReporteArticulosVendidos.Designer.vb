<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoReporteArticulosVendidos
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CantidadInput = New DevComponents.Editors.IntegerInput()
        Me.GenerarButton = New DevComponents.DotNetBar.ButtonX()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.FinalizarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ReporteArticulosLabel = New System.Windows.Forms.Label()
        Me.LabelHasta = New DevComponents.DotNetBar.LabelX()
        Me.LabelDesde = New DevComponents.DotNetBar.LabelX()
        Me.CantidadLabel = New DevComponents.DotNetBar.LabelX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(160, 209)
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
        Me.CantidadInput.Location = New System.Drawing.Point(709, 153)
        Me.CantidadInput.Name = "CantidadInput"
        Me.CantidadInput.ShowUpDown = True
        Me.CantidadInput.Size = New System.Drawing.Size(57, 20)
        Me.CantidadInput.TabIndex = 1
        '
        'GenerarButton
        '
        Me.GenerarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.GenerarButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.GenerarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.GenerarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GenerarButton.Location = New System.Drawing.Point(892, 140)
        Me.GenerarButton.Name = "GenerarButton"
        Me.GenerarButton.Size = New System.Drawing.Size(107, 45)
        Me.GenerarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GenerarButton.TabIndex = 2
        Me.GenerarButton.Text = "GENERAR"
        Me.GenerarButton.TextColor = System.Drawing.Color.White
        '
        'FechaDesde
        '
        Me.FechaDesde.Location = New System.Drawing.Point(160, 153)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.FechaDesde.TabIndex = 3
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(429, 153)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.FechaHasta.TabIndex = 4
        '
        'FinalizarButton
        '
        Me.FinalizarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.FinalizarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.FinalizarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.FinalizarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FinalizarButton.Location = New System.Drawing.Point(522, 516)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(199, 37)
        Me.FinalizarButton.TabIndex = 5
        Me.FinalizarButton.Text = "ButtonX2"
        Me.FinalizarButton.TextColor = System.Drawing.Color.White
        '
        'ReporteArticulosLabel
        '
        Me.ReporteArticulosLabel.AutoSize = True
        Me.ReporteArticulosLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ReporteArticulosLabel.Location = New System.Drawing.Point(493, 19)
        Me.ReporteArticulosLabel.Name = "ReporteArticulosLabel"
        Me.ReporteArticulosLabel.Size = New System.Drawing.Size(170, 65)
        Me.ReporteArticulosLabel.TabIndex = 12
        Me.ReporteArticulosLabel.Text = "LABEL"
        '
        'LabelHasta
        '
        '
        '
        '
        Me.LabelHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelHasta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHasta.Location = New System.Drawing.Point(463, 123)
        Me.LabelHasta.Name = "LabelHasta"
        Me.LabelHasta.Size = New System.Drawing.Size(75, 23)
        Me.LabelHasta.TabIndex = 46
        Me.LabelHasta.Text = "LabelX2"
        '
        'LabelDesde
        '
        '
        '
        '
        Me.LabelDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelDesde.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDesde.Location = New System.Drawing.Point(206, 124)
        Me.LabelDesde.Name = "LabelDesde"
        Me.LabelDesde.Size = New System.Drawing.Size(75, 23)
        Me.LabelDesde.TabIndex = 45
        Me.LabelDesde.Text = "LabelX1"
        '
        'CantidadLabel
        '
        '
        '
        '
        Me.CantidadLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CantidadLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CantidadLabel.Location = New System.Drawing.Point(691, 124)
        Me.CantidadLabel.Name = "CantidadLabel"
        Me.CantidadLabel.Size = New System.Drawing.Size(87, 23)
        Me.CantidadLabel.TabIndex = 47
        Me.CantidadLabel.Text = "LabelX2"
        '
        'NuevoReporteArticulosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 483)
        Me.Controls.Add(Me.CantidadLabel)
        Me.Controls.Add(Me.LabelHasta)
        Me.Controls.Add(Me.LabelDesde)
        Me.Controls.Add(Me.ReporteArticulosLabel)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.FechaHasta)
        Me.Controls.Add(Me.FechaDesde)
        Me.Controls.Add(Me.GenerarButton)
        Me.Controls.Add(Me.CantidadInput)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.DoubleBuffered = True
        Me.Name = "NuevoReporteArticulosVendidos"
        Me.Text = "ReporteArticulosVendidos"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents CantidadInput As DevComponents.Editors.IntegerInput
    Friend WithEvents GenerarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents FinalizarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ReporteArticulosLabel As Label
    Private WithEvents LabelHasta As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelDesde As DevComponents.DotNetBar.LabelX
    Private WithEvents CantidadLabel As DevComponents.DotNetBar.LabelX
End Class
