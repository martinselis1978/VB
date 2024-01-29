Public Class Basquet
    Inherits Deportista
    Implements IBasquetbolista

    Public Sub New(nombre As String, posicion As String, altura As Boolean)
        MyBase.New(nombre, posicion, altura)
    End Sub

    Public Function estableceAltura() As Boolean Implements IBasquetbolista.estableceAltura
        If alturaDeportista >= 200 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
