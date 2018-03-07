Imports SL

Public Class Reportes
    Private Sub ButtonReportePrecios_Click(sender As Object, e As EventArgs) Handles ButtonReportePrecios.Click
        ReportePrecios.Show()
    End Sub

    Private Sub ButtonReporteArticulos_Click(sender As Object, e As EventArgs) Handles ButtonReporteArticulos.Click
        ReporteArticulosç.Show()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma


        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma

            Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault
            ButtonReportePrecios.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEPRECIOS" Select V.Value).FirstOrDefault
            ButtonReporteArticulos.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEARTICULOS" Select V.Value).FirstOrDefault
            ButtonReporteVentas.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEVENTAS" Select V.Value).FirstOrDefault

        End If


        If Principal.CulturaGlobal = "ENGLISH" Then


            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault
            ButtonReportePrecios.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEPRECIOS" Select V.Value).FirstOrDefault
            ButtonReporteArticulos.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEARTICULOS" Select V.Value).FirstOrDefault
            ButtonReporteVentas.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTEVENTAS" Select V.Value).FirstOrDefault
        End If


    End Sub
End Class