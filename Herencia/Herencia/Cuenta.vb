Imports System.Runtime.Remoting

Public Class Cuenta

    Protected numCuenta As Integer
    Protected saldo As Double
    Protected cliente As Cliente

    Protected Shared id As Integer = 1

    Public Sub New()

        numCuenta = id
        cliente = Nothing
        saldo = 0

        id += 1
    End Sub

    Public Sub New(cl As Cliente, sa As Double)

        numCuenta = id
        saldo = sa
        cliente = cl

        id += 1
    End Sub

    Public Function getNumeroCuenta() As Integer

        Return numCuenta
    End Function

    Public Function getSaldo() As Double

        Return saldo
    End Function

    Public Property ClienteCuenta() As Cliente
        Get
            Return cliente
        End Get
        Set(value As Cliente)
            If cliente Is Nothing Then
                cliente = value
            Else
                Console.WriteLine("Esta cuenta ya esta asociada a un cliente")
            End If
        End Set
    End Property

    Public Sub depositarDinero(valor As Double)

        saldo = saldo + valor

    End Sub

    Public Sub retirarDinero(valor As Double)

        If saldo >= valor Then
            saldo = saldo - valor
        Else
            Console.WriteLine("No hay dinero suficiente")
        End If
    End Sub

End Class
