<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Me.LblIdEmpleado = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Mistral", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(247, 65)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(326, 101)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Empleados"
        '
        'LblIdEmpleado
        '
        Me.LblIdEmpleado.AutoSize = True
        Me.LblIdEmpleado.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdEmpleado.Location = New System.Drawing.Point(133, 240)
        Me.LblIdEmpleado.Name = "LblIdEmpleado"
        Me.LblIdEmpleado.Size = New System.Drawing.Size(178, 30)
        Me.LblIdEmpleado.TabIndex = 15
        Me.LblIdEmpleado.Text = "Id Empleado:"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(133, 330)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(155, 30)
        Me.LblContraseña.TabIndex = 16
        Me.LblContraseña.Text = "Contraseña:"
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(330, 247)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(172, 22)
        Me.TxtIdEmpleado.TabIndex = 17
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(330, 337)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(172, 22)
        Me.TxtContraseña.TabIndex = 18
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnContinuar.Location = New System.Drawing.Point(314, 478)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(188, 42)
        Me.btnContinuar.TabIndex = 19
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVolver.Location = New System.Drawing.Point(314, 569)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(188, 42)
        Me.BtnVolver.TabIndex = 20
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(795, 704)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblIdEmpleado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmEmpleado"
        Me.Text = "Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents LblIdEmpleado As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents btnContinuar As Button
    Friend WithEvents BtnVolver As Button
End Class
