Public Class Basquetbolista
    Inherits Deportista
    Implements IBasquetbolista

    Public Sub New(no As String, po As String, ed As Integer, es As Double)
        MyBase.New(no, po, ed, es)
    End Sub

    Public Function verificarEstatura() As Boolean Implements IBasquetbolista.verificarEstatura
        If verificarEstatura >= 190 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
