Imports SL



Public Class Usuarios
    Public B As Integer = 0

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _UsuarioDao As New UsuarioDAO
        Dim _Usuario As New Usuario


        UsuarioComboBox.DataSource = _UsuarioDao.ObtenerUsuarios
        UsuarioComboBox.DisplayMember = "Nombre"
        UsuarioComboBox.ValueMember = "IdUsuario"


        UsuarioComboBox.SelectedItem = 1

        _Usuario.IdUsuario = UsuarioComboBox.SelectedValue

        PoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesDeUsuarioDT(_Usuario)
        PoseeListBox.DisplayMember = "Nombre"


        NoPoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesNoAasignadas(_Usuario)
        NoPoseeListBox.DisplayMember = "Nombre"

        B = 1

    End Sub

    Private Sub UsuarioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsuarioComboBox.SelectedIndexChanged

        Dim _UsuarioDao As New UsuarioDAO
        Dim _Usuario As New Usuario

        If B = 1 Then
            _Usuario.IdUsuario = UsuarioComboBox.SelectedValue

            PoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesDeUsuarioDT(_Usuario)
            PoseeListBox.DisplayMember = "Nombre"


            NoPoseeListBox.DataSource = _UsuarioDao.ObtenerPatentesNoAasignadas(_Usuario)
            NoPoseeListBox.DisplayMember = "Nombre"
        End If
     




    End Sub
End Class