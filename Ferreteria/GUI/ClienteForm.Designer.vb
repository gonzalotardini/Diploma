<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteForm))
        Me.ClienteGridView = New System.Windows.Forms.DataGridView()
        Me.RazonSocialLabel = New System.Windows.Forms.Label()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.BarrioLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BarrioComboBox = New System.Windows.Forms.ComboBox()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CuitRadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClienteLabel = New System.Windows.Forms.Label()
        Me.LabelCodigoCliente = New System.Windows.Forms.Label()
        Me.AgregarClienteButton = New DevComponents.DotNetBar.ButtonX()
        Me.AceptarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ModificarButton = New DevComponents.DotNetBar.ButtonX()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ClienteGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteGridView
        '
        Me.ClienteGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClienteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClienteGridView.Location = New System.Drawing.Point(297, 126)
        Me.ClienteGridView.Name = "ClienteGridView"
        Me.ClienteGridView.ReadOnly = True
        Me.ClienteGridView.Size = New System.Drawing.Size(915, 413)
        Me.ClienteGridView.TabIndex = 0
        '
        'RazonSocialLabel
        '
        Me.RazonSocialLabel.AutoSize = True
        Me.RazonSocialLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RazonSocialLabel.Location = New System.Drawing.Point(16, 168)
        Me.RazonSocialLabel.Name = "RazonSocialLabel"
        Me.RazonSocialLabel.Size = New System.Drawing.Size(91, 15)
        Me.RazonSocialLabel.TabIndex = 2
        Me.RazonSocialLabel.Text = "RAZÓN SOCIAL"
        '
        'RazonSocialTextBox
        '
        Me.RazonSocialTextBox.Location = New System.Drawing.Point(120, 165)
        Me.RazonSocialTextBox.Name = "RazonSocialTextBox"
        Me.RazonSocialTextBox.Size = New System.Drawing.Size(127, 20)
        Me.RazonSocialTextBox.TabIndex = 3
        '
        'CuitTextBox
        '
        Me.CuitTextBox.Location = New System.Drawing.Point(120, 205)
        Me.CuitTextBox.Name = "CuitTextBox"
        Me.CuitTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CuitTextBox.TabIndex = 4
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(118, 246)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(127, 20)
        Me.DireccionTextBox.TabIndex = 5
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(118, 332)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(127, 20)
        Me.TelefonoTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(118, 377)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(127, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(26, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CUIT"
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DireccionLabel.Location = New System.Drawing.Point(26, 249)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(69, 15)
        Me.DireccionLabel.TabIndex = 10
        Me.DireccionLabel.Text = "DIRECCIÓN"
        '
        'BarrioLabel
        '
        Me.BarrioLabel.AutoSize = True
        Me.BarrioLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarrioLabel.Location = New System.Drawing.Point(26, 292)
        Me.BarrioLabel.Name = "BarrioLabel"
        Me.BarrioLabel.Size = New System.Drawing.Size(49, 15)
        Me.BarrioLabel.TabIndex = 11
        Me.BarrioLabel.Text = "BARRIO"
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TelefonoLabel.Location = New System.Drawing.Point(26, 339)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(65, 15)
        Me.TelefonoLabel.TabIndex = 12
        Me.TelefonoLabel.Text = "TELÉFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(26, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "EMAIL"
        '
        'BarrioComboBox
        '
        Me.BarrioComboBox.FormattingEnabled = True
        Me.BarrioComboBox.Location = New System.Drawing.Point(118, 289)
        Me.BarrioComboBox.Name = "BarrioComboBox"
        Me.BarrioComboBox.Size = New System.Drawing.Size(173, 21)
        Me.BarrioComboBox.TabIndex = 14
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(332, 95)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(316, 20)
        Me.BuscarTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RazonSocialRadioButton)
        Me.GroupBox1.Controls.Add(Me.CuitRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 45)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'RazonSocialRadioButton
        '
        Me.RazonSocialRadioButton.AutoSize = True
        Me.RazonSocialRadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RazonSocialRadioButton.Location = New System.Drawing.Point(109, 16)
        Me.RazonSocialRadioButton.Name = "RazonSocialRadioButton"
        Me.RazonSocialRadioButton.Size = New System.Drawing.Size(109, 19)
        Me.RazonSocialRadioButton.TabIndex = 1
        Me.RazonSocialRadioButton.TabStop = True
        Me.RazonSocialRadioButton.Text = "RAZÓN SOCIAL"
        Me.RazonSocialRadioButton.UseVisualStyleBackColor = True
        '
        'CuitRadioButton
        '
        Me.CuitRadioButton.AutoSize = True
        Me.CuitRadioButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CuitRadioButton.Location = New System.Drawing.Point(20, 15)
        Me.CuitRadioButton.Name = "CuitRadioButton"
        Me.CuitRadioButton.Size = New System.Drawing.Size(51, 19)
        Me.CuitRadioButton.TabIndex = 0
        Me.CuitRadioButton.TabStop = True
        Me.CuitRadioButton.Text = "CUIT"
        Me.CuitRadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ClienteLabel
        '
        Me.ClienteLabel.AutoSize = True
        Me.ClienteLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ClienteLabel.Location = New System.Drawing.Point(321, 27)
        Me.ClienteLabel.Name = "ClienteLabel"
        Me.ClienteLabel.Size = New System.Drawing.Size(243, 65)
        Me.ClienteLabel.TabIndex = 20
        Me.ClienteLabel.Text = "CLIENTES"
        '
        'LabelCodigoCliente
        '
        Me.LabelCodigoCliente.AutoSize = True
        Me.LabelCodigoCliente.Location = New System.Drawing.Point(23, 137)
        Me.LabelCodigoCliente.Name = "LabelCodigoCliente"
        Me.LabelCodigoCliente.Size = New System.Drawing.Size(0, 13)
        Me.LabelCodigoCliente.TabIndex = 22
        '
        'AgregarClienteButton
        '
        Me.AgregarClienteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AgregarClienteButton.BackColor = System.Drawing.Color.Green
        Me.AgregarClienteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.AgregarClienteButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarClienteButton.Image = CType(resources.GetObject("AgregarClienteButton.Image"), System.Drawing.Image)
        Me.AgregarClienteButton.Location = New System.Drawing.Point(19, 442)
        Me.AgregarClienteButton.Name = "AgregarClienteButton"
        Me.AgregarClienteButton.Size = New System.Drawing.Size(121, 68)
        Me.AgregarClienteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AgregarClienteButton.TabIndex = 24
        Me.AgregarClienteButton.Text = "AGREGAR"
        Me.AgregarClienteButton.TextColor = System.Drawing.Color.White
        '
        'AceptarButton
        '
        Me.AceptarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AceptarButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.AceptarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.AceptarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarButton.Image = CType(resources.GetObject("AceptarButton.Image"), System.Drawing.Image)
        Me.AceptarButton.Location = New System.Drawing.Point(157, 442)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(122, 68)
        Me.AceptarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AceptarButton.TabIndex = 25
        Me.AceptarButton.Text = "ACEPTAR"
        Me.AceptarButton.TextColor = System.Drawing.Color.White
        '
        'ModificarButton
        '
        Me.ModificarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ModificarButton.BackColor = System.Drawing.Color.OrangeRed
        Me.ModificarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ModificarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarButton.Image = CType(resources.GetObject("ModificarButton.Image"), System.Drawing.Image)
        Me.ModificarButton.Location = New System.Drawing.Point(297, 555)
        Me.ModificarButton.Name = "ModificarButton"
        Me.ModificarButton.Size = New System.Drawing.Size(146, 52)
        Me.ModificarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ModificarButton.TabIndex = 23
        Me.ModificarButton.Text = "MODIFICAR"
        Me.ModificarButton.TextColor = System.Drawing.Color.White
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.AgregarClienteButton)
        Me.Controls.Add(Me.ModificarButton)
        Me.Controls.Add(Me.LabelCodigoCliente)
        Me.Controls.Add(Me.ClienteLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.BarrioComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.BarrioLabel)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.CuitTextBox)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.RazonSocialLabel)
        Me.Controls.Add(Me.ClienteGridView)
        Me.DoubleBuffered = True
        Me.Name = "ClienteForm"
        Me.Text = "CLIENTES"
        CType(Me.ClienteGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClienteGridView As DataGridView
    Friend WithEvents RazonSocialLabel As Label
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DireccionLabel As Label
    Friend WithEvents BarrioLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BarrioComboBox As ComboBox
    Friend WithEvents BuscarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RazonSocialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CuitRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClienteLabel As System.Windows.Forms.Label
    Friend WithEvents LabelCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents AgregarClienteButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AceptarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ModificarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
