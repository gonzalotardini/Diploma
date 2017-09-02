Public Class Categoria
    Private _CodigoCategoria As Integer
    Private _DescripcionCategoria As String



    Public Property CodigoCategoria As Integer
        Get
            Return _CodigoCategoria
        End Get
        Set(value As Integer)
            _CodigoCategoria = value
        End Set
    End Property



    Public Property DescripcionCategoria As String
        Get
            Return _DescripcionCategoria
        End Get
        Set(value As String)
            _DescripcionCategoria = value
        End Set
    End Property

End Class
