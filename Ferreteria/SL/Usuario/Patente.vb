Public Class Patente
    Private _IdPatente As Integer
    Private _Nombre As String

    Public Property IdPatente As Integer
        Get
            Return _IdPatente
        End Get
        Set(ByVal value As Integer)
            _IdPatente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return Me._Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class
