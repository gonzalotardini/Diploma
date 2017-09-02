<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoPresupuestoForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoPresupuestoForm))
        Me.PresupuestoGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticuloGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxBuscarArticulo = New System.Windows.Forms.TextBox()
        Me.RadioButtonCodigo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDescripcion = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuitarTodoButton = New System.Windows.Forms.Button()
        Me.FinalizarButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CodigoClienteLabel = New System.Windows.Forms.Label()
        Me.RazonSocialLabel = New System.Windows.Forms.Label()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.QuitarButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CuitLabel = New System.Windows.Forms.Label()
        CType(Me.PresupuestoGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PresupuestoGridView1
        '
        Me.PresupuestoGridView1.AllowUserToAddRows = False
        Me.PresupuestoGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestoGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Codigo, Me.CodigoBarras, Me.Descripcion, Me.Marca, Me.UnidadMedida, Me.Precio, Me.Importe})
        Me.PresupuestoGridView1.Location = New System.Drawing.Point(26, 61)
        Me.PresupuestoGridView1.Name = "PresupuestoGridView1"
        Me.PresupuestoGridView1.Size = New System.Drawing.Size(1040, 309)
        Me.PresupuestoGridView1.TabIndex = 0
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
        'ArticuloGridView1
        '
        Me.ArticuloGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloGridView1.Location = New System.Drawing.Point(26, 437)
        Me.ArticuloGridView1.Name = "ArticuloGridView1"
        Me.ArticuloGridView1.ReadOnly = True
        Me.ArticuloGridView1.Size = New System.Drawing.Size(1055, 244)
        Me.ArticuloGridView1.TabIndex = 1
        '
        'TextBoxBuscarArticulo
        '
        Me.TextBoxBuscarArticulo.Location = New System.Drawing.Point(26, 395)
        Me.TextBoxBuscarArticulo.Name = "TextBoxBuscarArticulo"
        Me.TextBoxBuscarArticulo.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxBuscarArticulo.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDescripcion)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 39)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(881, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FECHA"
        '
        'QuitarTodoButton
        '
        Me.QuitarTodoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarTodoButton.Location = New System.Drawing.Point(1217, 61)
        Me.QuitarTodoButton.Name = "QuitarTodoButton"
        Me.QuitarTodoButton.Size = New System.Drawing.Size(87, 46)
        Me.QuitarTodoButton.TabIndex = 10
        Me.QuitarTodoButton.Text = "QUITAR TODO"
        Me.QuitarTodoButton.UseVisualStyleBackColor = True
        '
        'FinalizarButton
        '
        Me.FinalizarButton.Image = CType(resources.GetObject("FinalizarButton.Image"), System.Drawing.Image)
        Me.FinalizarButton.Location = New System.Drawing.Point(1081, 269)
        Me.FinalizarButton.Name = "FinalizarButton"
        Me.FinalizarButton.Size = New System.Drawing.Size(149, 72)
        Me.FinalizarButton.TabIndex = 11
        Me.FinalizarButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(790, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 39)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "TOTAL $"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(971, 389)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 39)
        Me.TotalLabel.TabIndex = 13
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Location = New System.Drawing.Point(946, 9)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(39, 13)
        Me.LabelFecha.TabIndex = 16
        Me.LabelFecha.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CODIGO CLIENTE: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(323, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "RAZON SOCIAL: "
        '
        'CodigoClienteLabel
        '
        Me.CodigoClienteLabel.AutoSize = True
        Me.CodigoClienteLabel.Location = New System.Drawing.Point(264, 12)
        Me.CodigoClienteLabel.Name = "CodigoClienteLabel"
        Me.CodigoClienteLabel.Size = New System.Drawing.Size(0, 13)
        Me.CodigoClienteLabel.TabIndex = 20
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Location = New System.Drawing.Point(421, 12)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(0, 13)
        Me.RazonSocialLabel.TabIndex = 21
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirButton.Image = Global.GUI.My.Resources.Resources.Imprimir
        Me.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ImprimirButton.Location = New System.Drawing.Point(1081, 146)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(107, 44)
        Me.ImprimirButton.TabIndex = 15
        Me.ImprimirButton.Text = "IMPRIMIR"
        Me.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'QuitarButton
        '
        Me.QuitarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarButton.Image = Global.GUI.My.Resources.Resources.quitar
        Me.QuitarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitarButton.Location = New System.Drawing.Point(1081, 61)
        Me.QuitarButton.Name = "QuitarButton"
        Me.QuitarButton.Size = New System.Drawing.Size(107, 46)
        Me.QuitarButton.TabIndex = 9
        Me.QuitarButton.Text = "QUITAR"
        Me.QuitarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QuitarButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "CUIT: "
        '
        'CuitLabel
        '
        Me.CuitLabel.AutoSize = True
        Me.CuitLabel.Location = New System.Drawing.Point(374, 39)
        Me.CuitLabel.Name = "CuitLabel"
        Me.CuitLabel.Size = New System.Drawing.Size(0, 13)
        Me.CuitLabel.TabIndex = 23
        '
        'NuevoPresupuestoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.CuitLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RazonSocialLabel)
        Me.Controls.Add(Me.CodigoClienteLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FinalizarButton)
        Me.Controls.Add(Me.QuitarTodoButton)
        Me.Controls.Add(Me.QuitarButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscarArticulo)
        Me.Controls.Add(Me.ArticuloGridView1)
        Me.Controls.Add(Me.PresupuestoGridView1)
        Me.Name = "NuevoPresupuestoForm"
        Me.Text = "NUEVO PRESUPUESTO"
        CType(Me.PresupuestoGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PresupuestoGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ArticuloGridView1 As DataGridView
    Friend WithEvents TextBoxBuscarArticulo As TextBox
    Friend WithEvents RadioButtonCodigo As RadioButton
    Friend WithEvents RadioButtonDescripcion As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QuitarButton As Button
    Friend WithEvents QuitarTodoButton As Button
    Friend WithEvents FinalizarButton As Button
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarras As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents ImprimirButton As Button
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CodigoClienteLabel As Label
    Friend WithEvents RazonSocialLabel As Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CuitLabel As System.Windows.Forms.Label
End Class
