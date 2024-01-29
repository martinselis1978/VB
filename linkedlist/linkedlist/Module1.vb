Module Module1

    Sub Main()

        Dim miLista As New LinkedList(Of Integer)

        miLista.AddFirst(15)
        miLista.AddFirst(New LinkedListNode(Of Integer)(20))
        miLista.AddLast(9)

        miLista.RemoveFirst()

        Dim nodo As LinkedListNode(Of Integer) = miLista.First


        For Each aux As Integer In miLista
            Console.WriteLine(aux)
        Next

    End Sub

End Module
