Module Module1

    Sub Main()

        Dim miLista As New List(Of Integer)

        miLista.Add(8)
        miLista.Add(12)
        miLista.Add(25)
        miLista.Add(40)

        Dim copiaLista() As Integer = miLista.ToArray

        miLista.Clear()

        For Each elemento As Integer In copiaLista

            Console.WriteLine(elemento)

        Next

    End Sub

End Module
