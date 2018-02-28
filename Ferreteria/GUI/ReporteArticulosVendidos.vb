Imports BLL
Imports SL

Public Class ReporteArticulosVendidos
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

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

        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
        DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub VentasLabel_Click(sender As Object, e As EventArgs) Handles VentasLabel.Click

    End Sub
End Class