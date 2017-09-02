Public Class PalabrasIdioma

    Private _Key As String
    Private _Value As String
    Private _Cultura As String

    Public Property Key As String
        Get
            Return _Key
        End Get
        Set(value As String)
            _Key = value

        End Set
    End Property

    Public Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
        End Set
    End Property

    Public Property Cultura As String
        Get
            Return _Cultura
        End Get
        Set(value As String)
            _Cultura = value
        End Set
    End Property
End Class
