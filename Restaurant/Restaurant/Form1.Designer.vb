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
        Me.pícBanner = New System.Windows.Forms.PictureBox()
        Me.lnkEntrar = New System.Windows.Forms.LinkLabel()
        Me.lnkSalir = New System.Windows.Forms.LinkLabel()
        CType(Me.pícBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pícBanner
        '
        Me.pícBanner.Image = Global.Restaurant.My.Resources.Resources.Captura_de_pantalla_2024_02_12_164535
        Me.pícBanner.Location = New System.Drawing.Point(-1, -3)
        Me.pícBanner.Name = "pícBanner"
        Me.pícBanner.Size = New System.Drawing.Size(626, 430)
        Me.pícBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pícBanner.TabIndex = 0
        Me.pícBanner.TabStop = False
        '
        'lnkEntrar
        '
        Me.lnkEntrar.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkEntrar.AutoSize = True
        Me.lnkEntrar.BackColor = System.Drawing.Color.Transparent
        Me.lnkEntrar.Location = New System.Drawing.Point(33, 387)
        Me.lnkEntrar.Name = "lnkEntrar"
        Me.lnkEntrar.Size = New System.Drawing.Size(93, 17)
        Me.lnkEntrar.TabIndex = 1
        Me.lnkEntrar.TabStop = True
        Me.lnkEntrar.Text = "Ordenar Aquí"
        '
        'lnkSalir
        '
        Me.lnkSalir.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.lnkSalir.AutoSize = True
        Me.lnkSalir.BackColor = System.Drawing.Color.Transparent
        Me.lnkSalir.Location = New System.Drawing.Point(496, 387)
        Me.lnkSalir.Name = "lnkSalir"
        Me.lnkSalir.Size = New System.Drawing.Size(36, 17)
        Me.lnkSalir.TabIndex = 2
        Me.lnkSalir.TabStop = True
        Me.lnkSalir.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 422)
        Me.Controls.Add(Me.lnkSalir)
        Me.Controls.Add(Me.lnkEntrar)
        Me.Controls.Add(Me.pícBanner)
        Me.Name = "Form1"
        Me.Text = "INICIO"
        CType(Me.pícBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pícBanner As PictureBox
    Friend WithEvents lnkEntrar As LinkLabel
    Friend WithEvents lnkSalir As LinkLabel
End Class
