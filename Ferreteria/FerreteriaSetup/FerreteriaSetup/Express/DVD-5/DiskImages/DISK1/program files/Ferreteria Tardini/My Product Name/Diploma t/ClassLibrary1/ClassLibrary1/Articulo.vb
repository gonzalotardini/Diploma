Public Class Articulo

    Private _CodigoArticulo As Integer
    Private _CodigoDeBarras As Long
    Private _Descripcion As String
    Private _Precio As Double
    Private _UnidadDeMedida As Integer
    Private _SubUnidadDeMedida As Integer
    Private _Categoria As Integer
    Private _SubCategoria As Integer
    Private _Marca As Integer


    Public Property CodigoArticulo As Integer

        Get
            Return _CodigoArticulo
        End Get
        Set(value As Integer)
            _CodigoArticulo = value

        End Set
    End Property

    Public Property CodigoDeBarras As Long

        Get
            Return _CodigoDeBarras
        End Get
        Set(value As Long)
            _CodigoDeBarras = value

        End Set
    End Property
    Public Property Descripcion As String

        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value

        End Set
    End Property

    Public Property UnidadDeMedida As Integer

        Get
            Return _UnidadDeMedida
        End Get
        Set(value As Integer)
            _UnidadDeMedida = value

        End Set
    End Property

    Public Property SubUnidadDeMedida As Integer

        Get
            Return _SubUnidadDeMedida
        End Get
        Set(value As Integer)
            _SubUnidadDeMedida = value

        End Set
    End Property
    Public Property Precio As Integer

        Get
            Return _Precio
        End Get
        Set(value As Integer)
            _Precio = value

        End Set
    End Property




    Public Property Categoria As Integer

        Get
            Return _Categoria
        End Get
        Set(value As Integer)
            _Categoria = value

        End Set
    End Property

    Public Property SubCategoria As Integer

        Get
            Return _SubCategoria
        End Get
        Set(value As Integer)
            _SubCategoria = value

        End Set
    End Property

    Public Property Marca As Integer

        Get
            Return _Marca
        End Get
        Set(value As Integer)
            _Marca = value

        End Set
    End Property

End Class
