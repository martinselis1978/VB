Public Class Personas

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

    Public Overrides Function ToString() As String

        If edad > 1 Then
            Return nombre & " tiene " & edad & " años."
        Else
            Return nombre & " tiene " & edad & " año."
        End If

    End Function


End Class
