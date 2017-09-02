Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient


Public Class BarrioDAO

    Inherits DatosBase

    ''' <summary>
    ''' Obtiene todos los barrios cargados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerBarrios() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DatSet As New DataSet

        Try
            Me.Conexion.Open()

            _Consulta = "Select Cod_Barrio, Descripcion from Barrio order by Descripcion"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DatSet)

            Return _DatSet.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try






    End Function




End Class
