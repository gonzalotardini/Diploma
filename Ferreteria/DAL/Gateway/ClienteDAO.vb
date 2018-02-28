Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient
Public Class ClienteDAO
    Inherits DatosBase



    Public Function ObtenerClientesDao() As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select Cod_Cliente as 'Codigo' ,Razon_Social, Cuit, Direccion, B.Descripcion, Telefono, Email from Cliente AS C, Barrio as B Where C.Cod_barrio = B.Cod_Barrio"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)




            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)



            Return _DataSet.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Conexion.Close()

        End Try

    End Function



    Public Sub AgregarClienteDao(Cliente As Cliente)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "insert into Cliente (Razon_Social, Cuit, Direccion, Cod_Barrio, Telefono, Email ) values (@Razon_Social, @Cuit, @Direccion, @Cod_Barrio, @Telefono, @Email )"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Razon_Social", Cliente.RazonSocial)
            _Comando.Parameters.AddWithValue("@Cuit", Cliente.Cuit)
            _Comando.Parameters.AddWithValue("@Direccion", Cliente.Direccion)
            _Comando.Parameters.AddWithValue("@Cod_Barrio", Cliente.Barrio)
            _Comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
            _Comando.Parameters.AddWithValue("@Email", Cliente.Email)
         


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el Cliente " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try



    End Sub


    Public Function ObtenerClientePorCodigo(Cliente As Cliente) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select  Razon_Social, Cuit, Direccion, Cod_Barrio, Telefono, Email from Cliente where Cod_Cliente = Cod_Cliente"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)




            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)


            '_DataSet.Tables(0)



            Return _DataSet.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Conexion.Close()

        End Try


    End Function


    Public Function ObtenerUnClientePorCodigo(Cliente As Cliente) As Cliente


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select  Razon_Social, Cuit, Direccion, Cod_Barrio, Telefono, Email from Cliente where Cod_Cliente = Cod_Cliente and Cod_Cliente =" & Cliente.CodigoCliente


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)




            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)


            '_DataSet.Tables(0)


            Cliente.RazonSocial = _DataSet.Tables(0).Rows(0).Item("Razon_Social")
            Cliente.Cuit = _DataSet.Tables(0).Rows(0).Item("Cuit")
            Cliente.Direccion = _DataSet.Tables(0).Rows(0).Item("Direccion")

            Cliente.Barrio = _DataSet.Tables(0).Rows(0).Item("Cod_Barrio")

            Cliente.Telefono = _DataSet.Tables(0).Rows(0).Item("Telefono")


            Cliente.Email = _DataSet.Tables(0).Rows(0).Item("Email")


            Return Cliente

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Conexion.Close()

        End Try


    End Function



    Public Sub ActualizarCliente(Cliente As Cliente)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "update Cliente set Razon_Social=@Razon_Social, Cuit=@Cuit, Direccion=@Direccion, Cod_Barrio=@Cod_Barrio, Telefono=@Telefono, Email=@Email Where Cod_Cliente=@Cod_Cliente"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Razon_Social", Cliente.RazonSocial)
            _Comando.Parameters.AddWithValue("@Cuit", Cliente.Cuit)
            _Comando.Parameters.AddWithValue("@Direccion", Cliente.Direccion)
            _Comando.Parameters.AddWithValue("@Cod_Barrio", Cliente.Barrio)
            _Comando.Parameters.AddWithValue("@Telefono", Cliente.Telefono)
            _Comando.Parameters.AddWithValue("@Email", Cliente.Email)

            _Comando.Parameters.AddWithValue("@Cod_Cliente", Cliente.CodigoCliente)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al Modificar Cliente " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try



    End Sub


    Public Function BuscarClientePorRazonSocial(_Cliente As Cliente) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select Cod_Cliente as 'Codigo' ,Razon_Social, Cuit, Direccion, B.Descripcion, Telefono, Email from Cliente AS C, Barrio as B Where C.Cod_barrio = B.Cod_Barrio"
            _Consulta += " and Razon_Social like '%" + _Cliente.RazonSocial + "%'"

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)




            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)



            Return _DataSet.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Conexion.Close()

        End Try

    End Function

    Public Function BuscarClientePorCuit(_Cliente As Cliente) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select Cod_Cliente as 'Codigo' ,Razon_Social, Cuit, Direccion, B.Descripcion, Telefono, Email from Cliente AS C, Barrio as B Where C.Cod_barrio = B.Cod_Barrio"
            _Consulta += " and Cuit=" & _Cliente.Cuit

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)




            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)



            Return _DataSet.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Conexion.Close()

        End Try

    End Function

End Class
