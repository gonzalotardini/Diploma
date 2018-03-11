Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient



Public Class PresupuestoDAO
    Inherits DatosBase


    ''' <summary>
    ''' Genera la cabcera de un presupuesto en donde estaran los datos del ciente, fecha, total y codigo de presupuesto
    ''' </summary>
    ''' <param name="PresupuestoCabecera"></param>
    ''' <remarks></remarks>
    Public Sub GenerarPresupuestoCabecera(PresupuestoCabecera As PresupuestoCabecera)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into PresupuestoCabecera (Cod_Cliente, Fecha_Inicio, Fecha_Fin, Total, Estado) Values (@Cod_Cliente, @Fecha_Inicio, @Fecha_Fin, @Total, 0)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Cliente", PresupuestoCabecera.Cod_Cliente)
            _Comando.Parameters.AddWithValue("@Fecha_Inicio", PresupuestoCabecera.FechaInicio)
            _Comando.Parameters.AddWithValue("@Fecha_Fin", PresupuestoCabecera.FechaFin)
            _Comando.Parameters.AddWithValue("@Total", PresupuestoCabecera.Total)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try





    End Sub

    ''' <summary>
    ''' Genera una línea de detalle de un determinado presupuesto
    ''' </summary>
    ''' <param name="PresupuestoDetalle"></param>
    ''' <remarks></remarks>
    Public Sub GenerarPresupuestoDetalle(PresupuestoDetalle As PresupuestoDetalle)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into PresupuestoDetalle (Cod_Presupuesto, Cod_Articulo, Cantidad, Precio, Importe, SubTotal, Iva) Values (@Cod_Presupuesto, @Cod_Articulo, @Cantidad, @Precio, @Importe, @SubTotal, @Iva)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", PresupuestoDetalle.Cod_Presupuesto)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", PresupuestoDetalle.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@Cantidad", PresupuestoDetalle.Cantidad)
            _Comando.Parameters.AddWithValue("@Precio", PresupuestoDetalle.Precio)
            _Comando.Parameters.AddWithValue("@Importe", PresupuestoDetalle.Importe)
            _Comando.Parameters.AddWithValue("@SubTotal", PresupuestoDetalle.SubTotal)
            _Comando.Parameters.AddWithValue("@Iva", PresupuestoDetalle.Iva)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try

    End Sub


    ''' <summary>
    ''' Obtiene el código del úiltimo presupuesto realizado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerCodUltimoPresupuesto() As Integer



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _Codigo As Integer



        Try


            Me.Conexion.Open()

            _Consulta = "select top 1 Cod_Presupuesto from presupuestocabecera order by Cod_Presupuesto desc "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Codigo = (_Comando.ExecuteScalar) 'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


            Return _Codigo


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()

        End Try



    End Function


    ''' <summary>
    ''' Obtiene la cabecera de todos los presupuestos realizados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerPresupuestos() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_Presupuesto, P.Cod_Cliente, C.Razon_Social, Fecha_Inicio, Fecha_Fin, Total From PresupuestoCabecera as P, Cliente as C Where C.Cod_Cliente=P.Cod_Cliente and Estado=0"





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)





            Return _dataSet.Tables(0)


        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function


    ''' <summary>
    ''' Realiza la búsqueda de presupuestos mediante la razón social del cliente
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BucarPresupuestoPorRazonSocial(Cliente As Cliente) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_Presupuesto, P.Cod_Cliente, C.Razon_Social, Fecha_Inicio, Fecha_Fin, Total From PresupuestoCabecera as P, Cliente as C Where C.Cod_Cliente=P.Cod_Cliente and C.Razon_Social like '%" + Cliente.RazonSocial + "%'"





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)





            Return _dataSet


        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function



    ''' <summary>
    ''' Realiza la búsqueda de presupuestos mediante el código de cliente
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function BucarPresupuestoPorCodigoCliente(Cliente As Cliente) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_Presupuesto, P.Cod_Cliente, C.Razon_Social, Fecha_Inicio, Fecha_Fin, Total From PresupuestoCabecera as P, Cliente as C Where C.Cod_Cliente=P.Cod_Cliente and  P.Cod_Cliente='" & Cliente.CodigoCliente & "'"





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_dataSet)





            Return _dataSet


        Catch ex As Exception

            Throw New Exception(ex.Message)

            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function


    ''' <summary>
    ''' Obtiene todos los detalles de determinado presupuesto
    ''' </summary>
    ''' <param name="PresupuestoCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>



    Public Function ObtenerPresupuestoDetalle(PresupuestoCabecera As PresupuestoCabecera) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet



        Try


            'lleno el detalle del presupuesto
            _Consulta = "select PC.Cantidad ,PC.cod_articulo as 'Codigo Articulo', A.Cod_Articulo_Proveedor as 'CodigoBarras', A.Descripcion, M.Descripcion as Marca, SU.Descripcion as 'UnidadMedida', PC.Precio, PC.importe from Marca as M, SubUnidad_Medida as SU, PresupuestoDetalle as PC, Articulo AS A WHERE PC.Cod_Articulo=A.Cod_Articulo and M.Cod_Marca=A.cod_Marca and SU.Cod_SubUnidad_Medida=A.Cod_SubUnidad_Medida  AND Cod_Presupuesto=@Cod_Presupuesto "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", PresupuestoCabecera.Cod_Presupuesto)

            Dim _Adapter As New SqlDataAdapter(_Comando)



            _Adapter.Fill(_DataSet)

            Return _DataSet



        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally
            Me.Conexion.Close()

        End Try


       

    End Function



    ''' <summary>
    ''' Obtiene toda la cabecera de determinado presupuesto
    ''' </summary>
    ''' <param name="_PresupuestoCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>


    Public Function ObtenerCabecera(_PresupuestoCabecera As PresupuestoCabecera) As PresupuestoCabecera

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_Presupuesto, P.Cod_Cliente, C.Razon_Social, Fecha_Inicio, Fecha_Fin, Total From PresupuestoCabecera as P, Cliente as C Where C.Cod_Cliente=P.Cod_Cliente and Cod_Presupuesto=@Cod_Presupuesto"





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)


            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", _PresupuestoCabecera.Cod_Presupuesto)

            _Adapter.Fill(_dataSet)



            _PresupuestoCabecera.Cod_Cliente = _dataSet.Tables(0).Rows(0).Item("Cod_Cliente")

            _PresupuestoCabecera.Cod_Presupuesto = _dataSet.Tables(0).Rows(0).Item("Cod_Presupuesto")

            _PresupuestoCabecera.FechaInicio = _dataSet.Tables(0).Rows(0).Item("Fecha_Inicio")


            _PresupuestoCabecera.FechaFin = _dataSet.Tables(0).Rows(0).Item("Fecha_Fin")


            _PresupuestoCabecera.Total = _dataSet.Tables(0).Rows(0).Item("Total")





            Return _PresupuestoCabecera


        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function



    ''' <summary>
    ''' Obtiene todos los datos de la cabecera del presupuesto que pertenezcan al cliente
    ''' </summary>
    ''' <param name="_PresupuestoCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerDatosCliente(_PresupuestoCabecera As PresupuestoCabecera) As Cliente

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir
        Dim _Cliente As New Cliente



        Try
            _Consulta = "Select C.Razon_Social, C.Cuit from Cliente as C, PresupuestoCabecera as P where C.Cod_Cliente = P.Cod_Cliente and P.Cod_Cliente=@Cod_Cliente "





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)


            _Comando.Parameters.AddWithValue("@Cod_Cliente", _PresupuestoCabecera.Cod_Cliente)

            _Adapter.Fill(_dataSet)



            _Cliente.RazonSocial = _dataSet.Tables(0).Rows(0).Item("Razon_Social")
            _Cliente.Cuit = _dataSet.Tables(0).Rows(0).Item("Cuit")







            Return _Cliente

        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function


    ''' <summary>
    ''' Eliminar todo el detalle de un presupuesto
    ''' </summary>
    ''' <param name="_PresupuestoCabecera"></param>
    ''' <remarks></remarks>


    Public Sub EliminarPresupuestoDetalle(_PresupuestoCabecera As PresupuestoCabecera)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "Delete from PresupuestoDetalle where Cod_Presupuesto=@Cod_Presupuesto"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", _PresupuestoCabecera.Cod_Presupuesto)
         


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub



    ''' <summary>
    ''' Actualiza el total de un presupuesto ya realizado
    ''' </summary>
    ''' <param name="_PresupuestoCabecera"></param>
    ''' <remarks></remarks>

    Public Sub ActualizarTotal(_PresupuestoCabecera As PresupuestoCabecera)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "Update PresupuestoCabecera set Total=@Total where Cod_Presupuesto=@Cod_Presupuesto"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Total", _PresupuestoCabecera.Total)
            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", _PresupuestoCabecera.Cod_Presupuesto)



            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try


    End Sub

    ''' <summary>
    ''' Realiza la eliminación de la cabecera de un presupuesto determinado
    ''' </summary>
    ''' <param name="cod"></param>
    Public Sub EliminarPresupuesto(cod As Long)
        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "Update PresupuestoCabecera set Estado=1 where Cod_Presupuesto=@Cod_Presupuesto"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Presupuesto", cod)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error,  " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try
    End Sub
End Class
