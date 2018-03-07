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
        Me.ArticuloGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDescripcion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCodigo = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscarArticulo = New System.Windows.Forms.TextBox()
        Me.CodigoPresupuestoLabel = New System.Windows.Forms.Label()
        Me.CodigoPresupuestoTextbox = New System.Windows.Forms.Label()
        Me.ModificarButton = New DevComponents.DotNetBar.ButtonX()
        Me.QuitarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ImprimirButton = New DevComponents.DotNetBar.ButtonX()
        Me.FinalizarButton = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PresupuestoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PresupuestoGridView
        '
        Me.PresupuestoGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PresupuestoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoGridView.Location = New System.Drawing.Point(12, 63)
        Me.PresupuestoGridView.Name = "PresupuestoGridView"
        Me.PresupuestoGridView.Size = New System.Drawing.Size(1030, 300)
        Me.PresupuestoGridView.TabIndex = 0
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RazonSocialLabel.Location = New System.Drawing.Point(22, 38)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(109, 19)
        Me.RazonSocialLabel.TabIndex = 1
        Me.RazonSocialLabel.Text = "RAZON SOCIAL"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(137, 41)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(149, 13)
        Me.RazonSocialTextBox.TabIndex = 2
        '
        'CodigoClienteLabel
        '
        Me.CodigoClienteLabel.AutoSize = True
        Me.CodigoClienteLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CodigoClienteLabel.Location = New System.Drawing.Point(22, -1)
        Me.CodigoClienteLabel.Name = "CodigoClienteLabel"
        Me.CodigoClienteLabel.Size = New System.Drawing.Size(142, 19)
        Me.CodigoClienteLabel.TabIndex = 3
        Me.CodigoClienteLabel.Text = "CODIGO DE CLIENTE"
        '
        'CuitLabel
        '
        Me.CuitLabel.AutoSize = True
        Me.CuitLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CuitLabel.Location = New System.Drawing.Point(315, 2)
        Me.CuitLabel.Name = "CuitLabel"
        Me.CuitLabel.Size = New System.Drawing.Size(40, 19)
        Me.CuitLabel.TabIndex = 4
        Me.CuitLabel.Text = "CUIT"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FechaLabel.Location = New System.Drawing.Point(573, 2)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(51, 19)
        Me.FechaLabel.TabIndex = 5
        Me.FechaLabel.Text = "FECHA"
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(180, 5)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(77, 13)
        Me.CodigoClienteTextBox.TabIndex = 6
        Me.CodigoClienteTextBox.Text = "AAAA"
        '
        'CuitTextBox
        '
        Me.CuitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CuitTextBox.Location = New System.Drawing.Point(361, 5)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(148, 13)
        Me.CuitTextBox.TabIndex = 7
        Me.CuitTextBox.Text = "22222222"
        '
        'FechaTextBox
        '
        Me.FechaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaTextBox.Location = New System.Drawing.Point(630, 5)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 13)
        Me.FechaTextBox.TabIndex = 8
        Me.FechaTextBox.Text = "14114"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(600, 366)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(183, 55)
        Me.label.TabIndex = 9
        Me.label.Text = "TOTAL"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(816, 366)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(226, 73)
        Me.TotalLabel.TabIndex = 10
        Me.TotalLabel.Text = "Label1"
        '
        'ArticuloGridView1
        '
        Me.ArticuloGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ArticuloGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ArticuloGridView1.Location = New System.Drawing.Point(12, 446)
        Me.ArticuloGridView1.Name = "ArticuloGridView1"
        Me.ArticuloGridView1.ReadOnly = True
        Me.ArticuloGridView1.Size = New System.Drawing.Size(1030, 244)
        Me.ArticuloGridView1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDescripcion)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 401)
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
        Me.TextBoxBuscarArticulo.Location = New System.Drawing.Point(12, 420)
        Me.TextBoxBuscarArticulo.Name = "TextBoxBuscarArticulo"
        Me.TextBoxBuscarArticulo.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBuscarArticulo.TabIndex = 13
        '
        'CodigoPresupuestoLabel
        '
        Me.CodigoPresupuestoLabel.AutoSize = True
        Me.CodigoPresupuestoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CodigoPresupuestoLabel.Location = New System.Drawing.Point(797, -2)
        Me.CodigoPresupuestoLabel.Name = "CodigoPresupuestoLabel"
        Me.CodigoPresupuestoLabel.Size = New System.Drawing.Size(161, 19)
        Me.CodigoPresupuestoLabel.TabIndex = 20
        Me.CodigoPresupuestoLabel.Text = "CODIGO PRESUPUESTO"
        '
        'CodigoPresupuestoTextbox
        '
        Me.CodigoPresupuestoTextbox.AutoSize = True
        Me.CodigoPresupuestoTextbox.Location = New System.Drawing.Point(951, 2)
        Me.CodigoPresupuestoTextbox.Name = "CodigoPresupuestoTextbox"
        Me.CodigoPresupuestoTextbox.Size = New System.Drawing.Size(39, 13)
        Me.CodigoPresupuestoTextbox.TabIndex = 22
        Me.CodigoPresupuestoTextbox.Text = "Label2"
        '
        'ModificarButton
        '
        Me.ModificarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ModificarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.ModificarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ModificarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.Image = CType(resources.GetObject("ModificarButton.Image"), System.Drawing.Image)
        Me.ModificarButton.Location = New System.Drawing.Point(26, 369)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(146, 45)
        Me.ModificarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ModificarButton.TabIndex = 104
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.TextColor = System.Drawing.Color.White
        '
        'QuitarButton
        '
        Me.QuitarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.QuitarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.QuitarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.QuitarButton.Image = Global.GUI.My.Resources.Resources.quitar1
        Me.QuitarButton.Location = New System.Drawing.Point(1067, 63)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(118, 50)
        Me.QuitarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.QuitarButton.TabIndex = 105
        Me.QuitarButton.Text = "ButtonX1"
        '
        'ImprimirButton
        '
        Me.ImprimirButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ImprimirButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ImprimirButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ImprimirButton.Image = Global.GUI.My.Resources.Resources.Imprimir1
        Me.ImprimirButton.Location = New System.Drawing.Point(1067, 136)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(118, 45)
        Me.ImprimirButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ImprimirButton.TabIndex = 106
        Me.ImprimirButton.Text = "ButtonX1"
        '
        'FinalizarButton
        '
        Me.FinalizarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.FinalizarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.FinalizarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.FinalizarButton.FocusCuesEnabled = False
        Me.FinalizarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FinalizarButton.Image = CType(resources.GetObject("FinalizarButton.Image"), System.Drawing.Image)
        Me.FinalizarButton.Location = New System.Drawing.Point(1067, 291)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(171, 72)
        Me.FinalizarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FinalizarButton.TabIndex = 107
        Me.FinalizarButton.Text = "ButtonX2"
        Me.FinalizarButton.TextColor = System.Drawing.Color.White
        '
        'PresupuestoDetalleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.QuitarButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.CodigoPresupuestoTextbox)
        Me.Controls.Add(Me.CodigoPresupuestoLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscarArticulo)
        Me.Controls.Add(Me.ArticuloGridView1)
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
        Me.DoubleBuffered = True
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
    Friend WithEvents ArticuloGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscarArticulo As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPresupuestoLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoPresupuestoTextbox As Label
    Friend WithEvents ModificarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents QuitarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImprimirButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents FinalizarButton As DevComponents.DotNetBar.ButtonX
End Class
