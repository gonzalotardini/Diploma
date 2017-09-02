Imports BIZ
Imports DAL
Imports SL
Imports System.Transactions
Imports System.Math

Public Class GestorArticulo

    ''' <summary>
    ''' Valida que los datos ingresados del artículo cumplan con las validaciones de los casos de uso
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <param name="Fecha"></param>
    ''' <remarks></remarks>

    Public Sub ValidarDatosArticulo(ByVal Articulo As Articulo, ByVal Fecha As Date)

        Dim ArticuloFacade As New ArticuloFacade

        Try

            If IsNumeric(Articulo.CodigoDeBarras) = False Then

                Throw New Exception("Error, codigo de barras debe ser numerico")

            End If

            If Articulo.CodigoDeBarras < 0 Then

                Throw New Exception("Error, codigo de barras debe ser positivo")

            End If

            If Articulo.Descripcion = "" Then
                Throw New Exception("Error, introduzca descripcion")
            End If


            If Articulo.Precio < 0 Then

                Throw New Exception("Error, precio debe ser positivo")

            End If

            If IsNumeric(Articulo.Precio) = False Then

                Throw New Exception("Error, precio debe ser numérico")



            End If


            ArticuloFacade.AgregarArticuloFacade(Articulo, Fecha)


        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Sub

    ''' <summary>
    ''' Valida que el código de barras infresado sea correcto
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ValidarCodigoDeBarrasParaBusqueda(Articulo As Articulo) As DataTable
        Dim ArticuloFacade As New ArticuloFacade

        Try

            If IsNumeric(Articulo.CodigoDeBarras) = True Then

                Return ArticuloFacade.BuscarArticuloPorCodigoDeBarrasFacade(Articulo)

            Else
                Throw New Exception("Error, Codigo de Barras debe ser Numérico")

            End If




        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try

    End Function


    ''' <summary>
    ''' Valida que Descripcion ingresada sea correcta
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ValidarDescripcionParaBusqueda(Articulo As Articulo) As DataSet
        Dim ArticuloFacade As New ArticuloFacade

        Try

            '    If IsNumeric(Articulo.Descripcion) = False Then

            Return ArticuloFacade.BuscarArticuloPorDescripcionFacade(Articulo)

            '  Else
            ' Throw New Exception("Error, descripcion no puede estar vacia")

            ' End If




        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try

    End Function


    ''' <summary>
    ''' Busca artículos mediante su codigo de barras, puede arrojar mas de un resultado
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerArticuloPorCodigo(Articulo As Articulo) As ArticuloParaPresupuesto

        Dim _ArticuloFacade As New ArticuloFacade




        Try
            If IsNumeric(Articulo.CodigoArticulo) = True Then

                Return _ArticuloFacade.BuscarArticuloPorCodigo(Articulo)

            Else

                Throw New Exception("Error, Codigo de articulo debe ser numerico")
            End If


        Catch ex As Exception


            Throw New Exception(ex.Message)


        End Try



    End Function


    ''' <summary>
    ''' Realiza los cálculos pertinentes de un aumento de precio
    ''' </summary>
    ''' <param name="_PorcentajeAumento"></param>
    ''' <param name="_ListaArticulo"></param>
    ''' <remarks></remarks>

    Public Sub AumentarPreciosBLL(ByVal _PorcentajeAumento As Integer, ByVal _ListaArticulo As List(Of Articulo))




        Dim _NuevoPrecio As Decimal
        Dim _CantidadArticulos As Integer = _ListaArticulo.Count
        Dim _Articulo As New Articulo
        Dim _ArticuloFacade As New ArticuloFacade


        Using ts As TransactionScope = New TransactionScope


            For i = 1 To _CantidadArticulos


                _Articulo.CodigoArticulo = _ListaArticulo.Item(i - 1).CodigoArticulo
                _Articulo.Precio = _ListaArticulo.Item(i - 1).Precio

                'Calculo nuevo precio con el porcentaje de aumento

                _NuevoPrecio = ((_Articulo.Precio * _PorcentajeAumento) / 100) + _Articulo.Precio


                If _NuevoPrecio > 5 Then

                    ' Si los centavos estan entre 50 y 10 redondeo para arriba

                    If Right(_NuevoPrecio, 2) > 10 And Right(_NuevoPrecio, 2) < 50 Then

                        _Articulo.Precio = Round(_NuevoPrecio) + 1

                        _ArticuloFacade.ActualizarPrecioFacade(_Articulo)


                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        _ArticuloFacade.MovimientoPreciosFacade(_Articulo, Fecha)

                    Else

                        _Articulo.Precio = Round(_NuevoPrecio)

                        _ArticuloFacade.ActualizarPrecioFacade(_Articulo)

                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        _ArticuloFacade.MovimientoPreciosFacade(_Articulo, Fecha)

                    End If



                Else


                    _Articulo.Precio = _NuevoPrecio

                    _ArticuloFacade.ActualizarPrecioFacade(_Articulo)



                    Dim Fecha As Date

                    Fecha = Now

                    ' Articulo.Cod_Articulo = Cod_Articulo

                    _ArticuloFacade.MovimientoPreciosFacade(_Articulo, Fecha)



                End If

            Next


            ts.Complete()

        End Using




    End Sub


    Public Sub DescontarPrecioBll(_ListaArticulo As List(Of Articulo), _PorcentajeAumento As Integer)

        Dim _NuevoPrecio As Decimal
        Dim _CantidadArticulos As Integer = _ListaArticulo.Count
        Dim _Articulo As New Articulo
        Dim _ArticuloFacade As New ArticuloFacade


        Using ts As TransactionScope = New TransactionScope


            For i = 1 To _CantidadArticulos


                _Articulo.CodigoArticulo = _ListaArticulo.Item(i - 1).CodigoArticulo
                _Articulo.Precio = _ListaArticulo.Item(i - 1).Precio

                'Calculo nuevo precio con el porcentaje de aumento

                _NuevoPrecio = _Articulo.Precio - ((_Articulo.Precio * _PorcentajeAumento) / 100)


                If _NuevoPrecio > 5 Then

                    ' Si los centavos estan entre 50 y 10 redondeo para arriba

                    If Right(_NuevoPrecio, 2) > 10 And Right(_NuevoPrecio, 2) < 50 Then

                        _Articulo.Precio = Round(_NuevoPrecio) + 1

                        _ArticuloFacade.ActualizarPrecioFacade(_Articulo)


                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        _ArticuloFacade.MovimientoPreciosFacade(_Articulo, Fecha)
                    Else

                        _Articulo.Precio = Round(_NuevoPrecio)

                        _ArticuloFacade.ActualizarPrecioFacade(_Articulo)

                        Dim Fecha As Date

                        Fecha = Now

                        ' Articulo.Cod_Articulo = Cod_Articulo

                        _ArticuloFacade.MovimientoPreciosFacade(_Articulo, Fecha)


                    End If

                Else
                    _Articulo.Precio = _NuevoPrecio

                    _ArticuloFacade.ActualizarPrecioFacade(_Articulo)


                End If

            Next


            ts.Complete()

        End Using

    End Sub

End Class
