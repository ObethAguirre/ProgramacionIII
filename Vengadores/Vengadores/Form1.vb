Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Public Sub limpiar()
        txtId.Text = ""
        txtNombre.Text = ""
        txtActor.Text = ""
        txtEdad.Text = ""
        txtAparicion.Text = ""
        txtPais.Text = ""
        PictureBox1.Image = Nothing
        txtId.Focus()
    End Sub


    Private Sub ConsultarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarStripMenuItem.Click
        Dim Consultar As New ClassLibraryVengadores.Vengadores
        With Consultar
            .Id = txtId.Text
            If Consultar.VengadorConsulta Then
                txtNombre.Text = .Nombre
                txtActor.Text = .Actor
                txtEdad.Text = .Edad
                txtAparicion.Text = .Aparicion
                txtPais.Text = .Pais
                If Not IsNothing(.FotoVengador) Then
                    Dim ms As New System.IO.MemoryStream(.FotoVengador)
                    PictureBox1.Image = Image.FromStream(ms)
                Else
                    PictureBox1.Image = Nothing ' Limpiar el PictureBox si no hay foto
                End If
            End If
        End With
    End Sub

    Private Sub AgregarStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarStripMenuItem.Click
        Dim Agregar As New ClassLibraryVengadores.Vengadores
        With Agregar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Actor = txtActor.Text
            .Edad = txtEdad.Text
            .Aparicion = txtAparicion.Text
            .Pais = txtPais.Text
            If Not String.IsNullOrEmpty(PictureBox1.ImageLocation) Then
                .SetFotoFromPath(PictureBox1.ImageLocation)
            End If
        End With
        If Agregar.VengadorAlta Then
        End If
        limpiar()
    End Sub

    Private Sub ModificarStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarStripMenuItem.Click
        Dim Modificar As New ClassLibraryVengadores.Vengadores
        With Modificar
            .Id = txtId.Text
            .Nombre = txtNombre.Text
            .Actor = txtActor.Text
            .Edad = txtEdad.Text
            .Aparicion = txtAparicion.Text
            .Pais = txtPais.Text
            If Not String.IsNullOrEmpty(PictureBox1.ImageLocation) Then
                Dim img As Image = Image.FromFile(PictureBox1.ImageLocation)
                Dim ms As New MemoryStream()
                img.Save(ms, Imaging.ImageFormat.Jpeg)
                Dim foto As Byte() = ms.ToArray()
                If .VengadorActualiza(foto) Then
                    ' El registro se actualizó correctamente
                Else
                    ' Hubo un error al actualizar el registro
                End If
            End If
        End With
        limpiar()
    End Sub

    Private Sub EliminarStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarStripMenuItem.Click
        Dim Eliminar As New ClassLibraryVengadores.Vengadores
        With Eliminar
            .Id = txtId.Text
        End With
        If Eliminar.VengadorBaja Then
        End If
        limpiar()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VENGADORES; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.VenConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Nombrel, Actorl, Edadl, Aparicionl, Paisl As String
        cmd.Parameters.Add(New SqlParameter("@Id", txtId.Text))
        cnx.Open()
        Dim leer As SqlDataReader
        leer = cmd.ExecuteReader
        If leer.Read() Then
            Nombrel = leer(1).ToString
            Actorl = leer(2).ToString
            Edadl = leer(3).ToString
            Aparicionl = leer(4).ToString()
            Paisl = leer(5).ToString()
            txtNombre.Text = Nombrel
            txtActor.Text = Actorl
            txtEdad.Text = Edadl
            txtAparicion.Text = Aparicionl
            txtPais.Text = Paisl
            cnx.Close()
        End If
    End Sub

    Private Sub LimpiarStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub SalirStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirStripMenuItem.Click
        End
    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
