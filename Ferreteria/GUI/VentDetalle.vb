Imports BLL
Imports BIZ
Imports DAL
Imports SL

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

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            Dim ventaBll = New GestorVenta
            Dim ventaDao = New VentaDAO
            Dim cod As Long
            Dim msg As String = ""
            cod = Convert.ToInt64(CodigoPresupuestoTextbox.Text)
            Dim pregunta As String = ""

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    pregunta = "¿Seguro desea cancelar la venta?"

                Case "ENGLISH"
                    pregunta = "Do you realle want to cancel the sell?"

            End Select



            If MsgBox(pregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then
                ventaBll.CancelarVentaBll(cod)
                VentasForm.VentasDataGridView.DataSource = ventaDao.ObtenerVentas

                For Each row As DataGridViewRow In VentasForm.VentasDataGridView.Rows

                    If row.Index Mod 2 <> 0 Then
                        row.DefaultCellStyle.BackColor = Color.Bisque
                    Else
                        row.DefaultCellStyle.BackColor = Color.Aqua

                    End If

                Next
                Select Case Principal.CulturaGlobal
                    Case "ESPAÑOL"
                        msg = "La venta fue correctamente cancelada y se generó la nota de crédito"
                    Case "ENGLISH"
                        msg = "The sell was correctly cancelled and credit note was created"
                End Select


                MsgBox(msg, MsgBoxStyle.Information, "ATENTION")
                Me.Close()
            End If





        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
End Class