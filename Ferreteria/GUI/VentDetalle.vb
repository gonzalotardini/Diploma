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


        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma

        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma
            CodigoClienteLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            FechaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FECHA" Select V.Value).FirstOrDefault
            RazonSocialLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            CodigoVentaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANCELAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault

        End If


        If Principal.CulturaGlobal = "ENGLISH" Then

            ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")


            Dim Cultura = "ENG-ENGLAND"
            'LINQ para el multiidioma
            CodigoClienteLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            FechaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FECHA" Select V.Value).FirstOrDefault
            RazonSocialLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            CodigoVentaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANCELAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault


        End If

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

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RazonSocialLabel_Click(sender As Object, e As EventArgs) Handles RazonSocialLabel.Click

    End Sub

    Private Sub CodigoClienteLabel_Click(sender As Object, e As EventArgs) Handles CodigoClienteLabel.Click

    End Sub

    Private Sub CuitLabel_Click(sender As Object, e As EventArgs) Handles CuitLabel.Click

    End Sub

    Private Sub FechaLabel_Click(sender As Object, e As EventArgs) Handles FechaLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CodigoVentaLabel.Click

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
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

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click
        Try
            Dim msg As String = ""

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    msg = "¿Seguro desea imprimir?"
                Case "ENGLISH"
                    msg = "Do you really want to print?"

            End Select


            If MsgBox(msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then


                Dim ventaCabecera As New VentaCabecera
                Dim _ClasePDFVenta As SL.ClaseVentaPDF
                Dim _ListaDetalle As New List(Of ClaseVentaPDF)



                Dim CantidadItems As Integer = PresupuestoGridView.RowCount

                If CantidadItems = 0 Then
                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Error, debe agregar artículos")
                        Case "ENGLISH"
                            Throw New Exception("Error, you must add products")
                    End Select
                End If





                Dim gestorVenta As New GestorVenta

                For i = 0 To (CantidadItems - 1)

                    _ClasePDFVenta = New ClaseVentaPDF




                    _ClasePDFVenta.Cantidad = CDec(PresupuestoGridView.Rows(i).Cells("Cantidad").Value)
                    _ClasePDFVenta.Descripcion = Microsoft.VisualBasic.Left(CStr((PresupuestoGridView.Rows(i).Cells("Descripcion").Value)), 40)
                    _ClasePDFVenta.Marca = CStr(PresupuestoGridView.Rows(i).Cells("Marca").Value)
                    _ClasePDFVenta.Medida = CStr(PresupuestoGridView.Rows(i).Cells("UnidadMedida").Value)
                    _ClasePDFVenta.Codigo = CLng(PresupuestoGridView.Rows(i).Cells("Codigo Articulo").Value)
                    _ClasePDFVenta.Precio = CDec(PresupuestoGridView.Rows(i).Cells("Precio").Value)
                    _ClasePDFVenta.Importe = CDec(PresupuestoGridView.Rows(i).Cells("Importe").Value)




                    _ListaDetalle.Add(_ClasePDFVenta)





                Next

                Try
                    ventaCabecera.Fecha = (FechaTextBox.Text)
                    ventaCabecera.Total = (TotalLabel.Text)
                    ventaCabecera.Cod_Cliente = (CodigoClienteTextBox.Text).ToUpper
                    ventaCabecera.RazonSocial = (RazonSocialTextBox.Text).ToUpper
                    ventaCabecera.Cod_Venta = CodigoPresupuestoTextbox.Text
                Catch ex As Exception
                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Debe seleccionar un cliente")
                        Case "ENGLISH"
                            Throw New Exception("You must choose a customer")
                    End Select
                End Try


                gestorVenta.GenerarVentaPDF(_ListaDetalle, ventaCabecera)

            Else
            End If


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")



        End Try
    End Sub
End Class