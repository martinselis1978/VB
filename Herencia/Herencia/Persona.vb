Public Class Persona

    Private nombre As String
    Private cedula As String
    Private direccion As String
    Private telefono As String

    Public Sub New()

    End Sub

    Public Sub New(no As String, ce As String, di As String, te As String)

        nombre = no
        cedula = ce
        direccion = di
        telefono = te

    End Sub

    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property CedulaPersona() As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property DireccionPersona() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoPersona() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
