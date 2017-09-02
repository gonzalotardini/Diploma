Imports DAL
Imports BIZ
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Verificar
    Inherits DatosBase


    Public Sub RealizarIntegridad()

        Dim _Consulta As String
        Dim _DataSet As New DataSet
        Dim _Comando As SqlCommand

        Try

            _Consulta = "Select * from Marca"




            Me.Conexion.Open()

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)


        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            Me.Conexion.Close()

        End Try




        '-------------Caego concatenacion en base

        Try
            Me.Conexion.Open()



            For Each row As DataRow In _DataSet.Tables(0).Rows



                _Consulta = "Update Marca set CRC=Binary_CheckSum(Cod_Marca,Descripcion) where cod_marca=@cod_marca"

                _Comando = New SqlCommand(_Consulta, Me.Conexion)


                _Comando.Parameters.AddWithValue("@cod_marca", row("Cod_Marca"))

                _Comando.ExecuteNonQuery()

            Next



        Catch ex As Exception

            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()
        End Try

       

        '     Return _DataSet




    End Sub




    Public Sub VerificarIntegridad()

        Dim _Consulta As String
        Dim _DataSet As New DataSet
        Dim _Comando As SqlCommand

        Try
            Me.Conexion.Open()


            _Consulta = "select Binary_CheckSum(Cod_Marca,Descripcion) as 'Concatenacion', CRC from marca"

            _Comando = New SqlCommand(_Consulta, Me.Conexion)

            Dim _Adapter As New SqlDataAdapter(_Comando)

            _Adapter.Fill(_DataSet)



        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            Me.Conexion.Close()

        End Try




        Try
            Me.Conexion.Open()

            Dim Concatenacion As String
            Dim Crc As String

            For Each row As DataRow In _DataSet.Tables(0).Rows


                Concatenacion = row("Concatenacion")
                Crc = row("CRC")


                If Concatenacion = Crc Then
                Else

                    Throw New Exception("Se corrompido la integridad de la BD en la Tabla Marcas")

                End If



            Next



        Catch ex As Exception

            Throw New Exception(ex.Message)
        Finally
            Me.Conexion.Close()
        End Try


    End Sub

End Class
