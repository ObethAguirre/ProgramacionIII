Imports System.Data.OleDb

Public Class Form1
    Dim strFileName As String
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtMatricula.Clear()
        txtNombre.Clear()
        txtFisica.Clear()
        txtIngles.Clear()
        txtMatematicas.Clear()
        picFoto.Image = Nothing
        txtMatricula.Focus()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim BUSCAR = "SELECT * FROM Tabla1 WHERE Matricula=@Matricula"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Matricula", txtMatricula.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader

        If (Lectura.Read) Then
            txtNombre.Text = Lectura(1)
            txtFisica.Text = Lectura(2)
            txtIngles.Text = Lectura(3)
            txtMatematicas.Text = Lectura(4)
            picFoto.ImageLocation = Lectura(5)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Calificaciones")
            txtMatricula.Clear()
            txtMatricula.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim Insertar = "Insert Into Tabla1 Values (@Matricula, @Nombre, @Fisica,@Ingles,@Matematicas, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Fisica", txtFisica.Text)
            Cmd.Parameters.AddWithValue("@Ingles", txtIngles.Text)
            Cmd.Parameters.AddWithValue("@Matematicas", txtMatematicas.Text)
            picFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Alumno Fue Registrado")
        Catch ex As Exception
            MsgBox("La Matricula a Registrar Ya Existe")
        End Try
        txtMatricula.Clear()
        txtNombre.Clear()
        txtFisica.Clear()
        txtIngles.Clear()
        txtMatematicas.Clear()
        picFoto.Image = Nothing
        txtMatricula.Focus()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim Actualizar = "UPDATE Tabla1 SET Matricula=@Matricula, Nombre=@Nombre, Fisica=@Fisica, Ingles=@Ingles, Matematicas=@Matematicas,  Fotografia=@Fotografia WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            Cmd.Parameters.AddWithValue("@Fisica", txtFisica.Text)
            Cmd.Parameters.AddWithValue("@Ingles", txtIngles.Text)
            Cmd.Parameters.AddWithValue("@Matematicas", txtMatematicas.Text)
            Cmd.Parameters.AddWithValue("@Fotografia", picFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Alumno Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtMatricula.Clear()
        txtNombre.Clear()
        txtIngles.Clear()
        txtFisica.Clear()
        txtMatematicas.Clear()
        picFoto.Image = Nothing
        txtMatricula.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim Eliminar = "DELETE FROM Tabla1 WHERE Matricula=@Matricula"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Alumno Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtMatricula.Clear()
        txtNombre.Clear()
        txtFisica.Clear()
        txtIngles.Clear()
        txtMatematicas.Clear()
        picFoto.Image = Nothing
        txtMatricula.Focus()

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

    Private Sub picFoto_Click(sender As Object, e As EventArgs) Handles picFoto.Click

    End Sub
End Class
