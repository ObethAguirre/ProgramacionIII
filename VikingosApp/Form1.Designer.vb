<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCliente
        '
        Me.BtnCliente.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCliente.Location = New System.Drawing.Point(298, 230)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(185, 40)
        Me.BtnCliente.TabIndex = 0
        Me.BtnCliente.Text = "Cliente"
        Me.BtnCliente.UseVisualStyleBackColor = False
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleado.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleado.ForeColor = System.Drawing.Color.White
        Me.BtnEmpleado.Location = New System.Drawing.Point(298, 324)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(185, 40)
        Me.BtnEmpleado.TabIndex = 1
        Me.BtnEmpleado.Text = "Empleado"
        Me.BtnEmpleado.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Mistral", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(157, 67)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(465, 101)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Barber Vikingos"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(590, 517)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(185, 49)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(800, 623)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.BtnEmpleado)
        Me.Controls.Add(Me.BtnCliente)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Name = "frmInicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCliente As Button
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents BtnSalir As Button
End Class
