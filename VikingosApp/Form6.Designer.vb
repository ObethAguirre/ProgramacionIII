<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnCortes = New System.Windows.Forms.Button()
        Me.btnHistorialVentas = New System.Windows.Forms.Button()
        Me.btnHistorialCortes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Mistral", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(349, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(215, 101)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "MENU"
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProductos.Location = New System.Drawing.Point(88, 207)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(346, 42)
        Me.btnProductos.TabIndex = 21
        Me.btnProductos.Text = "Administrar Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnCortes
        '
        Me.btnCortes.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnCortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCortes.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCortes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCortes.Location = New System.Drawing.Point(498, 207)
        Me.btnCortes.Name = "btnCortes"
        Me.btnCortes.Size = New System.Drawing.Size(346, 42)
        Me.btnCortes.TabIndex = 22
        Me.btnCortes.Text = "Administrar Cortes"
        Me.btnCortes.UseVisualStyleBackColor = False
        '
        'btnHistorialVentas
        '
        Me.btnHistorialVentas.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialVentas.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHistorialVentas.Location = New System.Drawing.Point(107, 317)
        Me.btnHistorialVentas.Name = "btnHistorialVentas"
        Me.btnHistorialVentas.Size = New System.Drawing.Size(285, 42)
        Me.btnHistorialVentas.TabIndex = 23
        Me.btnHistorialVentas.Text = "Historial Ventas"
        Me.btnHistorialVentas.UseVisualStyleBackColor = False
        '
        'btnHistorialCortes
        '
        Me.btnHistorialCortes.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnHistorialCortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialCortes.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialCortes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHistorialCortes.Location = New System.Drawing.Point(498, 317)
        Me.btnHistorialCortes.Name = "btnHistorialCortes"
        Me.btnHistorialCortes.Size = New System.Drawing.Size(346, 42)
        Me.btnHistorialCortes.TabIndex = 24
        Me.btnHistorialCortes.Text = "Historial Cortes"
        Me.btnHistorialCortes.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVentas.Location = New System.Drawing.Point(306, 423)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(285, 42)
        Me.btnVentas.TabIndex = 25
        Me.btnVentas.Text = "Registrar Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(686, 628)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(226, 42)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(936, 692)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnHistorialCortes)
        Me.Controls.Add(Me.btnHistorialVentas)
        Me.Controls.Add(Me.btnCortes)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnCortes As Button
    Friend WithEvents btnHistorialVentas As Button
    Friend WithEvents btnHistorialCortes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnVolver As Button
End Class
