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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtActor = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtAparicion = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnCargarFoto = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(15, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "País de origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(15, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Aparición:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(15, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(15, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Actor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(15, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vengador:"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(20, 63)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(169, 24)
        Me.txtId.TabIndex = 6
        '
        'txtActor
        '
        Me.txtActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActor.ForeColor = System.Drawing.Color.Black
        Me.txtActor.Location = New System.Drawing.Point(20, 176)
        Me.txtActor.Name = "txtActor"
        Me.txtActor.Size = New System.Drawing.Size(169, 24)
        Me.txtActor.TabIndex = 7
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.ForeColor = System.Drawing.Color.Black
        Me.txtEdad.Location = New System.Drawing.Point(20, 240)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(169, 24)
        Me.txtEdad.TabIndex = 8
        '
        'txtAparicion
        '
        Me.txtAparicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAparicion.ForeColor = System.Drawing.Color.Black
        Me.txtAparicion.Location = New System.Drawing.Point(20, 302)
        Me.txtAparicion.Name = "txtAparicion"
        Me.txtAparicion.Size = New System.Drawing.Size(169, 24)
        Me.txtAparicion.TabIndex = 9
        '
        'txtPais
        '
        Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.ForeColor = System.Drawing.Color.Black
        Me.txtPais.Location = New System.Drawing.Point(20, 371)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(169, 24)
        Me.txtPais.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(20, 118)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(169, 24)
        Me.txtNombre.TabIndex = 11
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Azure
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarStripMenuItem, Me.ConsultarStripMenuItem, Me.AgregarStripMenuItem, Me.ModificarStripMenuItem, Me.EliminarStripMenuItem, Me.SalirStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(527, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarStripMenuItem
        '
        Me.LimpiarStripMenuItem.Name = "LimpiarStripMenuItem"
        Me.LimpiarStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.LimpiarStripMenuItem.Text = "Limpiar"
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(307, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnCargarFoto
        '
        Me.btnCargarFoto.Location = New System.Drawing.Point(337, 344)
        Me.btnCargarFoto.Name = "btnCargarFoto"
        Me.btnCargarFoto.Size = New System.Drawing.Size(131, 23)
        Me.btnCargarFoto.TabIndex = 14
        Me.btnCargarFoto.Text = "Cargar Foto"
        Me.btnCargarFoto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vengadores.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(527, 401)
        Me.Controls.Add(Me.btnCargarFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtAparicion)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtActor)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtActor As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtAparicion As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnCargarFoto As Button
End Class
