Imports DAL
Imports BLL
Imports BIZ
Imports SL


Public Class PresupuestosForm
    Public Shared _CodigoPresupuesto As Long
    
    Private Sub PresupuestosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Dim _PresupuestoDAO As New PresupuestoDAO

        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
        PresupuestosDataGridView.AllowUserToAddRows = False
        PresupuestosDataGridView.EditMode = False

        PresupuestosDataGridView.DataSource = _PresupuestoDAO.ObtenerPresupuestos

        PresupuestosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        RazonSocialRadioButton.Checked = True

        For Each row As DataGridViewRow In PresupuestosDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown


        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _Cliente As New Cliente
        Dim _PresupuestoDAO As New PresupuestoDAO

        Try



            If CodigoClienteRadioButton.Checked = True Then

                Select Case e.KeyData
                    Case Keys.Enter

                        Dim EsNumero As Boolean

                        EsNumero = IsNumeric(TextBox1.Text)

                        If EsNumero = True Then

                            _Cliente.CodigoCliente = Convert.ToInt64(TextBox1.Text)

                            PresupuestosDataGridView.DataSource = _GestorPresupuesto.ValidarBusquedaClientePorCodigoCliente(_Cliente).Tables(0)


                        Else

                            Throw New Exception("Error, código debe ser numérico")

                        End If


                End Select

            Else

                If RazonSocialRadioButton.Checked = True Then
                    Select Case e.KeyData




                        Case Keys.Enter

                            If TextBox1.Text = "" Then

                                PresupuestosDataGridView.DataSource = _PresupuestoDAO.ObtenerPresupuestos()

                            Else
                                _Cliente.RazonSocial = (TextBox1.Text).ToUpper


                                PresupuestosDataGridView.[DataSource] = _GestorPresupuesto.ValidarBusquedaClientePorRazonSocial(_Cliente).Tables(0)


                            End If




                    End Select

                End If


            End If



        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try






        For Each row As DataGridViewRow In PresupuestosDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub VerDetalleButton_Click(sender As Object, e As EventArgs)









    End Sub

    Private Sub PresupuestosDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PresupuestosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestosDataGridView.CellContentClick

    End Sub

    Private Sub PresupuestosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PresupuestosDataGridView.CellClick

    End Sub

    Private Sub PresupuestosDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PresupuestosDataGridView.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In PresupuestosDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If PresupuestosDataGridView.CurrentRow IsNot Nothing Then

            _CodigoPresupuesto = (PresupuestosDataGridView.CurrentRow.Cells(0).Value)

            PresupuestoDetalleForm.Show()

        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try

            Dim pregunta As String = ""
            Dim msg As String = ""
            Dim presupuestoDAO As New PresupuestoDAO

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    pregunta = "¿Seguro desea eliminar el presupuesto?"
                    msg = "Se eliminó correctamente el presupuesto"

                Case "ENGLISH"
                    pregunta = "Do you really want to delete the budget?"
                    msg = "The budget was correctly deleted"

            End Select

            If MsgBox(pregunta, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then
                Dim presupuestoBll = New GestorPresupuesto
                Dim cod As Long = PresupuestosDataGridView.CurrentRow.Cells(0).Value
                presupuestoBll.EliminarPresupuestoBll(cod)
            End If

            PresupuestosDataGridView.AllowUserToAddRows = False
            PresupuestosDataGridView.EditMode = False

            PresupuestosDataGridView.DataSource = presupuestoDAO.ObtenerPresupuestos

            MsgBox(msg, MsgBoxStyle.Information, "ATENTION")

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
End Class