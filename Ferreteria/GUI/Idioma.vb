Imports SL
Public Class Idioma
    Public IdiomaSeleccionado

    Private Sub Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.DodgerBlue

        Me.Icon = My.Resources.ico

        LogIn.Hide()
        LogIn.TextBox1.Text = ""
        LogIn.TextBox2.Text = ""


        ComboBox1.Items.Add("ESPAÑOL")
        ComboBox1.Items.Add("ENGLISH")



    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            IdiomaSeleccionado = ComboBox1.SelectedItem

            Dim Verificar As New SL.Verificar

            Verificar.VerificarIntegridad()


            If IdiomaSeleccionado = "ESPAÑOL" Then

                MsgBox("Se ha verificado correctamente la integridad", MsgBoxStyle.Information, "INFORMACION")

            Else

                MsgBox("Integrity verified successfully", MsgBoxStyle.Information, "INFORMACION")

            End If



        Catch ex As Exception
            Dim el As New ErrorLogger
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Application.Exit()

        End Try



        If ComboBox1.SelectedItem = "ESPAÑOL" Then
            Principal.CulturaGlobal = "ESPAÑOL"
            Principal.Show()
            Me.Hide()
        End If


        If ComboBox1.SelectedItem = "ENGLISH" Then
            Principal.CulturaGlobal = "ENGLISH"
            Principal.Show()
            Me.Hide()
        End If





    End Sub
End Class