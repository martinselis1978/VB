Imports Microsoft.Reporting.WinForms

Public Class FrmReportePrueba
    Private Sub FrmReportePrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Public Sub generarReporte(id As Integer)

        Try

            Dim dt As DataTable
            Dim da As New DAlumno

            dt = da.consultarAlumnoPorId(id)

            ReportViewer1.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("dsAlumnos", dt)

            ReportViewer1.LocalReport.DataSources.Add(rpt)

            ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub
End Class