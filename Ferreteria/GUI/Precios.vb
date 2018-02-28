Imports DAL
Imports BIZ
Imports BLL
Imports SL




Public Class Precios

    Private Sub Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico

        MarcaRadioButton.Checked = True
        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim _MarcaDao As New MarcaDAO

        ComboBox1.DataSource = _MarcaDao.ObtenerMarcas
        ComboBox1.ValueMember = "Cod_Marca"
        ComboBox1.DisplayMember = "Descripcion"



        AumentarRadioButton.Checked = True
        NumericUpDown1.Value = 1





        If Principal.CulturaGlobal = "ESPAÑOL" Then

            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ES-ESP"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)


            PreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault

            PreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            MarcaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            SubRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            CategoriaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            EXCLUIR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "EXCLUIR" Select V.Value).FirstOrDefault
            AceptarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ACEPTAR" Select V.Value).FirstOrDefault
            AumentarRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "AUMENTAR" Select V.Value).FirstOrDefault
            DescontarRadioButon.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCONTAR" Select V.Value).FirstOrDefault
            CantidadArticulosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDADDEARTICULOS" Select V.Value).FirstOrDefault



        End If


        If Principal.CulturaGlobal = "ENGLISH" Then


            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ENG-ENGLAND"

            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            PreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault

            PreciosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIOS" Select V.Value).FirstOrDefault
            MarcaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault
            SubRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            CategoriaRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            EXCLUIR.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "EXCLUIR" Select V.Value).FirstOrDefault
            AceptarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "ACEPTAR" Select V.Value).FirstOrDefault
            AumentarRadioButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "AUMENTAR" Select V.Value).FirstOrDefault
            DescontarRadioButon.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCONTAR" Select V.Value).FirstOrDefault
            CantidadArticulosLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CANTIDADDEARTICULOS" Select V.Value).FirstOrDefault



        End If

     






    End Sub
    Public I = 0
    Private Sub MarcaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MarcaRadioButton.CheckedChanged


        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

        Dim _MarcaDao As New MarcaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _CategoriaDao As New CategoriaDAO

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        I = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                ComboBox1.DataSource = _MarcaDao.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                I = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = _SubCategoriaDao.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                I = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = _CategoriaDao.ObtenerTodasCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                I = 1

        End Select



        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub

    Private Sub SubRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubRadioButton.CheckedChanged
        Dim _MarcaDao As New MarcaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _CategoriaDao As New CategoriaDAO

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        I = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                ComboBox1.DataSource = _MarcaDao.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                I = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = _SubCategoriaDao.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                I = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = _CategoriaDao.ObtenerTodasCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                I = 1

        End Select

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next



    End Sub

    Private Sub CategoriaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoriaRadioButton.CheckedChanged
        Dim _MarcaDao As New MarcaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _CategoriaDao As New CategoriaDAO

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        I = 0
        DataGridView1.DataSource = Nothing

        Select Case True

            Case MarcaRadioButton.Checked = True
                ComboBox1.DataSource = _MarcaDao.ObtenerMarcas
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Marca"
                I = 1

            Case SubRadioButton.Checked = True
                ComboBox1.DataSource = _SubCategoriaDao.ObtenerTodasLasSUbCategoriasSolas.Tables(0)
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_SubCategoria"

                I = 1

            Case CategoriaRadioButton.Checked = True
                ComboBox1.DataSource = _CategoriaDao.ObtenerTodasCategorias
                ComboBox1.DisplayMember = "Descripcion"
                ComboBox1.ValueMember = "Cod_Categoria"

                I = 1

        End Select




        For Each row As DataGridViewRow In DataGridView1.Rows

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub

    Private Sub EXCLUIR_Click(sender As Object, e As EventArgs) Handles EXCLUIR.Click



        If DataGridView1.CurrentRow IsNot Nothing Then

            ' saco de la lista el articulo que no quiero aumentar
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

        End If





        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos


    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click


        Dim _Articulo As New Articulo
        Dim _ListaArticulo As New List(Of Articulo)
        Dim _ArticuloDAO As New ArticuloDAO
        Dim _PorcentajeAumento As Integer
        Dim _GestorArticulo As New GestorArticulo
        Dim _CantidadItems As Integer
        Dim i As Integer



        _CantidadItems = DataGridView1.RowCount
        _PorcentajeAumento = NumericUpDown1.Value




        Try


            For i = 0 To _CantidadItems - 1

                _Articulo = New Articulo

                _Articulo.CodigoArticulo = DataGridView1.Rows(i).Cells("Codigo").Value
                _Articulo.Precio = DataGridView1.Rows(i).Cells("Precio").Value

                _ListaArticulo.Add(_Articulo)

            Next




            Select Case True

                Case AumentarRadioButton.Checked = True
                    _GestorArticulo.AumentarPreciosBLL(_PorcentajeAumento, _ListaArticulo)

                    MsgBox("Se actualizaron correctamente los Artículos", MsgBoxStyle.Information, "Información")
                    i = 1

                Case DescontarRadioButon.Checked = True
                    _GestorArticulo.DescontarPrecioBll(_ListaArticulo, _PorcentajeAumento)

                    MsgBox("Se actualizaron correctamente los Artículos", MsgBoxStyle.Information, "Información")

            End Select




        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")



        End Try





        'Una vez actualizado los precios me muestra la lista actualizada



        Dim _MarcasDao As New MarcaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _ArticuloDa As New ArticuloDAO
        Dim _marca As New Marca
        Dim _SubCategoria As New SubCategoria
        Dim _Categoria As New Categoria
        Dim _selected As Integer

        '_selected = ComboBox1.SelectedIndex

        'ComboBox1.SelectedIndex = _selected

        DataGridView1.DataSource = Nothing

        Try

            Select Case True
                Case MarcaRadioButton.Checked = True

                    If i = 1 Then
                        _marca.Cod_Marca = ComboBox1.SelectedValue

                        DataGridView1.DataSource = _ArticuloDa.ObtenerArticuloPorMarca(_marca)
                    End If


                Case SubRadioButton.Checked = True

                    If i = 1 Then

                        _SubCategoria.SubCategoria = ComboBox1.SelectedValue
                        DataGridView1.DataSource = _ArticuloDa.ObtenerArticuloPorSubCategoria(_SubCategoria)


                    End If

                Case CategoriaRadioButton.Checked = True

                    If i = 1 Then


                        _Categoria.CodigoCategoria = ComboBox1.SelectedValue
                        DataGridView1.DataSource = _ArticuloDa.ObtenenrArticulosPorCategoria(_Categoria)



                    End If

            End Select

            For Each row As DataGridViewRow In DataGridView1.Rows

                If row.Index Mod 2 <> 0 Then
                    row.DefaultCellStyle.BackColor = Color.Bisque
                    ' row.Cells("Descripcion").Style.Font.Bold = True

                Else
                    row.DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim _MarcasDao As New MarcaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _ArticuloDao As New ArticuloDAO
        Dim _Marca As New Marca
        Dim _SubCategoria As New SubCategoria
        Dim _Categoria As New Categoria


        DataGridView1.DataSource = Nothing
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Select Case True
            Case MarcaRadioButton.Checked = True

                If I = 1 Then
                    _Marca.Cod_Marca = ComboBox1.SelectedValue

                    DataGridView1.DataSource = _ArticuloDao.ObtenerArticuloPorMarca(_Marca)
                End If


            Case SubRadioButton.Checked = True

                If I = 1 Then

                    _SubCategoria.SubCategoria = ComboBox1.SelectedValue
                    DataGridView1.DataSource = _ArticuloDao.ObtenerArticuloPorSubCategoria(_SubCategoria)


                End If

            Case CategoriaRadioButton.Checked = True

                If I = 1 Then


                    _Categoria.CodigoCategoria = ComboBox1.SelectedValue
                    DataGridView1.DataSource = _ArticuloDao.ObtenenrArticulosPorCategoria(_Categoria)



                End If

        End Select

        Dim CantidadArticulos As Integer

        CantidadArticulos = DataGridView1.RowCount - 1
        Label3.Text = CantidadArticulos



        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub
End Class