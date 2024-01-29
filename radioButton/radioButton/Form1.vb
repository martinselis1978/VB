Imports System.Linq.Expressions

Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim totalCompra As Double = Val(txtTotalCompra.Text)

        Dim totalCompraDescuento As Double = 0

        If rbDescuento5.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.05)
        End If

        If rbDescuento10.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.1)
        End If

        If rbDescuento15.Checked = True Then
            totalCompraDescuento = totalCompra - (totalCompra * 0.15)
        End If

        'muestra el resultado en el txtbox, el toString convierte el resultado de totalCompraDescuento que es
        'double a string
        txtTotalCompraDescuento.Text = totalCompraDescuento.ToString

    End Sub
End Class
