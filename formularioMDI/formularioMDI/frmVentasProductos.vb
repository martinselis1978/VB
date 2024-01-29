Public Class frmVentasProductos

    Public Shared existeInstancia As frmVentasProductos

    Public Function getInstancia() As frmVentasProductos

        If existeInstancia Is Nothing Then
            existeInstancia = New frmVentasProductos
            Return existeInstancia
        Else
            Return existeInstancia
        End If
    End Function

    Public Sub insertarDatos(productos As String)

        TextBox1.Text = productos

    End Sub

    Private Sub frmVentasProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmListaP As New frmListaProductos

        frmListaP.ShowDialog()

    End Sub

    Private Sub frmVentasProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        existeInstancia = Nothing

    End Sub
End Class