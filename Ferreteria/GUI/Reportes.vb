Public Class Reportes
    Private Sub ButtonReportePrecios_Click(sender As Object, e As EventArgs) Handles ButtonReportePrecios.Click
        ReportePrecios.Show()
    End Sub

    Private Sub ButtonReporteArticulos_Click(sender As Object, e As EventArgs) Handles ButtonReporteArticulos.Click
        ReporteArticulosç.Show()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
    End Sub
End Class