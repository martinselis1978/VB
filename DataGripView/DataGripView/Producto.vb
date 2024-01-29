Public Class Producto
    Private codigo As String
    Private descripcion As String
    Private precioU As Double
    Private Shared indiceCodigo As Integer = 1

    Public Sub New(descripcion As String, precioU As Double)
        Me.codigo = "AR00" & indiceCodigo
        indiceCodigo += 1
        Me.descripcion = descripcion
        Me.precioU = precioU
    End Sub

    Public ReadOnly Property CodigoProducto As String
        Get
            Return codigo
        End Get
    End Property

    Public ReadOnly Property DescripcionProducto As String
        Get
            Return descripcion
        End Get
    End Property

    Public ReadOnly Property PrecioUProducto As Double
        Get
            Return precioU
        End Get
    End Property

End Class
