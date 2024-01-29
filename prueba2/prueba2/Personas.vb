Public Class Personas

    Dim nombre As String
    Dim apellido As String
    Dim id As String
    Dim contador As Integer = 0

    Public Sub New(no As String, ap As String)
        contador += 1
        nombre = no
        apellido = ap
        id = contador.ToString
    End Sub

    Public ReadOnly Property NombrePersonas As String
        Get
            Return nombre
        End Get
    End Property

    Public ReadOnly Property ApellidoPersonas As String
        Get
            Return apellido
        End Get
    End Property

    Public ReadOnly Property IdPersonas As String
        Get
            Return id
        End Get
    End Property


End Class
