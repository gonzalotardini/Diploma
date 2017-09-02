<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Precios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Precios))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CantidadArticulosLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DescontarRadioButon = New System.Windows.Forms.RadioButton()
        Me.AumentarRadioButton = New System.Windows.Forms.RadioButton()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.EXCLUIR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CategoriaRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubRadioButton = New System.Windows.Forms.RadioButton()
        Me.MarcaRadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PreciosLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(733, 641)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        '
        'CantidadArticulosLabel
        '
        Me.CantidadArticulosLabel.AutoSize = True
        Me.CantidadArticulosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadArticulosLabel.Location = New System.Drawing.Point(620, 639)
        Me.CantidadArticulosLabel.Name = "CantidadArticulosLabel"
        Me.CantidadArticulosLabel.Size = New System.Drawing.Size(91, 26)
        Me.CantidadArticulosLabel.TabIndex = 21
        Me.CantidadArticulosLabel.Text = "CANTIDAD DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ARTICULOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DescontarRadioButon)
        Me.GroupBox1.Controls.Add(Me.AumentarRadioButton)
        Me.GroupBox1.Controls.Add(Me.AceptarButton)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 598)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 113)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'DescontarRadioButon
        '
        Me.DescontarRadioButon.AutoSize = True
        Me.DescontarRadioButon.Location = New System.Drawing.Point(271, 63)
        Me.DescontarRadioButon.Name = "DescontarRadioButon"
        Me.DescontarRadioButon.Size = New System.Drawing.Size(92, 17)
        Me.DescontarRadioButon.TabIndex = 14
        Me.DescontarRadioButon.TabStop = True
        Me.DescontarRadioButon.Text = "DESCONTAR"
        Me.DescontarRadioButon.UseVisualStyleBackColor = True
        '
        'AumentarRadioButton
        '
        Me.AumentarRadioButton.AutoSize = True
        Me.AumentarRadioButton.Location = New System.Drawing.Point(271, 39)
        Me.AumentarRadioButton.Name = "AumentarRadioButton"
        Me.AumentarRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.AumentarRadioButton.TabIndex = 13
        Me.AumentarRadioButton.TabStop = True
        Me.AumentarRadioButton.Text = "AUMENTAR"
        Me.AumentarRadioButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarButton.Location = New System.Drawing.Point(143, 39)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(95, 34)
        Me.AceptarButton.TabIndex = 12
        Me.AceptarButton.Text = "ACEPTAR"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(45, 39)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(69, 35)
        Me.NumericUpDown1.TabIndex = 11
        '
        'EXCLUIR
        '
        Me.EXCLUIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXCLUIR.Location = New System.Drawing.Point(247, 156)
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.Size = New System.Drawing.Size(84, 41)
        Me.EXCLUIR.TabIndex = 19
        Me.EXCLUIR.Text = "EXCLUIR"
        Me.EXCLUIR.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1291, 366)
        Me.DataGridView1.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(49, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'CategoriaRadioButton
        '
        Me.CategoriaRadioButton.AutoSize = True
        Me.CategoriaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaRadioButton.Location = New System.Drawing.Point(280, 119)
        Me.CategoriaRadioButton.Name = "CategoriaRadioButton"
        Me.CategoriaRadioButton.Size = New System.Drawing.Size(90, 22)
        Me.CategoriaRadioButton.TabIndex = 16
        Me.CategoriaRadioButton.TabStop = True
        Me.CategoriaRadioButton.Text = "Categoria"
        Me.CategoriaRadioButton.UseVisualStyleBackColor = True
        '
        'SubRadioButton
        '
        Me.SubRadioButton.AutoSize = True
        Me.SubRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubRadioButton.Location = New System.Drawing.Point(141, 119)
        Me.SubRadioButton.Name = "SubRadioButton"
        Me.SubRadioButton.Size = New System.Drawing.Size(120, 22)
        Me.SubRadioButton.TabIndex = 15
        Me.SubRadioButton.TabStop = True
        Me.SubRadioButton.Text = "Sub Categoria"
        Me.SubRadioButton.UseVisualStyleBackColor = True
        '
        'MarcaRadioButton
        '
        Me.MarcaRadioButton.AutoSize = True
        Me.MarcaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarcaRadioButton.Location = New System.Drawing.Point(46, 119)
        Me.MarcaRadioButton.Name = "MarcaRadioButton"
        Me.MarcaRadioButton.Size = New System.Drawing.Size(68, 22)
        Me.MarcaRadioButton.TabIndex = 14
        Me.MarcaRadioButton.TabStop = True
        Me.MarcaRadioButton.Text = "Marca"
        Me.MarcaRadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(49, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PreciosLabel
        '
        Me.PreciosLabel.AutoSize = True
        Me.PreciosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreciosLabel.Location = New System.Drawing.Point(196, 35)
        Me.PreciosLabel.Name = "PreciosLabel"
        Me.PreciosLabel.Size = New System.Drawing.Size(247, 55)
        Me.PreciosLabel.TabIndex = 24
        Me.PreciosLabel.Text = "PRECIOS"
        '
        'Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 755)
        Me.Controls.Add(Me.PreciosLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CantidadArticulosLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EXCLUIR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CategoriaRadioButton)
        Me.Controls.Add(Me.SubRadioButton)
        Me.Controls.Add(Me.MarcaRadioButton)
        Me.Name = "Precios"
        Me.Text = "PRECIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CantidadArticulosLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DescontarRadioButon As System.Windows.Forms.RadioButton
    Friend WithEvents AumentarRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AceptarButton As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents EXCLUIR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MarcaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PreciosLabel As System.Windows.Forms.Label
End Class
