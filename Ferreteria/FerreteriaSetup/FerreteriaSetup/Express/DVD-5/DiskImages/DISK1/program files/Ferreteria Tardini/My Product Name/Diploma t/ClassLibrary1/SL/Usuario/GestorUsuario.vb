﻿Imports BIZ

Public Class GestorUsuario

    Private UsuarioObtenido As Usuario




    Public Function TraerUsuarioBLL(_Usuario As Usuario) As Boolean
        Dim UsuarioDao As New UsuarioDAO

        Try

            UsuarioObtenido = UsuarioDao.ObtenerUsuario(_Usuario)

            If CompararUsuario(UsuarioObtenido, _Usuario) = True Then

                _Usuario.IdUsuario = UsuarioObtenido.IdUsuario
                Return True

            Else
                Return False

            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try







    End Function



    Public Function CompararUsuario(UsuarioObtenido As Usuario, usuario As Usuario) As Boolean

        If usuario.PW = UsuarioObtenido.PW Then

            Return True

        Else
            Return False
        End If





    End Function




    Public Function ObtenerPatentesDeUsuario(Usuario As Usuario) As List(Of Patente)

        Dim UsuarioDao As New UsuarioDAO


        Return UsuarioDao.ObtenerPatentesDeUsuario(Usuario)



    End Function


End Class
