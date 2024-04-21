Public Class Form3

    Public Sub New(Calle As String, colonia As String, cp As String, estado As String, ciudad As String, contacto As String, numTarjeta As String, Total As String)
        InitializeComponent()
        lblColonia.Text = colonia
        lblCP.Text = cp
        lblCiudad.Text = ciudad
        lblEstado.Text = estado
        lblContacto.Text = contacto
        'lblNumTrajeta
        lblTotal.Text = Total
        rbtEnvio.Checked = True
        lblCalle.Text = Calle
    End Sub

    Private Sub lkCondiciones_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkCondiciones.LinkClicked
        ' URL que deseas abrir
        Dim url As String = "https://www.amazon.com.mx/gp/help/customer/display.html?nodeId=508088"

        ' Abrir la URL en el navegador web predeterminado
        Process.Start(url)
    End Sub

    Private Sub lkprivacidad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkprivacidad.LinkClicked
        ' URL que deseas abrir
        Dim url As String = "https://www.amazon.com.mx/gp/help/customer/display.html?nodeId=468496"

        ' Abrir la URL en el navegador web predeterminado
        Process.Start(url)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub


End Class