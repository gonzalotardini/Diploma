<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoPoseeListBox = New System.Windows.Forms.ListBox()
        Me.PoseeListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RegistrarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(102, 24)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(165, 21)
        Me.UsuarioComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista Usuarios"
        '
        'NoPoseeListBox
        '
        Me.NoPoseeListBox.FormattingEnabled = True
        Me.NoPoseeListBox.Location = New System.Drawing.Point(381, 104)
        Me.NoPoseeListBox.Name = "NoPoseeListBox"
        Me.NoPoseeListBox.Size = New System.Drawing.Size(169, 199)
        Me.NoPoseeListBox.TabIndex = 2
        '
        'PoseeListBox
        '
        Me.PoseeListBox.FormattingEnabled = True
        Me.PoseeListBox.Location = New System.Drawing.Point(43, 104)
        Me.PoseeListBox.Name = "PoseeListBox"
        Me.PoseeListBox.Size = New System.Drawing.Size(167, 199)
        Me.PoseeListBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(436, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RegistrarButton
        '
        Me.RegistrarButton.Location = New System.Drawing.Point(254, 359)
        Me.RegistrarButton.Name = "RegistrarButton"
        Me.RegistrarButton.Size = New System.Drawing.Size(101, 38)
        Me.RegistrarButton.TabIndex = 6
        Me.RegistrarButton.Text = "REGISTRAR"
        Me.RegistrarButton.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 441)
        Me.Controls.Add(Me.RegistrarButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PoseeListBox)
        Me.Controls.Add(Me.NoPoseeListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsuarioComboBox)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoPoseeListBox As System.Windows.Forms.ListBox
    Friend WithEvents PoseeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RegistrarButton As System.Windows.Forms.Button
End Class
