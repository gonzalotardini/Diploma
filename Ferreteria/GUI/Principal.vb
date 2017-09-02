Imports System.Linq
Public Class Principal



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub


    Public CulturaGlobal As String

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If LogIn.Visible = False Then

            LogIn.Close()

        End If



    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ArticulosButtonn.Enabled = False
        ClientesButton.Enabled = False
        PresupuestosButton.Enabled = False
        VentasButton.Enabled = False
        PreciosButton.Enabled = False
        BackUpButton.Enabled = False
        IntegridadButton.Enabled = False
        UsuariosToolStripMenuItem.Enabled = False






        LabelX1.Text = Now.ToShortDateString

        Me.ForeColor = Color.LightGray

        MenuStrip1.ForeColor = Color.White
        MenuStrip1.BackColor = Color.DodgerBlue



        UnidadMedidaToolStripMenuItem.ForeColor = Color.White
        UnidadMedidaToolStripMenuItem.BackColor = Color.DodgerBlue

        SubUnidadMedidaToolStripMenuItem.ForeColor = Color.White
        SubUnidadMedidaToolStripMenuItem.BackColor = Color.DodgerBlue

        CategoriaToolStripMenuItem.ForeColor = Color.White
        CategoriaToolStripMenuItem.BackColor = Color.DodgerBlue

        SubCategoriaToolStripMenuItem.ForeColor = Color.White
        SubCategoriaToolStripMenuItem.BackColor = Color.DodgerBlue

        MarcasToolStripMenuItem.ForeColor = Color.White
        MarcasToolStripMenuItem.BackColor = Color.DodgerBlue

        PreciosToolStripMenuItem1.ForeColor = Color.White
        PreciosToolStripMenuItem1.BackColor = Color.DodgerBlue

        EventosToolStripMenuItem.ForeColor = Color.White
        EventosToolStripMenuItem.BackColor = Color.DodgerBlue

        ErroresToolStripMenuItem.ForeColor = Color.White
        ErroresToolStripMenuItem.BackColor = Color.DodgerBlue



        AdministrarToolStripMenuItem.ForeColor = Color.White
        AdministrarToolStripMenuItem.BackColor = Color.DodgerBlue






        Me.Icon = My.Resources.ico
        Me.Icon = My.Resources.ico




        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma



        If CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma

            ArticulosButtonn.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ARTICULOS" Select V.Value).FirstOrDefault
            ClientesButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CLIENTES" Select V.Value).FirstOrDefault
            UnidadMedidaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PresupuestosButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRESUPUESTOS" Select V.Value).FirstOrDefault
            SubUnidadMedidaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            CategoriaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SubCategoriaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MarcasToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            PreciosButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            NuevoPresupuestoToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVOPRESUPUESTO" Select V.Value).FirstOrDefault
            VentasToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVAVENTA" Select V.Value).FirstOrDefault
            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault
            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            IntegridadButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "INTEGRIDAD" Select V.Value).FirstOrDefault
            EventosToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "EVENTOS" Select V.Value).FirstOrDefault
            ErroresToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ERRORES" Select V.Value).FirstOrDefault
            BitacoraToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BITACORA" Select V.Value).FirstOrDefault
            'ArticulosEliminadosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOSELIMINADOS", Cultura))
            VentasButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "VENTAS" Select V.Value).FirstOrDefault
            UsuariosToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            ' EnviosButton.Text = RTrim(Multiidioma.ObtenerValue("ENVIOS", Cultura))

            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault

            ContraseñaButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑA" Select V.Value).FirstOrDefault

        End If


        If CulturaGlobal = "ENGLISH" Then


            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)





            ArticulosButtonn.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ARTICULOS" Select V.Value).FirstOrDefault
            ClientesButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CLIENTES" Select V.Value).FirstOrDefault
            UnidadMedidaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PresupuestosButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRESUPUESTOS" Select V.Value).FirstOrDefault
            SubUnidadMedidaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            CategoriaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SubCategoriaToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MarcasToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            PreciosButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            NuevoPresupuestoToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVOPRESUPUESTO" Select V.Value).FirstOrDefault
            VentasToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NUEVAVENTA" Select V.Value).FirstOrDefault
            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault
            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            IntegridadButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "INTEGRIDAD" Select V.Value).FirstOrDefault
            EventosToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "EVENTOS" Select V.Value).FirstOrDefault
            ErroresToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ERRORES" Select V.Value).FirstOrDefault
            BitacoraToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BITACORA" Select V.Value).FirstOrDefault
            'ArticulosEliminadosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOSELIMINADOS", Cultura))
            VentasButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "VENTAS" Select V.Value).FirstOrDefault
            UsuariosToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            ' EnviosButton.Text = RTrim(Multiidioma.ObtenerValue("ENVIOS", Cultura))
            ReportesToolStripMenuItem.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REPORTES" Select V.Value).FirstOrDefault

            ContraseñaButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CONTRASEÑA" Select V.Value).FirstOrDefault
        End If




        '-------PROCESO DE PATENTES


        LogOutToolStripMenuItem.Enabled = True
        For Each item In LogIn.ListaPatentes


            Select Case item.IdPatente

                Case 1

                    ArticulosButtonn.Enabled = True


                Case 2
                    ExtraToolStripMenuItem.Enabled = True

                Case 3
                    SubCategoriaToolStripMenuItem.Enabled = True

                Case 4
                    SubCategoriaToolStripMenuItem.Enabled = True


                Case 5
                    SubCategoriaToolStripMenuItem.Enabled = True

                Case 6
                    PreciosButton.Enabled = True

                Case 7

                    PresupuestosButton.Enabled = True
                    NuevoPresupuestoToolStripMenuItem.Enabled = True

                Case 8
                    ClientesButton.Enabled = True

                Case 9
                    VentasToolStripMenuItem.Enabled = True
                    VentasButton.Enabled = True

                Case 10
                    ReportesToolStripMenuItem.Enabled = True

                Case 11
                    IntegridadButton.Enabled = True

                Case 12
                    BitacoraToolStripMenuItem.Enabled = True

                Case 13
                    ' EnviosButton.Enabled = True

                Case 14
                    BackUpButton.Enabled = True

                Case 15
                    UsuariosToolStripMenuItem.Enabled = True
                    AdministrarToolStripMenuItem.Enabled = True



            End Select








        Next

        LogOutToolStripMenuItem.Enabled = True


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BackUpToolStripMenuItem_Click(sender As Object, e As EventArgs)
        BackUp.Show()
    End Sub

    Private Sub IntegridadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Integridad.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Idioma.Show()

    End Sub

    Private Sub SesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogIn.Show()
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub ErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErroresToolStripMenuItem.Click
        ErroresForm.Show()
    End Sub

    Private Sub EventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosToolStripMenuItem.Click
        EventosForm.Show()
    End Sub

    Private Sub NuevoPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPresupuestoToolStripMenuItem.Click
        NuevoPresupuestoForm.Show()
    End Sub

    Private Sub PresupuestosButton_Click(sender As Object, e As EventArgs)
        PresupuestosForm.Show()
    End Sub



    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        NuevaVentaForm.Show()
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click


    End Sub



    Private Sub PreciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem1.Click
        ReportePrecios.Show()

    End Sub

    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Usuarios.Show()
    End Sub



    Private Sub ArticulosButtonn_click(sender As Object, e As EventArgs) Handles ArticulosButtonn.Click
        ArticulosForm.Show()
    End Sub

    Private Sub ClientesButton_Click_1(sender As Object, e As EventArgs) Handles ClientesButton.Click
        ClienteForm.Show()
    End Sub

    Private Sub VentasButton_Click_1(sender As Object, e As EventArgs) Handles VentasButton.Click
        VentasForm.Show()
    End Sub

    Private Sub PresupuestosButton_Click_1(sender As Object, e As EventArgs) Handles PresupuestosButton.Click
        PresupuestosForm.Show()
    End Sub

    Private Sub UnidadMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadMedidaToolStripMenuItem.Click
        UnidadDeMedidaForm.Show()
    End Sub

    Private Sub SubUnidadMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubUnidadMedidaToolStripMenuItem.Click


    End Sub

    Private Sub ExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtraToolStripMenuItem.Click




    End Sub

    Private Sub ContextMenuBar1_ItemClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArticulosButtonn_MouseHover(sender As Object, e As EventArgs) Handles ArticulosButtonn.MouseHover
        Me.ArticulosButtonn.ForeColor = Color.Black
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PreciosButton_Click(sender As Object, e As EventArgs) Handles PreciosButton.Click
        Precios.Show()
    End Sub

    Private Sub BackUpButton_Click(sender As Object, e As EventArgs) Handles BackUpButton.Click
        BackUp.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click

    End Sub

    Private Sub IntegridadButton_Click(sender As Object, e As EventArgs) Handles IntegridadButton.Click
        Integridad.Show()

    End Sub

    Private Sub ContraseñaButton_Click(sender As Object, e As EventArgs) Handles ContraseñaButton.Click
        ContraseñaForm.Show()
    End Sub

    Private Sub AnalogClockControl1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class