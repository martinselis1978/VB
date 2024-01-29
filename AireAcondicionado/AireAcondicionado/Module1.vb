Module Module1

    Sub Main()

        Dim aire As New AireAcondicionado("BGH", "Blanco", 220, 12000, AireAcondicionado.tAireAcondicionado.Split)

        Console.WriteLine(aire.TipoAA & " " & aire.ModeloAA)

    End Sub

End Module
