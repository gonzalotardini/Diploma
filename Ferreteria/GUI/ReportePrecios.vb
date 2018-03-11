Imports DAL
Imports SL

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

                ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")
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
        Try
            Dim msg As String = ""
            Dim msg2 As String = ""
            Dim cod As Integer = (DataGridView1.CurrentRow.Cells(0).Value)

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    msg = "¿Seguro desea eliminar el reporte?"
                    msg2 = "Reporte eliminado correctamente"
                Case "ENGLISH"
                    msg = "Do you really want to delete the report?"
                    msg2 = "The report was correctly deleted"
            End Select


            If MsgBox(msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ATENCIÓN") = MsgBoxResult.Yes Then
                Dim reporteDao = New ReporteDAO
                reporteDao.EliminarReportePrecios(cod)
                MsgBox(msg2, MsgBoxStyle.Information, "INFO")
                DataGridView1.DataSource = reporteDao.ObtenerReportes
            End If

            For Each row As DataGridViewRow In DataGridView1.Rows

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
End Class