﻿Imports BIZ
Imports DAL
Imports SL
Public Class GestorCliente

    ''' <summary>
    ''' En el método ValidarClienteBLL se chequean todos los datos del clientes. Estos datos tienen que estar completos sin ningún tipo de faltante y con el formato correcto
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <remarks></remarks>

    Public Sub ValidarClienteBLL(Cliente As Cliente, cultura As String)

        Dim _ClienteFacade As New ClienteFacade
        Try

            If Cliente.RazonSocial = "" Or Cliente.RazonSocial = " " Then
                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, debe completar la razón social del cliente")
                Else
                    Throw New Exception("Error, you must complete business name")
                End If


            End If


            If (Len(Cliente.Cuit)) > 11 Then
                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, Cuit muy extenso")
                Else
                    Throw New Exception("Error, Cuit to long")
                End If


            End If


            If (Len(Cliente.Telefono)) > 11 Or (Len(Cliente.Telefono)) < 8 Then

                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, Revise Teléfono")
                Else
                    Throw New Exception("Error, check phone")
                End If
            End If



            _ClienteFacade.AgregarClienteFacade(Cliente)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Sub

    ''' <summary>
    ''' En el método ValidarClienteBLL se chequean todos los datos del clientes. Estos datos tienen que estar completos sin ningún tipo de faltante y con el formato correcto. Lo realiza para poder actualizar los datos de un determinado cliente
    ''' 
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <remarks></remarks>
    Public Sub ValidarClienteActualizacionBLL(Cliente As Cliente, cultura As String)

        Dim _ClienteFacade As New ClienteFacade





        Try
            If Cliente.RazonSocial = "" Or Cliente.RazonSocial = " " Then
                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, debe completar la razón social del cliente")
                Else
                    Throw New Exception("Error, you must complete business name")
                End If


            End If

            Dim largo As String = (Cliente.Cuit)


            If largo.Length > 11 Then
                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, Cuit muy extenso")
                Else
                    Throw New Exception("Error, Cuit to long")
                End If


            End If


            If (Len(Cliente.Telefono)) > 11 Or (Len(Cliente.Telefono)) < 8 Then

                If cultura = "ESPAÑOL" Then
                    Throw New Exception("Error, Revise Teléfono")
                Else
                    Throw New Exception("Error, check phone")
                End If
            End If



            _ClienteFacade.ActualizarClienteFacade(Cliente)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Sub

    ''' <summary>
    ''' Se encarga de realizar la busqueda de clientes mediante la razon social del mismo
    ''' </summary>
    ''' <param name="_Cliente"></param>
    ''' <returns></returns>

    Public Function BuscarClientePorRazonSocialBLL(_Cliente As Cliente) As DataTable

        Try
            Dim _ClienteFacade = New ClienteFacade()
            Return _ClienteFacade.ObtenerClientePorRazonSocialFacade(_Cliente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Se encarga de realizar la busqueda de un cliente mediante su cuit
    '''
    ''' </summary>
    ''' <param name="_cliente"></param>
    ''' <returns></returns>
    Public Function BuscarClientePorCuitBll(_cliente As Cliente) As DataTable

        Try
            Dim _clienteFacade = New ClienteFacade
            Return _clienteFacade.BuscarClientePorCuitFacade(_cliente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Function
End Class
