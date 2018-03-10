Imports DAL

Public Class ReporteArticulosç
    Public Shared _CodReporteArticulos As Long
    Private Sub ReporteArticulosç_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.ico


            Dim reporteDao = New ReporteDAO
            DataGridViewX1.AllowUserToAddRows = False
            DataGridViewX1.DataSource = reporteDao.ObtenerReportesArticulos
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma

                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                ButtonX1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                ButtonX2.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESPRECIOS" Select V.Value).FirstOrDefault
            End If


            If Principal.CulturaGlobal = "ENGLISH" Then

                ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")
                Dim Cultura = "ENG-ENGLAND"
                'ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)
                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                ButtonX1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                ButtonX2.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESPRECIOS" Select V.Value).FirstOrDefault

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.ColumnHeaderMouseClick

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If DataGridViewX1.CurrentRow IsNot Nothing Then

            _CodReporteArticulos = (DataGridViewX1.CurrentRow.Cells(0).Value)

            ReportePreciosDetalleForm.Show()

        End If
    End Sub
End Class