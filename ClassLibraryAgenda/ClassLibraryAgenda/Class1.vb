Imports System.Data.SqlClient
Imports System.Windows

Public Class Agenda

    Private mstrID_Corte As Integer
    Private mstrNombreCliente As String
    Private mstrHoraInicio As String
    Private mstrHoraFin As String
    Private mstrFecha As String

    Public Property ID_Corte() As Integer
        Get
            Return mstrID_Corte
        End Get
        Set(ByVal value As Integer)
            mstrID_Corte = value
        End Set
    End Property

    Public Property NombreCliente() As String
        Get
            Return mstrNombreCliente
        End Get
        Set(ByVal value As String)
            mstrNombreCliente = value
        End Set
    End Property

    Public Property HoraInicio() As String
        Get
            Return mstrHoraInicio
        End Get
        Set(ByVal value As String)
            mstrHoraInicio = value
        End Set
    End Property

    Public Property HoraFin() As String
        Get
            Return mstrHoraFin
        End Get
        Set(ByVal value As String)
            mstrHoraFin = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return mstrFecha
        End Get
        Set(ByVal value As String)
            mstrFecha = value
        End Set
    End Property

    Public Function NuevaCita() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"
        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("dbo.AgendarCita", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@ID_Corte", mstrID_Corte))
                    cmd.Parameters.Add(New SqlParameter("@NombreCliente", mstrNombreCliente))
                    cmd.Parameters.Add(New SqlParameter("@HoraInicio", mstrHoraInicio))
                    cmd.Parameters.Add(New SqlParameter("@HoraFin", mstrHoraFin))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", mstrFecha))
                    cnx.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al registrar la cita: " & ex.Message)
            Return False
        End Try
    End Function

End Class
