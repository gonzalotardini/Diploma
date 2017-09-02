Imports System.Data
Imports System.Collections.Generic
Imports System.Reflection




Public Class Convertir

    ''' <summary>
    ''' Convierte datatables a lista de artículos
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="datatable"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function DataTableToList(Of T)(ByVal datatable As DataTable) As List(Of T)

        Dim objects As New List(Of T)
        Dim tipo As Type = GetType(T)
        For Each DataRow In datatable.Rows
            Dim instancia As Object = Activator.CreateInstance(tipo)
            DataRowToObject(DataRow, instancia)
            objects.Add(instancia)
        Next
        Return objects

    End Function


    ''' <summary>
    ''' Convierte lista de artículos a datatables
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="lista"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListToDataTable(Of T)(ByVal lista As List(Of T)) As DataTable

        Dim dataTable As New DataTable
        Dim tipo As Type = GetType(T)
        'Genero las columnas
        For Each propiedad As PropertyInfo In tipo.GetProperties()
            Dim dcNombre As New DataColumn
            dcNombre.DataType = propiedad.GetType
            dcNombre.ColumnName = propiedad.Name
            dataTable.Columns.Add(dcNombre)
        Next
        For Each objeto In lista
            Dim row As DataRow = dataTable.NewRow
            ObjectToDataRow(objeto, row)
            dataTable.Rows.Add(row)
        Next
        Return dataTable

    End Function


    Public Sub DataRowToObject(ByVal dr As DataRow, ByRef o As Object)

        Dim tipo As Type = o.GetType()
        Dim propiedades As PropertyInfo() = tipo.GetProperties()
        For Each columna As DataColumn In dr.Table.Columns
            'Verifico que el objeto tiene una propiedad que se llama igual a mi columna
            Dim propiedad As PropertyInfo = tipo.GetProperty(columna.ColumnName)
            If Not propiedad Is Nothing Then
                propiedad.SetValue(o, dr(columna.ColumnName))
            End If
        Next

    End Sub


    Public Sub ObjectToDataRow(ByVal o As Object, ByRef dr As DataRow)

        Dim tipo As Type = o.GetType()
        Dim propiedades As PropertyInfo() = tipo.GetProperties()
        For Each propiedad As PropertyInfo In propiedades
            If Not dr(propiedad.Name) Is Nothing Then
                dr(propiedad.Name) = propiedad.GetValue(o)
            End If
        Next

    End Sub


    Public Function ObjectToDataRow(ByVal o As Object) As DataRow

        Dim tipo As Type = o.GetType()
        Dim dataTable As New DataTable

        'Genero las columnas
        For Each propiedad As PropertyInfo In tipo.GetProperties()
            Dim dcNombre As New DataColumn
            dcNombre.DataType = propiedad.PropertyType
            dcNombre.ColumnName = propiedad.Name
            dataTable.Columns.Add(dcNombre)
        Next

        Dim dr As DataRow = dataTable.NewRow()

        Dim propiedades As PropertyInfo() = tipo.GetProperties()

        For Each propiedad As PropertyInfo In propiedades
            If Not dr(propiedad.Name) Is Nothing Then
                dr(propiedad.Name) = propiedad.GetValue(o)
            End If
        Next

        Return dr

    End Function

End Class

