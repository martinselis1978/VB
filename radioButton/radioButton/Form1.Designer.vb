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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.rbDescuento5 = New System.Windows.Forms.RadioButton()
        Me.rbDescuento10 = New System.Windows.Forms.RadioButton()
        Me.rbDescuento15 = New System.Windows.Forms.RadioButton()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.txtTotalCompraDescuento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(77, 300)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(121, 50)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'rbDescuento5
        '
        Me.rbDescuento5.AutoSize = True
        Me.rbDescuento5.Location = New System.Drawing.Point(543, 86)
        Me.rbDescuento5.Name = "rbDescuento5"
        Me.rbDescuento5.Size = New System.Drawing.Size(109, 17)
        Me.rbDescuento5.TabIndex = 1
        Me.rbDescuento5.TabStop = True
        Me.rbDescuento5.Text = "Descuento de 5%"
        Me.rbDescuento5.UseVisualStyleBackColor = True
        '
        'rbDescuento10
        '
        Me.rbDescuento10.AutoSize = True
        Me.rbDescuento10.Location = New System.Drawing.Point(543, 153)
        Me.rbDescuento10.Name = "rbDescuento10"
        Me.rbDescuento10.Size = New System.Drawing.Size(115, 17)
        Me.rbDescuento10.TabIndex = 2
        Me.rbDescuento10.TabStop = True
        Me.rbDescuento10.Text = "Descuento de 10%"
        Me.rbDescuento10.UseVisualStyleBackColor = True
        '
        'rbDescuento15
        '
        Me.rbDescuento15.AutoSize = True
        Me.rbDescuento15.Location = New System.Drawing.Point(543, 217)
        Me.rbDescuento15.Name = "rbDescuento15"
        Me.rbDescuento15.Size = New System.Drawing.Size(115, 17)
        Me.rbDescuento15.TabIndex = 3
        Me.rbDescuento15.TabStop = True
        Me.rbDescuento15.Text = "Descuento de 15%"
        Me.rbDescuento15.UseVisualStyleBackColor = True
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Location = New System.Drawing.Point(66, 96)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCompra.TabIndex = 4
        '
        'txtTotalCompraDescuento
        '
        Me.txtTotalCompraDescuento.Location = New System.Drawing.Point(66, 204)
        Me.txtTotalCompraDescuento.Name = "txtTotalCompraDescuento"
        Me.txtTotalCompraDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCompraDescuento.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total de la compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total de la compra con descuento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCompraDescuento)
        Me.Controls.Add(Me.txtTotalCompra)
        Me.Controls.Add(Me.rbDescuento15)
        Me.Controls.Add(Me.rbDescuento10)
        Me.Controls.Add(Me.rbDescuento5)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents rbDescuento5 As Windows.Forms.RadioButton
    Friend WithEvents rbDescuento10 As Windows.Forms.RadioButton
    Friend WithEvents rbDescuento15 As Windows.Forms.RadioButton
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents txtTotalCompraDescuento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
