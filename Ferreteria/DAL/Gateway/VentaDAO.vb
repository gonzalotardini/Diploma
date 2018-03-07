Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Transactions

Public Class VentaDAO
    Inherits DatosBase


    ''' <summary>
    ''' genera una nueva cabecera de una venta la cual contendra codigo de cliente fecha y total de la venta
    ''' </summary>
    ''' <param name="VentaCabecera"></param>
    ''' <remarks></remarks>


    Public Sub GenerarVentaCabecera(VentaCabecera As VentaCabecera)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into VentaCabecera (Cod_Cliente,Estado,Fecha, Total) Values (@Cod_Cliente,@Estado, @Fecha, @Total)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Cliente", VentaCabecera.Cod_Cliente)
            _Comando.Parameters.AddWithValue("@Fecha", VentaCabecera.Fecha)
            _Comando.Parameters.AddWithValue("@Total", VentaCabecera.Total)
            _Comando.Parameters.AddWithValue("@Estado", 0)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al generar venta " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try





    End Sub

    ''' <summary>
    ''' Obtiene el codigo de la ultima venta realizada
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerCodUltimaVenta() As Integer



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _Codigo As Integer



        Try


            Me.Conexion.Open()

            _Consulta = "select top 1 Cod_Venta from VentaCabecera order by Cod_Venta desc "

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
    ''' Genera una linea de detalle de una venta a guardar
    ''' </summary>
    ''' <param name="VentaDetalle"></param>
    ''' <remarks></remarks>


    Public Sub GenerarVentaDetalle(VentaDetalle As VentaDetalle)


        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into VentaDetalle (Cod_Venta, Cod_Articulo, Cantidad, Precio, Importe, SubTotal, Iva) Values (@Cod_Venta, @Cod_Articulo, @Cantidad, @Precio, @Importe, @SubTotal, @Iva)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Venta", VentaDetalle.Cod_Venta)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", VentaDetalle.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@Cantidad", VentaDetalle.Cantidad)
            _Comando.Parameters.AddWithValue("@Precio", VentaDetalle.Precio)
            _Comando.Parameters.AddWithValue("@Importe", VentaDetalle.Importe)
            _Comando.Parameters.AddWithValue("@SubTotal", VentaDetalle.SubTotal)
            _Comando.Parameters.AddWithValue("@Iva", VentaDetalle.Iva)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al generar venta " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try

    End Sub

    ''' <summary>
    ''' Obtiene la cabecera de todas las ventas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerVentas() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select V.Cod_Venta, V.Cod_Cliente, C.Razon_Social, V.Fecha, V.Total From VentaCabecera as V , Cliente as C Where C.Cod_Cliente=V.Cod_Cliente and Estado=0"





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
    ''' Obtiene el detalle de una venta determinada por el usuario
    ''' </summary>
    ''' <param name="VentaCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>


    Public Function ObtenerVentaDetalle(VentaCabecera As VentaCabecera) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet



        Try


            'lleno el detalle del presupuesto
            _Consulta = "select V.Cantidad ,V.cod_articulo as 'Codigo Articulo', A.Cod_Articulo_Proveedor as 'CodigoBarras', A.Descripcion, M.Descripcion as Marca, SU.Descripcion as 'UnidadMedida', V.Precio, V.importe from Marca as M, SubUnidad_Medida as SU, VentaDetalle as V, Articulo AS A WHERE V.Cod_Articulo=A.Cod_Articulo and M.Cod_Marca=A.cod_Marca and SU.Cod_SubUnidad_Medida=A.Cod_SubUnidad_Medida  AND Cod_Venta=@Cod_Venta "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Venta", VentaCabecera.Cod_Venta)

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
    ''' Obtiene la cabecera de una determinada venta
    ''' </summary>
    ''' <param name="_VentaCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ObtenerCabecera(_VentaCabecera As VentaCabecera) As VentaCabecera

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_Venta, V.Cod_Cliente, C.Razon_Social, Fecha, Total From VentaCabecera as V, Cliente as C Where C.Cod_Cliente=V.Cod_Cliente and Cod_Venta=@Cod_Venta"





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)


            _Comando.Parameters.AddWithValue("@Cod_Venta", _VentaCabecera.Cod_Venta)

            _Adapter.Fill(_dataSet)



            _VentaCabecera.Cod_Cliente = _dataSet.Tables(0).Rows(0).Item("Cod_Cliente")

            _VentaCabecera.Cod_Venta = _dataSet.Tables(0).Rows(0).Item("Cod_Venta")

            _VentaCabecera.Fecha = _dataSet.Tables(0).Rows(0).Item("Fecha")


            _VentaCabecera.Total = _dataSet.Tables(0).Rows(0).Item("Total")





            Return _VentaCabecera


        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally


            Me.Conexion.Close()

        End Try


    End Function


    ''' <summary>
    ''' Obtiene los datos del cliente que concretó determinada venta
    ''' </summary>
    ''' <param name="_VentaCabecera"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>


    Public Function ObtenerDatosCliente(_VentaCabecera As VentaCabecera) As Cliente

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir
        Dim _Cliente As New Cliente



        Try
            _Consulta = "Select C.Razon_Social, C.Cuit from Cliente as C, VentaCabecera as V where C.Cod_Cliente = v.Cod_Cliente and V.Cod_Cliente=@Cod_Cliente "





            Me.Conexion.Open()



            _Comando = New SqlCommand(_Consulta, Me.Conexion)



            Dim _Adapter As New SqlDataAdapter(_Comando)


            _Comando.Parameters.AddWithValue("@Cod_Cliente", _VentaCabecera.Cod_Cliente)

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

    Public Sub CancelarVentaDao(cod_venta As Long)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _CodNotaCredito As Long

        Using ts As TransactionScope = New TransactionScope
            Try
                'Creo cabecera de nota de credito
                _Consulta = "insert into NotaDeCredito select Cod_Cliente,Cod_Venta,Total,Fecha,0 from VentaCabecera where Cod_Venta=" & cod_venta
                Me.Conexion.Open()
                _Comando = New SqlCommand(_Consulta, Me.Conexion)
                '_Comando.Parameters.AddWithValue("@Cod_Venta", cod_venta)
                _Comando.ExecuteNonQuery()

                _Consulta = "update VentaCabecera set Estado=1 where Cod_Venta=" & cod_venta
                _Comando = New SqlCommand(_Consulta, Me.Conexion)
                '_Comando.Parameters.AddWithValue("@Cod_Venta", cod_venta)
                _Comando.ExecuteNonQuery()

                Me.Conexion.Close()

                _CodNotaCredito = ObtenerCodUltimaNotaDeCredito()
                Me.Conexion.Open()
                _Consulta = "insert into NotaDeCreditoDetalle select " & _CodNotaCredito & ",cod_articulo,cantidad, importe, precio from VentaDetalle where cod_venta=" & cod_venta
                _Comando = New SqlCommand(_Consulta, Me.Conexion)
                '_Comando.Parameters.AddWithValue("@Cod_Venta", cod_venta)
                _Comando.ExecuteNonQuery()


            Catch ex As Exception

                Throw New Exception("Error: " & ex.Message)


            Finally
                Me.Conexion.Close()
            End Try

            ts.Complete()

        End Using

    End Sub

    Public Function ObtenerCodUltimaNotaDeCredito() As Integer



        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _Codigo As Integer



        Try


            Me.Conexion.Open()

            _Consulta = "select top 1 Cod_NotaCredito from NotaDeCredito order by Cod_NotaCredito desc "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Codigo = (_Comando.ExecuteScalar) 'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


            Return _Codigo


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()

        End Try

    End Function





    Public Function ObtenerNotasDeCredito() As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "select Cod_NotaCredito as ID, c.Cod_Cliente as CodCliente ,c.Razon_Social, n.Cod_Venta, Credito, convert(char(10),Fecha,103) as FechaVenta from NotaDeCredito n
                        inner join Cliente c on c.Cod_Cliente=n.Cod_Cliente Where Estado=0"

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

    Public Function BuscarNotaDeCreditoPorCOD(cod As Long) As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "select Cod_NotaCredito as ID, c.Cod_Cliente as CodCliente ,c.Razon_Social, n.Cod_Venta, Credito, convert(char(10),Fecha,103) as FechaVenta from NotaDeCredito n
                        inner join Cliente c on c.Cod_Cliente=n.Cod_Cliente Where Estado=0 and Cod_NotaCredito=" & cod

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

    Public Function BuscarNotaDeCreditoPorRazonSocial(razonSocial As String)
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "select Cod_NotaCredito as ID, c.Cod_Cliente as CodCliente ,c.Razon_Social, n.Cod_Venta, Credito, convert(char(10),Fecha,103) as FechaVenta from NotaDeCredito n
                        inner join Cliente c on c.Cod_Cliente=n.Cod_Cliente Where Estado=0 and C.Razon_Social like '%" & razonSocial & "%'"

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

    Public Sub CancelarNotaDeCredito(codNota As Long)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "update NotaDeCredito set Estado=1 where Cod_NotaCredito=" & codNota

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)
            _Comando.ExecuteNonQuery()


        Catch ex As Exception
            Throw New Exception("Error al generar venta " & ex.Message)
        Finally
            Me.Conexion.Close()
        End Try
    End Sub


    Public Function BucarVentaPorCodigoCliente(Cliente As Cliente) As DataSet

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_venta, V.Cod_Cliente, C.Razon_Social, Fecha, Total From VentaCabecera as V, Cliente as C Where V.Cod_Cliente=c.Cod_Cliente and c.Cod_Cliente='" & Cliente.CodigoCliente & "' and Estado=0"





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

    Public Function BucarVentaPorRazonSocial(Cliente As Cliente) As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "Select Cod_venta, V.Cod_Cliente, C.Razon_Social, Fecha, Total From VentaCabecera as V, Cliente as C Where V.Cod_Cliente=c.Cod_Cliente and C.Razon_Social like '%" & Cliente.RazonSocial & "%' and Estado=0"

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

End Class
