Imports System.Data.SqlClient
Imports System.Windows

Public Class HistVentas
    Private MstrFechaInicio As Date
    Private MstrFechaFin As Date

    Public Property FechaInicio() As String
        Get
            Return MstrFechaInicio
        End Get
        Set(ByVal value As String)
            MstrFechaInicio = value
        End Set
    End Property


    Public Property FechaFin() As String
        Get
            Return MstrFechaFin
        End Get
        Set(ByVal value As String)
            MstrFechaFin = value
        End Set
    End Property

    Public Function ConsultarHistorialVentasEntreFechas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim dt As New DataTable()
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"

        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("ConsultarHistorialVentasEntreFechas", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin)
                    cnx.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al consultar el historial de ventas: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function ConsultarHistorialCitasEntreFechas(ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim dt As New DataTable()
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"

        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("ConsultarHistorialCitasEntreFechas", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.ToString("yyyy-MM-dd"))
                    cnx.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al consultar el historial de citas: " & ex.Message)
        End Try

        Return dt
    End Function

End Class
