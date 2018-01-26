Imports BIZ
Imports DAL

Public Class GestorReporte

    Public Function ValidarFechas(_Articulo As Articulo, _fecha_Desde As Date, _fecha_hasta As Date) As DataTable
        Dim articuloDao = New ArticuloDAO

        Try
            If _fecha_Desde > _fecha_hasta Then

                Throw New Exception("Fecha desde debe ser anterior a fecha hasta")

            Else

                Return articuloDao.ObtenerPreciosHistoricosPorDescripcion(_Articulo, _fecha_Desde, _fecha_hasta).Tables(0)


            End If



        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try







    End Function



End Class
