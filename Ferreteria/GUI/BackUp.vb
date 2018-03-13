Imports SL

Public Class BackUp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BackUp As New SL.BackUp
        Dim msg As String = ""
        Try
            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    msg = "Se generó BackUp"
                Case "ENGLISH"
                    msg = "BackUp generated"
            End Select


            BackUp.BackUp()
            MsgBox(msg, MsgBoxStyle.Information, "INFO")
            Me.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub BackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
    End Sub
End Class