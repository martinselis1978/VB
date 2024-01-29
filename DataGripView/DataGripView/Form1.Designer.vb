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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtTotalAP = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblTotalAgregarProductos = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPrecioU = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnVerTotales = New System.Windows.Forms.Button()
        Me.txtTotalTotales = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblTotalTotales = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.codigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtTotalAP)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecioU)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblTotalAgregarProductos)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.lblPrecioU)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Productos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(18, 71)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtTotalAP
        '
        Me.txtTotalAP.Location = New System.Drawing.Point(649, 32)
        Me.txtTotalAP.Name = "txtTotalAP"
        Me.txtTotalAP.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalAP.TabIndex = 9
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(570, 32)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'txtPrecioU
        '
        Me.txtPrecioU.Location = New System.Drawing.Point(464, 32)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioU.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(346, 20)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(6, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'lblTotalAgregarProductos
        '
        Me.lblTotalAgregarProductos.AutoSize = True
        Me.lblTotalAgregarProductos.Location = New System.Drawing.Point(689, 16)
        Me.lblTotalAgregarProductos.Name = "lblTotalAgregarProductos"
        Me.lblTotalAgregarProductos.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalAgregarProductos.TabIndex = 4
        Me.lblTotalAgregarProductos.Text = "Total"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(580, 16)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblPrecioU
        '
        Me.lblPrecioU.AutoSize = True
        Me.lblPrecioU.Location = New System.Drawing.Point(489, 16)
        Me.lblPrecioU.Name = "lblPrecioU"
        Me.lblPrecioU.Size = New System.Drawing.Size(50, 13)
        Me.lblPrecioU.TabIndex = 2
        Me.lblPrecioU.Text = "Precio/U"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(250, 16)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(37, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProductos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 166)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos Agregados"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoProducto, Me.descripcionProducto, Me.precioProducto, Me.cantidadProducto, Me.totalProducto})
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Location = New System.Drawing.Point(3, 16)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(769, 147)
        Me.dgvProductos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnVerTotales)
        Me.GroupBox3.Controls.Add(Me.txtTotalTotales)
        Me.GroupBox3.Controls.Add(Me.txtIva)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblTotalTotales)
        Me.GroupBox3.Controls.Add(Me.lblIva)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(774, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'btnVerTotales
        '
        Me.btnVerTotales.Location = New System.Drawing.Point(18, 71)
        Me.btnVerTotales.Name = "btnVerTotales"
        Me.btnVerTotales.Size = New System.Drawing.Size(75, 23)
        Me.btnVerTotales.TabIndex = 6
        Me.btnVerTotales.Text = "Ver Totales"
        Me.btnVerTotales.UseVisualStyleBackColor = True
        '
        'txtTotalTotales
        '
        Me.txtTotalTotales.Location = New System.Drawing.Point(559, 32)
        Me.txtTotalTotales.Name = "txtTotalTotales"
        Me.txtTotalTotales.Size = New System.Drawing.Size(197, 20)
        Me.txtTotalTotales.TabIndex = 5
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(293, 32)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(197, 20)
        Me.txtIva.TabIndex = 4
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(18, 32)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(197, 20)
        Me.txtSubTotal.TabIndex = 3
        '
        'lblTotalTotales
        '
        Me.lblTotalTotales.AutoSize = True
        Me.lblTotalTotales.Location = New System.Drawing.Point(646, 16)
        Me.lblTotalTotales.Name = "lblTotalTotales"
        Me.lblTotalTotales.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalTotales.TabIndex = 2
        Me.lblTotalTotales.Text = "Total"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(375, 16)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(47, 13)
        Me.lblIva.TabIndex = 1
        Me.lblIva.Text = "IVA 19%"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(94, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "Sub Total"
        '
        'codigoProducto
        '
        Me.codigoProducto.HeaderText = "Código"
        Me.codigoProducto.Name = "codigoProducto"
        '
        'descripcionProducto
        '
        Me.descripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcionProducto.HeaderText = "Descripción"
        Me.descripcionProducto.Name = "descripcionProducto"
        '
        'precioProducto
        '
        Me.precioProducto.HeaderText = "Precio/U"
        Me.precioProducto.Name = "precioProducto"
        '
        'cantidadProducto
        '
        Me.cantidadProducto.HeaderText = "Cantidad"
        Me.cantidadProducto.Name = "cantidadProducto"
        '
        'totalProducto
        '
        Me.totalProducto.HeaderText = "Total"
        Me.totalProducto.Name = "totalProducto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalAgregarProductos As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPrecioU As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtTotalAP As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnVerTotales As Button
    Friend WithEvents txtTotalTotales As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblTotalTotales As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents codigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents descripcionProducto As DataGridViewTextBoxColumn
    Friend WithEvents precioProducto As DataGridViewTextBoxColumn
    Friend WithEvents cantidadProducto As DataGridViewTextBoxColumn
    Friend WithEvents totalProducto As DataGridViewTextBoxColumn
End Class
