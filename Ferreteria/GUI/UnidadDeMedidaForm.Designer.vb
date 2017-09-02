<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadDeMedidaForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelDesripcion = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.AgregarButton = New DevComponents.DotNetBar.ButtonX()
        Me.AceptarButton = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ModificarButton = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(189, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(457, 67)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "UNIDAD DE MEDIDA"
        '
        'LabelDesripcion
        '
        '
        '
        '
        Me.LabelDesripcion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelDesripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesripcion.Location = New System.Drawing.Point(36, 122)
        Me.LabelDesripcion.Name = "LabelDesripcion"
        Me.LabelDesripcion.Size = New System.Drawing.Size(116, 23)
        Me.LabelDesripcion.TabIndex = 1
        Me.LabelDesripcion.Text = "DESCRIPCION"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(179, 122)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(165, 27)
        Me.TextBoxX1.TabIndex = 3
        '
        'AgregarButton
        '
        Me.AgregarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AgregarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.AgregarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.AgregarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarButton.Location = New System.Drawing.Point(77, 212)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(101, 55)
        Me.AgregarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AgregarButton.TabIndex = 4
        Me.AgregarButton.Text = "AGREGAR"
        Me.AgregarButton.TextColor = System.Drawing.Color.White
        '
        'AceptarButton
        '
        Me.AceptarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AceptarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.AceptarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.AceptarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarButton.Location = New System.Drawing.Point(243, 212)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(101, 55)
        Me.AceptarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AceptarButton.TabIndex = 5
        Me.AceptarButton.Text = "ACEPTAR"
        Me.AceptarButton.TextColor = System.Drawing.Color.White
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(425, 122)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(350, 208)
        Me.DataGridViewX1.TabIndex = 6
        '
        'ModificarButton
        '
        Me.ModificarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ModificarButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ModificarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ModificarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.Location = New System.Drawing.Point(425, 346)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(123, 51)
        Me.ModificarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ModificarButton.TabIndex = 7
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.TextColor = System.Drawing.Color.White
        '
        'UnidadDeMedidaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 510)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.AgregarButton)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.LabelDesripcion)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Name = "UnidadDeMedidaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnidadDeMedidaForm"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelDesripcion As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents AgregarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AceptarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ModificarButton As DevComponents.DotNetBar.ButtonX
End Class
