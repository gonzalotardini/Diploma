Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient

Public Class UnidadDeMedidaDao
    Inherits DatosBase


    ''' <summary>
    ''' Obtiene todas las unidades de medidda cargadas previamente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>


    Public Function ObtenerUnidadesMedida() As DataTable



        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        Try
            _Consulta = "Select * from Unidad_Medida"


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

        


    End Function



End Class
