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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSocio = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpSocio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoStripMenuItem, Me.ConsultarStripMenuItem, Me.AgregarStripMenuItem, Me.ModificarStripMenuItem, Me.EliminarStripMenuItem, Me.SalirStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoStripMenuItem
        '
        Me.NuevoStripMenuItem.Name = "NuevoStripMenuItem"
        Me.NuevoStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.NuevoStripMenuItem.Text = "Limpiar"
        '
        'ConsultarStripMenuItem
        '
        Me.ConsultarStripMenuItem.Name = "ConsultarStripMenuItem"
        Me.ConsultarStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ConsultarStripMenuItem.Text = "Consultar"
        '
        'AgregarStripMenuItem
        '
        Me.AgregarStripMenuItem.Name = "AgregarStripMenuItem"
        Me.AgregarStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.AgregarStripMenuItem.Text = "Agregar"
        '
        'ModificarStripMenuItem
        '
        Me.ModificarStripMenuItem.Name = "ModificarStripMenuItem"
        Me.ModificarStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.ModificarStripMenuItem.Text = "Modificar"
        '
        'EliminarStripMenuItem
        '
        Me.EliminarStripMenuItem.Name = "EliminarStripMenuItem"
        Me.EliminarStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.EliminarStripMenuItem.Text = "Eliminar"
        '
        'SalirStripMenuItem
        '
        Me.SalirStripMenuItem.Name = "SalirStripMenuItem"
        Me.SalirStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirStripMenuItem.Text = "Salir"
        '
        'grpSocio
        '
        Me.grpSocio.Controls.Add(Me.txtTelefono)
        Me.grpSocio.Controls.Add(Me.txtDireccion)
        Me.grpSocio.Controls.Add(Me.txtNombre)
        Me.grpSocio.Controls.Add(Me.txtApellido)
        Me.grpSocio.Controls.Add(Me.txtId)
        Me.grpSocio.Controls.Add(Me.lblTelefono)
        Me.grpSocio.Controls.Add(Me.lblDireccion)
        Me.grpSocio.Controls.Add(Me.lblApellido)
        Me.grpSocio.Controls.Add(Me.lblNombre)
        Me.grpSocio.Controls.Add(Me.lblid)
        Me.grpSocio.Location = New System.Drawing.Point(63, 66)
        Me.grpSocio.Name = "grpSocio"
        Me.grpSocio.Size = New System.Drawing.Size(346, 269)
        Me.grpSocio.TabIndex = 1
        Me.grpSocio.TabStop = False
        Me.grpSocio.Text = "Socio"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(162, 205)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(151, 22)
        Me.txtTelefono.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(162, 159)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(151, 22)
        Me.txtDireccion.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(162, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 22)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(162, 121)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(151, 22)
        Me.txtApellido.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(162, 50)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(151, 22)
        Me.txtId.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 210)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(43, 165)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(67, 17)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Direccion"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(43, 126)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(43, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(43, 50)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(19, 17)
        Me.lblid.TabIndex = 0
        Me.lblid.Text = "Id"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 389)
        Me.Controls.Add(Me.grpSocio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpSocio.ResumeLayout(False)
        Me.grpSocio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpSocio As GroupBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblid As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As TextBox
End Class
