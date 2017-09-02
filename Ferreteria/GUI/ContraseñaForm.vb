Imports SL
Public Class ContraseñaForm

    Private Sub ContraseñaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.ico
        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma



        If Principal.CulturaGlobal = "ESPAÑOL" Then

            Dim Cultura = "ES-ESP"

            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")

            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑA" Select V.Value).FirstOrDefault
            LabelCambiarContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CAMBIARCONTRASEÑA" Select V.Value).FirstOrDefault
            LabelContraseñaAnterior.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑAANTERIOR" Select V.Value).FirstOrDefault
            LabelNuevaContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVACONTRASEÑA" Select V.Value).FirstOrDefault
            LabelRepitaNuevaContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPITANUEVACONTRASEÑA" Select V.Value).FirstOrDefault
            AceptarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ACEPTAR" Select V.Value).FirstOrDefault

        End If

        If Principal.CulturaGlobal = "ENGLISH" Then

            Dim Cultura = "ENG-ENGLAND"

            ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")

            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑA" Select V.Value).FirstOrDefault
            LabelCambiarContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CAMBIARCONTRASEÑA" Select V.Value).FirstOrDefault
            LabelNuevaContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVACONTRASEÑA" Select V.Value).FirstOrDefault
            LabelContraseñaAnterior.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑAANTERIOR" Select V.Value).FirstOrDefault
            LabelRepitaNuevaContraseña.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPITANUEVACONTRASEÑA" Select V.Value).FirstOrDefault
            AceptarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ACEPTAR" Select V.Value).FirstOrDefault

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        Dim _UsuarioDAO As New UsuarioDAO
        Dim _Usuario As New Usuario
        Dim _Criptografia As New Simple3Des

        Dim ContraseñaIngresada As String
        Dim ContraseñaNueva As String
        Dim ContraseñaNuevaDuplicada As String
        Dim _UsuarioAutentico As New Usuario

        Try



            _Usuario.NombreUsuario = LogIn.Usuario.NombreUsuario


            Me.Text = "HOLA"

            ContraseñaIngresada = (TextBoxContraseñaIngresada.Text).ToUpper
            ContraseñaNueva = (TextBoxNuevaContraseña.Text).ToUpper
            ContraseñaNuevaDuplicada = (TextBoxNuevaContraseñaDuplicado.Text).ToUpper

            _UsuarioAutentico = _UsuarioDAO.ObtenerUsuario(_Usuario)
            _UsuarioAutentico.PW = _Criptografia.DecryptData(_UsuarioAutentico.PW)


            If ContraseñaIngresada = _UsuarioAutentico.PW And ContraseñaNueva = ContraseñaNuevaDuplicada Then

                ContraseñaNueva = _Criptografia.EncryptData(ContraseñaNueva)

                _UsuarioAutentico.PW = ContraseñaNueva


                _UsuarioDAO.ActualizarContraseña(_UsuarioAutentico)

                Dim el As New EventLogger

                el.WriteToErrorLog("Se modificó la contraseña del usuario" & _UsuarioAutentico.NombreUsuario, "Articulo Form", "Información")

                If Principal.CulturaGlobal = "ES-ESP" Then

                    MsgBox("Se actualizo correctamente la contraseña", vbInformation, "ATENCION")
                Else
                    Principal.CulturaGlobal = "ENG-ENGLAND"

                    MsgBox("Your password was successfully updated", vbInformation, "ATTENTION")

                End If

                Me.Close()

            Else

                If Principal.CulturaGlobal = "ES-ESP" Then

                    Throw New Exception("ERROR: Revise los datos ingresados")
                Else
                    Principal.CulturaGlobal = "ENG-ENGLAND"

                    Throw New Exception("ERROR: Check input data")

                End If




            End If



        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try



    End Sub
End Class