Imports BIZ

Public Class ArticuloFacade

    Public Sub AgregarArticuloFacade(ByVal Articulo As Articulo, ByVal Fecha As Date)


        Dim ArticuloDao As New ArticuloDAO
        Dim ModificacionesPreciosDao As New ModificacionesPreciosDAO

        Try

            ArticuloDao.CargarArticulo(Articulo) 'Cargo el artículo en la tabla artículos
            ModificacionesPreciosDao.MovimientoPrecios(Articulo, Fecha) 'Cargo el precio histórico en la tabla de precios modificados


        Catch ex As Exception

            Throw New Exception(ex.Message)



        End Try


    End Sub

    Public Function BuscarArticuloPorCodigoDeBarrasFacade(Articulo As Articulo) As DataTable

        Dim ArticuloDAO As New ArticuloDAO


        Try

            Return ArticuloDAO.BuscarArticuloPorCodigoBarras(Articulo)



        Catch ex As Exception


            Throw New Exception("Error " & ex.Message)




        End Try





    End Function





    Public Function BuscarArticuloPorDescripcionFacade(Articulo As Articulo) As DataSet

        Dim ArticuloDAO As New ArticuloDAO


        Try

            Return ArticuloDAO.BuscarArticuloPorDescripcion(Articulo)



        Catch ex As Exception


            Throw New Exception("Error " & ex.Message)




        End Try





    End Function


    Public Function BuscarArticuloPorCodigo(Articulo As Articulo) As ArticuloParaPresupuesto

        Dim ArticuloDAO As New ArticuloDAO


        Try

            Return ArticuloDAO.BuscarArticuloPorCodigoParaPresupuesto(Articulo)



        Catch ex As Exception


            Throw New Exception("Error " & ex.Message)




        End Try


    End Function


    Public Sub ActualizarPrecioFacade(ByVal Articulo As Articulo)

        Dim _ArticuloDao As New ArticuloDAO

        Try
            _ArticuloDao.ActualizarPrecio(Articulo)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


    Public Sub MovimientoPreciosFacade(ByVal Articulo As Articulo, ByVal Fecha As Date)

        Dim _ArticuloDao As New ArticuloDAO

        Try


            _ArticuloDao.MovimientoPrecios(Articulo, Fecha)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


End Class
