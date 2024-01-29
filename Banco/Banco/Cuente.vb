Imports System.CodeDom

Public Class Cuente

    Private Shared cuenta As Integer = 1

    Private numCuenta As Integer
    Public Property NumCuentaCA() As Integer
        Get
            Return numCuenta
        End Get
        Set(cuenta As Integer)
            numCuenta = cuenta
            cuenta += 1
        End Set
    End Property

    Private saldo As Double
    Public Property SaldoCA() As Double
        Get
            Return saldo
        End Get
        Set(ByVal value As Double)
            saldo = value
        End Set
    End Property

    Private cta As Persona
    Public Property ctaCA() As Persona
        Get
            Return cta
        End Get
        Set(ByVal value As Persona)
            If cta Is Nothing Then
                cta = value
            Else
                Console.WriteLine("La cuenta ya está registrada")
            End If
        End Set
    End Property

    Public Sub New()
        numCuenta = cuenta
        cuenta += 1
        saldo = 0
        cta = Nothing
    End Sub

    Public Sub New(cliente As Persona, saldo As Double)
        Me.numCuenta = cuenta
        cuenta += 1
        Me.saldo = saldo
        Me.cta = cliente
    End Sub

    Public Sub retirarDinero(dinero As Double)
        If dinero <= saldo Then
            saldo = saldo - dinero
        Else
            Console.WriteLine("")
            Console.WriteLine("Los fondos son insuficientes para retirar dinero")
        End If
    End Sub

    Public Sub depositarDinero(dinero As Double)
        saldo = saldo + dinero
    End Sub

End Class
