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
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtConsultorio = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImagen
        '
        Me.btnImagen.BackColor = System.Drawing.Color.SpringGreen
        Me.btnImagen.Location = New System.Drawing.Point(130, 371)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(94, 23)
        Me.btnImagen.TabIndex = 58
        Me.btnImagen.Text = "IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = False
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Items.AddRange(New Object() {"Gastroenterologo", "Pediatra", "Internista"})
        Me.cmbEspecialidad.Location = New System.Drawing.Point(537, 231)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(222, 24)
        Me.cmbEspecialidad.TabIndex = 57
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnEliminar.Location = New System.Drawing.Point(545, 39)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.btnEliminar.TabIndex = 56
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnBuscar.Location = New System.Drawing.Point(178, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnAgregar.Location = New System.Drawing.Point(306, 39)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregar.TabIndex = 54
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnModificar.Location = New System.Drawing.Point(435, 39)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 23)
        Me.btnModificar.TabIndex = 53
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLimpiar.Location = New System.Drawing.Point(51, 39)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 52
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(537, 147)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 22)
        Me.txtNombre.TabIndex = 51
        '
        'txtConsultorio
        '
        Me.txtConsultorio.Location = New System.Drawing.Point(537, 273)
        Me.txtConsultorio.Name = "txtConsultorio"
        Me.txtConsultorio.Size = New System.Drawing.Size(222, 22)
        Me.txtConsultorio.TabIndex = 50
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(537, 192)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(222, 22)
        Me.txtApellido.TabIndex = 49
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(537, 99)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(222, 22)
        Me.txtCedula.TabIndex = 48
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(421, 278)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(79, 17)
        Me.lblPeso.TabIndex = 45
        Me.lblPeso.Text = "Consultorio"
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.Location = New System.Drawing.Point(421, 234)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(92, 17)
        Me.lblTam.TabIndex = 44
        Me.lblTam.Text = "Especialidad:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(421, 192)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(62, 17)
        Me.lblRaza.TabIndex = 43
        Me.lblRaza.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(421, 147)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 42
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(421, 102)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(52, 17)
        Me.lblCedula.TabIndex = 41
        Me.lblCedula.Text = "Cedula"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.SpringGreen
        Me.btnRegresar.Location = New System.Drawing.Point(604, 371)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(105, 26)
        Me.btnRegresar.TabIndex = 59
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(674, 39)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 23)
        Me.btnSalir.TabIndex = 60
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(51, 81)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(266, 277)
        Me.picFoto.TabIndex = 0
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.cmbEspecialidad)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtConsultorio)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblTam)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.picFoto)
        Me.Name = "Form2"
        Me.Text = "Medicos"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnImagen As Button
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtConsultorio As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblTam As Label
    Friend WithEvents lblRaza As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
