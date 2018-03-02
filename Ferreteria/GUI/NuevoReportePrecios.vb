Imports BIZ
Imports DAL
Imports BLL
Imports SL

Public Class NuevoReportePrecios

    Private Sub ReportePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        RadioButtonDESCRIPCION.Checked = True

        Select Case Principal.CulturaGlobal
            Case "ENGLISH"
                LabelDesde.Text = "FROM"
                LabelHasta.Text = "TO"
            Case "ESPAÑOL"
                LabelDesde.Text = "DESDE"
                LabelHasta.Text = "HASTA"
        End Select


        Dim _ArticuloDAO As New ArticuloDAO

        ArticulosGridView.DataSource = _ArticuloDAO.ObtenerPrimerosArticulos.Tables(0)

        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown



        Dim bandera As Integer = 0

        If RadioButtonCODIGO.Checked = True Then

            Dim Articulo As New Articulo
            Dim ArticuloBLL As New GestorArticulo

            Select Case e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscar.Text)
                        ArticulosGridView.DataSource = ArticuloBLL.ValidarCodigoDeBarrasParaBusqueda(Articulo)

                        TextBoxBuscar.SelectAll()

                        For Each row As DataGridViewRow In ArticulosGridView.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next




                    Else
                        bandera = 1
                    End If

                    '   Dim CantidadArticulos As Integer

                    'CantidadArticulos = DataGridView1.RowCount - 1
                    'Label14.Text = CantidadArticulos

            End Select


        End If

        If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

            Dim Articulo As New Articulo
            Dim GestorArticulo As New GestorArticulo

            Select Case e.KeyData

                Case Keys.Enter

                    Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
                    ArticulosGridView.DataSource = GestorArticulo.ValidarDescripcionParaBusqueda(Articulo).Tables(0)



                    For Each row As DataGridViewRow In ArticulosGridView.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    bandera = 0

                    RadioButtonDESCRIPCION.Checked = True
            End Select

            'Dim CantidadArticulos As Integer

            'CantidadArticulos = DataGridView1.RowCount - 1
            'Label14.Text = CantidadArticulos
        End If



        'Dim bandera As Integer = 0

        'Dim _fecha_Desde As Date
        'Dim _fecha_hasta As Date

        '_fecha_Desde = FechaDesde.Value
        '_fecha_hasta = FechaHasta.Value

        'If RadioButtonCODIGO.Checked = True Then

        '    Dim _Articulo As New Articulo
        '    Dim _ArticuloDao As New ArticuloDAO

        '    Select Case e.KeyData
        '        Case Keys.Enter
        '            Dim EsNumero As Boolean

        '            EsNumero = IsNumeric(TextBoxBuscar.Text)

        '            If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
        '                _Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscar.Text)
        '                DataGridView1.DataSource = _ArticuloDao.ObtenerPreciosHistoricosPorCodigo(_Articulo).Tables(0)

        '                TextBoxBuscar.SelectAll()


        '                For Each row As DataGridViewRow In DataGridView1.Rows

        '                    If row.Index Mod 2 <> 0 Then
        '                        row.DefaultCellStyle.BackColor = Color.Bisque
        '                    Else
        '                        row.DefaultCellStyle.BackColor = Color.Aqua

        '                    End If

        '                Next
        '                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        '            Else
        '                bandera = 1
        '            End If

        '            Dim CantidadArticulos As Integer

        '            CantidadArticulos = DataGridView1.RowCount - 1
        '            '   Label14.Text = CantidadArticulos

        '    End Select




        'End If

        'If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

        '    'Dim articulo2 As New Articulo
        '    ' Dim articuloMetodos2 As New ArticulosMetodos

        '    Select Case e.KeyData

        '        Case Keys.Enter



        '            Dim _Articulo As New Articulo
        '            Dim _ArticuloDao As New ArticuloDAO

        '            ' _Articulo.BuscarArticuloPorNombre(articulo2)


        '            _Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
        '            DataGridView1.DataSource = _ArticuloDao.ObtenerPreciosHistoricosPorDescripcion(_Articulo, _fecha_Desde, _fecha_hasta).Tables(0)



        '            For Each row As DataGridViewRow In DataGridView1.Rows

        '                If row.Index Mod 2 <> 0 Then
        '                    row.DefaultCellStyle.BackColor = Color.Bisque
        '                Else
        '                    row.DefaultCellStyle.BackColor = Color.Aqua

        '                End If

        '            Next
        '            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        '            bandera = 0

        '            RadioButtonDESCRIPCION.Checked = True
        '    End Select

        '    Dim CantidadArticulos As Integer

        '    CantidadArticulos = DataGridView1.RowCount - 1
        '    '  Label14.Text = CantidadArticulos
        'End If

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

    Private Sub ArticulosGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellContentClick

    End Sub

    Private Sub ArticulosGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellDoubleClick
        Dim _Articulo As New Articulo
        Dim _reporteDetalle As ReportePreciosDetalle
        Dim _ReporteBll As New GestorReporte

        Dim _fecha_Desde As Date
        Dim _fecha_hasta As Date
        Dim Fila = GridView1.Rows.Count

        _fecha_Desde = FechaDesde.Value
        _fecha_hasta = FechaHasta.Value


        Try

            _Articulo.CodigoArticulo = ArticulosGridView.CurrentRow.Cells(0).Value
            '_ReporteDao.BuscarPrecios(_Articulo, _fecha_Desde, _fecha_hasta)
            _reporteDetalle = _ReporteBll.ValidarFechas(_Articulo, _fecha_Desde, _fecha_hasta)

            GridView1.Rows.Add()
            GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Fila = GridView1.Rows.Count

            GridView1.Rows(Fila - 1).Cells(0).Value = _reporteDetalle.Cod_Articulo
            GridView1.Rows(Fila - 1).Cells(1).Value = _reporteDetalle.Descripcion
            GridView1.Rows(Fila - 1).Cells(2).Value = _reporteDetalle.Marca1
            GridView1.Rows(Fila - 1).Cells(3).Value = _reporteDetalle.SubUnidad
            GridView1.Rows(Fila - 1).Cells(4).Value = _reporteDetalle.PrecioInicial
            GridView1.Rows(Fila - 1).Cells(5).Value = _reporteDetalle.PrecioFinal
            GridView1.Rows(Fila - 1).Cells(6).Value = _reporteDetalle.CantidadPrecios
            GridView1.Rows(Fila - 1).Cells(7).Value = "%" & _reporteDetalle.PorcentajeAumento
            GridView1.Rows(Fila - 1).Cells(8).Value = _reporteDetalle.Fecha_Desde.ToString("dd/MM/yyyy")
            GridView1.Rows(Fila - 1).Cells(9).Value = _reporteDetalle.Fecha_Hasta.ToString("dd/MM/yyyy")

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try


    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If GridView1.CurrentRow IsNot Nothing Then
            ' saco del reporte el articulo
            GridView1.Rows.RemoveAt(GridView1.CurrentRow.Index)
        End If


    End Sub



    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonFinalizar.Click

        Dim listaDetalle As List(Of ReportePreciosDetalle)
        Dim item As ReportePreciosDetalle
        Dim GestorReporte As New GestorReporte
        Dim ReporteCabecera As New Reporte
        Dim msg As String = ""
        Dim msg2 = ""
        Dim reporteDao = New ReporteDAO

        Select Case Principal.CulturaGlobal
            Case "ESPAÑOL"
                msg = "¿Seguro desea finalizar el reporte?"
                msg2 = "¿Desea imprimir el reporte?"
            Case "ENGLISH"
                msg = "Do you really want to finish the report?"
                msg2 = "Do you want to print the report?"
        End Select

        Try
            If MsgBox(msg, MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then
                ReporteCabecera.Usuario = LogIn.Usuario.NombreUsuario
                listaDetalle = New List(Of ReportePreciosDetalle)

                For Each i As DataGridViewRow In GridView1.Rows

                    item = New ReportePreciosDetalle
                    item.Cod_Articulo = i.Cells(0).Value
                    item.Descripcion = i.Cells(1).Value
                    item.Marca1 = i.Cells(2).Value
                    item.SubUnidad = i.Cells(3).Value
                    item.PrecioInicial = i.Cells(4).Value
                    item.PrecioFinal = i.Cells(5).Value
                    item.CantidadPrecios = i.Cells(6).Value
                    item.PorcentajeAumento = Replace(i.Cells(7).Value, "%", "")
                    item.Fecha_Desde = i.Cells(8).Value
                    item.Fecha_Hasta = i.Cells(9).Value
                    listaDetalle.Add(item)

                Next

                'reporteDao.ImprimirReportePreciosDAO(ReporteCabecera, listaDetalle)

                GestorReporte.ValidarReporteAumentoDePrecios(ReporteCabecera, listaDetalle, Principal.CulturaGlobal)

                If MsgBox(msg2, MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then
                    ReporteCabecera.Cod_Reporte = reporteDao.ObtenerCodUltimoReportePrecios()
                    GestorReporte.ImprimirReportePrecios(ReporteCabecera, listaDetalle)
                End If

                Me.Hide()

            End If
        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try
    End Sub

    Private Sub ArticulosGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ArticulosGridView.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub
End Class