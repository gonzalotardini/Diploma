Imports DAL


Public Class ReportePrecios

    Public Shared _CodReportePrecios As Long
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma

                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                ReportesPreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESPRECIOS" Select V.Value).FirstOrDefault
            End If


            If Principal.CulturaGlobal = "ENGLISH" Then


                Dim Cultura = "ENG-ENGLAND"
                'ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)
                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                VerButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                CancelarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                ReportesPreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESPRECIOS" Select V.Value).FirstOrDefault

            End If


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

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles VerButton.Click
        If DataGridView1.CurrentRow IsNot Nothing Then

            _CodReportePrecios = (DataGridView1.CurrentRow.Cells(0).Value)

            ReportePreciosDetalleForm.Show()

        End If
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click

    End Sub
End Class