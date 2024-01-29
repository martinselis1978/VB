Module Module1

    Sub Main()

        Dim numero As Integer = 5

        cambiarNumVar(numero, 45)

        Console.WriteLine("El valor almacenado es --> " & numero)

    End Sub


    Sub cambiarNumVar(ByRef num As Integer, numNuevo As Integer) 'parametro por referencia (ByRef), y por valor

        num = numNuevo

    End Sub

End Module
