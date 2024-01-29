Public Class Deportista

    Private nombre As String
    Private posicion As String
    Private altura As Boolean

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, posicion As String, altura As Double)
        Me.nombre = nombre
        Me.posicion = posicion
        Me.altura = altura
    End Sub

    Public Property NombreDeportista As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PosicionDeportista As String
        Get
            Return posicion
        End Get
        Set(value As String)
            posicion = value
        End Set
    End Property

    Public Property alturaDeportista As Boolean
        Get
            Return altura
        End Get
        Set(value As Boolean)
            altura = value
        End Set
    End Property

End Class
