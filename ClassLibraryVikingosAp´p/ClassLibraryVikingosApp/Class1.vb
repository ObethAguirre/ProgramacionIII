Imports System.Data.SqlClient
Imports System.Windows

Public Class Login
    Private MstrId As String
    Private MstrContraseña As String
    'PROPÍEDADES CLIENTE
    Private MstrId_Cliente As String
    Private MstrContraseña_Cliente As String
    Private MstrNombre_Cliente As String
    Private MstrCorreo As String


    Public Property Id() As String
        Get
            Return MstrId
        End Get
        Set(ByVal value As String)
            MstrId = value
        End Set
    End Property


    Public Property Contraseña() As String
        Get
            Return MstrContraseña
        End Get
        Set(ByVal value As String)
            MstrContraseña = value
        End Set
    End Property

    Public Property Id_Cliente() As String
        Get
            Return MstrId_Cliente
        End Get
        Set(ByVal value As String)
            MstrId_Cliente = value
        End Set
    End Property


    Public Property Contraseña_Cliente() As String
        Get
            Return MstrContraseña_Cliente
        End Get
        Set(ByVal value As String)
            MstrContraseña_Cliente = value
        End Set
    End Property

    Public Property Nombre_Cliente() As String
        Get
            Return MstrNombre_Cliente
        End Get
        Set(ByVal value As String)
            MstrNombre_Cliente = value
        End Set
    End Property


    Public Property Correo() As String
        Get
            Return MstrCorreo
        End Get
        Set(ByVal value As String)
            MstrCorreo = value
        End Set
    End Property

    'Funcion para inicio de sesion del empleado
    Public Function loginEmpleado() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; Database=VikingosBarber; Integrated Security=True;"

        Using cnx As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("dbo.ConsultarEmpleado", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_EMPLEADO", MstrId)

                Try
                    cnx.Open()
                    Dim leer As SqlDataReader = cmd.ExecuteReader()

                    If leer.Read() Then

                        Dim contraseñaAlmacenada As String = leer("CONTRASEÑA").ToString()


                        If contraseñaAlmacenada = MstrContraseña Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al iniciar sesión: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    'Funcion para inicio de sesion del usuario
    Public Function loginUsuario() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; Database=VikingosBarber; Integrated Security=True;"

        Using cnx As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("dbo.ConsultarUsuario", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_CLIENTE", MstrId_Cliente)

                Try
                    cnx.Open()
                    Dim leer As SqlDataReader = cmd.ExecuteReader()

                    If leer.Read() Then

                        Dim contraseñaAlmacenada As String = leer("CONTRASEÑA_CLIENTE").ToString()


                        If contraseñaAlmacenada = MstrContraseña_Cliente Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al iniciar sesión: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    'FUNCION PARA CREAR UN NUEVO USUARIO
    Public Function nuevaCuenta() As Boolean
        Dim connectionString As String = "Server=MATECAT\SQLEXPRESS; database=VikingosBarber; Integrated Security=True;"
        Try
            Using cnx As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("dbo.AltaUsuario", cnx)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ID_Cliente", MstrId_Cliente)
                    cmd.Parameters.AddWithValue("@NombreCliente", MstrNombre_Cliente)
                    cmd.Parameters.AddWithValue("@Correo", MstrCorreo)
                    cmd.Parameters.AddWithValue("@ContraseñaCliente", MstrContraseña_Cliente)
                    cnx.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al registrar la cuenta: " & ex.Message)
            Return False
        End Try
    End Function


End Class
