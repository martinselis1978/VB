Imports MySql.Data.MySqlClient

Public Class DAlumno
    Inherits Conexion

    Private id As Integer
    Private nombre As String
    Private apellido As String
    Private email As String

    Private cmd As MySqlCommand

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellido As String, email As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.email = email
    End Sub

    Public Sub New(id As Integer, nombre As String, apellido As String, email As String)
        Me.id = id
        Me.nombre = nombre
        Me.apellido = apellido
        Me.email = email
    End Sub

    Public Property NombreAlumno As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property ApellidoAlumno As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property EmailAlumno As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property IdAlumno As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Function consultarAlumno(apellido As String) As DataTable

        Try

            conectar()
            cmd = New MySqlCommand("SELECT ID,NOMBRE,APELLIDO,EMAIL FROM ALUMNO WHERE APELLIDO='" & apellido & "'")
            cmd.Connection = conexion

            If cmd.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            desconectar()

        End Try

    End Function

    Public Function eliminarAlumno(id As String) As Boolean

        Try

            conectar()
            cmd = New MySqlCommand("DELETE FROM alumno WHERE id='" & id & "'", conexion)

            If cmd.ExecuteNonQuery Then

                MsgBox("El cliente se ha eliminado correctamente de la DB")
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            Return False

        Finally

            desconectar()

        End Try

    End Function

    Public Function consultarAlumnos() As DataTable

        Try

            conectar()

            cmd = New MySqlCommand("SELECT * FROM alumno", conexion)

            If cmd.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            conexion.Close()

        End Try

    End Function

    Public Function actualizarAlumno(al As DAlumno) As Boolean

        Try

            conectar()

            cmd = New MySqlCommand("UPDATE alumno SET nombre ='" & al.NombreAlumno &
                                   "', apellido='" & al.ApellidoAlumno & "', email='" &
                                   al.EmailAlumno & "' WHERE id='" & al.IdAlumno & "'", conexion)

            If cmd.ExecuteNonQuery Then

                MsgBox("Los datos del cliente fueron actiualizados correctamente")
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally

            desconectar()

        End Try

    End Function

    Public Function insertarAlumno(da As DAlumno) As Boolean

        Try

            conectar()

            cmd = New MySqlCommand("INSERT INTO alumno (nombre,apellido,email) VALUES ('" &
                                   da.nombre & "','" & da.apellido & "','" & da.email & "')", conexion)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El cliente fue ingresado exitosamente.")
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Function consultarAlumnoPorId(id As String) As DataTable

        Try

            conectar()

            cmd = New MySqlCommand("SELECT * FROM alumno WHERE id='" & id & "'",
                                   conexion)

            If cmd.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            desconectar()

        End Try

    End Function

End Class
