Imports System.Data.SqlClient
Imports System.Globalization
Imports BIZ

Public Class ReporteDAO
    Inherits DatosBase

    Public Function BuscarPrecios(ByVal articulo As Articulo, ByVal _fecha_desde As Date, ByVal _fecha_hasta As Date) As DataSet
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String
        Dim Fecha_Desde = _fecha_desde.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
        Dim Fecha_Hasta = _fecha_hasta.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)

        '_fecha_desde = (_fecha_desde.Date).ToString("yyyy-mm-dd")


        Try
            _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria"
            _Consulta += "  and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo and  Mo.Cod_Articulo =" & articulo.CodigoArticulo & " and  Fecha between (Cast('" + Fecha_Desde + " 00:00:00' as datetime)) and (Cast('" + Fecha_Hasta + " 23:59:59' as datetime))  ORDER BY Mo.Fecha DESC"


            Me.Conexion.Open()
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
