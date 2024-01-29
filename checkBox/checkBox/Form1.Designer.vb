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
        Me.chClase = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chObjeto = New System.Windows.Forms.CheckBox()
        Me.chHerencia = New System.Windows.Forms.CheckBox()
        Me.chBucle = New System.Windows.Forms.CheckBox()
        Me.chPolimorfismo = New System.Windows.Forms.CheckBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chClase
        '
        Me.chClase.AutoSize = True
        Me.chClase.Location = New System.Drawing.Point(49, 81)
        Me.chClase.Name = "chClase"
        Me.chClase.Size = New System.Drawing.Size(52, 17)
        Me.chClase.TabIndex = 0
        Me.chClase.Text = "Clase"
        Me.chClase.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lab¿Qué concepto de los que se muestran a continuación pertenecen al paradigma de" &
    " la POO?"
        '
        'chObjeto
        '
        Me.chObjeto.AutoSize = True
        Me.chObjeto.Location = New System.Drawing.Point(49, 132)
        Me.chObjeto.Name = "chObjeto"
        Me.chObjeto.Size = New System.Drawing.Size(57, 17)
        Me.chObjeto.TabIndex = 2
        Me.chObjeto.Text = "Objeto"
        Me.chObjeto.UseVisualStyleBackColor = True
        '
        'chHerencia
        '
        Me.chHerencia.AutoSize = True
        Me.chHerencia.Location = New System.Drawing.Point(49, 187)
        Me.chHerencia.Name = "chHerencia"
        Me.chHerencia.Size = New System.Drawing.Size(69, 17)
        Me.chHerencia.TabIndex = 3
        Me.chHerencia.Text = "Herencia"
        Me.chHerencia.UseVisualStyleBackColor = True
        '
        'chBucle
        '
        Me.chBucle.AutoSize = True
        Me.chBucle.Location = New System.Drawing.Point(49, 252)
        Me.chBucle.Name = "chBucle"
        Me.chBucle.Size = New System.Drawing.Size(53, 17)
        Me.chBucle.TabIndex = 4
        Me.chBucle.Text = "Bucle"
        Me.chBucle.UseVisualStyleBackColor = True
        '
        'chPolimorfismo
        '
        Me.chPolimorfismo.AutoSize = True
        Me.chPolimorfismo.Location = New System.Drawing.Point(49, 312)
        Me.chPolimorfismo.Name = "chPolimorfismo"
        Me.chPolimorfismo.Size = New System.Drawing.Size(84, 17)
        Me.chPolimorfismo.TabIndex = 5
        Me.chPolimorfismo.Text = "Polimorfismo"
        Me.chPolimorfismo.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(286, 252)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(162, 75)
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Procesar Respuesta"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.chPolimorfismo)
        Me.Controls.Add(Me.chBucle)
        Me.Controls.Add(Me.chHerencia)
        Me.Controls.Add(Me.chObjeto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chClase)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chClase As Windows.Forms.CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chObjeto As Windows.Forms.CheckBox
    Friend WithEvents chHerencia As Windows.Forms.CheckBox
    Friend WithEvents chBucle As Windows.Forms.CheckBox
    Friend WithEvents chPolimorfismo As Windows.Forms.CheckBox
    Friend WithEvents btnProcesar As Button
End Class
