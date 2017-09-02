Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient

Public Class ModificacionesPreciosDAO

    Inherits DatosBase


    ''' <summary>
    ''' Registra el cambio de precios de un artículo en la tabla movimientoPrecios
    ''' </summary>
    ''' <param name="articulo"></param>
    ''' <param name="Fecha"></param>
    ''' <remarks></remarks>

    Public Sub MovimientoPrecios(ByVal articulo As Articulo, Fecha As Date)

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        'Dim dal As New DAL.DatosBase

        Try


            _Consulta = "Insert into MovimientoPrecios (Cod_Articulo, Precio, Fecha) values (@Cod_Articulo, @Precio, @Fecha)"

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.CodigoArticulo)
            _Comando.Parameters.AddWithValue("Precio", articulo.Precio)
            _Comando.Parameters.AddWithValue("Fecha", Fecha)

            _Comando.ExecuteNonQuery()



        Catch ex As Exception

            Throw New Exception("Error al cargar precio histórico" & ex.Message)

        Finally

            Me.Conexion.Close()

        End Try




    End Sub

End Class
