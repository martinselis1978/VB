Public Class frmListaProductos
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim frmV As frmVentasProductos = frmVentasProductos.getInstancia

        Dim producto As String = ListBox1.SelectedItem.ToString

        frmV.insertarDatos(producto)

        Me.Close()

    End Sub
End Class