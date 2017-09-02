Imports BIZ

Imports System.Configuration
Imports System.Data.SqlClient

Public Class CategoriaDAO

    Inherits DatosBase

    ''' <summary>
    ''' Obtiene todas las categorías de articulos existentes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerTodasCategorias() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable


        Try
            _Consulta = "Select * from Categoria order by Descripcion"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataTable)

            Return _DataTable

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            Me.Conexion.Close()

        End Try


        Me.Conexion.Close()

    End Function


End Class
