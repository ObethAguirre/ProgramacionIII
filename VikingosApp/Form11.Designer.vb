<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.lblIdVenta = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(344, 76)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(375, 51)
        Me.lblTitulo.TabIndex = 53
        Me.lblTitulo.Text = "Registro de Venta" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(515, 300)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(393, 22)
        Me.txtIdCliente.TabIndex = 59
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(515, 253)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(393, 22)
        Me.txtIdProducto.TabIndex = 58
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(515, 207)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(393, 22)
        Me.txtIdVenta.TabIndex = 57
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.Location = New System.Drawing.Point(162, 294)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(171, 31)
        Me.lblIdCliente.TabIndex = 56
        Me.lblIdCliente.Text = "ID Clinete:"
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProducto.Location = New System.Drawing.Point(162, 247)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(200, 31)
        Me.lblIdProducto.TabIndex = 55
        Me.lblIdProducto.Text = "ID Producto:"
        '
        'lblIdVenta
        '
        Me.lblIdVenta.AutoSize = True
        Me.lblIdVenta.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdVenta.Location = New System.Drawing.Point(162, 201)
        Me.lblIdVenta.Name = "lblIdVenta"
        Me.lblIdVenta.Size = New System.Drawing.Size(152, 31)
        Me.lblIdVenta.TabIndex = 54
        Me.lblIdVenta.Text = "ID Venta:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(515, 349)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(393, 22)
        Me.txtNombre.TabIndex = 61
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(162, 343)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(134, 31)
        Me.lblNombre.TabIndex = 60
        Me.lblNombre.Text = "Nombre:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(515, 397)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(393, 22)
        Me.txtCantidad.TabIndex = 63
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(162, 391)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(297, 31)
        Me.lblCantidad.TabIndex = 62
        Me.lblCantidad.Text = "Cantidad Deseada:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(515, 446)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(393, 22)
        Me.txtPrecio.TabIndex = 65
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(162, 440)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(113, 31)
        Me.lblPrecio.TabIndex = 64
        Me.lblPrecio.Text = "Precio:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(162, 483)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(108, 31)
        Me.lblFecha.TabIndex = 66
        Me.lblFecha.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(515, 487)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(393, 22)
        Me.DateTimePicker1.TabIndex = 67
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnRegistrar.Location = New System.Drawing.Point(168, 608)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(226, 42)
        Me.BtnRegistrar.TabIndex = 69
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(682, 608)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(226, 42)
        Me.btnVolver.TabIndex = 68
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(1032, 713)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.lblIdProducto)
        Me.Controls.Add(Me.lblIdVenta)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmVentas"
        Me.Text = "Registro Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents lblIdVenta As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents btnVolver As Button
End Class
