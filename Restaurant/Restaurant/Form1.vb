Public Class Form1
    Private Sub lnkEntrar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEntrar.LinkClicked
        Dim form2 As New Form2()
        form2.ShowDialog()
    End Sub

    Private Sub lnkSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSalir.LinkClicked
        Application.Exit()
    End Sub
End Class
