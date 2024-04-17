<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistProductosVentas
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVhistorialP = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVhistorialP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(236, 65)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(677, 51)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Historial de Ventas de Productos"
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInicio.Location = New System.Drawing.Point(43, 167)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(207, 31)
        Me.LblFechaInicio.TabIndex = 37
        Me.LblFechaInicio.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(612, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Fecha final:"
        '
        'DGVhistorialP
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DGVhistorialP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVhistorialP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVhistorialP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVhistorialP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVhistorialP.Location = New System.Drawing.Point(49, 233)
        Me.DGVhistorialP.Name = "DGVhistorialP"
        Me.DGVhistorialP.RowHeadersWidth = 51
        Me.DGVhistorialP.RowTemplate.Height = 24
        Me.DGVhistorialP.Size = New System.Drawing.Size(1032, 349)
        Me.DGVhistorialP.TabIndex = 49
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(855, 643)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(226, 42)
        Me.btnVolver.TabIndex = 50
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnConsultar.Location = New System.Drawing.Point(49, 643)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(226, 42)
        Me.BtnConsultar.TabIndex = 51
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(347, 171)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(201, 22)
        Me.DateTimePickerInicio.TabIndex = 52
        '
        'DateTimePickerFin
        '
        Me.DateTimePickerFin.Location = New System.Drawing.Point(881, 175)
        Me.DateTimePickerFin.Name = "DateTimePickerFin"
        Me.DateTimePickerFin.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerFin.TabIndex = 53
        '
        'FrmHistProductosVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(1143, 699)
        Me.Controls.Add(Me.DateTimePickerFin)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.DGVhistorialP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmHistProductosVentas"
        Me.Text = "Historial Productos"
        CType(Me.DGVhistorialP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents LblFechaInicio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVhistorialP As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents DateTimePickerFin As DateTimePicker
End Class
