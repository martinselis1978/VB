﻿Imports System.Runtime.InteropServices

Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private btu As Integer
    Private temperatura As Integer

    Public Sub New(ma As String, co As String, vo As Integer, b As Integer)

        marca = ma
        color = co
        voltaje = vo
        btu = b
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"
        temperatura = 17

    End Sub
    Public Sub New(ma As String, vo As Integer, b As Integer)

        marca = ma
        voltaje = vo
        btu = b
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"
        temperatura = 17

    End Sub
    Public Sub New()

    End Sub

    Public Overloads Sub subirTemperatura()

        If temperatura < 30 Then

            temperatura += 1

        End If

    End Sub
    Public Overloads Sub subirTemperatura(grados As Integer)

        Dim temp As Integer = temperatura + grados

        If temp > 30 Then

            temperatura = 30

        Else

            temperatura = temp

        End If

    End Sub

    Public Overloads Sub bajarTemperatura()

        If temperatura > 17 Then

            temperatura -= 1

        End If

    End Sub
    Public Overloads Sub bajarTemperatura(grados As Integer)

        Dim temp As Integer = temperatura - grados

        If temp < 17 Then

            temperatura = 17

        Else

            temperatura = temp

        End If

    End Sub

    Public Property MarcaAire As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property ModeloAire As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property ColorAire As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    Public Property VoltajeAire As Integer
        Get
            Return voltaje
        End Get
        Set(value As Integer)
            voltaje = value
        End Set
    End Property

    Public Property BtuAire As Integer
        Get
            Return btu
        End Get
        Set(value As Integer)
            btu = value
        End Set
    End Property

    Public Property TemperaturaAire As Integer
        Get
            Return temperatura
        End Get
        Set(value As Integer)
            temperatura = value
        End Set
    End Property

End Class
