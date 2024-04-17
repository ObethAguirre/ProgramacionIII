Imports System.Data.SqlClient
Imports System.IO

Public Class Vengadores
    Private MstrId As String
    Private MstrNombre As String
    Private MstrActor As String
    Private MstrEdad As String
    Private MstrAparicion As String
    Private MstrPais As String
    Private Foto As Byte()

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

    Public Property Actor() As String
        Get
            Return MstrActor
        End Get
        Set(ByVal value As String)
            MstrActor = value
        End Set
    End Property

    Public Property Edad() As String
        Get
            Return MstrEdad
        End Get
        Set(ByVal value As String)
            MstrEdad = value
        End Set
    End Property

    Public Property Aparicion() As String
        Get
            Return MstrAparicion
        End Get
        Set(ByVal value As String)
            MstrAparicion = value
        End Set
    End Property

    Public Property Pais() As String
        Get
            Return MstrPais
        End Get
        Set(ByVal value As String)
            MstrPais = value
        End Set
    End Property

    Public Property FotoVengador() As Byte()
        Get
            Return Foto
        End Get
        Set(ByVal value As Byte())
            Foto = value
        End Set
    End Property
    Public Sub SetFotoFromPath(rutaImagen As String)
        Foto = File.ReadAllBytes(rutaImagen)
    End Sub
    Public Function VengadorAlta() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VENGADORES; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.VenAlta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Actor", MstrActor))
        cmd.Parameters.Add(New SqlParameter("@Edad", MstrEdad))
        cmd.Parameters.Add(New SqlParameter("@Aparicion", MstrAparicion))
        cmd.Parameters.Add(New SqlParameter("@Pais", MstrPais))
        cmd.Parameters.Add(New SqlParameter("@Foto", Foto))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function VengadorBaja() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VENGADORES; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.VenBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function VengadorActualiza(ByVal foto As Byte()) As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VENGADORES; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.VenActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Actor", MstrActor))
        cmd.Parameters.Add(New SqlParameter("@Edad", MstrEdad))
        cmd.Parameters.Add(New SqlParameter("@Aparicion", MstrAparicion))
        cmd.Parameters.Add(New SqlParameter("@Pais", MstrPais))
        cmd.Parameters.Add(New SqlParameter("@Foto", foto))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function VengadorConsulta() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VENGADORES; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.VenConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        Dim leer As SqlDataReader = cmd.ExecuteReader()
        If leer.Read() Then
            MstrNombre = leer(1).ToString()
            MstrActor = leer(2).ToString()
            MstrEdad = leer(3).ToString()
            MstrAparicion = leer(4).ToString()
            MstrPais = leer(5).ToString()
            If Not leer.IsDBNull(6) Then
                Foto = DirectCast(leer("Foto"), Byte())
            Else
                Foto = Nothing ' O asignar un valor por defecto si la foto es opcional.
            End If
            cnx.Close()
            Return True
        Else
            cnx.Close()
            Return False
        End If
    End Function
End Class
