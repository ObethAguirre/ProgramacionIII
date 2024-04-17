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
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New M1.Database1DataSet()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.txbid = New System.Windows.Forms.TextBox()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.PersonaTableAdapter = New M1.Database1DataSetTableAdapters.PersonaTableAdapter()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(35, 376)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(102, 23)
        Me.btnCargarDatos.TabIndex = 0
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(419, 376)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(93, 23)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(290, 376)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(114, 23)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(162, 376)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(108, 23)
        Me.btnPrimero.TabIndex = 3
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(529, 376)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(95, 23)
        Me.btnUltimo.TabIndex = 4
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(641, 376)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PersonaBindingSource, "foto", True))
        Me.picFoto.Location = New System.Drawing.Point(480, 86)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(215, 204)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 6
        Me.picFoto.TabStop = False
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(58, 113)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(19, 17)
        Me.lblid.TabIndex = 7
        Me.lblid.Text = "id"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(58, 176)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(58, 250)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono"
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(577, 50)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(36, 17)
        Me.lblFoto.TabIndex = 10
        Me.lblFoto.Text = "Foto"
        '
        'txbid
        '
        Me.txbid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "Id", True))
        Me.txbid.Location = New System.Drawing.Point(182, 108)
        Me.txbid.Name = "txbid"
        Me.txbid.Size = New System.Drawing.Size(170, 22)
        Me.txbid.TabIndex = 11
        '
        'txbTelefono
        '
        Me.txbTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "telefono", True))
        Me.txbTelefono.Location = New System.Drawing.Point(182, 245)
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(170, 22)
        Me.txbTelefono.TabIndex = 12
        '
        'txbNombre
        '
        Me.txbNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "nombre", True))
        Me.txbNombre.Location = New System.Drawing.Point(182, 171)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(170, 22)
        Me.txbNombre.TabIndex = 13
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(756, 450)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbid)
        Me.Controls.Add(Me.lblFoto)
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
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCargarDatos As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblid As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblFoto As Label
    Friend WithEvents txbid As TextBox
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As Database1DataSetTableAdapters.PersonaTableAdapter
End Class
