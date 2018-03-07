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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RazonSocialTextBox = New System.Windows.Forms.TextBox()
        Me.CuitTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BarrioComboBox = New System.Windows.Forms.ComboBox()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RazonSocialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CuitRadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelCodigoCliente = New System.Windows.Forms.Label()
        Me.AgregarClienteButton = New DevComponents.DotNetBar.ButtonX()
        Me.AceptarButton = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RAZÓN SOCIAL"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(26, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DIRECCIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(26, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "BARRIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(26, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "TELÉFONO"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(321, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 65)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CLIENTES"
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
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.OrangeRed
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(297, 555)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(146, 52)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 23
        Me.ButtonX1.Text = "MODIFICAR"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.AgregarClienteButton)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.LabelCodigoCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BuscarTextBox)
        Me.Controls.Add(Me.BarrioComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.CuitTextBox)
        Me.Controls.Add(Me.RazonSocialTextBox)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents RazonSocialTextBox As TextBox
    Friend WithEvents CuitTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BarrioComboBox As ComboBox
    Friend WithEvents BuscarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RazonSocialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CuitRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents AgregarClienteButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents AceptarButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
