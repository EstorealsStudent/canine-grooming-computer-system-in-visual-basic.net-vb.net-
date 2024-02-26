Imports AccesoDatos
Imports Común
Public Class ModeloCitas
    Dim userDao As New UsuarioDAO

    Private IDUsuarioCrea
    Private IDUsuarioModifica
    Private idMascota
    Private idhorario
    Private idecita
    Private idcita
    Private fechacita
    Private descripcion


    Public Sub New(idMascota As Object, idhorario As Object, idecita As Object, fechacita As Object, descripcion As Object, IDUsuarioCrea As Object)
        Me.idMascota = idMascota
        Me.idhorario = idhorario
        Me.idecita = idecita
        Me.fechacita = fechacita
        Me.descripcion = descripcion
        Me.IDUsuarioCrea = IDUsuarioCrea
    End Sub

    Public Property IdMascota1 As Object
        Get
            Return idMascota
        End Get
        Set(value As Object)
            idMascota = value
        End Set
    End Property

    Public Property Idhorario1 As Object
        Get
            Return idhorario
        End Get
        Set(value As Object)
            idhorario = value
        End Set
    End Property

    Public Property Idecita1 As Object
        Get
            Return idecita
        End Get
        Set(value As Object)
            idecita = value
        End Set
    End Property

    Public Property Fechacita1 As Object
        Get
            Return fechacita
        End Get
        Set(value As Object)
            fechacita = value
        End Set
    End Property

    Public Property Descripcion1 As Object
        Get
            Return descripcion
        End Get
        Set(value As Object)
            descripcion = value
        End Set
    End Property

    Public Property Idcita1 As Object
        Get
            Return idcita
        End Get
        Set(value As Object)
            idcita = value
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

    Public Sub New()

    End Sub

    Public Sub New(idecita As Object, idcita As Object, IDUsuarioModifica As Object)
        Me.idecita = idecita
        Me.idcita = idcita
        Me.IDUsuarioModifica = IDUsuarioModifica
    End Sub

    Public Sub New(idcita As Object, idhorario As Object, fechacita As Object, descripcion As Object, IDUsuarioModifica As Object)
        Me.idhorario = idhorario
        Me.idcita = idcita
        Me.fechacita = fechacita
        Me.descripcion = descripcion
        Me.IDUsuarioModifica = IDUsuarioModifica
    End Sub

    Public Function insertarcitas() As String
        Try
            userDao.InsertarCita(idMascota, idhorario, idecita, fechacita, descripcion, IDUsuarioCrea)
            Return "Cita registrada corrrectamente."
        Catch ex As Exception

            Return "Ya existe una cita pendiente ó confirmada en esta fecha y hora."
        End Try
    End Function

    Public Function modelomosostrarHorariocompleto() As List(Of Citas)
        Try
            Return userDao.obtenerHORARIOCITAS()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    'todas las citas
    Public Function modelousuariotraercitasdelprincipio(fecha As Date) As DataTable
        Try
            Return userDao.cargarcitasprimerainstancia(fecha)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function
    'citas pendientes
    Public Function modelocitaspendientes(fecha As Date) As DataTable
        Try
            Return userDao.cargarcitaspendientes(fecha)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function

    'citas confirmadas
    Public Function modelocitasconfirmadas(fecha As Date) As DataTable
        Try
            Return userDao.cargarcitasconfirmadas(fecha)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function

    'citas completadas
    Public Function modelocitascompletadas(fecha As Date) As DataTable
        Try
            Return userDao.cargarcitascompletadas(fecha)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function
    'citas canceladas
    Public Function modelocitascanceladas(fecha As Date) As DataTable
        Try
            Return userDao.cargarcitascanceladas(fecha)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function
    'mostrar la cita
    Public Function obtenercita(idcita As Integer) As Citas
        Try
            Dim cita As Citas = userDao.mostrarcita(idcita)

            ' Puedes realizar lógica adicional aquí si es necesario

            Return cita
        Catch
            Return Nothing
        End Try
    End Function

    Public Function ModeloMostrarEstadoCitaCompleto() As List(Of Citas)
        Try
            Return userDao.LlenarEstadoCita()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function EditarEstadoCita() As String
        Try
            userDao.EditarEstadoCita(idcita, idecita, IDUsuarioModifica)
            Return Nothing
        Catch ex As Exception

            Return Nothing
        End Try
    End Function

    Public Function EditarCitas() As String
        Try
            userDao.EditarCita(idcita, idhorario, fechacita, descripcion, IDUsuarioModifica)
            Return "Cita actualizada Corrrectamente."
        Catch ex As Exception

            Return "No se actualizó Corrrectamente."
        End Try
    End Function

    Public Function ModeloHistorialCitasMascota(idMascota As Integer) As DataTable
        Try
            Return userDao.CargarHistorialCitas(idMascota)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function


End Class
