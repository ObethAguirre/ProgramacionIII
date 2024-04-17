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
        Me.SalirStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EliminarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.grpLibros = New System.Windows.Forms.GroupBox()
        Me.txtDisponibilidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpLibros.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalirStripMenuItem
        '
        Me.SalirStripMenuItem.Name = "SalirStripMenuItem"
        Me.SalirStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirStripMenuItem.Text = "Salir"
        '
        'ModificarStripMenuItem
        '
        Me.ModificarStripMenuItem.Name = "ModificarStripMenuItem"
        Me.ModificarStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarStripMenuItem.Text = "Modificar"
        '
        'AgregarStripMenuItem
        '
        Me.AgregarStripMenuItem.Name = "AgregarStripMenuItem"
        Me.AgregarStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarStripMenuItem.Text = "Agregar"
        '
        'ConsultarStripMenuItem
        '
        Me.ConsultarStripMenuItem.Name = "ConsultarStripMenuItem"
        Me.ConsultarStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarStripMenuItem.Text = "Consultar"
        '
        'NuevoStripMenuItem
        '
        Me.NuevoStripMenuItem.Name = "NuevoStripMenuItem"
        Me.NuevoStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.NuevoStripMenuItem.Text = "Limpiar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoStripMenuItem, Me.ConsultarStripMenuItem, Me.AgregarStripMenuItem, Me.ModificarStripMenuItem, Me.EliminarStripMenuItem, Me.SalirStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(389, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EliminarStripMenuItem
        '
        Me.EliminarStripMenuItem.Name = "EliminarStripMenuItem"
        Me.EliminarStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarStripMenuItem.Text = "Eliminar"
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(122, 167)
        Me.txtEditorial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(154, 20)
        Me.txtEditorial.TabIndex = 9
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(122, 129)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(154, 20)
        Me.txtGenero.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(122, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(154, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(122, 98)
        Me.txtAutor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(154, 20)
        Me.txtAutor.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(122, 41)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(154, 20)
        Me.txtId.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(32, 171)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(44, 13)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Editorial"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(32, 134)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(42, 13)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Genero"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(32, 102)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(32, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Autor"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(32, 72)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(32, 41)
        Me.lblid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(16, 13)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Id"
        '
        'grpLibros
        '
        Me.grpLibros.Controls.Add(Me.txtDisponibilidad)
        Me.grpLibros.Controls.Add(Me.Label1)
        Me.grpLibros.Controls.Add(Me.txtEditorial)
        Me.grpLibros.Controls.Add(Me.txtGenero)
        Me.grpLibros.Controls.Add(Me.txtNombre)
        Me.grpLibros.Controls.Add(Me.txtAutor)
        Me.grpLibros.Controls.Add(Me.txtId)
        Me.grpLibros.Controls.Add(Me.lblTelefono)
        Me.grpLibros.Controls.Add(Me.lblDireccion)
        Me.grpLibros.Controls.Add(Me.lblApellido)
        Me.grpLibros.Controls.Add(Me.lblNombre)
        Me.grpLibros.Controls.Add(Me.lblid)
        Me.grpLibros.Location = New System.Drawing.Point(40, 57)
        Me.grpLibros.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLibros.Name = "grpLibros"
        Me.grpLibros.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLibros.Size = New System.Drawing.Size(298, 245)
        Me.grpLibros.TabIndex = 3
        Me.grpLibros.TabStop = False
        Me.grpLibros.Text = "Gestión de Libros"
        '
        'txtDisponibilidad
        '
        Me.txtDisponibilidad.Location = New System.Drawing.Point(122, 208)
        Me.txtDisponibilidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisponibilidad.Name = "txtDisponibilidad"
        Me.txtDisponibilidad.Size = New System.Drawing.Size(154, 20)
        Me.txtDisponibilidad.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 212)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Disponibilidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 313)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpLibros)
        Me.Name = "Form1"
        Me.Text = "Libros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpLibros.ResumeLayout(False)
        Me.grpLibros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalirStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EliminarStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtEditorial As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblid As Label
    Friend WithEvents grpLibros As GroupBox
    Friend WithEvents txtDisponibilidad As TextBox
    Friend WithEvents Label1 As Label
End Class
