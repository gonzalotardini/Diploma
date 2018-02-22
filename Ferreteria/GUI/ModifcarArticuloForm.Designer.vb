<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifcarArticuloForm
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
        Me.CODBARRAS = New DevComponents.DotNetBar.LabelX()
        Me.DESCRIPCION = New DevComponents.DotNetBar.LabelX()
        Me.UnidadDeMedida = New DevComponents.DotNetBar.LabelX()
        Me.SubUnidadMedidaLabel = New DevComponents.DotNetBar.LabelX()
        Me.PrecioLabel = New DevComponents.DotNetBar.LabelX()
        Me.CategoriaLabel = New DevComponents.DotNetBar.LabelX()
        Me.SubCategoriaLabel = New DevComponents.DotNetBar.LabelX()
        Me.MarcaLabel = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxCodBarras = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ModificarButton = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxUnidadDeMedida = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxSubUnidadMedida = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.TextBox3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBox4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxSubCategoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxMarca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'CODBARRAS
        '
        '
        '
        '
        Me.CODBARRAS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CODBARRAS.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODBARRAS.Location = New System.Drawing.Point(122, 32)
        Me.CODBARRAS.Name = "CODBARRAS"
        Me.CODBARRAS.Size = New System.Drawing.Size(105, 23)
        Me.CODBARRAS.TabIndex = 0
        Me.CODBARRAS.Text = "COD BARRAS"
        '
        'DESCRIPCION
        '
        '
        '
        '
        Me.DESCRIPCION.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DESCRIPCION.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPCION.Location = New System.Drawing.Point(122, 96)
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Size = New System.Drawing.Size(105, 23)
        Me.DESCRIPCION.TabIndex = 1
        Me.DESCRIPCION.Text = "DESCRIPCION"
        '
        'UnidadDeMedida
        '
        '
        '
        '
        Me.UnidadDeMedida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UnidadDeMedida.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadDeMedida.Location = New System.Drawing.Point(122, 160)
        Me.UnidadDeMedida.Name = "UnidadDeMedida"
        Me.UnidadDeMedida.Size = New System.Drawing.Size(213, 23)
        Me.UnidadDeMedida.TabIndex = 2
        Me.UnidadDeMedida.Text = "UNIDAD DE MEDIDA"
        '
        'SubUnidadMedidaLabel
        '
        '
        '
        '
        Me.SubUnidadMedidaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SubUnidadMedidaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubUnidadMedidaLabel.Location = New System.Drawing.Point(122, 231)
        Me.SubUnidadMedidaLabel.Name = "SubUnidadMedidaLabel"
        Me.SubUnidadMedidaLabel.Size = New System.Drawing.Size(213, 23)
        Me.SubUnidadMedidaLabel.TabIndex = 3
        Me.SubUnidadMedidaLabel.Text = "SUB UNIDAD MEDIDA"
        '
        'PrecioLabel
        '
        '
        '
        '
        Me.PrecioLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PrecioLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioLabel.Location = New System.Drawing.Point(122, 304)
        Me.PrecioLabel.Name = "PrecioLabel"
        Me.PrecioLabel.Size = New System.Drawing.Size(64, 23)
        Me.PrecioLabel.TabIndex = 4
        Me.PrecioLabel.Text = "PRECIO"
        '
        'CategoriaLabel
        '
        '
        '
        '
        Me.CategoriaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CategoriaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaLabel.Location = New System.Drawing.Point(122, 340)
        Me.CategoriaLabel.Name = "CategoriaLabel"
        Me.CategoriaLabel.Size = New System.Drawing.Size(105, 23)
        Me.CategoriaLabel.TabIndex = 5
        Me.CategoriaLabel.Text = "CATEGORIA"
        '
        'SubCategoriaLabel
        '
        '
        '
        '
        Me.SubCategoriaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SubCategoriaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubCategoriaLabel.Location = New System.Drawing.Point(122, 404)
        Me.SubCategoriaLabel.Name = "SubCategoriaLabel"
        Me.SubCategoriaLabel.Size = New System.Drawing.Size(190, 23)
        Me.SubCategoriaLabel.TabIndex = 6
        Me.SubCategoriaLabel.Text = "SUB-CATEGORIA"
        '
        'MarcaLabel
        '
        '
        '
        '
        Me.MarcaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MarcaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaLabel.Location = New System.Drawing.Point(122, 471)
        Me.MarcaLabel.Name = "MarcaLabel"
        Me.MarcaLabel.Size = New System.Drawing.Size(105, 23)
        Me.MarcaLabel.TabIndex = 7
        Me.MarcaLabel.Text = "MARCA"
        '
        'TextBoxCodBarras
        '
        Me.TextBoxCodBarras.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxCodBarras.Border.Class = "TextBoxBorder"
        Me.TextBoxCodBarras.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxCodBarras.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodBarras.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCodBarras.Location = New System.Drawing.Point(122, 61)
        Me.TextBoxCodBarras.Name = "TextBoxCodBarras"
        Me.TextBoxCodBarras.Size = New System.Drawing.Size(213, 27)
        Me.TextBoxCodBarras.TabIndex = 8
        '
        'ModificarButton
        '
        Me.ModificarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ModificarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.ModificarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ModificarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.Location = New System.Drawing.Point(146, 552)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(140, 65)
        Me.ModificarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ModificarButton.TabIndex = 16
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.TextColor = System.Drawing.Color.White
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxDescripcion.Border.Class = "TextBoxBorder"
        Me.TextBoxDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescripcion.ForeColor = System.Drawing.Color.Black
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(122, 125)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(213, 27)
        Me.TextBoxDescripcion.TabIndex = 17
        '
        'ComboBoxUnidadDeMedida
        '
        Me.ComboBoxUnidadDeMedida.DisplayMember = "Text"
        Me.ComboBoxUnidadDeMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxUnidadDeMedida.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUnidadDeMedida.FormattingEnabled = True
        Me.ComboBoxUnidadDeMedida.ItemHeight = 21
        Me.ComboBoxUnidadDeMedida.Location = New System.Drawing.Point(122, 189)
        Me.ComboBoxUnidadDeMedida.Name = "ComboBoxUnidadDeMedida"
        Me.ComboBoxUnidadDeMedida.Size = New System.Drawing.Size(213, 27)
        Me.ComboBoxUnidadDeMedida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxUnidadDeMedida.TabIndex = 18
        '
        'ComboBoxSubUnidadMedida
        '
        Me.ComboBoxSubUnidadMedida.DisplayMember = "Text"
        Me.ComboBoxSubUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxSubUnidadMedida.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubUnidadMedida.FormattingEnabled = True
        Me.ComboBoxSubUnidadMedida.ItemHeight = 21
        Me.ComboBoxSubUnidadMedida.Location = New System.Drawing.Point(125, 260)
        Me.ComboBoxSubUnidadMedida.Name = "ComboBoxSubUnidadMedida"
        Me.ComboBoxSubUnidadMedida.Size = New System.Drawing.Size(210, 27)
        Me.ComboBoxSubUnidadMedida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxSubUnidadMedida.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox3.Border.Class = "TextBoxBorder"
        Me.TextBox3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(207, 304)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 27)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBox4.Border.Class = "TextBoxBorder"
        Me.TextBox4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(271, 304)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(26, 27)
        Me.TextBox4.TabIndex = 21
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DisplayMember = "Text"
        Me.ComboBoxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.ItemHeight = 21
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(122, 369)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(213, 27)
        Me.ComboBoxCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxCategoria.TabIndex = 22
        '
        'ComboBoxSubCategoria
        '
        Me.ComboBoxSubCategoria.DisplayMember = "Text"
        Me.ComboBoxSubCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxSubCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSubCategoria.FormattingEnabled = True
        Me.ComboBoxSubCategoria.ItemHeight = 21
        Me.ComboBoxSubCategoria.Location = New System.Drawing.Point(122, 433)
        Me.ComboBoxSubCategoria.Name = "ComboBoxSubCategoria"
        Me.ComboBoxSubCategoria.Size = New System.Drawing.Size(213, 27)
        Me.ComboBoxSubCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxSubCategoria.TabIndex = 23
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.DisplayMember = "Text"
        Me.ComboBoxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.ItemHeight = 21
        Me.ComboBoxMarca.Location = New System.Drawing.Point(122, 500)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(213, 27)
        Me.ComboBoxMarca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxMarca.TabIndex = 24
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(181, 304)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(20, 23)
        Me.LabelX1.TabIndex = 25
        Me.LabelX1.Text = "$"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(255, 293)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(10, 38)
        Me.LabelX2.TabIndex = 26
        Me.LabelX2.Text = "."
        '
        'ModifcarArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 644)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ComboBoxMarca)
        Me.Controls.Add(Me.ComboBoxSubCategoria)
        Me.Controls.Add(Me.ComboBoxCategoria)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBoxSubUnidadMedida)
        Me.Controls.Add(Me.ComboBoxUnidadDeMedida)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.TextBoxCodBarras)
        Me.Controls.Add(Me.MarcaLabel)
        Me.Controls.Add(Me.SubCategoriaLabel)
        Me.Controls.Add(Me.CategoriaLabel)
        Me.Controls.Add(Me.PrecioLabel)
        Me.Controls.Add(Me.SubUnidadMedidaLabel)
        Me.Controls.Add(Me.UnidadDeMedida)
        Me.Controls.Add(Me.DESCRIPCION)
        Me.Controls.Add(Me.CODBARRAS)
        Me.DoubleBuffered = True
        Me.Name = "ModifcarArticuloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifcarArticuloForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CODBARRAS As DevComponents.DotNetBar.LabelX
    Friend WithEvents DESCRIPCION As DevComponents.DotNetBar.LabelX
    Friend WithEvents UnidadDeMedida As DevComponents.DotNetBar.LabelX
    Friend WithEvents SubUnidadMedidaLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents PrecioLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents CategoriaLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents SubCategoriaLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents MarcaLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxCodBarras As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ModificarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBoxUnidadDeMedida As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxSubUnidadMedida As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextBox3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBox4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBoxCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxSubCategoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboBoxMarca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
