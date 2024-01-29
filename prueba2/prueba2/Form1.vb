Public Class Form1

    Dim jugador As New List(Of Personas)
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        btnBorrar_Click()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtNombre.Clear()
        txtApellido.Clear()
        txtDescripcion.Clear()

    End Sub
End Class
