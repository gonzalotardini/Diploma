Public Class ArticuloParaPresupuesto
    Private _Cod_Articulo As Integer
    Private _CodigoDeBarras As Long
    Private _Descripcion As String
    Private _Marca As String
    Private _SubUnidadDeMedida As String
    Private _Precio As Decimal


    Public Property Cod_Articulo As Integer
        Get
            Return _Cod_Articulo
        End Get
        Set(value As Integer)
            _Cod_Articulo = value
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


    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property SubUnidadDeMedida As String
        Get
            Return _SubUnidadDeMedida
        End Get
        Set(value As String)
            _SubUnidadDeMedida = value
        End Set
    End Property


    Public Property Precio As Decimal

        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property
End Class
