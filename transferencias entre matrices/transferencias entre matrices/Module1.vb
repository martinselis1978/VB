Module Module1

    Sub Main()

        Dim numeros = New Integer() {14, 28, 56}

        Dim arrayCopia(2) As Integer

        For i = 0 To 2 Step 1

            arrayCopia(i) = numeros(i)

        Next

        Console.WriteLine(arrayCopia.Length)

        For i = 0 To arrayCopia.Length - 1 Step 1

            Console.Write(arrayCopia(i) & " ")

        Next

        Console.ReadKey()
    End Sub

End Module
