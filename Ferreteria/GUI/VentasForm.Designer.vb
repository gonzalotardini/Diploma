<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasForm))
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CodigoClienteRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.VentasLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VerDetalleButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelarButton
        '
        Me.CancelarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarButton.Location = New System.Drawing.Point(726, 548)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(95, 45)
        Me.CancelarButton.TabIndex = 10
        Me.CancelarButton.Text = "CANCELAR"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RazonSocialRadioButton)
        Me.GroupBox1.Controls.Add(Me.CodigoClienteRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(571, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 41)
        Me.GroupBox1.TabIndex = 8
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 20)
        Me.TextBox1.TabIndex = 7
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AllowUserToAddRows = False
        Me.VentasDataGridView.AllowUserToDeleteRows = False
        Me.VentasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Location = New System.Drawing.Point(229, 174)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.ReadOnly = True
        Me.VentasDataGridView.Size = New System.Drawing.Size(699, 352)
        Me.VentasDataGridView.TabIndex = 6
        '
        'VentasLabel
        '
        Me.VentasLabel.AutoSize = True
        Me.VentasLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.VentasLabel.Location = New System.Drawing.Point(485, 30)
        Me.VentasLabel.Name = "VentasLabel"
        Me.VentasLabel.Size = New System.Drawing.Size(210, 65)
        Me.VentasLabel.TabIndex = 11
        Me.VentasLabel.Text = "VENTAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 103)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'VerDetalleButton
        '
        Me.VerDetalleButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.VerDetalleButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.VerDetalleButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.VerDetalleButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VerDetalleButton.Location = New System.Drawing.Point(308, 548)
        Me.VerDetalleButton.Name = "VerDetalleButton"
        Me.VerDetalleButton.Size = New System.Drawing.Size(127, 59)
        Me.VerDetalleButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.VerDetalleButton.TabIndex = 14
        Me.VerDetalleButton.Text = "ButtonX1"
        Me.VerDetalleButton.TextColor = System.Drawing.Color.White
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 619)
        Me.Controls.Add(Me.VerDetalleButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.VentasLabel)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.DoubleBuffered = True
        Me.Name = "VentasForm"
        Me.Text = "VentasForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RazonSocialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CodigoClienteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VentasLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents VerDetalleButton As DevComponents.DotNetBar.ButtonX
End Class
