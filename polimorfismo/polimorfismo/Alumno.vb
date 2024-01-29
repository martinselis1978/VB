Public Class Alumno
    Inherits Persona
    Implements IAlumno

    Private codigoEstudiante As String
    Private carnetEstudiantil As Boolean

    Public Sub New(no As String, ti As String, id As String, ed As Integer, di As String, te As String, ca As Boolean)
        MyBase.New(no, ti, id, ed, di, te)
        Me.codigoEstudiante = no.Substring(0, 2) & id.Substring(0, 2)
        carnetEstudiantil = ca
    End Sub

    Public Property CodigoEstudiantilAlumno() As String
        Get
            Return codigoEstudiante
        End Get
        Set(value As String)
            codigoEstudiante = value
        End Set
    End Property
    Public Property CarnetEstudiantilAlumno() As Boolean
        Get
            Return carnetEstudiantil
        End Get
        Set(value As Boolean)
            carnetEstudiantil = value
        End Set
    End Property
    Public Overridable Sub darDescripcion() Implements IAlumno.
        Console.WriteLine(Of"=================================")
        Console.WriteLine("")
        Console.WriteLine("Datos del Estudiante: ")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de Identificación: " & TipoidPersona)
        Console.WriteLine("Número de Identificación: " & NoIdentificacionPersona)
        Console.WriteLine("Código Estudiantil: " & CodigoEstudiantilAlumno)
        Console.WriteLine("Carnet Estudiantil: " & CarnetEstudiantilAlumno)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Teléfono: " & TelefonoPersona)
    End Sub

    Public Sub darDescripcionAlumno() Implements IAlumno.darDescripcionAlumno
        Throw New NotImplementedException()
    End Sub
End Class
