Imports DAL
Imports SL

Public Class ReporteArticulosç
    Public Shared _CodReporteArticulos As Long
    Private Sub ReporteArticulosç_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Icon = My.Resources.ico


            Dim reporteDao = New ReporteDAO
            DataGridViewX1.AllowUserToAddRows = False
            DataGridViewX1.DataSource = reporteDao.ObtenerReportesArticulos
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


            Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

            Dim Multiidioma As New SL.Multiidioma

            If Principal.CulturaGlobal = "ESPAÑOL" Then
                ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


                Dim Cultura = "ES-ESP"
                'LINQ para el multiidioma

                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                ButtonX2.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                ButtonX1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESARTICULOS" Select V.Value).FirstOrDefault
            End If


            If Principal.CulturaGlobal = "ENGLISH" Then

                ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")
                Dim Cultura = "ENG-ENGLAND"
                'ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)
                'CodigoClienteRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGOCLIENTE" Select V.Value).FirstOrDefault
                'RazonSocialRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "RAZONSOCIAL" Select V.Value).FirstOrDefault
                ButtonX2.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DETALLE" Select V.Value).FirstOrDefault
                ButtonX1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ELIMINAR" Select V.Value).FirstOrDefault
                Label1.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTESARTICULOS" Select V.Value).FirstOrDefault

            End If


            For Each row As DataGridViewRow In DataGridViewX1.Rows

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

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub DataGridViewX1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewX1.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In DataGridViewX1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If DataGridViewX1.CurrentRow IsNot Nothing Then

            _CodReporteArticulos = (DataGridViewX1.CurrentRow.Cells(0).Value)

            ReporteArticulosDetalleForm.Show()

        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Dim msg As String = ""
            Dim msg2 As String = ""
            Dim cod As Integer = (DataGridViewX1.CurrentRow.Cells(0).Value)

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
                reporteDao.EliminarReporteArticulos(cod)
                MsgBox(msg2, MsgBoxStyle.Information, "INFO")
                DataGridViewX1.DataSource = reporteDao.ObtenerReportesArticulos
            End If

            For Each row As DataGridViewRow In DataGridViewX1.Rows

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

    Private Sub DataGridViewX1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
End Class