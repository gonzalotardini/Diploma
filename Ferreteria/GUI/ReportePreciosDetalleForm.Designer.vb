﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePreciosDetalleForm
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
        Me.CodLabel = New DevComponents.DotNetBar.LabelX()
        Me.FechaLabel = New DevComponents.DotNetBar.LabelX()
        Me.UsuarioLabel = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ImprimirButton = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodLabel
        '
        '
        '
        '
        Me.CodLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CodLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CodLabel.Location = New System.Drawing.Point(91, 47)
        Me.CodLabel.Name = "CodLabel"
        Me.CodLabel.Size = New System.Drawing.Size(75, 23)
        Me.CodLabel.TabIndex = 1
        Me.CodLabel.Text = "LabelX1"
        '
        'FechaLabel
        '
        '
        '
        '
        Me.FechaLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FechaLabel.Location = New System.Drawing.Point(302, 47)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(75, 23)
        Me.FechaLabel.TabIndex = 2
        Me.FechaLabel.Text = "LabelX2"
        '
        'UsuarioLabel
        '
        '
        '
        '
        Me.UsuarioLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UsuarioLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UsuarioLabel.Location = New System.Drawing.Point(560, 47)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(75, 23)
        Me.UsuarioLabel.TabIndex = 3
        Me.UsuarioLabel.Text = "LabelX3"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(172, 48)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "LabelX4"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(383, 48)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(123, 23)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "LabelX5"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(641, 47)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 6
        Me.LabelX6.Text = "LabelX6"
        '
        'ImprimirButton
        '
        Me.ImprimirButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ImprimirButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ImprimirButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ImprimirButton.Image = Global.GUI.My.Resources.Resources.Imprimir1
        Me.ImprimirButton.Location = New System.Drawing.Point(1165, 99)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(180, 51)
        Me.ImprimirButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ImprimirButton.TabIndex = 7
        Me.ImprimirButton.Text = "ButtonX1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1080, 292)
        Me.DataGridView1.TabIndex = 8
        '
        'ReportePreciosDetalleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 421)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.UsuarioLabel)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.CodLabel)
        Me.DoubleBuffered = True
        Me.Name = "ReportePreciosDetalleForm"
        Me.Text = "ReportePreciosDetalleForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CodLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents FechaLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents UsuarioLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ImprimirButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridView1 As DataGridView
End Class
