﻿Public Class CuentaAhorro

    Private numeroCuentaAhorro As Integer
    Private saldo As Double
    Private cte As Cliente

    Private Shared estableceNumeroCuenta As Integer = 1

    Public Sub New()

        numeroCuentaAhorro = estableceNumeroCuenta
        saldo = 0
        cte = Nothing

        estableceNumeroCuenta += 1

    End Sub

    Public Sub New(cl As Cliente, sa As Double)

        numeroCuentaAhorro = estableceNumeroCuenta
        saldo = sa
        cte = cl

        estableceNumeroCuenta += 1

    End Sub
    Public Function getNumeroCuentaAhorro() As Integer

        Return numeroCuentaAhorro
    End Function
    Public Function getSaldo() As Double

        Return saldo
    End Function

    Public Property ClienteCuenta() As Cliente
        Get
            Return cte
        End Get
        Set(value As Cliente)
            If cte Is Nothing Then
                cte = value
            Else
                Console.WriteLine("El cliente ya esta asignado a la cuenta")
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

            Console.WriteLine("El saldo disponible no es suficiente")

        End If

    End Sub

End Class
