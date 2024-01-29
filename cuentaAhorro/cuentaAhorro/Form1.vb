Imports System.ComponentModel
Imports System.Runtime.Remoting

Public Class Form1

    Private banco As New Banco(1, "XYZ")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = banco.Nombre_Banco
    End Sub

    Private Sub btnIngresarDinero_Click(sender As Object, e As EventArgs) Handles btnIngresarDinero.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ingresa Dinero", "", 500, 200))

            Dim valorIngresar As Integer = Double.Parse(InputBox("Ingrese el valor a Ingresar", "Ingresa Dinero", "", 500, 200))

            banco.ingresarDineroCuenta(numeroCuenta, valorIngresar)

        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try


    End Sub

    'Limpia las cajas de texto
    Public Sub limpiarCajas()

        txtNombres.Clear()
        txtnumId.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtSaldoInicial.Clear()

    End Sub

    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click

        If txtNombres.Text <> "" And txtnumId.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtSaldoInicial.Text <> "" Then

            Dim cte As New Cliente(txtNombres.Text, txtnumId.Text, txtDireccion.Text, txtTelefono.Text)

            Dim saldoInicial As Double = Double.Parse(txtSaldoInicial.Text)

            banco.crearCuentaAhorro(cte, saldoInicial)

            limpiarCajas()

        Else
            MsgBox("No se pudo crear la cuenta de ahorros, porque faltaron datos en el formulario")
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCajas()

    End Sub

    Private Sub btnRetirarDinero_Click(sender As Object, e As EventArgs) Handles btnRetirarDinero.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Retira Dinero", "", 500, 200))

            Dim valorRetirar As Integer = Double.Parse(InputBox("Ingrese el valor a Retirar", "Retira Dinero", "", 500, 200))

            banco.retirarDineroCuenta(numeroCuenta, valorRetirar)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Private Sub btnVerSaldo_Click(sender As Object, e As EventArgs) Handles btnVerSaldo.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Saldo", "", 500, 200))

            MsgBox("Saldo Disponible $" & banco.getSaldoCuenta(numeroCuenta))
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Private Sub btnVerTransacciones_Click(sender As Object, e As EventArgs) Handles btnVerTransacciones.Click

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Historial", "", 500, 200))

            Dim ingresosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialIngresos

            For i = 0 To ingresosCuenta.Count - 1 Step 1

                liIngresos.Items.Add(ingresosCuenta.Item(i))
            Next

            Dim retirosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialRetiros

            For i = 0 To retirosCuenta.Count - 1 Step 1

                liRetiros.Items.Add(retirosCuenta.Item(i))
            Next
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

End Class
