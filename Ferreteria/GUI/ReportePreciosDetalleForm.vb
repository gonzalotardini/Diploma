Imports BLL
Imports BIZ
Public Class ReportePreciosDetalleForm
    Private Sub ReportePreciosDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
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

        End Try


    End Sub
End Class