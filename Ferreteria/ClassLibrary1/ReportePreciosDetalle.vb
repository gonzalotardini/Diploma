Public Class ReportePreciosDetalle
    Inherits Articulo

    Private _Cod_Reporte As Integer
    Private _Cod_Articulo As Integer
    Private _PorcentajeAumento As Decimal
    Private _PrecioInicial As Decimal
    Private _PrecioFinal As Decimal
    Private _Fecha_Desde As Date
    Private _Fecha_Hasta As Date
    Private _CantidadPrecios As Integer
    Private _Marca As String
    Private _SubUnidad As String


    Public Property Cod_Reporte As Integer
        Get
            Return _Cod_Reporte
        End Get
        Set(ByVal value As Integer)
            _Cod_Reporte = value
        End Set
    End Property

    Public Property Cod_Articulo As Integer
        Get
            Return _Cod_Articulo
        End Get
        Set(ByVal value As Integer)
            _Cod_Articulo = value
        End Set
    End Property


    Public Property PorcentajeAumento As Decimal
        Get
            Return _PorcentajeAumento
        End Get
        Set(ByVal value As Decimal)
            _PorcentajeAumento = value
        End Set
    End Property

    Public Property PrecioInicial As Decimal
        Get
            Return _PrecioInicial
        End Get
        Set(ByVal value As Decimal)
            _PrecioInicial = value
        End Set
    End Property


    Public Property PrecioFinal As Decimal
        Get
            Return _PrecioFinal
        End Get
        Set(ByVal value As Decimal)
            _PrecioFinal = value
        End Set
    End Property


    Public Property Fecha_Desde As Date
        Get
            Return _Fecha_Desde
        End Get
        Set(ByVal value As Date)
            _Fecha_Desde = value
        End Set
    End Property

    Public Property Fecha_Hasta As Date
        Get
            Return _Fecha_Hasta
        End Get
        Set(ByVal value As Date)
            _Fecha_Hasta = value
        End Set
    End Property



    Public Property CantidadPrecios() As Integer
        Get
            Return _CantidadPrecios
        End Get
        Set(ByVal value As Integer)
            _CantidadPrecios = value
        End Set
    End Property

    Public Property Marca1 As String
        Get
            Return _Marca
        End Get
        Set(ByVal value As String)
            _Marca = value
        End Set
    End Property


    Public Property SubUnidad As String
        Get
            Return _SubUnidad
        End Get
        Set(ByVal value As String)
            _SubUnidad = value
        End Set
    End Property


End Class
