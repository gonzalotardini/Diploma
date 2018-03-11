Imports SL
Imports BLL
Imports BIZ
Imports DAL




Public Class PresupuestoDetalleForm

    Private Sub PresupuestoDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _PresupuestoCabecera As New PresupuestoCabecera
        Dim _PresupuestoDAO As New PresupuestoDAO
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
            CodigoPresupuestoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            QuitarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "QUITAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault
            FinalizarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FINALIZAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault
            RadioButtonCodigo.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            RadioButtonDescripcion.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            ModificarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault
        End If


        If Principal.CulturaGlobal = "ENGLISH" Then

            ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")


            Dim Cultura = "ENG-ENGLAND"
            'LINQ para el multiidioma
            CodigoClienteLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            FechaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FECHA" Select V.Value).FirstOrDefault
            RazonSocialLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            CodigoPresupuestoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            QuitarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "QUITAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault
            FinalizarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FINALIZAR" Select V.Value).FirstOrDefault
            ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault
            RadioButtonCodigo.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            RadioButtonDescripcion.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
             ModificarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault
        End If

        _PresupuestoCabecera.Cod_Presupuesto = PresupuestosForm._CodigoPresupuesto
        PresupuestoGridView.DataSource = _GestorPresupuesto.ObtenerPresupuestoDetalleBLL(_PresupuestoCabecera).Tables(0)
        'PresupuestoGridView.AllowUserToAddRows = False
        _PresupuestoCabecera = _PresupuestoDAO.ObtenerCabecera(_PresupuestoCabecera)

        _Cliente = _PresupuestoDAO.ObtenerDatosCliente(_PresupuestoCabecera)
        CodigoPresupuestoTextbox.Text = _PresupuestoCabecera.Cod_Presupuesto
        PresupuestoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        CodigoClienteTextBox.Text = _PresupuestoCabecera.Cod_Cliente
        FechaTextBox.Text = _PresupuestoCabecera.FechaInicio
        CuitTextBox.Text = _Cliente.Cuit
        RazonSocialTextBox.Text = _Cliente.RazonSocial


        TotalLabel.Text = _PresupuestoCabecera.Total



        'For Each row As DataGridViewRow In PresupuestoGridView.Rows

        '    If row.Index Mod 2 <> 0 Then
        '        row.DefaultCellStyle.BackColor = Color.Bisque
        '        ' row.Cells("Descripcion").Style.Font.Bold = True

        '    Else
        '        row.DefaultCellStyle.BackColor = Color.Aqua

        '    End If

        'Next




        ArticuloGridView1.Enabled = False
        GroupBox1.Enabled = False
        TextBoxBuscarArticulo.Enabled = False
        QuitarButton.Enabled = False

        ImprimirButton.Enabled = False
        FinalizarButton.Enabled = False



        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs)


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
                            ArticuloGridView1.AllowUserToAddRows = False
                        Else

                            Throw New Exception("Error, código debe ser numérico")

                        End If


                End Select

            Else

                Select Case e.KeyData
                    Case Keys.Enter
                        _Articulo.Descripcion = (TextBoxBuscarArticulo.Text).ToUpper


                        ArticuloGridView1.[DataSource] = GestorArticulo.ValidarDescripcionParaBusqueda(_Articulo).Tables(0)
                        ArticuloGridView1.AllowUserToAddRows = False
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

    Private Sub ArticuloGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellContentClick

    End Sub

    Private Sub ArticuloGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellDoubleClick
        Dim _GestorArticulo As New GestorArticulo
        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _ListaDetalles As New List(Of PresupuestoDetalle)

        Dim _Articulo As New Articulo
        Dim _ArticuloParaPresupuesto As New ArticuloParaPresupuesto
        Dim Fila As Integer = PresupuestoGridView.RowCount

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

                For Each row As DataGridViewRow In Me.PresupuestoGridView.Rows

                    If _Articulo.CodigoArticulo = row.Cells("Codigo Articulo").Value Then

                        _RespuestaInputBox = _RespuestaInputBox + Convert.ToDecimal(row.Cells("Cantidad").Value)
                        row.Cells(0).Value = _RespuestaInputBox
                        Bandera = 1
                        indice = row.Index


                    End If
                    _CantidadFilas = PresupuestoGridView.RowCount

                Next



                _Cantidad = Convert.ToDouble(_RespuestaInputBox)


            Else

                Throw New Exception("Error, cantidad debe ser numerico")

            End If

            If Bandera = 0 Then

                '

                Dim dt As DataTable = DirectCast(PresupuestoGridView.DataSource, DataTable)
                dt.Rows.Add()



                PresupuestoGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                PresupuestoGridView.Rows(Fila - 1).Cells(1).Value = _ArticuloParaPresupuesto.Cod_Articulo
                PresupuestoGridView.Rows(Fila - 1).Cells("Descripcion").Value = _ArticuloParaPresupuesto.Descripcion
                PresupuestoGridView.Rows(Fila - 1).Cells("CodigoBarras").Value = _ArticuloParaPresupuesto.CodigoDeBarras
                PresupuestoGridView.Rows(Fila - 1).Cells("Marca").Value = _ArticuloParaPresupuesto.Marca
                PresupuestoGridView.Rows(Fila - 1).Cells("UnidadMedida").Value = _ArticuloParaPresupuesto.SubUnidadDeMedida
                PresupuestoGridView.Rows(Fila - 1).Cells("Precio").Value = _ArticuloParaPresupuesto.Precio


                _Importe = _GestorPresupuesto.CalcularImporte(_Cantidad, _ArticuloParaPresupuesto.Precio)
                PresupuestoGridView.Rows(Fila - 1).Cells("importe").Value = _Importe
                PresupuestoGridView.Rows(Fila - 1).Cells("Cantidad").Value = _Cantidad

                _CantidadFilas = PresupuestoGridView.RowCount

            Else

                _Importe = _GestorPresupuesto.CalcularImporte(_Cantidad, _ArticuloParaPresupuesto.Precio)

                PresupuestoGridView.Item("Cantidad", indice).Value = _Cantidad



                PresupuestoGridView.Item("Importe", indice).Value = _Importe



            End If



            Dim _Filas = PresupuestoGridView.RowCount

            ' PresupuestoGridView.Rows.RemoveAt(PresupuestoGridView(_Filas))


            For i = 0 To _CantidadFilas - 1

                Dim _PresupuestoDetalle As New PresupuestoDetalle

                _PresupuestoDetalle.Importe = PresupuestoGridView.Rows(i).Cells("Importe").Value

                _ListaDetalles.Add(_PresupuestoDetalle)

            Next




            TotalLabel.Text = _GestorPresupuesto.CalcularTotal(_ListaDetalles)



            'For Each row As DataGridViewRow In PresupuestoGridView.Rows

            '    If row.Index Mod 2 <> 0 Then
            '        row.DefaultCellStyle.BackColor = Color.Bisque
            '        ' row.Cells("Descripcion").Style.Font.Bold = True

            '    Else
            '        row.DefaultCellStyle.BackColor = Color.Aqua

            '    End If

            'Next

            TextBoxBuscarArticulo.Text = ""
            Me.Show()
            TextBoxBuscarArticulo.Focus()

        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try

    End Sub

    Private Sub QuitarButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub QuitarTodoButton_Click(sender As Object, e As EventArgs)
        If PresupuestoGridView.CurrentRow IsNot Nothing Then



            PresupuestoGridView.Rows.Clear()






            TotalLabel.Text = 0


        End If



        TextBoxBuscarArticulo.Text = ""
        Me.Show()
        TextBoxBuscarArticulo.Focus()
    End Sub

    Private Sub FinalizarButton_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub ArticuloGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ArticuloGridView1.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In ArticuloGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click

        Dim _ArticuloDao As New ArticuloDAO


        ArticuloGridView1.Enabled = True
        GroupBox1.Enabled = True
        TextBoxBuscarArticulo.Enabled = True
        QuitarButton.Enabled = True

        ImprimirButton.Enabled = True
        FinalizarButton.Enabled = True


        RadioButtonDescripcion.Checked = True

        ArticuloGridView1.DataSource = _ArticuloDao.ObtenerPrimerosArticulos.Tables(0)

        ArticuloGridView1.AllowUserToAddRows = False
        ArticuloGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        For Each row As DataGridViewRow In ArticuloGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles QuitarButton.Click
        Try
            Dim _ListaDetalles As New List(Of PresupuestoDetalle)
            Dim _GestorPresupuesto As New GestorPresupuesto

            Dim _CantidadFilas As Integer


            If PresupuestoGridView.CurrentRow IsNot Nothing Then

                ' saco del presupuesto el articulo
                PresupuestoGridView.Rows.RemoveAt(PresupuestoGridView.CurrentRow.Index)
                _CantidadFilas = PresupuestoGridView.RowCount




                For i = 0 To _CantidadFilas - 1

                    Dim _PresupuestoDetalle As New PresupuestoDetalle

                    _PresupuestoDetalle.Importe = PresupuestoGridView.Rows(i).Cells("Importe").Value

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

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles FinalizarButton.Click



        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _PresupuestoDAO As New PresupuestoDAO
        Dim _PresupuestoCabecera As New PresupuestoCabecera
        Dim _ListaDetalles As New List(Of PresupuestoDetalle)
        Dim msg As String = ""
        Dim msg2 As String = ""

        Select Case Principal.CulturaGlobal
            Case "ESPAÑOL"
                msg = "¿Seguro desea finalizar el presupuesto?"
                msg2 = "Presupuesto guardado correctamente"
            Case "ENGLISH"
                msg = "Do you really want to finalize the budget?"
                msg2 = "Budget saved correcctly"
        End Select

        If MsgBox(msg, MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then

            Try

                '_PresupuestoCabecera.Cod_Presupuesto = _PresupuestoDAO.ObtenerCodUltimoPresupuesto + 1
                _PresupuestoCabecera.Cod_Presupuesto = Convert.ToInt32(CodigoPresupuestoTextbox.Text)
                _PresupuestoCabecera.Cod_Cliente = Convert.ToInt32(CodigoClienteTextBox.Text)
                _PresupuestoCabecera.FechaInicio = Convert.ToDateTime(FechaTextBox.Text)
                _PresupuestoCabecera.FechaFin = DateAdd(DateInterval.Day, 15, Convert.ToDateTime(FechaTextBox.Text))
                _PresupuestoCabecera.Total = Convert.ToDecimal(TotalLabel.Text)


                For i = 0 To PresupuestoGridView.RowCount - 1

                    Dim _PresupuestoDetalle As New PresupuestoDetalle

                    '_PresupuestoDetalle.Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto
                    _PresupuestoDetalle.Cantidad = PresupuestoGridView.Rows(i).Cells("Cantidad").Value
                    _PresupuestoDetalle.Cod_Articulo = PresupuestoGridView.Rows(i).Cells("Codigo Articulo").Value
                    _PresupuestoDetalle.Precio = PresupuestoGridView.Rows(i).Cells("Precio").Value
                    _PresupuestoDetalle.Importe = PresupuestoGridView.Rows(i).Cells("Importe").Value

                    _ListaDetalles.Add(_PresupuestoDetalle)

                Next


                _GestorPresupuesto.ActualizarPresupuesto(_PresupuestoCabecera, _ListaDetalles)


                Dim el As New EventLogger


                el.WriteToErrorLog("Se guardo correctamente el presupuesto ", "Nuevo Presupuesto Form", "Información")

                Dim Mensaje = MsgBox(msg2, MsgBoxStyle.Information, "INFORMACION")




                'PresupuestoGridView.Rows.Clear()

                TotalLabel.Text = 0

                TextBoxBuscarArticulo.Text = ""
                Me.Show()
                TextBoxBuscarArticulo.Focus()

                PresupuestosForm.PresupuestosDataGridView.AllowUserToAddRows = False
                PresupuestosForm.PresupuestosDataGridView.EditMode = False

                PresupuestosForm.PresupuestosDataGridView.DataSource = _PresupuestoDAO.ObtenerPresupuestos

                For Each row As DataGridViewRow In PresupuestosForm.PresupuestosDataGridView.Rows

                    If row.Index Mod 2 <> 0 Then
                        row.DefaultCellStyle.BackColor = Color.Bisque
                    Else
                        row.DefaultCellStyle.BackColor = Color.Aqua

                    End If

                Next

                Me.Close()

            Catch ex As Exception

                Dim el As New ErrorLogger
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            End Try



        Else

        End If

    End Sub

    Private Sub ImprimirButton_Click_1(sender As Object, e As EventArgs) Handles ImprimirButton.Click

        Try


            If MsgBox("¿Seguro desea imprimir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then


                Dim PresupuestoCabecera As New PresupuestoCabecera
                Dim _ClasePDFpresupuesto As SL.ClasePDFpresupuesto
                Dim _ListaDetalle As New List(Of ClasePDFpresupuesto)



                Dim CantidadItems As Integer = PresupuestoGridView.RowCount

                If CantidadItems = 0 Then
                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Error, debe agregar artículos")
                        Case "ENGLISH"
                            Throw New Exception("Error, you must add products")
                    End Select
                End If





                Dim _GestorPresupuesto As New GestorPresupuesto

                For i = 0 To (CantidadItems - 2)

                    _ClasePDFpresupuesto = New ClasePDFpresupuesto




                    _ClasePDFpresupuesto.Cantidad = CDec(PresupuestoGridView.Rows(i).Cells("Cantidad").Value)
                    _ClasePDFpresupuesto.Descripcion = Microsoft.VisualBasic.Left(CStr((PresupuestoGridView.Rows(i).Cells("Descripcion").Value)), 40)
                    _ClasePDFpresupuesto.Marca = CStr(PresupuestoGridView.Rows(i).Cells("Marca").Value)
                    _ClasePDFpresupuesto.Medida = CStr(PresupuestoGridView.Rows(i).Cells("UnidadMedida").Value)
                    _ClasePDFpresupuesto.Codigo = CLng(PresupuestoGridView.Rows(i).Cells("Codigo Articulo").Value)
                    _ClasePDFpresupuesto.Precio = CDec(PresupuestoGridView.Rows(i).Cells("Precio").Value)
                    _ClasePDFpresupuesto.Importe = CDec(PresupuestoGridView.Rows(i).Cells("Importe").Value)




                    _ListaDetalle.Add(_ClasePDFpresupuesto)





                Next

                Try
                    PresupuestoCabecera.FechaInicio = CDate(FechaTextBox.Text)
                    PresupuestoCabecera.Total = CDec(TotalLabel.Text)
                    PresupuestoCabecera.Cod_Cliente = (CodigoClienteTextBox.Text).ToUpper
                    PresupuestoCabecera.RazonSocial = (RazonSocialTextBox.Text).ToUpper
                    PresupuestoCabecera.Cod_Presupuesto = CodigoPresupuestoTextbox.Text
                Catch ex As Exception
                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Debe seleccionar un cliente")
                        Case "ENGLISH"
                            Throw New Exception("You must choose a customer")
                    End Select
                End Try


                _GestorPresupuesto.GenerarPresupuestoPDF(_ListaDetalle, PresupuestoCabecera)

            Else
            End If


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")



        End Try


    End Sub
End Class