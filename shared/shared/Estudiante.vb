Public Class Estudiante

    Private codigoEstudiante As Integer
    Private nombres As String

    'el shared hace que el 1 no se quede fijo, ya que no hace una copia
    'de este cada vez que se ejecuté el programa
    Private Shared codigo As Integer = 1

    Public Sub New(nom As String)

        nombres = nom
        codigoEstudiante = codigo
        codigo += 1

    End Sub

    Public Function getCodigoEstudiante() As Integer


        Return codigoEstudiante
    End Function

    Public Function getNombre() As String


        Return nombres
    End Function

End Class
