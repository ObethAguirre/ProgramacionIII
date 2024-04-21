Public Class frmVentas
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Public Sub limpiar()
        txtPrecio.Text = ""
        txtNombre.Text = ""
        txtIdVenta.Text = ""
        txtIdProducto.Text = ""
        txtIdCliente.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim ID_V As String = txtIdVenta.Text
        Dim ID_P As String = txtIdProducto.Text
        Dim ID_C As String = txtIdCliente.Text
        Dim CAN As String = txtCantidad.Text
        Dim PRE As String = txtPrecio.Text

        Dim ALTA As New ClassLibraryRegVentas.Registro
        With ALTA
            .ID_VENTA = Integer.Parse(ID_V)
            .ID_PRODUCTO = Integer.Parse(ID_P)
            .ID_CLIENTE = Integer.Parse(ID_C)
            .NOMBRE = txtNombre.Text
            .CANTIDAD_DESEADA = Integer.Parse(CAN)
            .PRECIO = Integer.Parse(PRE)
            .FECHA = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        End With
        If ALTA.REG() Then
            limpiar()
        End If
    End Sub
End Class