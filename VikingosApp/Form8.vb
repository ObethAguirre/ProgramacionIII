Imports System.IO

Public Class frmAdmiCortes
    Public Sub limpiar()
        txtIdCorte.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        PictureBox1.Image = Nothing
        txtIdCorte.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Consultar As New ClassLibraryAdminCortes.AdministrarCortes
        With Consultar
            .ID_CORTE = txtIdCorte.Text
            If Consultar.Consulta() Then
                txtNombre.Text = .NOMBRE
                txtPrecio.Text = .PRECIO
                If Not IsNothing(.IMG_CORTE) AndAlso .IMG_CORTE.Length > 0 Then
                    Try
                        Dim ms As New System.IO.MemoryStream(.IMG_CORTE)
                        PictureBox1.Image = Image.FromStream(ms)
                    Catch ex As Exception
                        MessageBox.Show("No se pudo cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        PictureBox1.Image = Nothing
                    End Try
                Else
                    PictureBox1.Image = Nothing
                End If
            Else
                MessageBox.Show("No se encontró el corte con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End With
    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Agregar As New ClassLibraryAdminCortes.AdministrarCortes
        With Agregar
            .ID_CORTE = txtIdCorte.Text
            .NOMBRE = txtNombre.Text
            .PRECIO = txtPrecio.Text
            If Not String.IsNullOrEmpty(PictureBox1.ImageLocation) Then
                .SetFotoFromPath(PictureBox1.ImageLocation)
            End If
        End With
        If Agregar.Alta Then
            limpiar()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Eliminar As New ClassLibraryAdminCortes.AdministrarCortes
        With Eliminar
            .ID_CORTE = txtIdCorte.Text
        End With
        If Eliminar.Baja Then
        End If
        limpiar()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        If String.IsNullOrEmpty(txtIdCorte.Text) Then
            MessageBox.Show("Por favor, ingrese un ID de corte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim Modificar As New ClassLibraryAdminCortes.AdministrarCortes
        With Modificar
            .ID_CORTE = txtIdCorte.Text
            .NOMBRE = txtNombre.Text
            .PRECIO = txtPrecio.Text


            If Not IsNothing(PictureBox1.Image) Then
                Using ms As New MemoryStream()
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    .IMG_CORTE = ms.ToArray()
                End Using
            Else
                .IMG_CORTE = Nothing
            End If


            If .Actualiza() Then
                MessageBox.Show("El corte ha sido actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo actualizar el corte. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With

        limpiar()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub frmAdmiCortes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class