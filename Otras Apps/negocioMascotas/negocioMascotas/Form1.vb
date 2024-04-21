Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub picMascotas_Click(sender As Object, e As EventArgs) Handles picMascotas.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub picRazas_Click(sender As Object, e As EventArgs) Handles picRazas.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub
End Class
