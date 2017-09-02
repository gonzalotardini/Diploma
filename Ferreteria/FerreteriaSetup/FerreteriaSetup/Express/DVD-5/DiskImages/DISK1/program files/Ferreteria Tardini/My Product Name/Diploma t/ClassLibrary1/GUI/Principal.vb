
Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ArticulosButton.Click
        Articuloss.Show()
    End Sub


    Public CulturaGlobal As String

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        LogIn.Close()


    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CulturaGlobal = "ESPAÑOL" Then

            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ES-ESP"

            ArticulosButton.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOS", Cultura))
            ClientesButton.Text = RTrim(Multiidioma.ObtenerValue("CLIENTES", Cultura))
            UnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("UNIDADDEMEDIDA", Cultura))
            PresupuestosButton.Text = Multiidioma.ObtenerValue("PRESUPUESTOS", Cultura)
            SubUnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBUNIDADDEMEDIDA", Cultura))
            CategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("CATEGORIA", Cultura))
            SubCategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBCATEGORIA", Cultura))
            MarcasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("MARCA", Cultura))
            PreciosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            NuevoPresupuestoToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVOPRESUPUESTO", Cultura))
            VentasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVAVENTA", Cultura))
            ReportesToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("REPORTES", Cultura))
            PreciosToolStripMenuItem1.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            'ArticulosEliminadosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOSELIMINADOS", Cultura))
            IntegridadToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("INTEGRIDAD", Cultura))
            EventosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("EVENTOS", Cultura))
            ErroresToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ERRORES", Cultura))
            BitacoraToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("BITACORA", Cultura))
            ' EnviosButton.Text = RTrim(Multiidioma.ObtenerValue("ENVIOS", Cultura))
            VentasButton.Text = RTrim(Multiidioma.ObtenerValue("VENTAS", Cultura))
            UsuariosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("USUARIO", Cultura))


        End If


        If CulturaGlobal = "ENGLISH" Then


            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ENG-ENGLAND"




            ArticulosButton.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOS", Cultura))
            ClientesButton.Text = RTrim(Multiidioma.ObtenerValue("CLIENTES", Cultura))
            UnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("UNIDADDEMEDIDA", Cultura))
            PresupuestosButton.Text = Multiidioma.ObtenerValue("PRESUPUESTOS", Cultura)
            SubUnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBUNIDADDEMEDIDA", Cultura))
            CategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("CATEGORIA", Cultura))
            SubCategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBCATEGORIA", Cultura))
            MarcasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("MARCA", Cultura))
            PreciosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            NuevoPresupuestoToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVOPRESUPUESTO", Cultura))
            VentasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVAVENTA", Cultura))
            ReportesToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("REPORTES", Cultura))
            PreciosToolStripMenuItem1.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            'ArticulosEliminadosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOSELIMINADOS", Cultura))
            IntegridadToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("INTEGRIDAD", Cultura))
            EventosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("EVENTOS", Cultura))
            ErroresToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ERRORES", Cultura))
            BitacoraToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("BITACORA", Cultura))
            ' EnviosButton.Text = RTrim(Multiidioma.ObtenerValue("ENVIOS", Cultura))
            VentasButton.Text = RTrim(Multiidioma.ObtenerValue("VENTAS", Cultura))
            UsuariosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("USUARIO", Cultura))

        End If

        If CulturaGlobal = "PORTUGUES" Then

            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "POR-PORTUGAL"






            ArticulosButton.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOS", Cultura))
            ClientesButton.Text = RTrim(Multiidioma.ObtenerValue("CLIENTES", Cultura))
            UnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("UNIDADDEMEDIDA", Cultura))
            PresupuestosButton.Text = Multiidioma.ObtenerValue("PRESUPUESTOS", Cultura)
            SubUnidadMedidaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBUNIDADDEMEDIDA", Cultura))
            CategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("CATEGORIA", Cultura))
            SubCategoriaToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("SUBCATEGORIA", Cultura))
            MarcasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("MARCA", Cultura))
            PreciosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            NuevoPresupuestoToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVOPRESUPUESTO", Cultura))
            VentasToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("NUEVAVENTA", Cultura))
            ReportesToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("REPORTES", Cultura))
            PreciosToolStripMenuItem1.Text = RTrim(Multiidioma.ObtenerValue("PRECIOS", Cultura))
            ' ArticulosEliminadosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ARTICULOSELIMINADOS", Cultura))
            IntegridadToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("INTEGRIDAD", Cultura))
            EventosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("EVENTOS", Cultura))
            ErroresToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("ERRORES", Cultura))
            BitacoraToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("BITACORA", Cultura))
            UsuariosToolStripMenuItem.Text = RTrim(Multiidioma.ObtenerValue("USUARIO", Cultura))
            ' EnviosButton.Text = RTrim(Multiidioma.ObtenerValue("ENVIOS", Cultura))

            VentasButton.Text = RTrim(Multiidioma.ObtenerValue("VENTAS", Cultura))
        End If





        '-------PROCESO DE PATENTES


        LogOutToolStripMenuItem.Enabled = True
        For Each item In LogIn.ListaPatentes


            Select Case item.IdPatente

                Case 1

                    ArticulosButton.Enabled = True


                Case 2
                    ExtraToolStripMenuItem.Enabled = True

                Case 3
                    SubCategoriaToolStripMenuItem.Enabled = True

                Case 4
                    SubCategoriaToolStripMenuItem.Enabled = True


                Case 5
                    SubCategoriaToolStripMenuItem.Enabled = True

                Case 6
                    PreciosToolStripMenuItem.Enabled = True

                Case 7

                    PresupuestosButton.Enabled = True
                    NuevoPresupuestoToolStripMenuItem.Enabled = True

                Case 8
                    ClientesButton.Enabled = True

                Case 9
                    VentasToolStripMenuItem.Enabled = True

                Case 10
                    ReportesToolStripMenuItem.Enabled = True

                Case 11
                    IntegridadToolStripMenuItem.Enabled = True

                Case 12
                    BitacoraToolStripMenuItem.Enabled = True

                Case 13
                    ' EnviosButton.Enabled = True

                Case 14
                    BackUpToolStripMenuItem.Enabled = True



            End Select








        Next

        LogOutToolStripMenuItem.Enabled = True


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BackUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpToolStripMenuItem.Click
        BackUp.Show()
    End Sub

    Private Sub IntegridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegridadToolStripMenuItem.Click
        Integridad.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Idioma.Show()

    End Sub

    Private Sub SesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        LogIn.Show()
        Me.Close()
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

    Private Sub PresupuestosButton_Click(sender As Object, e As EventArgs) Handles PresupuestosButton.Click
        PresupuestosForm.Show()
    End Sub

    Private Sub ClientesButton_Click(sender As Object, e As EventArgs) Handles ClientesButton.Click
        ClienteForm.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        NuevaVentaForm.Show()
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Precios.Show()

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.Show()

    End Sub

    Private Sub VentasButton_Click(sender As Object, e As EventArgs) Handles VentasButton.Click
        VentasForm.Show()

    End Sub

    Private Sub PreciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem1.Click
        ReportePrecios.Show()

    End Sub
End Class