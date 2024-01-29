Module Module1

    Sub Main()
        Try
            Dim nom, id As String
            Dim edad As Integer

            Console.Write("Ingrese el nombre de la personal --> ")
            nom = Console.ReadLine

            Console.Write("Ingrese el DNI de la persona --> ")
            id = Console.ReadLine

            Console.Write("Ingresa la edad de la perosna --> ")
            edad = Console.ReadLine

            Console.WriteLine(nom & ", " & id & ", " & edad)

        Catch ex As InvalidCastException

            Console.WriteLine("Ingreso un dato incorrecto")

        End Try

        'Dim p As New Persona(nom, id, edad)



    End Sub

End Module
