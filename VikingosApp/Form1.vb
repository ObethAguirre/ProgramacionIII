Public Class frmInicio


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        frmLogin.Show()
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        FrmEmpleado.Show()
    End Sub
End Class
