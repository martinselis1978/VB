Module Module1

    Sub Main()

        Console.Write("Ingrese un número --> ")
        Dim num = Console.ReadLine()

        Dim sumNum As Integer = 0

        While num > 0

            sumNum = sumNum + num Mod 10

            num = Math.Truncate(num / 10)

        End While

        Console.WriteLine("La suma de los dígitos es --> " & sumNum)
        Console.ReadKey()

    End Sub

End Module
