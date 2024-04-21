Imports System.Data.SqlClient
Imports System.Windows

Public Class AdministrarProductos
    Private MstrID_PRODUCTO As String
    Private MstrNombre As String
    Private MstrPrecio As String
    Private MstrCosto As String
    Private MstrCantidad_Almacenada As String
    Public Property ID_PRODUCTO() As String
        Get
            Return MstrID_PRODUCTO
        End Get
        Set(ByVal value As String)
            MstrID_PRODUCTO = value
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

    Public Property Precio() As String
        Get
            Return MstrPrecio
        End Get
        Set(ByVal value As String)
            MstrPrecio = value
        End Set
    End Property

    Public Property Costo() As String
        Get
            Return MstrCosto
        End Get
        Set(ByVal value As String)
            MstrCosto = value
        End Set
    End Property
    Public Property Cantidad_Almacenada() As String
        Get
            Return MstrCantidad_Almacenada
        End Get
        Set(ByVal value As String)
            MstrCantidad_Almacenada = value
        End Set
    End Property


    'Funcion Alta de prodcutos
    Public Function Alta() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"
        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("dbo.AltaProductoInventario", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID_Producto", MstrID_PRODUCTO)
                    cmd.Parameters.AddWithValue("@Nombre", MstrNombre)
                    cmd.Parameters.AddWithValue("@CantidadAlmacenada", MstrCantidad_Almacenada)
                    cmd.Parameters.AddWithValue("@Precio", MstrPrecio)
                    cmd.Parameters.AddWithValue("@Costo", MstrCosto)
                    cnx.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al registrar el producto:     " & ex.Message)
            Return False
        End Try
    End Function

    'FUNCION PARA BAJA
    Public Function Baja() As Boolean
        Dim cnx As New SqlConnection("Server=matecat\sqlexpress; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.BajaProductoInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@ID_Producto", MstrID_PRODUCTO))
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
        Return True
    End Function

    'FUNCION PARA CONSULTAR PRODUCTO
    Public Function Consulta() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.ConsultarProductoEnInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID_Producto", MstrID_PRODUCTO) ' Asignar el valor del ID_Producto

        Try
            cnx.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then

                MstrNombre = reader("NOMBRE").ToString()
                MstrCantidad_Almacenada = reader("CANTIDAD_ALMACENADA").ToString()
                MstrPrecio = reader("PRECIO").ToString()
                MstrCosto = reader("COSTO").ToString()
                reader.Close()
                Return True
            Else
                reader.Close()
                Return False
            End If
        Catch ex As Exception

            Return False
        Finally
            cnx.Close()
        End Try
    End Function



    'EDITAR PRODUCTO INVENTARIO
    Public Function Editar() As Boolean
        Dim cnx As New SqlConnection("Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;")
        Dim cmd As New SqlCommand("dbo.EditarProductoInventario", cnx)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@ID_Producto", MstrID_PRODUCTO))
        cmd.Parameters.Add(New SqlParameter("@NuevoNombre", MstrNombre))
        cmd.Parameters.Add(New SqlParameter("@NuevaCantidadAlmacenada", MstrCantidad_Almacenada))
        cmd.Parameters.Add(New SqlParameter("@NuevoPrecio", MstrPrecio))
        cmd.Parameters.Add(New SqlParameter("@NuevoCosto", MstrCosto))
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
        Return True
    End Function


End Class
