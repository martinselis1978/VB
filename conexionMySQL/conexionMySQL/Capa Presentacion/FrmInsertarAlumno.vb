Public Class FrmInsertarAlumno

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try

            Dim la As New LAlumno
            la.insertarAlumno(txtNombre.Text, txtApellido.Text, txtEmail.Text)
            limpiarCampos()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub limpiarCampos()

        txtNombre.Clear()
        txtApellido.Clear()
        txtEmail.Clear()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        limpiarCampos()

    End Sub
End Class