Public Class FrmActualziarAlumno

    Private Sub txtID_LostFocus(sender As Object, e As EventArgs) Handles txtID.LostFocus

        Try

            Dim la As New LAlumno

            Dim dt As DataTable = la.consultarAlumnoPorId(txtID.Text)

            Dim dr As DataRow = dt.Rows(0)

            txtID.Enabled = False
            txtNombre.Text = dr("NOMBRE")
            txtApellido.Text = dr("APELLIDO")
            txtEmail.Text = dr("EMAIL")

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            txtID.Enabled = False

        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim la As New LAlumno

        Try

            la.actualizarAlumno(txtID.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text)

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            limpiarCampos()

        End Try

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        limpiarCampos()

    End Sub

    Public Sub limpiarCampos()

        txtEmail.Clear()
        txtID.Clear()
        txtApellido.Clear()
        txtNombre.Clear()
        txtID.Enabled = True

    End Sub

End Class