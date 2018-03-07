<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresupuestosForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CodigoClienteRadioButton = New System.Windows.Forms.RadioButton()
        Me.PresupuestoLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CancelarButton = New DevComponents.DotNetBar.ButtonX()
        Me.VerButton = New DevComponents.DotNetBar.ButtonX()
        Me.PresupuestosDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(324, 208)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RazonSocialRadioButton)
        Me.GroupBox1.Controls.Add(Me.CodigoClienteRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(706, 187)
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
        'PresupuestoLabel
        '
        Me.PresupuestoLabel.AutoSize = True
        Me.PresupuestoLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.PresupuestoLabel.Location = New System.Drawing.Point(598, 55)
        Me.PresupuestoLabel.Name = "PresupuestoLabel"
        Me.PresupuestoLabel.Size = New System.Drawing.Size(382, 65)
        Me.PresupuestoLabel.TabIndex = 7
        Me.PresupuestoLabel.Text = "PRESUPUESTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(347, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CancelarButton
        '
        Me.CancelarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelarButton.BackColor = System.Drawing.Color.Red
        Me.CancelarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.CancelarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarButton.Image = CType(resources.GetObject("CancelarButton.Image"), System.Drawing.Image)
        Me.CancelarButton.Location = New System.Drawing.Point(762, 608)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(148, 59)
        Me.CancelarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelarButton.TabIndex = 17
        Me.CancelarButton.Text = "ButtonX1"
        Me.CancelarButton.TextColor = System.Drawing.Color.White
        '
        'VerButton
        '
        Me.VerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.VerButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.VerButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.VerButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VerButton.Image = CType(resources.GetObject("VerButton.Image"), System.Drawing.Image)
        Me.VerButton.Location = New System.Drawing.Point(420, 608)
        Me.VerButton.Name = "VerButton"
        Me.VerButton.Size = New System.Drawing.Size(148, 59)
        Me.VerButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.VerButton.TabIndex = 16
        Me.VerButton.Text = "ButtonX1"
        Me.VerButton.TextColor = System.Drawing.Color.White
        '
        'PresupuestosDataGridView
        '
        Me.PresupuestosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PresupuestosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PresupuestosDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PresupuestosDataGridView.Location = New System.Drawing.Point(313, 251)
        Me.PresupuestosDataGridView.Name = "PresupuestosDataGridView"
        Me.PresupuestosDataGridView.Size = New System.Drawing.Size(687, 310)
        Me.PresupuestosDataGridView.TabIndex = 18
        '
        'PresupuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 732)
        Me.Controls.Add(Me.PresupuestosDataGridView)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.VerButton)
        Me.Controls.Add(Me.PresupuestoLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.Name = "PresupuestosForm"
        Me.Text = "PresupuestosForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RazonSocialRadioButton As RadioButton
    Friend WithEvents CodigoClienteRadioButton As RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PresupuestoLabel As System.Windows.Forms.Label
    Private WithEvents CancelarButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents VerButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PresupuestosDataGridView As DataGridView
End Class
