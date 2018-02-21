Public Class Reporte


    Protected _Fecha As Date
    Protected _Tipo As String
    Protected _Usuario As String
    Protected _Cod_Reporte As Integer


    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property


    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Cod_Reporte As Integer
        Get
            Return _Cod_Reporte
        End Get
        Set(value As Integer)
            _Cod_Reporte = value
        End Set
    End Property



End Class
