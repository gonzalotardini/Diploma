Imports DAL
Imports BLL
Imports BIZ
Imports SL


Public Class NuevaVentaForm


    Public Shared _CodigoCliente As Long
    Public Shared _Cuit As Long
    Public Shared _RazonSocial As String

    Private Sub QuitarButton_Click(sender As Object, e As EventArgs) Handles QuitarButton.Click


        Try
            Dim _ListaDetalles As New List(Of PresupuestoDetalle)
            Dim _GestorPresupuesto As New GestorPresupuesto

            Dim _CantidadFilas As Integer


            If PresupuestoGridView1.CurrentRow IsNot Nothing Then

                ' saco del presupuesto el articulo
                PresupuestoGridView1.Rows.RemoveAt(PresupuestoGridView1.CurrentRow.Index)
                _CantidadFilas = PresupuestoGridView1.RowCount




                For i = 0 To _CantidadFilas - 1

                    Dim _PresupuestoDetalle As New PresupuestoDetalle

                    _PresupuestoDetalle.Importe = PresupuestoGridView1.Rows(i).Cells("Importe").Value

                    _ListaDetalles.Add(_PresupuestoDetalle)

                Next




                TotalLabel.Text = _GestorPresupuesto.CalcularTotal(_ListaDetalles)

            End If




            Me.Show()
            TextBoxBuscarArticulo.Focus()

        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try

    End Sub

    Private Sub NuevaVentaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ArticuloDAO As New ArticuloDAO
        LabelFecha.Text = Today

        Try
            ArticuloGridView1.DataSource = ArticuloDAO.ObtenerPrimerosArticulos.Tables(0)


            ArticuloGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception

        End Try





        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir


        RadioButtonDescripcion.Checked = True





        For Each row As DataGridViewRow In ArticuloGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

    End Sub

    Private Sub TextBoxBuscarArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscarArticulo.KeyDown
        Dim GestorArticulo As New GestorArticulo
        Dim _Articulo As New Articulo

        Try



            If RadioButtonCodigo.Checked = True Then
                Select Case e.KeyData
                    Case Keys.Enter

                        Dim EsNumero As Boolean

                        EsNumero = IsNumeric(TextBoxBuscarArticulo.Text)

                        If EsNumero = True Then

                            _Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscarArticulo.Text)


                            ArticuloGridView1.[DataSource] = GestorArticulo.ValidarCodigoDeBarrasParaBusqueda(_Articulo)

                        Else

                            Throw New Exception("Error, código debe ser numérico")

                        End If


                End Select

            Else

                Select Case e.KeyData
                    Case Keys.Enter
                        _Articulo.Descripcion = (TextBoxBuscarArticulo.Text).ToUpper


                        ArticuloGridView1.[DataSource] = GestorArticulo.ValidarDescripcionParaBusqueda(_Articulo).Tables(0)

                End Select

            End If



        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try






        For Each row As DataGridViewRow In ArticuloGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

        ArticuloGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub TextBoxBuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscarArticulo.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ClienteForm.Show()


    End Sub


    Public Sub TraerCliente(CodigoCliente As Long, RazonSocial As String, Cuit As Long)


        CodigoClienteLabel.Text = CodigoCliente
        RazonSocialLabel.Text = RazonSocial
        CuitLabel.Text = _Cuit


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub QuitarTodoButton_Click(sender As Object, e As EventArgs) Handles QuitarTodoButton.Click

    End Sub

    Private Sub ArticuloGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellContentClick

    End Sub

    Private Sub ArticuloGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellDoubleClick
        Dim _GestorArticulo As New GestorArticulo
        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _ListaDetalles As New List(Of PresupuestoDetalle)

        Dim _Articulo As New Articulo
        Dim _ArticuloParaPresupuesto As New ArticuloParaPresupuesto
        Dim Fila As Integer = PresupuestoGridView1.RowCount

        Dim _RespuestaInputBox As String
        Dim _Importe As Decimal
        Dim _Cantidad As String
        Dim _CantidadFilas As Integer
        Dim Bandera As Integer = 0
        Dim indice As Integer





        _Articulo.CodigoArticulo = ArticuloGridView1.CurrentRow.Cells(0).Value

        Try

            _ArticuloParaPresupuesto = _GestorArticulo.ObtenerArticuloPorCodigo(_Articulo)






            Dim _EsNumero As Boolean

            _RespuestaInputBox = InputBox("Introduza cantidad", "ATENCIÓN", CStr(1))

            _EsNumero = IsNumeric(_RespuestaInputBox)

            If _EsNumero = True Then


                If _RespuestaInputBox.Contains(".") = True Then

                    _RespuestaInputBox = Replace(_RespuestaInputBox, ".", ",")

                Else


                End If


                'Comparo para ver si este producto ya fue agregado al detalle entonces no agrego otra fila sino
                'que al producto que ya esta le suma la cantidad.

                For Each row As DataGridViewRow In Me.PresupuestoGridView1.Rows

                    If _Articulo.CodigoArticulo = row.Cells("Codigo").Value Then

                        _RespuestaInputBox = _RespuestaInputBox + Convert.ToDecimal(row.Cells("Cantidad").Value)
                        row.Cells(0).Value = _RespuestaInputBox
                        Bandera = 1
                        indice = row.Index


                    End If

                Next



                _Cantidad = Convert.ToDouble(_RespuestaInputBox)


            Else

                Throw New Exception("Error, cantidad debe ser numerico")

            End If

            If Bandera = 0 Then

                PresupuestoGridView1.Rows.Add()
                PresupuestoGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                PresupuestoGridView1.Rows(Fila).Cells(1).Value = _ArticuloParaPresupuesto.Cod_Articulo
                PresupuestoGridView1.Rows(Fila).Cells("Descripcion").Value = _ArticuloParaPresupuesto.Descripcion
                PresupuestoGridView1.Rows(Fila).Cells("CodigoBarras").Value = _ArticuloParaPresupuesto.CodigoDeBarras
                PresupuestoGridView1.Rows(Fila).Cells("Marca").Value = _ArticuloParaPresupuesto.Marca
                PresupuestoGridView1.Rows(Fila).Cells("UnidadMedida").Value = _ArticuloParaPresupuesto.SubUnidadDeMedida
                PresupuestoGridView1.Rows(Fila).Cells("Precio").Value = _ArticuloParaPresupuesto.Precio


                _Importe = _GestorPresupuesto.CalcularImporte(_Cantidad, _ArticuloParaPresupuesto.Precio)
                PresupuestoGridView1.Rows(Fila).Cells("importe").Value = _Importe
                PresupuestoGridView1.Rows(Fila).Cells("Cantidad").Value = _Cantidad

                _CantidadFilas = PresupuestoGridView1.RowCount

            Else

                _Importe = _GestorPresupuesto.CalcularImporte(_Cantidad, _ArticuloParaPresupuesto.Precio)

                PresupuestoGridView1.Item("Cantidad", indice).Value = _Cantidad



                PresupuestoGridView1.Item("Importe", indice).Value = _Importe



            End If








            For i = 0 To _CantidadFilas - 1

                Dim _PresupuestoDetalle As New PresupuestoDetalle

                _PresupuestoDetalle.Importe = PresupuestoGridView1.Rows(i).Cells("Importe").Value

                _ListaDetalles.Add(_PresupuestoDetalle)

            Next




            TotalLabel.Text = _GestorPresupuesto.CalcularTotal(_ListaDetalles)


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try

    End Sub

    Private Sub FinalizarButton_Click(sender As Object, e As EventArgs) Handles FinalizarButton.Click


        Dim _GestorVenta As New GestorVenta
        Dim _VentaDao As New VentaDAO
        Dim _VentaCabecera As New VentaCabecera
        Dim _ListaDetalles As New List(Of VentaDetalle)



        If MsgBox("¿Seguro desea finalizar la venta?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Try

                '_PresupuestoCabecera.Cod_Presupuesto = _PresupuestoDAO.ObtenerCodUltimoPresupuesto + 1
                _VentaCabecera.Cod_Cliente = Convert.ToInt32(CodigoClienteLabel.Text)
                _VentaCabecera.Fecha = Convert.ToDateTime(LabelFecha.Text)
                _VentaCabecera.Total = Convert.ToDecimal(TotalLabel.Text)


                For i = 0 To PresupuestoGridView1.RowCount - 1

                    Dim _VentaDetalle As New VentaDetalle

                    '_PresupuestoDetalle.Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto
                    _VentaDetalle.Cantidad = PresupuestoGridView1.Rows(i).Cells("Cantidad").Value
                    _VentaDetalle.Cod_Articulo = PresupuestoGridView1.Rows(i).Cells("Codigo").Value
                    _VentaDetalle.Precio = PresupuestoGridView1.Rows(i).Cells("Precio").Value
                    _VentaDetalle.Importe = PresupuestoGridView1.Rows(i).Cells("Importe").Value

                    _ListaDetalles.Add(_VentaDetalle)

                Next


                _GestorVenta.GenerarVenta(_VentaCabecera, _ListaDetalles)


                Dim el As New EventLogger


                el.WriteToErrorLog("Se creo correctamente la venta ", "Nuevo venta form", "Información")

                Dim Mensaje = MsgBox("Se creo correctamente la venta", MsgBoxStyle.Information, "INFORMACION")









            Catch ex As Exception

                Dim el As New ErrorLogger
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            End Try



        Else

        End If


        Try
            If MsgBox("¿Desea imprimir comprobante de venta?", MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

                Dim VentaCabecera As New VentaCabecera

                Dim _ClaseVentaPdf As SL.ClaseVentaPDF

                Dim _ListaDetalle As New List(Of ClaseVentaPDF)


                Dim CantidadItems As Integer = PresupuestoGridView1.RowCount



                '  Dim _GestorVenta As New GestorVenta

                For i = 0 To (CantidadItems - 1)

                    _ClaseVentaPdf = New ClaseVentaPDF




                    _ClaseVentaPdf.Cantidad = CDec(PresupuestoGridView1.Rows(i).Cells("Cantidad").Value)
                    _ClaseVentaPdf.Descripcion = Microsoft.VisualBasic.Left(CStr((PresupuestoGridView1.Rows(i).Cells("Descripcion").Value)), 40)
                    _ClaseVentaPdf.Marca = CStr(PresupuestoGridView1.Rows(i).Cells("Marca").Value)
                    _ClaseVentaPdf.Medida = CStr(PresupuestoGridView1.Rows(i).Cells("UnidadMedida").Value)
                    _ClaseVentaPdf.Codigo = CLng(PresupuestoGridView1.Rows(i).Cells("Codigo").Value)
                    _ClaseVentaPdf.Precio = CDec(PresupuestoGridView1.Rows(i).Cells("Precio").Value)
                    _ClaseVentaPdf.Importe = CDec(PresupuestoGridView1.Rows(i).Cells("Importe").Value)




                    _ListaDetalle.Add(_ClaseVentaPdf)





                Next
                VentaCabecera.Fecha = CDate(LabelFecha.Text)
                VentaCabecera.Total = CDec(TotalLabel.Text)
                VentaCabecera.Cod_Cliente = (CodigoClienteLabel.Text).ToUpper

                _GestorVenta.GenerarVentaPDF(_ListaDetalle, _VentaCabecera)

            End If


           




        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")



        End Try
      






        PresupuestoGridView1.Rows.Clear()

        TotalLabel.Text = 0

        TextBoxBuscarArticulo.Text = ""
        Me.Show()
        TextBoxBuscarArticulo.Focus()




      



    End Sub
End Class