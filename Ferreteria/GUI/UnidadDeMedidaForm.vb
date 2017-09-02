Imports DAL
Imports BIZ
Imports SL

Public Class UnidadDeMedidaForm
    Private UnidadMedida As New UnidadDeMedida


    Private Sub UnidadDeMedidaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _UnidadDeMedidaDao As New UnidadDeMedidaDao

        DataGridViewX1.DataSource = _UnidadDeMedidaDao.ObtenerUnidadesMedida

        AceptarButton.Enabled = False







    End Sub

    Private Sub ModificarButton_Click(sender As Object, e As EventArgs) Handles ModificarButton.Click







        If DataGridViewX1.CurrentRow.Cells(0).Value() IsNot Nothing Then

            UnidadMedida.CodUnidadMedida = DataGridViewX1.CurrentRow.Cells(0).Value()
            UnidadMedida.DescripcionUnidadMedida = DataGridViewX1.CurrentRow.Cells(1).Value

            TextBoxX1.Text = UnidadMedida.DescripcionUnidadMedida

            AgregarButton.Enabled = False
            AceptarButton.Enabled = True

        Else

            Throw New Exception("Seleccione Unidad de medida")

        End If

    End Sub



    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click

        Dim _UnidadMedidaDao As New UnidadDeMedidaDao

        Try


            If TextBoxX1.Text <> "" And TextBoxX1.Text <> " " Then

                Try

                    UnidadMedida.DescripcionUnidadMedida = (TextBoxX1.Text).ToUpper
                    _UnidadMedidaDao.CargarUnidadDeMedida(UnidadMedida)

                    Dim el As New EventLogger

                    el.WriteToErrorLog("Se agregó correctamente la unidad de medida " & UnidadMedida.DescripcionUnidadMedida, "UnidadMedida form", "Información")

                    Dim Mensaje = MsgBox("Se agregó correctamente la unidad de medida " & UnidadMedida.DescripcionUnidadMedida, MsgBoxStyle.Information, "ATENCÓN")




                Catch ex As Exception



                    If Principal.CulturaGlobal = "ESPAÑOL" Then

                        Throw New Exception("ERROR" & ex.Message)
                    Else

                        Throw New Exception("ERROR" & ex.Message)

                    End If




                End Try



            Else


                If Principal.CulturaGlobal = "ESPAÑOL" Then

                    Throw New Exception("Revise datos ingresados")
                Else



                    Throw New Exception("Check Input Data")

                End If

            End If


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")

        End Try











    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click


        Dim _UnidadMedidaDao As New UnidadDeMedidaDao






        Try
            If TextBoxX1.Text <> "" And TextBoxX1.Text <> " " Then

                UnidadMedida.DescripcionUnidadMedida = (TextBoxX1.Text).ToUpper
                _UnidadMedidaDao.ActualizarUnidadDeMedida(UnidadMedida)



                Dim el As New EventLogger

                el.WriteToErrorLog("Se actualizó correctamente la unidad de medida " & UnidadMedida.DescripcionUnidadMedida, "UnidadMedida form", "Información")

                If Principal.CulturaGlobal = "ESPAÑOL" Then

                    Dim Mensaje = MsgBox("Se agregó correctamente la unidad de medida " & UnidadMedida.DescripcionUnidadMedida, MsgBoxStyle.Information, "ATENCÓN")

                Else

                    Dim Mensaje = MsgBox("Updated Correctly " & UnidadMedida.DescripcionUnidadMedida, MsgBoxStyle.Information, "ATTENTION")

                End If


                AceptarButton.Enabled = False
                AgregarButton.Enabled = True
                TextBoxX1.Text = ""



            Else

                If Principal.CulturaGlobal = "ESPAÑOL" Then

                    Throw New Exception("Chequeat datos ingresados")

                Else

                    Throw New Exception("Check input data")

                End If

            End If


        Catch ex As Exception

            Dim el As New ErrorLogger
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            el.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")


        End Try






    End Sub
End Class