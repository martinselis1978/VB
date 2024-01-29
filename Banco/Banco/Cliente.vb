Public Class Cliente
    Inherits Persona

    Public Sub New(nombre As String, cedula As String, direccion As String, telefono As String)
        MyBase.New(nombre, cedula, direccion, telefono)
    End Sub
End Class
