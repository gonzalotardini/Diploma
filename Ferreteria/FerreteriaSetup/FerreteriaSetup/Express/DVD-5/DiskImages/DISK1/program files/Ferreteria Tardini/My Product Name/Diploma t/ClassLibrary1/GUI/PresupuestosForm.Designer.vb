<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresupuestosForm))
        Me.PresupuestosDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CodigoClienteRadioButton = New System.Windows.Forms.RadioButton()
        Me.VerDetalleButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PresupuestosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PresupuestosDataGridView
        '
        Me.PresupuestosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestosDataGridView.Location = New System.Drawing.Point(57, 251)
        Me.PresupuestosDataGridView.Name = "PresupuestosDataGridView"
        Me.PresupuestosDataGridView.ReadOnly = True
        Me.PresupuestosDataGridView.Size = New System.Drawing.Size(841, 357)
        Me.PresupuestosDataGridView.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 210)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RazonSocialRadioButton)
        Me.GroupBox1.Controls.Add(Me.CodigoClienteRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 41)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'RazonSocialRadioButton
        '
        Me.RazonSocialRadioButton.AutoSize = True
        Me.RazonSocialRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RazonSocialRadioButton.Location = New System.Drawing.Point(144, 18)
        Me.RazonSocialRadioButton.Name = "RazonSocialRadioButton"
        Me.RazonSocialRadioButton.Size = New System.Drawing.Size(116, 17)
        Me.RazonSocialRadioButton.TabIndex = 1
        Me.RazonSocialRadioButton.TabStop = True
        Me.RazonSocialRadioButton.Text = "RAZON SOCIAL"
        Me.RazonSocialRadioButton.UseVisualStyleBackColor = True
        '
        'CodigoClienteRadioButton
        '
        Me.CodigoClienteRadioButton.AutoSize = True
        Me.CodigoClienteRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoClienteRadioButton.Location = New System.Drawing.Point(9, 18)
        Me.CodigoClienteRadioButton.Name = "CodigoClienteRadioButton"
        Me.CodigoClienteRadioButton.Size = New System.Drawing.Size(129, 17)
        Me.CodigoClienteRadioButton.TabIndex = 0
        Me.CodigoClienteRadioButton.TabStop = True
        Me.CodigoClienteRadioButton.Text = "CODIGO CLIENTE"
        Me.CodigoClienteRadioButton.UseVisualStyleBackColor = True
        '
        'VerDetalleButton
        '
        Me.VerDetalleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerDetalleButton.Location = New System.Drawing.Point(184, 626)
        Me.VerDetalleButton.Name = "VerDetalleButton"
        Me.VerDetalleButton.Size = New System.Drawing.Size(107, 45)
        Me.VerDetalleButton.TabIndex = 3
        Me.VerDetalleButton.Text = "VER DETALLE"
        Me.VerDetalleButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarButton.Location = New System.Drawing.Point(603, 626)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(95, 45)
        Me.EliminarButton.TabIndex = 5
        Me.EliminarButton.Text = "ELIMINAR"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PRESUPUESTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PresupuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 732)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.VerDetalleButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PresupuestosDataGridView)
        Me.Name = "PresupuestosForm"
        Me.Text = "PresupuestosForm"
        CType(Me.PresupuestosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PresupuestosDataGridView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RazonSocialRadioButton As RadioButton
    Friend WithEvents CodigoClienteRadioButton As RadioButton
    Friend WithEvents VerDetalleButton As System.Windows.Forms.Button
    Friend WithEvents EliminarButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
