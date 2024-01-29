Module Module1

    Sub Main()

        Dim edades = New Integer() {25, 21, 43, 58, 34}
        Dim edad, indice, contador As Integer
        Dim encontrado As Boolean = False

        Console.Write("Ingrese un número a buscar --> ")
        edad = Console.ReadLine()

        'busca un valor específico en el array
        For i = 0 To edades.Length - 1 And encontrado = False Step 1

            If edad = edades(i) Then

                indice = i
                encontrado = True

            End If

        Next

        If encontrado = True Then

            Console.WriteLine("El valor " & edad & " se halla en la posición " & indice + 1 & " de la base de datos")

        Else

            Console.WriteLine("El valor buscado no se encuentra en la base de datos")
        End If

        'cuenta la cantidad de mayores
        For i = 0 To edades.Length - 1 Step 1

            If edades(i) < edad Then

                contador += 1

            End If

        Next

        Console.WriteLine("La cantidad de valores mayores a " & edad & " años, son " & contador)

        Console.ReadKey()
    End Sub


End Module
