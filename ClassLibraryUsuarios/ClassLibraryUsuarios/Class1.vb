Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows

Public Class AccesoUsuario

    Private MstrId_Corte As Integer
    Private MstrHoraInicio As String
    Private MstrNombreCliente As String
    Private MstrHoraFin As String
    Private MstrFecha As String
    Private MstrPrecio As Decimal
    Private MstrImgCorte As String

    Public Property Id_Corte() As Integer
        Get
            Return MstrId_Corte
        End Get
        Set(ByVal value As Integer)
            MstrId_Corte = value
        End Set
    End Property

    Public Property HoraInicio() As String
        Get
            Return MstrHoraInicio
        End Get
        Set(ByVal value As String)
            MstrHoraInicio = value
        End Set
    End Property

    Public Property NombreCliente() As String
        Get
            Return MstrNombreCliente
        End Get
        Set(ByVal value As String)
            MstrNombreCliente = value
        End Set
    End Property

    Public Property HoraFin() As String
        Get
            Return MstrHoraFin
        End Get
        Set(ByVal value As String)
            MstrHoraFin = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return MstrFecha
        End Get
        Set(ByVal value As String)
            MstrFecha = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return MstrPrecio
        End Get
        Set(ByVal value As Decimal)
            MstrPrecio = value
        End Set
    End Property

    Public Property ImgCorte() As String
        Get
            Return MstrImgCorte
        End Get
        Set(ByVal value As String)
            MstrImgCorte = value
        End Set
    End Property



    'FUNCION PARA CREAR UN NUEVA CITA
    Public Function Agendar() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"
        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("dbo.AgendarCita", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID_CORTE", MstrId_Corte)
                    cmd.Parameters.AddWithValue("@NombreCliente", MstrNombreCliente)
                    cmd.Parameters.AddWithValue("@HoraInicio", MstrHoraInicio)
                    cmd.Parameters.AddWithValue("@HoraFin", MstrHoraFin)
                    cmd.Parameters.AddWithValue("@Fecha", MstrFecha)
                    cmd.Parameters.AddWithValue("@Precio", MstrPrecio)
                    cmd.Parameters.AddWithValue("@ImgCorte", MstrImgCorte)
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
