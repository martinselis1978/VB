Public Class Form1

    Dim num1 As String
    Dim num2 As Integer

    Private Sub btnIngresarNumero_Click(sender As Object, e As EventArgs) Handles btnIngresarNumero.Click

        num1 = Integer.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer número", "Suma de dos números", "0", 700, 300))
        num2 = Integer.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo número", "Suma de dos números", "0", 700, 300))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim resultado As Integer = num1 + num2

        txtresultado.Text = resultado.ToString


    End Sub
End Class
