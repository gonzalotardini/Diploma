Public Class VentaCabecera



    Private _Cod_Venta As Long
    Private _Cod_Cliente As Integer
    Private _Fecha As Date
    Private _Total As Decimal
    Private _RazonSocial As String

    Public Property RazonSocial As String
        Get
            Return _RazonSocial
        End Get
        Set(value As String)
            _RazonSocial = value
        End Set
    End Property


    Public Property Cod_Venta As Long
        Get
            Return _Cod_Venta
        End Get
        Set(value As Long)
            _Cod_Venta = value
        End Set
    End Property



    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property


    Public Property Cod_Cliente As Integer

        Get
            Return _Cod_Cliente
        End Get
        Set(value As Integer)
            _Cod_Cliente = value
        End Set
    End Property

End Class
