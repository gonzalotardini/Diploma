<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubUnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosButtonn = New DevComponents.DotNetBar.ButtonX()
        Me.ClientesButton = New DevComponents.DotNetBar.ButtonX()
        Me.VentasButton = New DevComponents.DotNetBar.ButtonX()
        Me.PresupuestosButton = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PreciosButton = New DevComponents.DotNetBar.ButtonX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackUpButton = New DevComponents.DotNetBar.ButtonX()
        Me.IntegridadButton = New DevComponents.DotNetBar.ButtonX()
        Me.ContraseñaButton = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.VentasDiariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasSemanalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasMensualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosMasVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesMasGastadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtraToolStripMenuItem, Me.NuevoPresupuestoToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.BitacoraToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(939, 29)
        Me.MenuStrip1.TabIndex = 10
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadMedidaToolStripMenuItem, Me.SubUnidadMedidaToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.SubCategoriaToolStripMenuItem, Me.MarcasToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Enabled = False
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(44, 25)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'UnidadMedidaToolStripMenuItem
        '
        Me.UnidadMedidaToolStripMenuItem.Name = "UnidadMedidaToolStripMenuItem"
        Me.UnidadMedidaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.UnidadMedidaToolStripMenuItem.Text = "Unidad Medida"
        '
        'SubUnidadMedidaToolStripMenuItem
        '
        Me.SubUnidadMedidaToolStripMenuItem.Name = "SubUnidadMedidaToolStripMenuItem"
        Me.SubUnidadMedidaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SubUnidadMedidaToolStripMenuItem.Text = "SubUnidad Medida"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'SubCategoriaToolStripMenuItem
        '
        Me.SubCategoriaToolStripMenuItem.Name = "SubCategoriaToolStripMenuItem"
        Me.SubCategoriaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SubCategoriaToolStripMenuItem.Text = "Sub Categoria"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'NuevoPresupuestoToolStripMenuItem
        '
        Me.NuevoPresupuestoToolStripMenuItem.AutoSize = False
        Me.NuevoPresupuestoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NuevoPresupuestoToolStripMenuItem.Enabled = False
        Me.NuevoPresupuestoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoPresupuestoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoPresupuestoToolStripMenuItem.Name = "NuevoPresupuestoToolStripMenuItem"
        Me.NuevoPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.NuevoPresupuestoToolStripMenuItem.Text = "Nuevo Presupuesto"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.AutoSize = False
        Me.VentasToolStripMenuItem.Enabled = False
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.VentasToolStripMenuItem.Text = "Nueva Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.AutoSize = False
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosToolStripMenuItem1, Me.VentasDiariasToolStripMenuItem, Me.VentasSemanalesToolStripMenuItem, Me.VentasMensualesToolStripMenuItem, Me.ArticulosMasVendidosToolStripMenuItem, Me.ClientesMasGastadoresToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Enabled = False
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PreciosToolStripMenuItem1
        '
        Me.PreciosToolStripMenuItem1.Name = "PreciosToolStripMenuItem1"
        Me.PreciosToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.PreciosToolStripMenuItem1.Text = "Precios"
        '
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventosToolStripMenuItem, Me.ErroresToolStripMenuItem})
        Me.BitacoraToolStripMenuItem.Enabled = False
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(61, 25)
        Me.BitacoraToolStripMenuItem.Text = "Bitacora"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.EventosToolStripMenuItem.Text = "Eventos"
        '
        'ErroresToolStripMenuItem
        '
        Me.ErroresToolStripMenuItem.Name = "ErroresToolStripMenuItem"
        Me.ErroresToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ErroresToolStripMenuItem.Text = "Errores"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Enabled = False
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ArticulosButtonn
        '
        Me.ArticulosButtonn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ArticulosButtonn.BackColor = System.Drawing.Color.SteelBlue
        Me.ArticulosButtonn.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ArticulosButtonn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosButtonn.Image = Global.GUI.My.Resources.Resources.herramientas_del_empleado_de_mantenimiento
        Me.ArticulosButtonn.Location = New System.Drawing.Point(85, 108)
        Me.ArticulosButtonn.Name = "ArticulosButtonn"
        Me.ArticulosButtonn.Size = New System.Drawing.Size(214, 129)
        Me.ArticulosButtonn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ArticulosButtonn.TabIndex = 19
        Me.ArticulosButtonn.Text = "ARTICULOS"
        Me.ArticulosButtonn.TextColor = System.Drawing.Color.White
        '
        'ClientesButton
        '
        Me.ClientesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ClientesButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientesButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ClientesButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesButton.Image = Global.GUI.My.Resources.Resources.dependiente_con_corbata__1_
        Me.ClientesButton.Location = New System.Drawing.Point(318, 105)
        Me.ClientesButton.Name = "ClientesButton"
        Me.ClientesButton.Size = New System.Drawing.Size(212, 132)
        Me.ClientesButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ClientesButton.TabIndex = 20
        Me.ClientesButton.Text = "CLIENTES"
        Me.ClientesButton.TextColor = System.Drawing.Color.White
        '
        'VentasButton
        '
        Me.VentasButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.VentasButton.BackColor = System.Drawing.Color.Crimson
        Me.VentasButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.VentasButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasButton.Image = Global.GUI.My.Resources.Resources.datafono
        Me.VentasButton.Location = New System.Drawing.Point(318, 263)
        Me.VentasButton.Name = "VentasButton"
        Me.VentasButton.Size = New System.Drawing.Size(212, 132)
        Me.VentasButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.VentasButton.TabIndex = 21
        Me.VentasButton.Text = "VENTAS"
        Me.VentasButton.TextColor = System.Drawing.Color.White
        '
        'PresupuestosButton
        '
        Me.PresupuestosButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PresupuestosButton.BackColor = System.Drawing.Color.DarkOrange
        Me.PresupuestosButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.PresupuestosButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresupuestosButton.Image = Global.GUI.My.Resources.Resources.presupuesto
        Me.PresupuestosButton.Location = New System.Drawing.Point(85, 263)
        Me.PresupuestosButton.Name = "PresupuestosButton"
        Me.PresupuestosButton.Size = New System.Drawing.Size(214, 132)
        Me.PresupuestosButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PresupuestosButton.TabIndex = 22
        Me.PresupuestosButton.Text = "PRESUPUESTOS"
        Me.PresupuestosButton.TextColor = System.Drawing.Color.White
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(38, 32)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(395, 70)
        Me.ReflectionLabel1.TabIndex = 24
        Me.ReflectionLabel1.Text = "<b><font size=""+14""><i>FT</i><font color=""#B02B2C"">Ferreteria Tardini Hnos</font>" &
    "</font></b>"
        '
        'PreciosButton
        '
        Me.PreciosButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PreciosButton.BackColor = System.Drawing.Color.ForestGreen
        Me.PreciosButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.PreciosButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreciosButton.Image = Global.GUI.My.Resources.Resources.etiqueta
        Me.PreciosButton.Location = New System.Drawing.Point(547, 105)
        Me.PreciosButton.Name = "PreciosButton"
        Me.PreciosButton.Size = New System.Drawing.Size(212, 132)
        Me.PreciosButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.PreciosButton.TabIndex = 26
        Me.PreciosButton.Text = "PRECIOS"
        Me.PreciosButton.TextColor = System.Drawing.Color.White
        '
        'BackUpButton
        '
        Me.BackUpButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BackUpButton.BackColor = System.Drawing.Color.Black
        Me.BackUpButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.BackUpButton.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackUpButton.Image = Global.GUI.My.Resources.Resources.dispositivo_de_almacenamiento_de_datos
        Me.BackUpButton.Location = New System.Drawing.Point(547, 263)
        Me.BackUpButton.Name = "BackUpButton"
        Me.BackUpButton.Size = New System.Drawing.Size(214, 132)
        Me.BackUpButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.BackUpButton.TabIndex = 28
        Me.BackUpButton.Text = "BACK UP"
        Me.BackUpButton.TextColor = System.Drawing.Color.White
        '
        'IntegridadButton
        '
        Me.IntegridadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.IntegridadButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.IntegridadButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.IntegridadButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntegridadButton.Image = Global.GUI.My.Resources.Resources.circuito_integrado
        Me.IntegridadButton.Location = New System.Drawing.Point(85, 414)
        Me.IntegridadButton.Name = "IntegridadButton"
        Me.IntegridadButton.Size = New System.Drawing.Size(214, 132)
        Me.IntegridadButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.IntegridadButton.TabIndex = 29
        Me.IntegridadButton.Text = "INTEGRIDAD"
        Me.IntegridadButton.TextColor = System.Drawing.Color.White
        '
        'ContraseñaButton
        '
        Me.ContraseñaButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ContraseñaButton.BackColor = System.Drawing.Color.OliveDrab
        Me.ContraseñaButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ContraseñaButton.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaButton.Image = Global.GUI.My.Resources.Resources.palabras_clave
        Me.ContraseñaButton.Location = New System.Drawing.Point(318, 414)
        Me.ContraseñaButton.Name = "ContraseñaButton"
        Me.ContraseñaButton.Size = New System.Drawing.Size(214, 132)
        Me.ContraseñaButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContraseñaButton.TabIndex = 30
        Me.ContraseñaButton.Text = "CONTRASEÑA"
        Me.ContraseñaButton.TextColor = System.Drawing.Color.White
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(589, 447)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(139, 49)
        Me.LabelX1.TabIndex = 31
        Me.LabelX1.Text = "LabelX1"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'VentasDiariasToolStripMenuItem
        '
        Me.VentasDiariasToolStripMenuItem.Name = "VentasDiariasToolStripMenuItem"
        Me.VentasDiariasToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.VentasDiariasToolStripMenuItem.Text = "Ventas Diarias"
        '
        'VentasSemanalesToolStripMenuItem
        '
        Me.VentasSemanalesToolStripMenuItem.Name = "VentasSemanalesToolStripMenuItem"
        Me.VentasSemanalesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.VentasSemanalesToolStripMenuItem.Text = "Ventas Semanales"
        '
        'VentasMensualesToolStripMenuItem
        '
        Me.VentasMensualesToolStripMenuItem.Name = "VentasMensualesToolStripMenuItem"
        Me.VentasMensualesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.VentasMensualesToolStripMenuItem.Text = "Ventas Mensuales"
        '
        'ArticulosMasVendidosToolStripMenuItem
        '
        Me.ArticulosMasVendidosToolStripMenuItem.Name = "ArticulosMasVendidosToolStripMenuItem"
        Me.ArticulosMasVendidosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ArticulosMasVendidosToolStripMenuItem.Text = "Articulos mas vendidos"
        '
        'ClientesMasGastadoresToolStripMenuItem
        '
        Me.ClientesMasGastadoresToolStripMenuItem.Name = "ClientesMasGastadoresToolStripMenuItem"
        Me.ClientesMasGastadoresToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ClientesMasGastadoresToolStripMenuItem.Text = "Clientes mas gastadores"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(939, 558)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ContraseñaButton)
        Me.Controls.Add(Me.IntegridadButton)
        Me.Controls.Add(Me.BackUpButton)
        Me.Controls.Add(Me.PreciosButton)
        Me.Controls.Add(Me.ReflectionLabel1)
        Me.Controls.Add(Me.PresupuestosButton)
        Me.Controls.Add(Me.VentasButton)
        Me.Controls.Add(Me.ClientesButton)
        Me.Controls.Add(Me.ArticulosButtonn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExtraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubUnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosButtonn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ClientesButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents VentasButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PresupuestosButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PreciosButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackUpButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IntegridadButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContraseñaButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents VentasDiariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasSemanalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasMensualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosMasVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesMasGastadoresToolStripMenuItem As ToolStripMenuItem
End Class
