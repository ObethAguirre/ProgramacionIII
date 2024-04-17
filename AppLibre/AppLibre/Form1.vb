Public Class Form1
    Public SiCompra, SiRegalo As Boolean
    Public Cantidad As Integer
    Public Precio As Double = 1879.99
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el estado inicial del botón
        btnPago.Enabled = SiCompra
    End Sub

    Public Function CalcularSubtotal(Precio As Double, Cantidad As Integer) As String
        Dim Subtotal As Double = Precio * Cantidad

        Return Subtotal.ToString()
    End Function
    Private Sub pnlCarrito_Paint(sender As Object, e As PaintEventArgs) Handles pnlCarrito.Paint
        SiCompra = chkMouse.Checked
        Cantidad = cmbCantidad.SelectedItem

        If cmbCantidad.SelectedItem IsNot Nothing Then

            Dim valorSeleccionado As String = cmbCantidad.SelectedItem.ToString()

            lblCantidad.Text = valorSeleccionado
        End If

        Dim resultado As String = CalcularSubtotal(Precio, Cantidad)
        lblSubtotal.Text = resultado

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        SiRegalo = chkRegalo.Checked

        Dim resultado As String = CalcularSubtotal(Precio, Cantidad)
        lblSubtotal2.Text = resultado
    End Sub

    Private Sub chkMouse_CheckedChanged(sender As Object, e As EventArgs) Handles chkMouse.CheckedChanged
        btnPago.Enabled = chkMouse.Checked
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim resultado As String = CalcularSubtotal(Precio, Cantidad)
        Dim form2 As New Form2(Cantidad, resultado)
        form2.ShowDialog()
    End Sub

    Private Sub lnkMasInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkMasInfo.LinkClicked
        ' URL que deseas abrir
        Dim url As String = "https://www.amazon.com.mx/gp/help/customer/display.html?pop-up=1&nodeId=201910710"

        ' Abrir la URL en el navegador web predeterminado
        Process.Start(url)
    End Sub

End Class
