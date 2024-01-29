Public Class Persona

    Private nombre As String
    Private numId As String

    Public Sub New(no As String, nu As String)
        nombre = no
        numId = nu
    End Sub

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getNumId() As String
        Return numId
    End Function

End Class
