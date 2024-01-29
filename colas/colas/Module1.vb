Module Module1

    Sub Main()

        Dim cola As New Queue(Of Integer)

        cola.Enqueue(10)
        cola.Enqueue(35)
        cola.Enqueue(84)
        cola.Enqueue(24)

        'muestra el primer elemento ingresado sin eliminarlo
        Console.WriteLine(cola.Peek)

        'de esta forma no elimina los elementos
        For Each num As Integer In cola

            Console.WriteLine(num)

        Next

        'de esta forma los elimina
        For i = 0 To cola.Count - 1 Step 1

            Console.WriteLine(cola.Dequeue)

        Next

    End Sub

End Module
