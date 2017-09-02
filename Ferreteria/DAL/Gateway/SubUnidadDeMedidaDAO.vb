
Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient

Public Class SubUnidadDeMedidaDAO
    Inherits DatosBase


    ''' <summary>
    ''' Obtiene todas las sub unidades de medida cargadas previamente
    ''' </summary>
    ''' <param name="UnidadDeMedida"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerSubUnidadMedida(ByVal UnidadDeMedida As UnidadDeMedida) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        Try
            _Consulta = "Select * from SubUnidad_Medida where Cod_Unidad_Medida=@Cod_Unidad_Medida"

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", UnidadDeMedida.CodUnidadMedida)


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
