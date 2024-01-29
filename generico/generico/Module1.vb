Module Module1

    Sub Main()

        Dim general As Object = New Persona("Martin", "123456")

        Dim miPersona As Persona = TryCast(general, Persona)

        Console.WriteLine(miPersona.getNombre & " " & miPersona.getNumId)

        Dim general2 As New Objetos(Of Persona)

        general2.ElObjeto = New Persona("martin", "1234")

        Console.WriteLine(general2.ElObjeto.getNombre)

    End Sub

End Module
