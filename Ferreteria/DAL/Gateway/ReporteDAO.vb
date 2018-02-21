Imports System.Data.SqlClient
Imports System.Globalization
Imports BIZ

Public Class ReporteDAO
    Inherits DatosBase

    Public Function BuscarPrecios(ByVal articulo As Articulo, ByVal _fecha_desde As Date, ByVal _fecha_hasta As Date) As DataTable
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String
        Dim Fecha_Desde = _fecha_desde.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
        Dim Fecha_Hasta = _fecha_hasta.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)

        '_fecha_desde = (_fecha_desde.Date).ToString("yyyy-mm-dd")


        Try
            _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria"
            _Consulta += "  and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo and  Mo.Cod_Articulo =" & articulo.CodigoArticulo & " and  Fecha between (Cast('" + Fecha_Desde + " 00:00:00' as datetime)) and (Cast('" + Fecha_Hasta + " 23:59:59' as datetime))  ORDER BY Mo.Fecha ASC"


            Me.Conexion.Open()
            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)

            If _DataSet.Tables(0).Rows.Count = 0 Then
                Throw New Exception("No existes precios historicos del articulo")
            End If


            Return _DataSet.Tables(0)

        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try




    End Function

    Public Sub GuardarReportePreciosDetalle(item As ReportePreciosDetalle)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into ReportePreciosDetalle (Cod_Reporte, Cod_Articulo, CantidadPrecios, PorcentajeAumento, Precio_Inicial, Precio_Final, Fecha_Desde, Fecha_Hasta) Values (@Cod_Reporte, @Cod_Articulo, @CantidadPrecios, @PorcentajeAumento, @Precio_Inicial, @Precio_Final, @Fecha_Desde, @Fecha_Hasta)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Reporte", item.Cod_Reporte)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", item.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@CantidadPrecios", item.CantidadPrecios)
            _Comando.Parameters.AddWithValue("@PorcentajeAumento", item.PorcentajeAumento)
            _Comando.Parameters.AddWithValue("@Precio_Inicial", item.PrecioInicial)
            _Comando.Parameters.AddWithValue("@Precio_Final", item.PrecioFinal)
            _Comando.Parameters.AddWithValue("@Fecha_Desde", item.Fecha_Desde)
            _Comando.Parameters.AddWithValue("@Fecha_Hasta", item.Fecha_Hasta)

            '_Comando.Parameters.AddWithValue("@Precio", PresupuestoDetalle.Precio)
            '_Comando.Parameters.AddWithValue("@Importe", PresupuestoDetalle.Importe)
            '_Comando.Parameters.AddWithValue("@SubTotal", PresupuestoDetalle.SubTotal)
            '_Comando.Parameters.AddWithValue("@Iva", PresupuestoDetalle.Iva)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try
    End Sub

    Public Sub GuardarReportePreciosCabecera(ReporteCabecera As Reporte)
        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into ReporteAumentoDePrecios (Fecha, Usuario) Values (@Fecha, @Usuario)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            '_Comando.Parameters.AddWithValue("@Cod_Reporte", ReporteCabecera.Cod_Reporte)
            _Comando.Parameters.AddWithValue("@Fecha", ReporteCabecera.Fecha)
            _Comando.Parameters.AddWithValue("@Usuario", ReporteCabecera.Usuario)

            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar Reporte " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try

    End Sub



    Public Function ObtenerCodUltimoReportePrecios() As Integer



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _Codigo As Integer



        Try


            Me.Conexion.Open()

            _Consulta = "select top 1 Cod_Reporte from ReporteAumentoDePrecios order by Cod_Reporte desc "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Codigo = (_Comando.ExecuteScalar) 'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


            Return _Codigo


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()

        End Try



    End Function

End Class
