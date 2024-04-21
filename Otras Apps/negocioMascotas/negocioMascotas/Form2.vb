Imports System.Data.OleDb
Public Class Form2
    Dim strFileName As String
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim BUSCAR = "SELECT * FROM Mascotas WHERE id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", txtId.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader

        If (Lectura.Read) Then
            txtNombre.Text = Lectura(1)
            cmbRaza.Text = Lectura(2)
            txtTam.Text = Lectura(3)
            txtPeso.Text = Lectura(4)
            picFoto.ImageLocation = Lectura(5)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Mascotas")
            txtId.Clear()
            txtId.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtId.Clear()
        txtNombre.Clear()
        cmbRaza.Items.Clear()
        txtTam.Clear()
        txtPeso.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim Insertar = "Insert Into Mascotas Values (@Id, @Nombre, @Raza,@Tamano,@Peso, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Raza", cmbRaza.Text)
            Cmd.Parameters.AddWithValue("@Tamano", txtTam.Text)
            Cmd.Parameters.AddWithValue("@Peso", txtPeso.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Alumno Fue Registrado")
        Catch ex As Exception
            MsgBox("La Matricula a Registrar Ya Existe")
        End Try
        txtId.Clear()
        txtNombre.Clear()
        cmbRaza.Items.Clear()
        txtTam.Clear()
        txtPeso.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim Actualizar = "UPDATE Mascotas SET id=@Id, Nombre=@Nombre, Raza=@Raza, Tam=@Tamano, Peso=@Peso,  Fotografia=@Fotografia WHERE id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Raza", cmbRaza.Text)
            Cmd.Parameters.AddWithValue("@Tamano", txtTam.Text)
            Cmd.Parameters.AddWithValue("@Peso", txtPeso.Text)
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos De la Mascota Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtId.Clear()
        txtNombre.Clear()
        cmbRaza.Items.Clear()
        txtTam.Clear()
        txtPeso.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Eliminar = "DELETE FROM Mascotas WHERE id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtId.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("La Mascota Fue Eliminada....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtId.Clear()
        txtNombre.Clear()
        cmbRaza.Items.Clear()
        txtTam.Clear()
        txtPeso.Clear()
        picFoto.Image = Nothing
        txtId.Focus()
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        With OpenFileDialog1
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                picFoto.Image = Image.FromFile(strFileName)
                OpenFileDialog1.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class