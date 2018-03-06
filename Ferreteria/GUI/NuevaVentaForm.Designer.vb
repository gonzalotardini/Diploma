<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaVentaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaVentaForm))
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDescripcion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCodigo = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscarArticulo = New System.Windows.Forms.TextBox()
        Me.ArticuloGridView1 = New System.Windows.Forms.DataGridView()
        Me.PresupuestoGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RazonSocialLabel = New System.Windows.Forms.Label()
        Me.CodigoClienteLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinalizarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.BuscarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.labelPesos = New System.Windows.Forms.Label()
        Me.CreditoLabel = New System.Windows.Forms.Label()
        Me.codCreditoLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Acobrar = New System.Windows.Forms.Label()
        Me.AcobrarPrecio = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(902, 381)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 42)
        Me.TotalLabel.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(733, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 39)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "TOTAL $"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDescripcion)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 39)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDescripcion
        '
        Me.RadioButtonDescripcion.AutoSize = True
        Me.RadioButtonDescripcion.Location = New System.Drawing.Point(109, 13)
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
        Me.TextBoxBuscarArticulo.Location = New System.Drawing.Point(37, 394)
        Me.TextBoxBuscarArticulo.Name = "TextBoxBuscarArticulo"
        Me.TextBoxBuscarArticulo.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBuscarArticulo.TabIndex = 18
        '
        'ArticuloGridView1
        '
        Me.ArticuloGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ArticuloGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloGridView1.Location = New System.Drawing.Point(37, 435)
        Me.ArticuloGridView1.Name = "ArticuloGridView1"
        Me.ArticuloGridView1.ReadOnly = True
        Me.ArticuloGridView1.Size = New System.Drawing.Size(1055, 244)
        Me.ArticuloGridView1.TabIndex = 17
        '
        'PresupuestoGridView1
        '
        Me.PresupuestoGridView1.AllowUserToAddRows = False
        Me.PresupuestoGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.CodigoBarras, Me.Descripcion, Me.Marca, Me.UnidadMedida, Me.Precio, Me.Importe})
        Me.PresupuestoGridView1.Location = New System.Drawing.Point(37, 63)
        Me.PresupuestoGridView1.Name = "PresupuestoGridView1"
        Me.PresupuestoGridView1.Size = New System.Drawing.Size(1040, 309)
        Me.PresupuestoGridView1.TabIndex = 16
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'CodigoBarras
        '
        Me.CodigoBarras.HeaderText = "Codigo de Barras"
        Me.CodigoBarras.Name = "CodigoBarras"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'UnidadMedida
        '
        Me.UnidadMedida.HeaderText = "Unidad de Medida"
        Me.UnidadMedida.Name = "UnidadMedida"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'CuitLabel
        '
        Me.CuitLabel.AutoSize = True
        Me.CuitLabel.Location = New System.Drawing.Point(258, 36)
        Me.CuitLabel.Name = "CuitLabel"
        Me.CuitLabel.Size = New System.Drawing.Size(0, 13)
        Me.CuitLabel.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(180, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "CUIT: "
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Location = New System.Drawing.Point(561, 9)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(106, 13)
        Me.RazonSocialLabel.TabIndex = 30
        Me.RazonSocialLabel.Text = "GONZALO TARDINI"
        '
        'CodigoClienteLabel
        '
        Me.CodigoClienteLabel.AutoSize = True
        Me.CodigoClienteLabel.Location = New System.Drawing.Point(314, 9)
        Me.CodigoClienteLabel.Name = "CodigoClienteLabel"
        Me.CodigoClienteLabel.Size = New System.Drawing.Size(19, 13)
        Me.CodigoClienteLabel.TabIndex = 29
        Me.CodigoClienteLabel.Text = "16"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(439, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "RAZON SOCIAL: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(180, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CODIGO CLIENTE: "
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(950, 9)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(39, 13)
        Me.LabelFecha.TabIndex = 25
        Me.LabelFecha.Text = "Label4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(878, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "FECHA"
        '
        'FinalizarButton
        '
        Me.FinalizarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.FinalizarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.FinalizarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.FinalizarButton.FocusCuesEnabled = False
        Me.FinalizarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FinalizarButton.Image = CType(resources.GetObject("FinalizarButton.Image"), System.Drawing.Image)
        Me.FinalizarButton.Location = New System.Drawing.Point(1116, 300)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(171, 72)
        Me.FinalizarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FinalizarButton.TabIndex = 43
        Me.FinalizarButton.Text = "ButtonX2"
        Me.FinalizarButton.TextColor = System.Drawing.Color.White
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonX1.Image = Global.GUI.My.Resources.Resources.quitar1
        Me.ButtonX1.Location = New System.Drawing.Point(1116, 63)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(130, 50)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 44
        Me.ButtonX1.Text = "ButtonX1"
        '
        'BuscarButton
        '
        Me.BuscarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BuscarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.BuscarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.BuscarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarButton.Image = CType(resources.GetObject("BuscarButton.Image"), System.Drawing.Image)
        Me.BuscarButton.Location = New System.Drawing.Point(37, 9)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(110, 43)
        Me.BuscarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BuscarButton.TabIndex = 46
        Me.BuscarButton.Text = "BUSCAR"
        Me.BuscarButton.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Blue
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.Location = New System.Drawing.Point(1116, 171)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(80, 65)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 47
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'labelPesos
        '
        Me.labelPesos.AutoSize = True
        Me.labelPesos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labelPesos.Location = New System.Drawing.Point(1202, 217)
        Me.labelPesos.Name = "labelPesos"
        Me.labelPesos.Size = New System.Drawing.Size(17, 19)
        Me.labelPesos.TabIndex = 48
        Me.labelPesos.Text = "$"
        '
        'CreditoLabel
        '
        Me.CreditoLabel.AutoSize = True
        Me.CreditoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CreditoLabel.Location = New System.Drawing.Point(1216, 217)
        Me.CreditoLabel.Name = "CreditoLabel"
        Me.CreditoLabel.Size = New System.Drawing.Size(50, 19)
        Me.CreditoLabel.TabIndex = 49
        Me.CreditoLabel.Text = "Label6"
        '
        'codCreditoLabel
        '
        Me.codCreditoLabel.AutoSize = True
        Me.codCreditoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.codCreditoLabel.Location = New System.Drawing.Point(1202, 187)
        Me.codCreditoLabel.Name = "codCreditoLabel"
        Me.codCreditoLabel.Size = New System.Drawing.Size(46, 19)
        Me.codCreditoLabel.TabIndex = 50
        Me.codCreditoLabel.Text = "COD: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(1254, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Label6"
        '
        'Acobrar
        '
        Me.Acobrar.AutoSize = True
        Me.Acobrar.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Acobrar.Location = New System.Drawing.Point(1070, 388)
        Me.Acobrar.Name = "Acobrar"
        Me.Acobrar.Size = New System.Drawing.Size(126, 30)
        Me.Acobrar.TabIndex = 52
        Me.Acobrar.Text = "A COBRAR:"
        '
        'AcobrarPrecio
        '
        Me.AcobrarPrecio.AutoSize = True
        Me.AcobrarPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.AcobrarPrecio.Location = New System.Drawing.Point(1198, 388)
        Me.AcobrarPrecio.Name = "AcobrarPrecio"
        Me.AcobrarPrecio.Size = New System.Drawing.Size(78, 30)
        Me.AcobrarPrecio.TabIndex = 53
        Me.AcobrarPrecio.Text = "Label8"
        '
        'NuevaVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 691)
        Me.Controls.Add(Me.AcobrarPrecio)
        Me.Controls.Add(Me.Acobrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.codCreditoLabel)
        Me.Controls.Add(Me.CreditoLabel)
        Me.Controls.Add(Me.labelPesos)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.BuscarButton)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.CuitLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RazonSocialLabel)
        Me.Controls.Add(Me.CodigoClienteLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscarArticulo)
        Me.Controls.Add(Me.ArticuloGridView1)
        Me.Controls.Add(Me.PresupuestoGridView1)
        Me.DoubleBuffered = True
        Me.Name = "NuevaVentaForm"
        Me.Text = "NUEVA VENTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscarArticulo As System.Windows.Forms.TextBox
    Friend WithEvents ArticuloGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PresupuestoGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuitLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RazonSocialLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoClienteLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FinalizarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BuscarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents labelPesos As Label
    Friend WithEvents CreditoLabel As Label
    Friend WithEvents codCreditoLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Acobrar As Label
    Friend WithEvents AcobrarPrecio As Label
End Class
