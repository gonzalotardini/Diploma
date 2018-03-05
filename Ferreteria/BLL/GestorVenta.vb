Imports BIZ
Imports SL
Imports DAL
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class GestorVenta


    Public Sub GenerarVenta(ByVal VentaCabecera As VentaCabecera, ByVal ListaDetalles As List(Of VentaDetalle))

        Dim _VentaFacade As New VentaFacade


        Try

            _VentaFacade.GenerarVenta(VentaCabecera, ListaDetalles)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try




    End Sub


    Public Sub GenerarVentaPDF(DetalleVentaPDF As List(Of SL.ClaseVentaPDF), VentaCabecera As VentaCabecera)



        Try
            Dim PdfDocument As New Document(PageSize.A4, 0, 0, 0, 0)

            'Declaro fuente
            Dim fuente As iTextSharp.text.pdf.BaseFont
            'Defino fuente
            fuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont

            Dim PdfWrite As PdfWriter = PdfWriter.GetInstance(PdfDocument, New FileStream("VENTA.pdf", FileMode.Create))

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
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "COMPROBANTE", 450, 800, 0)
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

            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Cliente:  " & VentaCabecera.Cod_Cliente, 20, 720, 0)

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
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL: $" & VentaCabecera.Total, 400, 30, 0)


            Dim Ubicacion As Integer = 670




            For I = 1 To DetalleVentaPDF.Count

                cb.SetFontAndSize(fuente, 8)




                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Cantidad, 20, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Codigo, 60, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Descripcion, 90, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Marca, 330, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Medida, 440, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Precio, 490, Ubicacion, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DetalleVentaPDF(I - 1).Importe, 540, Ubicacion, 0)

                Ubicacion = Ubicacion - 15




            Next





            cb.EndText()
            PdfDocument.Close()

            MsgBox("PDF OK", MsgBoxStyle.Information)


            Dim myProcess As New Process
            myProcess.StartInfo.CreateNoWindow = False
            myProcess.StartInfo.Verb = "print"
            myProcess.StartInfo.FileName = "VENTA.PDF"
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

    Public Function ValidarBusquedaVentaPorCodigoCliente(cliente As Cliente, cultura As String) As DataSet
        Try
            If Not IsNumeric(cliente.CodigoCliente) Then
                Select Case cultura
                    Case "ESPAÑOL"
                        Throw New Exception("Error, el código de cliente debe ser numérico")
                    Case "ENGLISH"
                        Throw New Exception("Error, client code must be numeric")
                End Select
            Else
                Dim ventaFacade As New VentaFacade

                Return ventaFacade.BuscarPresupuestoPorCodigoClientelFacade(cliente)
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub CancelarVentaBll(cod As Long)
        Try
            Dim ventaFacade = New VentaFacade

            ventaFacade.CancelarVentaFacade(cod)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub CancelarNotaDeCredito(codNotaCredito As Long, totalCredito As Decimal, totalVenta As Decimal, cultura As String)
        Try

            If totalVenta >= totalCredito Then
                Dim ventaFacade As New VentaFacade
                ventaFacade.CancelarNotaCreditoFacade(codNotaCredito)
            Else

                Select Case cultura
                    Case "ESPAÑOL"
                        Throw New Exception("Error, el total de la venta debe ser mayor al crédito")
                    Case "ENGLISH"
                        Throw New Exception("Error, the total of the sell must be higher than the credit")
                End Select

            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
