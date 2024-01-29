Module Module1

    Sub Main()

        'el último elemento que se inserto es el primero en mostrarse
        Dim pila As New Stack(Of Integer)

        pila.Push(10)
        pila.Push(35)
        pila.Push(84)
        pila.Push(24)

        'sin borrar los elementos
        For Each num As Integer In pila

            Console.WriteLine(num)

        Next

        Console.WriteLine("")

        'eliminar un elemnto de la pila, siempre va a eliminar el último número
        pila.Pop() ' elimina el 24

        'esta función elimina a todos los elementos
        While pila.Count <> 0

            Console.WriteLine(pila.Pop)

        End While


    End Sub

End Module
