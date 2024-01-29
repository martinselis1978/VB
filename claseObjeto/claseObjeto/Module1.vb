Module Module1

    Sub Main()

        Dim miObjeto As New Object

        miObjeto = New Persona("Martin", 44)

        Dim miPersona As Persona = TryCast(miObjeto, Persona)

        Console.WriteLine(miPersona.getEdad)


    End Sub

End Module
