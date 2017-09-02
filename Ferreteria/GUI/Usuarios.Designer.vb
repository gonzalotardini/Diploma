<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.PoseeListBox = New System.Windows.Forms.ListBox()
        Me.ButtonPosee = New System.Windows.Forms.Button()
        Me.ButtonNoPosee = New System.Windows.Forms.Button()
        Me.RegistrarButton = New System.Windows.Forms.Button()
        Me.LabelNoPosee = New System.Windows.Forms.Label()
        Me.LabelPosee = New System.Windows.Forms.Label()
        Me.NoPoseeListBox = New System.Windows.Forms.ListBox()
        Me.LabelPermisos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(159, 104)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(165, 23)
        Me.UsuarioComboBox.TabIndex = 0
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.Location = New System.Drawing.Point(57, 107)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(73, 18)
        Me.LabelUsuarios.TabIndex = 1
        Me.LabelUsuarios.Text = "USUARIOS"
        '
        'PoseeListBox
        '
        Me.PoseeListBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoseeListBox.FormattingEnabled = True
        Me.PoseeListBox.ItemHeight = 15
        Me.PoseeListBox.Location = New System.Drawing.Point(60, 183)
        Me.PoseeListBox.Name = "PoseeListBox"
        Me.PoseeListBox.Size = New System.Drawing.Size(177, 199)
        Me.PoseeListBox.TabIndex = 3
        '
        'ButtonPosee
        '
        Me.ButtonPosee.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPosee.Location = New System.Drawing.Point(159, 388)
        Me.ButtonPosee.Name = "ButtonPosee"
        Me.ButtonPosee.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPosee.TabIndex = 4
        Me.ButtonPosee.Text = ">"
        Me.ButtonPosee.UseVisualStyleBackColor = True
        '
        'ButtonNoPosee
        '
        Me.ButtonNoPosee.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoPosee.Location = New System.Drawing.Point(428, 388)
        Me.ButtonNoPosee.Name = "ButtonNoPosee"
        Me.ButtonNoPosee.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNoPosee.TabIndex = 5
        Me.ButtonNoPosee.Text = "<"
        Me.ButtonNoPosee.UseVisualStyleBackColor = True
        '
        'RegistrarButton
        '
        Me.RegistrarButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarButton.Location = New System.Drawing.Point(276, 440)
        Me.RegistrarButton.Name = "RegistrarButton"
        Me.RegistrarButton.Size = New System.Drawing.Size(106, 45)
        Me.RegistrarButton.TabIndex = 6
        Me.RegistrarButton.Text = "REGISTRAR"
        Me.RegistrarButton.UseVisualStyleBackColor = True
        '
        'LabelNoPosee
        '
        Me.LabelNoPosee.AutoSize = True
        Me.LabelNoPosee.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNoPosee.Location = New System.Drawing.Point(483, 155)
        Me.LabelNoPosee.Name = "LabelNoPosee"
        Me.LabelNoPosee.Size = New System.Drawing.Size(70, 18)
        Me.LabelNoPosee.TabIndex = 7
        Me.LabelNoPosee.Text = "NO POSEE"
        '
        'LabelPosee
        '
        Me.LabelPosee.AutoSize = True
        Me.LabelPosee.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPosee.Location = New System.Drawing.Point(103, 155)
        Me.LabelPosee.Name = "LabelPosee"
        Me.LabelPosee.Size = New System.Drawing.Size(47, 18)
        Me.LabelPosee.TabIndex = 8
        Me.LabelPosee.Text = "POSEE"
        '
        'NoPoseeListBox
        '
        Me.NoPoseeListBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPoseeListBox.FormattingEnabled = True
        Me.NoPoseeListBox.ItemHeight = 15
        Me.NoPoseeListBox.Location = New System.Drawing.Point(428, 183)
        Me.NoPoseeListBox.Name = "NoPoseeListBox"
        Me.NoPoseeListBox.Size = New System.Drawing.Size(188, 199)
        Me.NoPoseeListBox.TabIndex = 9
        '
        'LabelPermisos
        '
        Me.LabelPermisos.AutoSize = True
        Me.LabelPermisos.Font = New System.Drawing.Font("Calibri", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPermisos.Location = New System.Drawing.Point(222, 20)
        Me.LabelPermisos.Name = "LabelPermisos"
        Me.LabelPermisos.Size = New System.Drawing.Size(254, 64)
        Me.LabelPermisos.TabIndex = 10
        Me.LabelPermisos.Text = "PERMISOS"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 509)
        Me.Controls.Add(Me.LabelPermisos)
        Me.Controls.Add(Me.NoPoseeListBox)
        Me.Controls.Add(Me.LabelPosee)
        Me.Controls.Add(Me.LabelNoPosee)
        Me.Controls.Add(Me.RegistrarButton)
        Me.Controls.Add(Me.ButtonNoPosee)
        Me.Controls.Add(Me.ButtonPosee)
        Me.Controls.Add(Me.PoseeListBox)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.UsuarioComboBox)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelUsuarios As System.Windows.Forms.Label
    Friend WithEvents PoseeListBox As System.Windows.Forms.ListBox
    Friend WithEvents NoPoseeListBox As System.Windows.Forms.ListBox
    Friend WithEvents ButtonPosee As System.Windows.Forms.Button
    Friend WithEvents ButtonNoPosee As System.Windows.Forms.Button
    Friend WithEvents RegistrarButton As System.Windows.Forms.Button
    Friend WithEvents LabelNoPosee As Label
    Friend WithEvents LabelPosee As Label
    Friend WithEvents LabelPermisos As Label
End Class
