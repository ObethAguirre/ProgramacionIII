Imports System.Data.OleDb

Public Class Form2
    Dim strFileName As String
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim BUSCAR = "SELECT * FROM MEDICOS WHERE cedula=@Cedula"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Cedula", txtCedula.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader

        If (Lectura.Read) Then
            txtNombre.Text = Lectura(1)
            txtApellido.Text = Lectura(2)
            cmbEspecialidad.Text = Lectura(3)
            txtConsultorio.Text = Lectura(4)
            picFoto.ImageLocation = Lectura(5)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Medicos")
            txtCedula.Clear()
            txtCedula.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCedula.Clear()
        txtNombre.Clear()
        cmbEspecialidad.Items.Clear()
        txtApellido.Clear()
        txtConsultorio.Clear()
        picFoto.Image = Nothing
        txtCedula.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim Insertar = "Insert Into MEDICOS Values (@Cedula, @Nombre, @Apellido,@Especialidad,@Consultorio, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Especialidad", cmbEspecialidad.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            Cmd.Parameters.AddWithValue("@Consultorio", txtConsultorio.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Medico Fue Registrado")
        Catch ex As Exception
            MsgBox("La Cedula a Registrar Ya Existe")
        End Try
        txtCedula.Clear()
        txtNombre.Clear()
        cmbEspecialidad.Items.Clear()
        txtApellido.Clear()
        txtConsultorio.Clear()
        picFoto.Image = Nothing
        txtCedula.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim Actualizar = "UPDATE MEDICOS SET Cedula=@Cedula, Nombre=@Nombre, Apellido=@Apellido, Especialidad=@Especialidad, Consultorio=@Consultorio,  Fotografia=@Fotografia WHERE Cedula=@Cedula"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Especialidad", cmbEspecialidad.Text)
            Cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            Cmd.Parameters.AddWithValue("@Consultorio", txtConsultorio.Text)
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Medico Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtCedula.Clear()
        txtNombre.Clear()
        cmbEspecialidad.Items.Clear()
        txtApellido.Clear()
        txtConsultorio.Clear()
        picFoto.Image = Nothing
        txtCedula.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Eliminar = "DELETE FROM MEDICOS WHERE Cedula=@Cedula"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Medico Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtCedula.Clear()
        txtNombre.Clear()
        cmbEspecialidad.Items.Clear()
        txtApellido.Clear()
        txtConsultorio.Clear()
        picFoto.Image = Nothing
        txtCedula.Focus()
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