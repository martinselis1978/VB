<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarAlumnos
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
        Me.dgvConsultar = New System.Windows.Forms.DataGridView()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgvConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultar
        '
        Me.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultar.Location = New System.Drawing.Point(13, 63)
        Me.dgvConsultar.Name = "dgvConsultar"
        Me.dgvConsultar.Size = New System.Drawing.Size(597, 217)
        Me.dgvConsultar.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(212, 12)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(202, 45)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'FrmConsultarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 292)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dgvConsultar)
        Me.Name = "FrmConsultarAlumnos"
        Me.Text = "FrmConsultarAlumnos"
        CType(Me.dgvConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvConsultar As DataGridView
    Friend WithEvents btnConsultar As Button
End Class
