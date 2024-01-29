Public Class FrmEliminarCliente
    Public Sub limpiarCampos()

        txtId.Clear()
        txtApellido.Clear()
        txtEmail.Clear()
        txtNombre.Clear()

    End Sub

    Private Sub txtId_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus

        Try

            Dim la As New LAlumno

            Dim dt As DataTable = la.consultarAlumnoPorId(txtId.Text)

            Dim dr As DataRow = dt.Rows(0)

            txtNombre.Text = dr("NOMBRE")
            txtApellido.Text = dr("APELLIDO")
            txtEmail.Text = dr("EMAIL")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim la As New LAlumno
            la.eliminarAlumno(txtId.Text)

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            limpiarCampos()

        End Try
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class