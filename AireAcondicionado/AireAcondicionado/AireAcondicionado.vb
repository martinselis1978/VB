Public Class AireAcondicionado
    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As String
    Private btu As String
    Private tipo As Integer

    Public Sub New(marca As String, color As String, voltaje As String, btu As String, tipo As Integer)
        Me.marca = marca
        Me.color = color
        Me.voltaje = voltaje
        Me.btu = btu
        Me.tipo = tipo
        modelo = "AC" & voltaje.ToString & marca.Substring(0, 2) & color.Substring(0, 2)
        modelo = modelo.ToUpper()
    End Sub

    Public Enum tAireAcondicionado
        Ventana
        Split
    End Enum

    Public Property MarcaAA As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    Public Property ModeloAA As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    Public Property ColorAA As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    Public Property VoltajeAA As String
        Get
            Return voltaje
        End Get
        Set(value As String)
            voltaje = value
        End Set
    End Property

    Public Property BtuAA As String
        Get
            Return btu
        End Get
        Set(value As String)
            btu = value
        End Set
    End Property

    Public Property TipoAA As Integer
        Get
            Return tipo
        End Get
        Set(value As Integer)
            tipo = value
        End Set
    End Property
End Class
