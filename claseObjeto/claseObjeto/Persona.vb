Public Class Persona

    Private nombre As String
    Private edad As Integer

    Public Sub New(no As String, ed As Integer)

        nombre = no
        edad = ed

    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getEdad() As Integer
        Return edad
    End Function

End Class
