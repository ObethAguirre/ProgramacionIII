Imports System.Data.SqlClient
Public Class Series

    Public Property MstrId As Integer
    Public Property MstrNombre As String
    Public Property MstrDirector As String
    Public Property MstrActores As String
    Public Property MstrTemporadas As Integer
    Public Property MstrGenero As String


#Region "Definicion de Metodos"
    Public Function SerieAlta() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=Series; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.SerAlta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("(Oirector", MstrDirector))
        cmd.Parameters.Add(New SqlParameter("@Actores", MstrActores))
        cmd.Parameters.Add(New SqlParameter("(Temporadas", MstrTemporadas))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function
    Public Function SerBaja() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=Series; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.SerBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
    End Function

    Public Function SerActualiza() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=Series; Integrated Security=True")
        Dim cmd As New SqlCommand("dbo.SerActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Director", MstrDirector))
        cmd.Parameters.Add(New SqlParameter("@Actores", MstrActores))
        cmd.Parameters.Add(New SqlParameter("@Temporadas", MstrTemporadas))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function SerConsulta() As DataTable
        Dim dt As New DataTable()
        Using cnx As New SqlConnection("Server=matecat\sqlexpress; database=Series; Integrated Security=True")
            Using cmd As New SqlCommand("dbo.SerConsulta", cnx) ' Reemplaza "dbo.SerConsultaPorId" con el nombre real de tu procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
                cnx.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function
#End Region
End Class

