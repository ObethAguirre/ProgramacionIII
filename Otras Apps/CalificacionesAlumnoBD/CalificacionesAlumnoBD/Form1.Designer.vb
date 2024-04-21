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
        Me.components = New System.ComponentModel.Container()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txtFisica = New System.Windows.Forms.TextBox()
        Me.txbid = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.txtMatematicas = New System.Windows.Forms.TextBox()
        Me.lblMatematicas = New System.Windows.Forms.Label()
        Me.txtIngles = New System.Windows.Forms.TextBox()
        Me.lblIngles = New System.Windows.Forms.Label()
        Me.DBCalificacionAlumnoDataSet = New CalificacionesAlumnoBDMetodo1.DBCalificacionAlumnoDataSet()
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabla1TableAdapter = New CalificacionesAlumnoBDMetodo1.DBCalificacionAlumnoDataSetTableAdapters.Tabla1TableAdapter()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCalificacionAlumnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbNombre
        '
        Me.txbNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Nombre", True))
        Me.txbNombre.Location = New System.Drawing.Point(457, 47)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(170, 22)
        Me.txbNombre.TabIndex = 27
        '
        'txtFisica
        '
        Me.txtFisica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Fisica", True))
        Me.txtFisica.Location = New System.Drawing.Point(88, 193)
        Me.txtFisica.Name = "txtFisica"
        Me.txtFisica.Size = New System.Drawing.Size(56, 22)
        Me.txtFisica.TabIndex = 26
        '
        'txbid
        '
        Me.txbid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Matricula", True))
        Me.txbid.Location = New System.Drawing.Point(133, 47)
        Me.txbid.Name = "txbid"
        Me.txbid.Size = New System.Drawing.Size(170, 22)
        Me.txbid.TabIndex = 25
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(85, 159)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(44, 17)
        Me.lblTelefono.TabIndex = 23
        Me.lblTelefono.Text = "Fisica"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(372, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(32, 47)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(73, 17)
        Me.lblid.TabIndex = 21
        Me.lblid.Text = "Matricula :"
        '
        'picFoto
        '
        Me.picFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tabla1BindingSource, "Fotografia", True))
        Me.picFoto.Location = New System.Drawing.Point(512, 107)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(215, 204)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 20
        Me.picFoto.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(694, 385)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(582, 385)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(95, 23)
        Me.btnUltimo.TabIndex = 18
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(215, 385)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(108, 23)
        Me.btnPrimero.TabIndex = 17
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(343, 385)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(114, 23)
        Me.btnAnterior.TabIndex = 16
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(472, 385)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(93, 23)
        Me.btnSiguiente.TabIndex = 15
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(88, 385)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(102, 23)
        Me.btnCargarDatos.TabIndex = 14
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'txtMatematicas
        '
        Me.txtMatematicas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Matematicas", True))
        Me.txtMatematicas.Location = New System.Drawing.Point(358, 193)
        Me.txtMatematicas.Name = "txtMatematicas"
        Me.txtMatematicas.Size = New System.Drawing.Size(56, 22)
        Me.txtMatematicas.TabIndex = 29
        '
        'lblMatematicas
        '
        Me.lblMatematicas.AutoSize = True
        Me.lblMatematicas.Location = New System.Drawing.Point(355, 159)
        Me.lblMatematicas.Name = "lblMatematicas"
        Me.lblMatematicas.Size = New System.Drawing.Size(87, 17)
        Me.lblMatematicas.TabIndex = 28
        Me.lblMatematicas.Text = "Matematicas"
        '
        'txtIngles
        '
        Me.txtIngles.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Ingles", True))
        Me.txtIngles.Location = New System.Drawing.Point(215, 193)
        Me.txtIngles.Name = "txtIngles"
        Me.txtIngles.Size = New System.Drawing.Size(56, 22)
        Me.txtIngles.TabIndex = 31
        '
        'lblIngles
        '
        Me.lblIngles.AutoSize = True
        Me.lblIngles.Location = New System.Drawing.Point(212, 159)
        Me.lblIngles.Name = "lblIngles"
        Me.lblIngles.Size = New System.Drawing.Size(45, 17)
        Me.lblIngles.TabIndex = 30
        Me.lblIngles.Text = "Ingles"
        '
        'DBCalificacionAlumnoDataSet
        '
        Me.DBCalificacionAlumnoDataSet.DataSetName = "DBCalificacionAlumnoDataSet"
        Me.DBCalificacionAlumnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.DBCalificacionAlumnoDataSet
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 504)
        Me.Controls.Add(Me.txtIngles)
        Me.Controls.Add(Me.lblIngles)
        Me.Controls.Add(Me.txtMatematicas)
        Me.Controls.Add(Me.lblMatematicas)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txtFisica)
        Me.Controls.Add(Me.txbid)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCalificacionAlumnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txtFisica As TextBox
    Friend WithEvents txbid As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblid As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCargarDatos As Button
    Friend WithEvents txtMatematicas As TextBox
    Friend WithEvents lblMatematicas As Label
    Friend WithEvents txtIngles As TextBox
    Friend WithEvents lblIngles As Label
    Friend WithEvents DBCalificacionAlumnoDataSet As DBCalificacionAlumnoDataSet
    Friend WithEvents Tabla1BindingSource As BindingSource
    Friend WithEvents Tabla1TableAdapter As DBCalificacionAlumnoDataSetTableAdapters.Tabla1TableAdapter
End Class
