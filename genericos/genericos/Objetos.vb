Public Class Objetos(Of t)

    Private miObjeto As t

    Public Property ElObjeto As t
        Get
            Return miObjeto
        End Get
        Set(value As t)
            miObjeto = value
        End Set
    End Property

End Class
