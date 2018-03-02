Imports DAL

Public Class NotaCreditoForm
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Try
            Dim codCliente As Long = NuevaVentaForm._CodigoCliente
            Dim codClienteNota As Long = DataGridView1.CurrentRow.Cells(1).Value
            NuevaVentaForm._CodNotaCredito = DataGridView1.CurrentRow.Cells(0).Value
            NuevaVentaForm._TotalCredito = DataGridView1.CurrentRow.Cells("Credito").Value
            NuevaVentaForm.TraerNotaCredito(NuevaVentaForm._TotalCredito, NuevaVentaForm._CodNotaCredito, codCliente, codClienteNota)

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub NotaCreditoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ventaDao = New VentaDAO

            DataGridView1.DataSource = ventaDao.ObtenerNotasDeCredito
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class