
Imports AccesoDatos
Imports Común

Public Class ModelosMascotas
    Dim userDao As New UsuarioDAO

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

    Public Sub New(iDCliente As Object, iDRMascota As Object, iDSeMascota As Object, nombre As Object, peso As Object, color As Object, esvacunado As Object, vacuna As Object, vigVacuna As Object, foto As Object, falleció As Object)
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
        Me.Falleció1 = falleció
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

    Public Property IDMascota1 As Object
        Get
            Return IDMascota
        End Get
        Set(value As Object)
            IDMascota = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(iDMascota As Object, IDCliente As Object, iDRMascota As Object, iDSeMascota As Object, nombre As Object, peso As Object, color As Object, esvacunado As Object, vacuna As Object, vigVacuna As Object, foto As Object, falleció As Object)
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
            Return userDao.obtenerlistipomascota()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function


    Public Function modelousuariomostrarSEXOSMASCOTAS() As List(Of Mascotas)
        Try
            Return userDao.obtenerlistsexomascota()
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modelousuariomostrarRAZAMASCOTAS(Razaseleccionada As Integer) As List(Of Mascotas)
        Try
            Return userDao.obtenerrazamascotas(Razaseleccionada)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modelousuariomostrarEDITARMASCOTAS(Razaseleccionada As Integer) As List(Of Mascotas)
        Try
            Return userDao.obtenerrazaEDITARmascotas(Razaseleccionada)
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            Return Nothing
        End Try
    End Function

    Public Function modeloinsertarMascotas() As String
        Try
            userDao.insertarmascotas(IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, falleció)
            Return "Registro exitoso."
        Catch ex As Exception
            ' Capturar la excepción y retornar un mensaje de error
            Return "No se Registró Corrrectamente. Error: "
        End Try

    End Function

    Public Function EditarMascotasModelo() As String
        Try
            userDao.Editarrmascotas(IDMascota, IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, falleció)
            Return "Mascota Editada Corrrectamente."
        Catch ex As Exception

            Return "error"
        End Try
    End Function



End Class
