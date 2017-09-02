<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePrecios
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCODIGO = New System.Windows.Forms.RadioButton()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 36)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonDESCRIPCION
        '
        Me.RadioButtonDESCRIPCION.AutoSize = True
        Me.RadioButtonDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDESCRIPCION.Location = New System.Drawing.Point(106, 13)
        Me.RadioButtonDESCRIPCION.Name = "RadioButtonDESCRIPCION"
        Me.RadioButtonDESCRIPCION.Size = New System.Drawing.Size(140, 22)
        Me.RadioButtonDESCRIPCION.TabIndex = 29
        Me.RadioButtonDESCRIPCION.TabStop = True
        Me.RadioButtonDESCRIPCION.Text = "DESCRIPCION"
        Me.RadioButtonDESCRIPCION.UseVisualStyleBackColor = True
        '
        'RadioButtonCODIGO
        '
        Me.RadioButtonCODIGO.AutoSize = True
        Me.RadioButtonCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCODIGO.Location = New System.Drawing.Point(4, 13)
        Me.RadioButtonCODIGO.Name = "RadioButtonCODIGO"
        Me.RadioButtonCODIGO.Size = New System.Drawing.Size(93, 22)
        Me.RadioButtonCODIGO.TabIndex = 28
        Me.RadioButtonCODIGO.TabStop = True
        Me.RadioButtonCODIGO.Text = "CODIGO"
        Me.RadioButtonCODIGO.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(77, 48)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(242, 20)
        Me.TextBoxBuscar.TabIndex = 33
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(77, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1130, 427)
        Me.DataGridView1.TabIndex = 32
        '
        'ReportePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ReportePrecios"
        Me.Text = "ReportePrecios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
