<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContraseñaForm
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
        Me.TextBoxContraseñaIngresada = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevaContraseñaDuplicado = New System.Windows.Forms.TextBox()
        Me.LabelContraseñaAnterior = New System.Windows.Forms.Label()
        Me.LabelNuevaContraseña = New System.Windows.Forms.Label()
        Me.LabelRepitaNuevaContraseña = New System.Windows.Forms.Label()
        Me.LabelCambiarContraseña = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AceptarButton = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxContraseñaIngresada
        '
        Me.TextBoxContraseñaIngresada.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseñaIngresada.Location = New System.Drawing.Point(255, 155)
        Me.TextBoxContraseñaIngresada.Name = "TextBoxContraseñaIngresada"
        Me.TextBoxContraseñaIngresada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContraseñaIngresada.Size = New System.Drawing.Size(221, 32)
        Me.TextBoxContraseñaIngresada.TabIndex = 0
        '
        'TextBoxNuevaContraseña
        '
        Me.TextBoxNuevaContraseña.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNuevaContraseña.Location = New System.Drawing.Point(255, 214)
        Me.TextBoxNuevaContraseña.Name = "TextBoxNuevaContraseña"
        Me.TextBoxNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNuevaContraseña.Size = New System.Drawing.Size(221, 32)
        Me.TextBoxNuevaContraseña.TabIndex = 1
        '
        'TextBoxNuevaContraseñaDuplicado
        '
        Me.TextBoxNuevaContraseñaDuplicado.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNuevaContraseñaDuplicado.Location = New System.Drawing.Point(255, 273)
        Me.TextBoxNuevaContraseñaDuplicado.Name = "TextBoxNuevaContraseñaDuplicado"
        Me.TextBoxNuevaContraseñaDuplicado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNuevaContraseñaDuplicado.Size = New System.Drawing.Size(221, 32)
        Me.TextBoxNuevaContraseñaDuplicado.TabIndex = 2
        '
        'LabelContraseñaAnterior
        '
        Me.LabelContraseñaAnterior.AutoSize = True
        Me.LabelContraseñaAnterior.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseñaAnterior.Location = New System.Drawing.Point(252, 131)
        Me.LabelContraseñaAnterior.Name = "LabelContraseñaAnterior"
        Me.LabelContraseñaAnterior.Size = New System.Drawing.Size(195, 21)
        Me.LabelContraseñaAnterior.TabIndex = 3
        Me.LabelContraseñaAnterior.Text = "CONTRASEÑA ANTERIOR"
        Me.LabelContraseñaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNuevaContraseña
        '
        Me.LabelNuevaContraseña.AutoSize = True
        Me.LabelNuevaContraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevaContraseña.Location = New System.Drawing.Point(252, 190)
        Me.LabelNuevaContraseña.Name = "LabelNuevaContraseña"
        Me.LabelNuevaContraseña.Size = New System.Drawing.Size(169, 21)
        Me.LabelNuevaContraseña.TabIndex = 4
        Me.LabelNuevaContraseña.Text = "NUEVA CONTRASEÑA"
        Me.LabelNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRepitaNuevaContraseña
        '
        Me.LabelRepitaNuevaContraseña.AutoSize = True
        Me.LabelRepitaNuevaContraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepitaNuevaContraseña.Location = New System.Drawing.Point(252, 249)
        Me.LabelRepitaNuevaContraseña.Name = "LabelRepitaNuevaContraseña"
        Me.LabelRepitaNuevaContraseña.Size = New System.Drawing.Size(224, 21)
        Me.LabelRepitaNuevaContraseña.TabIndex = 5
        Me.LabelRepitaNuevaContraseña.Text = "REPITA NUEVA CONTRASEÑA"
        Me.LabelRepitaNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelCambiarContraseña
        '
        Me.LabelCambiarContraseña.AutoSize = True
        Me.LabelCambiarContraseña.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCambiarContraseña.Location = New System.Drawing.Point(39, 28)
        Me.LabelCambiarContraseña.Name = "LabelCambiarContraseña"
        Me.LabelCambiarContraseña.Size = New System.Drawing.Size(583, 65)
        Me.LabelCambiarContraseña.TabIndex = 7
        Me.LabelCambiarContraseña.Text = "CAMBIAR CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.password
        Me.PictureBox1.Location = New System.Drawing.Point(41, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'AceptarButton
        '
        Me.AceptarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AceptarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.AceptarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.AceptarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarButton.Location = New System.Drawing.Point(272, 324)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(139, 52)
        Me.AceptarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AceptarButton.TabIndex = 9
        Me.AceptarButton.Text = "MODIFICAR"
        Me.AceptarButton.TextColor = System.Drawing.Color.White
        '
        'ContraseñaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 402)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelCambiarContraseña)
        Me.Controls.Add(Me.LabelRepitaNuevaContraseña)
        Me.Controls.Add(Me.LabelNuevaContraseña)
        Me.Controls.Add(Me.LabelContraseñaAnterior)
        Me.Controls.Add(Me.TextBoxNuevaContraseñaDuplicado)
        Me.Controls.Add(Me.TextBoxNuevaContraseña)
        Me.Controls.Add(Me.TextBoxContraseñaIngresada)
        Me.DoubleBuffered = True
        Me.Name = "ContraseñaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContraseñaForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxContraseñaIngresada As TextBox
    Friend WithEvents TextBoxNuevaContraseña As TextBox
    Friend WithEvents TextBoxNuevaContraseñaDuplicado As TextBox
    Friend WithEvents LabelContraseñaAnterior As Label
    Friend WithEvents LabelNuevaContraseña As Label
    Friend WithEvents LabelRepitaNuevaContraseña As Label
    Friend WithEvents LabelCambiarContraseña As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AceptarButton As DevComponents.DotNetBar.ButtonX
End Class
