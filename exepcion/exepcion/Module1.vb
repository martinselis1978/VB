Module Module1

    Sub Main()


        Dim nom, id As String
        Dim edad As Integer

        Try
            Console.WriteLine("Ingrese el nombre de la persona")
            nom = Console.ReadLine

            Console.WriteLine("Ingrese la identificación de la persona")
            id = Console.ReadLine

            Console.WriteLine("Ingrese la edad de la persona")
            edad = Console.ReadLine

            Dim p As New Persona(nom, id, edad)

            Console.WriteLine(p.nombre & " " & p.id & " " & p.edad)

        Catch ex As InvalidCastException
            Console.WriteLine(ex.Message)
        End Try

    End Sub

End Module
