<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.VerDetalleButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CodigoClienteRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.VentasLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelarButton
        '
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton.Location = New System.Drawing.Point(594, 483)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(95, 45)
        Me.CancelarButton.TabIndex = 10
        Me.CancelarButton.Text = "CANCELAR"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'VerDetalleButton
        '
        Me.VerDetalleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerDetalleButton.Location = New System.Drawing.Point(175, 483)
        Me.VerDetalleButton.Name = "VerDetalleButton"
        Me.VerDetalleButton.Size = New System.Drawing.Size(107, 45)
        Me.VerDetalleButton.TabIndex = 9
        Me.VerDetalleButton.Text = "VER DETALLE"
        Me.VerDetalleButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RazonSocialRadioButton)
        Me.GroupBox1.Controls.Add(Me.CodigoClienteRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 41)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'RazonSocialRadioButton
        '
        Me.RazonSocialRadioButton.AutoSize = True
        Me.RazonSocialRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialRadioButton.Location = New System.Drawing.Point(144, 18)
        Me.RazonSocialRadioButton.Name = "RazonSocialRadioButton"
        Me.RazonSocialRadioButton.Size = New System.Drawing.Size(116, 17)
        Me.RazonSocialRadioButton.TabIndex = 1
        Me.RazonSocialRadioButton.TabStop = True
        Me.RazonSocialRadioButton.Text = "RAZON SOCIAL"
        Me.RazonSocialRadioButton.UseVisualStyleBackColor = True
        '
        'CodigoClienteRadioButton
        '
        Me.CodigoClienteRadioButton.AutoSize = True
        Me.CodigoClienteRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoClienteRadioButton.Location = New System.Drawing.Point(9, 18)
        Me.CodigoClienteRadioButton.Name = "CodigoClienteRadioButton"
        Me.CodigoClienteRadioButton.Size = New System.Drawing.Size(129, 17)
        Me.CodigoClienteRadioButton.TabIndex = 0
        Me.CodigoClienteRadioButton.TabStop = True
        Me.CodigoClienteRadioButton.Text = "CODIGO CLIENTE"
        Me.CodigoClienteRadioButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 7
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Location = New System.Drawing.Point(48, 108)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.ReadOnly = True
        Me.VentasDataGridView.Size = New System.Drawing.Size(841, 357)
        Me.VentasDataGridView.TabIndex = 6
        '
        'VentasLabel
        '
        Me.VentasLabel.AutoSize = True
        Me.VentasLabel.Location = New System.Drawing.Point(459, 21)
        Me.VentasLabel.Name = "VentasLabel"
        Me.VentasLabel.Size = New System.Drawing.Size(50, 13)
        Me.VentasLabel.TabIndex = 11
        Me.VentasLabel.Text = "VENTAS"
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 544)
        Me.Controls.Add(Me.VentasLabel)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.VerDetalleButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.DoubleBuffered = True
        Me.Name = "VentasForm"
        Me.Text = "VentasForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents VerDetalleButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RazonSocialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CodigoClienteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VentasLabel As Label
End Class
