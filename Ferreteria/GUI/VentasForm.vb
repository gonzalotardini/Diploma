Imports DAL
Imports BLL
Imports BIZ
Imports SL

Public Class VentasForm

    Public Shared _CodigoVenta As Long

    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico

        RazonSocialRadioButton.Checked = True

        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma

        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma

            CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANCELAR" Select V.Value).FirstOrDefault
            VentasLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "VENTAS" Select V.Value).FirstOrDefault
        End If


        If Principal.CulturaGlobal = "ENGLISH" Then


            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)
            CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
            RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
            VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
            CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANCELAR" Select V.Value).FirstOrDefault
            VentasLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "VENTAS" Select V.Value).FirstOrDefault

        End If


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

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VerDetalleButton_Click_1(sender As Object, e As EventArgs) Handles VerButton.Click
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim _GestorVenta As New GestorVenta
        Dim _VentaDao As New VentaDAO
        Dim _Cliente As New Cliente


        Try



            If CodigoClienteRadioButton.Checked = True Then



                Select Case e.KeyData
                    Case Keys.Enter

                        Dim EsNumero As Boolean

                        EsNumero = IsNumeric(TextBox1.Text)

                        If EsNumero = True Then

                            _Cliente.CodigoCliente = Convert.ToInt64(TextBox1.Text)
                            VentasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            VentasDataGridView.DataSource = _GestorVenta.ValidarBusquedaVentaPorCodigoCliente(_Cliente, Principal.CulturaGlobal).Tables(0)


                        Else

                            Select Case Principal.CulturaGlobal
                                Case "ESPAÑOL"
                                    Throw New Exception("Error, el código de cliente debe ser numérico")
                                Case "ENGLISH"
                                    Throw New Exception("Error, client code must be numeric")
                            End Select

                        End If


                End Select

            Else

                If RazonSocialRadioButton.Checked = True Then
                    Select Case e.KeyData

                        Case Keys.Enter

                            If TextBox1.Text = "" Then

                                VentasDataGridView.DataSource = _VentaDao.ObtenerVentas


                            Else
                                _Cliente.RazonSocial = (TextBox1.Text).ToUpper


                                VentasDataGridView.[DataSource] = _GestorVenta.BuscarVentaPorRazonSocialBll(_Cliente)


                            End If




                    End Select

                End If


            End If



        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try



        For Each row As DataGridViewRow In VentasDataGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
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
                    pregunta = "Do you realle want to cancel the sale?"

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
End Class