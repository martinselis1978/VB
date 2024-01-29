Module Module1

    Sub Main()


        Dim pila As New Stack(Of Integer)

        pila.Push(10)
        pila.Push(20)
        pila.Push(34)
        pila.Push(9)

        pila.Pop()
        pila.Pop()

        For Each aux As Integer In pila
            Console.WriteLine(aux)
        Next



    End Sub

End Module
