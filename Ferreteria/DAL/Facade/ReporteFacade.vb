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
End Class
