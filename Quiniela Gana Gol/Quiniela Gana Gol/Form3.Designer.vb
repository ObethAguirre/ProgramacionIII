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
        Me.lblAciertos = New System.Windows.Forms.Label()
        Me.lblPremio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPierde = New System.Windows.Forms.PictureBox()
        Me.picResultado = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPierde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAciertos
        '
        Me.lblAciertos.AutoSize = True
        Me.lblAciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAciertos.Location = New System.Drawing.Point(83, 148)
        Me.lblAciertos.Name = "lblAciertos"
        Me.lblAciertos.Size = New System.Drawing.Size(15, 20)
        Me.lblAciertos.TabIndex = 0
        Me.lblAciertos.Text = "-"
        '
        'lblPremio
        '
        Me.lblPremio.AutoSize = True
        Me.lblPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremio.ForeColor = System.Drawing.Color.Red
        Me.lblPremio.Location = New System.Drawing.Point(83, 182)
        Me.lblPremio.Name = "lblPremio"
        Me.lblPremio.Size = New System.Drawing.Size(17, 24)
        Me.lblPremio.TabIndex = 1
        Me.lblPremio.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quiniela_Gana_Gol.My.Resources.Resources.LIGAMX
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picPierde
        '
        Me.picPierde.Image = Global.Quiniela_Gana_Gol.My.Resources.Resources.no_gane
        Me.picPierde.Location = New System.Drawing.Point(87, 232)
        Me.picPierde.Name = "picPierde"
        Me.picPierde.Size = New System.Drawing.Size(169, 167)
        Me.picPierde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPierde.TabIndex = 3
        Me.picPierde.TabStop = False
        '
        'picResultado
        '
        Me.picResultado.Image = Global.Quiniela_Gana_Gol.My.Resources.Resources.winner
        Me.picResultado.Location = New System.Drawing.Point(87, 232)
        Me.picResultado.Name = "picResultado"
        Me.picResultado.Size = New System.Drawing.Size(169, 167)
        Me.picResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picResultado.TabIndex = 2
        Me.picResultado.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 411)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPierde)
        Me.Controls.Add(Me.picResultado)
        Me.Controls.Add(Me.lblPremio)
        Me.Controls.Add(Me.lblAciertos)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPierde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAciertos As Label
    Friend WithEvents lblPremio As Label
    Friend WithEvents picResultado As PictureBox
    Friend WithEvents picPierde As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
