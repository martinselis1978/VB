Public Class Form1

    Private count As Integer
    Private num(10) As Integer

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click
        num(count) = count
        count += 1
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim res As Integer
        For Each aux As Integer In num
            res += aux
        Next
        lblResultado.Text = res
    End Sub
End Class
