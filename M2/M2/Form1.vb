Public Class Form1
    Private Sub PersonaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PersonaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Persona' Puede moverla o quitarla según sea necesario.
        Me.PersonaTableAdapter.Fill(Me.Database1DataSet.Persona)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub


End Class
