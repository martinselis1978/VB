Imports MySql.Data.MySqlClient

Public Class LAlumno

    Public Function actualizarAlumno(id As Integer, nombre As String, apellido As String, email As String) As Boolean

        Try

            Dim da As New DAlumno(id, nombre, apellido, email)
            da.actualizarAlumno(da)
            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try
    End Function

    Public Function consultarAlumnos() As DataTable

        Try

            Dim da As New DAlumno
            Dim dt As DataTable = da.consultarAlumnos

            Return dt

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing


        End Try

    End Function

    Public Function insertarAlumno(nombre As String, apellido As String, email As String)

        Dim da As New DAlumno(nombre, apellido, email)

        If da.insertarAlumno(da) = True Then

            Return True

        Else

            Return False

        End If

    End Function




    Public Function consultarAlumno(apellido As String) As DataTable

        Try

            Dim da As New DAlumno

            Dim dt As New DataTable

            dt = da.consultarAlumno(apellido)

            Return dt

        Catch ex As Exception

            MsgBox(ex.Message)

            Return Nothing

        End Try
    End Function


    Public Function consultarAlumnoPorId(id As String) As DataTable

        Try

            Dim da As New DAlumno

            Dim dt As DataTable = da.consultarAlumnoPorId(id)

            If dt IsNot Nothing Then

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try
    End Function

    Public Function eliminarAlumno(id As String) As Boolean

        Try

            Dim da As New DAlumno
            da.eliminarAlumno(id)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function
End Class
