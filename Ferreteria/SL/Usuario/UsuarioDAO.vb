Imports BIZ
Imports DAL
Imports System.Configuration
Imports System.Data.SqlClient


Public Class UsuarioDAO

    Inherits DatosBase

    Public Function ObtenerUsuario(_Usuario As Usuario) As Usuario


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _UsuarioObtenido As New Usuario


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select idUsuario, Nombre, Pw from Usuario where Nombre='" + _Usuario.NombreUsuario + "'"





            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            '_Comando.Parameters.AddWithValue("@Nombre", _Usuario.NombreUsuario)

            '_Comando.ExecuteNonQuery()

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)


            If _Dataset.Tables(0).Rows.Count > 0 Then



                _UsuarioObtenido.IdUsuario = _Dataset.Tables(0).Rows(0)("IdUsuario")
                _UsuarioObtenido.NombreUsuario = _Dataset.Tables(0).Rows(0)("Nombre")
                _UsuarioObtenido.PW = _Dataset.Tables(0).Rows(0).Item(2)

                Return _UsuarioObtenido


            Else
                Throw New Exception("Revise nombre de usuario o contraseña")

            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try



    End Function




    Public Function ObtenerPatentesDeUsuario(Usuario As Usuario) As List(Of Patente)



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _Patente As New List(Of Patente)


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select IdPatente from Usuario_Patente where IdUsuario=@IdUsuario "





            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario)

            _Comando.ExecuteNonQuery()



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)



            Return CrearListaDePatentes(_Dataset.Tables(0))




        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try



    End Function



    Public Function CrearListaDePatentes(DataTable As DataTable) As List(Of Patente)


        Dim _Patente As Patente
        Dim ListaPatente As New List(Of Patente)


        For Each fila As DataRow In DataTable.Rows
            _Patente = New Patente

            _Patente.IdPatente = fila.Item("IdPatente")


            ListaPatente.Add(_Patente)


        Next

        Return ListaPatente




    End Function



    Public Function ObtenerUsuarios() As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        '  Dim _UsuarioObtenido As New Usuario


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select idUsuario, Nombre, Pw from Usuario"





            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            _Comando.ExecuteNonQuery()



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)


            Return _Dataset.Tables(0)






        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try



    End Function


    Public Function ObtenerPatentesDescripcionDeUsuario(Usuario As Usuario) As List(Of Patente)



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _Patente As New List(Of Patente)


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select IdPatente from Usuario_Patente where IdUsuario=@IdUsuario "





            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario)

            _Comando.ExecuteNonQuery()



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)



            Return CrearListaDePatentes(_Dataset.Tables(0))




        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try

    End Function



    Public Function ObtenerPatentesDeUsuarioDT(Usuario As Usuario) As DataTable



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _Patente As New List(Of Patente)


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select P.IdPatente as IdPatente, P.Nombre as Nombre from Usuario_Patente as UP, Patente as P where IdUsuario=@IdUsuario And p.idPatente=up.idpatente order by nombre"





            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario)

            _Comando.ExecuteNonQuery()



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)



            Return _Dataset.Tables(0)




        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try



    End Function

    ''' <summary>
    ''' Obtiene todas aquellas patentes que cierto usuario no tiene asignadas
    ''' </summary>
    ''' <param name="Usuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerPatentesNoAasignadas(Usuario As Usuario) As DataTable



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _Patente As New List(Of Patente)


        Dim _Dataset As New DataSet
        Try
            Me.Conexion.Open()

            _Consulta = "Select IdPatente, Nombre From Patente where Not IdPatente In (Select IdPatente From Usuario_Patente where IdUsuario=@idUsuario)"





            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("idUsuario", Usuario.IdUsuario)

            _Comando.ExecuteNonQuery()



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_Dataset)



            Return _Dataset.Tables(0)




        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try



    End Function



    Public Sub ActualizarContraseña(Usuario As Usuario)



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "update Usuario set PW=@PW where idUsuario=@idUsuario"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@PW", Usuario.PW)
            _Comando.Parameters.AddWithValue("@idUsuario", Usuario.IdUsuario)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al Modificar Contraseña " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try







    End Sub


    Public Sub EliminarPatenteDeUsuario(Usuario As Usuario)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "Delete from Usuario_Patente where IdUsuario=@IdUsuario"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)


            _Comando.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al eliminar la patente " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub

    Public Sub AgregarPatenteAUsuario(Patente As Patente, Usuario As Usuario)



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "Insert into Usuario_Patente (IdUsuario, IdPatente) values (@IdUsuario, @IdPatente)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario)
            _Comando.Parameters.AddWithValue("@IdPatente", Patente.IdPatente)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al agregar patente a usuario " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try







    End Sub

End Class

