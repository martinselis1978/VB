Imports System.Runtime.InteropServices.WindowsRuntime

Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As String
    Private btu As String
    Private tipo As String

    Public Sub New(ma As String, mo As String, co As String, vo As String, bt As String, ti As tiAireAcondicionado)
        marca = ma
        modelo = mo
        color = co
        voltaje = vo
        btu = bt
        tipo = CType(ti, Integer)
        modelo = "AC" & voltaje.ToString & marca.Substring(0, 2) & color.Substring(0, 2)
        modelo = modelo.ToUpper
    End Sub
    Public Enum tiAireAcondicionado
        Ventana = 101
        Split = 102
    End Enum
    Public Property MarcaAire() As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property
    Public Property ModeloAire() As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property
    Public Property ColorAire() As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property
    Public Property VoltajeAire() As String
        Get
            Return voltaje
        End Get
        Set(value As String)
            voltaje = value
        End Set
    End Property
    Public Property BtuAire() As String
        Get
            Return btu
        End Get
        Set(value As String)
            btu = value
        End Set
    End Property
    Public Function getTipoAire() As String

        Return tipo
    End Function
End Class
