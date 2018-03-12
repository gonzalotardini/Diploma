Imports SL
Imports BLL
Imports System.Configuration

Public Class LogIn
    Public ListaPatentes As New List(Of Patente)
    Public Usuario As New Usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Label1.ForeColor = Color.DodgerBlue
        Label2.ForeColor = Color.DodgerBlue

        Me.Icon = My.Resources.ico
        TextBox2.PasswordChar = "*"

        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _Usuario As New Usuario
        Dim UsuarioBLL As New GestorUsuario
        Dim Simple3DES As New Simple3Des

        _Usuario.NombreUsuario = (TextBox1.Text).ToUpper
        Usuario.NombreUsuario = (TextBox1.Text).ToUpper



        _Usuario.PW = Simple3DES.EncryptData(TextBox2.Text)





        Try
            If UsuarioBLL.TraerUsuarioBLL(_Usuario) = True Then

                ListaPatentes = UsuarioBLL.ObtenerPatentesDeUsuario(_Usuario)

                Dim el As New EventLogger

                el.WriteToErrorLog("El usuario: " & _Usuario.NombreUsuario & " ha accedido correctamente al sistema", "LogIn Form", "Información")

                Idioma.Show()
                Me.Hide()
            Else
                Throw New Exception("USUARIO O CONTRASEÑA INCORRECTO")
            End If


        Catch ex As Exception



            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try


    End Sub

    Private Sub LogIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Inicio.Close()
    End Sub
End Class