Imports DAL
Imports BLL
Imports BIZ
Imports SL

Public Class VentasForm

    Public Shared _CodigoVenta As Long

    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico

        RazonSocialRadioButton.Checked = True



        VentasDataGridView.AllowUserToAddRows = False

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

    Private Sub VerDetalleButton_Click(sender As Object, e As EventArgs)

        If VentasDataGridView.CurrentRow IsNot Nothing Then

            _CodigoVenta = (VentasDataGridView.CurrentRow.Cells(0).Value)

            VentDetalle.Show()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles VentasLabel.Click

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Try
            Dim ventaBll = New GestorVenta
            Dim ventaDao = New VentaDAO
            Dim cod As Long
            Dim msg As String = ""
            cod = VentasDataGridView.CurrentRow.Cells(0).Value
            Dim pregunta As String = ""

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    pregunta = "¿Seguro desea cancelar la venta?"

                Case "ENGLISH"
                    pregunta = "Do you realle want to cancel the sell?"

            End Select



            If MsgBox(pregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then
                ventaBll.CancelarVentaBll(cod)
                VentasDataGridView.DataSource = ventaDao.ObtenerVentas

                For Each row As DataGridViewRow In VentasDataGridView.Rows

                    If row.Index Mod 2 <> 0 Then
                        row.DefaultCellStyle.BackColor = Color.Bisque
                    Else
                        row.DefaultCellStyle.BackColor = Color.Aqua

                    End If

                Next
                Select Case Principal.CulturaGlobal
                    Case "ESPAÑOL"
                        msg = "La venta fue correctamente cancelada y se generó la nota de crédito"
                    Case "ENGLISH"
                        msg = "The sell was correctly cancelled and credit note was created"
                End Select


                MsgBox(msg, MsgBoxStyle.Information, "ATENTION")

            End If





        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VerDetalleButton_Click_1(sender As Object, e As EventArgs) Handles VerDetalleButton.Click
        If VentasDataGridView.CurrentRow IsNot Nothing Then

            _CodigoVenta = (VentasDataGridView.CurrentRow.Cells(0).Value)

            VentDetalle.Show()

        End If
    End Sub

    Private Sub VentasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasDataGridView.CellContentClick

    End Sub

    Private Sub VentasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VentasDataGridView.CellClick

    End Sub

    Private Sub VentasDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles VentasDataGridView.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In VentasDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub
End Class