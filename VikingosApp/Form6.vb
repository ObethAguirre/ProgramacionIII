Public Class frmMenu
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmAdministrarProductos.Show()
    End Sub

    Private Sub btnCortes_Click(sender As Object, e As EventArgs) Handles btnCortes.Click
        frmAdmiCortes.Show()

    End Sub

    Private Sub btnHistorialVentas_Click(sender As Object, e As EventArgs) Handles btnHistorialVentas.Click
        FrmHistProductosVentas.Show()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmVentas.Show()

    End Sub

    Private Sub btnHistorialCortes_Click(sender As Object, e As EventArgs) Handles btnHistorialCortes.Click
        frmHistCortes.Show()
    End Sub

End Class