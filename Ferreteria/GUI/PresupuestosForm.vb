Imports DAL
Imports BLL
Imports BIZ
Imports SL


Public Class PresupuestosForm
    Public Shared _CodigoPresupuesto As Long
    
    Private Sub PresupuestosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico


        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma

        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma

            CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
            PresupuestoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRESUPUESTOS" Select V.Value).FirstOrDefault
        End If


        If Principal.CulturaGlobal = "ENGLISH" Then


            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)
            CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
            PresupuestoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRESUPUESTOS" Select V.Value).FirstOrDefault

        End If



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

    Private Sub PresupuestosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PresupuestosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PresupuestosDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        For Each row As DataGridViewRow In PresupuestosDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles VerButton.Click
        If PresupuestosDataGridView.CurrentRow IsNot Nothing Then

            _CodigoPresupuesto = (PresupuestosDataGridView.CurrentRow.Cells(0).Value)

            PresupuestoDetalleForm.Show()

        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
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
                MsgBox(msg, MsgBoxStyle.Information, "ATENTION")

            End If

            PresupuestosDataGridView.AllowUserToAddRows = False
            PresupuestosDataGridView.EditMode = False

            PresupuestosDataGridView.DataSource = presupuestoDAO.ObtenerPresupuestos

            For Each row As DataGridViewRow In PresupuestosDataGridView.Rows

                If row.Index Mod 2 <> 0 Then
                    row.DefaultCellStyle.BackColor = Color.Bisque
                Else
                    row.DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next

        Catch ex As Exception
            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class