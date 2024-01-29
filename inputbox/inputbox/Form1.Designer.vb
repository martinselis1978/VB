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
        Me.btnIngresarNumero = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtresultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIngresarNumero
        '
        Me.btnIngresarNumero.Location = New System.Drawing.Point(231, 55)
        Me.btnIngresarNumero.Name = "btnIngresarNumero"
        Me.btnIngresarNumero.Size = New System.Drawing.Size(124, 31)
        Me.btnIngresarNumero.TabIndex = 0
        Me.btnIngresarNumero.Text = "Ingresar número"
        Me.btnIngresarNumero.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtresultado
        '
        Me.txtresultado.Location = New System.Drawing.Point(300, 295)
        Me.txtresultado.Name = "txtresultado"
        Me.txtresultado.Size = New System.Drawing.Size(100, 20)
        Me.txtresultado.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtresultado)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnIngresarNumero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresarNumero As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtresultado As TextBox
End Class
