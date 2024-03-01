
Imports AccesoDatos
Imports Común

Public Class ModelosMascotas
    Dim userDao As New UsuarioDAO

    Private IDUsuarioCrea
    Private IDUsuarioModifica
    Private IDMascota
    Private IDCliente
    Private IDRMascota
    Private IDSeMascota
    Private Nombre
    Private Peso
    Private Color
    Private Esvacunado
    Private Vacuna
    Private VigVacuna
    Private Foto
    Private falleció

    'para usar en razamascota
    Private idRmascotas
    Private idTMascota
    Private nombreraza

    Public Sub New(iDCliente As Object, iDRMascota As Object, iDSeMascota As Object, nombre As Object, peso As Object, color As Object, esvacunado As Object, vacuna As Object, vigVacuna As Object, foto As Object, IDUsuarioCrea As Object)
        Me.IDCliente1 = iDCliente
        Me.IDRMascota1 = iDRMascota
        Me.IDSeMascota1 = iDSeMascota
        Me.Nombre1 = nombre
        Me.Peso1 = peso
        Me.Color1 = color
        Me.Esvacunado1 = esvacunado
        Me.Vacuna1 = vacuna
        Me.VigVacuna1 = vigVacuna
        Me.Foto1 = foto
        Me.IDUsuarioCrea1 = IDUsuarioCrea
    End Sub

    Public Property IDCliente1 As Object
        Get
            Return IDCliente
        End Get
        Set(value As Object)
            IDCliente = value
        End Set
    End Property

    Public Property IDRMascota1 As Object
        Get
            Return IDRMascota
        End Get
        Set(value As Object)
            IDRMascota = value
        End Set
    End Property

    Public Property IDSeMascota1 As Object
        Get
            Return IDSeMascota
        End Get
        Set(value As Object)
            IDSeMascota = value
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

    Public Property Peso1 As Object
        Get
            Return Peso
        End Get
        Set(value As Object)
            Peso = value
        End Set
    End Property

    Public Property Color1 As Object
        Get
            Return Color
        End Get
        Set(value As Object)
            Color = value
        End Set
    End Property

    Public Property Esvacunado1 As Object
        Get
            Return Esvacunado
        End Get
        Set(value As Object)
            Esvacunado = value
        End Set
    End Property

    Public Property Vacuna1 As Object
        Get
            Return Vacuna
        End Get
        Set(value As Object)
            Vacuna = value
        End Set
    End Property

    Public Property VigVacuna1 As Object
        Get
            Return VigVacuna
        End Get
        Set(value As Object)
            VigVacuna = value
        End Set
    End Property

    Public Property Foto1 As Object
        Get
            Return Foto
        End Get
        Set(value As Object)
            Foto = value
        End Set
    End Property

    Public Property Falleció1 As Object
        Get
            Return falleció
        End Get
        Set(value As Object)
            falleció = value
        End Set
    End Property

    Public Property IdTMascota1 As Object
        Get
            Return idTMascota
        End Get
        Set(value As Object)
            idTMascota = value
        End Set
    End Property

    Public Property Nombreraza1 As Object
        Get
            Return nombreraza
        End Get
        Set(value As Object)
            nombreraza = value
        End Set
    End Property

    Public Property IdRmascotas1 As Object
        Get
            Return idRmascotas
        End Get
        Set(value As Object)
            idRmascotas = value
        End Set
    End Property

    Public Property IDMascota1 As Object
        Get
            Return IDMascota
        End Get
        Set(value As Object)
            IDMascota = value
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


    Public Sub New(iDMascota As Object, IDCliente As Object, iDRMascota As Object, iDSeMascota As Object, nombre As Object, peso As Object, color As Object, esvacunado As Object, vacuna As Object, vigVacuna As Object, foto As Object, falleció As Object, IDUsuarioModifica As Object)
        Me.IDMascota = iDMascota
        Me.IDCliente = IDCliente
        Me.IDRMascota = iDRMascota
        Me.IDSeMascota = iDSeMascota
        Me.Nombre = nombre
        Me.Peso = peso
        Me.Color = color
        Me.Esvacunado = esvacunado
        Me.Vacuna = vacuna
        Me.VigVacuna = vigVacuna
        Me.Foto = foto
        Me.falleció = falleció
        Me.IDUsuarioModifica = IDUsuarioModifica
    End Sub

    Public Sub New(idTMascota As Object, nombreraza As Object, IDUsuarioCrea As Object)
        Me.idTMascota = idTMascota
        Me.nombreraza = nombreraza
        Me.IDUsuarioCrea = IDUsuarioCrea
    End Sub

    Public Sub New(idRmascotas As Object, idTMascota As Object, nombreraza As Object, IDUsuarioModifica As Object)
        Me.idRmascotas = idRmascotas
        Me.idTMascota = idTMascota
        Me.nombreraza = nombreraza
        Me.IDUsuarioModifica = IDUsuarioModifica
    End Sub

    Public Function modelousuariomostrarmascotas(idCliente As Integer) As DataTable
        Try
            Return userDao.CargarMascotasClientes(idCliente)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function


    Public Function ModelomostrarMascotasFRM(idmascotas As Integer) As Mascotas
        Try
            Return userDao.MostrarMascotas(idmascotas)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try

    End Function

    Public Function modelousuariomostrarTIPOSMASCOTAS() As List(Of Mascotas)
        Try
            Return userDao.Obtenerlistipomascota()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function


    Public Function modelousuariomostrarSEXOSMASCOTAS() As List(Of Mascotas)
        Try
            Return userDao.Obtenerlistsexomascota()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modelousuariomostrarRAZAMASCOTAS(Razaseleccionada As Integer) As List(Of Mascotas)
        Try
            Return userDao.Obtenerrazamascotas(Razaseleccionada)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modelousuariomostrarEDITARMASCOTAS(Razaseleccionada As Integer) As List(Of Mascotas)
        Try
            Return userDao.ObtenerrazaEDITARmascotas(Razaseleccionada)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modeloinsertarMascotas() As String
        Try
            userDao.Insertarmascotas(IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, IDUsuarioCrea)
            Return "Registro exitoso."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se Registró Corrrectamente. "
        End Try

    End Function

    Public Function EditarMascotasModelo() As String
        Try
            userDao.Editarrmascotas(IDMascota, IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, falleció, IDUsuarioModifica)
            Return "Mascota Editada Corrrectamente."
        Catch ex As Exception

            Return "error"
        End Try
    End Function

    Public Function Modelouusuariocargarmascotasparacitasclientes(idcliente) As List(Of Mascotas)
        Try
            Return userDao.Mascotasparacitasdeclientes(idcliente)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function


    'registrar tipo de mascota
    Public Function modeloinsertarrazamascotas() As String
        Try
            userDao.InsertarRazaMascota(idTMascota, nombreraza, IDUsuarioCrea)
            Return "Registro exitoso."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se Registró Corrrectamente. "
        End Try

    End Function

    Public Function ModelousuariomostrarRazaytipoMascotas() As List(Of Mascotas)
        Try
            Return userDao.BuscarRazayTipoDeMascotas()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function



    Public Function ModelomostrarRazayTipodeMascotasFRM(idrmasccota As Integer) As Mascotas
        Try
            Return userDao.MostrarRaza(idrmasccota)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function ModeloEditarRazayTipoMascota() As String
        Try
            userDao.EditarRaza(idRmascotas, idTMascota, nombreraza, IDUsuarioModifica)
            Return "Se acutalizó correctamente."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se acutalizó Corrrectamente. "
        End Try
    End Function




End Class
