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
        Me.picMascotas = New System.Windows.Forms.PictureBox()
        Me.picRazas = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRazas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMascotas
        '
        Me.picMascotas.Image = Global.negocioMascotas.My.Resources.Resources.Mascotas
        Me.picMascotas.Location = New System.Drawing.Point(32, 96)
        Me.picMascotas.Name = "picMascotas"
        Me.picMascotas.Size = New System.Drawing.Size(287, 239)
        Me.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMascotas.TabIndex = 0
        Me.picMascotas.TabStop = False
        '
        'picRazas
        '
        Me.picRazas.Image = Global.negocioMascotas.My.Resources.Resources.raza
        Me.picRazas.Location = New System.Drawing.Point(475, 96)
        Me.picRazas.Name = "picRazas"
        Me.picRazas.Size = New System.Drawing.Size(281, 239)
        Me.picRazas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRazas.TabIndex = 1
        Me.picRazas.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(328, 375)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 51)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.picRazas)
        Me.Controls.Add(Me.picMascotas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRazas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMascotas As PictureBox
    Friend WithEvents picRazas As PictureBox
    Friend WithEvents btnSalir As Button
End Class
