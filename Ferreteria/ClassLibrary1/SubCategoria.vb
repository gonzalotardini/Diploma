Public Class SubCategoria


    Private _SubCategoria As Integer
    Private _Categoria As Integer
    Private _Descripcion As String


    Public Property SubCategoria As Integer
        Get
            Return _SubCategoria
        End Get
        Set(value As Integer)
            _SubCategoria = value
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

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
End Class
