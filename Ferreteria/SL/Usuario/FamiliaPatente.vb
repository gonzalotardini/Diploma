Public Class FamiliaPatente

    Private _IdFamilia As Integer
    Private _IdPatente As Integer

    Public Property Idfamilia As Integer
        Get
            Return _IdFamilia
        End Get
        Set(value As Integer)
            _IdFamilia = value
        End Set
    End Property


    Public Property IdPatente As Integer
        Get
            Return _IdPatente
        End Get
        Set(value As Integer)
            _IdPatente = value
        End Set
    End Property

End Class
