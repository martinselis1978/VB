Module Module1

    Sub Main()

        Dim estudio As Boolean = False

        Console.Write("Ingrese su dinero ahorrado --> ")
        Dim dineroAhorrado As Double = Console.ReadLine()

        If dineroAhorrado > 600 Then
            estudio = True
            Console.WriteLine("El dinero es suficiente para estudiar")
        Else
            Console.WriteLine("El dinero no es suficiente para estudiar")
        End If
        Console.ReadKey()

    End Sub

End Module
