Imports DAL


Public Class ReportePrecios

    Public Shared _CodReportePrecios As Long
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.ico
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            Dim reportesDal = New ReporteDAO
            DataGridView1.DataSource = reportesDal.ObtenerReportes
            DataGridView1.AllowUserToAddRows = False

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.Index Mod 2 <> 0 Then
                    row.DefaultCellStyle.BackColor = Color.Bisque
                Else
                    row.DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If DataGridView1.CurrentRow IsNot Nothing Then

            _CodReportePrecios = (DataGridView1.CurrentRow.Cells(0).Value)

            ReportePreciosDetalleForm.Show()

        End If
    End Sub
End Class