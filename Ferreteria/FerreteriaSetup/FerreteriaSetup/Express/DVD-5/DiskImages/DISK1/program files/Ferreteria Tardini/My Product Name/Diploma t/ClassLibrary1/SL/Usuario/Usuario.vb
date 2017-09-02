Public Class Usuario
    Private _IdUsuario As Integer
    Private _NombreUsuario As String
    Private _Pw As String


    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property


    Public Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(ByVal value As String)
            _NombreUsuario = value
        End Set
    End Property

    Public Property PW As String
        Get
            Return _Pw
        End Get
        Set(ByVal value As String)
            _Pw = value
        End Set
    End Property

End Class


