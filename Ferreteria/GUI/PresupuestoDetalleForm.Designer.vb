<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoDetalleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresupuestoDetalleForm))
        Me.PresupuestoGridView = New System.Windows.Forms.DataGridView()
        Me.RazonSocialLabel = New System.Windows.Forms.Label()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoClienteLabel = New System.Windows.Forms.Label()
        Me.CuitLabel = New System.Windows.Forms.Label()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ModificarButton = New System.Windows.Forms.Button()
        Me.ArticuloGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDescripcion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCodigo = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscarArticulo = New System.Windows.Forms.TextBox()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.FinalizarButton = New System.Windows.Forms.Button()
        Me.QuitarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoPresupuestoTextbox = New System.Windows.Forms.TextBox()
        CType(Me.PresupuestoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PresupuestoGridView
        '
        Me.PresupuestoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoGridView.Location = New System.Drawing.Point(26, 106)
        Me.PresupuestoGridView.Name = "PresupuestoGridView"
        Me.PresupuestoGridView.Size = New System.Drawing.Size(1030, 300)
        Me.PresupuestoGridView.TabIndex = 0
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialLabel.Location = New System.Drawing.Point(23, 44)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(98, 13)
        Me.RazonSocialLabel.TabIndex = 1
        Me.RazonSocialLabel.Text = "RAZON SOCIAL"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(139, 44)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(149, 13)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'CodigoClienteLabel
        '
        Me.CodigoClienteLabel.AutoSize = True
        Me.CodigoClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoClienteLabel.Location = New System.Drawing.Point(19, 13)
        Me.CodigoClienteLabel.Name = "CodigoClienteLabel"
        Me.CodigoClienteLabel.Size = New System.Drawing.Size(132, 13)
        Me.CodigoClienteLabel.TabIndex = 3
        Me.CodigoClienteLabel.Text = "CODIGO DE CLIENTE"
        '
        'CuitLabel
        '
        Me.CuitLabel.AutoSize = True
        Me.CuitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuitLabel.Location = New System.Drawing.Point(315, 13)
        Me.CuitLabel.Name = "CuitLabel"
        Me.CuitLabel.Size = New System.Drawing.Size(36, 13)
        Me.CuitLabel.TabIndex = 4
        Me.CuitLabel.Text = "CUIT"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel.Location = New System.Drawing.Point(573, 13)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(47, 13)
        Me.FechaLabel.TabIndex = 5
        Me.FechaLabel.Text = "FECHA"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(157, 13)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(77, 13)
        Me.CodigoClienteTextBox.TabIndex = 6
        '
        'CuitTextBox
        '
        Me.CuitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CuitTextBox.Location = New System.Drawing.Point(354, 10)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(148, 13)
        Me.CuitTextBox.TabIndex = 7
        '
        'FechaTextBox
        '
        Me.FechaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaTextBox.Location = New System.Drawing.Point(631, 10)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 13)
        Me.FechaTextBox.TabIndex = 8
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(630, 429)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(183, 55)
        Me.label.TabIndex = 9
        Me.label.Text = "TOTAL"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(846, 429)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(226, 73)
        Me.TotalLabel.TabIndex = 10
        Me.TotalLabel.Text = "Label1"
        '
        'ModificarButton
        '
        Me.ModificarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.Location = New System.Drawing.Point(127, 447)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(86, 55)
        Me.ModificarButton.TabIndex = 11
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.UseVisualStyleBackColor = True
        '
        'ArticuloGridView1
        '
        Me.ArticuloGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloGridView1.Location = New System.Drawing.Point(26, 585)
        Me.ArticuloGridView1.Name = "ArticuloGridView1"
        Me.ArticuloGridView1.ReadOnly = True
        Me.ArticuloGridView1.Size = New System.Drawing.Size(1055, 244)
        Me.ArticuloGridView1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDescripcion)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 536)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 39)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDescripcion
        '
        Me.RadioButtonDescripcion.AutoSize = True
        Me.RadioButtonDescripcion.Location = New System.Drawing.Point(134, 13)
        Me.RadioButtonDescripcion.Name = "RadioButtonDescripcion"
        Me.RadioButtonDescripcion.Size = New System.Drawing.Size(98, 17)
        Me.RadioButtonDescripcion.TabIndex = 4
        Me.RadioButtonDescripcion.TabStop = True
        Me.RadioButtonDescripcion.Text = "DESCRIPCION"
        Me.RadioButtonDescripcion.UseVisualStyleBackColor = True
        '
        'RadioButtonCodigo
        '
        Me.RadioButtonCodigo.AutoSize = True
        Me.RadioButtonCodigo.Location = New System.Drawing.Point(25, 13)
        Me.RadioButtonCodigo.Name = "RadioButtonCodigo"
        Me.RadioButtonCodigo.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonCodigo.TabIndex = 3
        Me.RadioButtonCodigo.TabStop = True
        Me.RadioButtonCodigo.Text = "CODIGO"
        Me.RadioButtonCodigo.UseVisualStyleBackColor = True
        '
        'TextBoxBuscarArticulo
        '
        Me.TextBoxBuscarArticulo.Location = New System.Drawing.Point(26, 542)
        Me.TextBoxBuscarArticulo.Name = "TextBoxBuscarArticulo"
        Me.TextBoxBuscarArticulo.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBuscarArticulo.TabIndex = 13
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirButton.Image = Global.GUI.My.Resources.Resources.Imprimir
        Me.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ImprimirButton.Location = New System.Drawing.Point(1100, 209)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(107, 44)
        Me.ImprimirButton.TabIndex = 19
        Me.ImprimirButton.Text = "IMPRIMIR"
        Me.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'FinalizarButton
        '
        Me.FinalizarButton.Image = CType(resources.GetObject("FinalizarButton.Image"), System.Drawing.Image)
        Me.FinalizarButton.Location = New System.Drawing.Point(1083, 334)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(149, 72)
        Me.FinalizarButton.TabIndex = 18
        Me.FinalizarButton.UseVisualStyleBackColor = True
        '
        'QuitarButton
        '
        Me.QuitarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarButton.Image = Global.GUI.My.Resources.Resources.quitar
        Me.QuitarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarButton.Location = New System.Drawing.Point(1100, 106)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(107, 46)
        Me.QuitarButton.TabIndex = 16
        Me.QuitarButton.Text = "QUITAR"
        Me.QuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(797, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "CODIGO PRESUPUESTO"
        '
        'CodigoPresupuestoTextbox
        '
        Me.CodigoPresupuestoTextbox.Location = New System.Drawing.Point(954, 3)
        Me.CodigoPresupuestoTextbox.Name = "CodigoPresupuestoTextbox"
        Me.CodigoPresupuestoTextbox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoPresupuestoTextbox.TabIndex = 21
        '
        'PresupuestoDetalleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 912)
        Me.Controls.Add(Me.CodigoPresupuestoTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.QuitarButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscarArticulo)
        Me.Controls.Add(Me.ArticuloGridView1)
        Me.Controls.Add(Me.ModificarButton)
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
        Me.Name = "PresupuestoDetalleForm"
        Me.Text = "DETALLE PRESUPUESTO"
        CType(Me.PresupuestoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PresupuestoGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RazonSocialLabel As System.Windows.Forms.Label
    Friend WithEvents RazonSocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoClienteLabel As System.Windows.Forms.Label
    Friend WithEvents CuitLabel As System.Windows.Forms.Label
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents ModificarButton As System.Windows.Forms.Button
    Friend WithEvents ArticuloGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscarArticulo As System.Windows.Forms.TextBox
    Friend WithEvents ImprimirButton As System.Windows.Forms.Button
    Friend WithEvents FinalizarButton As System.Windows.Forms.Button
    Friend WithEvents QuitarButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CodigoPresupuestoTextbox As System.Windows.Forms.TextBox
End Class
