Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient
Imports DAL

Public Class BackUp
    Inherits DatosBase


    Public Sub BackUp()


        Try
            Dim NombreRespaldo As String

            NombreRespaldo = "BACKUP_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".bak"

            Me.Conexion.Close()

            Me.Conexion.Open()

            Dim v_ruta_destino As String = "C:\Users\Gonzalo\Desktop\Diploma t\BackUp\"

            Dim cmd As New SqlCommand("BACKUP DATABASE Ferreteria TO DISK = '" & v_ruta_destino & NombreRespaldo & "'", Me.Conexion)


            cmd.ExecuteNonQuery()



        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally
            Conexion.Close()

        End Try







    End Sub

End Class
