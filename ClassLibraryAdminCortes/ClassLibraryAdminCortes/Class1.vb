Imports System.Data.SqlClient
Imports System.IO

Public Class AdministrarCortes
    Private MstrID_CORTE As String
    Private MstrNOMBRE As String
    Private MstrPRECIO As String
    Private MstrIMG_CORTE As Byte()

    Public Property ID_CORTE() As String
        Get
            Return MstrID_CORTE
        End Get
        Set(ByVal value As String)
            MstrID_CORTE = value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return MstrNOMBRE
        End Get
        Set(ByVal value As String)
            MstrNOMBRE = value
        End Set
    End Property

    Public Property PRECIO() As String
        Get
            Return MstrPRECIO
        End Get
        Set(ByVal value As String)
            MstrPRECIO = value
        End Set
    End Property

    Public Property IMG_CORTE() As Byte()
        Get
            Return MstrIMG_CORTE
        End Get
        Set(ByVal value As Byte())
            MstrIMG_CORTE = value
        End Set
    End Property
    Public Sub SetFotoFromPath(rutaImagen As String)
        MstrIMG_CORTE = File.ReadAllBytes(rutaImagen)
    End Sub

    'ALTA
    Public Function Alta() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.AgregarCorteInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@ID_Corte", MstrID_CORTE))
        cmd.Parameters.Add(New SqlParameter("@Nombre", MstrNOMBRE))
        cmd.Parameters.Add(New SqlParameter("@Precio", MstrPRECIO))
        cmd.Parameters.Add(New SqlParameter("@ImgCorte", MstrIMG_CORTE))
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            cnx.Close()
        End Try
    End Function

    'ACTUALIZA
    Public Function Actualiza() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.EditarCorteInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@ID_Corte", MstrID_CORTE))
        cmd.Parameters.Add(New SqlParameter("@NuevoNombre", MstrNOMBRE))
        cmd.Parameters.Add(New SqlParameter("@NuevoPrecio", MstrPRECIO))
        cmd.Parameters.Add(New SqlParameter("@NuevaImgCorte", MstrIMG_CORTE))
        cnx.Open()
        cmd.ExecuteScalar()
        cnx.Close()
        Return True
    End Function

    'FUNCION PARA BAJA
    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.BajaCorteInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@ID_Corte", MstrID_CORTE))
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
        Return True
    End Function

    'FUNCION PARA CONSULTAR PRODUCTO
    Public Function Consulta() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ConsultarCorteInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_Corte", MstrID_CORTE)

        Try
            cnx.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MstrNOMBRE = reader("NOMBRE").ToString()
                MstrPRECIO = reader("PRECIO").ToString()

                ' Verificar si el campo IMG_CORTE es nulo antes de asignarlo
                If Not reader.IsDBNull(3) Then
                    MstrIMG_CORTE = DirectCast(reader("IMG_CORTE"), Byte())
                Else
                    MstrIMG_CORTE = Nothing
                End If

                reader.Close()
                Return True
            Else
                reader.Close()
                Return False
            End If
        Catch ex As Exception
            ' Manejo de errores
            Return False
        Finally
            cnx.Close()
        End Try
    End Function


End Class
