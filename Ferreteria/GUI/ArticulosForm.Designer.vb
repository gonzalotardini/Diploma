<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArticulosForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosForm))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CANTIDADDEARTICULOS = New System.Windows.Forms.Label()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.BUSCAR = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.MODIFICAR = New System.Windows.Forms.Button()
        Me.TextBoxCodProveedor = New System.Windows.Forms.TextBox()
        Me.ARTICULOSlbl = New System.Windows.Forms.Label()
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
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CODBARRAS = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1159, 900)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Label14"
        '
        'CANTIDADDEARTICULOS
        '
        Me.CANTIDADDEARTICULOS.AutoSize = True
        Me.CANTIDADDEARTICULOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTIDADDEARTICULOS.Location = New System.Drawing.Point(1124, 853)
        Me.CANTIDADDEARTICULOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CANTIDADDEARTICULOS.Name = "CANTIDADDEARTICULOS"
        Me.CANTIDADDEARTICULOS.Size = New System.Drawing.Size(91, 26)
        Me.CANTIDADDEARTICULOS.TabIndex = 97
        Me.CANTIDADDEARTICULOS.Text = "CANTIDAD DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ARTICULOS"
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonDESCRIPCION.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDESCRIPCION.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(768, 79)
        Me.RadioButtonDESCRIPCION.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonDESCRIPCION.Name = "RadioButtonDESCRIPCION"
        Me.RadioButtonDESCRIPCION.Size = New System.Drawing.Size(137, 24)
        Me.RadioButtonDESCRIPCION.TabIndex = 95
        Me.RadioButtonDESCRIPCION.TabStop = True
        Me.RadioButtonDESCRIPCION.Text = "DESCRIPCION"
        Me.RadioButtonDESCRIPCION.UseVisualStyleBackColor = False
        '
        'RadioButtonCODIGO
        '
        Me.RadioButtonCODIGO.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonCODIGO.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCODIGO.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonCODIGO.Location = New System.Drawing.Point(644, 79)
        Me.RadioButtonCODIGO.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonCODIGO.Name = "RadioButtonCODIGO"
        Me.RadioButtonCODIGO.Size = New System.Drawing.Size(96, 24)
        Me.RadioButtonCODIGO.TabIndex = 94
        Me.RadioButtonCODIGO.TabStop = True
        Me.RadioButtonCODIGO.Text = "CODIGO"
        Me.RadioButtonCODIGO.UseVisualStyleBackColor = False
        '
        'BUSCAR
        '
        Me.BUSCAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCAR.ForeColor = System.Drawing.Color.Black
        Me.BUSCAR.Location = New System.Drawing.Point(265, 85)
        Me.BUSCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(69, 17)
        Me.BUSCAR.TabIndex = 93
        Me.BUSCAR.Text = "BUSCAR: "
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscar.Location = New System.Drawing.Point(342, 81)
        Me.TextBoxBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(277, 22)
        Me.TextBoxBuscar.TabIndex = 67
        '
        'MODIFICAR
        '
        Me.MODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFICAR.Location = New System.Drawing.Point(243, 554)
        Me.MODIFICAR.Margin = New System.Windows.Forms.Padding(4)
        Me.MODIFICAR.Name = "MODIFICAR"
        Me.MODIFICAR.Size = New System.Drawing.Size(177, 51)
        Me.MODIFICAR.TabIndex = 91
        Me.MODIFICAR.Text = "MODIFICAR"
        Me.MODIFICAR.UseVisualStyleBackColor = True
        '
        'TextBoxCodProveedor
        '
        Me.TextBoxCodProveedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxCodProveedor.Location = New System.Drawing.Point(11, 34)
        Me.TextBoxCodProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCodProveedor.Name = "TextBoxCodProveedor"
        Me.TextBoxCodProveedor.Size = New System.Drawing.Size(172, 23)
        Me.TextBoxCodProveedor.TabIndex = 68
        '
        'ARTICULOSlbl
        '
        Me.ARTICULOSlbl.BackColor = System.Drawing.Color.Transparent
        Me.ARTICULOSlbl.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARTICULOSlbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ARTICULOSlbl.Location = New System.Drawing.Point(349, 9)
        Me.ARTICULOSlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ARTICULOSlbl.Name = "ARTICULOSlbl"
        Me.ARTICULOSlbl.Size = New System.Drawing.Size(391, 68)
        Me.ARTICULOSlbl.TabIndex = 87
        Me.ARTICULOSlbl.Text = "ARTÍCULOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(65, 277)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 21)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "$"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(162, 277)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 23)
        Me.TextBox3.TabIndex = 76
        '
        'ComboMarca
        '
        Me.ComboMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(12, 480)
        Me.ComboMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(213, 23)
        Me.ComboMarca.TabIndex = 80
        '
        'ComboSubCategoria
        '
        Me.ComboSubCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboSubCategoria.FormattingEnabled = True
        Me.ComboSubCategoria.Location = New System.Drawing.Point(12, 413)
        Me.ComboSubCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboSubCategoria.Name = "ComboSubCategoria"
        Me.ComboSubCategoria.Size = New System.Drawing.Size(200, 23)
        Me.ComboSubCategoria.TabIndex = 79
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxPrecio.Location = New System.Drawing.Point(88, 277)
        Me.TextBoxPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(67, 23)
        Me.TextBoxPrecio.TabIndex = 74
        '
        'MARCA
        '
        Me.MARCA.BackColor = System.Drawing.Color.Transparent
        Me.MARCA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MARCA.ForeColor = System.Drawing.Color.Black
        Me.MARCA.Location = New System.Drawing.Point(14, 459)
        Me.MARCA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MARCA.Name = "MARCA"
        Me.MARCA.Size = New System.Drawing.Size(67, 17)
        Me.MARCA.TabIndex = 84
        Me.MARCA.Text = "MARCA"
        '
        'SUBCATEGORIA
        '
        Me.SUBCATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.SUBCATEGORIA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SUBCATEGORIA.ForeColor = System.Drawing.Color.Black
        Me.SUBCATEGORIA.Location = New System.Drawing.Point(7, 392)
        Me.SUBCATEGORIA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SUBCATEGORIA.Name = "SUBCATEGORIA"
        Me.SUBCATEGORIA.Size = New System.Drawing.Size(143, 17)
        Me.SUBCATEGORIA.TabIndex = 83
        Me.SUBCATEGORIA.Text = "SUB CATEGORÍA"
        '
        'CATEGORIA
        '
        Me.CATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.CATEGORIA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CATEGORIA.ForeColor = System.Drawing.Color.Black
        Me.CATEGORIA.Location = New System.Drawing.Point(9, 324)
        Me.CATEGORIA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CATEGORIA.Name = "CATEGORIA"
        Me.CATEGORIA.Size = New System.Drawing.Size(104, 17)
        Me.CATEGORIA.TabIndex = 82
        Me.CATEGORIA.Text = "CATEGORÍA"
        '
        'ComboCategoria
        '
        Me.ComboCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ComboCategoria.FormattingEnabled = True
        Me.ComboCategoria.Location = New System.Drawing.Point(12, 345)
        Me.ComboCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboCategoria.Name = "ComboCategoria"
        Me.ComboCategoria.Size = New System.Drawing.Size(200, 23)
        Me.ComboCategoria.TabIndex = 77
        '
        'PRECIO
        '
        Me.PRECIO.BackColor = System.Drawing.Color.Transparent
        Me.PRECIO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PRECIO.ForeColor = System.Drawing.Color.Black
        Me.PRECIO.Location = New System.Drawing.Point(19, 282)
        Me.PRECIO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Size = New System.Drawing.Size(71, 25)
        Me.PRECIO.TabIndex = 78
        Me.PRECIO.Text = "PRECIO"
        '
        'Combo_SubUnidad
        '
        Me.Combo_SubUnidad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Combo_SubUnidad.FormattingEnabled = True
        Me.Combo_SubUnidad.Location = New System.Drawing.Point(12, 235)
        Me.Combo_SubUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_SubUnidad.Name = "Combo_SubUnidad"
        Me.Combo_SubUnidad.Size = New System.Drawing.Size(183, 23)
        Me.Combo_SubUnidad.TabIndex = 73
        '
        'SUBUNIDADDEMEDIDA
        '
        Me.SUBUNIDADDEMEDIDA.BackColor = System.Drawing.Color.Transparent
        Me.SUBUNIDADDEMEDIDA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SUBUNIDADDEMEDIDA.ForeColor = System.Drawing.Color.Black
        Me.SUBUNIDADDEMEDIDA.Location = New System.Drawing.Point(9, 214)
        Me.SUBUNIDADDEMEDIDA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SUBUNIDADDEMEDIDA.Name = "SUBUNIDADDEMEDIDA"
        Me.SUBUNIDADDEMEDIDA.Size = New System.Drawing.Size(209, 17)
        Me.SUBUNIDADDEMEDIDA.TabIndex = 75
        Me.SUBUNIDADDEMEDIDA.Text = "SUB UNIDAD DE MEDIDA"
        '
        'Combo_UniddMedida
        '
        Me.Combo_UniddMedida.DisplayMember = "Cod_Unidad_Medida"
        Me.Combo_UniddMedida.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Combo_UniddMedida.FormattingEnabled = True
        Me.Combo_UniddMedida.Location = New System.Drawing.Point(11, 166)
        Me.Combo_UniddMedida.Margin = New System.Windows.Forms.Padding(4)
        Me.Combo_UniddMedida.Name = "Combo_UniddMedida"
        Me.Combo_UniddMedida.Size = New System.Drawing.Size(183, 23)
        Me.Combo_UniddMedida.TabIndex = 71
        Me.Combo_UniddMedida.ValueMember = "Cod_Unidad_Medida"
        '
        'UNIDADDEMEDIDA
        '
        Me.UNIDADDEMEDIDA.BackColor = System.Drawing.Color.Transparent
        Me.UNIDADDEMEDIDA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UNIDADDEMEDIDA.ForeColor = System.Drawing.Color.Black
        Me.UNIDADDEMEDIDA.Location = New System.Drawing.Point(9, 144)
        Me.UNIDADDEMEDIDA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UNIDADDEMEDIDA.Name = "UNIDADDEMEDIDA"
        Me.UNIDADDEMEDIDA.Size = New System.Drawing.Size(171, 17)
        Me.UNIDADDEMEDIDA.TabIndex = 72
        Me.UNIDADDEMEDIDA.Text = "UNIDAD DE MEDIDA"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.DESCRIPCION.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DESCRIPCION.ForeColor = System.Drawing.Color.Black
        Me.DESCRIPCION.Location = New System.Drawing.Point(11, 72)
        Me.DESCRIPCION.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Size = New System.Drawing.Size(121, 23)
        Me.DESCRIPCION.TabIndex = 70
        Me.DESCRIPCION.Text = "DESCRIPCIÓN"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(10, 99)
        Me.TextBoxDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(214, 23)
        Me.TextBoxDescripcion.TabIndex = 69
        '
        'EliminarButton
        '
        Me.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarButton.Image = Global.GUI.My.Resources.Resources.delete1
        Me.EliminarButton.Location = New System.Drawing.Point(911, 554)
        Me.EliminarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(77, 80)
        Me.EliminarButton.TabIndex = 99
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(888, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.GUI.My.Resources.Resources.aceptar1
        Me.Button1.Location = New System.Drawing.Point(11, 534)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 171)
        Me.Button1.TabIndex = 88
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CODBARRAS
        '
        Me.CODBARRAS.AutoSize = True
        Me.CODBARRAS.BackColor = System.Drawing.Color.Transparent
        Me.CODBARRAS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CODBARRAS.ForeColor = System.Drawing.Color.Black
        Me.CODBARRAS.Location = New System.Drawing.Point(11, 9)
        Me.CODBARRAS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CODBARRAS.Name = "CODBARRAS"
        Me.CODBARRAS.Size = New System.Drawing.Size(79, 15)
        Me.CODBARRAS.TabIndex = 101
        Me.CODBARRAS.Text = "COD BARRAS"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(243, 110)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(986, 414)
        Me.DataGridView2.TabIndex = 102
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 1004)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.CODBARRAS)
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ARTICULOSlbl)
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
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ArticulosForm"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ARTICULOSlbl As System.Windows.Forms.Label
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
    Friend WithEvents CODBARRAS As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
