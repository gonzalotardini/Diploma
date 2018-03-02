﻿Imports BIZ
Imports DAL
Imports BLL
Imports SL



Public Class ClienteForm






    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Icon = My.Resources.ico
        Me.WindowState = FormWindowState.Maximized 'Maximizar Ventana al Abrir

        AceptarButton.Enabled = False


        Dim _ClienteDAO As New ClienteDAO
        Dim _BarrioDAO As New BarrioDAO


        ClienteGridView.DataSource = _ClienteDAO.ObtenerClientesDao
        ClienteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


        BarrioComboBox.DataSource = _BarrioDAO.ObtenerBarrios
        BarrioComboBox.DisplayMember = "Descripcion"
        BarrioComboBox.ValueMember = "Cod_Barrio"


        RazonSocialRadioButton.Checked = True



        For Each row As DataGridViewRow In ClienteGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next

    End Sub

    Private Sub ClienteGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteGridView.CellContentClick

    End Sub

    Private Sub ClienteGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteGridView.CellContentDoubleClick

        ' Dim _CodigoCliente As Integer
        ' Dim _RazonSocial As String

        Dim _Cliente As New Cliente


        If NuevoPresupuestoForm.Visible = True Then



            NuevoPresupuestoForm._CodigoCliente = ClienteGridView.CurrentRow.Cells(0).Value
            NuevoPresupuestoForm._RazonSocial = ClienteGridView.CurrentRow.Cells(1).Value
            NuevoPresupuestoForm._Cuit = ClienteGridView.CurrentRow.Cells(2).Value

            NuevoPresupuestoForm.TraerCliente(NuevoPresupuestoForm._CodigoCliente, NuevoPresupuestoForm._RazonSocial, NuevoPresupuestoForm._Cuit)


            Me.Close()
        End If


        If NuevaVentaForm.Visible = True Then



            NuevaVentaForm._CodigoCliente = ClienteGridView.CurrentRow.Cells(0).Value
            NuevaVentaForm._RazonSocial = ClienteGridView.CurrentRow.Cells(1).Value
            NuevaVentaForm._Cuit = ClienteGridView.CurrentRow.Cells(2).Value

            NuevaVentaForm.TraerCliente(NuevaVentaForm._CodigoCliente, NuevaVentaForm._RazonSocial, NuevaVentaForm._Cuit)


            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AgregarClienteButton.Click


        Dim _Cliente As New Cliente
        Dim _GestorCLiente As New GestorCliente

        Try

            _Cliente.RazonSocial = (RazonSocialTextBox.Text).ToUpper

            If IsNumeric(CuitTextBox.Text) = False Then
                Throw New Exception("Error revise Cuit del cliente")
            Else

                _Cliente.Cuit = Convert.ToInt64(CuitTextBox.Text)

            End If


            _Cliente.Direccion = (DireccionTextBox.Text).ToUpper


            If BarrioComboBox.SelectedIndex = -1 Then

                Throw New Exception("Error, debe seleccionar un barrio")
            Else
                _Cliente.Barrio = BarrioComboBox.SelectedValue

            End If




            If IsNumeric(CuitTextBox.Text) = False Then

                Throw New Exception("Error, Telefono debe ser numérico")
            Else
                _Cliente.Telefono = Convert.ToInt64(TelefonoTextBox.Text)


            End If



            _Cliente.Email = (EmailTextBox.Text).ToUpper






            _GestorCLiente.ValidarClienteBLL(_Cliente)


            Dim el As New EventLogger

            el.WriteToErrorLog("Se agregó correctamente el artículo " & _Cliente.RazonSocial, "Articulo Form", "Información")

            Dim Mensaje = MsgBox("Se agregó correctamente el articulo " & _Cliente.RazonSocial, MsgBoxStyle.Information, "ATENCÓN")


        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try





    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuscarTextBox.TextChanged

    End Sub

    Private Sub ModificarButton_Click_1(sender As Object, e As EventArgs) Handles ModificarButton.Click


        Dim _Cliente As New Cliente
        Dim _ClienteDAO As New ClienteDAO
        Dim _BarrioDao As New BarrioDAO





        If ClienteGridView.CurrentRow IsNot Nothing Then



            _Cliente.CodigoCliente = ClienteGridView.CurrentRow.Cells(0).Value

            _Cliente = _ClienteDAO.ObtenerUnClientePorCodigo(_Cliente)

   


            RazonSocialTextBox.Text = _Cliente.RazonSocial
            CuitTextBox.Text = _Cliente.Cuit
            DireccionTextBox.Text = _Cliente.Direccion




            BarrioComboBox.SelectedValue = _Cliente.Barrio


            TelefonoTextBox.Text = _Cliente.Telefono


            EmailTextBox.Text = _Cliente.Email

            LabelCodigoCliente.Text = _Cliente.CodigoCliente







        End If



        AgregarClienteButton.Enabled = False

        AceptarButton.Enabled = True


    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click


      

        Dim _ClienteDao As New ClienteDAO
        Dim _Cliente As New Cliente
        Dim _GestorCLiente As New GestorCliente

        Try

            _Cliente.RazonSocial = (RazonSocialTextBox.Text).ToUpper

            If IsNumeric(CuitTextBox.Text) = False Then
                Throw New Exception("Error revise Cuit del cliente")
            Else

                _Cliente.Cuit = Convert.ToInt64(CuitTextBox.Text)

            End If


            _Cliente.Direccion = (DireccionTextBox.Text).ToUpper


            If BarrioComboBox.SelectedIndex = -1 Then

                Throw New Exception("Error, debe seleccionar un barrio")
            Else
                _Cliente.Barrio = BarrioComboBox.SelectedValue

            End If




            If IsNumeric(TelefonoTextBox.Text) = False Then

                Throw New Exception("Error, Telefono debe ser numérico")
            Else
                _Cliente.Telefono = (TelefonoTextBox.Text)


            End If


            If EmailTextBox.Text = "" Then

                Throw New Exception("Error, complete email")
            Else
                _Cliente.Email = (EmailTextBox.Text).ToUpper
            End If

            _Cliente.CodigoCliente = Convert.ToInt64(LabelCodigoCliente.Text)






            _GestorCLiente.ValidarClienteActualizacionBLL(_Cliente)


            Dim el As New EventLogger

            el.WriteToErrorLog("Se Actualizo correctamente el Cliente " & _Cliente.RazonSocial, "Articulo Form", "Información")

            Dim Mensaje = MsgBox("Se actualizo correctamente el cliente " & _Cliente.RazonSocial, MsgBoxStyle.Information, "ATENCÓN")


        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try





        AceptarButton.Enabled = False
        AgregarClienteButton.Enabled = True


        ClienteGridView.DataSource = _ClienteDao.ObtenerClientesDao



        LabelCodigoCliente.Text = ""
        RazonSocialTextBox.Text = ""
        CuitTextBox.Text = ""
        DireccionTextBox.Text = ""
        TelefonoTextBox.Text = ""
        EmailTextBox.Text = ""



        For Each row As DataGridViewRow In ClienteGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
                ' row.Cells("Descripcion").Style.Font.Bold = True

            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next


    End Sub

    Private Sub BuscarTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BuscarTextBox.KeyDown

        Dim bandera As Integer = 0

        If CuitRadioButton.Checked = True Then

            Dim cliente As New Cliente
            Dim ClienteBll As New GestorCliente

            Select Case e.KeyData
                Case Keys.Enter
                    Dim EsNumero As Boolean

                    EsNumero = IsNumeric(BuscarTextBox.Text)

                    If BuscarTextBox.Text <> "" And EsNumero = True And ((Len(BuscarTextBox.Text)) < 16) Then  'valido para que no ejectue la funcion si no hay caracteres
                        cliente.Cuit = Convert.ToInt64(BuscarTextBox.Text)
                        ClienteGridView.DataSource = ClienteBll.BuscarClientePorCuitBll(cliente)

                        BuscarTextBox.SelectAll()

                        For Each row As DataGridViewRow In ClienteGridView.Rows

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

        If RazonSocialRadioButton.Checked = True Or bandera = 1 Then

            Dim _Cliente As New Cliente
            Dim _GestorCliente As New GestorCliente

            Select Case e.KeyData

                Case Keys.Enter





                    _Cliente.RazonSocial = (BuscarTextBox.Text).ToUpper
                    ClienteGridView.DataSource = _GestorCliente.BuscarClientePorRazonSocialBLL(_Cliente)



                    For Each row As DataGridViewRow In ClienteGridView.Rows

                        If row.Index Mod 2 <> 0 Then
                            row.DefaultCellStyle.BackColor = Color.Bisque
                        Else
                            row.DefaultCellStyle.BackColor = Color.Aqua

                        End If

                    Next


                    bandera = 0

                    RazonSocialRadioButton.Checked = True
            End Select

            'Dim CantidadArticulos As Integer

            'CantidadArticulos = DataGridView1.RowCount - 1
            'Label14.Text = CantidadArticulos
        End If



    End Sub

    Private Sub ClienteGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ClienteGridView.ColumnHeaderMouseClick
        For Each row As DataGridViewRow In ClienteGridView.Rows

            If row.Index Mod 2 <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Bisque
            Else
                row.DefaultCellStyle.BackColor = Color.Aqua

            End If

        Next
    End Sub
End Class