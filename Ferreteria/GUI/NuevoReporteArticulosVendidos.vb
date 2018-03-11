﻿Imports BLL
Imports SL
Imports BIZ
Imports DAL

Public Class NuevoReporteArticulosVendidos
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles GenerarButton.Click

        Try
            Dim reporteBLL = New GestorReporte
            Dim fecha_desde As Date
            Dim fecha_hasta As Date
            Dim cantidad As Integer

            fecha_desde = FechaDesde.Value
            fecha_hasta = FechaHasta.Value
            cantidad = CantidadInput.Value


            DataGridViewX1.DataSource = reporteBLL.ObtenerArticulosMasVendidosBLL(cantidad, fecha_desde, fecha_hasta)


            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try





    End Sub

    Private Sub ReporteArticulosVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CantidadInput.Value = 10
        Me.Icon = My.Resources.ico

        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma

        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma

            GenerarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BUSCAR" Select V.Value).FirstOrDefault
            LabelDesde.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESDE" Select V.Value).FirstOrDefault
            LabelHasta.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "HASTA" Select V.Value).FirstOrDefault
            FinalizarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FINALIZAR" Select V.Value).FirstOrDefault
            CantidadLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDAD" Select V.Value).FirstOrDefault
            ReporteArticulosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEARTICULOS" Select V.Value).FirstOrDefault

        End If


        If Principal.CulturaGlobal = "ENGLISH" Then


            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            GenerarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BUSCAR" Select V.Value).FirstOrDefault
            LabelDesde.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESDE" Select V.Value).FirstOrDefault
            LabelHasta.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "HASTA" Select V.Value).FirstOrDefault
            FinalizarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FINALIZAR" Select V.Value).FirstOrDefault
            CantidadLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDAD" Select V.Value).FirstOrDefault
              ReporteArticulosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEARTICULOS" Select V.Value).FirstOrDefault
        End If


        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
        DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewX1.AllowUserToAddRows = False

    End Sub

    Private Sub VentasLabel_Click(sender As Object, e As EventArgs) Handles ReporteArticulosLabel.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles FinalizarButton.Click

        Dim listaDetalle As List(Of ReporteArticulosMasVendidosDetalle)
        Dim item As ReporteArticulosMasVendidosDetalle
        Dim GestorReporte As New GestorReporte
        Dim ReporteCabecera As New ReporteArticulosCabecera
        Dim msg As String = ""
        Dim msg2 = ""
        Dim reporteDao = New ReporteDAO


        Select Case Principal.CulturaGlobal
            Case "ESPAÑOL"
                msg = "¿Seguro desea finalizar el reporte?"
                msg2 = "¿Desea imprimir el reporte?"
            Case "ENGLISH"
                msg = "Do you really want to finish the report?"
                msg2 = "Do you want to print the report?"
        End Select

        Try
            If MsgBox(msg, MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then
                ReporteCabecera.Usuario = LogIn.Usuario.NombreUsuario
                ReporteCabecera.FechaInicio = FechaDesde.Value
                ReporteCabecera.FechaFin = FechaHasta.Value

                listaDetalle = New List(Of ReporteArticulosMasVendidosDetalle)

                For Each i As DataGridViewRow In DataGridViewX1.Rows

                    item = New ReporteArticulosMasVendidosDetalle
                    item.Cod_Articulo = i.Cells(0).Value
                    item.CantidadVentas = i.Cells(4).Value
                    'item.Marca1 = i.Cells(2).Value
                    'item.SubUnidad = i.Cells(3).Value
                    'item.PrecioInicial = i.Cells(4).Value
                    'item.PrecioFinal = i.Cells(5).Value
                    'item.CantidadPrecios = i.Cells(6).Value
                    'item.PorcentajeAumento = Replace(i.Cells(7).Value, "%", "")
                    'item.Fecha_Desde = i.Cells(8).Value
                    'item.Fecha_Hasta = i.Cells(9).Value
                    listaDetalle.Add(item)

                Next

                'reporteDao.ImprimirReportePreciosDAO(ReporteCabecera, listaDetalle)

                GestorReporte.ValidarReporteArticulosMasVendidos(ReporteCabecera, listaDetalle, Principal.CulturaGlobal)

                If MsgBox(msg2, MsgBoxStyle.YesNo, "ATENCIÓN") = MsgBoxResult.Yes Then
                    ReporteCabecera.Cod_Reporte = reporteDao.ObtenerCodUltimoReporteArticulos()
                    'GestorReporte.ImprimirReportePrecios(ReporteCabecera, listaDetalle)
                End If

                Me.Close()

            End If

        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
End Class