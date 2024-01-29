Public Class Persona

    Dim nombre As String
    Dim id As String
    Dim telefono As String
    Dim email As String

    Public Sub New(no As String, i As String, te As String, em As String)
        nombre = no
        id = i
        telefono = te
        email = em
    End Sub

    Public ReadOnly Property NombrePersona As String
        Get
            Return nombre
        End Get
    End Property

    Public ReadOnly Property IdPersona As String
        Get
            Return id
        End Get
    End Property

    Public ReadOnly Property TelefonoPersona As String
        Get
            Return telefono
        End Get
    End Property

    Public ReadOnly Property EmailPersona As String
        Get
            Return email
        End Get
    End Property

    Public Overridable Function toString() As String

        Return nombre & " " & id & " " & telefono & " " & email

    End Function

End Class
