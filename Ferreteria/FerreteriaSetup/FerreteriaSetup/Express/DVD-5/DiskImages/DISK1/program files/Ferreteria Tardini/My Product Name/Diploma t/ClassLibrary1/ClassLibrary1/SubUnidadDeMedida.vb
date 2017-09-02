Public Class SubUnidadDeMedida



    Private _SubUnidadDeMedida As Integer
    Private _UnidadDeMedida As Integer
    Private _Descripcion As String


    Public Property SubUnidadDeMedida As Integer
        Get
            Return _SubUnidadDeMedida
        End Get
        Set(value As Integer)
            _SubUnidadDeMedida = value
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

    Public Property DescripcionSubUnidad As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
End Class
