Imports DAL
Public Class ReportePrecios
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            Dim reportesDal = New ReporteDAO
            DataGridViewX1.DataSource = reportesDal.ObtenerReportes

            For Each row As DataGridViewRow In DataGridViewX1.Rows

                If row.Index Mod 2 <> 0 Then
                    row.DefaultCellStyle.BackColor = Color.Bisque
                Else
                    row.DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next

            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try
    End Sub
End Class