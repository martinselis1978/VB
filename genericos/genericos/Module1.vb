Module Module1

    Sub Main()

        Dim general As Object = New Persona("Maria", "123456") 'creación de un objeto

        Dim miPersona As Persona = TryCast(general, Persona)

        Console.WriteLine(miPersona.getNombre)

        Dim general2 As New Objetos(Of Persona) 'se almacena dentro de objetos sin usar TryCast

        general2.ElObjeto = New Persona("Juan", "456789")

        Console.WriteLine(general2.ElObjeto.getNumId)

    End Sub

End Module
