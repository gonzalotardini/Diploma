
Imports BIZ
Imports System.Transactions

Public Class VentaFacade


    Public Sub GenerarVenta(ByVal VentaCabecera As VentaCabecera, ByVal ListaDetalles As List(Of VentaDetalle))
        Dim _VentaDAO As New VentaDAO

        Dim _Cod_Venta As Integer



        Try

            Using ts As TransactionScope = New TransactionScope

                _VentaDAO.GenerarVentaCabecera(VentaCabecera)

                _Cod_Venta = _VentaDAO.ObtenerCodUltimaVenta

                For i = 0 To ListaDetalles.Count - 1

                    ListaDetalles(i).Cod_Venta = _Cod_Venta

                    _VentaDAO.GenerarVentaDetalle(ListaDetalles(i))


                Next



                ts.Complete()



            End Using


        Catch ex As Exception


            Throw New Exception(ex.Message)


        End Try


    End Sub

    Public Sub CancelarVentaFacade(cod As Long)
        Try
            Dim ventaDao = New VentaDAO
            ventaDao.CancelarVentaDao(cod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub CancelarNotaCreditoFacade(codNotaCredito As Long)
        Try
            Dim ventaDao = New VentaDAO
            ventaDao.CancelarNotaDeCredito(codNotaCredito)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function BuscarPresupuestoPorCodigoClientelFacade(cliente As Cliente) As DataSet
        Try
            Dim ventaDao As New VentaDAO
            Return ventaDao.BucarVentaPorCodigoCliente(cliente)
        Catch ex As Exception
            Return Nothing
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
