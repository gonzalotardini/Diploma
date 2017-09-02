Public Class Cliente

    Private _CodigoCliente As Integer
    Private _RazonSocial As String
    Private _Cuit As Long
    Private _Direccion As String
    Private _Barrio As Integer
    Private _Telefono As Long
    Private _Email As String

    Public Property CodigoCliente As Integer
        Get
            Return _CodigoCliente
        End Get
        Set(value As Integer)
            _CodigoCliente = value
        End Set
    End Property

    Public Property RazonSocial As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property

    Public Property Cuit As Long
        Get
            Return _Cuit
        End Get
        Set(value As Long)
            _Cuit = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Barrio As Integer
        Get
            Return _Barrio
        End Get
        Set(value As Integer)
            _Barrio = value
        End Set
    End Property

    Public Property Telefono As Long
        Get
            Return _Telefono
        End Get
        Set(value As Long)
            _Telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
End Class
