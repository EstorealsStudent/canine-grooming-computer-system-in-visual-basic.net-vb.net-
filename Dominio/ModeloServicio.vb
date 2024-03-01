
Imports AccesoDatos
Imports Común

Public Class ModeloServicio

    Dim userDao As New UsuarioDAO

    Private IDUsuarioCrea
    Private IDUsuarioModifica
    Private IdCitaParaServicios
    Private idservicio
    Private TipoServicio
    Private Nombre
    Private Costo
    Private IdDetallesServicios

    Public Sub New(tipoServicio As Object, nombre As Object, costo As Object, IDUsuarioCrea As Object)
        Me.TipoServicio1 = tipoServicio
        Me.Nombre1 = nombre
        Me.Costo1 = costo
        Me.IDUsuarioCrea1 = IDUsuarioCrea
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(idservicio As Object, tipoServicio As Object, nombre As Object, costo As Object, IDUsuarioModifica As Object)
        Me.idservicio = idservicio
        Me.TipoServicio = tipoServicio
        Me.Nombre = nombre
        Me.Costo = costo
        Me.IDUsuarioModifica = IDUsuarioModifica
    End Sub

    Public Sub New(idCitaParaServicios As Object, idservicio As Object, IDUsuarioCrea As Object)
        Me.IdCitaParaServicios = idCitaParaServicios
        Me.idservicio = idservicio
        Me.IDUsuarioCrea = IDUsuarioCrea
    End Sub

    Public Sub New(idDetallesServicios As Object, IDUsuarioModifica As Object)
        Me.IdDetallesServicios = idDetallesServicios
        Me.IDUsuarioModifica = IDUsuarioModifica
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

    Public Property IdCitaParaServicios1 As Object
        Get
            Return IdCitaParaServicios
        End Get
        Set(value As Object)
            IdCitaParaServicios = value
        End Set
    End Property

    Public Property IdDetallesServicios1 As Object
        Get
            Return IdDetallesServicios
        End Get
        Set(value As Object)
            IdDetallesServicios = value
        End Set
    End Property

    Public Property IDUsuarioCrea1 As Object
        Get
            Return IDUsuarioCrea
        End Get
        Set(value As Object)
            IDUsuarioCrea = value
        End Set
    End Property

    Public Property IDUsuarioModifica1 As Object
        Get
            Return IDUsuarioModifica
        End Get
        Set(value As Object)
            IDUsuarioModifica = value
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
            userDao.InsertarServicio(TipoServicio, Nombre, Costo, IDUsuarioCrea)
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
            userDao.Editarservicio(idservicio, TipoServicio, Nombre, Costo, IDUsuarioModifica)
            Return "Servicio Editado Corrrectamente."
        Catch ex As Exception

            Return "error"
        End Try
    End Function

    Public Function ModeloUsuariomostrarServiciodependiendoDeTipoCitas(IdTipoServicio As Integer) As List(Of Servicios)
        Try
            Return userDao.ObtenerServiciosdeTIPOS(IdTipoServicio)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCostoServicioCita(idservicio As Integer) As Servicios
        Dim CostoServicio As Servicios = userDao.MostrarCostoServicio(idservicio)
        ' Puedes realizar lógica adicional aquí si es necesario

        Return CostoServicio
    End Function


    Public Function ModeloInsertarServiciosParaCitas() As String
        Try
            userDao.InsertarDetallesCitasServicios(IdCitaParaServicios, idservicio, IDUsuarioCrea)
            Return "Servicio Añadido."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se añadió Corrrectamente."
        End Try

    End Function

    Public Function ModeloMostrarServiciosDetallesCitas(IdCita As Integer) As DataTable
        Try
            Return userDao.ObtenerServiciosDetallesCitas(IdCita)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function

    Public Function ObtenerCostoTotal(IdCita As Integer) As Servicios
        Dim servicio As Servicios = userDao.MostrarCostototal(IdCita)

        ' Puedes realizar lógica adicional aquí si es necesario

        Return servicio
    End Function

    Public Function ModeloEliminarDetalleCita() As String
        Try
            userDao.EliminarServicio(IdDetallesServicios, IDUsuarioModifica)
            Return "Eliminado con exito."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se eliminó Corrrectamente."
        End Try

    End Function

End Class
