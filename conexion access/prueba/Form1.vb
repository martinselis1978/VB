Imports System.Data.OleDb
Public Class Form1
    Private conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\repos\Base de datos\Prueba.accdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            conexion.Open()
            MsgBox("La conexión fue exisosa.")

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            conexion.Close()

        End Try

    End Sub
End Class
