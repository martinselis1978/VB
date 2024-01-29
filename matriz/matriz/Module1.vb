Module Module1

    Sub Main()

        '------ Diferentes formas de ingresar una matriz ------

        'Dim num(2,3) as Integer
        'Dim num = New Integer(,) {{1, 2, 3}, {1, 2, 3}} ' habrá dos filas con tres columnas

        Dim num(2, 3) As Integer

        For i = 0 To 1 Step 1 'creación de 2 filas

            For j = 0 To 2 Step 1 'creación de 3 columnas

                Console.Write("Ingrese el número a almacenar en la posición [fila,columna] [" & i + 1 & "," & j + 1 & "] --> ")
                num(i, j) = Console.ReadLine

            Next

        Next

        For i = 0 To 1 Step 1

            Console.WriteLine()

            For j = 0 To 2 Step 1

                Console.Write(num(i, j) & " ")

            Next
        Next

        Console.WriteLine()

        'mostrando con la variante for each, que recorre toda la variable
        'lo curioso es que aparecen muchos ceros
        For Each matriz As Integer In num

            Console.WriteLine(matriz)

        Next

        'otra forma que devuelve un valor específico con getUpperBound
        For i = 0 To num.GetUpperBound(0) - 1 Step 1

            For j = 0 To num.GetUpperBound(1) - 1 Step 1

                Console.WriteLine(num(i, j))

            Next

        Next

        Console.ReadKey()
    End Sub

End Module
