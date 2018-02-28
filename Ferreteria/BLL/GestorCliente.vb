Imports BIZ
Imports DAL
Imports SL
Public Class GestorCliente

    ''' <summary>
    ''' En el método ValidarClienteBLL se chequean todos los datos del clientes. Estos datos tienen que estar completos sin ningún tipo de faltante y con el formato correcto
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <remarks></remarks>

    Public Sub ValidarClienteBLL(Cliente As Cliente)

        Dim _ClienteFacade As New ClienteFacade





        Try

            If Cliente.RazonSocial = "" Or Cliente.RazonSocial = " " Then

                Throw New Exception("Error, debe completar la razón social del cliente")

            End If


            If (Len(Cliente.Cuit)) > 11 Then

                Throw New Exception("Error, Cuit muy extenso")

            End If


            If (Len(Cliente.Telefono)) > 11 Or (Len(Cliente.Telefono)) < 8 Then

                Throw New Exception("Error, Revise Teléfono")

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
    Public Sub ValidarClienteActualizacionBLL(Cliente As Cliente)

        Dim _ClienteFacade As New ClienteFacade





        Try

            If Cliente.RazonSocial = "" Or Cliente.RazonSocial = " " Then

                Throw New Exception("Error, debe completar la razón social del cliente")

            End If


            If (Len(Cliente.Cuit)) > 11 Then

                Throw New Exception("Error, Cuit muy extenso")

            End If


            If (Len(Cliente.Telefono)) > 11 Or (Len(Cliente.Telefono)) < 8 Then

                Throw New Exception("Error, Revise Teléfono")

            End If



            _ClienteFacade.ActualizarClienteFacade(Cliente)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Sub

    Public Function BuscarClientePorRazonSocialBLL(_Cliente As Cliente) As DataTable

        Try
            Dim _ClienteFacade = New ClienteFacade()
            Return _ClienteFacade.ObtenerClientePorRazonSocialFacade(_Cliente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function BuscarClientePorCuitBll(_cliente As Cliente) As DataTable

        Try
            Dim _clienteFacade = New ClienteFacade
            Return _clienteFacade.BuscarClientePorCuitFacade(_cliente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Function
End Class
