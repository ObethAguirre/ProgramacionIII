Imports System.Data.SqlClient
Public Class Socio
    Private MstrId As String
    Private MstrNombre As String
    Private MstrApellido As String
    Private MstrDireccion As String
    Private MstrTelefono As String

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

    Public Property Apellido() As String
        Get
            Return MstrApellido
        End Get
        Set(ByVal value As String)
            MstrApellido = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return MstrDireccion
        End Get
        Set(ByVal value As String)
            MstrDireccion = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return MstrTelefono
        End Get
        Set(ByVal value As String)
            MstrTelefono = value
        End Set
    End Property

    Public Function SocioAlta() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocAlta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function SocioBaja() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocBaja", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function SocioActualiza() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocActualiza", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@Apellido", MstrApellido))
        cmd.Parameters.Add(New SqlParameter("@Direccion", MstrDireccion))
        cmd.Parameters.Add(New SqlParameter("@Telefono", MstrTelefono))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    Public Function SocioConsulta() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=socio; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.SocConsulta", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Id", MstrId))
        cnx.Open()
        Dim leer As SqlDataReader = cmd.ExecuteReader()
        If leer.Read() Then
            MstrNombre = leer(1).ToString()
            MstrApellido = leer(2).ToString()
            MstrDireccion = leer(3).ToString()
            MstrTelefono = leer(4).ToString()
            cnx.Close()
            Return True
        Else
            cnx.Close()
            Return False
        End If
    End Function
End Class

