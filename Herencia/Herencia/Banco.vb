Public Class Banco

    Private nomBanco As String
    Private cuentas() As CuentaAhorro

    Public Sub New(nomB As String)

        nomBanco = nomB
        cuentas = New CuentaAhorro(20) {}

    End Sub

    Public Sub crearCuentaCliente(cl As Cliente, saldo As Double)

        For i = 0 To cuentas.Length - 1 Step 1

            If cuentas(i) Is Nothing Then

                cuentas(i) = New CuentaAhorro(cl, saldo)

                Exit For
            End If

        Next

    End Sub

    Public Sub depositarDineroCuenta(numCuenta As Integer, valor As Double)

        cuentas(numCuenta - 1).depositarDinero(valor)

    End Sub

    Public Sub retirarDineroCuenta(numCuenta As Integer, valor As Double)

        cuentas(numCuenta - 1).retirarDinero(valor)

    End Sub

    Public Function getSaldoCuenta(numCuenta As Integer)


        Return cuentas(numCuenta - 1).getSaldo
    End Function

    Public Function buscarCuentaCliente(cedula As String) As CuentaAhorro

        Dim cuentaCliente As CuentaAhorro = Nothing

        For i = 0 To cuentas.Length - 1 Step 1

            If cedula.Equals(cuentas(i).ClienteCuenta.CedulaPersona) Then

                cuentaCliente = cuentas(i)

                Exit For
            End If

        Next

    End Function

End Class
