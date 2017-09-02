Imports DAL
Imports BLL
Imports BIZ

Public Class VentasForm

    Public Shared _CodigoVenta As Long

    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico

        RazonSocialRadioButton.Checked = True



        Dim _VentaDAO As New VentaDAO

        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir


        VentasDataGridView.DataSource = _VentaDAO.ObtenerVentas


        VentasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        RazonSocialRadioButton.Checked = True

        For Each row As DataGridViewRow In VentasDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next



    End Sub

    Private Sub VerDetalleButton_Click(sender As Object, e As EventArgs) Handles VerDetalleButton.Click

        If VentasDataGridView.CurrentRow IsNot Nothing Then

            _CodigoVenta = (VentasDataGridView.CurrentRow.Cells(0).Value)

            VentDetalle.Show()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles VentasLabel.Click

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click

    End Sub
End Class