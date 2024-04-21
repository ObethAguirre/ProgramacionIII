Public Class Form3
    Public Sub MostrarPedido(imagenComida As Image, precioComida As String, imagenPostre As Image, precioPostre As String, imagenBebida As Image, precioBebida As String)
        ' Mostrar la imagen y el precio de la comida
        picComidaSeleccionada.Image = imagenComida
        lblPrecioComidaSeleccionada.Text = precioComida

        ' Mostrar la imagen y el precio del postre
        picPostreSeleccionado.Image = imagenPostre
        lblPrecioPostreSeleccionado.Text = precioPostre

        ' Mostrar la imagen y el precio de la bebida
        picBebidaSeleccionada.Image = imagenBebida
        lblPrecioBebidaSeleccionada.Text = precioBebida
    End Sub

    Private Sub CalcularTotal()
        Dim total As Integer = 0

        ' Sumar los precios de comida, postre y bebida
        total += Convert.ToInt32(lblPrecioComidaSeleccionada.Text.Replace("$", ""))
        total += Convert.ToInt32(lblPrecioPostreSeleccionado.Text.Replace("$", ""))
        total += Convert.ToInt32(lblPrecioBebidaSeleccionada.Text.Replace("$", ""))

        ' Mostrar el total a pagar
        lblTotal.Text = "Total a pagar: $" & total.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalcularTotal()

        lblMensaje.Text = "¡Gracias por su visita!"
        picMensaje.Image = Image.FromFile("C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\cara.jpg")
    End Sub

    Private Sub lnkSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSalir.LinkClicked
        Application.Exit()
    End Sub

    Private Sub lnkMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkMenu.LinkClicked
        Dim form1 As New Form1()
        form1.ShowDialog()

        Me.Close()
    End Sub
End Class