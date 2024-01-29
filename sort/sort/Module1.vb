Module Module1

    Sub Main()

        Dim numeros = New Integer() {10, 8, 23, 5, 7}

        Array.Sort(numeros)

        For Each num As Integer In numeros

            Console.Write(num & "")

        Next

        Console.WriteLine("")
        Console.WriteLine(numeros(4))

    End Sub

End Module
