Imports BIZ
Imports DAL
Imports GUI

Public Class GestorReporte

    Public Function ValidarFechas(_Articulo As Articulo, _fecha_Desde As Date, _fecha_hasta As Date) As ReportePreciosDetalle
        Dim articuloDao = New ArticuloDAO
        Dim _Datatable As New DataTable
        Dim _reporteDao As New ReporteDAO

        Try
            If _fecha_Desde > _fecha_hasta.AddMinutes(1) Then

                Throw New Exception("Fecha desde debe ser anterior a fecha hasta")

            Else

                ' _Datatable = articuloDao.ObtenerPreciosHistoricosPorDescripcion(_Articulo, _fecha_Desde, _fecha_hasta).Tables(0)
                _Datatable = _reporteDao.BuscarPrecios(_Articulo, _fecha_Desde, _fecha_hasta)

                Return CalculosReportePrecios(_Datatable, _fecha_Desde, _fecha_hasta)


            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function


    Public Function CalculosReportePrecios(_Datatable As DataTable, _fecha_Desde As Date, _fecha_hasta As Date) As ReportePreciosDetalle
        Dim _ReportePreciosDetalle As New ReportePreciosDetalle
        Dim _Articulo = New Articulo


        _ReportePreciosDetalle.Cod_Articulo = _Datatable.Rows(0).Item(1)
        _ReportePreciosDetalle.PrecioInicial = _Datatable.Rows(0).Item("Precio")
        _ReportePreciosDetalle.CantidadPrecios = _Datatable.Rows.Count
        _ReportePreciosDetalle.PrecioFinal = _Datatable.Rows((_Datatable.Rows.Count) - 1).Item("Precio")
        _ReportePreciosDetalle.Fecha_Desde = _fecha_Desde
        _ReportePreciosDetalle.Fecha_Hasta = _fecha_hasta
        _ReportePreciosDetalle.PorcentajeAumento = FormatNumber(((_ReportePreciosDetalle.PrecioFinal - _ReportePreciosDetalle.PrecioInicial) / _ReportePreciosDetalle.PrecioInicial) * 100, 2)
        _ReportePreciosDetalle.Descripcion = _Datatable.Rows(0).Item("Descripcion")
        _ReportePreciosDetalle.Marca1 = _Datatable.Rows(0).Item("Marca")
        _ReportePreciosDetalle.SubUnidad = _Datatable.Rows(0).Item("Sub Unidad")


        Return _ReportePreciosDetalle

    End Function


    Public Sub ValidarReporteAumentoDePrecios(reporteCabecera As Reporte, listaDetalles As List(Of ReportePreciosDetalle), culturaGlobal As String)
        Dim ReporteFacade = New ReporteFacade

        Try
            If listaDetalles.Count = 0 Then
                Select Case culturaGlobal
                    Case "ESPAÑOL"
                        Throw New Exception("Error, debe agregar articulos al reporte")

                    Case "ENGLISH"
                        Throw New Exception("Error, you must add products to the report")
                    Case Else
                End Select
            End If

            reporteCabecera.Fecha = Now
            reporteCabecera.Tipo = "AUMENTO DE PRECIOS"

            ReporteFacade.GuardarReportePreciosFacade(reporteCabecera, listaDetalles, culturaGlobal)


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub


End Class
