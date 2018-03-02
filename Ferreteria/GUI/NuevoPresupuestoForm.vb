Imports DAL
Imports BLL
Imports BIZ
Imports SL



Public Class NuevoPresupuestoForm


    Public Shared _CodigoCliente As Long
    Public Shared _Cuit As Long
    Public Shared _RazonSocial As String

    'Private _Cliente As Cliente


    'Public Sub New(Cliente As Cliente,)

    '    ' Esta llamada es exigida por el diseñador.

    '    InitializeComponent()

    '    _Cliente = Cliente       ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub


    Private Sub NuevoPresupuestoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ArticuloGridView1.AllowUserToAddRows = False

        Me.Icon = My.Resources.ico
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
        ArticuloGridView1.AllowUserToAddRows = False

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





    End Sub

    Private Sub TextBoxBuscarArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscarArticulo.TextChanged

    End Sub

    Private Sub ArticuloGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellContentClick


    End Sub

    Private Sub ArticuloGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticuloGridView1.CellContentDoubleClick



    End Sub

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

    Private Sub FinalizarButton_Click(sender As Object, e As EventArgs) Handles FinalizarButton.Click
        Dim _GestorPresupuesto As New GestorPresupuesto
        '  Dim _PresupuestoDAO As New PresupuestoDAO
        Dim _PresupuestoCabecera As New PresupuestoCabecera
        Dim _ListaDetalles As New List(Of PresupuestoDetalle)


        If MsgBox("¿Seguro desea finalizar el presupuesto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then

            Try
                Try

                    '_PresupuestoCabecera.Cod_Presupuesto = _PresupuestoDAO.ObtenerCodUltimoPresupuesto + 1
                    _PresupuestoCabecera.Cod_Cliente = Convert.ToInt32(CodigoClienteLabel.Text)
                    _PresupuestoCabecera.FechaInicio = Convert.ToDateTime(LabelFecha.Text)
                    _PresupuestoCabecera.FechaFin = DateAdd(DateInterval.Day, 15, Convert.ToDateTime(LabelFecha.Text))
                    _PresupuestoCabecera.Total = Convert.ToDecimal(TotalLabel.Text)

                Catch ex As Exception

                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Debe seleccionar un cliente")
                        Case "ENGLISH"
                            Throw New Exception("You must choose a customer")
                    End Select

                End Try




                For i = 0 To PresupuestoGridView1.RowCount - 1

                    Dim _PresupuestoDetalle As New PresupuestoDetalle

                    '_PresupuestoDetalle.Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto
                    _PresupuestoDetalle.Cantidad = PresupuestoGridView1.Rows(i).Cells("Cantidad").Value
                    _PresupuestoDetalle.Cod_Articulo = PresupuestoGridView1.Rows(i).Cells("Codigo").Value
                    _PresupuestoDetalle.Precio = PresupuestoGridView1.Rows(i).Cells("Precio").Value
                    _PresupuestoDetalle.Importe = PresupuestoGridView1.Rows(i).Cells("Importe").Value

                    _ListaDetalles.Add(_PresupuestoDetalle)

                Next


                _GestorPresupuesto.GenerarPresupuesto(_PresupuestoCabecera, _ListaDetalles)


                Dim el As New EventLogger


                el.WriteToErrorLog("Se guardo correctamente el presupuesto ", "Nuevo Presupuesto Form", "Información")

                Dim Mensaje = MsgBox("Se guardo correctamente el presupuesto", MsgBoxStyle.Information, "INFORMACION")




                PresupuestoGridView1.Rows.Clear()

                TotalLabel.Text = 0

                TextBoxBuscarArticulo.Text = ""
                Me.Show()
                TextBoxBuscarArticulo.Focus()

                CodigoClienteLabel.Text = ""

                TotalLabel.Text = ""
                CuitLabel.Text = ""
                RazonSocialLabel.Text = ""


            Catch ex As Exception

                Dim el As New ErrorLogger
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            End Try



        Else

        End If




    End Sub





    Public Sub TraerCliente(CodigoCliente As Long, RazonSocial As String, Cuit As Long)


        CodigoClienteLabel.Text = CodigoCliente
        RazonSocialLabel.Text = RazonSocial
        CuitLabel.Text = _Cuit


    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click

        Try


            If MsgBox("¿Seguro desea imprimir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then


                Dim PresupuestoCabecera As New PresupuestoCabecera
                Dim _ClasePDFpresupuesto As SL.ClasePDFpresupuesto
                Dim _ListaDetalle As New List(Of ClasePDFpresupuesto)



                Dim CantidadItems As Integer = PresupuestoGridView1.RowCount

                If CantidadItems = 0 Then
                    Select Case Principal.CulturaGlobal
                        Case "ESPAÑOL"
                            Throw New Exception("Error, debe agregar artículos")
                        Case "ENGLISH"
                            Throw New Exception("Error, you must add products")
                    End Select
                End If





                Dim _GestorPresupuesto As New GestorPresupuesto

                For i = 0 To (CantidadItems - 1)

                    _ClasePDFpresupuesto = New ClasePDFpresupuesto




                    _ClasePDFpresupuesto.Cantidad = CDec(PresupuestoGridView1.Rows(i).Cells("Cantidad").Value)
                    _ClasePDFpresupuesto.Descripcion = Microsoft.VisualBasic.Left(CStr((PresupuestoGridView1.Rows(i).Cells("Descripcion").Value)), 40)
                    _ClasePDFpresupuesto.Marca = CStr(PresupuestoGridView1.Rows(i).Cells("Marca").Value)
                    _ClasePDFpresupuesto.Medida = CStr(PresupuestoGridView1.Rows(i).Cells("UnidadMedida").Value)
                    _ClasePDFpresupuesto.Codigo = CLng(PresupuestoGridView1.Rows(i).Cells("Codigo").Value)
                    _ClasePDFpresupuesto.Precio = CDec(PresupuestoGridView1.Rows(i).Cells("Precio").Value)
                    _ClasePDFpresupuesto.Importe = CDec(PresupuestoGridView1.Rows(i).Cells("Importe").Value)




                    _ListaDetalle.Add(_ClasePDFpresupuesto)





                Next

                Try
                    PresupuestoCabecera.FechaInicio = CDate(LabelFecha.Text)
                    PresupuestoCabecera.Total = CDec(TotalLabel.Text)
                    PresupuestoCabecera.Cod_Cliente = (CodigoClienteLabel.Text).ToUpper
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

    Private Sub QuitarTodoButton_Click(sender As Object, e As EventArgs) Handles QuitarTodoButton.Click

        If PresupuestoGridView1.CurrentRow IsNot Nothing Then



            PresupuestoGridView1.Rows.Clear()






            TotalLabel.Text = 0


        End If



        TextBoxBuscarArticulo.Text = ""
        Me.Show()
        TextBoxBuscarArticulo.Focus()
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
                _CantidadFilas = PresupuestoGridView1.RowCount



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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        ClienteForm.Show()

        CodigoClienteLabel.Text = _CodigoCliente

    End Sub

    Private Sub ArticuloGridView1_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ArticuloGridView1.ColumnHeaderMouseDoubleClick

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
End Class