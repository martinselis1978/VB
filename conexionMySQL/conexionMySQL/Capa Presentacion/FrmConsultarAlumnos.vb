Public Class FrmConsultarAlumnos
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try

            Dim la As New LAlumno
            Dim dt As DataTable = la.consultarAlumnos

            dgvConsultar.DataSource = dt

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class