Public Class FrmEmpleado

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Dim Login As New ClassLibraryVikingosApp.Login
        With Login
            .Id = TxtIdEmpleado.Text
            .Contraseña = TxtContraseña.Text
        End With
        If Login.loginEmpleado Then
            frmMenu.Show()
        End If
    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class