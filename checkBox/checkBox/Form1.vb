Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Dim puntos As Double = 0

        If chClase.Checked = True Then
            puntos += 2.5
        End If

        If chObjeto.Checked = True Then
            puntos += 2.5
        End If

        If chHerencia.Checked = True Then
            puntos += 2.5
        End If

        If chPolimorfismo.Checked = True Then
            puntos += 2.5
        End If

        If chBucle.Checked = True Then
            puntos -= 2.5
        End If

        If puntos >= 0 Then
            MsgBox("El total de puntos obtenidos es: " & puntos)
        Else
            MsgBox("El total de puntos obtenidos es: " & "0")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'esto hace que aparezca activada la pestaña de polimorfismo
        chPolimorfismo.Checked = True

    End Sub
End Class
