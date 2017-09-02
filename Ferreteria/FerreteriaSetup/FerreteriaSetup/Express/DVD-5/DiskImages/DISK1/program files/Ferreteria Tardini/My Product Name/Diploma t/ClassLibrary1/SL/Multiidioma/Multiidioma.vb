Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient
Imports DAL

Public Class Multiidioma

    Inherits DatosBase


    Public Function ObtenerPalabras(Cultura As String) As List(Of PalabrasIdioma)

        Dim _Consulta As String
        Dim _Comando As SqlCommand
        Dim _DataSet As New DataSet

        Dim Resultado As New List(Of PalabrasIdioma)



        Try

            Me.Conexion.Open()

            _Consulta = "select * from Idioma where Cultura='" & Cultura & "'"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)


            Resultado = CrearListaDeIdioma(_DataSet.Tables(0))


            Return Resultado


        Catch ex As Exception

            Throw New Exception("Error " & ex.Message)

        Finally
            Me.Conexion.Close()

        End Try


        













    End Function





    Public Function CrearListaDeIdioma(DataTable As DataTable) As List(Of PalabrasIdioma)

        Dim Idioma As New PalabrasIdioma
        Dim ListaIdioma As New List(Of PalabrasIdioma)


        For Each fila As DataRow In DataTable.Rows
            Idioma = New PalabrasIdioma




            Idioma.Key = fila.Item("Key")
            Idioma.Value = fila.Item("Value")
            Idioma.Cultura = fila.Item("Cultura")



            ListaIdioma.Add(Idioma)


        Next

        Return ListaIdioma

    End Function

    Public Function ObtenerValue(key As String, Cultura As String) As String


        '


        Dim _Consulta As String
        Dim _Comando As New SqlCommand
        Dim Dal As New DAL.DatosBase
        Dim palabra As String

        Try

            Dal.Conexion.Open()

            _Consulta = "select Value  from Idioma where [Key]=@Key and Cultura=@cultura "



            _Comando = New SqlCommand(_Consulta, Dal.Conexion)

            _Comando.Parameters.AddWithValue("@key", key)
            _Comando.Parameters.AddWithValue("@Cultura", Cultura)



            palabra = (_Comando.ExecuteScalar).ToString  'ejecuto scalar porque quiero obtener el valor, uso executenonqueri cuando quiero hacer un insert


            Return palabra



        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message)
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
            Return Nothing

        Finally

            Dal.Conexion.Close()

        End Try




    End Function



End Class
