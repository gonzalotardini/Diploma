Public Class PresupuestoCabecera

    Private _Cod_Presupuesto As Long
    Private _Cod_Cliente As Integer
    Private _FechaInicio As Date
    Private _FechaFin As Date
    Private _Total As Decimal


    Public Property Cod_Presupuesto As Long
        Get
            Return _Cod_Presupuesto
        End Get
        Set(value As Long)
            _Cod_Presupuesto = value
        End Set
    End Property

    Public Property FechaInicio As Date
        Get
            Return _FechaInicio
        End Get
        Set(value As Date)
            _FechaInicio = value
        End Set
    End Property

    Public Property FechaFin As Date
        Get
            Return _FechaFin
        End Get
        Set(value As Date)
            _FechaFin = value
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
