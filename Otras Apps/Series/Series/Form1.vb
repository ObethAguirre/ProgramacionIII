Imports System.Data.SqlClient

Public Class Form1
    Public Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtId.Focus()
    End Sub


    Private Sub SalirStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirStripMenuItem.Click
        End
    End Sub

    Private Sub NuevoStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub ConsultarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarStripMenuItem.Click
        Dim Consultar As New ClassLibrarySocio.Socio
        With Consultar
            .Id = txtId.Text
            If Consultar.SocioConsulta Then
                txtNombre.Text = .Nombre
                txtApellido.Text = .Apellido
                txtDireccion.Text = .Direccion
                txtTelefono.Text = .Telefono
            End If
        End With
    End Sub

    Private Sub AgregarStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarStripMenuItem.Click
        Dim Agregar As New ClassLibrarySocio.Socio
        With Agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
        End With
        If Agregar.SocioAlta Then
        End If
        limpiar()
    End Sub

    Private Sub ModificarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarStripMenuItem.Click
        Dim Modificar As New ClassLibrarySocio.Socio
        With Modificar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Apellido = txtApellido.Text
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text

        End With

        If Modificar.SocioActualiza Then
        End If
        limpiar()
    End Sub

    Private Sub EliminarStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarStripMenuItem.Click
        Dim Eliminar As New ClassLibrarySocio.Socio
        With Eliminar
            .Id = txtId.Text
        End With
        If Eliminar.SocioBaja Then
        End If
        limpiar()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=socio; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.SocConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombrel, Apellidol, Direccionl, Telefonol As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Nombrel = leer(1).ToString
            Apellidol = leer(2).ToString
            Direccionl = leer(3).ToString
            Telefonol = leer(4).ToString()
            txtNombre.Text = Nombrel
            txtApellido.Text = Apellidol
            txtDireccion.Text = Direccionl
            txtTelefono.Text = Telefonol
            cnx.Close()
        End If
    End Sub
End Class


