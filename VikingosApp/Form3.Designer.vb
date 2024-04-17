<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgenda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.PicCorte = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.dateFech = New System.Windows.Forms.DateTimePicker()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cmbCorte = New System.Windows.Forms.ComboBox()
        CType(Me.PicCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 101)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agenda"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(82, 202)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(122, 30)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hora Fin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Corte: "
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Modern No. 20", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.Location = New System.Drawing.Point(589, 439)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(92, 30)
        Me.LabelPrecio.TabIndex = 9
        Me.LabelPrecio.Text = "Precio"
        '
        'PicCorte
        '
        Me.PicCorte.Location = New System.Drawing.Point(523, 194)
        Me.PicCorte.Name = "PicCorte"
        Me.PicCorte.Size = New System.Drawing.Size(324, 242)
        Me.PicCorte.TabIndex = 10
        Me.PicCorte.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(210, 209)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(249, 22)
        Me.txtNombre.TabIndex = 11
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(210, 272)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(249, 22)
        Me.txtHora.TabIndex = 12
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Location = New System.Drawing.Point(210, 414)
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.Size = New System.Drawing.Size(249, 22)
        Me.txtHoraFin.TabIndex = 14
        '
        'dateFech
        '
        Me.dateFech.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFech.Location = New System.Drawing.Point(210, 342)
        Me.dateFech.Name = "dateFech"
        Me.dateFech.Size = New System.Drawing.Size(249, 22)
        Me.dateFech.TabIndex = 16
        '
        'btnAgendar
        '
        Me.btnAgendar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgendar.Location = New System.Drawing.Point(594, 534)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(188, 42)
        Me.btnAgendar.TabIndex = 17
        Me.btnAgendar.Text = "Agendar"
        Me.btnAgendar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(594, 613)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(188, 42)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'cmbCorte
        '
        Me.cmbCorte.FormattingEnabled = True
        Me.cmbCorte.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbCorte.Location = New System.Drawing.Point(210, 482)
        Me.cmbCorte.Name = "cmbCorte"
        Me.cmbCorte.Size = New System.Drawing.Size(249, 24)
        Me.cmbCorte.TabIndex = 19
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(882, 701)
        Me.Controls.Add(Me.cmbCorte)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgendar)
        Me.Controls.Add(Me.dateFech)
        Me.Controls.Add(Me.txtHoraFin)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.PicCorte)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgenda"
        Me.Text = "Form3"
        CType(Me.PicCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents PicCorte As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtHoraFin As TextBox
    Friend WithEvents dateFech As DateTimePicker
    Friend WithEvents btnAgendar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents cmbCorte As ComboBox
End Class
