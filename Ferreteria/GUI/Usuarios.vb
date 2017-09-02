Imports SL
Imports DAL



Public Class Usuarios
    Public B As Integer = 0

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ico


        Dim ListaPalabras As New List(Of SL.PalabrasIdioma)

        Dim Multiidioma As New SL.Multiidioma



        If Principal.CulturaGlobal = "ESPAÑOL" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ES-ESP")


            Dim Cultura = "ES-ESP"
            'LINQ para el multiidioma
            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            LabelUsuarios.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            LabelPosee.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "POSEE" Select V.Value).FirstOrDefault
            LabelNoPosee.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NOPOSEE" Select V.Value).FirstOrDefault
            RegistrarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REGISTRAR" Select V.Value).FirstOrDefault
            LabelPermisos.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PERMISOS" Select V.Value).FirstOrDefault


        End If

        If Principal.CulturaGlobal = "ENGLISH" Then
            ListaPalabras = Multiidioma.ObtenerPalabras("ENG-ENGLAND")


            Dim Cultura = "ENG-ENGLAND"
            'LINQ para el multiidioma
            Me.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            LabelUsuarios.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "USUARIO" Select V.Value).FirstOrDefault
            LabelPosee.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "POSEE" Select V.Value).FirstOrDefault
            LabelNoPosee.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "NOPOSEE" Select V.Value).FirstOrDefault
            RegistrarButton.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "REGISTRAR" Select V.Value).FirstOrDefault
            LabelPermisos.Text = (From V In ListaPalabras Where V.Cultura = Cultura And V.Key = "PERMISOS" Select V.Value).FirstOrDefault




        End If



        Dim _UsuarioDao As New UsuarioDAO
        Dim _Usuario As New Usuario


        UsuarioComboBox.DataSource = _UsuarioDao.ObtenerUsuarios
        UsuarioComboBox.DisplayMember = "Nombre"
        UsuarioComboBox.ValueMember = "IdUsuario"



        UsuarioComboBox.SelectedIndex = 0


        _Usuario.IdUsuario = UsuarioComboBox.SelectedValue

        PoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesDeUsuarioDT(_Usuario)
        PoseeListBox.DisplayMember = "Nombre"
        PoseeListBox.ValueMember = "IdPatente"

        NoPoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesNoAasignadas(_Usuario)
        NoPoseeListBox.DisplayMember = "Nombre"
        NoPoseeListBox.ValueMember = "IdPatente"
        B = 1

    End Sub

    Private Sub UsuarioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsuarioComboBox.SelectedIndexChanged

        Dim _UsuarioDao As New UsuarioDAO
        Dim _Usuario As New Usuario

        If B = 1 Then
            _Usuario.IdUsuario = UsuarioComboBox.SelectedValue

            PoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesDeUsuarioDT(_Usuario)
            PoseeListBox.DisplayMember = "Nombre"
            PoseeListBox.ValueMember = "IdPatente"


            NoPoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesNoAasignadas(_Usuario)
            NoPoseeListBox.DisplayMember = "Nombre"
            NoPoseeListBox.ValueMember = "IdPatente"
        End If
     




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonNoPosee.Click

        If Not (Me.NoPoseeListBox.SelectedValue Is Nothing) Then
            Me.RegistrarButton.Enabled = True

            Dim dtNoposeePAT As DataTable = Me.NoPoseeListBox.DataSource
            Dim dtposeePAT As DataTable = Me.PoseeListBox.DataSource
            Dim listaPatentesNoPosee As New List(Of Patente)

            For Each drpat As DataRow In dtNoposeePAT.Rows
                If (Me.NoPoseeListBox.SelectedValue = drpat(0)) Then

                    Dim pat As New Patente
                    pat.IdPatente = drpat(0)
                    pat.Nombre = drpat(1)

                    listaPatentesPosee.Add(pat)


                    Dim drposePat As DataRow = dtposeePAT.NewRow
                    drposePat(0) = drpat(0)
                    drposePat(1) = drpat(1)
                    dtposeePAT.Rows.Add(drposePat)
                Else
                    Dim pat As New Patente
                    pat.IdPatente = drpat(0)
                    pat.Nombre = drpat(1)
                    listaPatentesNoPosee.Add(pat)
                End If

            Next
            'refresco el no pose con la lista de patentes que no posee
            Dim nwdtNoPoseePAT As New DataTable
            nwdtNoPoseePAT.Columns.Add("IdPatente")
            nwdtNoPoseePAT.Columns.Add("Nombre")
            For Each idi As Patente In listaPatentesNoPosee
                Dim drNoPoseePAT As DataRow = nwdtNoPoseePAT.NewRow()
                drNoPoseePAT(0) = idi.IdPatente
                drNoPoseePAT(1) = idi.Nombre
                nwdtNoPoseePAT.Rows.Add(drNoPoseePAT)
            Next
            Me.NoPoseeListBox.DataSource = nwdtNoPoseePAT
            Me.NoPoseeListBox.ValueMember = "IdPatente"
            Me.NoPoseeListBox.DisplayMember = "Nombre"

            Me.PoseeListBox.DataSource = dtposeePAT
            Me.PoseeListBox.ValueMember = "IdPatente"
            Me.PoseeListBox.DisplayMember = "Nombre"

        End If



    End Sub
    Public listaPatentesPosee As New List(Of Patente)
    Private Sub ButtonPosee_Click(sender As Object, e As EventArgs) Handles ButtonPosee.Click

        Dim _Convertir As New Convertir
        Dim valor As Integer = PoseeListBox.SelectedValue


        'Me.LstPoseePAT.Items.Add(LstNoPoseePAT.SelectedItem)
        If Not (Me.PoseeListBox.SelectedValue Is Nothing) Then
            Me.RegistrarButton.Enabled = True

            listaPatentesPosee.Clear()

            Dim dtposeePAT As DataTable = Me.PoseeListBox.DataSource
            Dim dtNoposeePAT As DataTable = Me.NoPoseeListBox.DataSource
            'Dim listaPatentesPosee As New List(Of Patente)


            For Each drpat As DataRow In dtposeePAT.Rows
                If (Me.PoseeListBox.SelectedValue = drpat(0)) Then
                    'seleccionado lo cargo al listado no disponible
                    Dim drNoposePat As DataRow = dtNoposeePAT.NewRow
                    drNoposePat(0) = drpat(0)
                    drNoposePat(1) = drpat(1)
                    dtNoposeePAT.Rows.Add(drNoposePat)
                Else
                    'no seleccionado lo cargo a las que posee
                    Dim pat As New Patente
                    pat.IdPatente = drpat(0)
                    pat.Nombre = drpat(1)

                    listaPatentesPosee.Add(pat)
                End If
            Next

            'refresco el posee con la lista de patentes que no posee
            Dim nwdtPoseePAT As New DataTable
            nwdtPoseePAT.Columns.Add("IdPatente")
            nwdtPoseePAT.Columns.Add("Nombre")
            For Each idi As Patente In listaPatentesPosee
                Dim drPoseePAT As DataRow = nwdtPoseePAT.NewRow()
                drPoseePAT(0) = idi.IdPatente
                drPoseePAT(1) = idi.Nombre
                nwdtPoseePAT.Rows.Add(drPoseePAT)
            Next
            Me.PoseeListBox.DataSource = nwdtPoseePAT
            Me.PoseeListBox.ValueMember = "IdPatente"
            Me.PoseeListBox.DisplayMember = "Nombre"

        End If

    End Sub

    Private Sub RegistrarButton_Click(sender As Object, e As EventArgs) Handles RegistrarButton.Click


        Dim _DataTablePosee As New DataTable
        Dim _Convertir As New Convertir
        Dim _ListaPatentes As New List(Of Patente)
        Dim _GestorUsuario As New GestorUsuario
        Dim _Usuario As New Usuario


        Try

            _Usuario.IdUsuario = UsuarioComboBox.SelectedValue

            '_DataTablePosee = PoseeListBox.DataSource

            '_ListaPatentes = _Convertir.DataTableToList(Of Patente)(_DataTablePosee)


            _GestorUsuario.ActualizarPatentesBLL(listaPatentesPosee, _Usuario)


            Dim el As New EventLogger

            el.WriteToErrorLog("Se modificaron correctamente las patentes del usuario " & UsuarioComboBox.SelectedText, "Usuarios Form", "Información")


            If Principal.CulturaGlobal = "ES-ESP" Then
                Dim Mensaje = MsgBox("Se modificaron correctamente las patentes del usuario " & UsuarioComboBox.SelectedText, MsgBoxStyle.Information, "ATENCÓN")
            Else

                Dim Mensaje = MsgBox("User patents were correctly modified " & UsuarioComboBox.SelectedText, MsgBoxStyle.Information, "ATTENTION")

            End If




        Catch ex As Exception


            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try


    End Sub
End Class