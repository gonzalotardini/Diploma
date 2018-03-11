﻿Imports BIZ
Imports DAL


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

    Public Function ObtenerReportePreciosDetalleBll(codReportePrecios As Long) As Object
        Try
            Dim reporteFacade = New ReporteFacade

            Return reporteFacade.ObtenerReportePreciosDetalleFacade(codReportePrecios)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerReportePreciosCabeceraBll(codReportePrecios As Long) As Reporte
        Try
            Dim reporteFacade = New ReporteFacade

            Return reporteFacade.ObtenerReportePreciosCabeceraFacade(codReportePrecios)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerArticulosMasVendidosBLL(cantidad As Integer, fecha_desde As Date, fecha_hasta As Date) As DataTable
        Try
            Dim reporteFacade = New ReporteFacade

            If fecha_desde > fecha_hasta.AddMinutes(1) Then

                Throw New Exception("Fecha desde debe ser menor a fecha hasta")
            Else
                Return reporteFacade.ObtenerArticulosMasVendidosFacade(cantidad, fecha_desde, fecha_hasta)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
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

    Public Function ObtenerReporteArticulosDetalle(codReporteArticulos As Long) As DataTable
        Try
            Dim reporteFacade As New ReporteFacade
            Return reporteFacade.obtenerReporteArticulosDetalle(codReporteArticulos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerReporteArticulosCabecera(codreporte As Long) As ReporteArticulosCabecera
        Try
            Dim reporteFacade As New ReporteFacade
            Return reporteFacade.obtenerReporteArticulosCabecera(codreporte)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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

    Public Sub ValidarReporteArticulosMasVendidos(reporteCabecera As ReporteArticulosCabecera, listaDetalle As List(Of ReporteArticulosMasVendidosDetalle), culturaGlobal As String)
        Dim ReporteFacade = New ReporteFacade

        Try
            If listaDetalle.Count = 0 Then
                Select Case culturaGlobal
                    Case "ESPAÑOL"
                        Throw New Exception("Error, debe agregar articulos al reporte")

                    Case "ENGLISH"
                        Throw New Exception("Error, you must add products to the report")
                    Case Else
                End Select
            End If

            'reporteCabecera.Fecha = Now
            reporteCabecera.Tipo = "ARTICULOS MAS VENDIDOS"

            ReporteFacade.GuardarReporteArticulosFacade(reporteCabecera, listaDetalle, culturaGlobal)


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub ImprimirReporteArticulosBll(reporteCabecera As ReporteArticulosCabecera, listaDetalle As List(Of ReporteArticulosMasVendidosDetalle))
        Try
            Dim reporteFacade = New ReporteFacade
            reporteFacade.ImprimirReporteArticulos(reporteCabecera, listaDetalle)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub ImprimirReportePrecios(reporteCabecera As Reporte, listaDetalle As List(Of ReportePreciosDetalle))
        Try
            Dim reporteFacade = New ReporteFacade

            reporteFacade.ImprimirReportePreciosFacade(reporteCabecera, listaDetalle)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
