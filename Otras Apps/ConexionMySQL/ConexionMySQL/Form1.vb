
Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "server=localhost;database=bdnew;uid=root;password=12345;"
    Private connection As MySqlConnection

    Private Sub ConectarBD()
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Conexión exitosa a MySQL.")

            ' Aquí puedes realizar operaciones en la base de datos

        Catch ex As MySqlException
            MessageBox.Show("Error al conectar a MySQL: " & ex.Message)
        End Try
    End Sub

    Private Sub DesconectarBD()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
            MessageBox.Show("Desconexión exitosa de MySQL.")
        Else
            MessageBox.Show("No hay conexión abierta para desconectar.")
        End If
    End Sub

    Private Sub btnConexion_Click(sender As Object, e As EventArgs) Handles btnConexion.Click
        ConectarBD()
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        DesconectarBD()
    End Sub
End Class

