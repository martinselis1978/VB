Imports System.Security.Cryptography.X509Certificates

Public Class Banco

    Private nombre As String
    Public Property nombreBanco() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Private cuentas() As CuentaAhorro

    Public Sub New(nombre As String)

        nombre = nombre
        cuentas = New CuentaAhorro(20) {}

    End Sub

    Public Sub crearCuentaCliente(cliente As Cliente, saldo As Double)

        For i = 0 To cuentas.Length - 1

            If cuentas(i) Is Nothing Then
                cuentas(i) = New CuentaAhorro(cliente, saldo)
                Exit For
            End If

        Next

    End Sub

    Public Sub depositarDineroCuenta(numCuenta As Integer, dinero As Double)

        cuentas(numCuenta - 1).depositarDinero(dinero)

    End Sub

    Public Sub retirarDineroCuenta(numCuenta As Integer, dinero As Double)

        cuentas(numCuenta - 1).retirarDinero(dinero)

    End Sub

    Public Function getSaldoCuenta(numCuenta As Integer)

        Return cuentas(numCuenta - 1).SaldoCA
    End Function

    Public Function buscarCuentaCliente(cedula As String) As CuentaAhorro

        Dim cuentaCliente As CuentaAhorro = Nothing

        For i = 1 To 10

            If cedula.Equals(cuentas(i).ctaCA.CedulaCliente) Then
                cuentaCliente = cuentas(i)
                Exit For

            End If
        Next

    End Function

End Class
