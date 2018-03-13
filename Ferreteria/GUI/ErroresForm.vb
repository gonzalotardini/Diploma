Imports System.IO.StreamReader
Public Class ErroresForm



    Private Sub ErroresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico


        Try
            Dim lector As New System.IO.StreamReader(Application.StartupPath & "\Errors\errlog.txt",
                   System.Text.Encoding.Default,
                   True)

            ' Leer el contenido mientras no se llegue al final
            While lector.Peek() <> -1
                ' Leer una linea del fichero
                Dim s As String = lector.ReadLine()
                ' Si no esta vacia, incluirla al control
                ' Si esta vacia, continuar el bucle
                If String.IsNullOrEmpty(s) Then
                    Continue While
                End If

                ListBox1.Items.Add(s)
            End While
            ' Cerrar el fichero
            lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try






    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            For x As Integer = 0 To ListBox1.Items.Count - 1

                Dim palabra = (ListBox1.Items(x).ToString).ToUpper
                If palabra.Contains((TextBoxX1.Text).ToUpper) Then
                    ListBox1.SelectedIndex = x
                    Return
                End If

            Next

            Select Case Principal.CulturaGlobal
                Case "ESPAÑOL"
                    MsgBox("No se encontro nada", MsgBoxStyle.Information, "ATENTION")
                Case "ENGLISH"
                    MsgBox("Nothing was found", MsgBoxStyle.Information, "ATENTION")
            End Select


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class