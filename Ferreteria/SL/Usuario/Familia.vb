Public Class Familia
    Private _IdFamilia As Integer
    Private _Nombre As Integer


    Public Property IdFamilia As Integer
        Get
            Return _IdFamilia
        End Get
        Set(value As Integer)
            _IdFamilia = value
        End Set
    End Property



    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
End Class
