Imports SL
Public Class Idioma
    Public IdiomaSeleccionado

    Private Sub Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LogIn.Hide()
        LogIn.TextBox1.Text = ""
        LogIn.TextBox2.Text = ""


        ComboBox1.Items.Add("ESPAÑOL")
        ComboBox1.Items.Add("ENGLISH")
        ComboBox1.Items.Add("PORTUGUES")


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try


            Dim Verificar As New SL.Verificar

            Verificar.VerificarIntegridad()

            MsgBox("Se ha verificado correctamente la integridad", MsgBoxStyle.Information, "INFORMACION")

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


        If ComboBox1.SelectedItem = "PORTUGUES" Then
            Principal.CulturaGlobal = "PORTUGUES"
            Principal.Show()
            Me.Hide()
        End If



    End Sub
End Class