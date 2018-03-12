<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePrecios
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportePrecios))
        Me.ReportesPreciosLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CancelarButton = New DevComponents.DotNetBar.ButtonX()
        Me.VerButton = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportesPreciosLabel
        '
        Me.ReportesPreciosLabel.AutoSize = True
        Me.ReportesPreciosLabel.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ReportesPreciosLabel.Location = New System.Drawing.Point(432, 44)
        Me.ReportesPreciosLabel.Name = "ReportesPreciosLabel"
        Me.ReportesPreciosLabel.Size = New System.Drawing.Size(226, 65)
        Me.ReportesPreciosLabel.TabIndex = 8
        Me.ReportesPreciosLabel.Text = "label rep"
        Me.ReportesPreciosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(370, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(488, 314)
        Me.DataGridView1.TabIndex = 10
        '
        'CancelarButton
        '
        Me.CancelarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelarButton.BackColor = System.Drawing.Color.Red
        Me.CancelarButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.CancelarButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CancelarButton.Image = CType(resources.GetObject("CancelarButton.Image"), System.Drawing.Image)
        Me.CancelarButton.Location = New System.Drawing.Point(710, 472)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(148, 59)
        Me.CancelarButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelarButton.TabIndex = 19
        Me.CancelarButton.Text = "ButtonX2"
        Me.CancelarButton.TextColor = System.Drawing.Color.White
        '
        'VerButton
        '
        Me.VerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.VerButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.VerButton.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.VerButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VerButton.Image = CType(resources.GetObject("VerButton.Image"), System.Drawing.Image)
        Me.VerButton.Location = New System.Drawing.Point(370, 472)
        Me.VerButton.Name = "VerButton"
        Me.VerButton.Size = New System.Drawing.Size(148, 59)
        Me.VerButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.VerButton.TabIndex = 18
        Me.VerButton.Text = "ButtonX1"
        Me.VerButton.TextColor = System.Drawing.Color.White
        '
        'ReportePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 595)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.VerButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ReportesPreciosLabel)
        Me.DoubleBuffered = True
        Me.Name = "ReportePrecios"
        Me.Text = "Reportes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportesPreciosLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents CancelarButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents VerButton As DevComponents.DotNetBar.ButtonX
End Class
