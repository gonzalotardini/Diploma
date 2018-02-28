Imports BLL
Imports BIZ
Imports DAL


Public Class VentDetalle

    Private Sub VentDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Dim _GestorVenta As New GestorVenta
        Dim _VentaCabecera As New VentaCabecera
        Dim _VentaDao As New VentaDAO
        Dim _Cliente As New Cliente

        _VentaCabecera.Cod_Venta = VentasForm._CodigoVenta

        PresupuestoGridView.AllowUserToAddRows = False

        PresupuestoGridView.DataSource = _VentaDao.ObtenerVentaDetalle(_VentaCabecera).Tables(0)

        _VentaCabecera = _VentaDao.ObtenerCabecera(_VentaCabecera)


        _Cliente = _VentaDao.ObtenerDatosCliente(_VentaCabecera)



        CodigoPresupuestoTextbox.Text = _VentaCabecera.Cod_Venta



        PresupuestoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



        CodigoClienteTextBox.Text = _VentaCabecera.Cod_Cliente

        FechaTextBox.Text = _VentaCabecera.Fecha

        CuitTextBox.Text = _Cliente.Cuit
        RazonSocialTextBox.Text = _Cliente.RazonSocial


        TotalLabel.Text = _VentaCabecera.Total



        'For Each row As DataGridViewRow In PresupuestoGridView.Rows

        '    If row.Index Mod 2 <> 0 Then
        '        row.DefaultCellStyle.BackColor = Color.Bisque
        '        ' row.Cells("Descripcion").Style.Font.Bold = True

        '    Else
        '        row.DefaultCellStyle.BackColor = Color.Aqua

        '    End If

        'Next




        'ArticuloGridView1.Enabled = False
        ' GroupBox1.Enabled = False
        'TextBoxBuscarArticulo.Enabled = False
        ' QuitarButton.Enabled = False

        ' ImprimirButton.Enabled = False
        ' FinalizarButton.Enabled = False



        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

    End Sub
End Class