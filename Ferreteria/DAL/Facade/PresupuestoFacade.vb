Imports BIZ
Imports System.Transactions
Public Class PresupuestoFacade


    Public Sub GenerarPresupuesto(ByVal PresupuestoCabecera As PresupuestoCabecera, ByVal ListaDetalles As List(Of PresupuestoDetalle))
        Dim _PresupuestoDAO As New PresupuestoDAO
        Dim _Cod_Presupuesto As Integer



        Try

            Using ts As TransactionScope = New TransactionScope

                _PresupuestoDAO.GenerarPresupuestoCabecera(PresupuestoCabecera)

                _Cod_Presupuesto = _PresupuestoDAO.ObtenerCodUltimoPresupuesto()

                For i = 0 To ListaDetalles.Count - 1

                    ListaDetalles(i).Cod_Presupuesto = _Cod_Presupuesto

                    _PresupuestoDAO.GenerarPresupuestoDetalle(ListaDetalles(i))


                Next



                ts.Complete()



            End Using


        Catch ex As Exception


            Throw New Exception(ex.Message)


        End Try


    End Sub


    Public Function BuscarPresupuestoPorRazonSocialFacade(_Cliente As Cliente) As DataSet

        Dim _PresupuestoDao As New PresupuestoDAO

        Try


            Return _PresupuestoDao.BucarPresupuestoPorRazonSocial(_Cliente)


        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try



    End Function


    Public Function BuscarPresupuestoPorCodigoClientelFacade(_Cliente As Cliente) As DataSet

        Dim _PresupuestoDao As New PresupuestoDAO

        Try


            Return _PresupuestoDao.BucarPresupuestoPorCodigoCliente(_Cliente)


        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try



    End Function

    Public Function ObtenerPresupuestoDetalleFacade(_PresupuestoCabecera As PresupuestoCabecera) As DataSet

        Dim _PresupuestoDao As New PresupuestoDAO

        Try


            Return _PresupuestoDao.ObtenerPresupuestoDetalle(_PresupuestoCabecera)


        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try



    End Function





    Public Sub ActualizarPresupuestoFacade(ByVal _PresupuestoCabecera As PresupuestoCabecera, ByVal _ListaDetalles As List(Of PresupuestoDetalle))

        Dim _PresupuestoDao As New PresupuestoDAO



        Try


            Using ts As TransactionScope = New TransactionScope



                _PresupuestoDao.EliminarPresupuestoDetalle(_PresupuestoCabecera)
                _PresupuestoDao.ActualizarTotal(_PresupuestoCabecera)






                For i = 0 To _ListaDetalles.Count - 1

                    _ListaDetalles(i).Cod_Presupuesto = _PresupuestoCabecera.Cod_Presupuesto

                    _PresupuestoDao.GenerarPresupuestoDetalle(_ListaDetalles(i))


                Next



                ts.Complete()





            End Using






        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try





    End Sub

    Public Sub EliminarPresupuestoFacade(cod As Long)
        Try
            Dim presupuestoDao As New PresupuestoDAO
            presupuestoDao.EliminarPresupuesto(cod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
