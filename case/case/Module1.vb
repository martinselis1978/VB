Module Module1

    Sub Main()
        Console.WriteLine("Ingrese 1. Suma, 2. Resta, 3. Multiplicar, 4. Dividir y 5. Promedio")
        Dim opcion As Integer = Console.ReadLine()
        Console.WriteLine()

        Dim num1, num2 As Double
        Console.Write("Ingrese un valor --> ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese otro valor --> ")
        num2 = Console.ReadLine()
        Console.WriteLine()

        Select Case opcion
            Case 1

                Console.WriteLine("El valor de la suma es: " & num1 + num2)

            Case 2

                Console.WriteLine("El valor de la resta es: " & num1 - num2)

            Case 3

                Console.WriteLine("El valor de la multiplicación es: " & num1 * num2)

            Case 4

                Console.WriteLine("El valor de la división es: " & num1 / num2)

            Case 5

                Console.WriteLine("El promedio de " & num1 & " y " & num2 & " es: " & (num1 + num2) / 2)

            Case Else

                Console.WriteLine("El valor ingresado no corresponde a ninguna operación")

        End Select
        Console.ReadKey()
    End Sub

End Module
