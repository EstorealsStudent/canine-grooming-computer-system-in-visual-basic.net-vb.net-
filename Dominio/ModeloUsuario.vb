Imports AccesoDatos
Imports Común

Public Class ModeloUsuario
    Dim userDao As New UsuarioDAO

    'Atributos'
    Private idUser
    Private loginName
    Private password
    Private firstName
    Private lastName
    Private position
    Private email

    Public Sub New(idUser As Object, loginName As Object, password As Object, firstName As Object, lastName As Object, position As Object, email As Object)
        Me.idUser = idUser
        Me.loginName = loginName
        Me.password = password
        Me.firstName = firstName
        Me.lastName = lastName
        Me.position = position
        Me.email = email
    End Sub

    Public Property IdUser1 As Object
        Get
            Return idUser
        End Get
        Set(value As Object)
            idUser = value
        End Set
    End Property

    Public Property LoginName1 As Object
        Get
            Return loginName
        End Get
        Set(value As Object)
            loginName = value
        End Set
    End Property

    Public Property Password1 As Object
        Get
            Return password
        End Get
        Set(value As Object)
            password = value
        End Set
    End Property

    Public Property FirstName1 As Object
        Get
            Return firstName
        End Get
        Set(value As Object)
            firstName = value
        End Set
    End Property

    Public Property LastName1 As Object
        Get
            Return lastName
        End Get
        Set(value As Object)
            lastName = value
        End Set
    End Property

    Public Property Position1 As Object
        Get
            Return position
        End Get
        Set(value As Object)
            position = value
        End Set
    End Property

    Public Property Email1 As Object
        Get
            Return email
        End Get
        Set(value As Object)
            email = value
        End Set
    End Property

    Public Sub New()
    End Sub


    'Methods'

    Public Function EditUserProfile() As String
        Try
            userDao.EditProfile(idUser, loginName, password, firstName, lastName, email)
            Login(loginName, password) 'Invocamos el metodo login para actualizar los datos del usuario en la interfaz gráfica'
            Return "Tú perfil ha sido actualizado correctamente"
        Catch ex As Exception
            Return ($"Error al abrir la conexión: {ex}")
        End Try
    End Function



    'Recuperar contraseña
    Public Function RecoverPassword(requestingUser As String) As String
        Return userDao.RequestUserPassword(requestingUser)
    End Function
    '

    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function


    Public Function SecurityLogin() As Boolean
        If UsuarioActivo.idUser >= 1 Then
            If userDao.ExistsUser(UsuarioActivo.idUser, UsuarioActivo.Usuario, UsuarioActivo.Contraseña) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function


    Public Function Modelousuariomostrarclientes() As List(Of Clientes)
        Try
            Return userDao.Buscarclientes()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCliente(idCliente As Integer) As Clientes
        Dim cliente As Clientes = userDao.MostrarClientes(idCliente)

        ' Puedes realizar lógica adicional aquí si es necesario

        Return cliente
    End Function

    Public Function Modelousuariomostrargeneros() As List(Of Clientes)
        Try
            Return userDao.ObtenerListaGeneros()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function


End Class
