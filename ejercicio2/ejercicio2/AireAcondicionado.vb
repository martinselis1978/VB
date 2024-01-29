Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private btu As Integer
    Private temperatura As Integer

    Public Sub New(marca As String, color As String, voltaje As Integer, btu As Integer)
        Me.marca = marca
        Me.color = color
        Me.voltaje = voltaje
        Me.btu = btu
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"
        temperatura = 17
    End Sub

    Public Sub New(marca As String, voltaje As Integer, btu As Integer)
        Me.marca = marca
        Me.voltaje = voltaje
        Me.btu = btu
        modelo = marca.Substring(0, 2) & voltaje.ToString & "ac" & btu.ToString.Substring(0, 2) & "k2020"
        temperatura = 17
    End Sub

    Public Sub New()

    End Sub

    Public Property MarcaAire As String
        Get
            Return marca
        End Get
        Set
            marca = Value
        End Set
    End Property

    Public Property ModeloAire As String
        Get
            Return modelo
        End Get
        Set
            modelo = Value
        End Set
    End Property

    Public Property ColorAire As String
        Get
            Return color
        End Get
        Set
            color = Value
        End Set
    End Property

    Public Property VoltajeAire As Integer
        Get
            Return voltaje
        End Get
        Set
            voltaje = Value
        End Set
    End Property

    Public Property BtuAire As Integer
        Get
            Return btu
        End Get
        Set
            btu = Value
        End Set
    End Property

    Public Property TemperaturaAire As Integer
        Get
            Return temperatura
        End Get
        Set
            temperatura = Value
        End Set
    End Property

    Public Overloads Sub subirTemperatura()
        If temperatura < 30 Then
            temperatura += 1
        End If
    End Sub
    Public Overloads Sub subirTemperatura(grado As Integer)
        Dim temp As Integer = temperatura + grado
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

    Public Overloads Sub bajarTemperatura(grado As Integer)
        Dim temp As Integer = temperatura - grado
        If temp < 17 Then
            temperatura = 17
        Else
            temperatura = temp
        End If
    End Sub

    Public Function darTemperatura() As Integer
        Return temperatura
    End Function

End Class
