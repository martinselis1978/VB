Public Class Formula

    Private id As Integer
    Private nombre As String
    Private formula As String

    Private Shared idSuma As Integer = 1

    Public Sub New(nombre As String, formula As String)
        id = idSuma
        idSuma += 1
        Me.nombre = nombre
        Me.formula = formula
    End Sub

    Public ReadOnly Property IdFormula As Integer
        Get
            Return id
        End Get
    End Property

    Public Property NombreFormula As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property FormulaFormula As String
        Get
            Return formula
        End Get
        Set(value As String)
            formula = value
        End Set
    End Property
End Class
