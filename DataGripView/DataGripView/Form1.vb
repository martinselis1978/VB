Public Class Form1

    Dim listaProductos As New List(Of Producto)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Venta de Producto"

        listaProductos.Add(New Producto("Arroz x 500gr", 1800))
        listaProductos.Add(New Producto("Aceite x 1Lt", 9800))
        listaProductos.Add(New Producto("Atún en lata", 5400))
        listaProductos.Add(New Producto("Salsa de Tomate x 500gr", 4300))

        desactivaTextBox()


    End Sub

    Private Sub limpiarTextBox()

        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecioU.Clear()
        txtCantidad.Clear()
        txtTotalAP.Clear()

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCantidad.Click

    End Sub

    Public Sub desactivaTextBox()

        txtDescripcion.Enabled = False
        txtPrecioU.Enabled = False
        txtTotalAP.Enabled = False

    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus

        Try

            Dim codigo As String = txtCodigo.Text.ToUpper

            For i = 0 To listaProductos.Count - 1 Step 1

                If codigo.Equals(listaProductos.Item(i).CodigoProducto) Then

                    txtDescripcion.Text = listaProductos.Item(i).DescripcionProducto
                    txtPrecioU.Text = listaProductos.Item(i).PrecioUProducto

                    Exit For
                End If

            Next
        Catch ex As Exception
            MsgBox("El código ingresado es incorrecto")
        End Try

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

        If txtCantidad.Text <> "" And Val(txtCantidad.Text) > 0 Then
            Dim total As Double = Val(txtPrecioU.Text) * Val(txtCantidad.Text)
            txtTotalAP.Text = total.ToString
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        dgvProductos.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecioU.Text, txtCantidad.Text, txtTotalAP.Text)

    End Sub

    Private Sub btnVerTotales_Click(sender As Object, e As EventArgs) Handles btnVerTotales.Click

        Dim total As Double = 0

        For i = 0 To dgvProductos.Rows.Count - 1 Step 1

            total += dgvProductos.Rows.Item(i).Cells.Item(4).Value

        Next

        Dim subtotal As Double = total - (total * 0.19)
        Dim iva As Double = total * 0.19

        txtSubTotal.Text = subtotal.ToString
        txtIva.Text = iva.ToString
        txtTotalTotales.Text = total.ToString

    End Sub
End Class
