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

End Class
