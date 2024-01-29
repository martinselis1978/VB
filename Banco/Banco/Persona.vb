Public Class Persona

    Protected nombre As String
    Public Property NombreCliente() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Protected cedula As String
    Public Property CedulaCliente() As String
        Get
            Return cedula
        End Get
        Set(ByVal value As String)
            If value.Length <> 8 Then
                Console.WriteLine("La extensión máxima de la cédula es de 8 caracteres sin punto")
            Else
                cedula = value
            End If
        End Set
    End Property

    Protected direccion As String
    Public Property DirecciónCliente() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Protected telefono As String
    Public Property telefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, cedula As String, direccion As String, telefono As String)
        Me.nombre = nombre
        Me.cedula = cedula
        Me.direccion = direccion
        Me.telefono = telefono
    End Sub

End Class
