Module Module1

    Sub Main()

        Dim cliente1 As Cliente = New Cliente("Martin", "123", "falsa", "33333")
        Dim cuenta1 As New CuentaAhorro(cliente1, 250)

        Console.WriteLine(cuenta1.getSaldo())

        cuenta1.depositarDinero(350)

        Console.WriteLine(cuenta1.getSaldo())

        cuenta1.retirarDinero(500)

        Console.WriteLine(cuenta1.getSaldo())

        Console.WriteLine(cuenta1.ClienteCuenta.NombreCliente())


    End Sub

End Module
