Imports BIZ
Imports DAL


Public Class ModifcarArticuloForm

    Private Articulo As New Articulo

    Public Sub New(_Articulo As Articulo)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Articulo = _Articulo

    End Sub


    Private Sub ModifcarArticuloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        If Principal.CulturaGlobal = "ESPAÑOL" Then


            Dim Multiidioma As New SL.Multiidioma

            Dim Cultura = "ES-ESP"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICARARTICULO" Select V.Value).FirstOrDefault

            CODBARRAS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault
            DESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            UnidadDeMedida.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            SubUnidadMedidaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PrecioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIO" Select V.Value).FirstOrDefault
            CategoriaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SubCategoriaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MarcaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault

            ModificarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault






        End If

        If Principal.CulturaGlobal = "ENGLISH" Then

            Dim Multiidioma As New SL.Multiidioma
            Dim Cultura = "ENG-ENGLAND"
            ListaPalabras = Multiidioma.ObtenerPalabras(Cultura)

            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICARARTICULO" Select V.Value).FirstOrDefault

            CODBARRAS.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CODBARRAS" Select V.Value).FirstOrDefault
            DESCRIPCION.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "DESCRIPCION" Select V.Value).FirstOrDefault
            UnidadDeMedida.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "UNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            SubUnidadMedidaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBUNIDADDEMEDIDA" Select V.Value).FirstOrDefault
            PrecioLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PRECIO" Select V.Value).FirstOrDefault
            CategoriaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "CATEGORIA" Select V.Value).FirstOrDefault
            SubCategoriaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "SUBCATEGORIA" Select V.Value).FirstOrDefault
            MarcaLabel.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MARCA" Select V.Value).FirstOrDefault



            ModificarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "MODIFICAR" Select V.Value).FirstOrDefault
        End If









        Dim _ArticuloDao As New ArticuloDAO

        Articulo = _ArticuloDao.BuscarArticuloPorCodigo(Articulo)



        TextBoxX1.Text = Articulo.CodigoDeBarras
        TextBoxX2.Text = Articulo.Descripcion
        TextBox4.Text = Microsoft.VisualBasic.Right(Articulo.Precio, 2) 'solo los decimales
        TextBox3.Text = Convert.ToInt32(Fix(Articulo.Precio)) ' selecciono solo el número entero, sin decimales

    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click

    End Sub
    Public numUnidad As Integer = 0
    Public NumCategoria As Integer = 0
    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged


    End Sub

    Private Sub ComboBoxUnidadDeMedida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUnidadDeMedida.SelectedIndexChanged

        Dim _ArticuloDao As New ArticuloDAO
        Dim _SubUnidadMedidaDao As New SubUnidadDeMedidaDAO
        Dim _Articulo As New Articulo
        Dim _Unidad_Medida As New UnidadDeMedida



        If numUnidad = 1 Then

            _Unidad_Medida.CodUnidadMedida = ComboBoxUnidadDeMedida.SelectedValue


            'cargo las sub unidades de medida
            ComboBoxSubUnidadMedida.DataSource = _SubUnidadMedidaDao.ObtenerSubUnidadMedida(_Unidad_Medida)
            ComboBoxSubUnidadMedida.ValueMember = "Cod_SubUnidad_Medida"
            ComboBoxSubUnidadMedida.DisplayMember = "Descripcion"



            ComboBoxSubUnidadMedida.SelectedValue = Articulo.SubUnidadDeMedida



        End If









    End Sub

    Private Sub ComboBoxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategoria.SelectedIndexChanged
        Dim _ArticuloDao As New ArticuloDAO
        Dim _Categoria As New Categoria
        Dim _SubCategoriaDao As New SubCategoriaDAO



        'Cargo las subCategorias
        ' hago este if para que primero me cargue las categorias y despues las sub categorias, es una bandera para que no tire error
        If NumCategoria = 1 Then
            _Categoria.CodigoCategoria = ComboBoxCategoria.SelectedValue

            'Cargo Sub Categorias
            ComboBoxSubCategoria.DataSource = _SubCategoriaDao.ObtenerSubCategorias(_Categoria)
            ComboBoxSubCategoria.ValueMember = "Cod_SubCategoria"
            ComboBoxSubCategoria.DisplayMember = "Descripcion"
        End If


    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX2.TextChanged
        Dim _ArticuloDao As New ArticuloDAO
        Dim _UnidadDeMedidaDao As New UnidadDeMedidaDao
        Dim _CategoriaDao As New CategoriaDAO
        Dim _SubCategoriaDao As New SubCategoriaDAO
        Dim _MarcaDao As New MarcaDAO



        Dim _Articulo As New Articulo
        Dim _Categoria As New Categoria


        'cargo las unidades de medida
        ComboBoxUnidadDeMedida.DataSource = _UnidadDeMedidaDao.ObtenerUnidadesMedida
        ComboBoxUnidadDeMedida.ValueMember = "Cod_Unidad_Medida"
        ComboBoxUnidadDeMedida.DisplayMember = "Descripcion"

        numUnidad = 1
        ComboBoxUnidadDeMedida.SelectedValue = Articulo.UnidadDeMedida






        _Articulo.CodigoArticulo = Articulo.CodigoArticulo

        'articulosMetodos.ObtenerArticuloConID(articulo)


        ComboBoxUnidadDeMedida.SelectedValue = Articulo.UnidadDeMedida



        'cargo categorias

        ComboBoxCategoria.DataSource = _CategoriaDao.ObtenerTodasCategorias
        ComboBoxCategoria.ValueMember = "Cod_Categoria"
        ComboBoxCategoria.DisplayMember = "Descripcion"

        ComboBoxCategoria.SelectedValue = Articulo.Categoria
        NumCategoria = 1




        'cargo las sub categorias
        _Categoria.CodigoCategoria = ComboBoxCategoria.SelectedValue

        ComboBoxSubCategoria.DataSource = _SubCategoriaDao.ObtenerSubCategorias(_Categoria)
        ComboBoxSubCategoria.ValueMember = "Cod_SubCategoria"
        ComboBoxSubCategoria.DisplayMember = "Descripcion"








        ComboBoxSubCategoria.SelectedValue = Articulo.SubCategoria




        'cargo marcas

        ComboBoxMarca.DataSource = _MarcaDao.ObtenerMarcas
        ComboBoxMarca.ValueMember = "Cod_Marca"
        ComboBoxMarca.DisplayMember = "Descripcion"

        ComboBoxMarca.SelectedValue = Articulo.Marca

    End Sub
End Class