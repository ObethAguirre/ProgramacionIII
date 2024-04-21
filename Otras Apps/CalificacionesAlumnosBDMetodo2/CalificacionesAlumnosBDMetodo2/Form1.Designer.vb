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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FisicaLabel As System.Windows.Forms.Label
        Dim InglesLabel As System.Windows.Forms.Label
        Dim MatematicasLabel As System.Windows.Forms.Label
        Me.DBCalificacionAlumnoDataSet = New CalificacionesAlumnosBDMetodo2.DBCalificacionAlumnoDataSet()
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabla1TableAdapter = New CalificacionesAlumnosBDMetodo2.DBCalificacionAlumnoDataSetTableAdapters.Tabla1TableAdapter()
        Me.TableAdapterManager = New CalificacionesAlumnosBDMetodo2.DBCalificacionAlumnoDataSetTableAdapters.TableAdapterManager()
        Me.Tabla1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tabla1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.FisicaTextBox = New System.Windows.Forms.TextBox()
        Me.InglesTextBox = New System.Windows.Forms.TextBox()
        Me.MatematicasTextBox = New System.Windows.Forms.TextBox()
        Me.lblFoto = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        MatriculaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        FisicaLabel = New System.Windows.Forms.Label()
        InglesLabel = New System.Windows.Forms.Label()
        MatematicasLabel = New System.Windows.Forms.Label()
        CType(Me.DBCalificacionAlumnoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabla1BindingNavigator.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBCalificacionAlumnoDataSet
        '
        Me.DBCalificacionAlumnoDataSet.DataSetName = "DBCalificacionAlumnoDataSet"
        Me.DBCalificacionAlumnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.DBCalificacionAlumnoDataSet
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabla1TableAdapter = Me.Tabla1TableAdapter
        Me.TableAdapterManager.UpdateOrder = CalificacionesAlumnosBDMetodo2.DBCalificacionAlumnoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabla1BindingNavigator
        '
        Me.Tabla1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tabla1BindingNavigator.BindingSource = Me.Tabla1BindingSource
        Me.Tabla1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tabla1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tabla1BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tabla1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tabla1BindingNavigatorSaveItem})
        Me.Tabla1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tabla1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tabla1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tabla1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tabla1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tabla1BindingNavigator.Name = "Tabla1BindingNavigator"
        Me.Tabla1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tabla1BindingNavigator.Size = New System.Drawing.Size(578, 27)
        Me.Tabla1BindingNavigator.TabIndex = 0
        Me.Tabla1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 20)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Tabla1BindingNavigatorSaveItem
        '
        Me.Tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tabla1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tabla1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tabla1BindingNavigatorSaveItem.Name = "Tabla1BindingNavigatorSaveItem"
        Me.Tabla1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tabla1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(36, 78)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(69, 17)
        MatriculaLabel.TabIndex = 1
        MatriculaLabel.Text = "Matricula:"
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Matricula", True))
        Me.MatriculaTextBox.Location = New System.Drawing.Point(111, 75)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MatriculaTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(285, 75)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(353, 75)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(163, 22)
        Me.NombreTextBox.TabIndex = 4
        '
        'FisicaLabel
        '
        FisicaLabel.AutoSize = True
        FisicaLabel.Location = New System.Drawing.Point(36, 170)
        FisicaLabel.Name = "FisicaLabel"
        FisicaLabel.Size = New System.Drawing.Size(48, 17)
        FisicaLabel.TabIndex = 5
        FisicaLabel.Text = "Fisica:"
        '
        'FisicaTextBox
        '
        Me.FisicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Fisica", True))
        Me.FisicaTextBox.Location = New System.Drawing.Point(133, 167)
        Me.FisicaTextBox.Name = "FisicaTextBox"
        Me.FisicaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FisicaTextBox.TabIndex = 6
        '
        'InglesLabel
        '
        InglesLabel.AutoSize = True
        InglesLabel.Location = New System.Drawing.Point(36, 237)
        InglesLabel.Name = "InglesLabel"
        InglesLabel.Size = New System.Drawing.Size(49, 17)
        InglesLabel.TabIndex = 7
        InglesLabel.Text = "Ingles:"
        '
        'InglesTextBox
        '
        Me.InglesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Ingles", True))
        Me.InglesTextBox.Location = New System.Drawing.Point(133, 234)
        Me.InglesTextBox.Name = "InglesTextBox"
        Me.InglesTextBox.Size = New System.Drawing.Size(100, 22)
        Me.InglesTextBox.TabIndex = 8
        '
        'MatematicasLabel
        '
        MatematicasLabel.AutoSize = True
        MatematicasLabel.Location = New System.Drawing.Point(36, 307)
        MatematicasLabel.Name = "MatematicasLabel"
        MatematicasLabel.Size = New System.Drawing.Size(91, 17)
        MatematicasLabel.TabIndex = 9
        MatematicasLabel.Text = "Matematicas:"
        '
        'MatematicasTextBox
        '
        Me.MatematicasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Matematicas", True))
        Me.MatematicasTextBox.Location = New System.Drawing.Point(133, 304)
        Me.MatematicasTextBox.Name = "MatematicasTextBox"
        Me.MatematicasTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MatematicasTextBox.TabIndex = 10
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Location = New System.Drawing.Point(375, 125)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(36, 17)
        Me.lblFoto.TabIndex = 18
        Me.lblFoto.Text = "Foto"
        '
        'picFoto
        '
        Me.picFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tabla1BindingSource, "Fotografia", True))
        Me.picFoto.Location = New System.Drawing.Point(288, 145)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(215, 204)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 17
        Me.picFoto.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(298, 417)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 39)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(96, 417)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(114, 39)
        Me.btnCargarDatos.TabIndex = 15
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 492)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(MatematicasLabel)
        Me.Controls.Add(Me.MatematicasTextBox)
        Me.Controls.Add(InglesLabel)
        Me.Controls.Add(Me.InglesTextBox)
        Me.Controls.Add(FisicaLabel)
        Me.Controls.Add(Me.FisicaTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.Tabla1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DBCalificacionAlumnoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabla1BindingNavigator.ResumeLayout(False)
        Me.Tabla1BindingNavigator.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBCalificacionAlumnoDataSet As DBCalificacionAlumnoDataSet
    Friend WithEvents Tabla1BindingSource As BindingSource
    Friend WithEvents Tabla1TableAdapter As DBCalificacionAlumnoDataSetTableAdapters.Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As DBCalificacionAlumnoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabla1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tabla1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MatriculaTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents FisicaTextBox As TextBox
    Friend WithEvents InglesTextBox As TextBox
    Friend WithEvents MatematicasTextBox As TextBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCargarDatos As Button
End Class
