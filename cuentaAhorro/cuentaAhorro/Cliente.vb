Public Class Cliente

    Private nombre As String
    Private numIdentificacion As String
    Private direccion As String
    Private telefono As String

    Public Sub New()


    End Sub
    Public Sub New(nom As String, numId As String, dire As String, tel As String)

        nombre = nom
        numIdentificacion = numId
        direccion = dire
        telefono = tel

    End Sub

    Public Property NombreCliente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property NumIdCliente As String
        Get
            Return numIdentificacion
        End Get
        Set(value As String)
            numIdentificacion = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
