Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picPacientes.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub picMedicos_Click(sender As Object, e As EventArgs) Handles picMedicos.Click
        Dim form2 As New Form2()
        form2.Show
    End Sub

End Class
