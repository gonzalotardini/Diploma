Imports SL
Public Class Integridad

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Verificar As New Verificar


        Try
            Verificar.RealizarIntegridad()
            MsgBox("Integridad de Base De Datos Actualizada con exito", MsgBoxStyle.Information, "INFORMACION")

            Dim el As New EventLogger

            el.WriteToErrorLog("Se actualizo correctamente la integridad", "Integridad Form", "Información")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Dim el As New ErrorLogger
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Verificar As New Verificar


        Try
            Verificar.VerificarIntegridad()
            MsgBox("Integridad de Base De Datos correcta", MsgBoxStyle.Information, "INFORMACION")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Dim el As New ErrorLogger
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try

    End Sub
End Class