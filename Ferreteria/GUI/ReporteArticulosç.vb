Imports DAL

Public Class ReporteArticulosç
    Private Sub ReporteArticulosç_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.ico


            Dim reporteDao = New ReporteDAO
            DataGridViewX1.AllowUserToAddRows = False
            DataGridViewX1.DataSource = reporteDao.ObtenerReportesArticulos
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.ColumnHeaderMouseClick

    End Sub
End Class