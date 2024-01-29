<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarReporte
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
        Me.btnGenerarNombre = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGenerarNombre
        '
        Me.btnGenerarNombre.Location = New System.Drawing.Point(41, 55)
        Me.btnGenerarNombre.Name = "btnGenerarNombre"
        Me.btnGenerarNombre.Size = New System.Drawing.Size(100, 56)
        Me.btnGenerarNombre.TabIndex = 0
        Me.btnGenerarNombre.Text = "Generar Reporte"
        Me.btnGenerarNombre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el ID"
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(41, 29)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(100, 20)
        Me.txtNumId.TabIndex = 2
        '
        'FrmGenerarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(171, 136)
        Me.Controls.Add(Me.txtNumId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerarNombre)
        Me.Name = "FrmGenerarReporte"
        Me.Text = "FrmGenerarReporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerarNombre As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumId As TextBox
End Class
