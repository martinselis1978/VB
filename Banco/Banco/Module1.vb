Imports System.Runtime.Remoting.Channels
Imports System.Security
Imports System.Security.Cryptography
Imports System.Security.Policy

Module Module1

    Sub Main()

        Dim banco As New Banco("Galicia")

        banco.crearCuentaCliente(New Cliente("Martin", "12345678", "Calle 123", "123456"), 1000)

        banco.crearCuentaCliente(New Cliente("Pedro", "24587125", "Calle 1245", "123475"), 1000)

        banco.crearCuentaCliente(New Cliente("Yanina", "57846215", "Calle 123", "2451668"), 1000)

        banco.depositarDineroCuenta(1, 1000)
        banco.retirarDineroCuenta(2, 1000)
        banco.depositarDineroCuenta(3, 500)
        banco.retirarDineroCuenta(3, 500)
        banco.retirarDineroCuenta(3, 500)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))
        Console.WriteLine(banco.getSaldoCuenta(3))


        Console.ReadKey()
    End Sub

End Module
