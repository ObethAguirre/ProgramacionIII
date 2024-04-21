Imports System.Data.SqlClient

Public Class frmAgenda
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtHora.Text = ""
        txtHoraFin.Text = ""
        cmbCorte.SelectedIndex = -1
    End Sub

    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIDsCorte()
    End Sub

    Private Sub CargarIDsCorte()
        cmbCorte.Items.Clear()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT ID_CORTE FROM Inventario_Cortes"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cmbCorte.Items.Add(reader("ID_CORTE").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los IDs de corte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        Try
            If cmbCorte.SelectedIndex <> -1 Then
                Dim idCorte As Integer = Integer.Parse(cmbCorte.SelectedItem.ToString())

                Dim ALTA As New ClassLibraryAgenda.Agenda
                With ALTA
                    .ID_Corte = idCorte
                    .NombreCliente = txtNombre.Text
                    .HoraInicio = txtHora.Text
                    .HoraFin = txtHoraFin.Text
                    .Fecha = dateFech.Value.ToString("yyyy-MM-dd")
                End With

                If ALTA.NuevaCita Then
                    limpiar()
                End If
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"

    Private Sub cmbCorte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCorte.SelectedIndexChanged
        Dim ID_C As String = cmbCorte.Text
        Dim idCorte As Integer
        If Integer.TryParse(ID_C, idCorte) Then
            Dim infoCorte As CorteInfo = ObtenerInformacionCorte(idCorte)
            If infoCorte IsNot Nothing Then
                PicCorte.Image = ByteArrayToImage(infoCorte.Imagen)
                PicCorte.SizeMode = PictureBoxSizeMode.StretchImage
                LabelPrecio.Text = infoCorte.Precio.ToString("C")
            Else
            End If
        Else
        End If
    End Sub

    Private Function ObtenerInformacionCorte(idCorte As Integer) As CorteInfo
        Dim corteInfo As New CorteInfo()

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT PRECIO, IMG_CORTE FROM Inventario_Cortes WHERE ID_CORTE = @ID_CORTE"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ID_CORTE", idCorte)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        corteInfo.Precio = reader.GetInt32(0)
                        corteInfo.Imagen = DirectCast(reader("IMG_CORTE"), Byte())
                    End If
                End Using
            End Using
        End Using

        Return corteInfo
    End Function

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Try
            If byteArray Is Nothing Then
                Return Nothing
            End If
            Using ms As New System.IO.MemoryStream(byteArray)
                Return Image.FromStream(ms)
            End Using
        Catch ex As ArgumentException
            MessageBox.Show("Parámetro no válido al convertir los datos de imagen: " & ex.Message, "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Catch ex As Exception
            MessageBox.Show("Error al convertir los datos de imagen: " & ex.Message, "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Class

Public Class CorteInfo
    Public Property Precio As Integer
    Public Property Imagen As Byte()
End Class
