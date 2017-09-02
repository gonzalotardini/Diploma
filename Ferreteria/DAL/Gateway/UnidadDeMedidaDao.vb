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

    Public Sub CargarUnidadDeMedida(ByVal UnidadDeMedida As UnidadDeMedida)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "insert into Unidad_Medida (Descripcion) values (@Descripcion) "

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", UnidadDeMedida.DescripcionUnidadMedida)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar la Unidad de Medida " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub

    Public Sub ActualizarUnidadDeMedida(ByVal UnidadDeMedida As UnidadDeMedida)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "Update Unidad_Medida set Descripcion=@Descripcion where Cod_Unidad_Medida=@Cod_Unidad_Medida"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Descripcion", UnidadDeMedida.DescripcionUnidadMedida)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", UnidadDeMedida.CodUnidadMedida)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception



            Throw New Exception("Error al actualizar la Unidad de Medida " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub



End Class
