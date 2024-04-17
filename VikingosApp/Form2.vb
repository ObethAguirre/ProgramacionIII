Public Class frmLogin


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        frmCrearCuenta.Show()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim Login As New ClassLibraryVikingosApp.Login
        With Login
            .Id_Cliente = txtId.Text
            .Contraseña_Cliente = txtContraseña.Text
        End With
        If Login.loginUsuario Then
            frmAgenda.Show()
        End If
    End Sub


End Class