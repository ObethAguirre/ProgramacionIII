Public Class Form1
    Private Sub Tabla1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tabla1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBCalificacionAlumnoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        'TODO: esta línea de código carga datos en la tabla 'DBCalificacionAlumnoDataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.DBCalificacionAlumnoDataSet.Tabla1)

    End Sub
End Class
