Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class ArticuloDAO
    Inherits DatosBase


    ''' <summary>
    ''' Genera la alta de un nuevo artículo en la base de datos
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <remarks></remarks>

    Public Sub CargarArticulo(ByVal Articulo As Articulo)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "insert into Articulo (Cod_Articulo_Proveedor,Descripcion,Cod_Unidad_Medida,Cod_SubUnidad_Medida,Precio,Cod_Categoria,Cod_SubCategoria,Cod_Marca, Eliminado) values (@Cod_Articulo_Proveedor,@Descripcion,@Cod_Unidad_Medida, @Cod_SubUnidad_Medida, @Precio,@Cod_Categoria, @Cod_SubCategoria, @Cod_Marca,0)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo_Proveedor", Articulo.CodigoDeBarras)
            _Comando.Parameters.AddWithValue("@Descripcion", Articulo.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", Articulo.UnidadDeMedida)
            _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", Articulo.SubUnidadDeMedida)
            _Comando.Parameters.AddWithValue("@Precio", Articulo.Precio)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", Articulo.Categoria)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", Articulo.SubCategoria)
            _Comando.Parameters.AddWithValue("@Cod_Marca", Articulo.Marca)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub

    ''' <summary>
    ''' Modifica un artículo en la base de datos
    ''' </summary>
    ''' <param name="Articulo"></param>
    Public Sub ModificarArticulo(ByVal Articulo As Articulo)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "Update Articulo set Cod_Articulo_Proveedor=@Cod_Articulo_Proveedor,Descripcion=@Descripcion,Cod_Unidad_Medida=@Cod_Unidad_Medida,Cod_SubUnidad_Medida=@Cod_SubUnidad_Medida,Precio = @Precio , Cod_Categoria=@Cod_Categoria , Cod_SubCategoria= @Cod_SubCategoria , Cod_Marca=@Cod_Marca "
        _Consulta += " where Cod_Articulo=@Cod_Articulo"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo_Proveedor", Articulo.CodigoDeBarras)
            _Comando.Parameters.AddWithValue("@Descripcion", Articulo.Descripcion)
            _Comando.Parameters.AddWithValue("@Cod_Unidad_Medida", Articulo.UnidadDeMedida)
            _Comando.Parameters.AddWithValue("@Cod_SubUnidad_Medida", Articulo.SubUnidadDeMedida)
            _Comando.Parameters.AddWithValue("@Precio", Articulo.Precio)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", Articulo.Categoria)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", Articulo.SubCategoria)
            _Comando.Parameters.AddWithValue("@Cod_Marca", Articulo.Marca)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", Articulo.CodigoArticulo)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub


    ''' <summary>
    ''' Obtiene los primeros 50 artículos que se encuentran en la base de datos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerPrimerosArticulos() As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DatSet As New DataSet

        Try
            Me.Conexion.Open()

            _Consulta = "Select top 50 A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and Eliminado=0 ORDER BY A.Descripcion "

            Me.Conexion.Close()
            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DatSet)

            Return _DatSet

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try




    End Function





    ''' <summary>
    ''' Realiza la búsqueda de un artículo mediante su código de barras
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function BuscarArticuloPorCodigoBarras(ByVal Articulo As Articulo) As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Try

            _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca',SU.Descripcion as 'SubUnidadDeMedida', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Cod_Articulo_Proveedor=" & Articulo.CodigoDeBarras & " and eliminado=0 ORDER BY A.Descripcion"


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


    ''' <summary>
    ''' Realiza la búsqueda de un artículo mediante su descripción, puede arrojar mas de un resulrdo
    ''' </summary>
    ''' <param name="articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function BuscarArticuloPorDescripcion(ByVal articulo As Articulo) As DataSet
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet


        Try
            _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion , M.Descripcion as 'Marca' ,SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria',C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and A.Descripcion like '%" + articulo.Descripcion + "%' and Eliminado=0 order by A.Descripcion"




            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)

            Return _dataSet

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try




    End Function

    ''' <summary>
    ''' La funcion realiza una busqueda por codigo de articulo y devuelve todos los articulos que tengane se codigo
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function BuscarArticuloPorCodigoParaPresupuesto(ByVal Articulo As Articulo) As ArticuloParaPresupuesto


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir
        Dim _ArticuloparPresupuesto As New ArticuloParaPresupuesto


        Try
            _Consulta = "Select A.Cod_Articulo, A.Cod_Articulo_Proveedor as 'CodigoDeBarras', A.Descripcion as 'Descripcion' , M.Descripcion as 'Marca' ,SU.Descripcion as 'SubUnidadDeMedida', A.Precio, SC.Descripcion 'SubCategoria',C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and Eliminado=0 and A.Cod_articulo =" & Articulo.CodigoArticulo




            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)





            Return _Convertir.DataTableToList(Of ArticuloParaPresupuesto)(_dataSet.Tables(0))(0)


        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function

    ''' <summary>
    ''' Busca un artículo por su código
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <returns></returns>
    Public Function BuscarArticuloPorCodigo(ByVal Articulo As Articulo) As Articulo


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir
        Dim _ArticuloparPresupuesto As New ArticuloParaPresupuesto


        Try
            _Consulta = "Select * from Articulo where Cod_Articulo=@Cod_Articulo"



            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", Articulo.CodigoArticulo)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)





            Return MapearArticulo(_dataSet.Tables(0))


        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function

    ''' <summary>
    ''' Realiza el soft delete de un articulo asignando como bandera = 1 a la columna eliminado
    ''' </summary>
    ''' <param name="_Articulo"></param>
    ''' <remarks></remarks>

    Public Sub EliminarArticulo(_Articulo As Articulo)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = "Update Articulo set Eliminado=1 where Cod_Articulo=@Cod_Articulo"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo", _Articulo.CodigoArticulo)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al eliminar el articulo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub

    ''' <summary>
    ''' Obtenego todos los articulos que son de determinada marca. Los busco por codigo de marca
    ''' </summary>
    ''' <param name="marca"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerArticuloPorMarca(ByVal marca As Marca) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable

        Try
            _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_Marca=@Cod_Marca and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.Parameters.AddWithValue("@Cod_Marca", marca.Cod_Marca)
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
    ''' Obtiene todos los artículos que pertenecen a una determinada sub caterogía
    ''' </summary>
    ''' <param name="subcategoria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerArticuloPorSubCategoria(ByVal subcategoria As SubCategoria) As DataTable


        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable


        Try

            _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_SubCategoria=@Cod_SubCategoria and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.Parameters.AddWithValue("@Cod_SubCategoria", subcategoria.SubCategoria)
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
    ''' Obtiene todos los artículos que pertenecen a una determinada categoría que debe ser indicada
    ''' </summary>
    ''' <param name="categoria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenenrArticulosPorCategoria(ByVal categoria As Categoria) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataTable As New DataTable




        Try

            _Consulta = "Select A.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', A.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria' from Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where A.Cod_Categoria=@Cod_Categoria and U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and "
            _Consulta += "M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria ORDER BY A.Descripcion"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.Parameters.AddWithValue("@Cod_Categoria", categoria.CodigoCategoria)
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
    ''' Actualiza el precio de determinado artículo
    ''' </summary>
    ''' <param name="Articulo"></param>
    ''' <remarks></remarks>


    Public Sub ActualizarPrecio(ByVal Articulo As Articulo)


        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try

            Me.Conexion.Open()

            _Consulta = "Update Articulo set Precio=@Precio where Cod_Articulo=@Cod_Articulo"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Precio", Articulo.Precio)
            _Comando.Parameters.AddWithValue("Cod_Articulo", Articulo.CodigoArticulo)


            _Comando.ExecuteNonQuery()



        Catch ex As Exception

        Finally

            Me.Conexion.Close()

        End Try



    End Sub



    ''' <summary>
    ''' Inserta en la tabla movimiento de precios el cambio de precio de un artículo para luego poder realizar dicho reporte
    ''' </summary>
    ''' <param name="articulo"></param>
    ''' <param name="Fecha"></param>
    ''' <remarks></remarks>

    Public Sub MovimientoPrecios(ByVal articulo As Articulo, Fecha As Date)

        Dim _Consulta As String
        Dim _Comando As SqlCommand

        Try


            _Consulta = "Insert into MovimientoPrecios (Cod_Articulo, Precio, Fecha) values (@Cod_Articulo, @Precio, @Fecha)"


            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Articulo", articulo.CodigoArticulo)
            _Comando.Parameters.AddWithValue("Precio", articulo.Precio)
            _Comando.Parameters.AddWithValue("Fecha", Fecha)

            _Comando.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            Me.Conexion.Close()
        End Try



    End Sub







    ''' <summary>
    ''' Busca todos los precios históricos de un artículo mediante su Descripción
    ''' </summary>
    ''' <param name="articulo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerPreciosHistoricosPorDescripcion(ByVal articulo As Articulo, _fecha_desde As Date, _fecha_hasta As Date) As DataSet
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String
        Dim Fecha_Desde = _fecha_desde.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
        Dim Fecha_Hasta = _fecha_hasta.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)

        '_fecha_desde = (_fecha_desde.Date).ToString("yyyy-mm-dd")


        Try
            _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria"
            _Consulta += "  and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo and  A.Descripcion like '%" + articulo.Descripcion + "%' and  Fecha between (Cast('" + Fecha_Desde + " 00:00:00' as datetime)) and (Cast('" + Fecha_Hasta + " 23:59:59' as datetime))  ORDER BY Mo.Fecha DESC"


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






    ''' <summary>
    ''' Obtiene los primeros 50 precios historicos de los articulos
    ''' </summary>
    ''' <returns></returns>

    Public Function ObtenerPreciosHistoricostop50() As DataSet
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String


        Try
            _Consulta = "Select id_Movimiento as ID, Mo.Cod_Articulo as Codigo, A.Cod_Articulo_Proveedor AS 'CodigoBarras', A.Descripcion, M.Descripcion as 'Marca', SU.Descripcion as 'Sub Unidad', Mo.Precio, SC.Descripcion 'Sub Categoria', C.Descripcion as 'Categoria', Mo.Fecha from MovimientoPrecios as Mo, Articulo as A, Marca as M, Unidad_Medida as U, SubUnidad_Medida as SU, Categoria as C, SubCategoria as SC Where U.Cod_Unidad_Medida = A.Cod_Unidad_Medida And SU.Cod_SubUnidad_Medida = A.Cod_SubUnidad_Medida and M.Cod_Marca=A.Cod_Marca and C.Cod_Categoria=A.Cod_Categoria and SC.Cod_SubCategoria=A.Cod_SubCategoria and Mo.Cod_Articulo=A.Cod_Articulo ORDER BY Mo.Fecha DESC"


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


    ''' <summary>
    ''' Mapper de artículo, transforma un datatable en una lista de artículos
    ''' </summary>
    ''' <param name="DataTable"></param>
    ''' <returns></returns>
    Public Function MapearArticulo(DataTable As DataTable) As Articulo
        Dim Articulo As New Articulo

        Try

            For Each row As DataRow In DataTable.Rows

                Articulo.CodigoArticulo = row.Item("Cod_Articulo")
                Articulo.CodigoDeBarras = row.Item("Cod_Articulo_Proveedor")
                Articulo.Descripcion = (row).Item("Descripcion")
                Articulo.Categoria = (row).Item("Cod_Categoria")
                Articulo.Marca = (row).Item("Cod_Marca")
                Articulo.Precio = (row).Item("Precio")
                Articulo.SubCategoria = (row).Item("Cod_SubCategoria")
                Articulo.SubUnidadDeMedida = (row).Item("Cod_SubUnidad_Medida")
                Articulo.UnidadDeMedida = (row).Item("Cod_Unidad_Medida")



            Next

            Return Articulo

        Catch ex As Exception
            Throw New Exception("Error al mapear Articulo" & ex.Message)
        End Try
    End Function




    Public Sub CrearBaseDatos(query As String)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        'Dim Dal As New DAL.DatosBase
        _Consulta = query

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al crear base de datos " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub


End Class
