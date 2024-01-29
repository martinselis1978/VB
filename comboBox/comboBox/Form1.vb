Public Class Form1

    Dim listaPersona As New List(Of Persona)
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtNombre.Text <> "" And txtID.Text <> "" And txtTelefono.Text <> "" And txtEmail.Text <> "" Then

            Dim p As New Persona(txtNombre.Text, txtID.Text, txtTelefono.Text, txtEmail.Text)

            listaPersona.Add(p)

            cmbPersonas.Items.Add(txtID.Text)

            txtNombre.Clear()
            txtID.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()

        Else

            MsgBox("Faltan ingresar Datos")

        End If

    End Sub

    Private Sub cmbPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonas.SelectedIndexChanged

        Dim numIdPersona As String = cmbPersonas.SelectedItem.ToString

        For i = 0 To listaPersona.Count - 1 Step 1

            If numIdPersona.Equals(listaPersona.Item(i).IdPersona) Then

                MsgBox(listaPersona.Item(i).toString)

                Exit For

            End If

        Next

    End Sub
End Class
