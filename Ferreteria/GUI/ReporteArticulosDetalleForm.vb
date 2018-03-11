Imports BIZ
Imports BLL
Imports SL

Public Class ReporteArticulosDetalleForm
    Private Sub ReporteArticulosDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma
                CodLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
                DesdeLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESDE" Select V.Value).FirstOrDefault
                HastaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "HASTA" Select V.Value).FirstOrDefault
                UsuarioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
                ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault

            End If


            If Principal.CulturaGlobal = "ENGLISH" Then

                ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")


                Dim Cultura = "ENG-ENGLAND"
                'LINQ para el multiidioma
                CodLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
                DesdeLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESDE" Select V.Value).FirstOrDefault
                HastaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "HASTA" Select V.Value).FirstOrDefault
                UsuarioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
                ImprimirButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "IMPRIMIR" Select V.Value).FirstOrDefault

            End If


            Dim reporteBll = New GestorReporte
            Dim reporteCabecera = New ReporteArticulosCabecera
            Dim reporteArticuloDetalle = New ReporteArticulosMasVendidosDetalle


            DataGridView1.AllowUserToAddRows = False
            Me.Icon = My.Resources.ico

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

            reporteCabecera = reporteBll.ObtenerReporteArticulosCabecera(ReporteArticulosç._CodReporteArticulos)

            LabelX4.Text = reporteCabecera.Cod_Reporte
            FechaDesde.Text = reporteCabecera.FechaInicio
            FechaHasta.Text = reporteCabecera.FechaFin
            LabelX6.Text = reporteCabecera.Usuario


            DataGridView1.DataSource = reporteBll.ObtenerReporteArticulosDetalle(ReporteArticulosç._CodReporteArticulos)

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try

    End Sub
End Class