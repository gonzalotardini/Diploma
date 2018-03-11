Imports BLL
Imports BIZ
Imports SL
Imports DAL

Public Class ReportePreciosDetalleForm
    Private Sub ReportePreciosDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try


            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma
                CodLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
                FechaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FECHA" Select V.Value).FirstOrDefault
                UsuarioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
                ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault

            End If


            If Principal.CulturaGlobal = "ENGLISH" Then

                ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")


                Dim Cultura = "ENG-ENGLAND"
                'LINQ para el multiidioma
                CodLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
                FechaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "FECHA" Select V.Value).FirstOrDefault
                UsuarioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
                ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault

            End If


            Dim reporteBll = New GestorReporte
            Dim reportePreciosCabecera = New Reporte
            Dim reportePreciosDetalle = New ReportePreciosDetalle


            DataGridView1.AllowUserToAddRows = False
            Me.Icon = My.Resources.ico

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

            reportePreciosCabecera = reporteBll.ObtenerReportePreciosCabeceraBll(ReportePrecios._CodReportePrecios)

            LabelX4.Text = reportePreciosCabecera.Cod_Reporte
            LabelX5.Text = reportePreciosCabecera.Fecha
            LabelX6.Text = reportePreciosCabecera.Usuario


            DataGridView1.DataSource = reporteBll.ObtenerReportePreciosDetalleBll(ReportePrecios._CodReportePrecios)

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try


    End Sub

    Private Sub ImprimirButton_Click(sender As Object, e As EventArgs) Handles ImprimirButton.Click
        Dim listaDetalle As List(Of ReportePreciosDetalle)
        Dim item As ReportePreciosDetalle
        Dim GestorReporte As New GestorReporte
        Dim ReporteCabecera As New Reporte

        Dim msg2 = ""
        Dim reporteDao = New ReporteDAO

        Select Case Principal.CulturaGlobal
            Case "ESPAÑOL"

                msg2 = "¿Desea imprimir el reporte?"
            Case "ENGLISH"

                msg2 = "Do you want to print the report?"
        End Select

        Try
            If MsgBox(msg2, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then
                'ReporteCabecera.Usuario = LogIn.Usuario.NombreUsuario
                listaDetalle = New List(Of ReportePreciosDetalle)

                For i = 0 To DataGridView1.RowCount - 1

                    item = New ReportePreciosDetalle
                    item.Cod_Articulo = DataGridView1.Rows(i).Cells(0).Value
                    item.Descripcion = DataGridView1.Rows(i).Cells(1).Value
                    item.Marca1 = DataGridView1.Rows(i).Cells(2).Value
                    item.SubUnidad = DataGridView1.Rows(i).Cells(3).Value
                    item.PrecioInicial = DataGridView1.Rows(i).Cells(4).Value
                    item.PrecioFinal = DataGridView1.Rows(i).Cells(5).Value
                    item.CantidadPrecios = DataGridView1.Rows(i).Cells(6).Value
                    item.PorcentajeAumento = Replace(DataGridView1.Rows(i).Cells(7).Value, "%", "")
                    item.Fecha_Desde = DataGridView1.Rows(i).Cells(8).Value
                    item.Fecha_Hasta = DataGridView1.Rows(i).Cells(9).Value
                    listaDetalle.Add(item)

                Next

                'reporteDao.ImprimirReportePreciosDAO(ReporteCabecera, listaDetalle)




                'ReporteCabecera.Cod_Reporte = reporteDao.ObtenerCodUltimoReportePrecios()
                ReporteCabecera.Cod_Reporte = LabelX4.Text
                ReporteCabecera.Tipo = "AUMENTO DE PRECIOS"
                ReporteCabecera.Usuario = LabelX6.Text
                ReporteCabecera.Fecha = LabelX5.Text
                GestorReporte.ImprimirReportePrecios(ReporteCabecera, listaDetalle)




            End If
        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try
    End Sub
End Class