<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbCrearCuenta = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVerTransacciones = New System.Windows.Forms.Button()
        Me.btnVerSaldo = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnIngresarDinero = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.liRetiros = New System.Windows.Forms.ListBox()
        Me.liIngresos = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbCrearCuenta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCrearCuenta
        '
        Me.gbCrearCuenta.Controls.Add(Me.btnNuevo)
        Me.gbCrearCuenta.Controls.Add(Me.btnCrearCuenta)
        Me.gbCrearCuenta.Controls.Add(Me.txtSaldoInicial)
        Me.gbCrearCuenta.Controls.Add(Me.Label5)
        Me.gbCrearCuenta.Controls.Add(Me.txtTelefono)
        Me.gbCrearCuenta.Controls.Add(Me.Label4)
        Me.gbCrearCuenta.Controls.Add(Me.txtDireccion)
        Me.gbCrearCuenta.Controls.Add(Me.Label3)
        Me.gbCrearCuenta.Controls.Add(Me.txtnumId)
        Me.gbCrearCuenta.Controls.Add(Me.Label2)
        Me.gbCrearCuenta.Controls.Add(Me.txtNombres)
        Me.gbCrearCuenta.Controls.Add(Me.Label1)
        Me.gbCrearCuenta.Location = New System.Drawing.Point(13, 13)
        Me.gbCrearCuenta.Name = "gbCrearCuenta"
        Me.gbCrearCuenta.Size = New System.Drawing.Size(749, 120)
        Me.gbCrearCuenta.TabIndex = 0
        Me.gbCrearCuenta.TabStop = False
        Me.gbCrearCuenta.Text = "Crear cuenta"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(143, 76)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Location = New System.Drawing.Point(20, 76)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(100, 23)
        Me.btnCrearCuenta.TabIndex = 10
        Me.btnCrearCuenta.Text = "Crear cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(506, 37)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoInicial.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(503, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Saldo Inicial"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(385, 37)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Teléfono"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(266, 37)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'txtnumId
        '
        Me.txtnumId.Location = New System.Drawing.Point(143, 37)
        Me.txtnumId.Name = "txtnumId"
        Me.txtnumId.Size = New System.Drawing.Size(100, 20)
        Me.txtnumId.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Número de ID"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(20, 37)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(100, 20)
        Me.txtNombres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVerTransacciones)
        Me.GroupBox1.Controls.Add(Me.btnVerSaldo)
        Me.GroupBox1.Controls.Add(Me.btnRetirarDinero)
        Me.GroupBox1.Controls.Add(Me.btnIngresarDinero)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 87)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'btnVerTransacciones
        '
        Me.btnVerTransacciones.Location = New System.Drawing.Point(531, 38)
        Me.btnVerTransacciones.Name = "btnVerTransacciones"
        Me.btnVerTransacciones.Size = New System.Drawing.Size(145, 23)
        Me.btnVerTransacciones.TabIndex = 14
        Me.btnVerTransacciones.Text = "Ver Detalle Transacción"
        Me.btnVerTransacciones.UseVisualStyleBackColor = True
        '
        'btnVerSaldo
        '
        Me.btnVerSaldo.Location = New System.Drawing.Point(381, 38)
        Me.btnVerSaldo.Name = "btnVerSaldo"
        Me.btnVerSaldo.Size = New System.Drawing.Size(130, 23)
        Me.btnVerSaldo.TabIndex = 13
        Me.btnVerSaldo.Text = "Ver Saldo Disponible"
        Me.btnVerSaldo.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Location = New System.Drawing.Point(150, 38)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirarDinero.TabIndex = 12
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnIngresarDinero
        '
        Me.btnIngresarDinero.Location = New System.Drawing.Point(45, 38)
        Me.btnIngresarDinero.Name = "btnIngresarDinero"
        Me.btnIngresarDinero.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresarDinero.TabIndex = 11
        Me.btnIngresarDinero.Text = "Ingresar Dinero"
        Me.btnIngresarDinero.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.liRetiros)
        Me.GroupBox2.Controls.Add(Me.liIngresos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 175)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial de TRansacciones Cuenta"
        '
        'liRetiros
        '
        Me.liRetiros.FormattingEnabled = True
        Me.liRetiros.Location = New System.Drawing.Point(381, 44)
        Me.liRetiros.Name = "liRetiros"
        Me.liRetiros.Size = New System.Drawing.Size(355, 121)
        Me.liRetiros.TabIndex = 4
        '
        'liIngresos
        '
        Me.liIngresos.FormattingEnabled = True
        Me.liIngresos.Location = New System.Drawing.Point(20, 44)
        Me.liIngresos.Name = "liIngresos"
        Me.liIngresos.Size = New System.Drawing.Size(355, 121)
        Me.liIngresos.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Retiros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ingresos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCrearCuenta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbCrearCuenta.ResumeLayout(False)
        Me.gbCrearCuenta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCrearCuenta As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnumId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVerTransacciones As Button
    Friend WithEvents btnVerSaldo As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents btnIngresarDinero As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents liRetiros As ListBox
    Friend WithEvents liIngresos As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
