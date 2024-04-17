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
        Me.picComidaSeleccionada = New System.Windows.Forms.PictureBox()
        Me.lblPrecioComidaSeleccionada = New System.Windows.Forms.Label()
        Me.picPostreSeleccionado = New System.Windows.Forms.PictureBox()
        Me.lblPrecioPostreSeleccionado = New System.Windows.Forms.Label()
        Me.picBebidaSeleccionada = New System.Windows.Forms.PictureBox()
        Me.lblPrecioBebidaSeleccionada = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.picMensaje = New System.Windows.Forms.PictureBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkSalir = New System.Windows.Forms.LinkLabel()
        Me.lnkMenu = New System.Windows.Forms.LinkLabel()
        CType(Me.picComidaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPostreSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBebidaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picComidaSeleccionada
        '
        Me.picComidaSeleccionada.Location = New System.Drawing.Point(26, 88)
        Me.picComidaSeleccionada.Name = "picComidaSeleccionada"
        Me.picComidaSeleccionada.Size = New System.Drawing.Size(125, 104)
        Me.picComidaSeleccionada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComidaSeleccionada.TabIndex = 0
        Me.picComidaSeleccionada.TabStop = False
        '
        'lblPrecioComidaSeleccionada
        '
        Me.lblPrecioComidaSeleccionada.AutoSize = True
        Me.lblPrecioComidaSeleccionada.Location = New System.Drawing.Point(172, 138)
        Me.lblPrecioComidaSeleccionada.Name = "lblPrecioComidaSeleccionada"
        Me.lblPrecioComidaSeleccionada.Size = New System.Drawing.Size(48, 17)
        Me.lblPrecioComidaSeleccionada.TabIndex = 1
        Me.lblPrecioComidaSeleccionada.Text = "Precio"
        '
        'picPostreSeleccionado
        '
        Me.picPostreSeleccionado.Location = New System.Drawing.Point(26, 223)
        Me.picPostreSeleccionado.Name = "picPostreSeleccionado"
        Me.picPostreSeleccionado.Size = New System.Drawing.Size(125, 103)
        Me.picPostreSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPostreSeleccionado.TabIndex = 2
        Me.picPostreSeleccionado.TabStop = False
        '
        'lblPrecioPostreSeleccionado
        '
        Me.lblPrecioPostreSeleccionado.AutoSize = True
        Me.lblPrecioPostreSeleccionado.Location = New System.Drawing.Point(172, 270)
        Me.lblPrecioPostreSeleccionado.Name = "lblPrecioPostreSeleccionado"
        Me.lblPrecioPostreSeleccionado.Size = New System.Drawing.Size(48, 17)
        Me.lblPrecioPostreSeleccionado.TabIndex = 3
        Me.lblPrecioPostreSeleccionado.Text = "Precio"
        '
        'picBebidaSeleccionada
        '
        Me.picBebidaSeleccionada.Location = New System.Drawing.Point(26, 355)
        Me.picBebidaSeleccionada.Name = "picBebidaSeleccionada"
        Me.picBebidaSeleccionada.Size = New System.Drawing.Size(125, 108)
        Me.picBebidaSeleccionada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBebidaSeleccionada.TabIndex = 4
        Me.picBebidaSeleccionada.TabStop = False
        '
        'lblPrecioBebidaSeleccionada
        '
        Me.lblPrecioBebidaSeleccionada.AutoSize = True
        Me.lblPrecioBebidaSeleccionada.Location = New System.Drawing.Point(172, 397)
        Me.lblPrecioBebidaSeleccionada.Name = "lblPrecioBebidaSeleccionada"
        Me.lblPrecioBebidaSeleccionada.Size = New System.Drawing.Size(48, 17)
        Me.lblPrecioBebidaSeleccionada.TabIndex = 5
        Me.lblPrecioBebidaSeleccionada.Text = "Precio"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Total :"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(124, 522)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 17)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'picMensaje
        '
        Me.picMensaje.Location = New System.Drawing.Point(307, 211)
        Me.picMensaje.Name = "picMensaje"
        Me.picMensaje.Size = New System.Drawing.Size(139, 130)
        Me.picMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMensaje.TabIndex = 8
        Me.picMensaje.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(304, 355)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(61, 17)
        Me.lblMensaje.TabIndex = 9
        Me.lblMensaje.Text = "Mensaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 36)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cuenta"
        '
        'lnkSalir
        '
        Me.lnkSalir.AutoSize = True
        Me.lnkSalir.Location = New System.Drawing.Point(362, 532)
        Me.lnkSalir.Name = "lnkSalir"
        Me.lnkSalir.Size = New System.Drawing.Size(36, 17)
        Me.lnkSalir.TabIndex = 11
        Me.lnkSalir.TabStop = True
        Me.lnkSalir.Text = "Salir"
        '
        'lnkMenu
        '
        Me.lnkMenu.AutoSize = True
        Me.lnkMenu.Location = New System.Drawing.Point(362, 504)
        Me.lnkMenu.Name = "lnkMenu"
        Me.lnkMenu.Size = New System.Drawing.Size(100, 17)
        Me.lnkMenu.TabIndex = 12
        Me.lnkMenu.TabStop = True
        Me.lnkMenu.Text = "Menú principal"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 551)
        Me.Controls.Add(Me.lnkMenu)
        Me.Controls.Add(Me.lnkSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.picMensaje)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPrecioBebidaSeleccionada)
        Me.Controls.Add(Me.picBebidaSeleccionada)
        Me.Controls.Add(Me.lblPrecioPostreSeleccionado)
        Me.Controls.Add(Me.picPostreSeleccionado)
        Me.Controls.Add(Me.lblPrecioComidaSeleccionada)
        Me.Controls.Add(Me.picComidaSeleccionada)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.picComidaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPostreSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBebidaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComidaSeleccionada As PictureBox
    Friend WithEvents lblPrecioComidaSeleccionada As Label
    Friend WithEvents picPostreSeleccionado As PictureBox
    Friend WithEvents lblPrecioPostreSeleccionado As Label
    Friend WithEvents picBebidaSeleccionada As PictureBox
    Friend WithEvents lblPrecioBebidaSeleccionada As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents picMensaje As PictureBox
    Friend WithEvents lblMensaje As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkSalir As LinkLabel
    Friend WithEvents lnkMenu As LinkLabel
End Class
