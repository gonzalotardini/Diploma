Imports SL

Public Class BackUp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BackUp As New SL.BackUp

        Try

            BackUp.BackUp()
            MsgBox("Se genero backup", MsgBoxStyle.Information, "INFORMACION")
            Me.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class