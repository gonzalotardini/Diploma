Imports System.Transactions
Imports BIZ

Public Class ReporteFacade

    Public Function BuscarPreciosFacade(_Articulo As Articulo, _fecha_desde As Date, _fecha_hasta As Date) As DataTable

        Try

            Dim ReporteDao As New ReporteDAO

            Return ReporteDao.BuscarPrecios(_Articulo, _fecha_desde, _fecha_hasta)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Se encagra de las llamadas a la DAL para guardar cabecera y detalle del reporte
    ''' </summary>
    ''' <param name="reporteCabecera"></param>
    ''' <param name="listaDetalles"></param>
    ''' <param name="culturaGlobal"></param>
    Public Sub GuardarReportePreciosFacade(reporteCabecera As Reporte, listaDetalles As List(Of ReportePreciosDetalle), culturaGlobal As String)
        Dim reportesDAL As New ReporteDAO
        Dim codReporte As Integer

        Try
            Using ts As TransactionScope = New TransactionScope
                reportesDAL.GuardarReportePreciosCabecera(reporteCabecera)
                codReporte = reportesDAL.ObtenerCodUltimoReportePrecios()

                For Each i As ReportePreciosDetalle In listaDetalles
                    i.Cod_Reporte = codReporte
                    reportesDAL.GuardarReportePreciosDetalle(i)
                Next

                ts.Complete()
            End Using


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try



    End Sub

    Public Function ObtenerReportePreciosDetalleFacade(codReportePrecios As Long) As Object
        Try
            Dim reporteDal = New ReporteDAO

            Return reporteDal.ObtenerReportePreciosDetalle(codReportePrecios)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerReportePreciosCabeceraFacade(codReportePrecios As Long) As Reporte
        Try
            Dim reporteDao = New ReporteDAO
            Return reporteDao.ObtenerReportePreciosCabecera(codReportePrecios)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Llama a la Dal para obtener el detalle del reporte
    ''' </summary>
    ''' <param name="cantidad"></param>
    ''' <param name="fecha_desde"></param>
    ''' <param name="fecha_hasta"></param>
    ''' <returns></returns>
    Public Function ObtenerArticulosMasVendidosFacade(cantidad As Integer, fecha_desde As Date, fecha_hasta As Date) As DataTable
        Try
            Dim reporteDal = New ReporteDAO
            Return reporteDal.ArticulosMasVendidos(cantidad, fecha_desde, fecha_hasta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ImprimirReportePreciosFacade(reporteCabecera As Reporte, listaDetalle As List(Of ReportePreciosDetalle))
        Try
            Dim reporteDao = New ReporteDAO
            reporteDao.ImprimirReportePreciosDAO(reporteCabecera, listaDetalle)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Se encagra de las llamadas a la DAL para guardar cabecera y detalle del reporte
    ''' </summary>
    ''' <param name="reporteCabecera"></param>
    ''' <param name="listaDetalle"></param>
    ''' <param name="culturaGlobal"></param>
    Public Sub GuardarReporteArticulosFacade(reporteCabecera As ReporteArticulosCabecera, listaDetalle As List(Of ReporteArticulosMasVendidosDetalle), culturaGlobal As String)
        Dim reportesDAL As New ReporteDAO
        Dim codReporte As Integer

        Try
            Using ts As TransactionScope = New TransactionScope
                reportesDAL.GuardarReporteArticulosCabecera(reporteCabecera)
                codReporte = reportesDAL.ObtenerCodUltimoReporteArticulos()

                For Each i As ReporteArticulosMasVendidosDetalle In listaDetalle
                    i.Cod_Reporte = codReporte
                    reportesDAL.GuardarReporteArticulosDetalle(i)
                Next

                ts.Complete()
            End Using


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Function obtenerReporteArticulosCabecera(codreporte As Long) As ReporteArticulosCabecera
        Try
            Dim reporteDao = New ReporteDAO
            Return reporteDao.ObtenerReporteArticulosCabecera(codreporte)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function obtenerReporteArticulosDetalle(codReporteArticulos As Long) As DataTable
        Try
            Dim reporteDao = New ReporteDAO
            Return reporteDao.ObtenerReporteArticulosDetalle(codReporteArticulos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ImprimirReporteArticulos(reporteCabecera As ReporteArticulosCabecera, listaDetalle As List(Of ReporteArticulosMasVendidosDetalle))
        Try
            Dim reporteDao = New ReporteDAO
            reporteDao.ImprimirReporteArticulossDAO(reporteCabecera, listaDetalle)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
