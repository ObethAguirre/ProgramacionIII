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
        Me.btnConexion = New System.Windows.Forms.Button()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConexion
        '
        Me.btnConexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConexion.Location = New System.Drawing.Point(48, 35)
        Me.btnConexion.Name = "btnConexion"
        Me.btnConexion.Size = New System.Drawing.Size(114, 62)
        Me.btnConexion.TabIndex = 0
        Me.btnConexion.Text = "Conectar"
        Me.btnConexion.UseVisualStyleBackColor = False
        '
        'btnDesconectar
        '
        Me.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDesconectar.Location = New System.Drawing.Point(208, 35)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(112, 62)
        Me.btnDesconectar.TabIndex = 1
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(378, 139)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.btnConexion)
        Me.Name = "Form1"
        Me.Text = "Conexión"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnConexion As Button
    Friend WithEvents btnDesconectar As Button
End Class
