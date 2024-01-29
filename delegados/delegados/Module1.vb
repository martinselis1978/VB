Module Module1

    Sub Main()

        'Dim persona1 As New Personas("Martin", 44)

        'Dim elObjetoEncargado As elEncargado = New elEncargado(AddressOf persona1.ToString)

        'Console.WriteLine(elObjetoEncargado())


        Dim listaPersona As New List(Of Personas)

        listaPersona.Add(New Personas("Martín", 44))
        listaPersona.Add(New Personas("Yanina", 39))
        listaPersona.Add(New Personas("Bruno", 3))
        listaPersona.Add(New Personas("Salvador", 1))

        'Dim objetoPredicado As New Predicate(Of Personas)(AddressOf menoresTreinta)

        'Aplicación de una funcion LAMBDA function(p) ...
        Dim listaMenoresTreinta As List(Of Personas) = listaPersona.FindAll(Function(p) p.getEdad < 30 Or p.getEdad > 40)

        For i = 0 To listaMenoresTreinta.Count - 1 Step 1

            Console.WriteLine(listaMenoresTreinta(i))

        Next

    End Sub

    'Delegate Function elEncargado()

    'Function menoresTreinta(p As Personas) As Boolean

    '    If p.getEdad < 30 Then

    '        Return True

    '    Else

    '        Return False

    '    End If

    'End Function

End Module
