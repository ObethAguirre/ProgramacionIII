Public Class FrmAdministrarProductos
    Public Sub limpiar()
        TxtCantidad.Text = ""
        TxtCosto.Text = ""
        TxtIdProducto.Text = ""
        TxtNombre.Text = ""
        TxtPrecio.Text = ""
        TxtIdProducto.Focus()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim Actualiza As New ClassLibraryAdminProductos.AdministrarProductos
        With Actualiza
            .ID_PRODUCTO = TxtIdProducto.Text
            .Nombre = TxtNombre.Text
            .Cantidad_Almacenada = TxtCantidad.Text
            .Precio = TxtPrecio.Text
            .Costo = TxtCosto.Text
        End With
        If Actualiza.Editar Then
        End If
        limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Actualiza As New ClassLibraryAdminProductos.AdministrarProductos
        With Actualiza
            .ID_PRODUCTO = TxtIdProducto.Text
            .Nombre = TxtNombre.Text
            .Cantidad_Almacenada = TxtCantidad.Text
            .Precio = TxtPrecio.Text
            .Costo = TxtCosto.Text
        End With
        If Actualiza.Alta Then
        End If
        limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Eliminar As New ClassLibraryAdminProductos.AdministrarProductos
        With Eliminar
            .ID_PRODUCTO = TxtIdProducto.Text
        End With
        If Eliminar.Baja Then
        End If
        limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim Busca As New ClassLibraryAdminProductos.AdministrarProductos
        With Busca
            .ID_PRODUCTO = TxtIdProducto.Text
            If .Consulta() Then

                TxtNombre.Text = .Nombre
                TxtCantidad.Text = .Cantidad_Almacenada
                TxtPrecio.Text = .Precio
                TxtCosto.Text = .Costo
            Else
                limpiar()
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With
    End Sub
End Class