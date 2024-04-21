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
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpDireccion = New System.Windows.Forms.GroupBox()
        Me.grpMedotoPago = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.picAdd = New System.Windows.Forms.PictureBox()
        Me.picBaner = New System.Windows.Forms.PictureBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.txbCalle = New System.Windows.Forms.TextBox()
        Me.txbColonia = New System.Windows.Forms.TextBox()
        Me.txbCP = New System.Windows.Forms.TextBox()
        Me.txbCiudad = New System.Windows.Forms.TextBox()
        Me.txbEstado = New System.Windows.Forms.TextBox()
        Me.txbNumeroTarjeta = New System.Windows.Forms.TextBox()
        Me.txbNombreTarjeta = New System.Windows.Forms.TextBox()
        Me.txbCVS = New System.Windows.Forms.TextBox()
        Me.txbContacto = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.grpDireccion.SuspendLayout()
        Me.grpMedotoPago.SuspendLayout()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBaner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(404, 26)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(10, 13)
        Me.lblCantidad.TabIndex = 1
        Me.lblCantidad.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1     Dirección de envío" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Colonia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(261, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Contacto:"
        '
        'grpDireccion
        '
        Me.grpDireccion.Controls.Add(Me.txbContacto)
        Me.grpDireccion.Controls.Add(Me.txbEstado)
        Me.grpDireccion.Controls.Add(Me.txbCiudad)
        Me.grpDireccion.Controls.Add(Me.txbCP)
        Me.grpDireccion.Controls.Add(Me.txbColonia)
        Me.grpDireccion.Controls.Add(Me.txbCalle)
        Me.grpDireccion.Controls.Add(Me.Label1)
        Me.grpDireccion.Controls.Add(Me.Label3)
        Me.grpDireccion.Controls.Add(Me.Label2)
        Me.grpDireccion.Controls.Add(Me.Label4)
        Me.grpDireccion.Controls.Add(Me.Label5)
        Me.grpDireccion.Controls.Add(Me.Label7)
        Me.grpDireccion.Controls.Add(Me.Label6)
        Me.grpDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpDireccion.Location = New System.Drawing.Point(12, 58)
        Me.grpDireccion.Name = "grpDireccion"
        Me.grpDireccion.Size = New System.Drawing.Size(671, 230)
        Me.grpDireccion.TabIndex = 5
        Me.grpDireccion.TabStop = False
        '
        'grpMedotoPago
        '
        Me.grpMedotoPago.Controls.Add(Me.txbCVS)
        Me.grpMedotoPago.Controls.Add(Me.txbNombreTarjeta)
        Me.grpMedotoPago.Controls.Add(Me.txbNumeroTarjeta)
        Me.grpMedotoPago.Controls.Add(Me.cmbAño)
        Me.grpMedotoPago.Controls.Add(Me.cmbMes)
        Me.grpMedotoPago.Controls.Add(Me.picAdd)
        Me.grpMedotoPago.Controls.Add(Me.Label8)
        Me.grpMedotoPago.Controls.Add(Me.Label12)
        Me.grpMedotoPago.Controls.Add(Me.Label11)
        Me.grpMedotoPago.Controls.Add(Me.Label10)
        Me.grpMedotoPago.Controls.Add(Me.Label9)
        Me.grpMedotoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpMedotoPago.Location = New System.Drawing.Point(12, 309)
        Me.grpMedotoPago.Name = "grpMedotoPago"
        Me.grpMedotoPago.Size = New System.Drawing.Size(671, 230)
        Me.grpMedotoPago.TabIndex = 6
        Me.grpMedotoPago.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "2     Método de pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Número de tarjeta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(214, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 32)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nombre en la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tarjeta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(223, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 32)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vencimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(232, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 32)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Código de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seguridad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picAdd
        '
        Me.picAdd.Image = Global.AppLibre.My.Resources.Resources.Captura_de_pantalla_2024_02_05_154301
        Me.picAdd.Location = New System.Drawing.Point(417, 13)
        Me.picAdd.Name = "picAdd"
        Me.picAdd.Size = New System.Drawing.Size(248, 211)
        Me.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdd.TabIndex = 5
        Me.picAdd.TabStop = False
        '
        'picBaner
        '
        Me.picBaner.Image = Global.AppLibre.My.Resources.Resources.Captura_de_pantalla_2024_02_05_151402
        Me.picBaner.Location = New System.Drawing.Point(0, 0)
        Me.picBaner.Name = "picBaner"
        Me.picBaner.Size = New System.Drawing.Size(695, 52)
        Me.picBaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBaner.TabIndex = 0
        Me.picBaner.TabStop = False
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(309, 146)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(40, 21)
        Me.cmbMes.TabIndex = 6
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Items.AddRange(New Object() {"2024", "2025", "2026", "2027", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.cmbAño.Location = New System.Drawing.Point(355, 146)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(56, 21)
        Me.cmbAño.TabIndex = 6
        '
        'txbCalle
        '
        Me.txbCalle.Location = New System.Drawing.Point(337, 49)
        Me.txbCalle.Name = "txbCalle"
        Me.txbCalle.Size = New System.Drawing.Size(100, 20)
        Me.txbCalle.TabIndex = 5
        '
        'txbColonia
        '
        Me.txbColonia.Location = New System.Drawing.Point(337, 77)
        Me.txbColonia.Name = "txbColonia"
        Me.txbColonia.Size = New System.Drawing.Size(100, 20)
        Me.txbColonia.TabIndex = 5
        '
        'txbCP
        '
        Me.txbCP.Location = New System.Drawing.Point(337, 104)
        Me.txbCP.Name = "txbCP"
        Me.txbCP.Size = New System.Drawing.Size(100, 20)
        Me.txbCP.TabIndex = 5
        '
        'txbCiudad
        '
        Me.txbCiudad.Location = New System.Drawing.Point(337, 132)
        Me.txbCiudad.Name = "txbCiudad"
        Me.txbCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txbCiudad.TabIndex = 5
        '
        'txbEstado
        '
        Me.txbEstado.Location = New System.Drawing.Point(337, 160)
        Me.txbEstado.Name = "txbEstado"
        Me.txbEstado.Size = New System.Drawing.Size(100, 20)
        Me.txbEstado.TabIndex = 5
        '
        'txbNumeroTarjeta
        '
        Me.txbNumeroTarjeta.Location = New System.Drawing.Point(309, 63)
        Me.txbNumeroTarjeta.Name = "txbNumeroTarjeta"
        Me.txbNumeroTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txbNumeroTarjeta.TabIndex = 5
        '
        'txbNombreTarjeta
        '
        Me.txbNombreTarjeta.Location = New System.Drawing.Point(309, 101)
        Me.txbNombreTarjeta.Name = "txbNombreTarjeta"
        Me.txbNombreTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txbNombreTarjeta.TabIndex = 5
        '
        'txbCVS
        '
        Me.txbCVS.Location = New System.Drawing.Point(309, 192)
        Me.txbCVS.Name = "txbCVS"
        Me.txbCVS.Size = New System.Drawing.Size(100, 20)
        Me.txbCVS.TabIndex = 7
        '
        'txbContacto
        '
        Me.txbContacto.Location = New System.Drawing.Point(337, 187)
        Me.txbContacto.Name = "txbContacto"
        Me.txbContacto.Size = New System.Drawing.Size(100, 20)
        Me.txbContacto.TabIndex = 6
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.Gold
        Me.btnContinuar.Location = New System.Drawing.Point(248, 556)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(181, 33)
        Me.btnContinuar.TabIndex = 7
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(695, 600)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.grpMedotoPago)
        Me.Controls.Add(Me.grpDireccion)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.picBaner)
        Me.Name = "Form2"
        Me.Text = "Datos de envio"
        Me.grpDireccion.ResumeLayout(False)
        Me.grpDireccion.PerformLayout()
        Me.grpMedotoPago.ResumeLayout(False)
        Me.grpMedotoPago.PerformLayout()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBaner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBaner As PictureBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grpDireccion As GroupBox
    Friend WithEvents grpMedotoPago As GroupBox
    Friend WithEvents picAdd As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents txbContacto As TextBox
    Friend WithEvents txbEstado As TextBox
    Friend WithEvents txbCiudad As TextBox
    Friend WithEvents txbCP As TextBox
    Friend WithEvents txbColonia As TextBox
    Friend WithEvents txbCalle As TextBox
    Friend WithEvents txbCVS As TextBox
    Friend WithEvents txbNombreTarjeta As TextBox
    Friend WithEvents txbNumeroTarjeta As TextBox
    Friend WithEvents btnContinuar As Button
End Class
