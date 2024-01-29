Public Class FrmActualizarAlumno
    Private Sub btnInsertarAlumno_Click(sender As Object, e As EventArgs) Handles btnInsertarAlumno.Click

        Try
            If txtNombreAlumno.Text <> "" And txtApellidoAlumno.Text <> "" And txtEmailAlumno.Text <> "" Then

                Dim la As New LAlumno()

                la.insertarAlumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, txtEmailAlumno.Text)

                limpiarCampos()

            Else

                MsgBox("Faltan datos del alumno")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub limpiarCampos()

        txtNombreAlumno.Clear()
        txtApellidoAlumno.Clear()
        txtEmailAlumno.Clear()

    End Sub

End Class