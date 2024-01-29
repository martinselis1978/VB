Public Class Form1

    Dim num1, num2 As Integer

    Private Sub btnIngresarNumero_Click(sender As Object, e As EventArgs) Handles btnIngresarNumero.Click

        num1 = Integer.Parse(InputBox("Ingresar el primer número", "Ingresar un número", "", 700, 300))
        num2 = Integer.Parse(InputBox("Ingresar el segundo número", "Ingresar un número", "", 700, 300))

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim resultado As Integer = num1 + num2

        txtResultado.Text = resultado

    End Sub
End Class
