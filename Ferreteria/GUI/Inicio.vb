Imports System.Configuration
Imports System.Data.Sql
Imports System.IO
Imports DAL

Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim test = ConfigurationManager.AppSettings("inicio").ToString()
        If test = 1 Then
            Me.ShowInTaskbar = False
            Me.Visible = False
            LogIn.Show()
        Else
            Dim i1 As String = Instancias(0).Item(0)
            'Dim i2 As String = Instancias(0).Item(1)
            ComboBox1.Items.Add(i1 & "\SQL_UAI")
        End If

        'DataGridView1.DataSource = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServers()


    End Sub

    Public Function Instancias() As DataTable
        Dim enume As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
        Return enume
    End Function

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Try
            Dim d As New DirectoryInfo(Application.StartupPath & "\DB.sql")
            Dim ArticuloDao As New ArticuloDAO


            'Dim script As String = file.OpenText().ReadToEnd();


            Dim file As String = (Application.StartupPath & "\DB.sql")
            Dim sr As System.IO.StreamReader = Nothing


            sr = New System.IO.StreamReader(file)
            Dim script As String = sr.ReadToEnd() ' con este metodo leeriamos todo el fichero y cargar en el string

            'ArticuloDao.CrearBaseDatos(script)
            MsgBox(script)

            sr.Close()
            sr.Dispose()

            'Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            'config.AppSettings.Settings("inicio").Value = "1"
            'config.Save(ConfigurationSaveMode.Modified)
            'ConfigurationManager.RefreshSection("appSettings")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class