<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarAlumno
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
        Me.gbDatosAlumno = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.txtApellidoAlumno = New System.Windows.Forms.TextBox()
        Me.txtEmailAlumno = New System.Windows.Forms.TextBox()
        Me.btnInsertarAlumno = New System.Windows.Forms.Button()
        Me.gbDatosAlumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosAlumno
        '
        Me.gbDatosAlumno.Controls.Add(Me.btnInsertarAlumno)
        Me.gbDatosAlumno.Controls.Add(Me.txtEmailAlumno)
        Me.gbDatosAlumno.Controls.Add(Me.txtApellidoAlumno)
        Me.gbDatosAlumno.Controls.Add(Me.txtNombreAlumno)
        Me.gbDatosAlumno.Controls.Add(Me.Label3)
        Me.gbDatosAlumno.Controls.Add(Me.Label2)
        Me.gbDatosAlumno.Controls.Add(Me.Label1)
        Me.gbDatosAlumno.Location = New System.Drawing.Point(13, 13)
        Me.gbDatosAlumno.Name = "gbDatosAlumno"
        Me.gbDatosAlumno.Size = New System.Drawing.Size(297, 261)
        Me.gbDatosAlumno.TabIndex = 0
        Me.gbDatosAlumno.TabStop = False
        Me.gbDatosAlumno.Text = "Datos del Alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "eMail"
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(77, 39)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(187, 20)
        Me.txtNombreAlumno.TabIndex = 3
        '
        'txtApellidoAlumno
        '
        Me.txtApellidoAlumno.Location = New System.Drawing.Point(77, 82)
        Me.txtApellidoAlumno.Name = "txtApellidoAlumno"
        Me.txtApellidoAlumno.Size = New System.Drawing.Size(187, 20)
        Me.txtApellidoAlumno.TabIndex = 4
        '
        'txtEmailAlumno
        '
        Me.txtEmailAlumno.Location = New System.Drawing.Point(77, 133)
        Me.txtEmailAlumno.Name = "txtEmailAlumno"
        Me.txtEmailAlumno.Size = New System.Drawing.Size(187, 20)
        Me.txtEmailAlumno.TabIndex = 5
        '
        'btnInsertarAlumno
        '
        Me.btnInsertarAlumno.Location = New System.Drawing.Point(77, 190)
        Me.btnInsertarAlumno.Name = "btnInsertarAlumno"
        Me.btnInsertarAlumno.Size = New System.Drawing.Size(138, 49)
        Me.btnInsertarAlumno.TabIndex = 6
        Me.btnInsertarAlumno.Text = "Insetar Alumno"
        Me.btnInsertarAlumno.UseVisualStyleBackColor = True
        '
        'FrmInsertarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 291)
        Me.Controls.Add(Me.gbDatosAlumno)
        Me.Name = "FrmInsertarAlumno"
        Me.Text = "FrmInsertarAlumno"
        Me.gbDatosAlumno.ResumeLayout(False)
        Me.gbDatosAlumno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosAlumno As GroupBox
    Friend WithEvents btnInsertarAlumno As Button
    Friend WithEvents txtEmailAlumno As TextBox
    Friend WithEvents txtApellidoAlumno As TextBox
    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
