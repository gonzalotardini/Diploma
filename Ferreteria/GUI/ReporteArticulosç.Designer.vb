<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteArticulosç
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteArticulosç))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewX1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Red
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.Location = New System.Drawing.Point(749, 514)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(148, 59)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "ButtonX1"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.Location = New System.Drawing.Point(358, 514)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(148, 59)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ButtonX2.TabIndex = 18
        Me.ButtonX2.Text = "ButtonX1"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        '
        '
        '
        Me.Label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(358, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 68)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "LabelX1"
        Me.Label1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Location = New System.Drawing.Point(340, 162)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(571, 319)
        Me.DataGridViewX1.TabIndex = 22
        '
        'ReporteArticulosç
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 597)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonX2)
        Me.DoubleBuffered = True
        Me.Name = "ReporteArticulosç"
        Me.Text = "ReporteArticulosç"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX1 As DataGridView
End Class
