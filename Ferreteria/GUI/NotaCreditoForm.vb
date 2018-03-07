Imports BLL
Imports DAL
Imports SL

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
            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)
            RazonSocialRadioButton.Checked = True

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma

                NotasCreditoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NOTASCREDITO" Select V.Value).FirstOrDefault
                CodigoNotaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGONOTA" Select V.Value).FirstOrDefault
                RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault

            End If


            If Principal.CulturaGlobal = "ENGLISH" Then


                Dim Cultura = "ENG-ENGLAND"
                ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

                NotasCreditoLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NOTASCREDITO" Select V.Value).FirstOrDefault
                CodigoNotaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGONOTA" Select V.Value).FirstOrDefault
                RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault

            End If



            Dim ventaDao = New VentaDAO
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            DataGridView1.DataSource = ventaDao.ObtenerNotasDeCredito
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.Index Mod 2 <> 0 Then
                    row.DefaultCellStyle.BackColor = Color.Bisque
                Else
                    row.DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Dim _GestorPresupuesto As New GestorPresupuesto
        Dim _cod As Long
        Dim ventaDao As New VentaDAO
        Dim _razonSocial As String

        Try



            If CodigoNotaRadioButton.Checked = True Then

                Select Case e.KeyData
                    Case Keys.Enter

                        Dim EsNumero As Boolean

                        EsNumero = IsNumeric(TextBox1.Text)

                        If EsNumero = True Then

                            _cod = Convert.ToInt64(TextBox1.Text)

                            DataGridView1.DataSource = ventaDao.BuscarNotaDeCreditoPorCOD(_cod)
                            DataGridView1.AllowUserToAddRows = False

                        Else

                            Select Case Principal.CulturaGlobal
                                Case "ESPAÑOL"
                                    Throw New Exception("Error, el código debe ser numérico")
                                Case "ENGLISH"
                                    Throw New Exception("Error,  code must be numeric")
                            End Select

                        End If




                End Select

            Else

                If RazonSocialRadioButton.Checked = True Then
                    Select Case e.KeyData




                        Case Keys.Enter

                            If TextBox1.Text = "" Then
                                _razonSocial = (TextBox1.Text).ToUpper
                                DataGridView1.DataSource = ventaDao.BuscarNotaDeCreditoPorRazonSocial(_razonSocial)
                                DataGridView1.AllowUserToAddRows = False

                            Else
                                _razonSocial = (TextBox1.Text).ToUpper
                                DataGridView1.[DataSource] = ventaDao.BuscarNotaDeCreditoPorRazonSocial(_razonSocial)
                                 DataGridView1.AllowUserToAddRows=False


                            End If




                    End Select

                End If


            End If



        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try






        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

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
End Class