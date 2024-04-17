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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.picPacientes = New System.Windows.Forms.PictureBox()
        Me.picMedicos = New System.Windows.Forms.PictureBox()
        Me.picHospital = New System.Windows.Forms.PictureBox()
        CType(Me.picPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHospital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(578, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\obeth\source\repos\AppHospi" &
    "tal\AppHospital\DBHospital.mdb"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picPacientes
        '
        Me.picPacientes.Image = Global.AppHospital.My.Resources.Resources.pacientes
        Me.picPacientes.Location = New System.Drawing.Point(649, 103)
        Me.picPacientes.Name = "picPacientes"
        Me.picPacientes.Size = New System.Drawing.Size(212, 238)
        Me.picPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacientes.TabIndex = 2
        Me.picPacientes.TabStop = False
        '
        'picMedicos
        '
        Me.picMedicos.Image = Global.AppHospital.My.Resources.Resources.medicos
        Me.picMedicos.Location = New System.Drawing.Point(414, 103)
        Me.picMedicos.Name = "picMedicos"
        Me.picMedicos.Size = New System.Drawing.Size(212, 238)
        Me.picMedicos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMedicos.TabIndex = 1
        Me.picMedicos.TabStop = False
        '
        'picHospital
        '
        Me.picHospital.Image = Global.AppHospital.My.Resources.Resources.hospital
        Me.picHospital.Location = New System.Drawing.Point(-3, 0)
        Me.picHospital.Name = "picHospital"
        Me.picHospital.Size = New System.Drawing.Size(391, 452)
        Me.picHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHospital.TabIndex = 0
        Me.picHospital.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(885, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picPacientes)
        Me.Controls.Add(Me.picMedicos)
        Me.Controls.Add(Me.picHospital)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHospital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picHospital As PictureBox
    Friend WithEvents picMedicos As PictureBox
    Friend WithEvents picPacientes As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
