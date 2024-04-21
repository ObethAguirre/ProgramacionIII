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
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtTam = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblNac = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblTam = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(120, 380)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(94, 23)
        Me.btnImagen.TabIndex = 59
        Me.btnImagen.Text = "IMAGEN"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(595, 48)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 23)
        Me.btnEliminar.TabIndex = 57
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(228, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 56
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(356, 48)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 23)
        Me.btnAgregar.TabIndex = 55
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(485, 48)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(93, 23)
        Me.btnModificar.TabIndex = 54
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(101, 48)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 23)
        Me.btnLimpiar.TabIndex = 53
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(527, 156)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 22)
        Me.txtNombre.TabIndex = 52
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(527, 251)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(222, 22)
        Me.txtPeso.TabIndex = 51
        '
        'txtTam
        '
        Me.txtTam.Location = New System.Drawing.Point(527, 209)
        Me.txtTam.Name = "txtTam"
        Me.txtTam.Size = New System.Drawing.Size(222, 22)
        Me.txtTam.TabIndex = 50
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(527, 108)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(222, 22)
        Me.txtId.TabIndex = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(527, 333)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(222, 22)
        Me.DateTimePicker1.TabIndex = 48
        Me.DateTimePicker1.Value = New Date(2024, 2, 22, 17, 55, 23, 0)
        '
        'lblNac
        '
        Me.lblNac.AutoSize = True
        Me.lblNac.Location = New System.Drawing.Point(411, 338)
        Me.lblNac.Name = "lblNac"
        Me.lblNac.Size = New System.Drawing.Size(80, 17)
        Me.lblNac.TabIndex = 47
        Me.lblNac.Text = "Fecha Nac."
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(411, 256)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(44, 17)
        Me.lblPeso.TabIndex = 46
        Me.lblPeso.Text = "Peso:"
        '
        'lblTam
        '
        Me.lblTam.AutoSize = True
        Me.lblTam.Location = New System.Drawing.Point(411, 209)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(64, 17)
        Me.lblTam.TabIndex = 45
        Me.lblTam.Text = "Tamaño:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(411, 156)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 43
        Me.lblNombre.Text = "Nombre:"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(411, 111)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(23, 17)
        Me.lblid.TabIndex = 42
        Me.lblid.Text = "id:"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(52, 111)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(257, 244)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 41
        Me.picFoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Origen:"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(527, 294)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(222, 22)
        Me.txtOrigen.TabIndex = 61
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImagen)
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
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.picFoto)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImagen As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtTam As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblNac As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblTam As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblid As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
