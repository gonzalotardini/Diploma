﻿
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



End Class
