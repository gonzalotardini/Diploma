<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articuloss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Articuloss))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CANTIDADDEARTICULOS = New System.Windows.Forms.Label()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.BUSCAR = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.MODIFICAR = New System.Windows.Forms.Button()
        Me.TextBoxCodProveedor = New System.Windows.Forms.TextBox()
        Me.CODBARRAS = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ARTICULOS = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.ComboSubCategoria = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.MARCA = New System.Windows.Forms.Label()
        Me.SUBCATEGORIA = New System.Windows.Forms.Label()
        Me.CATEGORIA = New System.Windows.Forms.Label()
        Me.ComboCategoria = New System.Windows.Forms.ComboBox()
        Me.PRECIO = New System.Windows.Forms.Label()
        Me.Combo_SubUnidad = New System.Windows.Forms.ComboBox()
        Me.SUBUNIDADDEMEDIDA = New System.Windows.Forms.Label()
        Me.Combo_UniddMedida = New System.Windows.Forms.ComboBox()
        Me.UNIDADDEMEDIDA = New System.Windows.Forms.Label()
        Me.DESCRIPCION = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(869, 688)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Label14"
        '
        'CANTIDADDEARTICULOS
        '
        Me.CANTIDADDEARTICULOS.AutoSize = True
        Me.CANTIDADDEARTICULOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTIDADDEARTICULOS.Location = New System.Drawing.Point(843, 652)
        Me.CANTIDADDEARTICULOS.Name = "CANTIDADDEARTICULOS"
        Me.CANTIDADDEARTICULOS.Size = New System.Drawing.Size(91, 26)
        Me.CANTIDADDEARTICULOS.TabIndex = 97
        Me.CANTIDADDEARTICULOS.Text = "CANTIDAD DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ARTICULOS"
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(733, 121)
        Me.RadioButtonDESCRIPCION.Name = "RadioButtonDESCRIPCION"
        Me.RadioButtonDESCRIPCION.Size = New System.Drawing.Size(98, 17)
        Me.RadioButtonDESCRIPCION.TabIndex = 95
        Me.RadioButtonDESCRIPCION.TabStop = True
        Me.RadioButtonDESCRIPCION.Text = "DESCRIPCION"
        Me.RadioButtonDESCRIPCION.UseVisualStyleBackColor = True
        '
        'RadioButtonCODIGO
        '
        Me.RadioButtonCODIGO.Location = New System.Drawing.Point(640, 121)
        Me.RadioButtonCODIGO.Name = "RadioButtonCODIGO"
        Me.RadioButtonCODIGO.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonCODIGO.TabIndex = 94
        Me.RadioButtonCODIGO.TabStop = True
        Me.RadioButtonCODIGO.Text = "CODIGO"
        Me.RadioButtonCODIGO.UseVisualStyleBackColor = True
        '
        'BUSCAR
        '
        Me.BUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCAR.Location = New System.Drawing.Point(331, 128)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(65, 13)
        Me.BUSCAR.TabIndex = 93
        Me.BUSCAR.Text = "BUSCAR: "
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(411, 121)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(209, 22)
        Me.TextBoxBuscar.TabIndex = 67
        '
        'MODIFICAR
        '
        Me.MODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFICAR.Location = New System.Drawing.Point(207, 650)
        Me.MODIFICAR.Name = "MODIFICAR"
        Me.MODIFICAR.Size = New System.Drawing.Size(133, 39)
        Me.MODIFICAR.TabIndex = 91
        Me.MODIFICAR.Text = "MODIFICAR"
        Me.MODIFICAR.UseVisualStyleBackColor = True
        '
        'TextBoxCodProveedor
        '
        Me.TextBoxCodProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodProveedor.Location = New System.Drawing.Point(11, 36)
        Me.TextBoxCodProveedor.Name = "TextBoxCodProveedor"
        Me.TextBoxCodProveedor.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxCodProveedor.TabIndex = 68
        '
        'CODBARRAS
        '
        Me.CODBARRAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODBARRAS.Location = New System.Drawing.Point(12, 20)
        Me.CODBARRAS.Name = "CODBARRAS"
        Me.CODBARRAS.Size = New System.Drawing.Size(87, 13)
        Me.CODBARRAS.TabIndex = 90
        Me.CODBARRAS.Text = "COD BARRAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(145, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = ","
        '
        'ARTICULOS
        '
        Me.ARTICULOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARTICULOS.Location = New System.Drawing.Point(380, 20)
        Me.ARTICULOS.Name = "ARTICULOS"
        Me.ARTICULOS.Size = New System.Drawing.Size(240, 42)
        Me.ARTICULOS.TabIndex = 87
        Me.ARTICULOS.Text = "ARTÍCULOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "$"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(156, 223)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 20)
        Me.TextBox3.TabIndex = 76
        '
        'ComboMarca
        '
        Me.ComboMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(12, 378)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(161, 21)
        Me.ComboMarca.TabIndex = 80
        '
        'ComboSubCategoria
        '
        Me.ComboSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSubCategoria.FormattingEnabled = True
        Me.ComboSubCategoria.Location = New System.Drawing.Point(12, 326)
        Me.ComboSubCategoria.Name = "ComboSubCategoria"
        Me.ComboSubCategoria.Size = New System.Drawing.Size(151, 21)
        Me.ComboSubCategoria.TabIndex = 79
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecio.Location = New System.Drawing.Point(92, 223)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(51, 20)
        Me.TextBoxPrecio.TabIndex = 74
        '
        'MARCA
        '
        Me.MARCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MARCA.Location = New System.Drawing.Point(16, 362)
        Me.MARCA.Name = "MARCA"
        Me.MARCA.Size = New System.Drawing.Size(50, 13)
        Me.MARCA.TabIndex = 84
        Me.MARCA.Text = "MARCA"
        '
        'SUBCATEGORIA
        '
        Me.SUBCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBCATEGORIA.Location = New System.Drawing.Point(12, 309)
        Me.SUBCATEGORIA.Name = "SUBCATEGORIA"
        Me.SUBCATEGORIA.Size = New System.Drawing.Size(107, 13)
        Me.SUBCATEGORIA.TabIndex = 83
        Me.SUBCATEGORIA.Text = "SUB CATEGORÍA"
        '
        'CATEGORIA
        '
        Me.CATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATEGORIA.Location = New System.Drawing.Point(14, 257)
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.Size = New System.Drawing.Size(78, 13)
        Me.CATEGORIA.TabIndex = 82
        Me.CATEGORIA.Text = "CATEGORÍA"
        '
        'ComboCategoria
        '
        Me.ComboCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCategoria.FormattingEnabled = True
        Me.ComboCategoria.Location = New System.Drawing.Point(12, 274)
        Me.ComboCategoria.Name = "ComboCategoria"
        Me.ComboCategoria.Size = New System.Drawing.Size(151, 21)
        Me.ComboCategoria.TabIndex = 77
        '
        'PRECIO
        '
        Me.PRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIO.Location = New System.Drawing.Point(13, 226)
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Size = New System.Drawing.Size(53, 13)
        Me.PRECIO.TabIndex = 78
        Me.PRECIO.Text = "PRECIO"
        '
        'Combo_SubUnidad
        '
        Me.Combo_SubUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_SubUnidad.FormattingEnabled = True
        Me.Combo_SubUnidad.Location = New System.Drawing.Point(12, 190)
        Me.Combo_SubUnidad.Name = "Combo_SubUnidad"
        Me.Combo_SubUnidad.Size = New System.Drawing.Size(138, 21)
        Me.Combo_SubUnidad.TabIndex = 73
        '
        'SUBUNIDADDEMEDIDA
        '
        Me.SUBUNIDADDEMEDIDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBUNIDADDEMEDIDA.Location = New System.Drawing.Point(12, 174)
        Me.SUBUNIDADDEMEDIDA.Name = "SUBUNIDADDEMEDIDA"
        Me.SUBUNIDADDEMEDIDA.Size = New System.Drawing.Size(157, 13)
        Me.SUBUNIDADDEMEDIDA.TabIndex = 75
        Me.SUBUNIDADDEMEDIDA.Text = "SUB UNIDAD DE MEDIDA"
        '
        'Combo_UniddMedida
        '
        Me.Combo_UniddMedida.DisplayMember = "Cod_Unidad_Medida"
        Me.Combo_UniddMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_UniddMedida.FormattingEnabled = True
        Me.Combo_UniddMedida.Location = New System.Drawing.Point(11, 137)
        Me.Combo_UniddMedida.Name = "Combo_UniddMedida"
        Me.Combo_UniddMedida.Size = New System.Drawing.Size(138, 21)
        Me.Combo_UniddMedida.TabIndex = 71
        Me.Combo_UniddMedida.ValueMember = "Cod_Unidad_Medida"
        '
        'UNIDADDEMEDIDA
        '
        Me.UNIDADDEMEDIDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNIDADDEMEDIDA.Location = New System.Drawing.Point(12, 120)
        Me.UNIDADDEMEDIDA.Name = "UNIDADDEMEDIDA"
        Me.UNIDADDEMEDIDA.Size = New System.Drawing.Size(128, 13)
        Me.UNIDADDEMEDIDA.TabIndex = 72
        Me.UNIDADDEMEDIDA.Text = "UNIDAD DE MEDIDA"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCION.Location = New System.Drawing.Point(12, 70)
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Size = New System.Drawing.Size(91, 13)
        Me.DESCRIPCION.TabIndex = 70
        Me.DESCRIPCION.Text = "DESCRIPCIÓN"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(11, 86)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(214, 20)
        Me.TextBoxDescripcion.TabIndex = 69
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(207, 149)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1173, 495)
        Me.DataGridView1.TabIndex = 92
        '
        'EliminarButton
        '
        Me.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarButton.Image = Global.GUI.My.Resources.Resources.delete1
        Me.EliminarButton.Location = New System.Drawing.Point(733, 652)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(58, 61)
        Me.EliminarButton.TabIndex = 99
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(675, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GUI.My.Resources.Resources.aceptar1
        Me.Button1.Location = New System.Drawing.Point(11, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 131)
        Me.Button1.TabIndex = 88
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Articuloss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 733)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CANTIDADDEARTICULOS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButtonDESCRIPCION)
        Me.Controls.Add(Me.RadioButtonCODIGO)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.MODIFICAR)
        Me.Controls.Add(Me.TextBoxCodProveedor)
        Me.Controls.Add(Me.CODBARRAS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ARTICULOS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboMarca)
        Me.Controls.Add(Me.ComboSubCategoria)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.MARCA)
        Me.Controls.Add(Me.SUBCATEGORIA)
        Me.Controls.Add(Me.CATEGORIA)
        Me.Controls.Add(Me.ComboCategoria)
        Me.Controls.Add(Me.PRECIO)
        Me.Controls.Add(Me.Combo_SubUnidad)
        Me.Controls.Add(Me.SUBUNIDADDEMEDIDA)
        Me.Controls.Add(Me.Combo_UniddMedida)
        Me.Controls.Add(Me.UNIDADDEMEDIDA)
        Me.Controls.Add(Me.DESCRIPCION)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Articuloss"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EliminarButton As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CANTIDADDEARTICULOS As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButtonDESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents BUSCAR As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents MODIFICAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxCodProveedor As System.Windows.Forms.TextBox
    Friend WithEvents CODBARRAS As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ARTICULOS As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents MARCA As System.Windows.Forms.Label
    Friend WithEvents SUBCATEGORIA As System.Windows.Forms.Label
    Friend WithEvents CATEGORIA As System.Windows.Forms.Label
    Friend WithEvents ComboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents PRECIO As System.Windows.Forms.Label
    Friend WithEvents Combo_SubUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents SUBUNIDADDEMEDIDA As System.Windows.Forms.Label
    Friend WithEvents Combo_UniddMedida As System.Windows.Forms.ComboBox
    Friend WithEvents UNIDADDEMEDIDA As System.Windows.Forms.Label
    Friend WithEvents DESCRIPCION As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
