
Imports AccesoDatos
Imports Común

Public Class ModeloServicio

    Dim userDao As New UsuarioDAO

    Private idservicio
    Private TipoServicio
    Private Nombre
    Private Costo

    Public Sub New(tipoServicio As Object, nombre As Object, costo As Object)
        Me.TipoServicio1 = tipoServicio
        Me.Nombre1 = nombre
        Me.Costo1 = costo
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(idservicio As Object, tipoServicio As Object, nombre As Object, costo As Object)
        Me.idservicio = idservicio
        Me.TipoServicio = tipoServicio
        Me.Nombre = nombre
        Me.Costo = costo
    End Sub

    Public Property TipoServicio1 As Object
        Get
            Return TipoServicio
        End Get
        Set(value As Object)
            TipoServicio = value
        End Set
    End Property

    Public Property Nombre1 As Object
        Get
            Return Nombre
        End Get
        Set(value As Object)
            Nombre = value
        End Set
    End Property

    Public Property Costo1 As Object
        Get
            Return Costo
        End Get
        Set(value As Object)
            Costo = value
        End Set
    End Property

    Public Property Idservicio1 As Object
        Get
            Return idservicio
        End Get
        Set(value As Object)
            idservicio = value
        End Set
    End Property

    Public Function ModelomostrarTIPOservicio() As List(Of Servicios)
        Try
            Return userDao.LlenarTipoServicio()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function ModeloinsertarServicio() As String
        Try
            userDao.InsertarServicio(TipoServicio, Nombre, Costo)
            Return "Registro exitoso."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se Registró Corrrectamente. Error: "
        End Try

    End Function

    Public Function Modelousuariomostrarservicios() As List(Of Servicios)
        Try
            Return userDao.Buscarservicios()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function ObtenerServicio(idservicio As Integer) As Servicios
        Dim cliente As Servicios = userDao.MostrarServicio(idservicio)

        ' Puedes realizar lógica adicional aquí si es necesario

        Return cliente
    End Function

    Public Function ModeloEditarServicio() As String
        Try
            userDao.Editarservicio(idservicio, TipoServicio, Nombre, Costo)
            Return "Servicio Editado Corrrectamente."
        Catch ex As Exception

            Return "error"
        End Try
    End Function



End Class
