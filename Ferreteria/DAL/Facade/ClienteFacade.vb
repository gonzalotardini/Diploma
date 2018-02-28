Imports BIZ

Public Class ClienteFacade


    Public Sub AgregarClienteFacade(Cliente As Cliente)
        Dim _ClienteDAO As New ClienteDAO

        Try


            _ClienteDAO.AgregarClienteDao(Cliente)


        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try


    End Sub

    Public Sub ActualizarClienteFacade(Cliente As Cliente)
        Dim _ClienteDAO As New ClienteDAO

        Try


            _ClienteDAO.ActualizarCliente(Cliente)


        Catch ex As Exception

            Throw New Exception(ex.Message)


        End Try


    End Sub


    Public Function ObtenerClientePorRazonSocialFacade(_Cliente As Cliente) As DataTable

        Try
            Dim _ClienteDao = New ClienteDAO()
            Dim _DataSet = New DataSet()

            Return _ClienteDao.BuscarClientePorRazonSocial(_Cliente)

        Catch ex As Exception
            Throw New Exception("Error " & ex.Message)
        End Try


    End Function

    Public Function BuscarClientePorCuitFacade(cliente As Cliente) As DataTable
        Try
            Dim clienteDAL = New ClienteDAO
            Return clienteDAL.BuscarClientePorCuit(cliente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
