Public Class Cliente

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

    Public Property NombreCliente() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property CedulaCliente() As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property DireccionCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
