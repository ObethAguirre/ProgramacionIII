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
        Me.cmbEdad = New System.Windows.Forms.ComboBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txbPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txbEstatura = New System.Windows.Forms.TextBox()
        Me.lblEstatura = New System.Windows.Forms.Label()
        Me.cmbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.grpSexo = New System.Windows.Forms.GroupBox()
        Me.rbtnFemenino = New System.Windows.Forms.RadioButton()
        Me.rbtnMasculino = New System.Windows.Forms.RadioButton()
        Me.grpQuestion = New System.Windows.Forms.GroupBox()
        Me.chkPregunta = New System.Windows.Forms.CheckedListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.grpNacionalidad = New System.Windows.Forms.GroupBox()
        Me.grpSexo.SuspendLayout()
        Me.grpQuestion.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.grpNacionalidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbEdad
        '
        Me.cmbEdad.AccessibleName = "ranEdad"
        Me.cmbEdad.FormattingEnabled = True
        Me.cmbEdad.Items.AddRange(New Object() {"10 - 20", "20 - 30", "30 - 40", "40 - 50", "50 - 60"})
        Me.cmbEdad.Location = New System.Drawing.Point(21, 241)
        Me.cmbEdad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEdad.Name = "cmbEdad"
        Me.cmbEdad.Size = New System.Drawing.Size(121, 24)
        Me.cmbEdad.TabIndex = 8
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(21, 220)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(106, 17)
        Me.lblEdad.TabIndex = 7
        Me.lblEdad.Text = "Rango de edad"
        '
        'txbPeso
        '
        Me.txbPeso.AccessibleName = "Peso"
        Me.txbPeso.Location = New System.Drawing.Point(21, 180)
        Me.txbPeso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbPeso.Name = "txbPeso"
        Me.txbPeso.Size = New System.Drawing.Size(100, 22)
        Me.txbPeso.TabIndex = 6
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(19, 159)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(40, 17)
        Me.lblPeso.TabIndex = 5
        Me.lblPeso.Text = "Peso"
        '
        'txbEstatura
        '
        Me.txbEstatura.AccessibleName = "Estatura"
        Me.txbEstatura.Location = New System.Drawing.Point(21, 121)
        Me.txbEstatura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbEstatura.Name = "txbEstatura"
        Me.txbEstatura.Size = New System.Drawing.Size(100, 22)
        Me.txbEstatura.TabIndex = 4
        '
        'lblEstatura
        '
        Me.lblEstatura.AutoSize = True
        Me.lblEstatura.Location = New System.Drawing.Point(19, 100)
        Me.lblEstatura.Name = "lblEstatura"
        Me.lblEstatura.Size = New System.Drawing.Size(61, 17)
        Me.lblEstatura.TabIndex = 3
        Me.lblEstatura.Text = "Estatura"
        '
        'cmbNacionalidad
        '
        Me.cmbNacionalidad.AccessibleName = "ranEdad"
        Me.cmbNacionalidad.FormattingEnabled = True
        Me.cmbNacionalidad.Items.AddRange(New Object() {"Mexicana", "Estadounidense", "Española", "Inglesa"})
        Me.cmbNacionalidad.Location = New System.Drawing.Point(20, 37)
        Me.cmbNacionalidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNacionalidad.Name = "cmbNacionalidad"
        Me.cmbNacionalidad.Size = New System.Drawing.Size(195, 24)
        Me.cmbNacionalidad.TabIndex = 8
        '
        'grpSexo
        '
        Me.grpSexo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpSexo.Controls.Add(Me.rbtnFemenino)
        Me.grpSexo.Controls.Add(Me.rbtnMasculino)
        Me.grpSexo.Location = New System.Drawing.Point(329, 12)
        Me.grpSexo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSexo.Name = "grpSexo"
        Me.grpSexo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSexo.Size = New System.Drawing.Size(177, 123)
        Me.grpSexo.TabIndex = 3
        Me.grpSexo.TabStop = False
        Me.grpSexo.Text = "Sexo"
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(24, 74)
        Me.rbtnFemenino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(91, 21)
        Me.rbtnFemenino.TabIndex = 0
        Me.rbtnFemenino.TabStop = True
        Me.rbtnFemenino.Text = "Femenino"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(24, 36)
        Me.rbtnMasculino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(92, 21)
        Me.rbtnMasculino.TabIndex = 0
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'grpQuestion
        '
        Me.grpQuestion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpQuestion.Controls.Add(Me.chkPregunta)
        Me.grpQuestion.Location = New System.Drawing.Point(329, 169)
        Me.grpQuestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpQuestion.Name = "grpQuestion"
        Me.grpQuestion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpQuestion.Size = New System.Drawing.Size(319, 138)
        Me.grpQuestion.TabIndex = 4
        Me.grpQuestion.TabStop = False
        Me.grpQuestion.Text = "¿Usted consume alguna de estas sustancias?"
        '
        'chkPregunta
        '
        Me.chkPregunta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.chkPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkPregunta.FormattingEnabled = True
        Me.chkPregunta.Items.AddRange(New Object() {"Alchol", "Tabaco", "Drogas", "Medicamentos prescritos"})
        Me.chkPregunta.Location = New System.Drawing.Point(24, 36)
        Me.chkPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPregunta.Name = "chkPregunta"
        Me.chkPregunta.Size = New System.Drawing.Size(260, 68)
        Me.chkPregunta.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcular.Location = New System.Drawing.Point(437, 325)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(437, 375)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.cmbEdad)
        Me.grpDatos.Controls.Add(Me.lblEdad)
        Me.grpDatos.Controls.Add(Me.lblNombre)
        Me.grpDatos.Controls.Add(Me.txbPeso)
        Me.grpDatos.Controls.Add(Me.txbNombre)
        Me.grpDatos.Controls.Add(Me.lblPeso)
        Me.grpDatos.Controls.Add(Me.lblEstatura)
        Me.grpDatos.Controls.Add(Me.txbEstatura)
        Me.grpDatos.Location = New System.Drawing.Point(12, 16)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatos.Size = New System.Drawing.Size(297, 289)
        Me.grpDatos.TabIndex = 6
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos del Paciente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txbNombre
        '
        Me.txbNombre.AccessibleName = "Nombre"
        Me.txbNombre.Location = New System.Drawing.Point(20, 58)
        Me.txbNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(256, 22)
        Me.txbNombre.TabIndex = 2
        '
        'grpNacionalidad
        '
        Me.grpNacionalidad.Controls.Add(Me.cmbNacionalidad)
        Me.grpNacionalidad.Location = New System.Drawing.Point(12, 325)
        Me.grpNacionalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpNacionalidad.Name = "grpNacionalidad"
        Me.grpNacionalidad.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpNacionalidad.Size = New System.Drawing.Size(297, 102)
        Me.grpNacionalidad.TabIndex = 7
        Me.grpNacionalidad.TabStop = False
        Me.grpNacionalidad.Text = "Nacionalidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(660, 441)
        Me.Controls.Add(Me.grpNacionalidad)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.grpQuestion)
        Me.Controls.Add(Me.grpSexo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Tag = ""
        Me.Text = "10-15"
        Me.grpSexo.ResumeLayout(False)
        Me.grpSexo.PerformLayout()
        Me.grpQuestion.ResumeLayout(False)
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.grpNacionalidad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEstatura As Label
    Friend WithEvents cmbEdad As ComboBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents txbPeso As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents txbEstatura As TextBox
    Friend WithEvents cmbNacionalidad As ComboBox
    Friend WithEvents grpSexo As GroupBox
    Friend WithEvents grpQuestion As GroupBox
    Friend WithEvents chkPregunta As CheckedListBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents grpNacionalidad As GroupBox
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton
End Class
