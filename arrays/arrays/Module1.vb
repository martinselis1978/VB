Imports System.Globalization

Module Module1

    Sub Main()

        'Dim nombres = New String() {"Martin", "Yanina", "Bruno", "Salvador", "Lola", "Keko"}

        Dim nombres(6) As String

        For i = 0 To nombres.Length - 2 Step 1

            Console.Write("Ingrese un nombre de la posición " & i + 1 & " --> ")
            nombres(i) = Console.ReadLine()

        Next

        Console.WriteLine()

        For Each nom As String In nombres

            Console.WriteLine(nom)

        Next

        Console.ReadKey()
    End Sub

End Module
