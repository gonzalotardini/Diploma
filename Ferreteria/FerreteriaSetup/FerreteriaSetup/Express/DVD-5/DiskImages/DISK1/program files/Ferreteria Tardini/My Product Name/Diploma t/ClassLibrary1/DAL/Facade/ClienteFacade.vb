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



   
End Class
