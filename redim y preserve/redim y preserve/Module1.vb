Imports System.Runtime.InteropServices

Module Module1

    Sub Main()

        Dim numeros = New Integer() {1, 2, 3, 4}
        Dim matriz = New Integer(,) {{1, 2}, {3, 4}}

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

        ReDim Preserve numeros(5)

        numeros(4) = 5
        numeros(5) = 6

        Console.WriteLine()
        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

        'modificción de la matriz --- no se puede utilizar el presereve --- por lo que cuando se
        'redimenciona con reDim una matriz esta se borra
        ReDim matriz(3, 3)


        Console.ReadKey()
    End Sub

End Module
