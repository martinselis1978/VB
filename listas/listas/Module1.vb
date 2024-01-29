Module Module1

    Sub Main()

        Dim miLista As New LinkedList(Of Integer)

        miLista.AddFirst(15)
        miLista.AddFirst(New LinkedListNode(Of Integer)(20))
        miLista.AddLast(9)

        'miLista.Remove(20)

        Dim node As LinkedListNode(Of Integer) = miLista.First

        While node IsNot Nothing

            Console.WriteLine(node.Value)

            node = node.Next

        End While

        Console.WriteLine("")

        Dim nodeLast As LinkedListNode(Of Integer) = miLista.Last

        While nodeLast IsNot Nothing

            Console.WriteLine(nodeLast.Value)

            nodeLast = nodeLast.Previous

        End While


        Console.WriteLine("")

        For i = 0 To miLista.Count - 1 Step 1

            Console.WriteLine(miLista(i))

        Next


    End Sub

End Module
