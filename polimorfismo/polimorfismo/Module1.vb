Module Module1

    Sub Main()
        Dim estudiante(2) As IAlumno

        estudiante(0) = New Alumno("Martin", "cc", "123", 12, "calle 123", "12300", True)
        estudiante(1) = New Universitario("maria", "cc", "456", 45, "calle 456", "45600", True, "Medicina")
        estudiante(2) = New EstudiantePosgrado("juan", "cc", "789", 28, "calle 789", "78900", False, "Especialista en Actividad Física")

        Array.Sort(estudiante)

        For Each est As Alumno In estudiante
            est.darDescripcion()
        Next
    End Sub

End Module
