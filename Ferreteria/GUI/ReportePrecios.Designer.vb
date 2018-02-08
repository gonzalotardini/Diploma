<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePrecios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ArticulosGridView = New System.Windows.Forms.DataGridView()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Precios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 36)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.AutoSize = True
        Me.RadioButtonDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(106, 14)
        Me.RadioButtonDESCRIPCION.Name = "RadioButtonDESCRIPCION"
        Me.RadioButtonDESCRIPCION.Size = New System.Drawing.Size(140, 22)
        Me.RadioButtonDESCRIPCION.TabIndex = 29
        Me.RadioButtonDESCRIPCION.TabStop = True
        Me.RadioButtonDESCRIPCION.Text = "DESCRIPCION"
        Me.RadioButtonDESCRIPCION.UseVisualStyleBackColor = True
        '
        'RadioButtonCODIGO
        '
        Me.RadioButtonCODIGO.AutoSize = True
        Me.RadioButtonCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCODIGO.Location = New System.Drawing.Point(4, 13)
        Me.RadioButtonCODIGO.Name = "RadioButtonCODIGO"
        Me.RadioButtonCODIGO.Size = New System.Drawing.Size(93, 22)
        Me.RadioButtonCODIGO.TabIndex = 28
        Me.RadioButtonCODIGO.TabStop = True
        Me.RadioButtonCODIGO.Text = "CODIGO"
        Me.RadioButtonCODIGO.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(37, 454)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxBuscar.TabIndex = 33
        '
        'ArticulosGridView
        '
        Me.ArticulosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosGridView.Location = New System.Drawing.Point(37, 494)
        Me.ArticulosGridView.Name = "ArticulosGridView"
        Me.ArticulosGridView.Size = New System.Drawing.Size(1130, 302)
        Me.ArticulosGridView.TabIndex = 32
        '
        'FechaDesde
        '
        Me.FechaDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDesde.Location = New System.Drawing.Point(38, 12)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(200, 20)
        Me.FechaDesde.TabIndex = 35
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(296, 12)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(200, 20)
        Me.FechaHasta.TabIndex = 36
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Marca, Me.UnidadMedida, Me.Precio_Inicial, Me.Precio_Final, Me.Cantidad_Precios, Me.Aumento, Me.Desde, Me.Hasta})
        Me.GridView1.Location = New System.Drawing.Point(37, 71)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.Size = New System.Drawing.Size(1040, 309)
        Me.GridView1.TabIndex = 37
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
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
        'Precio_Inicial
        '
        Me.Precio_Inicial.HeaderText = "Precio_Inicial"
        Me.Precio_Inicial.Name = "Precio_Inicial"
        '
        'Precio_Final
        '
        Me.Precio_Final.HeaderText = "Precio_Final"
        Me.Precio_Final.Name = "Precio_Final"
        '
        'Cantidad_Precios
        '
        Me.Cantidad_Precios.HeaderText = "Cantidad_Precios"
        Me.Cantidad_Precios.Name = "Cantidad_Precios"
        '
        'Aumento
        '
        Me.Aumento.HeaderText = "Aumento"
        Me.Aumento.Name = "Aumento"
        '
        'Desde
        '
        Me.Desde.HeaderText = "Desde"
        Me.Desde.Name = "Desde"
        '
        'Hasta
        '
        Me.Hasta.HeaderText = "Hasta"
        Me.Hasta.Name = "Hasta"
        '
        'ReportePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 865)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.FechaHasta)
        Me.Controls.Add(Me.FechaDesde)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ArticulosGridView)
        Me.DoubleBuffered = True
        Me.Name = "ReportePrecios"
        Me.Text = "ReportePrecios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ArticulosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ArticulosGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FechaDesde As DateTimePicker
    Friend WithEvents FechaHasta As DateTimePicker
    Friend WithEvents GridView1 As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedida As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Inicial As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Final As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Precios As DataGridViewTextBoxColumn
    Friend WithEvents Aumento As DataGridViewTextBoxColumn
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
End Class
