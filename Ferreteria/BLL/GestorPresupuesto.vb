Imports BIZ
Imports DAL
Imports SL
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class GestorPresupuesto

    ''' <summary>
    ''' Calcula el importe de un artículo del presupuesto
    ''' </summary>
    ''' <param name="Cantidad"></param>
    ''' <param name="Precio"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function CalcularImporte(ByVal Cantidad As Decimal, ByVal Precio As Decimal) As Decimal


        Dim Importe As Decimal

        Importe = Cantidad * Precio

        Return [Importe]



    End Function

    ''' <summary>
    ''' Calcula el total de un presupuesto
    ''' </summary>
    ''' <param name="ListaDetalles"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function CalcularTotal(ListaDetalles As List(Of PresupuestoDetalle)) As Decimal

        Dim Total As Decimal

        For I = 0 To ListaDetalles.Count - 1


            Total = Total + ListaDetalles(I).Importe

        Next



        Return Total

    End Function

    Public Sub GenerarPresupuesto(ByVal PresupuestoCabecera As PresupuestoCabecera, ByVal ListaDetalles As List(Of PresupuestoDetalle))

        Dim _PresupuestoFacade As New PresupuestoFacade


        Try

            _PresupuestoFacade.GenerarPresupuesto(PresupuestoCabecera, ListaDetalles)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try




    End Sub


    ''' <summary>
    ''' genera el reporte de un presupuesto para ser impreso
    ''' </summary>
    ''' <param name="DetallePresupuestoPDF"></param>
    ''' <param name="PresupuestoCabecera"></param>
    ''' <remarks></remarks>

    Public Sub GenerarPresupuestoPDF(DetallePresupuestoPDF As List(Of SL.ClasePDFpresupuesto), PresupuestoCabecera As PresupuestoCabecera)



        Try
            Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

            'Declaro fuente
            Dim fuente As iTextSharp.text.pdf.BaseFont
            'Defino fuente
            fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont

            Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New FileStream("PRESUPUESTO.pdf", FileMode.Create))

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
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "PRESUPUESTO", 450, 800, 0)
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
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Codigo:  " & PresupuestoCabecera.Cod_Presupuesto, 20, 720, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Codigo Cliente:  " & PresupuestoCabecera.Cod_Cliente, 170, 720, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Razon Social:  " & PresupuestoCabecera.RazonSocial, 300, 720, 0)


            'Derecha
            cb.SetFontAndSize(fuente, 11)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Punto de venta: 001", 400, 780, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Fecha:  " + Now.ToShortDateString, 400, 760, 0)

            'COLUMNAS
            cb.SetFontAndSize(fuente, 8)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cantidad", 20, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Código", 65, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Descripción", 130, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca", 350, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Medida", 450, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Precio", 500, 685, 0)
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Importe", 550, 685, 0)

            'Total


            cb.SetFontAndSize(fuente, 20)
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & PresupuestoCabecera.Total, 400, 30, 0)


            Dim Ubicacion As Integer = 670




            For I = 1 To DetallePresupuestoPDF.Count

                cb.SetFontAndSize(fuente, 8)




                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Cantidad, 20, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Codigo, 60, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Descripcion, 90, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Marca, 330, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Medida, 440, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Precio, 490, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetallePresupuestoPDF(I - 1).Importe, 540, Ubicacion, 0)

                Ubicacion = Ubicacion - 15




            Next





            cb.EndText()
            PdfDocument.Close()

            MsgBox("PDF OK", MsgBoxStyle.Information)


            Dim myProcess As New Process
            myProcess.StartInfo.CreateNoWindow = False
            myProcess.StartInfo.Verb = "print"
            myProcess.StartInfo.FileName = "PRESUPUESTO.PDF"
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

    ''' <summary>
    ''' Es un pasa manos que llama a la capa facade para realzar la elimninacion de un presupuesto
    ''' </summary>
    ''' <param name="cod"></param>
    Public Sub EliminarPresupuestoBll(cod As Long)
        Try
            Dim presupuestoFacade As New PresupuestoFacade
            presupuestoFacade.EliminarPresupuestoFacade(cod)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Valida que los datos sean correctos para realizar una busqueda de presupuesto mediante razon social
    ''' </summary>
    ''' <param name="Cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ValidarBusquedaClientePorRazonSocial(Cliente As Cliente) As DataSet

        Dim _PresupuestoFacade As New PresupuestoFacade
        Try

            Return _PresupuestoFacade.BuscarPresupuestoPorRazonSocialFacade(Cliente)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Function


    ''' <summary>
    ''' Valida que los datos sean correctos para realizar una busqueda de presupuesto mediante codigo
    ''' </summary>
    ''' <param name="_Cliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ValidarBusquedaClientePorCodigoCliente(_Cliente As Cliente) As DataSet

        Dim _PresupuestoFacade As New PresupuestoFacade

        Try

            Return _PresupuestoFacade.BuscarPresupuestoPorCodigoClientelFacade(_Cliente)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try



    End Function


    ''' <summary>
    ''' Obtiene el detalle de un presupuesto en particular. LLama a la capa Facade
    ''' </summary>
    ''' <param name="_presupuestoCabecera"></param>
    ''' <returns></returns>
    Public Function ObtenerPresupuestoDetalleBLL(_presupuestoCabecera As PresupuestoCabecera) As DataSet

        Dim _PresupuestoFacade As New PresupuestoFacade
        Try

            Return _PresupuestoFacade.ObtenerPresupuestoDetalleFacade(_presupuestoCabecera)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try
    End Function



    ''' <summary>
    ''' Se encarga de llamar a la capa Facade para realizar la actualizacion de un presupuesto
    ''' </summary>
    ''' <param name="_PresupuestoCabecera"></param>
    ''' <param name="_ListaDetalles"></param>
    Public Sub ActualizarPresupuesto(ByVal _PresupuestoCabecera As PresupuestoCabecera, ByVal _ListaDetalles As List(Of PresupuestoDetalle))

        Dim _PresupuestoFacade As New PresupuestoFacade

        Try

            _PresupuestoFacade.ActualizarPresupuestoFacade(_PresupuestoCabecera, _ListaDetalles)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try





    End Sub


End Class
