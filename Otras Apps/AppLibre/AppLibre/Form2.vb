Public Class Form2
    Public Calle, Colonia, CP, Estado, Ciudad, Contacto, NumTarjeta, NomTarjeta, Mes, Año, Codigo As String
    Public R As String
    Public Sub New(cantidad As String, resultado As String)
        InitializeComponent()
        lblCantidad.Text = cantidad
        R = resultado
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Verificar si todos los campos de texto están llenos
        Dim camposLlenos As Boolean = Not String.IsNullOrEmpty(txbNumeroTarjeta.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbNombreTarjeta.Text) AndAlso
                                       Not String.IsNullOrEmpty(cmbMes.SelectedItem?.ToString()) AndAlso
                                       Not String.IsNullOrEmpty(cmbAño.SelectedItem?.ToString()) AndAlso
                                       Not String.IsNullOrEmpty(txbCVS.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbCalle.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbColonia.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbCP.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbEstado.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbCiudad.Text) AndAlso
                                       Not String.IsNullOrEmpty(txbContacto.Text)

        ' Habilitar o deshabilitar el botón de continuar basado en si todos los campos están llenos
        btnContinuar.Enabled = camposLlenos
        Return camposLlenos
    End Function

    Private Sub grpMedotoPago_Enter(sender As Object, e As EventArgs) Handles grpMedotoPago.Enter
        NumTarjeta = txbNumeroTarjeta.Text
        NomTarjeta = txbNombreTarjeta.Text
        Mes = cmbMes.SelectedItem
        Año = cmbAño.SelectedItem
        Codigo = txbCVS.Text
        ValidarCampos()
    End Sub

    Private Sub grpDireccion_Enter(sender As Object, e As EventArgs) Handles grpDireccion.Enter
        Calle = txbCalle.Text
        Colonia = txbColonia.Text
        CP = txbCP.Text
        Estado = txbEstado.Text
        Ciudad = txbCiudad.Text
        Contacto = txbContacto.Text
        ValidarCampos()
    End Sub
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Verificar si todos los campos están llenos
        If ValidarCampos() Then
            ' Si todos los campos están llenos, continuar con la lógica de tu aplicación
            Dim form3 As New Form3(Calle, Colonia, CP, Estado, Ciudad, Contacto, NumTarjeta, R)
            form3.ShowDialog()
        Else
            ' Mostrar un mensaje de advertencia al usuario indicando que debe completar todos los campos
            MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class