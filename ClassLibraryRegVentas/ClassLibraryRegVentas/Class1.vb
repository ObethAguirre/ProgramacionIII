Imports System.Data.SqlClient
Imports System.Windows

Public Class Registro

    Private mstrID_VENTA As Integer
    Private mstrID_PRODUCTO As Integer
    Private mstrID_CLIENTE As Integer
    Private mstrNOMBRE As String
    Private mstrCANTIDAD_DESEADA As Integer
    Private mstrPRECIO As Integer
    Private mstrFECHA As String

    Public Property ID_VENTA() As Integer
        Get
            Return mstrID_VENTA
        End Get
        Set(ByVal value As Integer)
            mstrID_VENTA = value
        End Set
    End Property

    Public Property ID_PRODUCTO() As Integer
        Get
            Return mstrID_PRODUCTO
        End Get
        Set(ByVal value As Integer)
            mstrID_PRODUCTO = value
        End Set
    End Property

    Public Property ID_CLIENTE() As Integer
        Get
            Return mstrID_CLIENTE
        End Get
        Set(ByVal value As Integer)
            mstrID_CLIENTE = value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return mstrNOMBRE
        End Get
        Set(ByVal value As String)
            mstrNOMBRE = value
        End Set
    End Property

    Public Property CANTIDAD_DESEADA() As Integer
        Get
            Return mstrCANTIDAD_DESEADA
        End Get
        Set(ByVal value As Integer)
            mstrCANTIDAD_DESEADA = value
        End Set
    End Property

    Public Property PRECIO() As Integer
        Get
            Return mstrPRECIO
        End Get
        Set(ByVal value As Integer)
            mstrPRECIO = value
        End Set
    End Property

    Public Property FECHA() As String
        Get
            Return mstrFECHA
        End Get
        Set(ByVal value As String)
            mstrFECHA = value
        End Set
    End Property


    Public Function REG() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"
        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("dbo.AltaVentas_Producto", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@ID_Venta", mstrID_VENTA))
                    cmd.Parameters.Add(New SqlParameter("@ID_Producto", mstrID_PRODUCTO))
                    cmd.Parameters.Add(New SqlParameter("@ID_CLIENTE", mstrID_CLIENTE))
                    cmd.Parameters.Add(New SqlParameter("@Nombre", mstrNOMBRE))
                    cmd.Parameters.Add(New SqlParameter("@Cantidad_Deseada", mstrCANTIDAD_DESEADA))
                    cmd.Parameters.Add(New SqlParameter("@Precio", mstrPRECIO))
                    cmd.Parameters.Add(New SqlParameter("@Fecha", mstrFECHA))
                    cnx.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al registrar la venta: " & ex.Message)
            Return False
        End Try
    End Function

End Class

