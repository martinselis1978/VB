Module Module1

    Sub Main()

        Dim sams As AireAcondicionado = New AireAcondicionado()

        Console.WriteLine(sams.ModeloAire)

        Console.WriteLine(sams.TemperaturaAire)

        sams.subirTemperatura(10)

        Console.WriteLine(sams.TemperaturaAire)

        sams.bajarTemperatura(5)

        Console.WriteLine(sams.TemperaturaAire)



    End Sub

End Module
