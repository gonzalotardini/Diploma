Imports System.IO.StreamReader
Public Class ErroresForm



    Private Sub ErroresForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico

        Dim lector As New System.IO.StreamReader(Application.StartupPath & "\Errors\errlog.txt", _
                    System.Text.Encoding.Default, _
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




    End Sub







End Class