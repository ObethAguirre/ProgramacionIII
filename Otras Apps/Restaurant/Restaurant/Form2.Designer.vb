<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.grpComidas = New System.Windows.Forms.GroupBox()
        Me.lblPrecioComidas = New System.Windows.Forms.Label()
        Me.picComidas = New System.Windows.Forms.PictureBox()
        Me.rbtFlautas = New System.Windows.Forms.RadioButton()
        Me.rbtMole = New System.Windows.Forms.RadioButton()
        Me.rbtPozole = New System.Windows.Forms.RadioButton()
        Me.rbtEnchiladas = New System.Windows.Forms.RadioButton()
        Me.grpPostres = New System.Windows.Forms.GroupBox()
        Me.lblPrecioPostres = New System.Windows.Forms.Label()
        Me.lstPostres = New System.Windows.Forms.ListBox()
        Me.picPostres = New System.Windows.Forms.PictureBox()
        Me.grpBebidas = New System.Windows.Forms.GroupBox()
        Me.cmbBebidas = New System.Windows.Forms.ComboBox()
        Me.lblPrecioBebidas = New System.Windows.Forms.Label()
        Me.picBebidas = New System.Windows.Forms.PictureBox()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.grpComidas.SuspendLayout()
        CType(Me.picComidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPostres.SuspendLayout()
        CType(Me.picPostres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBebidas.SuspendLayout()
        CType(Me.picBebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpComidas
        '
        Me.grpComidas.Controls.Add(Me.lblPrecioComidas)
        Me.grpComidas.Controls.Add(Me.picComidas)
        Me.grpComidas.Controls.Add(Me.rbtFlautas)
        Me.grpComidas.Controls.Add(Me.rbtMole)
        Me.grpComidas.Controls.Add(Me.rbtPozole)
        Me.grpComidas.Controls.Add(Me.rbtEnchiladas)
        Me.grpComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpComidas.Location = New System.Drawing.Point(12, 12)
        Me.grpComidas.Name = "grpComidas"
        Me.grpComidas.Size = New System.Drawing.Size(468, 178)
        Me.grpComidas.TabIndex = 0
        Me.grpComidas.TabStop = False
        Me.grpComidas.Text = "Comidas"
        '
        'lblPrecioComidas
        '
        Me.lblPrecioComidas.AutoSize = True
        Me.lblPrecioComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioComidas.Location = New System.Drawing.Point(387, 81)
        Me.lblPrecioComidas.Name = "lblPrecioComidas"
        Me.lblPrecioComidas.Size = New System.Drawing.Size(63, 20)
        Me.lblPrecioComidas.TabIndex = 5
        Me.lblPrecioComidas.Text = "Precio"
        '
        'picComidas
        '
        Me.picComidas.Location = New System.Drawing.Point(211, 40)
        Me.picComidas.Name = "picComidas"
        Me.picComidas.Size = New System.Drawing.Size(168, 110)
        Me.picComidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComidas.TabIndex = 4
        Me.picComidas.TabStop = False
        '
        'rbtFlautas
        '
        Me.rbtFlautas.AutoSize = True
        Me.rbtFlautas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFlautas.Location = New System.Drawing.Point(6, 126)
        Me.rbtFlautas.Name = "rbtFlautas"
        Me.rbtFlautas.Size = New System.Drawing.Size(85, 24)
        Me.rbtFlautas.TabIndex = 3
        Me.rbtFlautas.TabStop = True
        Me.rbtFlautas.Text = "Flautas"
        Me.rbtFlautas.UseVisualStyleBackColor = True
        '
        'rbtMole
        '
        Me.rbtMole.AutoSize = True
        Me.rbtMole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMole.Location = New System.Drawing.Point(6, 66)
        Me.rbtMole.Name = "rbtMole"
        Me.rbtMole.Size = New System.Drawing.Size(66, 24)
        Me.rbtMole.TabIndex = 2
        Me.rbtMole.TabStop = True
        Me.rbtMole.Text = "Mole"
        Me.rbtMole.UseVisualStyleBackColor = True
        '
        'rbtPozole
        '
        Me.rbtPozole.AutoSize = True
        Me.rbtPozole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtPozole.Location = New System.Drawing.Point(6, 96)
        Me.rbtPozole.Name = "rbtPozole"
        Me.rbtPozole.Size = New System.Drawing.Size(81, 24)
        Me.rbtPozole.TabIndex = 1
        Me.rbtPozole.TabStop = True
        Me.rbtPozole.Text = "Pozole"
        Me.rbtPozole.UseVisualStyleBackColor = True
        '
        'rbtEnchiladas
        '
        Me.rbtEnchiladas.AutoSize = True
        Me.rbtEnchiladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEnchiladas.Location = New System.Drawing.Point(6, 36)
        Me.rbtEnchiladas.Name = "rbtEnchiladas"
        Me.rbtEnchiladas.Size = New System.Drawing.Size(112, 24)
        Me.rbtEnchiladas.TabIndex = 0
        Me.rbtEnchiladas.TabStop = True
        Me.rbtEnchiladas.Text = "Enchiladas"
        Me.rbtEnchiladas.UseVisualStyleBackColor = True
        '
        'grpPostres
        '
        Me.grpPostres.Controls.Add(Me.lblPrecioPostres)
        Me.grpPostres.Controls.Add(Me.lstPostres)
        Me.grpPostres.Controls.Add(Me.picPostres)
        Me.grpPostres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPostres.Location = New System.Drawing.Point(12, 210)
        Me.grpPostres.Name = "grpPostres"
        Me.grpPostres.Size = New System.Drawing.Size(468, 178)
        Me.grpPostres.TabIndex = 5
        Me.grpPostres.TabStop = False
        Me.grpPostres.Text = "Postres"
        '
        'lblPrecioPostres
        '
        Me.lblPrecioPostres.AutoSize = True
        Me.lblPrecioPostres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioPostres.Location = New System.Drawing.Point(387, 83)
        Me.lblPrecioPostres.Name = "lblPrecioPostres"
        Me.lblPrecioPostres.Size = New System.Drawing.Size(63, 20)
        Me.lblPrecioPostres.TabIndex = 6
        Me.lblPrecioPostres.Text = "Precio"
        '
        'lstPostres
        '
        Me.lstPostres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPostres.FormattingEnabled = True
        Me.lstPostres.ItemHeight = 20
        Me.lstPostres.Items.AddRange(New Object() {"Helado de Fresa", "Helado de Núez", "Helado de Vainilla", "Helado de Chocolate", "Flan", "Buñuelos"})
        Me.lstPostres.Location = New System.Drawing.Point(6, 40)
        Me.lstPostres.Name = "lstPostres"
        Me.lstPostres.Size = New System.Drawing.Size(188, 124)
        Me.lstPostres.TabIndex = 5
        '
        'picPostres
        '
        Me.picPostres.Location = New System.Drawing.Point(211, 40)
        Me.picPostres.Name = "picPostres"
        Me.picPostres.Size = New System.Drawing.Size(168, 110)
        Me.picPostres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPostres.TabIndex = 4
        Me.picPostres.TabStop = False
        '
        'grpBebidas
        '
        Me.grpBebidas.Controls.Add(Me.cmbBebidas)
        Me.grpBebidas.Controls.Add(Me.lblPrecioBebidas)
        Me.grpBebidas.Controls.Add(Me.picBebidas)
        Me.grpBebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBebidas.Location = New System.Drawing.Point(12, 394)
        Me.grpBebidas.Name = "grpBebidas"
        Me.grpBebidas.Size = New System.Drawing.Size(468, 178)
        Me.grpBebidas.TabIndex = 6
        Me.grpBebidas.TabStop = False
        Me.grpBebidas.Text = "Comidas"
        '
        'cmbBebidas
        '
        Me.cmbBebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBebidas.FormattingEnabled = True
        Me.cmbBebidas.Items.AddRange(New Object() {"Agua de Piña", "Agua de Limon", "Agua de Jamaica", "CocaCola", "Fresca", "Manzanita"})
        Me.cmbBebidas.Location = New System.Drawing.Point(6, 81)
        Me.cmbBebidas.Name = "cmbBebidas"
        Me.cmbBebidas.Size = New System.Drawing.Size(121, 28)
        Me.cmbBebidas.TabIndex = 6
        '
        'lblPrecioBebidas
        '
        Me.lblPrecioBebidas.AutoSize = True
        Me.lblPrecioBebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioBebidas.Location = New System.Drawing.Point(387, 81)
        Me.lblPrecioBebidas.Name = "lblPrecioBebidas"
        Me.lblPrecioBebidas.Size = New System.Drawing.Size(63, 20)
        Me.lblPrecioBebidas.TabIndex = 5
        Me.lblPrecioBebidas.Text = "Precio"
        '
        'picBebidas
        '
        Me.picBebidas.Location = New System.Drawing.Point(211, 40)
        Me.picBebidas.Name = "picBebidas"
        Me.picBebidas.Size = New System.Drawing.Size(168, 110)
        Me.picBebidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBebidas.TabIndex = 4
        Me.picBebidas.TabStop = False
        '
        'btnCuenta
        '
        Me.btnCuenta.Location = New System.Drawing.Point(186, 588)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(107, 37)
        Me.btnCuenta.TabIndex = 7
        Me.btnCuenta.Text = "Cuenta"
        Me.btnCuenta.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 637)
        Me.Controls.Add(Me.btnCuenta)
        Me.Controls.Add(Me.grpBebidas)
        Me.Controls.Add(Me.grpPostres)
        Me.Controls.Add(Me.grpComidas)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.grpComidas.ResumeLayout(False)
        Me.grpComidas.PerformLayout()
        CType(Me.picComidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPostres.ResumeLayout(False)
        Me.grpPostres.PerformLayout()
        CType(Me.picPostres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBebidas.ResumeLayout(False)
        Me.grpBebidas.PerformLayout()
        CType(Me.picBebidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpComidas As GroupBox
    Friend WithEvents lblPrecioComidas As Label
    Friend WithEvents picComidas As PictureBox
    Friend WithEvents rbtFlautas As RadioButton
    Friend WithEvents rbtMole As RadioButton
    Friend WithEvents rbtPozole As RadioButton
    Friend WithEvents rbtEnchiladas As RadioButton
    Friend WithEvents grpPostres As GroupBox
    Friend WithEvents lblPrecioPostres As Label
    Friend WithEvents lstPostres As ListBox
    Friend WithEvents picPostres As PictureBox
    Friend WithEvents grpBebidas As GroupBox
    Friend WithEvents cmbBebidas As ComboBox
    Friend WithEvents lblPrecioBebidas As Label
    Friend WithEvents picBebidas As PictureBox
    Friend WithEvents btnCuenta As Button
End Class
