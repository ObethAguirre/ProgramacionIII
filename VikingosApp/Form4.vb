Public Class frmCrearCuenta
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim Agregar As New ClassLibraryVikingosApp.Login
        With Agregar
            .Id_Cliente = txtId.Text
            .NOMBRE_CLIENTE = txtNombre.Text
            .CORREO = txtCorreo.Text
            .Contraseña_Cliente = txtContraseña.Text
        End With
        If Agregar.nuevaCuenta Then
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub
End Class