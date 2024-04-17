<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNSS = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNSS = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblNac = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(669, 46)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 23)
        Me.btnSalir.TabIndex = 79
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnRegresar.Location = New System.Drawing.Point(591, 400)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(105, 26)
        Me.btnRegresar.TabIndex = 78
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnImagen
        '
        Me.btnImagen.BackColor = System.Drawing.Color.SpringGreen
        Me.btnImagen.Location = New System.Drawing.Point(125, 378)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(94, 23)
        Me.btnImagen.TabIndex = 77
        Me.btnImagen.Text = "IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = False
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbSexo.Location = New System.Drawing.Point(532, 238)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(222, 24)
        Me.cmbSexo.TabIndex = 76
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnEliminar.Location = New System.Drawing.Point(540, 46)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.btnEliminar.TabIndex = 75
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnBuscar.Location = New System.Drawing.Point(173, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 74
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnAgregar.Location = New System.Drawing.Point(301, 46)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregar.TabIndex = 73
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnModificar.Location = New System.Drawing.Point(430, 46)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 23)
        Me.btnModificar.TabIndex = 72
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLimpiar.Location = New System.Drawing.Point(46, 46)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 71
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(532, 154)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 22)
        Me.txtNombre.TabIndex = 70
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(532, 280)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(222, 22)
        Me.txtEdad.TabIndex = 69
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(532, 199)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(222, 22)
        Me.txtApellido.TabIndex = 68
        '
        'txtNSS
        '
        Me.txtNSS.Location = New System.Drawing.Point(532, 106)
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Size = New System.Drawing.Size(222, 22)
        Me.txtNSS.TabIndex = 67
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(416, 285)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(45, 17)
        Me.lblPeso.TabIndex = 66
        Me.lblPeso.Text = "Edad:"
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.Location = New System.Drawing.Point(416, 241)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(43, 17)
        Me.lblTam.TabIndex = 65
        Me.lblTam.Text = "Sexo:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(416, 199)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(62, 17)
        Me.lblRaza.TabIndex = 64
        Me.lblRaza.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(416, 154)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 63
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNSS
        '
        Me.lblNSS.AutoSize = True
        Me.lblNSS.Location = New System.Drawing.Point(416, 109)
        Me.lblNSS.Name = "lblNSS"
        Me.lblNSS.Size = New System.Drawing.Size(36, 17)
        Me.lblNSS.TabIndex = 62
        Me.lblNSS.Text = "NSS"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(532, 328)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(222, 22)
        Me.dtpFecha.TabIndex = 81
        Me.dtpFecha.Value = New Date(2024, 2, 26, 0, 0, 0, 0)
        '
        'lblNac
        '
        Me.lblNac.AutoSize = True
        Me.lblNac.Location = New System.Drawing.Point(416, 333)
        Me.lblNac.Name = "lblNac"
        Me.lblNac.Size = New System.Drawing.Size(98, 17)
        Me.lblNac.TabIndex = 80
        Me.lblNac.Text = "Fecha Ingreso"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(46, 88)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(266, 277)
        Me.picFoto.TabIndex = 61
        Me.picFoto.TabStop = False
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\obeth\source\repos\AppHospi" &
    "tal\AppHospital\DBHospital.mdb"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblNac)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNSS)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblTam)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNSS)
        Me.Controls.Add(Me.picFoto)
        Me.Name = "Form3"
        Me.Text = "Pacientes"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnImagen As Button
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNSS As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblTam As Label
    Friend WithEvents lblRaza As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNSS As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblNac As Label
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
