﻿Imports DAL

Public Class ReporteArticulosç
    Private Sub ReporteArticulosç_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim reporteDao = New ReporteDAO
            DataGridViewX1.AllowUserToAddRows = False
            DataGridViewX1.DataSource = reporteDao.ObtenerReportesArticulos
            Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
            DataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



        Catch ex As Exception

        End Try
    End Sub
End Class