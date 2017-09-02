Public Class UnidadDeMedida

    Private _CodUnidadMedida As Integer
    Private _DescripcionUnidadMedida As String

    Public Property CodUnidadMedida As Integer
        Get
            Return _CodUnidadMedida
        End Get
        Set(value As Integer)
            _CodUnidadMedida = value
        End Set
    End Property

    Public Property DescripcionUnidadMedida As String
        Get
            Return _DescripcionUnidadMedida
        End Get
        Set(value As String)
            _DescripcionUnidadMedida = value
        End Set
    End Property
End Class
