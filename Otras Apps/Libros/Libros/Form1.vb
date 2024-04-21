Imports System.Data.SqlClient
Public Class Form1
    Public Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtAutor.Text = ""
        txtGenero.Text = ""
        txtEditorial.Text = ""
        txtDisponibilidad.Text = ""
        txtId.Focus()
    End Sub


    Private Sub SalirStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirStripMenuItem.Click
        End
    End Sub

    Private Sub NuevoStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub ConsultarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarStripMenuItem.Click
        Dim Consultar As New ClassLibraryLibro.Libro
        With Consultar
            .Id = txtId.Text
            If Consultar.LibroConsulta Then
                txtNombre.Text = .Nombre
                txtAutor.Text = .Autor
                txtGenero.Text = .Genero
                txtEditorial.Text = .Editorial
                txtDisponibilidad.Text = .Disponibilidad
            End If
        End With
    End Sub

    Private Sub AgregarStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarStripMenuItem.Click
        Dim Agregar As New ClassLibraryLibro.Libro
        With Agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Autor = txtAutor.Text
            .Genero = txtGenero.Text
            .Editorial = txtEditorial.Text
            .Disponibilidad = txtDisponibilidad.Text

        End With
        If Agregar.LibroAlta Then
        End If
        limpiar()
    End Sub

    Private Sub ModificarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarStripMenuItem.Click
        Dim Modificar As New ClassLibraryLibro.Libro
        With Modificar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Autor = txtAutor.Text
            .Genero = txtGenero.Text
            .Editorial = txtEditorial.Text
            .Disponibilidad = txtDisponibilidad.Text
        End With

        If Modificar.LibroActualiza Then
        End If
        limpiar()
    End Sub

    Private Sub EliminarStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarStripMenuItem.Click
        Dim Eliminar As New ClassLibraryLibro.Libro
        With Eliminar
            .Id = txtId.Text
        End With
        If Eliminar.LibroBaja Then
        End If
        limpiar()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=Libros; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.libConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombrel, Autorl, Generol, Editoriall, Disponibilidadl As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Nombrel = leer(1).ToString
            Autorl = leer(2).ToString
            Generol = leer(3).ToString
            Editoriall = leer(4).ToString()
            Disponibilidadl = leer(5).ToString()
            txtNombre.Text = Nombrel
            txtAutor.Text = Autorl
            txtGenero.Text = Generol
            txtEditorial.Text = Editoriall
            txtDisponibilidad.Text = Disponibilidadl
            cnx.Close()
        End If
    End Sub
End Class
