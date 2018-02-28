Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports BIZ
Imports iTextSharp.text
Imports iTextSharp.text.pdf

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

    Public Function ObtenerReportesArticulos() As DataTable
        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "select Cod_Reporte, convert(char(10),FechaInicio,103) as FechaDesde, convert(char(10),FechaFin,103) as FechaHasta, Usuario, Tipo from ReporteArticulosMasVendidos"

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

    Public Function ArticulosMasVendidos(ByVal _cantidad As Integer, ByVal _fecha_desde As Date, ByVal _fecha_hasta As Date) As DataTable
        Dim _Comando As New SqlCommand
        Dim _DataSet As New DataSet
        Dim _Consulta As String
        Dim Fecha_Desde = _fecha_desde.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
        Dim Fecha_Hasta = _fecha_hasta.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)

        '_fecha_desde = (_fecha_desde.Date).ToString("yyyy-mm-dd")


        Try

            _Consulta = "select  top " & _cantidad & "(d.Cod_Articulo), a.Descripcion,s.Descripcion,m.Descripcion,sum(cantidad) as 'Cantidad' from VentaDetalle d
                        inner join VentaCabecera c on c.Cod_Venta=d.Cod_Venta
                        inner join Articulo a on a.Cod_Articulo=d.Cod_Articulo
                        inner join SubUnidad_Medida s on s.Cod_SubUnidad_Medida=a.Cod_SubUnidad_Medida
                        inner join marca m on m.Cod_Marca = a.Cod_Marca
                        where c.Fecha between (Cast('" + Fecha_Desde + " 00:00:00' as datetime)) and (Cast('" + Fecha_Hasta + " 23:59:59' as datetime))
                        group by d.Cod_Articulo, a.Descripcion,s.Descripcion, m.Descripcion
                        order by Cantidad desc"

            Me.Conexion.Open()
            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)

            If _DataSet.Tables(0).Rows.Count = 0 Then
                Throw New Exception("No se encontraron articulos")
            End If


            Return _DataSet.Tables(0)

        Catch ex As Exception

            Throw New Exception(ex.Message)
            Return Nothing


        Finally
            Me.Conexion.Close()
        End Try




    End Function



    Public Sub ImprimirReportePreciosDAO(reporteCabecera As Reporte, listaDetalle As List(Of ReportePreciosDetalle))


        Try
            Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

            'Declaro fuente
            Dim fuente As iTextSharp.text.pdf.BaseFont
            'Defino fuente
            fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont

            Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New FileStream("ReportePrecios.pdf", FileMode.Create))

            Dim linea As PdfContentByte

            Dim cb As PdfContentByte


            PdfDocument.Open()
            PdfDocument.NewPage()




            linea = PdfWrite.DirectContent

            'linea.BeginText()


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(750, 750) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(0, 700) 'MoveTo indica el punto de inicio
            linea.LineTo(700, 700) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(300, 750) 'MoveTo indica el punto de inicio
            linea.LineTo(300, 800) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(280, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

            linea.SetLineWidth(1.2) 'configurando el ancho de linea
            linea.MoveTo(320, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 900) 'LineTo indica hacia donde se dibuja la linea
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
            linea.LineTo(320, 800) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


            'Linea final
            linea.SetLineWidth(1.5) 'configurando el ancho de linea
            linea.MoveTo(10, 50) 'MoveTo indica el punto de inicio
            linea.LineTo(590, 50) 'LineTo indica hacia donde se dibuja la linea 
            linea.Stroke() 'traza la linea actual y se puede iniciar una nueva



            cb = PdfWrite.DirectContent
            cb.BeginText()

            cb.SetFontAndSize(fuente, 18)

            'PdfDocument.Add(New Paragraph(" "))
            ' PdfDocument.Add(New Paragraph(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI"))


            'CABECERA
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI HNOS.", 145, 800, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "REPORTE", 450, 800, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

            cb.SetFontAndSize(fuente, 22)
            'X
            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "X", 300, 810, 0)
            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)


            'Izquierda
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Direccion: Artigas Jose G. 3985 CABA ", 20, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Condicion frente al IVA: Responsable Inscripto ", 20, 760, 0)


            'Cliente

            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Codigo de Reporte:  " & listaDetalle(1).Cod_Reporte, 20, 720, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Usuario:  " & reporteCabecera.Usuario, 210, 720, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Tipo Reporte:  " & reporteCabecera.Tipo, 365, 720, 0)

            'Derecha
            cb.SetFontAndSize(fuente, 11)
            'cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Punto de venta: 001", 400, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha:  " + reporteCabecera.Fecha.ToString("dd/MM/yyyy"), 400, 760, 0)

            'COLUMNAS
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Código", 20, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Descripcion", 70, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca", 210, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Medida", 260, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio Inicial", 305, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio Final", 365, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "#", 400, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "%", 425, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Desde", 480, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Hasta", 540, 685, 0)

            'Total


            'cb.SetFontAndSize(fuente, 20)
            'cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & PresupuestoCabecera.Total, 400, 30, 0)


            Dim Ubicacion As Integer = 670




            For I = 1 To listaDetalle.Count

                cb.SetFontAndSize(fuente, 8)


                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).Cod_Articulo, 10, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).Descripcion, 45, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).Marca1, 200, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).SubUnidad, 255, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).PrecioInicial, 300, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).PrecioFinal, 350, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).CantidadPrecios, 400, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).PorcentajeAumento, 420, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).Fecha_Desde, 460, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, listaDetalle(I - 1).Fecha_Hasta, 520, Ubicacion, 0)

                Ubicacion = Ubicacion - 15




            Next





            cb.EndText()
            PdfDocument.Close()

            Dim myProcess As New Process
            myProcess.StartInfo.CreateNoWindow = False
            myProcess.StartInfo.Verb = "print"
            myProcess.StartInfo.FileName = "ReportePrecios.pdf"
            myProcess.Start()
            myProcess.WaitForExit(10000)
            myProcess.CloseMainWindow()
            myProcess.Close()


            Dim myprocesses As Process() = System.Diagnostics.Process.GetProcessesByName("AcroRd32")


            System.Threading.Thread.Sleep(7000)

            For Each myproces As Process In myprocesses
                myproces.Kill()
            Next





        Catch ex As Exception
            MsgBox("Error al crear pdf", ex.Message)
        End Try

    End Sub

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


        _Consulta = "insert into ReporteAumentoDePrecios (Fecha, Tipo ,Usuario) Values (@Fecha, @Tipo, @Usuario)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            '_Comando.Parameters.AddWithValue("@Cod_Reporte", ReporteCabecera.Cod_Reporte)
            _Comando.Parameters.AddWithValue("@Fecha", ReporteCabecera.Fecha)
            _Comando.Parameters.AddWithValue("@Usuario", ReporteCabecera.Usuario)
            _Comando.Parameters.AddWithValue("@Tipo", ReporteCabecera.Tipo)

            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar Reporte " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try

    End Sub

    Public Sub GuardarReporteArticulosCabecera(ReporteCabecera As ReporteArticulosCabecera)
        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into ReporteArticulosMasVendidos (FechaInicio, FechaFin, Tipo ,Usuario) Values (@FechaInicio, @FechaFin, @Tipo ,@Usuario)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            '_Comando.Parameters.AddWithValue("@Cod_Reporte", ReporteCabecera.Cod_Reporte)
            _Comando.Parameters.AddWithValue("@FechaInicio", ReporteCabecera.FechaInicio)
            _Comando.Parameters.AddWithValue("@FechaFin", ReporteCabecera.FechaFin)
            _Comando.Parameters.AddWithValue("@Usuario", ReporteCabecera.Usuario)
            _Comando.Parameters.AddWithValue("@Tipo", ReporteCabecera.Tipo)

            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar Reporte " & ex.Message)


        Finally
            Me.Conexion.Close()
        End Try

    End Sub

    Public Sub GuardarReporteArticulosDetalle(item As ReporteArticulosMasVendidosDetalle)

        Dim _Consulta As String
        Dim _Comando As New SqlCommand


        _Consulta = "insert into ReporteArticulosMasVendidosDetalle (Cod_Reporte, Cod_Articulo, CantidadVentas) Values (@Cod_Reporte, @Cod_Articulo, @CantidadVentas)"

        Try

            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Comando.Parameters.AddWithValue("@Cod_Reporte", item.Cod_Reporte)
            _Comando.Parameters.AddWithValue("@Cod_Articulo", item.Cod_Articulo)
            _Comando.Parameters.AddWithValue("@CantidadVentas", item.CantidadVentas)


            _Comando.ExecuteNonQuery()


        Catch ex As Exception

            Throw New Exception("Error al cargar el artículo " & ex.Message)


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


    Public Function ObtenerCodUltimoReporteArticulos() As Integer

        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim _Codigo As Integer

        Try


            Me.Conexion.Open()

            _Consulta = "select top 1 Cod_Reporte from ReporteArticulosMasVendidos order by Cod_Reporte desc "

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            _Codigo = (_Comando.ExecuteScalar) 'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


            Return _Codigo


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()

        End Try



    End Function



    Public Function ObtenerReportes() As DataTable

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _dataSet As New DataSet
        Dim _Convertir As New Convertir



        Try
            _Consulta = "select Cod_Reporte,Fecha, Usuario, Tipo from ReporteAumentoDePrecios"

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

    'Public Sub GenerarPdf(ListaDetalle As List(Of Reporte), PresupuestoCabecera As PresupuestoCabecera, b As Integer)
    '    Try
    '        Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

    '        'Declaro fuente
    '        Dim fuente As iTextSharp.text.pdf.BaseFont
    '        'Defino fuente
    '        fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont


    '        Dim path As String

    '        path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    '        Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New System.IO.FileStream(path + "\PRESUPUESTO.pdf", FileMode.Create))



    '        Dim linea As PdfContentByte




    '        Dim cb As PdfContentByte


    '        PdfDocument.Open()
    '        PdfDocument.NewPage()




    '        linea = PdfWrite.DirectContent

    '        'linea.BeginText()


    '        linea.SetLineWidth(1.5) 'configurando el ancho de linea
    '        linea.MoveTo(0, 750) 'MoveTo indica el punto de inicio
    '        linea.LineTo(750, 750) 'LineTo indica hacia donde se dibuja la linea 
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

    '        linea.SetLineWidth(1.5) 'configurando el ancho de linea
    '        linea.MoveTo(0, 700) 'MoveTo indica el punto de inicio
    '        linea.LineTo(700, 700) 'LineTo indica hacia donde se dibuja la linea 
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

    '        linea.SetLineWidth(1.5) 'configurando el ancho de linea
    '        linea.MoveTo(300, 750) 'MoveTo indica el punto de inicio
    '        linea.LineTo(300, 800) 'LineTo indica hacia donde se dibuja la linea
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

    '        linea.SetLineWidth(1.2) 'configurando el ancho de linea
    '        linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
    '        linea.LineTo(280, 900) 'LineTo indica hacia donde se dibuja la linea
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva

    '        linea.SetLineWidth(1.2) 'configurando el ancho de linea
    '        linea.MoveTo(320, 800) 'MoveTo indica el punto de inicio
    '        linea.LineTo(320, 900) 'LineTo indica hacia donde se dibuja la linea
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


    '        linea.SetLineWidth(1.5) 'configurando el ancho de linea
    '        linea.MoveTo(280, 800) 'MoveTo indica el punto de inicio
    '        linea.LineTo(320, 800) 'LineTo indica hacia donde se dibuja la linea 
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva


    '        'Linea final
    '        linea.SetLineWidth(1.5) 'configurando el ancho de linea
    '        linea.MoveTo(10, 50) 'MoveTo indica el punto de inicio
    '        linea.LineTo(590, 50) 'LineTo indica hacia donde se dibuja la linea 
    '        linea.Stroke() 'traza la linea actual y se puede iniciar una nueva






    '        cb = PdfWrite.DirectContent
    '        cb.BeginText()

    '        cb.SetFontAndSize(fuente, 18)

    '        'PdfDocument.Add(New Paragraph(" "))
    '        ' PdfDocument.Add(New Paragraph(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI"))


    '        'CABECERA
    '        cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "FERRETERIA TARDINI HNOS.", 145, 800, 0)
    '        ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

    '        If b = 1 Then

    '            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMPROBANTE", 450, 800, 0)
    '            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)

    '        Else
    '            cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 450, 800, 0)
    '            ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)
    '        End If

    '        cb.SetFontAndSize(fuente, 22)
    '        'X
    '        cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "X", 300, 810, 0)
    '        ' cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 300, 725, 0)


    '        'Izquierda
    '        cb.SetFontAndSize(fuente, 8)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Direccion: Artigas Jose G. 3985 CABA ", 20, 780, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Condicion frente al IVA: Responsable Inscripto ", 20, 760, 0)


    '        'Cliente

    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Cliente:  " & PresupuestoCabecera.Nombre, 20, 720, 0)

    '        'Derecha
    '        cb.SetFontAndSize(fuente, 11)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Punto de venta: 001", 400, 780, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha:  " + Now.ToShortDateString, 400, 760, 0)

    '        'COLUMNAS
    '        cb.SetFontAndSize(fuente, 8)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cantidad", 25, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Código", 65, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Descripción", 130, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca", 350, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Medida", 450, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio", 500, 685, 0)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Importe", 550, 685, 0)

    '        'Total


    '        cb.SetFontAndSize(fuente, 20)
    '        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & PresupuestoCabecera.Total, 400, 30, 0)


    '        Dim Ubicacion As Integer = 670




    '        For I = 1 To ListaDetalle.Count

    '            cb.SetFontAndSize(fuente, 8)


    '            'obtenemos el valor de la columna en la variable declarada
    '            ' ListaDetalledetalle.Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer
    '            ' detalle.Cantidad = row.Cells(1).Value
    '            ' detalle.Descripcion = row.Cells(2).Value
    '            ' detalle.Marca = row.Cells(3).Value
    '            ' detalle.Medida = row.Cells(4).Value
    '            ' detalle.Precio = row.Cells(5).Value
    '            ' detalle.Importe = row.Cells(6).Value

    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Cantidad, 20, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Codigo, 60, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Descripcion, 90, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Marca, 330, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Medida, 440, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Precio, 490, Ubicacion, 0)
    '            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, ListaDetalle(I - 1).Importe, 540, Ubicacion, 0)

    '            Ubicacion = Ubicacion - 15




    '        Next





    '        cb.EndText()
    '        PdfDocument.Close()

    '        MsgBox("PDF OK", MsgBoxStyle.Information)



    '    Catch ex As Exception
    '        MsgBox("Error al crear pdf", ex.Message)
    '    End Try





    'End Sub

End Class
