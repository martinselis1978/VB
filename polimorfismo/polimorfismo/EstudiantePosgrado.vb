Public Class EstudiantePosgrado
    Inherits Universitario

    Public Sub New(no As String, ti As String, id As String, ed As Integer, di As String, te As String, ca As Boolean, pr As String)
        MyBase.New(no, ti, id, ed, di, te, ca, pr)
    End Sub
    Public Overrides Sub darDescripcion()
        Console.WriteLine("=================================")
        Console.WriteLine("")
        Console.WriteLine("Datos del Estudiante: ")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de Identificación: " & TipoidPersona)
        Console.WriteLine("Número de Identificación: " & NoIdentificacionPersona)
        Console.WriteLine("Código Estudiantil: " & CodigoEstudiantilAlumno)
        Console.WriteLine("Carnet Estudiantil: " & CarnetEstudiantilAlumno)
        Console.WriteLine("Programa de Posgrado: " & ProgramaUniversitario)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Teléfono: " & TelefonoPersona)
    End Sub
End Class
