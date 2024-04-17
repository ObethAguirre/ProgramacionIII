Imports System.Data.SqlClient
Public Class Libro
    Private MstrId As String
    Private MstrNombre As String
    Private MstrAutor As String
    Private MstrGenero As String
    Private MstrEditorial As String
    Private MstrDisponibilidad As String

    Public Property Id() As String
        Get
            Return MstrId
        End Get
        Set(ByVal value As String)
            MstrId = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return MstrNombre
        End Get
        Set(ByVal value As String)
            MstrNombre = value
        End Set
    End Property

    Public Property Autor() As String
        Get
            Return MstrAutor
        End Get
        Set(ByVal value As String)
            MstrAutor = value
        End Set
    End Property

    Public Property Genero() As String
        Get
            Return MstrGenero
        End Get
        Set(ByVal value As String)
            MstrGenero = value
        End Set
    End Property

    Public Property Editorial() As String
        Get
            Return MstrEditorial
        End Get
        Set(ByVal value As String)
            MstrEditorial = value
        End Set
    End Property

    Public Property Disponibilidad() As String
        Get
            Return MstrDisponibilidad
        End Get
        Set(ByVal value As String)
            MstrDisponibilidad = value
        End Set
    End Property

    Public Function LibroAlta() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=Libros; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.libAgregar", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Autor", MstrAutor))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cmd.Parameters.Add(New SqlParameter("@Editorial", MstrEditorial))
        cmd.Parameters.Add(New SqlParameter("@Disponibilidad", MstrDisponibilidad))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function LibroBaja() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=Libros; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.libBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function LibroActualiza() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=Libros; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.libActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Autor", MstrAutor))
        cmd.Parameters.Add(New SqlParameter("@Genero", MstrGenero))
        cmd.Parameters.Add(New SqlParameter("@Editorial", MstrEditorial))
        cmd.Parameters.Add(New SqlParameter("@Disponibilidad", MstrDisponibilidad))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function LibroConsulta() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=Libros; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.libConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        Dim leer As SqlDataReader = cmd.ExecuteReader()
        If leer.Read() Then
            MstrNombre = leer(1).ToString()
            MstrAutor = leer(2).ToString()
            MstrGenero = leer(3).ToString()
            MstrEditorial = leer(4).ToString()
            MstrDisponibilidad = leer(5).ToString()
            cnx.Close()
            Return True
        Else
            cnx.Close()
            Return False
        End If
    End Function
End Class
