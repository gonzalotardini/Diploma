Imports BIZ
Imports DAL
Imports BLL
Imports SL

Public Class ReportePrecios

    Private Sub ReportePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico
        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir
        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        RadioButtonDESCRIPCION.Checked = True


        Dim _ArticuloDAO As New ArticuloDAO




        ArticulosGridView.DataSource = _ArticuloDAO.ObtenerPreciosHistoricostop50.Tables(0)

        For Each row As DataGridViewRow In ArticulosGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

        ArticulosGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub TextBoxBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBuscar.KeyDown



        Dim bandera As Integer = 0

        If RadioButtonCODIGO.Checked = True Then

            Dim Articulo As New Articulo
            Dim ArticuloBLL As New GestorArticulo

            Select Case e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(TextBoxBuscar.Text)

                    If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscar.Text)
                        ArticulosGridView.DataSource = ArticuloBLL.ValidarCodigoDeBarrasParaBusqueda(Articulo)

                        TextBoxBuscar.SelectAll()

                        For Each row As DataGridViewRow In ArticulosGridView.Rows

                            If row.Index Mod 2 <> 0 Then
                                row.DefaultCellStyle.BackColor = Color.Bisque
                            Else
                                row.DefaultCellStyle.BackColor = Color.Aqua

                            End If

                        Next




                    Else
                        bandera = 1
                    End If

                    Dim CantidadArticulos As Integer

                    'CantidadArticulos = DataGridView1.RowCount - 1
                    'Label14.Text = CantidadArticulos

            End Select


        End If

        If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

            Dim Articulo As New Articulo
            Dim GestorArticulo As New GestorArticulo

            Select Case e.KeyData

                Case Keys.Enter

                    Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
                    ArticulosGridView.DataSource = GestorArticulo.ValidarDescripcionParaBusqueda(Articulo).Tables(0)



                    For Each row As DataGridViewRow In ArticulosGridView.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    bandera = 0

                    RadioButtonDESCRIPCION.Checked = True
            End Select

            Dim CantidadArticulos As Integer

            'CantidadArticulos = DataGridView1.RowCount - 1
            'Label14.Text = CantidadArticulos
        End If



        'Dim bandera As Integer = 0

        'Dim _fecha_Desde As Date
        'Dim _fecha_hasta As Date

        '_fecha_Desde = FechaDesde.Value
        '_fecha_hasta = FechaHasta.Value

        'If RadioButtonCODIGO.Checked = True Then

        '    Dim _Articulo As New Articulo
        '    Dim _ArticuloDao As New ArticuloDAO

        '    Select Case e.KeyData
        '        Case Keys.Enter
        '            Dim EsNumero As Boolean

        '            EsNumero = IsNumeric(TextBoxBuscar.Text)

        '            If TextBoxBuscar.Text <> "" And EsNumero = True And ((Len(TextBoxBuscar.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
        '                _Articulo.CodigoDeBarras = Convert.ToInt64(TextBoxBuscar.Text)
        '                DataGridView1.DataSource = _ArticuloDao.ObtenerPreciosHistoricosPorCodigo(_Articulo).Tables(0)

        '                TextBoxBuscar.SelectAll()


        '                For Each row As DataGridViewRow In DataGridView1.Rows

        '                    If row.Index Mod 2 <> 0 Then
        '                        row.DefaultCellStyle.BackColor = Color.Bisque
        '                    Else
        '                        row.DefaultCellStyle.BackColor = Color.Aqua

        '                    End If

        '                Next
        '                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        '            Else
        '                bandera = 1
        '            End If

        '            Dim CantidadArticulos As Integer

        '            CantidadArticulos = DataGridView1.RowCount - 1
        '            '   Label14.Text = CantidadArticulos

        '    End Select




        'End If

        'If RadioButtonDESCRIPCION.Checked = True Or bandera = 1 Then

        '    'Dim articulo2 As New Articulo
        '    ' Dim articuloMetodos2 As New ArticulosMetodos

        '    Select Case e.KeyData

        '        Case Keys.Enter



        '            Dim _Articulo As New Articulo
        '            Dim _ArticuloDao As New ArticuloDAO

        '            ' _Articulo.BuscarArticuloPorNombre(articulo2)


        '            _Articulo.Descripcion = (TextBoxBuscar.Text).ToUpper
        '            DataGridView1.DataSource = _ArticuloDao.ObtenerPreciosHistoricosPorDescripcion(_Articulo, _fecha_Desde, _fecha_hasta).Tables(0)



        '            For Each row As DataGridViewRow In DataGridView1.Rows

        '                If row.Index Mod 2 <> 0 Then
        '                    row.DefaultCellStyle.BackColor = Color.Bisque
        '                Else
        '                    row.DefaultCellStyle.BackColor = Color.Aqua

        '                End If

        '            Next
        '            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        '            bandera = 0

        '            RadioButtonDESCRIPCION.Checked = True
        '    End Select

        '    Dim CantidadArticulos As Integer

        '    CantidadArticulos = DataGridView1.RowCount - 1
        '    '  Label14.Text = CantidadArticulos
        'End If

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

    Private Sub ArticulosGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellContentClick

    End Sub

    Private Sub ArticulosGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ArticulosGridView.CellDoubleClick
        Dim _Articulo As New Articulo
        Dim _ReporteDao As New ReporteDAO

        Dim _fecha_Desde As Date
        Dim _fecha_hasta As Date

        _fecha_Desde = FechaDesde.Value
        _fecha_hasta = FechaHasta.Value


        Try

            _Articulo.CodigoArticulo = ArticulosGridView.CurrentRow.Cells(1).Value
            _ReporteDao.BuscarPrecios(_Articulo, _fecha_Desde, _fecha_hasta)

        Catch ex As Exception

        End Try


    End Sub
End Class