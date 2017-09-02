<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentDetalle
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
        Me.CodigoPresupuestoTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.CuitLabel = New System.Windows.Forms.Label()
        Me.CodigoClienteLabel = New System.Windows.Forms.Label()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.RazonSocialLabel = New System.Windows.Forms.Label()
        Me.PresupuestoGridView = New System.Windows.Forms.DataGridView()
        CType(Me.PresupuestoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoPresupuestoTextbox
        '
        Me.CodigoPresupuestoTextbox.Location = New System.Drawing.Point(961, 24)
        Me.CodigoPresupuestoTextbox.Name = "CodigoPresupuestoTextbox"
        Me.CodigoPresupuestoTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoPresupuestoTextbox.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(804, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "CODIGO PRESUPUESTO"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(821, 449)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(226, 73)
        Me.TotalLabel.TabIndex = 32
        Me.TotalLabel.Text = "Label1"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(605, 449)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(183, 55)
        Me.label.TabIndex = 31
        Me.label.Text = "TOTAL"
        '
        'FechaTextBox
        '
        Me.FechaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaTextBox.Location = New System.Drawing.Point(638, 31)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 13)
        Me.FechaTextBox.TabIndex = 30
        '
        'CuitTextBox
        '
        Me.CuitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CuitTextBox.Location = New System.Drawing.Point(361, 31)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(148, 13)
        Me.CuitTextBox.TabIndex = 29
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(164, 34)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(77, 13)
        Me.CodigoClienteTextBox.TabIndex = 28
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel.Location = New System.Drawing.Point(580, 34)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(47, 13)
        Me.FechaLabel.TabIndex = 27
        Me.FechaLabel.Text = "FECHA"
        '
        'CuitLabel
        '
        Me.CuitLabel.AutoSize = True
        Me.CuitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuitLabel.Location = New System.Drawing.Point(322, 34)
        Me.CuitLabel.Name = "CuitLabel"
        Me.CuitLabel.Size = New System.Drawing.Size(36, 13)
        Me.CuitLabel.TabIndex = 26
        Me.CuitLabel.Text = "CUIT"
        '
        'CodigoClienteLabel
        '
        Me.CodigoClienteLabel.AutoSize = True
        Me.CodigoClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoClienteLabel.Location = New System.Drawing.Point(26, 34)
        Me.CodigoClienteLabel.Name = "CodigoClienteLabel"
        Me.CodigoClienteLabel.Size = New System.Drawing.Size(132, 13)
        Me.CodigoClienteLabel.TabIndex = 25
        Me.CodigoClienteLabel.Text = "CODIGO DE CLIENTE"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(146, 65)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(149, 13)
        Me.RazonSocialTextBox.TabIndex = 24
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialLabel.Location = New System.Drawing.Point(30, 65)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(98, 13)
        Me.RazonSocialLabel.TabIndex = 23
        Me.RazonSocialLabel.Text = "RAZON SOCIAL"
        '
        'PresupuestoGridView
        '
        Me.PresupuestoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoGridView.Location = New System.Drawing.Point(29, 126)
        Me.PresupuestoGridView.Name = "PresupuestoGridView"
        Me.PresupuestoGridView.Size = New System.Drawing.Size(1030, 300)
        Me.PresupuestoGridView.TabIndex = 22
        '
        'VentDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 592)
        Me.Controls.Add(Me.CodigoPresupuestoTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(Me.CuitTextBox)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.CuitLabel)
        Me.Controls.Add(Me.CodigoClienteLabel)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.RazonSocialLabel)
        Me.Controls.Add(Me.PresupuestoGridView)
        Me.Name = "VentDetalle"
        Me.Text = "VentDetalle"
        CType(Me.PresupuestoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodigoPresupuestoTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents CuitLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoClienteLabel As System.Windows.Forms.Label
    Friend WithEvents RazonSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RazonSocialLabel As System.Windows.Forms.Label
    Friend WithEvents PresupuestoGridView As System.Windows.Forms.DataGridView
End Class
