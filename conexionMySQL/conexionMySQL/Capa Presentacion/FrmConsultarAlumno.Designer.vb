<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarAlumno
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
        Me.gbDatosConsulta = New System.Windows.Forms.GroupBox()
        Me.btnNuevoConsulta = New System.Windows.Forms.Button()
        Me.btnConsultarConsulta = New System.Windows.Forms.Button()
        Me.txtEmailConsulta = New System.Windows.Forms.TextBox()
        Me.txtApellidoConsulta = New System.Windows.Forms.TextBox()
        Me.txtNombreConsulta = New System.Windows.Forms.TextBox()
        Me.txtIdConsulta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatosConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosConsulta
        '
        Me.gbDatosConsulta.Controls.Add(Me.btnNuevoConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.btnConsultarConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.txtEmailConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.txtApellidoConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.txtNombreConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.txtIdConsulta)
        Me.gbDatosConsulta.Controls.Add(Me.Label4)
        Me.gbDatosConsulta.Controls.Add(Me.Label3)
        Me.gbDatosConsulta.Controls.Add(Me.Label2)
        Me.gbDatosConsulta.Controls.Add(Me.Label1)
        Me.gbDatosConsulta.Location = New System.Drawing.Point(13, 13)
        Me.gbDatosConsulta.Name = "gbDatosConsulta"
        Me.gbDatosConsulta.Size = New System.Drawing.Size(519, 117)
        Me.gbDatosConsulta.TabIndex = 0
        Me.gbDatosConsulta.TabStop = False
        Me.gbDatosConsulta.Text = "Datos de consulta"
        '
        'btnNuevoConsulta
        '
        Me.btnNuevoConsulta.Location = New System.Drawing.Point(162, 75)
        Me.btnNuevoConsulta.Name = "btnNuevoConsulta"
        Me.btnNuevoConsulta.Size = New System.Drawing.Size(84, 36)
        Me.btnNuevoConsulta.TabIndex = 9
        Me.btnNuevoConsulta.Text = "Nuevo"
        Me.btnNuevoConsulta.UseVisualStyleBackColor = True
        '
        'btnConsultarConsulta
        '
        Me.btnConsultarConsulta.Location = New System.Drawing.Point(56, 75)
        Me.btnConsultarConsulta.Name = "btnConsultarConsulta"
        Me.btnConsultarConsulta.Size = New System.Drawing.Size(84, 36)
        Me.btnConsultarConsulta.TabIndex = 8
        Me.btnConsultarConsulta.Text = "Consultar"
        Me.btnConsultarConsulta.UseVisualStyleBackColor = True
        '
        'txtEmailConsulta
        '
        Me.txtEmailConsulta.Location = New System.Drawing.Point(313, 49)
        Me.txtEmailConsulta.Name = "txtEmailConsulta"
        Me.txtEmailConsulta.Size = New System.Drawing.Size(190, 20)
        Me.txtEmailConsulta.TabIndex = 7
        '
        'txtApellidoConsulta
        '
        Me.txtApellidoConsulta.Location = New System.Drawing.Point(207, 49)
        Me.txtApellidoConsulta.Name = "txtApellidoConsulta"
        Me.txtApellidoConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoConsulta.TabIndex = 6
        '
        'txtNombreConsulta
        '
        Me.txtNombreConsulta.Location = New System.Drawing.Point(101, 49)
        Me.txtNombreConsulta.Name = "txtNombreConsulta"
        Me.txtNombreConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreConsulta.TabIndex = 5
        '
        'txtIdConsulta
        '
        Me.txtIdConsulta.Location = New System.Drawing.Point(18, 49)
        Me.txtIdConsulta.Name = "txtIdConsulta"
        Me.txtIdConsulta.Size = New System.Drawing.Size(77, 20)
        Me.txtIdConsulta.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "eMail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Alumno"
        '
        'FrmConsultarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 142)
        Me.Controls.Add(Me.gbDatosConsulta)
        Me.Name = "FrmConsultarAlumno"
        Me.Text = "FrmConsultarAlumno"
        Me.gbDatosConsulta.ResumeLayout(False)
        Me.gbDatosConsulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosConsulta As GroupBox
    Friend WithEvents btnNuevoConsulta As Button
    Friend WithEvents btnConsultarConsulta As Button
    Friend WithEvents txtEmailConsulta As TextBox
    Friend WithEvents txtApellidoConsulta As TextBox
    Friend WithEvents txtNombreConsulta As TextBox
    Friend WithEvents txtIdConsulta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
