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
        Dim MatematicasLabel As System.Windows.Forms.Label
        Dim InglesLabel As System.Windows.Forms.Label
        Dim FisicaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.btnCargarFoto = New System.Windows.Forms.Button()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtMatematicas = New System.Windows.Forms.TextBox()
        Me.txtIngles = New System.Windows.Forms.TextBox()
        Me.txtFisica = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        MatematicasLabel = New System.Windows.Forms.Label()
        InglesLabel = New System.Windows.Forms.Label()
        FisicaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MatematicasLabel
        '
        MatematicasLabel.AutoSize = True
        MatematicasLabel.Location = New System.Drawing.Point(59, 279)
        MatematicasLabel.Name = "MatematicasLabel"
        MatematicasLabel.Size = New System.Drawing.Size(91, 17)
        MatematicasLabel.TabIndex = 46
        MatematicasLabel.Text = "Matematicas:"
        '
        'InglesLabel
        '
        InglesLabel.AutoSize = True
        InglesLabel.Location = New System.Drawing.Point(59, 209)
        InglesLabel.Name = "InglesLabel"
        InglesLabel.Size = New System.Drawing.Size(49, 17)
        InglesLabel.TabIndex = 44
        InglesLabel.Text = "Ingles:"
        '
        'FisicaLabel
        '
        FisicaLabel.AutoSize = True
        FisicaLabel.Location = New System.Drawing.Point(59, 142)
        FisicaLabel.Name = "FisicaLabel"
        FisicaLabel.Size = New System.Drawing.Size(48, 17)
        FisicaLabel.TabIndex = 42
        FisicaLabel.Text = "Fisica:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(308, 47)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 40
        NombreLabel.Text = "Nombre:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(59, 50)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(69, 17)
        MatriculaLabel.TabIndex = 38
        MatriculaLabel.Text = "Matricula:"
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\obeth\source\repos\Califica" &
    "cionAlumnoBDMetodo3\CalificacionAlumnoBDMetodo3\DBCalificacionAlumnoJPG.mdb"
        '
        'btnCargarFoto
        '
        Me.btnCargarFoto.Location = New System.Drawing.Point(701, 302)
        Me.btnCargarFoto.Name = "btnCargarFoto"
        Me.btnCargarFoto.Size = New System.Drawing.Size(107, 31)
        Me.btnCargarFoto.TabIndex = 37
        Me.btnCargarFoto.Text = "Cargar Foto"
        Me.btnCargarFoto.UseVisualStyleBackColor = True
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(728, 52)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(36, 17)
        Me.lblFoto.TabIndex = 36
        Me.lblFoto.Text = "Foto"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(639, 92)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(215, 204)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 35
        Me.picFoto.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(660, 376)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 23)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(548, 376)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(181, 376)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(309, 376)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregar.TabIndex = 31
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(438, 376)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 23)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(54, 376)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtMatematicas
        '
        Me.txtMatematicas.Location = New System.Drawing.Point(156, 276)
        Me.txtMatematicas.Name = "txtMatematicas"
        Me.txtMatematicas.Size = New System.Drawing.Size(100, 22)
        Me.txtMatematicas.TabIndex = 47
        '
        'txtIngles
        '
        Me.txtIngles.Location = New System.Drawing.Point(156, 206)
        Me.txtIngles.Name = "txtIngles"
        Me.txtIngles.Size = New System.Drawing.Size(100, 22)
        Me.txtIngles.TabIndex = 45
        '
        'txtFisica
        '
        Me.txtFisica.Location = New System.Drawing.Point(156, 139)
        Me.txtFisica.Name = "txtFisica"
        Me.txtFisica.Size = New System.Drawing.Size(100, 22)
        Me.txtFisica.TabIndex = 43
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(376, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(163, 22)
        Me.txtNombre.TabIndex = 41
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(134, 47)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 22)
        Me.txtMatricula.TabIndex = 39
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 450)
        Me.Controls.Add(MatematicasLabel)
        Me.Controls.Add(Me.txtMatematicas)
        Me.Controls.Add(InglesLabel)
        Me.Controls.Add(Me.txtIngles)
        Me.Controls.Add(FisicaLabel)
        Me.Controls.Add(Me.txtFisica)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.btnCargarFoto)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents btnCargarFoto As Button
    Friend WithEvents lblFoto As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtMatematicas As TextBox
    Friend WithEvents txtIngles As TextBox
    Friend WithEvents txtFisica As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
