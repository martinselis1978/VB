Public Class FrmGenerarReporte
    Private Sub btnGenerarNombre_Click(sender As Object, e As EventArgs) Handles btnGenerarNombre.Click

        Try

            Dim frmRp As New FrmReportePrueba

            frmRp.generarReporte(txtNumId.Text)

            frmRp.Show()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class