﻿Public Class ReporteArticulosMasVendidosDetalle
    Inherits Articulo
    Private _Cod_Reporte As Integer
    Private _Cod_Articulo As Integer
    Private _CantidadVentas As Integer
    Private _Marca1 As String
    Private _SubUnidad1 As String


    Public Property SubUnidad1 As String
        Get
            Return _SubUnidad1
        End Get
        Set(ByVal value As String)
            _SubUnidad1 = value
        End Set
    End Property

    Public Property Marca1 As String
        Get
            Return _Marca1
        End Get
        Set(ByVal value As String)
            _Marca1 = value
        End Set
    End Property

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

    Public Property CantidadVentas As Integer
        Get
            Return _CantidadVentas
        End Get
        Set(ByVal value As Integer)
            _CantidadVentas = value
        End Set
    End Property


End Class
