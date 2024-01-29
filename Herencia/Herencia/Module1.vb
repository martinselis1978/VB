Module Module1

    Sub Main()

        Dim banco As New Banco("Banco Santa Fe")

        banco.crearCuentaCliente(New Cliente("Martín", "dni123", "calle 123", "123"), 600)
        banco.crearCuentaCliente(New Cliente("Yanina", "dni456", "calle 456", "456"), 550)

        banco.depositarDineroCuenta(1, 460)
        banco.depositarDineroCuenta(2, 550)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        banco.retirarDineroCuenta(1, 800)
        banco.retirarDineroCuenta(2, 450)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        Dim ca As CuentaAhorro = banco.buscarCuentaCliente("dni123")

        Console.WriteLine("N° de Cuenta: " & ca.getNumeroCuenta)
        Console.WriteLine("Nombre del cliente asociado a la cuenta: " & ca.ClienteCuenta.NombrePersona)

    End Sub

End Module
