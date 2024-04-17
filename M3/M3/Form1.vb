Imports System.Data.OleDb

Public Class Form1
    Dim strFileName As String

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TxtId.Clear()
        TxtNombre.Clear()
        TxtTelefono.Clear()
        picFoto.Image = Nothing
        TxtId.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim BUSCAR = "SELECT * FROM persona WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", TxtId.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader

        If (Lectura.Read) Then
            TxtNombre.Text = Lectura(1)
            TxtTelefono.Text = Lectura(2)
            picFoto.ImageLocation = Lectura(3)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Agenda")
            TxtId.Clear()
            TxtId.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim Insertar = "Insert Into persona Values (@Id, @Nombre, @Telefono, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtid.Text)
            Cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            Cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Registrado")
        Catch ex As Exception
            MsgBox("La Clave a Registrar Ya Existe")
        End Try
        txtid.Clear()
        TxtNombre.Clear()
        TxtTelefono.Clear()
        picFoto.Image = Nothing
        txtid.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim Actualizar = "UPDATE persona SET Id=@Id, Nombre=@Nombre, Telefono=@Telefono, Foto=@Foto WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtid.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
            Cmd.Parameters.AddWithValue("@Foto", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Contacto Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtid.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        picFoto.Image = Nothing
        txtid.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Eliminar = "DELETE FROM persona WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txtid.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtid.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        picFoto.Image = Nothing
        txtid.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCargarFoto_Click(sender As Object, e As EventArgs) Handles btnCargarFoto.Click
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
