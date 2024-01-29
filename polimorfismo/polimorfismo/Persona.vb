Public MustInherit Class Persona

    Private nombre As String
    Private tipoid As String
    Private noIdentificacion As String
    Private edad As Integer
    Private direccion As String
    Private telefono As String
    Public Sub New(no As String, ti As String, id As String, ed As Integer, di As String, te As String)
        nombre = no
        tipoid = ti
        noIdentificacion = id
        edad = ed
        direccion = di
        telefono = te
    End Sub
    Public Property TipoidPersona() As String
        Get
            Return tipoid
        End Get
        Set(value As String)
            tipoid = value
        End Set
    End Property
    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property NoIdentificacionPersona() As String
        Get
            Return noIdentificacion
        End Get
        Set(value As String)
            noIdentificacion = value
        End Set
    End Property
    Public Property EdadPersona() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
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
    Public MustOverride Sub darDescripcion()

End Class
