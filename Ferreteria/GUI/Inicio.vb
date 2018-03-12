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

            Dim Server As String = String.Empty
            Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
            Dim table As System.Data.DataTable = instance.GetDataSources()

            For Each row As System.Data.DataRow In table.Rows
                Server = String.Empty
                Server = row("ServerName")
                If row("InstanceName").ToString.Length > 0 Then
                    Server = Server & "\" & row("InstanceName")
                End If
                ComboBox1.Items.Add(Server)
            Next

            ComboBox1.SelectedIndex = ComboBox1.FindStringExact(Environment.MachineName)

        End If







        'DataGridView1.DataSource = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServers()


    End Sub

    Public Function Instancias() As DataTable
        Dim enume As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
        Return enume
    End Function

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Try

            Dim ArticuloDao As New ArticuloDAO

            Dim file As String = (Application.StartupPath & "\Correr.bat")
            Dim file2 As String = (Application.StartupPath & "\CorrerUai.bat")
            Dim sr As System.IO.StreamReader = Nothing




            If ComboBox1.SelectedItem = "GONZALO-PC" Then
                Process.Start(file)
            Else
                Process.Start(file2)
            End If


            MsgBox("Base de datos creada correctamente/ DataBase created successfully", MsgBoxStyle.Information)

            Dim config2 As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config2.ConnectionStrings.ConnectionStrings("Conexion").ConnectionString = "Data Source=" & ComboBox1.SelectedItem & ";Initial Catalog=Ferreteria;Integrated Security=True"
            config2.Save(ConfigurationSaveMode.Modified, True)
            ConfigurationManager.RefreshSection("connectionStrings")

            Dim config3 = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config3.AppSettings.Settings("inicio").Value = "1"
            config3.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")


            LogIn.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class