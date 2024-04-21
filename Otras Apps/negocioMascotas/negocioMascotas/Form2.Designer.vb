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
        Me.components = New System.ComponentModel.Container()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblNac = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtTam = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MascotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NegocioMascotasDBDataSet = New negocioMascotas.negocioMascotasDBDataSet()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.MascotasTableAdapter = New negocioMascotas.negocioMascotasDBDataSetTableAdapters.MascotasTableAdapter()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbRaza = New System.Windows.Forms.ComboBox()
        Me.btnImagen = New System.Windows.Forms.Button()
        CType(Me.MascotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NegocioMascotasDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(395, 101)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(23, 17)
        Me.lblid.TabIndex = 1
        Me.lblid.Text = "id:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(395, 146)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(395, 191)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(45, 17)
        Me.lblRaza.TabIndex = 3
        Me.lblRaza.Text = "Raza:"
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.Location = New System.Drawing.Point(395, 233)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(64, 17)
        Me.lblTam.TabIndex = 4
        Me.lblTam.Text = "Tamaño:"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(395, 277)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(44, 17)
        Me.lblPeso.TabIndex = 5
        Me.lblPeso.Text = "Peso:"
        '
        'lblNac
        '
        Me.lblNac.AutoSize = True
        Me.lblNac.Location = New System.Drawing.Point(395, 328)
        Me.lblNac.Name = "lblNac"
        Me.lblNac.Size = New System.Drawing.Size(80, 17)
        Me.lblNac.TabIndex = 6
        Me.lblNac.Text = "Fecha Nac."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(511, 323)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(222, 22)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2024, 2, 22, 17, 30, 27, 0)
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(511, 98)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(222, 22)
        Me.txtId.TabIndex = 8
        '
        'txtTam
        '
        Me.txtTam.Location = New System.Drawing.Point(511, 230)
        Me.txtTam.Name = "txtTam"
        Me.txtTam.Size = New System.Drawing.Size(222, 22)
        Me.txtTam.TabIndex = 10
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(511, 272)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(222, 22)
        Me.txtPeso.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(511, 146)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 22)
        Me.txtNombre.TabIndex = 12
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\obeth\source\repos\negocioM" &
    "ascotas\negocioMascotas\negocioMascotasDB.mdb"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MascotasBindingSource
        '
        Me.MascotasBindingSource.DataMember = "Mascotas"
        Me.MascotasBindingSource.DataSource = Me.NegocioMascotasDBDataSet
        '
        'NegocioMascotasDBDataSet
        '
        Me.NegocioMascotasDBDataSet.DataSetName = "negocioMascotasDBDataSet"
        Me.NegocioMascotasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(36, 101)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(257, 244)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'MascotasTableAdapter
        '
        Me.MascotasTableAdapter.ClearBeforeFill = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(579, 38)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(212, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 37
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(340, 38)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregar.TabIndex = 36
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(469, 38)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 23)
        Me.btnModificar.TabIndex = 35
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(85, 38)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbRaza
        '
        Me.cmbRaza.FormattingEnabled = True
        Me.cmbRaza.Location = New System.Drawing.Point(511, 188)
        Me.cmbRaza.Name = "cmbRaza"
        Me.cmbRaza.Size = New System.Drawing.Size(222, 24)
        Me.cmbRaza.TabIndex = 39
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(104, 370)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(94, 23)
        Me.btnImagen.TabIndex = 40
        Me.btnImagen.Text = "IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.cmbRaza)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtTam)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblNac)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblTam)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.picFoto)
        Me.Name = "Form2"
        Me.Text = "Mascotas"
        CType(Me.MascotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NegocioMascotasDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lblid As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblRaza As Label
    Friend WithEvents lblTam As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblNac As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtTam As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents NegocioMascotasDBDataSet As negocioMascotasDBDataSet
    Friend WithEvents MascotasBindingSource As BindingSource
    Friend WithEvents MascotasTableAdapter As negocioMascotasDBDataSetTableAdapters.MascotasTableAdapter
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbRaza As ComboBox
    Friend WithEvents btnImagen As Button
End Class
