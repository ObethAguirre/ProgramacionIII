<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistCortes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.DGVhistorialC = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVhistorialC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnConsultar.Location = New System.Drawing.Point(48, 628)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(226, 42)
        Me.BtnConsultar.TabIndex = 59
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(854, 628)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(226, 42)
        Me.btnVolver.TabIndex = 58
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'DGVhistorialC
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVhistorialC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVhistorialC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVhistorialC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVhistorialC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVhistorialC.Location = New System.Drawing.Point(48, 218)
        Me.DGVhistorialC.Name = "DGVhistorialC"
        Me.DGVhistorialC.RowHeadersWidth = 51
        Me.DGVhistorialC.RowTemplate.Height = 24
        Me.DGVhistorialC.Size = New System.Drawing.Size(1032, 349)
        Me.DGVhistorialC.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(602, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 31)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Fecha final:"
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInicio.Location = New System.Drawing.Point(42, 152)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(207, 31)
        Me.LblFechaInicio.TabIndex = 53
        Me.LblFechaInicio.Text = "Fecha Inicio:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(364, 59)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(401, 51)
        Me.lblTitulo.TabIndex = 52
        Me.lblTitulo.Text = "Historial de Cortes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateTimePickerFin
        '
        Me.DateTimePickerFin.Location = New System.Drawing.Point(880, 156)
        Me.DateTimePickerFin.Name = "DateTimePickerFin"
        Me.DateTimePickerFin.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerFin.TabIndex = 61
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(335, 156)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(201, 22)
        Me.DateTimePickerInicio.TabIndex = 60
        '
        'frmHistCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(1118, 700)
        Me.Controls.Add(Me.DateTimePickerFin)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.DGVhistorialC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmHistCortes"
        Me.Text = "Form10"
        CType(Me.DGVhistorialC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConsultar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents DGVhistorialC As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents DateTimePickerFin As DateTimePicker
    Friend WithEvents DateTimePickerInicio As DateTimePicker
End Class
