Module Module1

    Sub Main()

        Dim matrizOrigen = New Integer(,) {{14, 28}, {56, 70}}

        Dim matrizCopia(1, 1) As Integer

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                matrizCopia(i, j) = matrizOrigen(i, j)

            Next

        Next

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                Console.Write(matrizCopia(i, j) & " ")

            Next

        Next

        Console.ReadKey()
    End Sub

End Module
