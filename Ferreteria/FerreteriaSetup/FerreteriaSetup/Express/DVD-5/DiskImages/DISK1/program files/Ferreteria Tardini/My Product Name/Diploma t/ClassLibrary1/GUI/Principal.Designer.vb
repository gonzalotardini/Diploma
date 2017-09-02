<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubUnidadMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesButton = New System.Windows.Forms.Button()
        Me.ArticulosButton = New System.Windows.Forms.Button()
        Me.PresupuestosButton = New System.Windows.Forms.Button()
        Me.VentasButton = New System.Windows.Forms.Button()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExtraToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.NuevoPresupuestoToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.BackUpToolStripMenuItem, Me.IntegridadToolStripMenuItem, Me.BitacoraToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(939, 29)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.AutoSize = False
        Me.PreciosToolStripMenuItem.Enabled = False
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'NuevoPresupuestoToolStripMenuItem
        '
        Me.NuevoPresupuestoToolStripMenuItem.AutoSize = False
        Me.NuevoPresupuestoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NuevoPresupuestoToolStripMenuItem.Enabled = False
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
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Enabled = False
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PreciosToolStripMenuItem1
        '
        Me.PreciosToolStripMenuItem1.Name = "PreciosToolStripMenuItem1"
        Me.PreciosToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.PreciosToolStripMenuItem1.Text = "Precios"
        '
        'BackUpToolStripMenuItem
        '
        Me.BackUpToolStripMenuItem.Enabled = False
        Me.BackUpToolStripMenuItem.Name = "BackUpToolStripMenuItem"
        Me.BackUpToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.BackUpToolStripMenuItem.Text = "BackUp"
        '
        'IntegridadToolStripMenuItem
        '
        Me.IntegridadToolStripMenuItem.Enabled = False
        Me.IntegridadToolStripMenuItem.Name = "IntegridadToolStripMenuItem"
        Me.IntegridadToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.IntegridadToolStripMenuItem.Text = "Integridad"
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
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ClientesButton
        '
        Me.ClientesButton.Enabled = False
        Me.ClientesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesButton.Location = New System.Drawing.Point(6, 142)
        Me.ClientesButton.Name = "ClientesButton"
        Me.ClientesButton.Size = New System.Drawing.Size(143, 54)
        Me.ClientesButton.TabIndex = 12
        Me.ClientesButton.Text = "CLIENTES"
        Me.ClientesButton.UseVisualStyleBackColor = True
        '
        'ArticulosButton
        '
        Me.ArticulosButton.Enabled = False
        Me.ArticulosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosButton.Location = New System.Drawing.Point(6, 83)
        Me.ArticulosButton.Name = "ArticulosButton"
        Me.ArticulosButton.Size = New System.Drawing.Size(143, 53)
        Me.ArticulosButton.TabIndex = 15
        Me.ArticulosButton.Text = "ARTÍCULOS"
        Me.ArticulosButton.UseVisualStyleBackColor = True
        '
        'PresupuestosButton
        '
        Me.PresupuestosButton.Enabled = False
        Me.PresupuestosButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresupuestosButton.Location = New System.Drawing.Point(6, 202)
        Me.PresupuestosButton.Name = "PresupuestosButton"
        Me.PresupuestosButton.Size = New System.Drawing.Size(143, 55)
        Me.PresupuestosButton.TabIndex = 16
        Me.PresupuestosButton.Text = "PRESUPUESTOS"
        Me.PresupuestosButton.UseVisualStyleBackColor = True
        '
        'VentasButton
        '
        Me.VentasButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasButton.Location = New System.Drawing.Point(6, 263)
        Me.VentasButton.Name = "VentasButton"
        Me.VentasButton.Size = New System.Drawing.Size(143, 50)
        Me.VentasButton.TabIndex = 18
        Me.VentasButton.Text = "VENTAS"
        Me.VentasButton.UseVisualStyleBackColor = True
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.GUI.My.Resources.Resources.fondo3
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.fondo3
        Me.PictureBox1.InitialImage = Global.GUI.My.Resources.Resources.fondo3
        Me.PictureBox1.Location = New System.Drawing.Point(155, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(751, 414)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 546)
        Me.Controls.Add(Me.VentasButton)
        Me.Controls.Add(Me.PresupuestosButton)
        Me.Controls.Add(Me.ArticulosButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClientesButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Principal"
        Me.Text = "PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExtraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubUnidadMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClientesButton As System.Windows.Forms.Button
    Friend WithEvents ArticulosButton As System.Windows.Forms.Button
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents PresupuestosButton As System.Windows.Forms.Button
    Friend WithEvents BackUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasButton As System.Windows.Forms.Button
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
