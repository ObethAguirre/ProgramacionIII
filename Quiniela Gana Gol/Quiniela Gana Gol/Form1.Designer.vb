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
        Me.picLaQuiniela = New System.Windows.Forms.PictureBox()
        Me.picLogoSelección = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picLaQuiniela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogoSelección, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLaQuiniela
        '
        Me.picLaQuiniela.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picLaQuiniela.Image = Global.Quiniela_Gana_Gol.My.Resources.Resources.Captura_de_pantalla_2024_02_08_164511
        Me.picLaQuiniela.Location = New System.Drawing.Point(94, 222)
        Me.picLaQuiniela.Name = "picLaQuiniela"
        Me.picLaQuiniela.Size = New System.Drawing.Size(235, 171)
        Me.picLaQuiniela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLaQuiniela.TabIndex = 1
        Me.picLaQuiniela.TabStop = False
        '
        'picLogoSelección
        '
        Me.picLogoSelección.Image = Global.Quiniela_Gana_Gol.My.Resources.Resources.Captura_de_pantalla_2024_02_08_164059
        Me.picLogoSelección.Location = New System.Drawing.Point(0, -1)
        Me.picLogoSelección.Name = "picLogoSelección"
        Me.picLogoSelección.Size = New System.Drawing.Size(422, 200)
        Me.picLogoSelección.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoSelección.TabIndex = 0
        Me.picLogoSelección.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Green
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEntrar.Location = New System.Drawing.Point(148, 430)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(128, 50)
        Me.btnEntrar.TabIndex = 2
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(148, 500)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 50)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(421, 573)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.picLaQuiniela)
        Me.Controls.Add(Me.picLogoSelección)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picLaQuiniela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogoSelección, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogoSelección As PictureBox
    Friend WithEvents picLaQuiniela As PictureBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnSalir As Button
End Class
