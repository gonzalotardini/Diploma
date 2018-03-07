

Imports BIZ
Imports BLL
Imports SL
Imports DAL





Public Class ArticulosForm







    Private Sub Button1_Click_1(sender As Object, e As EventArgs)





    End Sub

    Public num = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized

        Me.Width = 1366

        Me.Height = 768



        Me.PerformAutoScale()
        Me.Icon = My.Resources.ico
        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)



        If Principal.CulturaGlobal = "ESPAÑOL" Then


            Dim Multiidioma As New SL.Multiidioma

            Dim Cultura = "ES-ESP"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            CODBARRAS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault
            DESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            UNIDADDEMEDIDA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            SUBUNIDADDEMEDIDA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PRECIO.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIO" Select V.Value).FirstOrDefault
            CATEGORIA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SUBCATEGORIA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MARCA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            ARTICULOSlbl.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ARTICULOS" Select V.Value).FirstOrDefault
            BUSCAR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BUSCAR" Select V.Value).FirstOrDefault
            RadioButtonDESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            MODIFICAR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault
            RadioButtonCODIGO.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            CANTIDADDEARTICULOS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDADDEARTICULOS" Select V.Value).FirstOrDefault




        End If

        If Principal.CulturaGlobal = "ENGLISH" Then

            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            CODBARRAS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault
            DESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            UNIDADDEMEDIDA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            SUBUNIDADDEMEDIDA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PRECIO.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIO" Select V.Value).FirstOrDefault
            CATEGORIA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SUBCATEGORIA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MARCA.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            ARTICULOSlbl.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ARTICULOS" Select V.Value).FirstOrDefault
            BUSCAR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "BUSCAR" Select V.Value).FirstOrDefault
            RadioButtonDESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            MODIFICAR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault
            RadioButtonCODIGO.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODIGO" Select V.Value).FirstOrDefault
            CANTIDADDEARTICULOS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDADDEARTICULOS" Select V.Value).FirstOrDefault



        End If




        Application.DoEvents()
        TextBoxBuscar.Focus()





        '----------------------------------------------------------------------

        Dim ArticuloDao As New ArticuloDAO
        Dim UnidadDeMedidaDao As New UnidadDeMedidaDao

        TextBox3.Text = "00"
        RadioButtonDESCRIPCION.Select()

        Try


            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


            'Cargo las unidades de medida
            Combo_UniddMedida.DataSource = UnidadDeMedidaDao.ObtenerUnidadesMedida
            Combo_UniddMedida.ValueMember = "Cod_Unidad_Medida"
            Combo_UniddMedida.DisplayMember = "Descripcion"











        Catch ex As Exception


            MsgBox(ex.Message)



        End Try




        'CARGO LAS SUB UNIDAD DE MEDIDA


        Try


            Dim UnidadDeMedida As New UnidadDeMedida
            Dim SubUnidadDeMedidaDao As New SubUnidadDeMedidaDAO




            UnidadDeMedida.CodUnidadMedida = Combo_UniddMedida.SelectedValue
            'Cargo las Sub Unidad de Medida
            Combo_SubUnidad.DataSource = SubUnidadDeMedidaDao.ObtenerSubUnidadMedida(UnidadDeMedida)
            Combo_SubUnidad.DisplayMember = "Descripcion"
            Combo_SubUnidad.ValueMember = "Cod_SubUnidad_Medida"


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try






        'Cargo las Categorias

        Try

            Dim _CategoriaDAO As New CategoriaDAO

            ComboCategoria.DataSource = _CategoriaDAO.ObtenerTodasCategorias
            ComboCategoria.ValueMember = "Cod_Categoria"
            ComboCategoria.DisplayMember = "Descripcion"
            num = 1
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try



        'Cargo Sub Categorias


        Try

            Dim Categoria As New Categoria
            Dim SubCategoriaDao As New SubCategoriaDAO

            Categoria.CodigoCategoria = ComboCategoria.SelectedValue


            ComboSubCategoria.DataSource = SubCategoriaDao.ObtenerSubCategorias(Categoria)
            ComboSubCategoria.ValueMember = "Cod_SubCategoria"
            ComboSubCategoria.DisplayMember = "Descripcion"

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try








        'Cargo las Marcas

        Try

            Dim MarcaDAO As New MarcaDAO

            ComboMarca.DataSource = MarcaDAO.ObtenerMarcas
            ComboMarca.ValueMember = "Cod_Marca"
            ComboMarca.DisplayMember = "Descripcion"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        DataGridView2.DataSource = ArticuloDao.ObtenerPrimerosArticulos.Tables(0)

        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView2.RowCount - 1
        Label14.Text = CantidadArticulos

        For Each row As DataGridViewRow In DataGridView2.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next











    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub


    Private Sub Combo_UniddMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_UniddMedida.SelectedIndexChanged

        Dim UnidadDeMedida As New UnidadDeMedida
        'Dim Categoria As New Categoria
        Dim SubUnidadDeMedidaDAO As New SubUnidadDeMedidaDAO






        UnidadDeMedida.CodUnidadMedida = Combo_UniddMedida.SelectedValue

        'Cargo las Sub Unidad de Medida
        Combo_SubUnidad.DataSource = SubUnidadDeMedidaDAO.ObtenerSubUnidadMedida(UnidadDeMedida)
        Combo_SubUnidad.DisplayMember = "Descripcion"
        Combo_SubUnidad.ValueMember = "Cod_SubUnidad_Medida"


    End Sub




    Private Sub ComboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCategoria.SelectedIndexChanged
        Dim SubCategoriaDAO As New SubCategoriaDAO
        Dim Categoria As New Categoria



        If num = 1 Then
            Try
                Categoria.CodigoCategoria = ComboCategoria.SelectedValue

                'Cargo Sub Categorias
                ComboSubCategoria.DataSource = SubCategoriaDAO.ObtenerSubCategorias(Categoria)
                ComboSubCategoria.ValueMember = "Cod_SubCategoria"
                ComboSubCategoria.DisplayMember = "Descripcion"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




        End If

    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown


        Dim bandera As Integer = 0

        If RadioButtonCODIGO.Checked = True Then

            Dim Articulo As New Articulo
            Dim ArticuloBLL As New GestorArticulo

            Select Case e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscar.Text)
                        DataGridView2.DataSource = ArticuloBLL.ValidarCodigoDeBarrasParaBusqueda(Articulo)

                        TextBoxBuscar.SelectAll()

                        For Each row As DataGridViewRow In DataGridView2.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next
                    Else
                        bandera = 1
                    End If

                    Dim CantidadArticulos As Integer

                    CantidadArticulos = DataGridView2.RowCount - 1
                    Label14.Text = CantidadArticulos

            End Select

        End If

        If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

            Dim Articulo As New Articulo
            Dim GestorArticulo As New GestorArticulo

            Select Case e.KeyData

                Case Keys.Enter

                    Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
                    DataGridView2.DataSource = GestorArticulo.ValidarDescripcionParaBusqueda(Articulo).Tables(0)



                    For Each row As DataGridViewRow In DataGridView2.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    bandera = 0

                    RadioButtonDESCRIPCION.Checked = True
            End Select

            Dim CantidadArticulos As Integer

            CantidadArticulos = DataGridView2.RowCount - 1
            Label14.Text = CantidadArticulos
        End If



    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

    Private Sub RadioButtonCODIGO_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCODIGO.CheckedChanged
        If RadioButtonCODIGO.Checked = True Then
            TextBoxBuscar.Text = ""
            Me.Show()
            TextBoxBuscar.Focus()


        End If

        If RadioButtonDESCRIPCION.Checked = True Then
            Me.Show()
            TextBoxBuscar.Focus()
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim _Articulo As New Articulo
        Dim _ArticuloDao As New ArticuloDAO



        Try

            If MsgBox("¿Desea eliminar el articulo?", vbYesNo, "ATENCION") = True Then

                _Articulo.CodigoArticulo = DataGridView2.CurrentRow.Cells(0).Value
                _Articulo.Descripcion = DataGridView2.CurrentRow.Cells(2).Value

                _ArticuloDao.EliminarArticulo(_Articulo)

                Dim el As New EventLogger

                MsgBox("Se ha eliminado correctamente el articulo " & _Articulo.Descripcion, MsgBoxStyle.Information, "ATENCION")
                el.WriteToErrorLog("Se ha eliminado correctamente el articulo " & _Articulo.Descripcion, "Articulo Form", "Información")

                _ArticuloDao.ObtenerPrimerosArticulos()

            End If


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try



    End Sub

    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs)

        Dim Articulo As New Articulo


        Articulo.CodigoArticulo = DataGridView2.CurrentRow.Cells(0).Value


        Dim Form As New ModifcarArticuloForm(Articulo)


        Form.Show()




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        For Each row As DataGridViewRow In DataGridView2.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub MODIFICAR1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles MODIFICAR.Click
        Dim Articulo As New Articulo


        Articulo.CodigoArticulo = DataGridView2.CurrentRow.Cells(0).Value


        Dim Form As New ModifcarArticuloForm(Articulo)


        Form.Show()


    End Sub

    Private Sub AgregarClienteButton_Click(sender As Object, e As EventArgs) Handles AgregarClienteButton.Click
        Dim GestorArticulo As New GestorArticulo
        Dim Articulo As New Articulo
        Dim _Tipo As String

        _Tipo = "AGREGAR"

        Dim Fecha As Date

        Fecha = Now





        Try
            'el textbox codigo de barras no puede estar vacio
            If TextBoxCodProveedor.Text = "" Then

                Select Case Principal.CulturaGlobal
                    Case "ESPAÑOL"
                        Throw New Exception("Introduzca Codigo de Barras")

                    Case "ENGLISH"
                        Throw New Exception("Introduce Bar Code")
                End Select

                TextBoxCodProveedor.Focus()

            Else
                Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxCodProveedor.Text)
            End If


            If TextBoxPrecio.Text = "" Then

                Select Case Principal.CulturaGlobal
                    Case "ESPAÑOL"
                        Throw New Exception("Introduzca precio")

                    Case "ENGLISH"
                        Throw New Exception("Introduce Price")
                End Select


                TextBoxPrecio.Focus()
            Else

                Articulo.Precio = Convert.ToDecimal(TextBoxPrecio.Text + "," + TextBox3.Text)

            End If


            If Combo_UniddMedida.SelectedIndex = -1 Then
                Throw New Exception("Error, Seleccione Unidad de Medida")

            Else

                Articulo.UnidadDeMedida = Combo_UniddMedida.SelectedValue

            End If



            If Combo_SubUnidad.SelectedIndex = -1 Then

                Throw New Exception("Error, Seleccione Sub-Unidad de Medida")


            Else
                Articulo.SubUnidadDeMedida = Combo_SubUnidad.SelectedValue

            End If


            If ComboCategoria.SelectedIndex = -1 Then

                Throw New Exception("Error, Seleccione Categoría")

            Else

                Articulo.Categoria = ComboCategoria.SelectedValue

            End If



            If ComboSubCategoria.SelectedIndex = -1 Then

                Throw New Exception("Error, Seleccione Sub-Categoría")

            Else

                Articulo.SubCategoria = ComboSubCategoria.SelectedValue

            End If


            If ComboMarca.SelectedIndex = -1 Then

                Throw New Exception("Error, Seleccione Marca")

            Else

                Articulo.Marca = ComboMarca.SelectedValue

            End If


            Articulo.Descripcion = (TextBoxDescripcion.Text).ToUpper


            GestorArticulo.ValidarDatosArticulo(Articulo, Fecha, _Tipo)

            Dim el As New EventLogger

            el.WriteToErrorLog("Se agregó correctamente el artículo " & Articulo.Descripcion, "Articulo Form", "Información")

            Dim Mensaje = MsgBox("Se agregó correctamente el articulo " & Articulo.Descripcion, MsgBoxStyle.Information, "ATENCÓN")


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")



        End Try

    End Sub
End Class
