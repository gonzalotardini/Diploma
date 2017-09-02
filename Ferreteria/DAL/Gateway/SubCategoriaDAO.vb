
Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient


Public Class SubCategoriaDAO


    Inherits DatosBase

    ''' <summary>
    ''' Obtiene todas las subcategorias cargadas previamente
    ''' </summary>
    ''' <param name="Categoria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>



    Public Function ObtenerSubCategorias(ByVal Categoria As Categoria) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        _Consulta = "Select * from SubCategoria where Cod_Categoria=@Cod_Categoria order by Descripcion"

        Try

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Categoria", Categoria.CodigoCategoria)


            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataTable)

            Return _DataTable


        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally

            Me.Conexion.Close()

        End Try





    End Function

    ''' <summary>
    ''' Obtiene todas las subcategorias cargadas previamente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerTodasLasSUbCategoriasSolas() As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            Me.Conexion.Open()

            _Consulta = "Select Cod_SubCategoria, Descripcion from SubCategoria order by Descripcion"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)

            Return _DataSet

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing
        Finally
            Me.Conexion.Close()

        End Try
        



    End Function

End Class
