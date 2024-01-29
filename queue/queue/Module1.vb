Module Module1

    Sub Main()

        Dim cola As New Queue(Of Integer)

        cola.Enqueue(10)
        cola.Enqueue(35)
        cola.Enqueue(84)
        cola.Enqueue(24)

        Console.WriteLine(cola.Peek) 'el primer numero sin eliminarlo

    End Sub

End Module
