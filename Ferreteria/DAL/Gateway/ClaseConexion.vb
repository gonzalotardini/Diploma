Imports System.Configuration
Imports System.Data.SqlClient



Public Class ClaseConexion
    Private _CadenaConexion As SqlConnection
    Private Shared _ObjetoConexion As ClaseConexion = Nothing




    Public Sub New()

        Try


            '_CadenaConexion = New SqlConnection("Data Source=.\SQL_UAI;Initial Catalog=Ferreteria;Integrated Security=True")
            '  _CadenaConexion = New SqlConnection("Data Source=Gonzalo-PC;Initial Catalog=Ferreteria;Integrated Security=True")
            _CadenaConexion = New SqlConnection("Data Source=ACBYEMRTRL\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True")
            '_CadenaConexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ToString)

        Catch ex As Exception

            Throw New Exception("Error al conectar con la base de datos")

        End Try




    End Sub



    Public ReadOnly Property CadenaConexion As SqlConnection
        Get
            Return _CadenaConexion
        End Get
    End Property

    Public Shared Function InstanciarObjetoConexion() As ClaseConexion

        If _ObjetoConexion Is Nothing Then
            _ObjetoConexion = New ClaseConexion

        End If

        Return _ObjetoConexion

    End Function


End Class
