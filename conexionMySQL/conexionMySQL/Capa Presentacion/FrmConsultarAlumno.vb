Public Class FrmConsultarAlumno

    Private Sub btnConsultarConsulta_Click(sender As Object, e As EventArgs) Handles btnConsultarConsulta.Click

        Try

            Dim la As New LAlumno

            Dim dt As DataTable = la.consultarAlumno(txtApellidoConsulta.Text)

            Dim dr As DataRow = dt.Rows.Item(0)

            txtIdConsulta.Text = dr.Item("ID")
            txtNombreConsulta.Text = dr.Item("NOMBRE")
            txtEmailConsulta.Text = dr.Item("EMAIL")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FrmConsultarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtApellidoConsulta.Enabled = False
        txtNombreConsulta.Enabled = False
        txtEmailConsulta.Enabled = False

    End Sub

    Public Sub limpiarCampos()

        txtIdConsulta.Clear()
        txtNombreConsulta.Clear()
        txtApellidoConsulta.Clear()
        txtEmailConsulta.Clear()

    End Sub

    Private Sub btnNuevoConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevoConsulta.Click

        limpiarCampos()

    End Sub

    Private Sub txtIdConsulta_LostFocus(sender As Object, e As EventArgs) Handles txtIdConsulta.LostFocus

    End Sub
End Class