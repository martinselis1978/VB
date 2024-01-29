Imports MySql.Data.MySqlClient

Public Class Form1

    Private conexion As New MySqlConnection("server=localhost;database=escuela;user=root;password=''")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            conexion.Open()
            MsgBox("La conexión ha sido exitosa.")

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            If conexion.State = ConnectionState.Open Then

                conexion.Close()

            End If

        End Try

    End Sub
End Class
